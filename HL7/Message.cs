using System.Collections.Generic;
using System.IO;

namespace HL7
{
    public struct NestedSegment
    {
        public NestedSegment(HL7.Segment x, List<HL7.Segment> y)
        {
            ParentSegment = x;
            SegmentList = y;
        }

        public Segment ParentSegment { get; set; }
        public List<Segment> SegmentList { get; set; }

        public override string ToString() => $"({ParentSegment.SegmentCode}, {SegmentList.Count})";
    }

    public class Message
    {
        public string FileFullPath { get; set; } = "";
        public List<Segment> Segments { get; set; } = null;        

        public Message()
        {
            FileFullPath = "";
            Segments = new List<Segment>();
        }

        public Message(string fileFullPath)
        {
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
        /// Return a list of Nested Segments by supplying the Parent Segment Code.
        /// Passing OBR will nest every child segment until another OBR is encountered.
        /// </summary>
        /// <param name="segmentCode">3 character Segment ID (PID, EVN, OBR, etc...)</param>
        /// <returns>List of parent segments with their own child semgents.</returns>
        public List<NestedSegment> GetNestedSegments(string segmentCode)
        {
            var list = new List<NestedSegment>();
            var nestedSeg = new NestedSegment();

            // Nesting begins when we encounter the specified parent segment.
            bool startNesting = false;

            Segment[] segs = Segments.ToArray();

            for (int n = 0; n < segs.Length; n++)
            {
                // If this segment is to be the parent...
                if (segs[n].SegmentCode == segmentCode)
                {
                    startNesting = true;
                    nestedSeg = new NestedSegment(segs[n], new List<Segment>());
                    continue;
                }
                else
                {
                    // If we're in the nesting process, add this segment
                    // to the parent segment list.
                    if (startNesting)
                        nestedSeg.SegmentList.Add(segs[n]);
                    else
                        continue;

                    // If we're not at the end of the array or the next
                    // segment is the actual parent semgent, then add
                    // the full nested item to the return list.
                    if (n + 1 >= segs.Length || segs[n + 1].SegmentCode == segmentCode) list.Add(nestedSeg);
                }
            }

            return list;
        }

        public List<Segment> GetSegments(string segmentCode)
        {
            return Segments.FindAll(x => x.SegmentCode == segmentCode);
        }

        public Segment GetSegment(string segmentCode)
        {
            return Segments.Find(x => x.SegmentCode == segmentCode);
        }

        /// <summary>
        /// Returns a particular component of a Data Element.
        /// </summary>
        /// <param name="segSearch">Semgment ID (PID, OBR, PV1, etc...)</param>
        /// <param name="elementName">Account Number, Patient Idenifier List, etc...</param>
        /// <param name="indexLocation">1-based index location of the component.</param>
        /// <returns>Data Element Component Value</returns>
        public string GetSegmentValue(string segSearch, string elementName, int indexLocation)
        {
            if (Segments == null || Segments.Count == 0) return "";

            Segment seg = null;
            DataElement dataElement = null;

            seg = Segments.Find(s => s.SegmentCode == segSearch);

            dataElement = seg.DataElements.Find(x => x.ElementCode == elementName);

            string[] splitter = dataElement.DataValue.Split(char.Parse("^"));

            return splitter[indexLocation - 1];
        }

        /// <summary>
        /// Returns the Data Element value from a Segment.
        /// </summary>
        /// <param name="segSearch">Semgment ID (PID, OBR, PV1, etc...)</param>
        /// <param name="elementName">Account Number, Patient Idenifier List, etc...</param>
        /// <returns>Data Element Value</returns>
        public string GetSegmentValue(string segSearch, string elementName)
        {
            if (Segments == null || Segments.Count == 0) return "";

            Segment seg = null;
            DataElement dataElement = null;

            seg = Segments.Find(s => s.SegmentCode == segSearch);

            dataElement = seg.DataElements.Find(x => x.ElementCode == elementName);

            return dataElement.DataValue;
        }

        /// <summary>
        /// Return the value of an HL7 data element. You will need to supply the segment name and location.
        /// You can either get the sub-component, or the entire element.
        /// Example: MSH 8.3 or PID 4
        /// </summary>
        /// <param name="segSearch">Segment and location.</param>
        /// <returns>Segment Data Element Value, or Component Value.</returns>
        public string GetSegmentValue(string segSearch)
        {
            Segment seg = null;
            seg = Segments.Find(s => s.SegmentCode == segSearch.Substring(0, 3));

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

            if (componentSequence > 0 && dataElement.DataValue.Contains("^"))            
                return dataElement.DataValue.Split(char.Parse("^"))[componentSequence - 1];            
            else
                return dataElement.DataValue;
        }

        /// <summary>
        /// Set the value of a particular Component for the Data Element.
        /// </summary>
        /// <param name="segSearch">Segment ID (PID, OBR, etc...)</param>
        /// <param name="elementName">Account Number, Patient Idenifier List, etc...</param>
        /// <param name="indexLocation">1-based index location of the component.</param>
        /// <param name="newValue">The overwrite value to replace the component.</param>
        public void SetSegmentValue(string segSearch, string elementName, int indexLocation, string newValue)
        {
            if (Segments == null || Segments.Count == 0) return;

            Segment seg = null;
            DataElement dataElement = null;

            seg = Segments.Find(s => s.SegmentCode == segSearch);

            dataElement = seg.DataElements.Find(x => x.ElementCode == elementName);

            string[] splitter = dataElement.DataValue.Split(char.Parse("^"));

            splitter[indexLocation - 1] = newValue;

            string newValueWithSplit = "";

            foreach (string s in splitter) newValueWithSplit += s + "^";

            dataElement.DataValue = newValueWithSplit.Substring(0, newValueWithSplit.Length - 1);

            Update(ref seg);
        }

        /// <summary>
        /// Set the value of the Data Element.
        /// </summary>
        /// <param name="segSearch">Segment ID (PID, OBR, etc...)</param>
        /// <param name="elementName">Account Number, Patient Idenifier List, etc...</param>
        /// <param name="newValue">The overwrite value to replace the component.</param>
        public void SetSegmentValue(string segSearch, string elementName, string newValue)
        {
            if (Segments == null || Segments.Count == 0) return;

            Segment seg = null;
            DataElement dataElement = null;

            seg = Segments.Find(s => s.SegmentCode == segSearch);
            dataElement = seg.DataElements.Find(x => x.ElementCode == elementName);
            dataElement.DataValue = newValue;

            Update(ref seg);
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
            Segment seg = null;

            seg = Segments.Find(s => s.SegmentCode == segSearch.Substring(0, 3));

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

            if (componentSequence > 0 && dataElement.DataValue.Contains("^"))
            {
                string[] splitter = dataElement.DataValue.Split(char.Parse("^"));

                splitter[componentSequence - 1] = newValue;

                string newValueWithSplit = "";

                foreach (string s in splitter) newValueWithSplit += s + "^";

                dataElement.DataValue = newValueWithSplit.Substring(0, newValueWithSplit.Length - 1);
            }
            else
                dataElement.DataValue = newValue;

            Update(ref seg);
        }

        private void Update(ref Segment seg)
        {
            // Everytime we use a "set" function, we should update
            // the segment full text property so it will reflect
            // all the new element values without saving to disk.
            string fullSegText = "";        
           
            // Re-build the full segment property.
            foreach (var element in seg.DataElements) fullSegText += element.DataValue + "|";

            seg.FullSegment = fullSegText.Substring(0, fullSegText.Length - 1);
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
                        foreach (DataElement element in seg.DataElements) textOut += element.DataValue + "|";                        
                    }
                    else
                    {
                        // No data elements have been configured. So we don't lose data when
                        // writing the HL7, just use the segment text from the original HL7 file.
                        textOut += seg.FullSegment;
                    }
                    
                    sw.Write(textOut + "\r");
                }
            }

            // "Re-read" the updated segments. Reinitialize the segments so it will resize.
            Segments = new List<Segment>(File.ReadAllLines(newFilename).Length);
            PopulateSegments();
        }
    }
}