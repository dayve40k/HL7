using System.Collections.Generic;

namespace HL7
{
    public class DataElement
    {
        public string ElementCode { get; set; } = "";
        public string SegmentCode { get; set; } = "";
        public int IndexLocation { get; set; } = 0;
        public string DataValue { get; set; } = "";
        public List<Component> Components { get; set; } = null;

        public DataElement()
        {
            ElementCode = "";
            SegmentCode = "";
            IndexLocation = 0;
        }
        public override string ToString()
        {
            return ElementCode;
        }    

        public static List<DataElement> GetAllDataElements()
        {
            List<DataElement> list = new List<DataElement>();            

            #region "AIL"
            list.Add(new DataElement { ElementCode = "Set ID", SegmentCode = "AIL", IndexLocation = 1 });
            list.Add(new DataElement { ElementCode = "Segment Action Code", SegmentCode = "AIL", IndexLocation = 2 });
            list.Add(new DataElement { ElementCode = "Location Resource ID", SegmentCode = "AIL", IndexLocation = 3 });
            list.Add(new DataElement { ElementCode = "Location Type - AIL", SegmentCode = "AIL", IndexLocation = 4 });
            list.Add(new DataElement { ElementCode = "Location Group", SegmentCode = "AIL", IndexLocation = 5 });
            list.Add(new DataElement { ElementCode = "Start DateTime", SegmentCode = "AIL", IndexLocation = 6 });
            list.Add(new DataElement { ElementCode = "Start DateTime Offset", SegmentCode = "AIL", IndexLocation = 7 });
            list.Add(new DataElement { ElementCode = "Start DateTime Offset Units", SegmentCode = "AIL", IndexLocation = 8 });
            list.Add(new DataElement { ElementCode = "Duration", SegmentCode = "AIL", IndexLocation = 9 });
            list.Add(new DataElement { ElementCode = "Duration Units", SegmentCode = "AIL", IndexLocation = 10 });
            list.Add(new DataElement { ElementCode = "Allow Subsitiutions", SegmentCode = "AIL", IndexLocation = 11 });
            list.Add(new DataElement { ElementCode = "Filler Status Code", SegmentCode = "AIL", IndexLocation = 12 });
            #endregion

            #region "EVN"
            list.Add(new DataElement { ElementCode = "Event Type Code", SegmentCode = "EVN", IndexLocation = 1 });
            list.Add(new DataElement { ElementCode = "Recorded Date Time", SegmentCode = "EVN", IndexLocation = 2 });
            list.Add(new DataElement { ElementCode = "Date Time Planned Event", SegmentCode = "EVN", IndexLocation = 3 });
            list.Add(new DataElement { ElementCode = "Event Reason Code", SegmentCode = "EVN", IndexLocation = 4 });
            list.Add(new DataElement { ElementCode = "Operator ID", SegmentCode = "EVN", IndexLocation = 5 });
            list.Add(new DataElement { ElementCode = "Event Occured", SegmentCode = "EVN", IndexLocation = 6 });
            list.Add(new DataElement { ElementCode = "Event Facility", SegmentCode = "EVN", IndexLocation = 7 });
            #endregion

            #region "MSH"
            //list.Add(new DataElement { ElementCode = "Field Separator", SegmentCode = "MSH", IndexLocation = 1 });
            list.Add(new DataElement { ElementCode = "Encoding Characters", SegmentCode = "MSH", IndexLocation = 2 });
            list.Add(new DataElement { ElementCode = "Sending Application", SegmentCode = "MSH", IndexLocation = 3 });
            list.Add(new DataElement { ElementCode = "Sending Facility", SegmentCode = "MSH", IndexLocation = 4 });
            list.Add(new DataElement { ElementCode = "Receiving Application", SegmentCode = "MSH", IndexLocation = 5 });
            list.Add(new DataElement { ElementCode = "Receiving Facility", SegmentCode = "MSH", IndexLocation = 6 });
            list.Add(new DataElement { ElementCode = "Date/Time of Message", SegmentCode = "MSH", IndexLocation = 7 });
            list.Add(new DataElement { ElementCode = "Security", SegmentCode = "MSH", IndexLocation = 8 });
            list.Add(new DataElement { ElementCode = "Message Type", SegmentCode = "MSH", IndexLocation = 9 });
            list.Add(new DataElement { ElementCode = "Message Control ID", SegmentCode = "MSH", IndexLocation = 10 });
            list.Add(new DataElement { ElementCode = "Processing ID", SegmentCode = "MSH", IndexLocation = 11 });
            list.Add(new DataElement { ElementCode = "Version ID", SegmentCode = "MSH", IndexLocation = 12 });
            list.Add(new DataElement { ElementCode = "Sequence Number", SegmentCode = "MSH", IndexLocation = 13 });
            list.Add(new DataElement { ElementCode = "Continuation Pointer", SegmentCode = "MSH", IndexLocation = 14 });
            list.Add(new DataElement { ElementCode = "Accept Acknowledgment Type", SegmentCode = "MSH", IndexLocation = 15 });
            list.Add(new DataElement { ElementCode = "Application Acknowledgment Type", SegmentCode = "MSH", IndexLocation = 16 });
            list.Add(new DataElement { ElementCode = "Country Code", SegmentCode = "MSH", IndexLocation = 17 });
            list.Add(new DataElement { ElementCode = "Character Set", SegmentCode = "MSH", IndexLocation = 18 });
            list.Add(new DataElement { ElementCode = "Principal Language Of Message", SegmentCode = "MSH", IndexLocation = 19 });
            list.Add(new DataElement { ElementCode = "Alternate Character Set Handling Scheme", SegmentCode = "MSH", IndexLocation = 20 });
            list.Add(new DataElement { ElementCode = "Message Profile Identifier", SegmentCode = "MSH", IndexLocation = 21 });
            list.Add(new DataElement { ElementCode = "Sending Responsible Organization", SegmentCode = "MSH", IndexLocation = 22 });
            list.Add(new DataElement { ElementCode = "Receiving Responsible Organization", SegmentCode = "MSH", IndexLocation = 23 });
            list.Add(new DataElement { ElementCode = "Sending Network Address", SegmentCode = "MSH", IndexLocation = 24 });
            list.Add(new DataElement { ElementCode = "Receiving Network Address", SegmentCode = "MSH", IndexLocation = 25 });
            #endregion

            #region "OBR"
            list.Add(new DataElement { ElementCode = "Set ID", SegmentCode = "OBR", IndexLocation = 1 });
            list.Add(new DataElement { ElementCode = "Placer Order Number", SegmentCode = "OBR", IndexLocation = 2 });
            list.Add(new DataElement { ElementCode = "Filler Order Number", SegmentCode = "OBR", IndexLocation = 3 });
            list.Add(new DataElement { ElementCode = "Universal Service Identifier", SegmentCode = "OBR", IndexLocation = 4 });
            list.Add(new DataElement { ElementCode = "Priority", SegmentCode = "OBR", IndexLocation = 5 });
            list.Add(new DataElement { ElementCode = "Requested DateTime", SegmentCode = "OBR", IndexLocation = 6 });
            list.Add(new DataElement { ElementCode = "Observation DateTime", SegmentCode = "OBR", IndexLocation = 7 });
            list.Add(new DataElement { ElementCode = "Observation End DateTime", SegmentCode = "OBR", IndexLocation = 8 });
            list.Add(new DataElement { ElementCode = "Collection Volume", SegmentCode = "OBR", IndexLocation = 9 });
            list.Add(new DataElement { ElementCode = "Collector Identifer", SegmentCode = "OBR", IndexLocation = 10 });
            list.Add(new DataElement { ElementCode = "Specimen Action Code", SegmentCode = "OBR", IndexLocation = 11 });
            list.Add(new DataElement { ElementCode = "Danger Code", SegmentCode = "OBR", IndexLocation = 12 });
            list.Add(new DataElement { ElementCode = "Relevant Clinical Information", SegmentCode = "OBR", IndexLocation = 13 });
            list.Add(new DataElement { ElementCode = "Specimen Received DateTime", SegmentCode = "OBR", IndexLocation = 14 });
            list.Add(new DataElement { ElementCode = "Specimen Source", SegmentCode = "OBR", IndexLocation = 15 });
            list.Add(new DataElement { ElementCode = "Ordering Provider", SegmentCode = "OBR", IndexLocation = 16 });
            list.Add(new DataElement { ElementCode = "Order Callback Phone Number", SegmentCode = "OBR", IndexLocation = 17 });
            list.Add(new DataElement { ElementCode = "Placer Field 1", SegmentCode = "OBR", IndexLocation = 18 });
            list.Add(new DataElement { ElementCode = "Placer Field 2", SegmentCode = "OBR", IndexLocation = 19 });
            list.Add(new DataElement { ElementCode = "Filler Field 1 +", SegmentCode = "OBR", IndexLocation = 20 });
            list.Add(new DataElement { ElementCode = "Filler Field 2 +", SegmentCode = "OBR", IndexLocation = 21 });
            list.Add(new DataElement { ElementCode = "Results Report Status Change DateTime", SegmentCode = "OBR", IndexLocation = 22 });
            list.Add(new DataElement { ElementCode = "Charge to Practice", SegmentCode = "OBR", IndexLocation = 23 });
            list.Add(new DataElement { ElementCode = "Diagnostic Serv Sect ID", SegmentCode = "OBR", IndexLocation = 24 });
            list.Add(new DataElement { ElementCode = "Result Status", SegmentCode = "OBR", IndexLocation = 25 });
            list.Add(new DataElement { ElementCode = "Parent Status", SegmentCode = "OBR", IndexLocation = 26 });
            list.Add(new DataElement { ElementCode = "QuantityTiming", SegmentCode = "OBR", IndexLocation = 27 });
            list.Add(new DataElement { ElementCode = "Result Copies To", SegmentCode = "OBR", IndexLocation = 28 });
            list.Add(new DataElement { ElementCode = "Parent Results Observation Identifier", SegmentCode = "OBR", IndexLocation = 29 });
            list.Add(new DataElement { ElementCode = "Transportation Mode", SegmentCode = "OBR", IndexLocation = 30 });
            list.Add(new DataElement { ElementCode = "Reason for Study", SegmentCode = "OBR", IndexLocation = 31 });
            list.Add(new DataElement { ElementCode = "Principal Result Interpreter", SegmentCode = "OBR", IndexLocation = 32 });
            list.Add(new DataElement { ElementCode = "Assistant Result Interpreter", SegmentCode = "OBR", IndexLocation = 33 });
            list.Add(new DataElement { ElementCode = "Technician", SegmentCode = "OBR", IndexLocation = 34 });
            list.Add(new DataElement { ElementCode = "Transcriptionist", SegmentCode = "OBR", IndexLocation = 35 });
            list.Add(new DataElement { ElementCode = "Scheduled DateTime", SegmentCode = "OBR", IndexLocation = 36 });
            list.Add(new DataElement { ElementCode = "Number of Sample Containers", SegmentCode = "OBR", IndexLocation = 37 });
            list.Add(new DataElement { ElementCode = "Transport Logistics of Collected Sample", SegmentCode = "OBR", IndexLocation = 38 });
            list.Add(new DataElement { ElementCode = "Collectors Comment", SegmentCode = "OBR", IndexLocation = 39 });
            list.Add(new DataElement { ElementCode = "Transport Arrangement Responsibility", SegmentCode = "OBR", IndexLocation = 40 });
            list.Add(new DataElement { ElementCode = "Transport Arranged", SegmentCode = "OBR", IndexLocation = 41 });
            list.Add(new DataElement { ElementCode = "Escort Required", SegmentCode = "OBR", IndexLocation = 42 });
            list.Add(new DataElement { ElementCode = "Planned Patient Transport Comment", SegmentCode = "OBR", IndexLocation = 43 });
            list.Add(new DataElement { ElementCode = "Procedure Code", SegmentCode = "OBR", IndexLocation = 44 });
            list.Add(new DataElement { ElementCode = "Procedure Code Modifier", SegmentCode = "OBR", IndexLocation = 45 });
            list.Add(new DataElement { ElementCode = "Placer Supplemental Service Information", SegmentCode = "OBR", IndexLocation = 46 });
            list.Add(new DataElement { ElementCode = "Filler Supplemental Service Information", SegmentCode = "OBR", IndexLocation = 47 });
            list.Add(new DataElement { ElementCode = "Medically Necessary Duplicate Procedure Reason", SegmentCode = "OBR", IndexLocation = 48 });
            list.Add(new DataElement { ElementCode = "Result Handling", SegmentCode = "OBR", IndexLocation = 49 });
            list.Add(new DataElement { ElementCode = "Parent Universal Service Identifier", SegmentCode = "OBR", IndexLocation = 50 });
            list.Add(new DataElement { ElementCode = "Observation Group ID", SegmentCode = "OBR", IndexLocation = 51 });
            list.Add(new DataElement { ElementCode = "Parent Observation Group ID", SegmentCode = "OBR", IndexLocation = 52 });
            list.Add(new DataElement { ElementCode = "Alternate Placer Order Number", SegmentCode = "OBR", IndexLocation = 53 });
            list.Add(new DataElement { ElementCode = "Parent Order", SegmentCode = "OBR", IndexLocation = 54 });
            #endregion

            #region "OBX"
            list.Add(new DataElement { ElementCode = "Set ID - OBX", SegmentCode = "OBX", IndexLocation = 1 });
            list.Add(new DataElement { ElementCode = "Value Type", SegmentCode = "OBX", IndexLocation = 2 });
            list.Add(new DataElement { ElementCode = "Observation Identifier", SegmentCode = "OBX", IndexLocation = 3 });
            list.Add(new DataElement { ElementCode = "Observation Sub_ID", SegmentCode = "OBX", IndexLocation = 4 });
            list.Add(new DataElement { ElementCode = "Observation Value", SegmentCode = "OBX", IndexLocation = 5 });
            list.Add(new DataElement { ElementCode = "Units", SegmentCode = "OBX", IndexLocation = 6 });
            list.Add(new DataElement { ElementCode = "References Range", SegmentCode = "OBX", IndexLocation = 7 });
            list.Add(new DataElement { ElementCode = "Interpretation Codes", SegmentCode = "OBX", IndexLocation = 8 });
            list.Add(new DataElement { ElementCode = "Probability", SegmentCode = "OBX", IndexLocation = 9 });
            list.Add(new DataElement { ElementCode = "Nature of Abnormal Test", SegmentCode = "OBX", IndexLocation = 10 });
            list.Add(new DataElement { ElementCode = "Observation Result Status", SegmentCode = "OBX", IndexLocation = 11 });
            list.Add(new DataElement { ElementCode = "Effective Date of Reference Range", SegmentCode = "OBX", IndexLocation = 12 });
            list.Add(new DataElement { ElementCode = "User Defined Access Checks", SegmentCode = "OBX", IndexLocation = 13 });
            list.Add(new DataElement { ElementCode = "DateTime of the Observation", SegmentCode = "OBX", IndexLocation = 14 });
            list.Add(new DataElement { ElementCode = "Producers ID", SegmentCode = "OBX", IndexLocation = 15 });
            list.Add(new DataElement { ElementCode = "Responsible Observer", SegmentCode = "OBX", IndexLocation = 16 });
            list.Add(new DataElement { ElementCode = "Observation Method", SegmentCode = "OBX", IndexLocation = 17 });
            list.Add(new DataElement { ElementCode = "Equipment Instance Identifier", SegmentCode = "OBX", IndexLocation = 18 });
            list.Add(new DataElement { ElementCode = "DateTime of the Analysis", SegmentCode = "OBX", IndexLocation = 19 });
            list.Add(new DataElement { ElementCode = "Observation Site", SegmentCode = "OBX", IndexLocation = 20 });
            list.Add(new DataElement { ElementCode = "Observation Instance Identifier", SegmentCode = "OBX", IndexLocation = 21 });
            list.Add(new DataElement { ElementCode = "Mood Code", SegmentCode = "OBX", IndexLocation = 22 });
            list.Add(new DataElement { ElementCode = "Performing Organization Name", SegmentCode = "OBX", IndexLocation = 23 });
            list.Add(new DataElement { ElementCode = "Performing Organization Address", SegmentCode = "OBX", IndexLocation = 24 });
            list.Add(new DataElement { ElementCode = "Performing Organization Medical Director", SegmentCode = "OBX", IndexLocation = 25 });
            list.Add(new DataElement { ElementCode = "Patient Results Release Category", SegmentCode = "OBX", IndexLocation = 26 });
            list.Add(new DataElement { ElementCode = "Root Cause", SegmentCode = "OBX", IndexLocation = 27 });
            list.Add(new DataElement { ElementCode = "Local Process Control", SegmentCode = "OBX", IndexLocation = 28 });
            list.Add(new DataElement { ElementCode = "Observation Type", SegmentCode = "OBX", IndexLocation = 29 });
            list.Add(new DataElement { ElementCode = "Observation Sub-Type", SegmentCode = "OBX", IndexLocation = 30 });
            #endregion

            #region "PID"
            list.Add(new DataElement { ElementCode = "Set ID", SegmentCode = "PID", IndexLocation = 1 });
            list.Add(new DataElement { ElementCode = "Patient ID", SegmentCode = "PID", IndexLocation = 2 });
            list.Add(new DataElement { ElementCode = "Patient Identifier List", SegmentCode = "PID", IndexLocation = 3 });
            list.Add(new DataElement { ElementCode = "Alternate Patient ID", SegmentCode = "PID", IndexLocation = 4 });
            list.Add(new DataElement { ElementCode = "Patient Name", SegmentCode = "PID", IndexLocation = 5 });
            list.Add(new DataElement { ElementCode = "Mothers Maiden Name", SegmentCode = "PID", IndexLocation = 6 });
            list.Add(new DataElement { ElementCode = "DateTime of Birth", SegmentCode = "PID", IndexLocation = 7 });
            list.Add(new DataElement { ElementCode = "Administrative Sex", SegmentCode = "PID", IndexLocation = 8 });
            list.Add(new DataElement { ElementCode = "Patient Alias", SegmentCode = "PID", IndexLocation = 9 });
            list.Add(new DataElement { ElementCode = "Race", SegmentCode = "PID", IndexLocation = 10 });
            list.Add(new DataElement { ElementCode = "Patient Address", SegmentCode = "PID", IndexLocation = 11 });
            list.Add(new DataElement { ElementCode = "County Code", SegmentCode = "PID", IndexLocation = 12 });
            list.Add(new DataElement { ElementCode = "Phone Number - Home", SegmentCode = "PID", IndexLocation = 13 });
            list.Add(new DataElement { ElementCode = "Phone Number - Business", SegmentCode = "PID", IndexLocation = 14 });
            list.Add(new DataElement { ElementCode = "Primary Language", SegmentCode = "PID", IndexLocation = 15 });
            list.Add(new DataElement { ElementCode = "Marital Status", SegmentCode = "PID", IndexLocation = 16 });
            list.Add(new DataElement { ElementCode = "Religion", SegmentCode = "PID", IndexLocation = 17 });
            list.Add(new DataElement { ElementCode = "Patient Account Number", SegmentCode = "PID", IndexLocation = 18 });
            list.Add(new DataElement { ElementCode = "SSN", SegmentCode = "PID", IndexLocation = 19 });
            list.Add(new DataElement { ElementCode = "Drivers License Number", SegmentCode = "PID", IndexLocation = 20 });
            list.Add(new DataElement { ElementCode = "Mothers Identifier", SegmentCode = "PID", IndexLocation = 21 });
            list.Add(new DataElement { ElementCode = "Ethnic Group", SegmentCode = "PID", IndexLocation = 22 });
            list.Add(new DataElement { ElementCode = "Birth Place", SegmentCode = "PID", IndexLocation = 23 });
            list.Add(new DataElement { ElementCode = "Multiple Birth Indicator", SegmentCode = "PID", IndexLocation = 24 });
            list.Add(new DataElement { ElementCode = "Birth Order", SegmentCode = "PID", IndexLocation = 25 });
            list.Add(new DataElement { ElementCode = "Citizenship", SegmentCode = "PID", IndexLocation = 26 });
            list.Add(new DataElement { ElementCode = "Veterans Military Status", SegmentCode = "PID", IndexLocation = 27 });
            list.Add(new DataElement { ElementCode = "Nationality", SegmentCode = "PID", IndexLocation = 28 });
            list.Add(new DataElement { ElementCode = "Patient Death Date and Time", SegmentCode = "PID", IndexLocation = 29 });
            list.Add(new DataElement { ElementCode = "Patient Death Indicator", SegmentCode = "PID", IndexLocation = 30 });
            list.Add(new DataElement { ElementCode = "Identity Unknown Indicator", SegmentCode = "PID", IndexLocation = 31 });
            list.Add(new DataElement { ElementCode = "Identity Reliability Code", SegmentCode = "PID", IndexLocation = 32 });
            list.Add(new DataElement { ElementCode = "Last Update Date Time", SegmentCode = "PID", IndexLocation = 33 });
            list.Add(new DataElement { ElementCode = "Last Update Facility", SegmentCode = "PID", IndexLocation = 34 });
            list.Add(new DataElement { ElementCode = "Taxonomic Classification Code", SegmentCode = "PID", IndexLocation = 35 });
            list.Add(new DataElement { ElementCode = "Breed Code", SegmentCode = "PID", IndexLocation = 36 });
            list.Add(new DataElement { ElementCode = "Strain", SegmentCode = "PID", IndexLocation = 37 });
            list.Add(new DataElement { ElementCode = "Production Class Code", SegmentCode = "PID", IndexLocation = 38 });
            list.Add(new DataElement { ElementCode = "Tribal Citizenship", SegmentCode = "PID", IndexLocation = 39 });
            list.Add(new DataElement { ElementCode = "Patient Telecommunication Information", SegmentCode = "PID", IndexLocation = 40 });
            #endregion

            #region "PV1"
            list.Add(new DataElement { ElementCode = "Set ID", SegmentCode = "PV1", IndexLocation = 1 });
            list.Add(new DataElement { ElementCode = "Patient Class", SegmentCode = "PV1", IndexLocation = 2 });
            list.Add(new DataElement { ElementCode = "Assigned Patient Location", SegmentCode = "PV1", IndexLocation = 3 });
            list.Add(new DataElement { ElementCode = "Admission Type", SegmentCode = "PV1", IndexLocation = 4 });
            list.Add(new DataElement { ElementCode = "Preadmit Number", SegmentCode = "PV1", IndexLocation = 5 });
            list.Add(new DataElement { ElementCode = "Prior Patient Location", SegmentCode = "PV1", IndexLocation = 6 });
            list.Add(new DataElement { ElementCode = "Attending Doctor", SegmentCode = "PV1", IndexLocation = 7 });
            list.Add(new DataElement { ElementCode = "Referring Doctor", SegmentCode = "PV1", IndexLocation = 8 });
            list.Add(new DataElement { ElementCode = "Consulting Doctor", SegmentCode = "PV1", IndexLocation = 9 });
            list.Add(new DataElement { ElementCode = "Hospital Service", SegmentCode = "PV1", IndexLocation = 10 });
            list.Add(new DataElement { ElementCode = "Temporary Location", SegmentCode = "PV1", IndexLocation = 11 });
            list.Add(new DataElement { ElementCode = "Preadmit Test Indicator", SegmentCode = "PV1", IndexLocation = 12 });
            list.Add(new DataElement { ElementCode = "Re-admission Indicator", SegmentCode = "PV1", IndexLocation = 13 });
            list.Add(new DataElement { ElementCode = "Admit Source", SegmentCode = "PV1", IndexLocation = 14 });
            list.Add(new DataElement { ElementCode = "Ambulatory Status", SegmentCode = "PV1", IndexLocation = 15 });
            list.Add(new DataElement { ElementCode = "VIP Indicator", SegmentCode = "PV1", IndexLocation = 16 });
            list.Add(new DataElement { ElementCode = "Admitting Doctor", SegmentCode = "PV1", IndexLocation = 17 });
            list.Add(new DataElement { ElementCode = "Patient Type", SegmentCode = "PV1", IndexLocation = 18 });
            list.Add(new DataElement { ElementCode = "Visit Number", SegmentCode = "PV1", IndexLocation = 19 });
            list.Add(new DataElement { ElementCode = "Financial Class", SegmentCode = "PV1", IndexLocation = 20 });
            list.Add(new DataElement { ElementCode = "Charge Price Indicator", SegmentCode = "PV1", IndexLocation = 21 });
            list.Add(new DataElement { ElementCode = "Courtesy Code", SegmentCode = "PV1", IndexLocation = 22 });
            list.Add(new DataElement { ElementCode = "Credit Rating", SegmentCode = "PV1", IndexLocation = 23 });
            list.Add(new DataElement { ElementCode = "Contract Code", SegmentCode = "PV1", IndexLocation = 24 });
            list.Add(new DataElement { ElementCode = "Contract Effective Date", SegmentCode = "PV1", IndexLocation = 25 });
            list.Add(new DataElement { ElementCode = "Contract Amount", SegmentCode = "PV1", IndexLocation = 26 });
            list.Add(new DataElement { ElementCode = "Contract Period", SegmentCode = "PV1", IndexLocation = 27 });
            list.Add(new DataElement { ElementCode = "Interest Code", SegmentCode = "PV1", IndexLocation = 28 });
            list.Add(new DataElement { ElementCode = "Transfer to Bad Dept Code", SegmentCode = "PV1", IndexLocation = 29 });
            list.Add(new DataElement { ElementCode = "Transfer to Bad Debt Date", SegmentCode = "PV1", IndexLocation = 30 });
            list.Add(new DataElement { ElementCode = "Bad Debt Agency Code", SegmentCode = "PV1", IndexLocation = 31 });
            list.Add(new DataElement { ElementCode = "Bad Debt Transfer Amount", SegmentCode = "PV1", IndexLocation = 32 });
            list.Add(new DataElement { ElementCode = "Bad Debt Recovery Amount", SegmentCode = "PV1", IndexLocation = 33 });
            list.Add(new DataElement { ElementCode = "Delete Account Indicator", SegmentCode = "PV1", IndexLocation = 34 });
            list.Add(new DataElement { ElementCode = "Delete Account Date", SegmentCode = "PV1", IndexLocation = 35 });
            list.Add(new DataElement { ElementCode = "Discharge Disposition", SegmentCode = "PV1", IndexLocation = 36 });
            list.Add(new DataElement { ElementCode = "Discharged to Location", SegmentCode = "PV1", IndexLocation = 37 });
            list.Add(new DataElement { ElementCode = "Diet Type", SegmentCode = "PV1", IndexLocation = 38 });
            list.Add(new DataElement { ElementCode = "Servicing Facility", SegmentCode = "PV1", IndexLocation = 39 });
            list.Add(new DataElement { ElementCode = "Bed Status", SegmentCode = "PV1", IndexLocation = 40 });
            list.Add(new DataElement { ElementCode = "Account Status", SegmentCode = "PV1", IndexLocation = 41 });
            list.Add(new DataElement { ElementCode = "Pending Location", SegmentCode = "PV1", IndexLocation = 42 });
            list.Add(new DataElement { ElementCode = "Prior Temporary Location", SegmentCode = "PV1", IndexLocation = 43 });
            list.Add(new DataElement { ElementCode = "Admit DateTime", SegmentCode = "PV1", IndexLocation = 44 });
            list.Add(new DataElement { ElementCode = "Discharge DateTime", SegmentCode = "PV1", IndexLocation = 45 });
            list.Add(new DataElement { ElementCode = "Current Patient Balance", SegmentCode = "PV1", IndexLocation = 46 });
            list.Add(new DataElement { ElementCode = "Total Charges", SegmentCode = "PV1", IndexLocation = 47 });
            list.Add(new DataElement { ElementCode = "Total Adjustments", SegmentCode = "PV1", IndexLocation = 48 });
            list.Add(new DataElement { ElementCode = "Total Payments", SegmentCode = "PV1", IndexLocation = 49 });
            list.Add(new DataElement { ElementCode = "Alternate Visit ID", SegmentCode = "PV1", IndexLocation = 50 });
            list.Add(new DataElement { ElementCode = "Visit Indicator", SegmentCode = "PV1", IndexLocation = 51 });
            list.Add(new DataElement { ElementCode = "Other Healthcare Provider", SegmentCode = "PV1", IndexLocation = 52 });
            list.Add(new DataElement { ElementCode = "Service Episode Description", SegmentCode = "PV1", IndexLocation = 53 });
            list.Add(new DataElement { ElementCode = "Service Episode Identifier", SegmentCode = "PV1", IndexLocation = 54 });
            #endregion

            #region "TXA"
            list.Add(new DataElement { ElementCode = "Set ID", SegmentCode = "TXA", IndexLocation = 1 });
            list.Add(new DataElement { ElementCode = "Document Type", SegmentCode = "TXA", IndexLocation = 2 });
            list.Add(new DataElement { ElementCode = "Document Content Presentation", SegmentCode = "TXA", IndexLocation = 3 });
            list.Add(new DataElement { ElementCode = "Activity DateTime", SegmentCode = "TXA", IndexLocation = 4 });
            list.Add(new DataElement { ElementCode = "Primary Activity Provider Code/Name", SegmentCode = "TXA", IndexLocation = 5 });
            list.Add(new DataElement { ElementCode = "Origination DateTime", SegmentCode = "TXA", IndexLocation = 6 });
            list.Add(new DataElement { ElementCode = "Transcription DateTime", SegmentCode = "TXA", IndexLocation = 7 });
            list.Add(new DataElement { ElementCode = "Edit DateTime", SegmentCode = "TXA", IndexLocation = 8 });
            list.Add(new DataElement { ElementCode = "Originator Code/Name", SegmentCode = "TXA", IndexLocation = 9 });
            list.Add(new DataElement { ElementCode = "Assigned Document Authenticator", SegmentCode = "TXA", IndexLocation = 10 });
            list.Add(new DataElement { ElementCode = "Transcriptionist Code/Name", SegmentCode = "TXA", IndexLocation = 11 });
            list.Add(new DataElement { ElementCode = "Unique Document Number", SegmentCode = "TXA", IndexLocation = 12 });
            list.Add(new DataElement { ElementCode = "Parent Document Number", SegmentCode = "TXA", IndexLocation = 13 });
            list.Add(new DataElement { ElementCode = "Placer Order Number", SegmentCode = "TXA", IndexLocation = 14 });
            list.Add(new DataElement { ElementCode = "Filler Order Number", SegmentCode = "TXA", IndexLocation = 15 });
            list.Add(new DataElement { ElementCode = "Unique Document File Name", SegmentCode = "TXA", IndexLocation = 16 });
            list.Add(new DataElement { ElementCode = "Document Completion Status", SegmentCode = "TXA", IndexLocation = 17 });
            list.Add(new DataElement { ElementCode = "Document Confidentiality Status", SegmentCode = "TXA", IndexLocation = 18 });
            list.Add(new DataElement { ElementCode = "Document Availability Status", SegmentCode = "TXA", IndexLocation = 19 });
            list.Add(new DataElement { ElementCode = "Document Storage Status", SegmentCode = "TXA", IndexLocation = 20 });
            list.Add(new DataElement { ElementCode = "Document Change Reason", SegmentCode = "TXA", IndexLocation = 21 });
            list.Add(new DataElement { ElementCode = "Authentication Person Time Stamp", SegmentCode = "TXA", IndexLocation = 22 });
            list.Add(new DataElement { ElementCode = "Distributed Copies", SegmentCode = "TXA", IndexLocation = 23 });
            list.Add(new DataElement { ElementCode = "Folder Assignment", SegmentCode = "TXA", IndexLocation = 24 });
            list.Add(new DataElement { ElementCode = "Document Title", SegmentCode = "TXA", IndexLocation = 25 });
            list.Add(new DataElement { ElementCode = "Agreed Due DateTime", SegmentCode = "TXA", IndexLocation = 26 });
            #endregion

            #region "SCH"
            list.Add(new DataElement { ElementCode = "Placer Appointment ID", SegmentCode = "SCH", IndexLocation = 1 });
            list.Add(new DataElement { ElementCode = "Filler Appointment ID", SegmentCode = "SCH", IndexLocation = 2 });
            list.Add(new DataElement { ElementCode = "Occurrence Number", SegmentCode = "SCH", IndexLocation = 3 });
            list.Add(new DataElement { ElementCode = "Placer Group Number", SegmentCode = "SCH", IndexLocation = 4 });
            list.Add(new DataElement { ElementCode = "Schedule ID", SegmentCode = "SCH", IndexLocation = 5 });
            list.Add(new DataElement { ElementCode = "Event Reason", SegmentCode = "SCH", IndexLocation = 6 });
            list.Add(new DataElement { ElementCode = "Appointment Reason", SegmentCode = "SCH", IndexLocation = 7 });
            list.Add(new DataElement { ElementCode = "Appointment Type", SegmentCode = "SCH", IndexLocation = 8 });
            list.Add(new DataElement { ElementCode = "Appointment Duration", SegmentCode = "SCH", IndexLocation = 9 });
            list.Add(new DataElement { ElementCode = "Appointment Duration Units", SegmentCode = "SCH", IndexLocation = 10 });
            list.Add(new DataElement { ElementCode = "Appointment Timing Quantity", SegmentCode = "SCH", IndexLocation = 11 });
            list.Add(new DataElement { ElementCode = "Placer Contact Person", SegmentCode = "SCH", IndexLocation = 12 });
            list.Add(new DataElement { ElementCode = "Placer Contact Phone Number", SegmentCode = "SCH", IndexLocation = 13 });
            list.Add(new DataElement { ElementCode = "Placer Contact Address", SegmentCode = "SCH", IndexLocation = 14 });
            list.Add(new DataElement { ElementCode = "Placer Contact Location", SegmentCode = "SCH", IndexLocation = 15 });
            list.Add(new DataElement { ElementCode = "Filler Contact Person", SegmentCode = "SCH", IndexLocation = 16 });
            list.Add(new DataElement { ElementCode = "Filler Contact Phone Number", SegmentCode = "SCH", IndexLocation = 17 });
            list.Add(new DataElement { ElementCode = "Filler Contact Address", SegmentCode = "SCH", IndexLocation = 18 });
            list.Add(new DataElement { ElementCode = "Filler Contact Location", SegmentCode = "SCH", IndexLocation = 19 });
            list.Add(new DataElement { ElementCode = "Entered By Person", SegmentCode = "SCH", IndexLocation = 20 });
            list.Add(new DataElement { ElementCode = "Entered By Phone Number", SegmentCode = "SCH", IndexLocation = 21 });
            list.Add(new DataElement { ElementCode = "Entered By Location", SegmentCode = "SCH", IndexLocation = 22 });
            list.Add(new DataElement { ElementCode = "Parent Placer Appointment ID", SegmentCode = "SCH", IndexLocation = 23 });
            list.Add(new DataElement { ElementCode = "Parent Filler Appointment ID", SegmentCode = "SCH", IndexLocation = 24 });
            list.Add(new DataElement { ElementCode = "Filler Status Code", SegmentCode = "SCH", IndexLocation = 25 });
            list.Add(new DataElement { ElementCode = "Placer Order Number", SegmentCode = "SCH", IndexLocation = 26 });
            list.Add(new DataElement { ElementCode = "Filler Order Number", SegmentCode = "SCH", IndexLocation = 27 });
            #endregion

            #region "ORC"
            list.Add(new DataElement { ElementCode = "Order Control", SegmentCode = "ORC", IndexLocation = 1 });
            list.Add(new DataElement { ElementCode = "Placer Order Number", SegmentCode = "ORC", IndexLocation = 2 });
            list.Add(new DataElement { ElementCode = "Filler Order Number", SegmentCode = "ORC", IndexLocation = 3 });
            list.Add(new DataElement { ElementCode = "Placer Group Number", SegmentCode = "ORC", IndexLocation = 4 });
            list.Add(new DataElement { ElementCode = "Order Status", SegmentCode = "ORC", IndexLocation = 5 });
            list.Add(new DataElement { ElementCode = "Response Flag", SegmentCode = "ORC", IndexLocation = 6 });
            list.Add(new DataElement { ElementCode = "Quantity/Timing", SegmentCode = "ORC", IndexLocation = 7 });
            list.Add(new DataElement { ElementCode = "Parent Order", SegmentCode = "ORC", IndexLocation = 8 });
            list.Add(new DataElement { ElementCode = "Date/Time of Transaction", SegmentCode = "ORC", IndexLocation = 9 });
            list.Add(new DataElement { ElementCode = "Entered By", SegmentCode = "ORC", IndexLocation = 10 });
            list.Add(new DataElement { ElementCode = "Verified By", SegmentCode = "ORC", IndexLocation = 11 });
            list.Add(new DataElement { ElementCode = "Ordering Provider", SegmentCode = "ORC", IndexLocation = 12 });
            list.Add(new DataElement { ElementCode = "Enterers Location", SegmentCode = "ORC", IndexLocation = 13 });
            list.Add(new DataElement { ElementCode = "Call Back Phone Number", SegmentCode = "ORC", IndexLocation = 14 });
            list.Add(new DataElement { ElementCode = "Order Effective Date/Time", SegmentCode = "ORC", IndexLocation = 15 });
            list.Add(new DataElement { ElementCode = "Order Control Code Reason", SegmentCode = "ORC", IndexLocation = 16 });
            list.Add(new DataElement { ElementCode = "Entering Organization", SegmentCode = "ORC", IndexLocation = 17 });
            list.Add(new DataElement { ElementCode = "Entering Device", SegmentCode = "ORC", IndexLocation = 18 });
            list.Add(new DataElement { ElementCode = "Action By", SegmentCode = "ORC", IndexLocation = 19 });
            list.Add(new DataElement { ElementCode = "Advanced Beneficiary Notice Code", SegmentCode = "ORC", IndexLocation = 20 });
            list.Add(new DataElement { ElementCode = "Ordering Facility Name", SegmentCode = "ORC", IndexLocation = 21 });
            list.Add(new DataElement { ElementCode = "Ordering Facility Address", SegmentCode = "ORC", IndexLocation = 22 });
            list.Add(new DataElement { ElementCode = "Ordering Facility Phone Number", SegmentCode = "ORC", IndexLocation = 23 });
            list.Add(new DataElement { ElementCode = "Ordering Provider Address", SegmentCode = "ORC", IndexLocation = 24 });
            list.Add(new DataElement { ElementCode = "Order Status Modifier", SegmentCode = "ORC", IndexLocation = 25 });
            list.Add(new DataElement { ElementCode = "Advanced Beneficiary Notice Override Reason", SegmentCode = "ORC", IndexLocation = 26 });
            list.Add(new DataElement { ElementCode = "Fillers Expected Availability Date/Time", SegmentCode = "ORC", IndexLocation = 27 });
            list.Add(new DataElement { ElementCode = "Confidentiality Code", SegmentCode = "ORC", IndexLocation = 28 });
            list.Add(new DataElement { ElementCode = "Order Type", SegmentCode = "ORC", IndexLocation = 29 });
            list.Add(new DataElement { ElementCode = "Enterer Authorization Mode", SegmentCode = "ORC", IndexLocation = 30 });
            list.Add(new DataElement { ElementCode = "Parent Universal Service Identifier", SegmentCode = "ORC", IndexLocation = 31 });
            list.Add(new DataElement { ElementCode = "Advanced Beneficiary Notice Date", SegmentCode = "ORC", IndexLocation = 32 });
            list.Add(new DataElement { ElementCode = "Alternate Placer Order Number", SegmentCode = "ORC", IndexLocation = 33 });
            list.Add(new DataElement { ElementCode = "Order Workflow Profile", SegmentCode = "ORC", IndexLocation = 34 });
            #endregion

            #region "RXA"
            list.Add(new DataElement { ElementCode = "Give Sub-ID Counter", SegmentCode = "RXA", IndexLocation = 1 });
            list.Add(new DataElement { ElementCode = "Administration Sub-ID Counter", SegmentCode = "RXA", IndexLocation = 2 });
            list.Add(new DataElement { ElementCode = "Date/Time Start of Administration", SegmentCode = "RXA", IndexLocation = 3 });
            list.Add(new DataElement { ElementCode = "Date/Time End of Administration", SegmentCode = "RXA", IndexLocation = 4 });
            list.Add(new DataElement { ElementCode = "Administered Code", SegmentCode = "RXA", IndexLocation = 5 });
            list.Add(new DataElement { ElementCode = "Administered Amount", SegmentCode = "RXA", IndexLocation = 6 });
            list.Add(new DataElement { ElementCode = "Administered Units", SegmentCode = "RXA", IndexLocation = 7 });
            list.Add(new DataElement { ElementCode = "Administered Dosage Form", SegmentCode = "RXA", IndexLocation = 8 });
            list.Add(new DataElement { ElementCode = "Administration Notes", SegmentCode = "RXA", IndexLocation = 9 });
            list.Add(new DataElement { ElementCode = "Administering Provider", SegmentCode = "RXA", IndexLocation = 10 });
            list.Add(new DataElement { ElementCode = "Administered-at Location", SegmentCode = "RXA", IndexLocation = 11 });
            list.Add(new DataElement { ElementCode = "Administered Per (Time Unit)", SegmentCode = "RXA", IndexLocation = 12 });
            list.Add(new DataElement { ElementCode = "Administered Strength", SegmentCode = "RXA", IndexLocation = 13 });
            list.Add(new DataElement { ElementCode = "Administered Strength Units", SegmentCode = "RXA", IndexLocation = 14 });
            list.Add(new DataElement { ElementCode = "Substance Lot Number", SegmentCode = "RXA", IndexLocation = 15 });
            list.Add(new DataElement { ElementCode = "Substance Expiration Date", SegmentCode = "RXA", IndexLocation = 16 });
            list.Add(new DataElement { ElementCode = "Substance Manufacturer Name", SegmentCode = "RXA", IndexLocation = 17 });
            list.Add(new DataElement { ElementCode = "Substance/Treatment Refusal Reason", SegmentCode = "RXA", IndexLocation = 18 });
            list.Add(new DataElement { ElementCode = "Indication", SegmentCode = "RXA", IndexLocation = 19 });
            list.Add(new DataElement { ElementCode = "Completion Status", SegmentCode = "RXA", IndexLocation = 20 });
            list.Add(new DataElement { ElementCode = "Action Code", SegmentCode = "RXA", IndexLocation = 21 });
            list.Add(new DataElement { ElementCode = "System Entry Date/Time", SegmentCode = "RXA", IndexLocation = 22 });
            list.Add(new DataElement { ElementCode = "Administered Drug Strength Volume", SegmentCode = "RXA", IndexLocation = 23 });
            list.Add(new DataElement { ElementCode = "Administered Drug Strength Volume Units", SegmentCode = "RXA", IndexLocation = 24 });
            list.Add(new DataElement { ElementCode = "Administered Barcode Identifier", SegmentCode = "RXA", IndexLocation = 25 });
            list.Add(new DataElement { ElementCode = "Pharmacy Order Type	ID", SegmentCode = "RXA", IndexLocation = 26 });
            list.Add(new DataElement { ElementCode = "Administer-at", SegmentCode = "RXA", IndexLocation = 27 });
            list.Add(new DataElement { ElementCode = "Administered-at Address	", SegmentCode = "RXA", IndexLocation = 28 });
            #endregion

            return list;
        }

        public static List<DataElement> GetDataElementsBySegment(string segmentCode)
        {
            return GetAllDataElements().FindAll(x => x.SegmentCode == segmentCode);
        }
    }
}
