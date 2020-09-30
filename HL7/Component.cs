using System.Collections.Generic;

namespace HL7
{
    public class Component
    {
        public string ComponentCode { get; set; } = "";
        public string SegmentCode { get; set; } = "";
        public string ElementCode { get; set; } = "";
        public int IndexLocation { get; set; } = 0;
        public string DataValue { get; set; } = "";

        public static List<Component> PopulateComponents(DataElement element)
        {
            string[] splitter = element.DataValue.Split(char.Parse("^"));

            if (splitter.Length == 0) return null;

            List<Component> returnList = GetComponentsByElement(element.SegmentCode, element.ElementCode);

            if (returnList == null || returnList.Count == 0) return null;

            int i = 0;

            foreach (Component c in returnList)
            {
                try
                {
                    if (i <= splitter.Length) c.DataValue = splitter[c.IndexLocation - 1];
                }
                catch
                {
                    c.DataValue = "";
                }

                i++;
            }
            return returnList;
        }

        public Component()
        {
            ComponentCode = "";
            SegmentCode = "";
            ElementCode = "";
            IndexLocation = 0;
        }

        public override string ToString()
        {
            return ComponentCode;
        }

        public static List<Component> GetAllComponents()
        {
            List<Component> list = new List<Component>();

            #region "MSH"

            #region "MSH 9  - Message Type"

            list.Add(new Component { ComponentCode = "Message Code", SegmentCode = "MSH", ElementCode = "Message Type", IndexLocation = 1 });
            list.Add(new Component { ComponentCode = "Trigger Event", SegmentCode = "MSH", ElementCode = "Message Type", IndexLocation = 2 });
            //list.Add(new Component { ComponentCode = "Message Structure", SegmentCode = "MSH", ElementCode = "Message Type", IndexLocation = 3 });

            #endregion "MSH 9  - Message Type"

            #endregion "MSH"

            #region "PID"
            #region "PID 18 - Patient Account Number"
            //list.Add(new Component { ComponentCode = "ID Number", SegmentCode = "PID", ElementCode = "Patient Account Number", IndexLocation = 1 });
            //list.Add(new Component { ComponentCode = "Identifier Check Digit", SegmentCode = "PID", ElementCode = "Patient Account Number", IndexLocation = 2 });
            //list.Add(new Component { ComponentCode = "Check Digit Scheme", SegmentCode = "PID", ElementCode = "Patient Account Number", IndexLocation = 3 });
            //list.Add(new Component { ComponentCode = "Assigning Authority", SegmentCode = "PID", ElementCode = "Patient Account Number", IndexLocation = 4 });
            //list.Add(new Component { ComponentCode = "Identifier Type Code", SegmentCode = "PID", ElementCode = "Patient Account Number", IndexLocation = 5 });
            //list.Add(new Component { ComponentCode = "Assigning Facility", SegmentCode = "PID", ElementCode = "Patient Account Number", IndexLocation = 6 });
            #endregion
            #endregion

            #region "AIL"

            #region "AIL 3 - Location Resource"

            list.Add(new Component { ComponentCode = "Point of Care", SegmentCode = "AIL", ElementCode = "Location Resource ID", IndexLocation = 1 });
            list.Add(new Component { ComponentCode = "Room", SegmentCode = "AIL", ElementCode = "Location Resource ID", IndexLocation = 2 });
            list.Add(new Component { ComponentCode = "Bed", SegmentCode = "AIL", ElementCode = "Location Resource ID", IndexLocation = 3 });
            list.Add(new Component { ComponentCode = "Facility", SegmentCode = "AIL", ElementCode = "Location Resource ID", IndexLocation = 4 });

            #endregion "AIL 3 - Location Resource"

            #endregion "AIL"

            #region "EVN"

            #region "EVN 5 - Operator ID "

            list.Add(new Component { ComponentCode = "ID number", SegmentCode = "EVN", ElementCode = "Operator ID", IndexLocation = 1 });
            list.Add(new Component { ComponentCode = "Family Name", SegmentCode = "EVN", ElementCode = "Operator ID", IndexLocation = 2 });
            list.Add(new Component { ComponentCode = "Given Name", SegmentCode = "EVN", ElementCode = "Operator ID", IndexLocation = 3 });
            list.Add(new Component { ComponentCode = "Middle Initial or Name", SegmentCode = "EVN", ElementCode = "Operator ID", IndexLocation = 4 });
            list.Add(new Component { ComponentCode = "Suffix", SegmentCode = "EVN", ElementCode = "Operator ID", IndexLocation = 5 });
            list.Add(new Component { ComponentCode = "Prefix", SegmentCode = "EVN", ElementCode = "Operator ID", IndexLocation = 6 });
            list.Add(new Component { ComponentCode = "Degree", SegmentCode = "EVN", ElementCode = "Operator ID", IndexLocation = 7 });
            list.Add(new Component { ComponentCode = "Source Table", SegmentCode = "EVN", ElementCode = "Operator ID", IndexLocation = 8 });
            list.Add(new Component { ComponentCode = "Assigning Authority", SegmentCode = "EVN", ElementCode = "Operator ID", IndexLocation = 9 });
            list.Add(new Component { ComponentCode = "Name Type Code", SegmentCode = "EVN", ElementCode = "Operator ID", IndexLocation = 10 });
            list.Add(new Component { ComponentCode = "Identifier Check Digit", SegmentCode = "EVN", ElementCode = "Operator ID", IndexLocation = 11 });
            list.Add(new Component { ComponentCode = "Code Identifying the Check Digit Scheme Employed", SegmentCode = "EVN", ElementCode = "Operator ID", IndexLocation = 12 });
            list.Add(new Component { ComponentCode = "Identifier Type Code", SegmentCode = "EVN", ElementCode = "Operator ID", IndexLocation = 13 });
            list.Add(new Component { ComponentCode = "Assigning Facility", SegmentCode = "EVN", ElementCode = "Operator ID", IndexLocation = 14 });

            #endregion "EVN 5 - Operator ID "

            #endregion "EVN"

            #region "PID"

            #region "PID 3 - Patient Identifier List"

            list.Add(new Component { ComponentCode = "ID Number", SegmentCode = "PID", ElementCode = "Patient Identifier List", IndexLocation = 1 });
            list.Add(new Component { ComponentCode = "Identifier Check Digit", SegmentCode = "PID", ElementCode = "Patient Identifier List", IndexLocation = 2 });
            list.Add(new Component { ComponentCode = "Check Digit Scheme", SegmentCode = "PID", ElementCode = "Patient Identifier List", IndexLocation = 3 });
            list.Add(new Component { ComponentCode = "Assigning Authority", SegmentCode = "PID", ElementCode = "Patient Identifier List", IndexLocation = 4 });
            list.Add(new Component { ComponentCode = "Identifier Type Code", SegmentCode = "PID", ElementCode = "Patient Identifier List", IndexLocation = 5 });
            list.Add(new Component { ComponentCode = "Assigning Facility", SegmentCode = "PID", ElementCode = "Patient Identifier List", IndexLocation = 6 });
            list.Add(new Component { ComponentCode = "Effective Date", SegmentCode = "PID", ElementCode = "Patient Identifier List", IndexLocation = 7 });
            list.Add(new Component { ComponentCode = "Expiration Date", SegmentCode = "PID", ElementCode = "Patient Identifier List", IndexLocation = 8 });
            list.Add(new Component { ComponentCode = "Assigning Jurisdiction", SegmentCode = "PID", ElementCode = "Patient Identifier List", IndexLocation = 9 });
            list.Add(new Component { ComponentCode = "Assigning Agency or Department", SegmentCode = "PID", ElementCode = "Patient Identifier List", IndexLocation = 10 });
            list.Add(new Component { ComponentCode = "Security Check", SegmentCode = "PID", ElementCode = "Patient Identifier List", IndexLocation = 11 });
            list.Add(new Component { ComponentCode = "Security Check Scheme", SegmentCode = "PID", ElementCode = "Patient Identifier List", IndexLocation = 12 });

            #endregion "PID 3 - Patient Identifier List"

            #region "PID 5 - Patient Name"

            list.Add(new Component { ComponentCode = "Family Name", SegmentCode = "PID", ElementCode = "Patient Name", IndexLocation = 1 });
            list.Add(new Component { ComponentCode = "Given Name", SegmentCode = "PID", ElementCode = "Patient Name", IndexLocation = 2 });
            list.Add(new Component { ComponentCode = "Middle Name", SegmentCode = "PID", ElementCode = "Patient Name", IndexLocation = 3 });

            #endregion "PID 5 - Patient Name"

            #region "PID 11 - Patient Address"

            list.Add(new Component { ComponentCode = "Street Address", SegmentCode = "PID", ElementCode = "Patient Address", IndexLocation = 1 });
            list.Add(new Component { ComponentCode = "Other Designation", SegmentCode = "PID", ElementCode = "Patient Address", IndexLocation = 2 });
            list.Add(new Component { ComponentCode = "City", SegmentCode = "PID", ElementCode = "Patient Address", IndexLocation = 3 });
            list.Add(new Component { ComponentCode = "State", SegmentCode = "PID", ElementCode = "Patient Address", IndexLocation = 4 });
            list.Add(new Component { ComponentCode = "Zip", SegmentCode = "PID", ElementCode = "Patient Address", IndexLocation = 5 });
            list.Add(new Component { ComponentCode = "Country", SegmentCode = "PID", ElementCode = "Patient Address", IndexLocation = 6 });
            list.Add(new Component { ComponentCode = "Address Type", SegmentCode = "PID", ElementCode = "Patient Address", IndexLocation = 7 });
            list.Add(new Component { ComponentCode = "Other Geographic Designation", SegmentCode = "PID", ElementCode = "Patient Address", IndexLocation = 8 });
            list.Add(new Component { ComponentCode = "County Code", SegmentCode = "PID", ElementCode = "Patient Address", IndexLocation = 9 });

            #endregion "PID 11 - Patient Address"

            #endregion "PID"

            #region "PV1"
            #region "PV1 3 - Assigned Patient Location"

            list.Add(new Component { ComponentCode = "Point of Care", SegmentCode = "PV1", ElementCode = "Assigned Patient Location", IndexLocation = 1 });
            list.Add(new Component { ComponentCode = "Room", SegmentCode = "PV1", ElementCode = "Assigned Patient Location", IndexLocation = 2 });
            list.Add(new Component { ComponentCode = "Bed", SegmentCode = "PV1", ElementCode = "Assigned Patient Location", IndexLocation = 3 });
            list.Add(new Component { ComponentCode = "Facility", SegmentCode = "PV1", ElementCode = "Assigned Patient Location", IndexLocation = 4 });
            list.Add(new Component { ComponentCode = "Locatoin Status", SegmentCode = "PV1", ElementCode = "Assigned Patient Location", IndexLocation = 5 });
            list.Add(new Component { ComponentCode = "Person Location Type", SegmentCode = "PV1", ElementCode = "Assigned Patient Location", IndexLocation = 6 });
            list.Add(new Component { ComponentCode = "Building", SegmentCode = "PV1", ElementCode = "Assigned Patient Location", IndexLocation = 7 });
            list.Add(new Component { ComponentCode = "Floor", SegmentCode = "PV1", ElementCode = "Assigned Patient Location", IndexLocation = 8 });
            list.Add(new Component { ComponentCode = "Location Description", SegmentCode = "PV1", ElementCode = "Assigned Patient Location", IndexLocation = 9 });
            list.Add(new Component { ComponentCode = "Comprehensive Location Identifier", SegmentCode = "PV1", ElementCode = "Assigned Patient Location", IndexLocation = 10 });
            list.Add(new Component { ComponentCode = "Assigning Authority for Location", SegmentCode = "PV1", ElementCode = "Assigned Patient Location", IndexLocation = 11 });

            #endregion "PV1 3 - Assigned Patient Location"
            #endregion

            #region "TXA"

            #region "Originator Code/Name"
            list.Add(new Component { ComponentCode = "Person Identifier", SegmentCode = "TXA", ElementCode = "Originator Code/Name", IndexLocation = 1 });
            list.Add(new Component { ComponentCode = "Family Name", SegmentCode = "TXA", ElementCode = "Originator Code/Name", IndexLocation = 2 });
            list.Add(new Component { ComponentCode = "Given Name", SegmentCode = "TXA", ElementCode = "Originator Code/Name", IndexLocation = 3 });
            #endregion

            #region "Transcriptionist Code/Name"
            list.Add(new Component { ComponentCode = "Person Identifier", SegmentCode = "TXA", ElementCode = "Transcriptionist Code/Name", IndexLocation = 1 });
            list.Add(new Component { ComponentCode = "Family Name", SegmentCode = "TXA", ElementCode = "Transcriptionist Code/Name", IndexLocation = 2 });
            list.Add(new Component { ComponentCode = "Given Name", SegmentCode = "TXA", ElementCode = "Transcriptionist Code/Name", IndexLocation = 3 });
            #endregion

            #region "Assigned Document Authenticator"
            list.Add(new Component { ComponentCode = "Person Identifier", SegmentCode = "TXA", ElementCode = "Assigned Document Authenticator", IndexLocation = 1 });
            list.Add(new Component { ComponentCode = "Family Name", SegmentCode = "TXA", ElementCode = "Assigned Document Authenticator", IndexLocation = 2 });
            list.Add(new Component { ComponentCode = "Given Name", SegmentCode = "TXA", ElementCode = "Assigned Document Authenticator", IndexLocation = 3 });
            #endregion

            #region "Primary Activity Provider Code/Name"
            list.Add(new Component { ComponentCode = "Person Identifier", SegmentCode = "TXA", ElementCode = "Primary Activity Provider Code/Name", IndexLocation = 1 });
            list.Add(new Component { ComponentCode = "Family Name", SegmentCode = "TXA", ElementCode = "Primary Activity Provider Code/Name", IndexLocation = 2 });
            list.Add(new Component { ComponentCode = "Given Name", SegmentCode = "TXA", ElementCode = "Primary Activity Provider Code/Name", IndexLocation = 3 });
            #endregion

            #endregion

            #region "OBR"

            #region "Universal Service Identifier"
            list.Add(new Component { ComponentCode = "Identifier", SegmentCode = "OBR", ElementCode = "Universal Service Identifier", IndexLocation = 1 });
            list.Add(new Component { ComponentCode = "Text", SegmentCode = "OBR", ElementCode = "Universal Service Identifier", IndexLocation = 2 });
            //list.Add(new Component { ComponentCode = "Name of Coding System", SegmentCode = "OBR", ElementCode = "Universal Service Identifier", IndexLocation = 3 });
            #endregion

            #endregion

            return list;
        }

        public static List<Component> GetComponentsByElement(string segmentCode, string elementCode)
        {
            return GetAllComponents().FindAll(x => x.SegmentCode == segmentCode && x.ElementCode == elementCode);
        }
    }
}