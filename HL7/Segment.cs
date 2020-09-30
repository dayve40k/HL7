using System.Collections.Generic;

namespace HL7
{
    public class Segment
    {
        public string SegmentCode { get; set; } = "";
        public string CodeDescription { get; set; } = "";
        public int Sequence { get; set; } = 0;
        public string FullSegment { get; set; } = "";
        public List<DataElement> DataElements { get; set; } = null;

        public Segment()
        {
            SegmentCode = "";
            CodeDescription = "";
            Sequence = 99;
            FullSegment = "";
            DataElements = null;
        }

        public Segment(string lineText)
        {
            SegmentCode = lineText.Substring(0, 3);
            FullSegment = lineText;
            GetSegment();
            PopulateDataElements(lineText);            
        }
        public override string ToString()
        {
            return SegmentCode;
        }

        private void PopulateDataElements(string fullSegmentText)
        {
            if (DataElements != null && DataElements.Count > 0)
            {
                string[] splitter = fullSegmentText.Split(char.Parse("|"));
                int i = 0;

                foreach (DataElement element in DataElements)
                {
                    element.SegmentCode = SegmentCode;

                    if (element.SegmentCode == "MSH") element.IndexLocation--; // This is a special case...                    

                    try
                    {                    
                        if (i <= splitter.Length) element.DataValue = splitter[element.IndexLocation];
                    }
                    catch 
                    {
                        element.DataValue = "";
                    }
                    i++;
                   element.Components = Component.PopulateComponents(element);
                }
            }
        }

        public static List<Segment> GetSegments()
        {
            List<Segment> segs = new List<Segment>();

            segs.Add(new Segment { SegmentCode = "MSH", CodeDescription = "Message Header", Sequence = 1 });
            segs.Add(new Segment { SegmentCode = "EVN", CodeDescription = "Event Type", Sequence = 2 });
            segs.Add(new Segment { SegmentCode = "PID", CodeDescription = "Patient Identification", Sequence = 3 });
            segs.Add(new Segment { SegmentCode = "PV1", CodeDescription = "Patient Visit", Sequence = 4 });
            segs.Add(new Segment { SegmentCode = "SCH", CodeDescription = "Schedule Activity Information", Sequence = 5});
            segs.Add(new Segment { SegmentCode = "OBR", CodeDescription = "Observation Request", Sequence = 6 });            
            segs.Add(new Segment { SegmentCode = "AIL", CodeDescription = "Appointment Information Location Resource", Sequence = 7 });
            segs.Add(new Segment { SegmentCode = "OBX", CodeDescription = "Observation Value", Sequence = 8 });
            segs.Add(new Segment { SegmentCode = "TXA", CodeDescription = "Transcription Document Header", Sequence = 9 });
            segs.Add(new Segment { SegmentCode = "ORC", CodeDescription = "Common Order Segment", Sequence = 10 });
            segs.Add(new Segment { SegmentCode = "RXA", CodeDescription = "PHARMACY/TREATMENT ADMINISTRATION", Sequence = 11 });

            return segs;
        }  

        private void GetSegment()
        {
            var seg = GetSegments().Find(x => x.SegmentCode == SegmentCode);

            if (seg != null)
            {
                CodeDescription = seg.CodeDescription;
                Sequence = seg.Sequence;
                DataElements = DataElement.GetDataElementsBySegment(seg.SegmentCode);
            }
        }

    }
}
