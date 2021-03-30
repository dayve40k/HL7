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

                foreach (DataElement element in DataElements)
                {
                    element.SegmentCode = SegmentCode;

                    if (element.SegmentCode == "MSH") element.IndexLocation--; // This is a special case...

                    if (element.IndexLocation <= splitter.Length - 1) element.DataValue = splitter[element.IndexLocation];
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
            segs.Add(new Segment { SegmentCode = "PV2", CodeDescription = "Patient Visit Additional Information", Sequence = 11 });
            segs.Add(new Segment { SegmentCode = "SCH", CodeDescription = "Schedule Activity Information", Sequence = 5 });
            segs.Add(new Segment { SegmentCode = "ORC", CodeDescription = "Common Order Segment", Sequence = 6 });
            segs.Add(new Segment { SegmentCode = "OBR", CodeDescription = "Observation Request", Sequence = 6 });
            segs.Add(new Segment { SegmentCode = "AIL", CodeDescription = "Appointment Information Location Resource", Sequence = 7 });
            segs.Add(new Segment { SegmentCode = "OBX", CodeDescription = "Observation Value", Sequence = 8 });
            segs.Add(new Segment { SegmentCode = "TXA", CodeDescription = "Transcription Document Header", Sequence = 9 });
            segs.Add(new Segment { SegmentCode = "RXA", CodeDescription = "Pharmacy Treatment Administration", Sequence = 11 });
            segs.Add(new Segment { SegmentCode = "RGS", CodeDescription = "Resource Group", Sequence = 11 });
            segs.Add(new Segment { SegmentCode = "ROL", CodeDescription = "Role", Sequence = 11 });
            segs.Add(new Segment { SegmentCode = "AIS", CodeDescription = "Appointment Information - Service", Sequence = 11 });
            segs.Add(new Segment { SegmentCode = "AIP", CodeDescription = "Appointment Information - Personnel Resource", Sequence = 11 });
            segs.Add(new Segment { SegmentCode = "PR1", CodeDescription = "Procedures", Sequence = 11 });
            segs.Add(new Segment { SegmentCode = "NTE", CodeDescription = "Notes and Comments", Sequence = 11 });
            segs.Add(new Segment { SegmentCode = "NK1", CodeDescription = "Next of Kin/Associated Parties", Sequence = 11 });
            segs.Add(new Segment { SegmentCode = "DRG", CodeDescription = "Diagnosis Related Group", Sequence = 11 });
            segs.Add(new Segment { SegmentCode = "DG1", CodeDescription = "Diagnosis", Sequence = 11 });            
            segs.Add(new Segment { SegmentCode = "GT1", CodeDescription = "Guarantor", Sequence = 11 });
            segs.Add(new Segment { SegmentCode = "IN1", CodeDescription = "Insurance", Sequence = 11 });
            segs.Add(new Segment { SegmentCode = "IN2", CodeDescription = "Insurance Additional Information", Sequence = 11 });
            segs.Add(new Segment { SegmentCode = "IN3", CodeDescription = "Insurance Additional Information - Certification", Sequence = 11 });
            segs.Add(new Segment { SegmentCode = "ACC", CodeDescription = "Accident", Sequence = 11 });
            segs.Add(new Segment { SegmentCode = "AL1", CodeDescription = "Patient Allergy Information", Sequence = 11 });
            segs.Add(new Segment { SegmentCode = "FT1", CodeDescription = "Financial Transaction", Sequence = 11 });
            segs.Add(new Segment { SegmentCode = "UB1", CodeDescription = "UB92 Data", Sequence = 11 });
            segs.Add(new Segment { SegmentCode = "UB2", CodeDescription = "Uniform Billing", Sequence = 11 });
            segs.Add(new Segment { SegmentCode = "RXR", CodeDescription = "IV Solutions", Sequence = 11 });

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

        public void SetValue(string elementName, string newValue)
        {
            DataElements.Find(x => x.ElementCode == elementName).DataValue = newValue;
        }

        public string GetDataElementValue(string elementCode)
        {
            return DataElements.Find(x => x.ElementCode == elementCode).DataValue;
        }

        /// <summary>
        /// Return a sub-component of the Data Element.
        /// </summary>
        /// <param name="elementCode">Description of the Data Element.</param>
        /// <param name="indexLocation">1-based index location of the ^ character.</param>
        /// <returns>Element Data Value</returns>
        public string GetDataElementValue(string elementCode, int indexLocation)
        {
            var element = DataElements.Find(x => x.ElementCode == elementCode);

            if (element.DataValue.Contains("^"))
                return element.DataValue.Split(char.Parse("^"))[indexLocation - 1];
            else
                return element.DataValue;
        }
    }
}