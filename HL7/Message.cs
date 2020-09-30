using System.Collections.Generic;
using System.IO;

namespace HL7
{
    public class Message
    {
        public string FileFullPath { get; set; } = "";
        public List<Segment> Segments { get; set; } = null;
        public string ErrorMessage { get; set; } = "";

        public Message(string fileFullPath)
        {
            if (!File.Exists(fileFullPath))
            {
                ErrorMessage = "File not found.";
                return;
            }

            if (!IsFileAvailable(fileFullPath))
            {
                ErrorMessage = "File in use by another process.";
                return;
            }

            FileFullPath = fileFullPath;
            Segments = new List<Segment>(File.ReadAllLines(fileFullPath).Length);
            PopulateSegments();
        }

        private void PopulateSegments()
        {
            string lineText = "";
            using (StreamReader sr = new StreamReader(FileFullPath))
            {
                do
                {
                    lineText = sr.ReadLine();
                    if (lineText.Trim() != "") Segments.Add(new Segment(lineText));
                }
                while (!sr.EndOfStream);
            }
        }

        /// <summary>
        /// Return the value of an HL7 data element. You will need to supply the segment name and location.
        /// You can either get the sub-component, or the entire element.
        /// Example: MSH 8.3 or PID 4
        /// </summary>
        /// <param name="segSearch">Segment and location.</param>
        /// <returns>string</returns>
        public string GetSegmentValue(string segSearch)
        {
            if (Segments == null || Segments.Count == 0) return "";

            Segment seg = null;

            try 
            {
                seg = Segments.Find(s => s.SegmentCode == segSearch.Substring(0, 3));

                // If segment is not found, or it doesn't have any data elements...
                if (seg == null || (seg.DataElements == null || seg.DataElements.Count == 0)) return "";

                int elementSequence = 0;
                int componentSequence = 0;

                if (segSearch.Contains("."))
                {
                    // Both an element and component are specified. Parse both
                    // sides of the decimal <element index>.<component index>
                    elementSequence = int.Parse(segSearch.Split(char.Parse(" "))[1].Split(char.Parse("."))[0]);
                    componentSequence = int.Parse(segSearch.Split(char.Parse(" "))[1].Split(char.Parse("."))[1]);
                }
                else
                    elementSequence = int.Parse(segSearch.Split(char.Parse(" "))[1]);

                DataElement dataElement = null;

                if (seg.SegmentCode == "MSH") // This is a special case.
                    dataElement = seg.DataElements.Find(x => x.IndexLocation + 1 == elementSequence);
                else
                    dataElement = seg.DataElements.Find(x => x.IndexLocation == elementSequence);

                if (dataElement == null) return ""; // This element has not been configured.

                if (componentSequence > 0 && dataElement.Components != null)
                {
                    Component c = dataElement.Components.Find(x => x.IndexLocation == componentSequence);
                    return (c != null ? c.DataValue : "");
                }
                else
                    return dataElement.DataValue;
            }
            catch 
            {
                return "";
            }            
        }

        /// <summary>
        /// Changes the value of an HL7 data element, or component.
        /// You can either change the sub-component, or the entire element.
        /// Example: MSH 8.3 or PID 4
        /// </summary>
        /// <param name="segSearch">Segment and location.</param>
        /// <param name="newValue">New value of the data element, or component.</param>
        public void SetSegmentValue(string segSearch, string newValue)
        {
            if (Segments == null || Segments.Count == 0) return;

            Segment seg = null;            

            try 
            {
                seg = Segments.Find(s => s.SegmentCode == segSearch.Substring(0, 3));

                // If segment is not found, or it doesn't have any data elements...
                if (seg == null || (seg.DataElements == null || seg.DataElements.Count == 0)) return;

                int elementSequence = 0;
                int componentSequence = 0;

                if (segSearch.Contains("."))
                {
                    // Both an element and component are specified. Parse both
                    // sides of the decimal <element index>.<component index>
                    elementSequence = int.Parse(segSearch.Split(char.Parse(" "))[1].Split(char.Parse("."))[0]);
                    componentSequence = int.Parse(segSearch.Split(char.Parse(" "))[1].Split(char.Parse("."))[1]);
                }
                else
                    elementSequence = int.Parse(segSearch.Split(char.Parse(" "))[1]);

                DataElement dataElement = null;

                if (seg.SegmentCode == "MSH") // This is a special case.
                    dataElement = seg.DataElements.Find(x => x.IndexLocation + 1 == elementSequence);
                else
                    dataElement = seg.DataElements.Find(x => x.IndexLocation == elementSequence);

                if (dataElement == null) return; // This element has not been configured.

                if (componentSequence > 0 && dataElement.Components != null)
                {
                    Component c = dataElement.Components.Find(x => x.IndexLocation == componentSequence);
                    if (c != null) c.DataValue = newValue;
                }
                else
                    dataElement.DataValue = newValue;
            }
            catch 
            {}
        }

        /// <summary>
        /// Saves the HL7 file to disk. If no directory is specified, the HL7 file will be saved in the same\n
        /// directory as the original. If no filename is specified, the original HL7 file will be overwritten.
        /// </summary>
        /// <param name="newFilename">If a new file name is not provided, the current HL7 will be overwritten.</param>
        public void Save(string newFilename = "")
        {
            // Write each segment out to a file by iterating through all
            // the data elements and components. Doing it this way rather
            // than using the "FullSegment" property will guarantee we get
            // any modified, or added data.

            if (newFilename == "") // Use the original file name.
                newFilename = FileFullPath;
            else
            {
                if (newFilename.Contains("\\"))
                    // Directory has been included.
                    FileFullPath = newFilename;
                else
                    // No directory was specified. Just use the original HL7 file location.
                    newFilename = FileFullPath.Substring(FileFullPath.LastIndexOf("\\") + 1) + newFilename;
            }

            using (StreamWriter sw = new StreamWriter(newFilename, false))
            {
                string textOut = ""; // The resulting segment in full.

                // Assuming we have configured HL7 segments, elements, and components:
                // 1. Write each segment code.
                // 2. Write each segments data elements.
                // 3. Write each data element's components.
                foreach (Segment seg in Segments)
                {
                    textOut = "";

                    if (seg.DataElements != null && seg.DataElements.Count > 0)
                    {
                        textOut = seg.SegmentCode + "|";

                        foreach (DataElement element in seg.DataElements)
                        {
                            if (element.Components != null && element.Components.Count > 0)
                            {
                                foreach (Component c in element.Components) textOut += c.DataValue + "^";

                                // The last separator is actually the first separator of the next data element.
                                textOut = textOut.Substring(0, textOut.Length - 1) + "|";
                            }
                            else
                                // This data element does not have any components configured. Just write what we have.
                                textOut += element.DataValue + "|";
                        }
                    }
                    else
                    {
                        // No data elements have been configured. So we don't lose data when
                        // writing the HL7, just use the segment text from the original HL7 file.
                        textOut += seg.FullSegment;
                    }

                    sw.WriteLine(textOut);
                }
            }

            // "Re-read" the updated segments. Reinitialize the segments so it will resize.
            Segments = new List<Segment>(File.ReadAllLines(newFilename).Length);
            PopulateSegments();
        }

        public void ApplySorting()
        {
            if (Segments == null || Segments.Count == 0) return; // Nothing to "Sort"?    
            Segments.Sort((x, y) => x.Sequence.CompareTo(y.Sequence));
        }

        private static bool IsFileAvailable(string fileFullPath)
        {
            try
            {
                var s = File.Open(fileFullPath, FileMode.Append, FileAccess.Write, FileShare.None);
                s.Close();
                s.Dispose();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}