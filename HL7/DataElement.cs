using System.Collections.Generic;

namespace HL7
{
    public class DataElement
    {
        public string ElementCode { get; set; } = "";
        public string SegmentCode { get; set; } = "";
        public int IndexLocation { get; set; } = 0;
        public string DataValue { get; set; } = "";

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

            list.Add(new DataElement { ElementCode = AIL_Set_ID, SegmentCode = "AIL", IndexLocation = 1 });
            list.Add(new DataElement { ElementCode = AIL_Segment_Action_Code, SegmentCode = "AIL", IndexLocation = 2 });
            list.Add(new DataElement { ElementCode = AIL_Location_Resource_ID, SegmentCode = "AIL", IndexLocation = 3 });
            list.Add(new DataElement { ElementCode = AIL_Location_Type_AIL, SegmentCode = "AIL", IndexLocation = 4 });
            list.Add(new DataElement { ElementCode = AIL_Location_Group, SegmentCode = "AIL", IndexLocation = 5 });
            list.Add(new DataElement { ElementCode = AIL_Start_DateTime, SegmentCode = "AIL", IndexLocation = 6 });
            list.Add(new DataElement { ElementCode = AIL_Start_DateTime_Offset, SegmentCode = "AIL", IndexLocation = 7 });
            list.Add(new DataElement { ElementCode = AIL_Start_DateTime_Offset_Units, SegmentCode = "AIL", IndexLocation = 8 });
            list.Add(new DataElement { ElementCode = AIL_Duration, SegmentCode = "AIL", IndexLocation = 9 });
            list.Add(new DataElement { ElementCode = AIL_Duration_Units, SegmentCode = "AIL", IndexLocation = 10 });
            list.Add(new DataElement { ElementCode = AIL_Allow_Subsitiutions, SegmentCode = "AIL", IndexLocation = 11 });
            list.Add(new DataElement { ElementCode = AIL_Filler_Status_Code, SegmentCode = "AIL", IndexLocation = 12 });

            #endregion "AIL"

            #region "EVN"

            list.Add(new DataElement { ElementCode = EVN_Event_Type_Code, SegmentCode = "EVN", IndexLocation = 1 });
            list.Add(new DataElement { ElementCode = EVN_Recorded_Date_Time, SegmentCode = "EVN", IndexLocation = 2 });
            list.Add(new DataElement { ElementCode = EVN_Date_Time_Planned_Event, SegmentCode = "EVN", IndexLocation = 3 });
            list.Add(new DataElement { ElementCode = EVN_Event_Reason_Code, SegmentCode = "EVN", IndexLocation = 4 });
            list.Add(new DataElement { ElementCode = EVN_Operator_ID, SegmentCode = "EVN", IndexLocation = 5 });
            list.Add(new DataElement { ElementCode = EVN_Event_Occured, SegmentCode = "EVN", IndexLocation = 6 });
            list.Add(new DataElement { ElementCode = EVN_Event_Facility, SegmentCode = "EVN", IndexLocation = 7 });

            #endregion "EVN"

            #region "MSH"

            //list.Add(new DataElement { ElementCode = "Field Separator", SegmentCode = "MSH", IndexLocation = 1 });
            list.Add(new DataElement { ElementCode = MSH_Encoding_Characters, SegmentCode = "MSH", IndexLocation = 2 });
            list.Add(new DataElement { ElementCode = MSH_Sending_Application, SegmentCode = "MSH", IndexLocation = 3 });
            list.Add(new DataElement { ElementCode = MSH_Sending_Facility, SegmentCode = "MSH", IndexLocation = 4 });
            list.Add(new DataElement { ElementCode = MSH_Receiving_Application, SegmentCode = "MSH", IndexLocation = 5 });
            list.Add(new DataElement { ElementCode = MSH_Receiving_Facility, SegmentCode = "MSH", IndexLocation = 6 });
            list.Add(new DataElement { ElementCode = MSH_Date_Time_of_Message, SegmentCode = "MSH", IndexLocation = 7 });
            list.Add(new DataElement { ElementCode = MSH_Security, SegmentCode = "MSH", IndexLocation = 8 });
            list.Add(new DataElement { ElementCode = MSH_Message_Type, SegmentCode = "MSH", IndexLocation = 9 });
            list.Add(new DataElement { ElementCode = MSH_Message_Control_ID, SegmentCode = "MSH", IndexLocation = 10 });
            list.Add(new DataElement { ElementCode = MSH_Processing_ID, SegmentCode = "MSH", IndexLocation = 11 });
            list.Add(new DataElement { ElementCode = MSH_Version_ID, SegmentCode = "MSH", IndexLocation = 12 });
            list.Add(new DataElement { ElementCode = MSH_Sequence_Number, SegmentCode = "MSH", IndexLocation = 13 });
            list.Add(new DataElement { ElementCode = MSH_Continuation_Pointer, SegmentCode = "MSH", IndexLocation = 14 });
            list.Add(new DataElement { ElementCode = MSH_Accept_Acknowledgment_Type, SegmentCode = "MSH", IndexLocation = 15 });
            list.Add(new DataElement { ElementCode = MSH_Application_Acknowledgment_Type, SegmentCode = "MSH", IndexLocation = 16 });
            list.Add(new DataElement { ElementCode = MSH_Country_Code, SegmentCode = "MSH", IndexLocation = 17 });
            list.Add(new DataElement { ElementCode = MSH_Character_Set, SegmentCode = "MSH", IndexLocation = 18 });
            list.Add(new DataElement { ElementCode = MSH_Principal_Language_Of_Message, SegmentCode = "MSH", IndexLocation = 19 });
            list.Add(new DataElement { ElementCode = MSH_Alternate_Character_Set_Handling_Scheme, SegmentCode = "MSH", IndexLocation = 20 });
            list.Add(new DataElement { ElementCode = MSH_Message_Profile_Identifier, SegmentCode = "MSH", IndexLocation = 21 });
            list.Add(new DataElement { ElementCode = MSH_Sending_Responsible_Organization, SegmentCode = "MSH", IndexLocation = 22 });
            list.Add(new DataElement { ElementCode = MSH_Receiving_Responsible_Organization, SegmentCode = "MSH", IndexLocation = 23 });
            list.Add(new DataElement { ElementCode = MSH_Sending_Network_Address, SegmentCode = "MSH", IndexLocation = 24 });
            list.Add(new DataElement { ElementCode = MSH_Receiving_Network_Address, SegmentCode = "MSH", IndexLocation = 25 });

            #endregion "MSH"

            #region "OBR"

            list.Add(new DataElement { ElementCode = OBR_Set_ID, SegmentCode = "OBR", IndexLocation = 1 });
            list.Add(new DataElement { ElementCode = OBR_Placer_Order_Number, SegmentCode = "OBR", IndexLocation = 2 });
            list.Add(new DataElement { ElementCode = OBR_Filler_Order_Number, SegmentCode = "OBR", IndexLocation = 3 });
            list.Add(new DataElement { ElementCode = OBR_Universal_Service_Identifier, SegmentCode = "OBR", IndexLocation = 4 });
            list.Add(new DataElement { ElementCode = OBR_Priority, SegmentCode = "OBR", IndexLocation = 5 });
            list.Add(new DataElement { ElementCode = OBR_Requested_DateTime, SegmentCode = "OBR", IndexLocation = 6 });
            list.Add(new DataElement { ElementCode = OBR_Observation_DateTime, SegmentCode = "OBR", IndexLocation = 7 });
            list.Add(new DataElement { ElementCode = OBR_Observation_End_DateTime, SegmentCode = "OBR", IndexLocation = 8 });
            list.Add(new DataElement { ElementCode = OBR_Collection_Volume, SegmentCode = "OBR", IndexLocation = 9 });
            list.Add(new DataElement { ElementCode = OBR_Collector_Identifer, SegmentCode = "OBR", IndexLocation = 10 });
            list.Add(new DataElement { ElementCode = OBR_Specimen_Action_Code, SegmentCode = "OBR", IndexLocation = 11 });
            list.Add(new DataElement { ElementCode = OBR_Danger_Code, SegmentCode = "OBR", IndexLocation = 12 });
            list.Add(new DataElement { ElementCode = OBR_Relevant_Clinical_Information, SegmentCode = "OBR", IndexLocation = 13 });
            list.Add(new DataElement { ElementCode = OBR_Specimen_Received_DateTime, SegmentCode = "OBR", IndexLocation = 14 });
            list.Add(new DataElement { ElementCode = OBR_Specimen_Source, SegmentCode = "OBR", IndexLocation = 15 });
            list.Add(new DataElement { ElementCode = OBR_Ordering_Provider, SegmentCode = "OBR", IndexLocation = 16 });
            list.Add(new DataElement { ElementCode = OBR_Order_Callback_Phone_Number, SegmentCode = "OBR", IndexLocation = 17 });
            list.Add(new DataElement { ElementCode = OBR_Placer_Field_1, SegmentCode = "OBR", IndexLocation = 18 });
            list.Add(new DataElement { ElementCode = OBR_Placer_Field_2, SegmentCode = "OBR", IndexLocation = 19 });
            list.Add(new DataElement { ElementCode = OBR_Filler_Field_1, SegmentCode = "OBR", IndexLocation = 20 });
            list.Add(new DataElement { ElementCode = OBR_Filler_Field_2, SegmentCode = "OBR", IndexLocation = 21 });
            list.Add(new DataElement { ElementCode = OBR_Results_Report_Status_Change_DateTime, SegmentCode = "OBR", IndexLocation = 22 });
            list.Add(new DataElement { ElementCode = OBR_Charge_to_Practice, SegmentCode = "OBR", IndexLocation = 23 });
            list.Add(new DataElement { ElementCode = OBR_Diagnostic_Serv_Sect_ID, SegmentCode = "OBR", IndexLocation = 24 });
            list.Add(new DataElement { ElementCode = OBR_Result_Status, SegmentCode = "OBR", IndexLocation = 25 });
            list.Add(new DataElement { ElementCode = OBR_Parent_Status, SegmentCode = "OBR", IndexLocation = 26 });
            list.Add(new DataElement { ElementCode = OBR_QuantityTiming, SegmentCode = "OBR", IndexLocation = 27 });
            list.Add(new DataElement { ElementCode = OBR_Result_Copies_To, SegmentCode = "OBR", IndexLocation = 28 });
            list.Add(new DataElement { ElementCode = OBR_Parent_Results_Observation_Identifier, SegmentCode = "OBR", IndexLocation = 29 });
            list.Add(new DataElement { ElementCode = OBR_Transportation_Mode, SegmentCode = "OBR", IndexLocation = 30 });
            list.Add(new DataElement { ElementCode = OBR_Reason_for_Study, SegmentCode = "OBR", IndexLocation = 31 });
            list.Add(new DataElement { ElementCode = OBR_Principal_Result_Interpreter, SegmentCode = "OBR", IndexLocation = 32 });
            list.Add(new DataElement { ElementCode = OBR_Assistant_Result_Interpreter, SegmentCode = "OBR", IndexLocation = 33 });
            list.Add(new DataElement { ElementCode = OBR_Technician, SegmentCode = "OBR", IndexLocation = 34 });
            list.Add(new DataElement { ElementCode = OBR_Transcriptionist, SegmentCode = "OBR", IndexLocation = 35 });
            list.Add(new DataElement { ElementCode = OBR_Scheduled_DateTime, SegmentCode = "OBR", IndexLocation = 36 });
            list.Add(new DataElement { ElementCode = OBR_Number_of_Sample_Containers, SegmentCode = "OBR", IndexLocation = 37 });
            list.Add(new DataElement { ElementCode = OBR_Transport_Logistics_of_Collected_Sample, SegmentCode = "OBR", IndexLocation = 38 });
            list.Add(new DataElement { ElementCode = OBR_Collectors_Comment, SegmentCode = "OBR", IndexLocation = 39 });
            list.Add(new DataElement { ElementCode = OBR_Transport_Arrangement_Responsibility, SegmentCode = "OBR", IndexLocation = 40 });
            list.Add(new DataElement { ElementCode = OBR_Transport_Arranged, SegmentCode = "OBR", IndexLocation = 41 });
            list.Add(new DataElement { ElementCode = OBR_Escort_Required, SegmentCode = "OBR", IndexLocation = 42 });
            list.Add(new DataElement { ElementCode = OBR_Planned_Patient_Transport_Comment, SegmentCode = "OBR", IndexLocation = 43 });
            list.Add(new DataElement { ElementCode = OBR_Procedure_Code, SegmentCode = "OBR", IndexLocation = 44 });
            list.Add(new DataElement { ElementCode = OBR_Procedure_Code_Modifier, SegmentCode = "OBR", IndexLocation = 45 });
            list.Add(new DataElement { ElementCode = OBR_Placer_Supplemental_Service_Information, SegmentCode = "OBR", IndexLocation = 46 });
            list.Add(new DataElement { ElementCode = OBR_Filler_Supplemental_Service_Information, SegmentCode = "OBR", IndexLocation = 47 });
            list.Add(new DataElement { ElementCode = OBR_Medically_Necessary_Duplicate_Procedure_Reason, SegmentCode = "OBR", IndexLocation = 48 });
            list.Add(new DataElement { ElementCode = OBR_Result_Handling, SegmentCode = "OBR", IndexLocation = 49 });
            list.Add(new DataElement { ElementCode = OBR_Parent_Universal_Service_Identifier, SegmentCode = "OBR", IndexLocation = 50 });
            list.Add(new DataElement { ElementCode = OBR_Observation_Group_ID, SegmentCode = "OBR", IndexLocation = 51 });
            list.Add(new DataElement { ElementCode = OBR_Parent_Observation_Group_ID, SegmentCode = "OBR", IndexLocation = 52 });
            list.Add(new DataElement { ElementCode = OBR_Alternate_Placer_Order_Number, SegmentCode = "OBR", IndexLocation = 53 });
            list.Add(new DataElement { ElementCode = OBR_Parent_Order, SegmentCode = "OBR", IndexLocation = 54 });

            #endregion "OBR"

            #region "OBX"

            list.Add(new DataElement { ElementCode = OBX_Set_ID, SegmentCode = "OBX", IndexLocation = 1 });
            list.Add(new DataElement { ElementCode = OBX_Value_Type, SegmentCode = "OBX", IndexLocation = 2 });
            list.Add(new DataElement { ElementCode = OBX_Observation_Identifier, SegmentCode = "OBX", IndexLocation = 3 });
            list.Add(new DataElement { ElementCode = OBX_Observation_Sub_ID, SegmentCode = "OBX", IndexLocation = 4 });
            list.Add(new DataElement { ElementCode = OBX_Observation_Value, SegmentCode = "OBX", IndexLocation = 5 });
            list.Add(new DataElement { ElementCode = OBX_Units, SegmentCode = "OBX", IndexLocation = 6 });
            list.Add(new DataElement { ElementCode = OBX_References_Range, SegmentCode = "OBX", IndexLocation = 7 });
            list.Add(new DataElement { ElementCode = OBX_Interpretation_Codes, SegmentCode = "OBX", IndexLocation = 8 });
            list.Add(new DataElement { ElementCode = OBX_Probability, SegmentCode = "OBX", IndexLocation = 9 });
            list.Add(new DataElement { ElementCode = OBX_Nature_of_Abnormal_Test, SegmentCode = "OBX", IndexLocation = 10 });
            list.Add(new DataElement { ElementCode = OBX_Observation_Result_Status, SegmentCode = "OBX", IndexLocation = 11 });
            list.Add(new DataElement { ElementCode = OBX_Effective_Date_of_Reference_Range, SegmentCode = "OBX", IndexLocation = 12 });
            list.Add(new DataElement { ElementCode = OBX_User_Defined_Access_Checks, SegmentCode = "OBX", IndexLocation = 13 });
            list.Add(new DataElement { ElementCode = OBX_DateTime_of_the_Observation, SegmentCode = "OBX", IndexLocation = 14 });
            list.Add(new DataElement { ElementCode = OBX_Producers_ID, SegmentCode = "OBX", IndexLocation = 15 });
            list.Add(new DataElement { ElementCode = OBX_Responsible_Observer, SegmentCode = "OBX", IndexLocation = 16 });
            list.Add(new DataElement { ElementCode = OBX_Observation_Method, SegmentCode = "OBX", IndexLocation = 17 });
            list.Add(new DataElement { ElementCode = OBX_Equipment_Instance_Identifier, SegmentCode = "OBX", IndexLocation = 18 });
            list.Add(new DataElement { ElementCode = OBX_DateTime_of_the_Analysis, SegmentCode = "OBX", IndexLocation = 19 });
            list.Add(new DataElement { ElementCode = OBX_Observation_Site, SegmentCode = "OBX", IndexLocation = 20 });
            list.Add(new DataElement { ElementCode = OBX_Observation_Instance_Identifier, SegmentCode = "OBX", IndexLocation = 21 });
            list.Add(new DataElement { ElementCode = OBX_Mood_Code, SegmentCode = "OBX", IndexLocation = 22 });
            list.Add(new DataElement { ElementCode = OBX_Performing_Organization_Name, SegmentCode = "OBX", IndexLocation = 23 });
            list.Add(new DataElement { ElementCode = OBX_Performing_Organization_Address, SegmentCode = "OBX", IndexLocation = 24 });
            list.Add(new DataElement { ElementCode = OBX_Performing_Organization_Medical_Director, SegmentCode = "OBX", IndexLocation = 25 });
            list.Add(new DataElement { ElementCode = OBX_Patient_Results_Release_Category, SegmentCode = "OBX", IndexLocation = 26 });
            list.Add(new DataElement { ElementCode = OBX_Root_Cause, SegmentCode = "OBX", IndexLocation = 27 });
            list.Add(new DataElement { ElementCode = OBX_Local_Process_Control, SegmentCode = "OBX", IndexLocation = 28 });
            list.Add(new DataElement { ElementCode = OBX_Observation_Type, SegmentCode = "OBX", IndexLocation = 29 });
            list.Add(new DataElement { ElementCode = OBX_Observation_Sub_Type, SegmentCode = "OBX", IndexLocation = 30 });

            #endregion "OBX"

            #region "PID"

            list.Add(new DataElement { ElementCode = PID_Set_ID, SegmentCode = "PID", IndexLocation = 1 });
            list.Add(new DataElement { ElementCode = PID_Patient_ID, SegmentCode = "PID", IndexLocation = 2 });
            list.Add(new DataElement { ElementCode = PID_Patient_Identifier_List, SegmentCode = "PID", IndexLocation = 3 });
            list.Add(new DataElement { ElementCode = PID_Alternate_Patient_ID, SegmentCode = "PID", IndexLocation = 4 });
            list.Add(new DataElement { ElementCode = PID_Patient_Name, SegmentCode = "PID", IndexLocation = 5 });
            list.Add(new DataElement { ElementCode = PID_Mothers_Maiden_Name, SegmentCode = "PID", IndexLocation = 6 });
            list.Add(new DataElement { ElementCode = PID_DateTime_of_Birth, SegmentCode = "PID", IndexLocation = 7 });
            list.Add(new DataElement { ElementCode = PID_Administrative_Sex, SegmentCode = "PID", IndexLocation = 8 });
            list.Add(new DataElement { ElementCode = PID_Patient_Alias, SegmentCode = "PID", IndexLocation = 9 });
            list.Add(new DataElement { ElementCode = PID_Race, SegmentCode = "PID", IndexLocation = 10 });
            list.Add(new DataElement { ElementCode = PID_Patient_Address, SegmentCode = "PID", IndexLocation = 11 });
            list.Add(new DataElement { ElementCode = PID_County_Code, SegmentCode = "PID", IndexLocation = 12 });
            list.Add(new DataElement { ElementCode = PID_Phone_Number_Home, SegmentCode = "PID", IndexLocation = 13 });
            list.Add(new DataElement { ElementCode = PID_Phone_Number_Business, SegmentCode = "PID", IndexLocation = 14 });
            list.Add(new DataElement { ElementCode = PID_Primary_Language, SegmentCode = "PID", IndexLocation = 15 });
            list.Add(new DataElement { ElementCode = PID_Marital_Status, SegmentCode = "PID", IndexLocation = 16 });
            list.Add(new DataElement { ElementCode = PID_Religion, SegmentCode = "PID", IndexLocation = 17 });
            list.Add(new DataElement { ElementCode = PID_Patient_Account_Number, SegmentCode = "PID", IndexLocation = 18 });
            list.Add(new DataElement { ElementCode = PID_SSN, SegmentCode = "PID", IndexLocation = 19 });
            list.Add(new DataElement { ElementCode = PID_Drivers_License_Number, SegmentCode = "PID", IndexLocation = 20 });
            list.Add(new DataElement { ElementCode = PID_Mothers_Identifier, SegmentCode = "PID", IndexLocation = 21 });
            list.Add(new DataElement { ElementCode = PID_Ethnic_Group, SegmentCode = "PID", IndexLocation = 22 });
            list.Add(new DataElement { ElementCode = PID_Birth_Place, SegmentCode = "PID", IndexLocation = 23 });
            list.Add(new DataElement { ElementCode = PID_Multiple_Birth_Indicator, SegmentCode = "PID", IndexLocation = 24 });
            list.Add(new DataElement { ElementCode = PID_Birth_Order, SegmentCode = "PID", IndexLocation = 25 });
            list.Add(new DataElement { ElementCode = PID_Citizenship, SegmentCode = "PID", IndexLocation = 26 });
            list.Add(new DataElement { ElementCode = PID_Veterans_Military_Status, SegmentCode = "PID", IndexLocation = 27 });
            list.Add(new DataElement { ElementCode = PID_Nationality, SegmentCode = "PID", IndexLocation = 28 });
            list.Add(new DataElement { ElementCode = PID_Patient_Death_Date_Time, SegmentCode = "PID", IndexLocation = 29 });
            list.Add(new DataElement { ElementCode = PID_Patient_Death_Indicator, SegmentCode = "PID", IndexLocation = 30 });
            list.Add(new DataElement { ElementCode = PID_Identity_Unknown_Indicator, SegmentCode = "PID", IndexLocation = 31 });
            list.Add(new DataElement { ElementCode = PID_Identity_Reliability_Code, SegmentCode = "PID", IndexLocation = 32 });
            list.Add(new DataElement { ElementCode = PID_Last_Update_Date_Time, SegmentCode = "PID", IndexLocation = 33 });
            list.Add(new DataElement { ElementCode = PID_Last_Update_Facility, SegmentCode = "PID", IndexLocation = 34 });
            list.Add(new DataElement { ElementCode = PID_Taxonomic_Classification_Code, SegmentCode = "PID", IndexLocation = 35 });
            list.Add(new DataElement { ElementCode = PID_Breed_Code, SegmentCode = "PID", IndexLocation = 36 });
            list.Add(new DataElement { ElementCode = PID_Strain, SegmentCode = "PID", IndexLocation = 37 });
            list.Add(new DataElement { ElementCode = PID_Production_Class_Code, SegmentCode = "PID", IndexLocation = 38 });
            list.Add(new DataElement { ElementCode = PID_Tribal_Citizenship, SegmentCode = "PID", IndexLocation = 39 });
            list.Add(new DataElement { ElementCode = PID_Patient_Telecommunication_Information, SegmentCode = "PID", IndexLocation = 40 });

            #endregion "PID"

            #region "PV1"

            list.Add(new DataElement { ElementCode = PV1_Set_ID, SegmentCode = "PV1", IndexLocation = 1 });
            list.Add(new DataElement { ElementCode = PV1_Patient_Class, SegmentCode = "PV1", IndexLocation = 2 });
            list.Add(new DataElement { ElementCode = PV1_Assigned_Patient_Location, SegmentCode = "PV1", IndexLocation = 3 });
            list.Add(new DataElement { ElementCode = PV1_Admission_Type, SegmentCode = "PV1", IndexLocation = 4 });
            list.Add(new DataElement { ElementCode = PV1_Preadmit_Number, SegmentCode = "PV1", IndexLocation = 5 });
            list.Add(new DataElement { ElementCode = PV1_Prior_Patient_Location, SegmentCode = "PV1", IndexLocation = 6 });
            list.Add(new DataElement { ElementCode = PV1_Attending_Doctor, SegmentCode = "PV1", IndexLocation = 7 });
            list.Add(new DataElement { ElementCode = PV1_Referring_Doctor, SegmentCode = "PV1", IndexLocation = 8 });
            list.Add(new DataElement { ElementCode = PV1_Consulting_Doctor, SegmentCode = "PV1", IndexLocation = 9 });
            list.Add(new DataElement { ElementCode = PV1_Hospital_Service, SegmentCode = "PV1", IndexLocation = 10 });
            list.Add(new DataElement { ElementCode = PV1_Temporary_Location, SegmentCode = "PV1", IndexLocation = 11 });
            list.Add(new DataElement { ElementCode = PV1_Preadmit_Test_Indicator, SegmentCode = "PV1", IndexLocation = 12 });
            list.Add(new DataElement { ElementCode = PV1_Readmission_Indicator, SegmentCode = "PV1", IndexLocation = 13 });
            list.Add(new DataElement { ElementCode = PV1_Admit_Source, SegmentCode = "PV1", IndexLocation = 14 });
            list.Add(new DataElement { ElementCode = PV1_Ambulatory_Status, SegmentCode = "PV1", IndexLocation = 15 });
            list.Add(new DataElement { ElementCode = PV1_VIP_Indicator, SegmentCode = "PV1", IndexLocation = 16 });
            list.Add(new DataElement { ElementCode = PV1_Admitting_Doctor, SegmentCode = "PV1", IndexLocation = 17 });
            list.Add(new DataElement { ElementCode = PV1_Patient_Type, SegmentCode = "PV1", IndexLocation = 18 });
            list.Add(new DataElement { ElementCode = PV1_Visit_Number, SegmentCode = "PV1", IndexLocation = 19 });
            list.Add(new DataElement { ElementCode = PV1_Financial_Class, SegmentCode = "PV1", IndexLocation = 20 });
            list.Add(new DataElement { ElementCode = PV1_Charge_Price_Indicator, SegmentCode = "PV1", IndexLocation = 21 });
            list.Add(new DataElement { ElementCode = PV1_Courtesy_Code, SegmentCode = "PV1", IndexLocation = 22 });
            list.Add(new DataElement { ElementCode = PV1_Credit_Rating, SegmentCode = "PV1", IndexLocation = 23 });
            list.Add(new DataElement { ElementCode = PV1_Contract_Code, SegmentCode = "PV1", IndexLocation = 24 });
            list.Add(new DataElement { ElementCode = PV1_Contract_Effective_Date, SegmentCode = "PV1", IndexLocation = 25 });
            list.Add(new DataElement { ElementCode = PV1_Contract_Amount, SegmentCode = "PV1", IndexLocation = 26 });
            list.Add(new DataElement { ElementCode = PV1_Contract_Period, SegmentCode = "PV1", IndexLocation = 27 });
            list.Add(new DataElement { ElementCode = PV1_Interest_Code, SegmentCode = "PV1", IndexLocation = 28 });
            list.Add(new DataElement { ElementCode = PV1_Transfer_to_Bad_Dept_Code, SegmentCode = "PV1", IndexLocation = 29 });
            list.Add(new DataElement { ElementCode = PV1_Transfer_to_Bad_Debt_Date, SegmentCode = "PV1", IndexLocation = 30 });
            list.Add(new DataElement { ElementCode = PV1_Bad_Debt_Agency_Code, SegmentCode = "PV1", IndexLocation = 31 });
            list.Add(new DataElement { ElementCode = PV1_Bad_Debt_Transfer_Amount, SegmentCode = "PV1", IndexLocation = 32 });
            list.Add(new DataElement { ElementCode = PV1_Bad_Debt_Recovery_Amount, SegmentCode = "PV1", IndexLocation = 33 });
            list.Add(new DataElement { ElementCode = PV1_Delete_Account_Indicator, SegmentCode = "PV1", IndexLocation = 34 });
            list.Add(new DataElement { ElementCode = PV1_Delete_Account_Date, SegmentCode = "PV1", IndexLocation = 35 });
            list.Add(new DataElement { ElementCode = PV1_Discharge_Disposition, SegmentCode = "PV1", IndexLocation = 36 });
            list.Add(new DataElement { ElementCode = PV1_Discharged_to_Location, SegmentCode = "PV1", IndexLocation = 37 });
            list.Add(new DataElement { ElementCode = PV1_Diet_Type, SegmentCode = "PV1", IndexLocation = 38 });
            list.Add(new DataElement { ElementCode = PV1_Servicing_Facility, SegmentCode = "PV1", IndexLocation = 39 });
            list.Add(new DataElement { ElementCode = PV1_Bed_Status, SegmentCode = "PV1", IndexLocation = 40 });
            list.Add(new DataElement { ElementCode = PV1_Account_Status, SegmentCode = "PV1", IndexLocation = 41 });
            list.Add(new DataElement { ElementCode = PV1_Pending_Location, SegmentCode = "PV1", IndexLocation = 42 });
            list.Add(new DataElement { ElementCode = PV1_Prior_Temporary_Location, SegmentCode = "PV1", IndexLocation = 43 });
            list.Add(new DataElement { ElementCode = PV1_Admit_DateTime, SegmentCode = "PV1", IndexLocation = 44 });
            list.Add(new DataElement { ElementCode = PV1_Discharge_DateTime, SegmentCode = "PV1", IndexLocation = 45 });
            list.Add(new DataElement { ElementCode = PV1_Current_Patient_Balance, SegmentCode = "PV1", IndexLocation = 46 });
            list.Add(new DataElement { ElementCode = PV1_Total_Charges, SegmentCode = "PV1", IndexLocation = 47 });
            list.Add(new DataElement { ElementCode = PV1_Total_Adjustments, SegmentCode = "PV1", IndexLocation = 48 });
            list.Add(new DataElement { ElementCode = PV1_Total_Payments, SegmentCode = "PV1", IndexLocation = 49 });
            list.Add(new DataElement { ElementCode = PV1_Alternate_Visit_ID, SegmentCode = "PV1", IndexLocation = 50 });
            list.Add(new DataElement { ElementCode = PV1_Visit_Indicator, SegmentCode = "PV1", IndexLocation = 51 });
            list.Add(new DataElement { ElementCode = PV1_Other_Healthcare_Provider, SegmentCode = "PV1", IndexLocation = 52 });
            list.Add(new DataElement { ElementCode = PV1_Service_Episode_Description, SegmentCode = "PV1", IndexLocation = 53 });
            list.Add(new DataElement { ElementCode = PV1_Service_Episode_Identifier, SegmentCode = "PV1", IndexLocation = 54 });

            #endregion "PV1"

            #region "TXA"

            list.Add(new DataElement { ElementCode = TXA_Set_ID, SegmentCode = "TXA", IndexLocation = 1 });
            list.Add(new DataElement { ElementCode = TXA_Document_Type, SegmentCode = "TXA", IndexLocation = 2 });
            list.Add(new DataElement { ElementCode = TXA_Document_Content_Presentation, SegmentCode = "TXA", IndexLocation = 3 });
            list.Add(new DataElement { ElementCode = TXA_Activity_DateTime, SegmentCode = "TXA", IndexLocation = 4 });
            list.Add(new DataElement { ElementCode = TXA_Primary_Activity_Provider_Code_Name, SegmentCode = "TXA", IndexLocation = 5 });
            list.Add(new DataElement { ElementCode = TXA_Origination_DateTime, SegmentCode = "TXA", IndexLocation = 6 });
            list.Add(new DataElement { ElementCode = TXA_Transcription_DateTime, SegmentCode = "TXA", IndexLocation = 7 });
            list.Add(new DataElement { ElementCode = TXA_Edit_DateTime, SegmentCode = "TXA", IndexLocation = 8 });
            list.Add(new DataElement { ElementCode = TXA_Originator_Code_Name, SegmentCode = "TXA", IndexLocation = 9 });
            list.Add(new DataElement { ElementCode = TXA_Assigned_Document_Authenticator, SegmentCode = "TXA", IndexLocation = 10 });
            list.Add(new DataElement { ElementCode = TXA_Transcriptionist_Code_Name, SegmentCode = "TXA", IndexLocation = 11 });
            list.Add(new DataElement { ElementCode = TXA_Unique_Document_Number, SegmentCode = "TXA", IndexLocation = 12 });
            list.Add(new DataElement { ElementCode = TXA_Parent_Document_Number, SegmentCode = "TXA", IndexLocation = 13 });
            list.Add(new DataElement { ElementCode = TXA_Placer_Order_Number, SegmentCode = "TXA", IndexLocation = 14 });
            list.Add(new DataElement { ElementCode = TXA_Filler_Order_Number, SegmentCode = "TXA", IndexLocation = 15 });
            list.Add(new DataElement { ElementCode = TXA_Unique_Document_File_Name, SegmentCode = "TXA", IndexLocation = 16 });
            list.Add(new DataElement { ElementCode = TXA_Document_Completion_Status, SegmentCode = "TXA", IndexLocation = 17 });
            list.Add(new DataElement { ElementCode = TXA_Document_Confidentiality_Status, SegmentCode = "TXA", IndexLocation = 18 });
            list.Add(new DataElement { ElementCode = TXA_Document_Availability_Status, SegmentCode = "TXA", IndexLocation = 19 });
            list.Add(new DataElement { ElementCode = TXA_Document_Storage_Status, SegmentCode = "TXA", IndexLocation = 20 });
            list.Add(new DataElement { ElementCode = TXA_Document_Change_Reason, SegmentCode = "TXA", IndexLocation = 21 });
            list.Add(new DataElement { ElementCode = TXA_Authentication_Person_Time_Stamp, SegmentCode = "TXA", IndexLocation = 22 });
            list.Add(new DataElement { ElementCode = TXA_Distributed_Copies, SegmentCode = "TXA", IndexLocation = 23 });
            list.Add(new DataElement { ElementCode = TXA_Folder_Assignment, SegmentCode = "TXA", IndexLocation = 24 });
            list.Add(new DataElement { ElementCode = TXA_Document_Title, SegmentCode = "TXA", IndexLocation = 25 });
            list.Add(new DataElement { ElementCode = TXA_Agreed_Due_DateTime, SegmentCode = "TXA", IndexLocation = 26 });

            #endregion "TXA"

            #region "SCH"

            list.Add(new DataElement { ElementCode = SCH_Placer_Appointment_ID, SegmentCode = "SCH", IndexLocation = 1 });
            list.Add(new DataElement { ElementCode = SCH_Filler_Appointment_ID, SegmentCode = "SCH", IndexLocation = 2 });
            list.Add(new DataElement { ElementCode = SCH_Occurrence_Number, SegmentCode = "SCH", IndexLocation = 3 });
            list.Add(new DataElement { ElementCode = SCH_Placer_Group_Number, SegmentCode = "SCH", IndexLocation = 4 });
            list.Add(new DataElement { ElementCode = SCH_Schedule_ID, SegmentCode = "SCH", IndexLocation = 5 });
            list.Add(new DataElement { ElementCode = SCH_Event_Reason, SegmentCode = "SCH", IndexLocation = 6 });
            list.Add(new DataElement { ElementCode = SCH_Appointment_Reason, SegmentCode = "SCH", IndexLocation = 7 });
            list.Add(new DataElement { ElementCode = SCH_Appointment_Type, SegmentCode = "SCH", IndexLocation = 8 });
            list.Add(new DataElement { ElementCode = SCH_Appointment_Duration, SegmentCode = "SCH", IndexLocation = 9 });
            list.Add(new DataElement { ElementCode = SCH_Appointment_Duration_Units, SegmentCode = "SCH", IndexLocation = 10 });
            list.Add(new DataElement { ElementCode = SCH_Appointment_Timing_Quantity, SegmentCode = "SCH", IndexLocation = 11 });
            list.Add(new DataElement { ElementCode = SCH_Placer_Contact_Person, SegmentCode = "SCH", IndexLocation = 12 });
            list.Add(new DataElement { ElementCode = SCH_Placer_Contact_Phone_Number, SegmentCode = "SCH", IndexLocation = 13 });
            list.Add(new DataElement { ElementCode = SCH_Placer_Contact_Address, SegmentCode = "SCH", IndexLocation = 14 });
            list.Add(new DataElement { ElementCode = SCH_Placer_Contact_Location, SegmentCode = "SCH", IndexLocation = 15 });
            list.Add(new DataElement { ElementCode = SCH_Filler_Contact_Person, SegmentCode = "SCH", IndexLocation = 16 });
            list.Add(new DataElement { ElementCode = SCH_Filler_Contact_Phone_Number, SegmentCode = "SCH", IndexLocation = 17 });
            list.Add(new DataElement { ElementCode = SCH_Filler_Contact_Address, SegmentCode = "SCH", IndexLocation = 18 });
            list.Add(new DataElement { ElementCode = SCH_Filler_Contact_Location, SegmentCode = "SCH", IndexLocation = 19 });
            list.Add(new DataElement { ElementCode = SCH_Entered_By_Person, SegmentCode = "SCH", IndexLocation = 20 });
            list.Add(new DataElement { ElementCode = SCH_Entered_By_Phone_Number, SegmentCode = "SCH", IndexLocation = 21 });
            list.Add(new DataElement { ElementCode = SCH_Entered_By_Location, SegmentCode = "SCH", IndexLocation = 22 });
            list.Add(new DataElement { ElementCode = SCH_Parent_Placer_Appointment_ID, SegmentCode = "SCH", IndexLocation = 23 });
            list.Add(new DataElement { ElementCode = SCH_Parent_Filler_Appointment_ID, SegmentCode = "SCH", IndexLocation = 24 });
            list.Add(new DataElement { ElementCode = SCH_Filler_Status_Code, SegmentCode = "SCH", IndexLocation = 25 });
            list.Add(new DataElement { ElementCode = SCH_Placer_Order_Number, SegmentCode = "SCH", IndexLocation = 26 });
            list.Add(new DataElement { ElementCode = SCH_Filler_Order_Number, SegmentCode = "SCH", IndexLocation = 27 });

            #endregion "SCH"

            #region "ORC"

            list.Add(new DataElement { ElementCode = ORC_Order_Control, SegmentCode = "ORC", IndexLocation = 1 });
            list.Add(new DataElement { ElementCode = ORC_Placer_Order_Number, SegmentCode = "ORC", IndexLocation = 2 });
            list.Add(new DataElement { ElementCode = ORC_Filler_Order_Number, SegmentCode = "ORC", IndexLocation = 3 });
            list.Add(new DataElement { ElementCode = ORC_Placer_Group_Number, SegmentCode = "ORC", IndexLocation = 4 });
            list.Add(new DataElement { ElementCode = ORC_Order_Status, SegmentCode = "ORC", IndexLocation = 5 });
            list.Add(new DataElement { ElementCode = ORC_Response_Flag, SegmentCode = "ORC", IndexLocation = 6 });
            list.Add(new DataElement { ElementCode = ORC_Quantity_Timing, SegmentCode = "ORC", IndexLocation = 7 });
            list.Add(new DataElement { ElementCode = ORC_Parent_Order, SegmentCode = "ORC", IndexLocation = 8 });
            list.Add(new DataElement { ElementCode = ORC_Date_Time_of_Transaction, SegmentCode = "ORC", IndexLocation = 9 });
            list.Add(new DataElement { ElementCode = ORC_Entered_By, SegmentCode = "ORC", IndexLocation = 10 });
            list.Add(new DataElement { ElementCode = ORC_Verified_By, SegmentCode = "ORC", IndexLocation = 11 });
            list.Add(new DataElement { ElementCode = ORC_Ordering_Provider, SegmentCode = "ORC", IndexLocation = 12 });
            list.Add(new DataElement { ElementCode = ORC_Enterers_Location, SegmentCode = "ORC", IndexLocation = 13 });
            list.Add(new DataElement { ElementCode = ORC_Call_Back_Phone_Number, SegmentCode = "ORC", IndexLocation = 14 });
            list.Add(new DataElement { ElementCode = ORC_Order_Effective_Date_Time, SegmentCode = "ORC", IndexLocation = 15 });
            list.Add(new DataElement { ElementCode = ORC_Order_Control_Code_Reason, SegmentCode = "ORC", IndexLocation = 16 });
            list.Add(new DataElement { ElementCode = ORC_Entering_Organization, SegmentCode = "ORC", IndexLocation = 17 });
            list.Add(new DataElement { ElementCode = ORC_Entering_Device, SegmentCode = "ORC", IndexLocation = 18 });
            list.Add(new DataElement { ElementCode = ORC_Action_By, SegmentCode = "ORC", IndexLocation = 19 });
            list.Add(new DataElement { ElementCode = ORC_Advanced_Beneficiary_Notice_Code, SegmentCode = "ORC", IndexLocation = 20 });
            list.Add(new DataElement { ElementCode = ORC_Ordering_Facility_Name, SegmentCode = "ORC", IndexLocation = 21 });
            list.Add(new DataElement { ElementCode = ORC_Ordering_Facility_Address, SegmentCode = "ORC", IndexLocation = 22 });
            list.Add(new DataElement { ElementCode = ORC_Ordering_Facility_Phone_Number, SegmentCode = "ORC", IndexLocation = 23 });
            list.Add(new DataElement { ElementCode = ORC_Ordering_Provider_Address, SegmentCode = "ORC", IndexLocation = 24 });
            list.Add(new DataElement { ElementCode = ORC_Order_Status_Modifier, SegmentCode = "ORC", IndexLocation = 25 });
            list.Add(new DataElement { ElementCode = ORC_Advanced_Beneficiary_Notice_Override_Reason, SegmentCode = "ORC", IndexLocation = 26 });
            list.Add(new DataElement { ElementCode = ORC_Fillers_Expected_Availability_Date_Time, SegmentCode = "ORC", IndexLocation = 27 });
            list.Add(new DataElement { ElementCode = ORC_Confidentiality_Code, SegmentCode = "ORC", IndexLocation = 28 });
            list.Add(new DataElement { ElementCode = ORC_Order_Type, SegmentCode = "ORC", IndexLocation = 29 });
            list.Add(new DataElement { ElementCode = ORC_Enterer_Authorization_Mode, SegmentCode = "ORC", IndexLocation = 30 });
            list.Add(new DataElement { ElementCode = ORC_Parent_Universal_Service_Identifier, SegmentCode = "ORC", IndexLocation = 31 });
            list.Add(new DataElement { ElementCode = ORC_Advanced_Beneficiary_Notice_Date, SegmentCode = "ORC", IndexLocation = 32 });
            list.Add(new DataElement { ElementCode = ORC_Alternate_Placer_Order_Number, SegmentCode = "ORC", IndexLocation = 33 });
            list.Add(new DataElement { ElementCode = ORC_Order_Workflow_Profile, SegmentCode = "ORC", IndexLocation = 34 });

            #endregion "ORC"

            #region "RXA"

            list.Add(new DataElement { ElementCode = RXA_Give_Sub_ID_Counter, SegmentCode = "RXA", IndexLocation = 1 });
            list.Add(new DataElement { ElementCode = RXA_Administration_Sub_ID_Counter, SegmentCode = "RXA", IndexLocation = 2 });
            list.Add(new DataElement { ElementCode = RXA_Date_Time_Start_of_Administration, SegmentCode = "RXA", IndexLocation = 3 });
            list.Add(new DataElement { ElementCode = RXA_Date_Time_End_of_Administration, SegmentCode = "RXA", IndexLocation = 4 });
            list.Add(new DataElement { ElementCode = RXA_Administered_Code, SegmentCode = "RXA", IndexLocation = 5 });
            list.Add(new DataElement { ElementCode = RXA_Administered_Amount, SegmentCode = "RXA", IndexLocation = 6 });
            list.Add(new DataElement { ElementCode = RXA_Administered_Units, SegmentCode = "RXA", IndexLocation = 7 });
            list.Add(new DataElement { ElementCode = RXA_Administered_Dosage_Form, SegmentCode = "RXA", IndexLocation = 8 });
            list.Add(new DataElement { ElementCode = RXA_Administration_Notes, SegmentCode = "RXA", IndexLocation = 9 });
            list.Add(new DataElement { ElementCode = RXA_Administering_Provider, SegmentCode = "RXA", IndexLocation = 10 });
            list.Add(new DataElement { ElementCode = RXA_Administered_at_Location, SegmentCode = "RXA", IndexLocation = 11 });
            list.Add(new DataElement { ElementCode = RXA_Administered_Per_Time_Unit, SegmentCode = "RXA", IndexLocation = 12 });
            list.Add(new DataElement { ElementCode = RXA_Administered_Strength, SegmentCode = "RXA", IndexLocation = 13 });
            list.Add(new DataElement { ElementCode = RXA_Administered_Strength_Units, SegmentCode = "RXA", IndexLocation = 14 });
            list.Add(new DataElement { ElementCode = RXA_Substance_Lot_Number, SegmentCode = "RXA", IndexLocation = 15 });
            list.Add(new DataElement { ElementCode = RXA_Substance_Expiration_Date, SegmentCode = "RXA", IndexLocation = 16 });
            list.Add(new DataElement { ElementCode = RXA_Substance_Manufacturer_Name, SegmentCode = "RXA", IndexLocation = 17 });
            list.Add(new DataElement { ElementCode = RXA_Substance_Treatment_Refusal_Reason, SegmentCode = "RXA", IndexLocation = 18 });
            list.Add(new DataElement { ElementCode = RXA_Indication, SegmentCode = "RXA", IndexLocation = 19 });
            list.Add(new DataElement { ElementCode = RXA_Completion_Status, SegmentCode = "RXA", IndexLocation = 20 });
            list.Add(new DataElement { ElementCode = RXA_Action_Code, SegmentCode = "RXA", IndexLocation = 21 });
            list.Add(new DataElement { ElementCode = RXA_System_Entry_Date_Time, SegmentCode = "RXA", IndexLocation = 22 });
            list.Add(new DataElement { ElementCode = RXA_Administered_Drug_Strength_Volume, SegmentCode = "RXA", IndexLocation = 23 });
            list.Add(new DataElement { ElementCode = RXA_Administered_Drug_Strength_Volume_Units, SegmentCode = "RXA", IndexLocation = 24 });
            list.Add(new DataElement { ElementCode = RXA_Administered_Barcode_Identifier, SegmentCode = "RXA", IndexLocation = 25 });
            list.Add(new DataElement { ElementCode = RXA_Pharmacy_Order_Type_ID, SegmentCode = "RXA", IndexLocation = 26 });

            #endregion "RXA"

            #region "RGS"

            list.Add(new DataElement { ElementCode = RGS_Set_ID, SegmentCode = "RGS", IndexLocation = 1 });
            list.Add(new DataElement { ElementCode = RGS_Segment_Action_Code, SegmentCode = "RGS", IndexLocation = 2 });
            list.Add(new DataElement { ElementCode = RGS_Resource_Group_ID, SegmentCode = "RGS", IndexLocation = 3 });

            #endregion "RGS"

            #region "ROL"

            list.Add(new DataElement { ElementCode = ROL_Role_Instance_ID, SegmentCode = "ROL", IndexLocation = 1 });
            list.Add(new DataElement { ElementCode = ROL_Action_Code, SegmentCode = "ROL", IndexLocation = 2 });
            list.Add(new DataElement { ElementCode = ROL_Role, SegmentCode = "ROL", IndexLocation = 3 });
            list.Add(new DataElement { ElementCode = ROL_Role_Person, SegmentCode = "ROL", IndexLocation = 4 });
            list.Add(new DataElement { ElementCode = ROL_Role_Begin_Date_Time, SegmentCode = "ROL", IndexLocation = 5 });
            list.Add(new DataElement { ElementCode = ROL_Role_End_Date_Time, SegmentCode = "ROL", IndexLocation = 6 });
            list.Add(new DataElement { ElementCode = ROL_Role_Duration, SegmentCode = "ROL", IndexLocation = 7 });
            list.Add(new DataElement { ElementCode = ROL_Role_Action_Reason, SegmentCode = "ROL", IndexLocation = 8 });
            list.Add(new DataElement { ElementCode = ROL_Provider_Type, SegmentCode = "ROL", IndexLocation = 9 });
            list.Add(new DataElement { ElementCode = ROL_Organization_Unit_Type, SegmentCode = "ROL", IndexLocation = 10 });
            list.Add(new DataElement { ElementCode = ROL_Office_Home_Address_Birthplace, SegmentCode = "ROL", IndexLocation = 11 });
            list.Add(new DataElement { ElementCode = ROL_Phone, SegmentCode = "ROL", IndexLocation = 12 });
            list.Add(new DataElement { ElementCode = ROL_Person_Location, SegmentCode = "ROL", IndexLocation = 13 });
            list.Add(new DataElement { ElementCode = ROL_Organization, SegmentCode = "ROL", IndexLocation = 14 });

            #endregion "ROL"

            #region "AIS"

            list.Add(new DataElement { ElementCode = AIS_Set_ID, SegmentCode = "AIS", IndexLocation = 1 });
            list.Add(new DataElement { ElementCode = AIS_Segment_Action_Code, SegmentCode = "AIS", IndexLocation = 2 });
            list.Add(new DataElement { ElementCode = AIS_Universal_Service_Identifier, SegmentCode = "AIS", IndexLocation = 3 });
            list.Add(new DataElement { ElementCode = AIS_Start_Date_Time, SegmentCode = "AIS", IndexLocation = 4 });
            list.Add(new DataElement { ElementCode = AIS_Start_Date_Time_Offset, SegmentCode = "AIS", IndexLocation = 5 });
            list.Add(new DataElement { ElementCode = AIS_Start_Date_Time_Offset_Units, SegmentCode = "AIS", IndexLocation = 6 });
            list.Add(new DataElement { ElementCode = AIS_Duration, SegmentCode = "AIS", IndexLocation = 7 });
            list.Add(new DataElement { ElementCode = AIS_Duration_Units, SegmentCode = "AIS", IndexLocation = 8 });
            list.Add(new DataElement { ElementCode = AIS_Allow_Substitution_Code, SegmentCode = "AIS", IndexLocation = 9 });
            list.Add(new DataElement { ElementCode = AIS_Filler_Status_Code, SegmentCode = "AIS", IndexLocation = 10 });
            list.Add(new DataElement { ElementCode = AIS_Placer_Supplemental_Service_Information, SegmentCode = "AIS", IndexLocation = 11 });
            list.Add(new DataElement { ElementCode = AIS_Filler_Supplemental_Service_Information, SegmentCode = "AIS", IndexLocation = 12 });

            #endregion "AIS"

            #region "AIP"

            list.Add(new DataElement { ElementCode = AIP_Set_ID, SegmentCode = "AIP", IndexLocation = 1 });
            list.Add(new DataElement { ElementCode = AIP_Segment_Action_Code, SegmentCode = "AIP", IndexLocation = 2 });
            list.Add(new DataElement { ElementCode = AIP_Personnel_Resource_ID, SegmentCode = "AIP", IndexLocation = 3 });
            list.Add(new DataElement { ElementCode = AIP_Resource_Type, SegmentCode = "AIP", IndexLocation = 4 });
            list.Add(new DataElement { ElementCode = AIP_Resource_Group, SegmentCode = "AIP", IndexLocation = 5 });
            list.Add(new DataElement { ElementCode = AIP_Start_Date_Time, SegmentCode = "AIP", IndexLocation = 6 });
            list.Add(new DataElement { ElementCode = AIP_Start_Date_Time_Offset, SegmentCode = "AIP", IndexLocation = 7 });
            list.Add(new DataElement { ElementCode = AIP_Start_Date_Time_Offset_Units, SegmentCode = "AIP", IndexLocation = 8 });
            list.Add(new DataElement { ElementCode = AIP_Duration, SegmentCode = "AIP", IndexLocation = 9 });
            list.Add(new DataElement { ElementCode = AIP_Duration_Units, SegmentCode = "AIP", IndexLocation = 10 });
            list.Add(new DataElement { ElementCode = AIP_Allow_Substitution_Code, SegmentCode = "AIP", IndexLocation = 11 });
            list.Add(new DataElement { ElementCode = AIP_Filler_Status_Code, SegmentCode = "AIP", IndexLocation = 12 });

            #endregion "AIP"

            #region "PR1"

            list.Add(new DataElement { ElementCode = PR1_Set_ID, SegmentCode = "PR1", IndexLocation = 1 });
            list.Add(new DataElement { ElementCode = PR1_Procedure_Coding_Method, SegmentCode = "PR1", IndexLocation = 2 });
            list.Add(new DataElement { ElementCode = PR1_Procedure_Code, SegmentCode = "PR1", IndexLocation = 3 });
            list.Add(new DataElement { ElementCode = PR1_Procedure_Description, SegmentCode = "PR1", IndexLocation = 4 });
            list.Add(new DataElement { ElementCode = PR1_Procedure_Date_Time, SegmentCode = "PR1", IndexLocation = 5 });
            list.Add(new DataElement { ElementCode = PR1_Procedure_Functional_Type, SegmentCode = "PR1", IndexLocation = 6 });
            list.Add(new DataElement { ElementCode = PR1_Procedure_Minutes, SegmentCode = "PR1", IndexLocation = 7 });
            list.Add(new DataElement { ElementCode = PR1_Anesthesiologist, SegmentCode = "PR1", IndexLocation = 8 });
            list.Add(new DataElement { ElementCode = PR1_Anesthesia_Code, SegmentCode = "PR1", IndexLocation = 9 });
            list.Add(new DataElement { ElementCode = PR1_Anesthesia_Minutes, SegmentCode = "PR1", IndexLocation = 10 });
            list.Add(new DataElement { ElementCode = PR1_Surgeon, SegmentCode = "PR1", IndexLocation = 11 });
            list.Add(new DataElement { ElementCode = PR1_Procedure_Practitioner, SegmentCode = "PR1", IndexLocation = 12 });
            list.Add(new DataElement { ElementCode = PR1_Consent_Code, SegmentCode = "PR1", IndexLocation = 13 });
            list.Add(new DataElement { ElementCode = PR1_Procedure_Priority, SegmentCode = "PR1", IndexLocation = 14 });
            list.Add(new DataElement { ElementCode = PR1_Associated_Diagnosis_Code, SegmentCode = "PR1", IndexLocation = 15 });
            list.Add(new DataElement { ElementCode = PR1_Procedure_Code_Modifier, SegmentCode = "PR1", IndexLocation = 16 });
            list.Add(new DataElement { ElementCode = PR1_Procedure_DRG_Type, SegmentCode = "PR1", IndexLocation = 17 });
            list.Add(new DataElement { ElementCode = PR1_Tissue_Type_Code, SegmentCode = "PR1", IndexLocation = 18 });
            list.Add(new DataElement { ElementCode = PR1_Procedure_Identifier, SegmentCode = "PR1", IndexLocation = 19 });
            list.Add(new DataElement { ElementCode = PR1_Procedure_Action_Code, SegmentCode = "PR1", IndexLocation = 20 });
            list.Add(new DataElement { ElementCode = PR1_DRG_Procedure_Determination_Status, SegmentCode = "PR1", IndexLocation = 21 });
            list.Add(new DataElement { ElementCode = PR1_DRG_Procedure_Relevance, SegmentCode = "PR1", IndexLocation = 22 });
            list.Add(new DataElement { ElementCode = PR1_Treating_Organizational_Unit, SegmentCode = "PR1", IndexLocation = 23 });
            list.Add(new DataElement { ElementCode = PR1_Respiratory_Within_Surgery, SegmentCode = "PR1", IndexLocation = 24 });
            list.Add(new DataElement { ElementCode = PR1_Parent_Procedure_ID, SegmentCode = "PR1", IndexLocation = 25 });

            #endregion "PR1"

            #region "NTE"

            list.Add(new DataElement { ElementCode = NTE_Set_ID, SegmentCode = "NTE", IndexLocation = 1 });
            list.Add(new DataElement { ElementCode = NTE_Source_of_Comment, SegmentCode = "NTE", IndexLocation = 2 });
            list.Add(new DataElement { ElementCode = NTE_Comment, SegmentCode = "NTE", IndexLocation = 3 });
            list.Add(new DataElement { ElementCode = NTE_Comment_Type, SegmentCode = "NTE", IndexLocation = 4 });
            list.Add(new DataElement { ElementCode = NTE_Entered_By, SegmentCode = "NTE", IndexLocation = 5 });
            list.Add(new DataElement { ElementCode = NTE_Entered_Date_Time, SegmentCode = "NTE", IndexLocation = 6 });
            list.Add(new DataElement { ElementCode = NTE_Effective_Start_Date, SegmentCode = "NTE", IndexLocation = 7 });
            list.Add(new DataElement { ElementCode = NTE_Expiration_Date, SegmentCode = "NTE", IndexLocation = 8 });

            #endregion "NTE"

            #region "NK1"

            list.Add(new DataElement { ElementCode = NK1_Set_ID, SegmentCode = "NK1", IndexLocation = 1 });
            list.Add(new DataElement { ElementCode = NK1_Name, SegmentCode = "NK1", IndexLocation = 2 });
            list.Add(new DataElement { ElementCode = NK1_Relationship, SegmentCode = "NK1", IndexLocation = 3 });
            list.Add(new DataElement { ElementCode = NK1_Address, SegmentCode = "NK1", IndexLocation = 4 });
            list.Add(new DataElement { ElementCode = NK1_Phone_Number, SegmentCode = "NK1", IndexLocation = 5 });
            list.Add(new DataElement { ElementCode = NK1_Business_Phone_Number, SegmentCode = "NK1", IndexLocation = 6 });
            list.Add(new DataElement { ElementCode = NK1_Contact_Role, SegmentCode = "NK1", IndexLocation = 7 });
            list.Add(new DataElement { ElementCode = NK1_Start_Date, SegmentCode = "NK1", IndexLocation = 8 });
            list.Add(new DataElement { ElementCode = NK1_End_Date, SegmentCode = "NK1", IndexLocation = 9 });
            list.Add(new DataElement { ElementCode = NK1_Next_of_Kin_Associated_Parties_Job_Title, SegmentCode = "NK1", IndexLocation = 10 });
            list.Add(new DataElement { ElementCode = NK1_Next_of_Kin_Associated_Parties_Job_Code_Class, SegmentCode = "NK1", IndexLocation = 11 });
            list.Add(new DataElement { ElementCode = NK1_Next_of_Kin_Associated_Parties_Employee_Number, SegmentCode = "NK1", IndexLocation = 12 });
            list.Add(new DataElement { ElementCode = NK1_Organization_Name, SegmentCode = "NK1", IndexLocation = 13 });
            list.Add(new DataElement { ElementCode = NK1_Marital_Status, SegmentCode = "NK1", IndexLocation = 14 });
            list.Add(new DataElement { ElementCode = NK1_Administrative_Sex, SegmentCode = "NK1", IndexLocation = 15 });
            list.Add(new DataElement { ElementCode = NK1_Date_Time_of_Birth, SegmentCode = "NK1", IndexLocation = 16 });
            list.Add(new DataElement { ElementCode = NK1_Living_Dependency, SegmentCode = "NK1", IndexLocation = 17 });
            list.Add(new DataElement { ElementCode = NK1_Ambulatory_Status, SegmentCode = "NK1", IndexLocation = 18 });
            list.Add(new DataElement { ElementCode = NK1_Citizenship, SegmentCode = "NK1", IndexLocation = 19 });
            list.Add(new DataElement { ElementCode = NK1_Primary_Language, SegmentCode = "NK1", IndexLocation = 20 });
            list.Add(new DataElement { ElementCode = NK1_Living_Arrangement, SegmentCode = "NK1", IndexLocation = 21 });
            list.Add(new DataElement { ElementCode = NK1_Publicity_Code, SegmentCode = "NK1", IndexLocation = 22 });
            list.Add(new DataElement { ElementCode = NK1_Protection_Indicator, SegmentCode = "NK1", IndexLocation = 23 });
            list.Add(new DataElement { ElementCode = NK1_Student_Indicator, SegmentCode = "NK1", IndexLocation = 24 });
            list.Add(new DataElement { ElementCode = NK1_Relationship, SegmentCode = "NK1", IndexLocation = 25 });
            list.Add(new DataElement { ElementCode = NK1_Mothers_Maiden_Name, SegmentCode = "NK1", IndexLocation = 26 });
            list.Add(new DataElement { ElementCode = NK1_Nationality, SegmentCode = "NK1", IndexLocation = 27 });
            list.Add(new DataElement { ElementCode = NK1_Ethnic_Group, SegmentCode = "NK1", IndexLocation = 28 });
            list.Add(new DataElement { ElementCode = NK1_Contact_Reason, SegmentCode = "NK1", IndexLocation = 29 });
            list.Add(new DataElement { ElementCode = NK1_Contact_Persons_Name, SegmentCode = "NK1", IndexLocation = 30 });
            list.Add(new DataElement { ElementCode = NK1_Contact_Persons_Telephone_Number, SegmentCode = "NK1", IndexLocation = 31 });
            list.Add(new DataElement { ElementCode = NK1_Contact_Persons_Address, SegmentCode = "NK1", IndexLocation = 32 });
            list.Add(new DataElement { ElementCode = NK1_Next_of_Kin_Associated_Partys_Identifiers, SegmentCode = "NK1", IndexLocation = 33 });
            list.Add(new DataElement { ElementCode = NK1_Job_Status, SegmentCode = "NK1", IndexLocation = 34 });
            list.Add(new DataElement { ElementCode = NK1_Race, SegmentCode = "NK1", IndexLocation = 35 });
            list.Add(new DataElement { ElementCode = NK1_Handicap, SegmentCode = "NK1", IndexLocation = 36 });
            list.Add(new DataElement { ElementCode = NK1_Contact_Person_Social_Security_Number, SegmentCode = "NK1", IndexLocation = 37 });
            list.Add(new DataElement { ElementCode = NK1_Next_of_Kin_Birth_Place, SegmentCode = "NK1", IndexLocation = 38 });
            list.Add(new DataElement { ElementCode = NK1_VIP_Indicator, SegmentCode = "NK1", IndexLocation = 39 });
            list.Add(new DataElement { ElementCode = NK1_Next_of_Kin_Telecommunication_Information, SegmentCode = "NK1", IndexLocation = 40 });
            list.Add(new DataElement { ElementCode = NK1_Contact_Persons_Telecommunication_Information, SegmentCode = "NK1", IndexLocation = 41 });

            #endregion "NK1"

            #region "PV2"

            list.Add(new DataElement { ElementCode = PV2_Prior_Pending_Location, SegmentCode = "PV2", IndexLocation = 1 });
            list.Add(new DataElement { ElementCode = PV2_Accommodation_Code, SegmentCode = "PV2", IndexLocation = 2 });
            list.Add(new DataElement { ElementCode = PV2_Admit_Reason, SegmentCode = "PV2", IndexLocation = 3 });
            list.Add(new DataElement { ElementCode = PV2_Transfer_Reason, SegmentCode = "PV2", IndexLocation = 4 });
            list.Add(new DataElement { ElementCode = PV2_Patient_Valuables, SegmentCode = "PV2", IndexLocation = 5 });
            list.Add(new DataElement { ElementCode = PV2_Patient_Valuables_Location, SegmentCode = "PV2", IndexLocation = 6 });
            list.Add(new DataElement { ElementCode = PV2_Visit_User_Code, SegmentCode = "PV2", IndexLocation = 7 });
            list.Add(new DataElement { ElementCode = PV2_Expected_Admit_Date_Time, SegmentCode = "PV2", IndexLocation = 8 });
            list.Add(new DataElement { ElementCode = PV2_Expected_Discharge_Date_Time, SegmentCode = "PV2", IndexLocation = 9 });
            list.Add(new DataElement { ElementCode = PV2_Estimated_Length_of_Inpatient_Stay, SegmentCode = "PV2", IndexLocation = 10 });
            list.Add(new DataElement { ElementCode = PV2_Actual_Length_of_Inpatient_Stay, SegmentCode = "PV2", IndexLocation = 11 });
            list.Add(new DataElement { ElementCode = PV2_Visit_Description, SegmentCode = "PV2", IndexLocation = 12 });
            list.Add(new DataElement { ElementCode = PV2_Referral_Source_Code, SegmentCode = "PV2", IndexLocation = 13 });
            list.Add(new DataElement { ElementCode = PV2_Previous_Service_Date, SegmentCode = "PV2", IndexLocation = 14 });
            list.Add(new DataElement { ElementCode = PV2_Employment_Illness_Related_Indicator, SegmentCode = "PV2", IndexLocation = 15 });
            list.Add(new DataElement { ElementCode = PV2_Purge_Status_Code, SegmentCode = "PV2", IndexLocation = 16 });
            list.Add(new DataElement { ElementCode = PV2_Purge_Status_Date, SegmentCode = "PV2", IndexLocation = 17 });
            list.Add(new DataElement { ElementCode = PV2_Special_Program_Code, SegmentCode = "PV2", IndexLocation = 18 });
            list.Add(new DataElement { ElementCode = PV2_Retention_Indicator, SegmentCode = "PV2", IndexLocation = 19 });
            list.Add(new DataElement { ElementCode = PV2_Expected_Number_of_Insurance_Plans, SegmentCode = "PV2", IndexLocation = 20 });
            list.Add(new DataElement { ElementCode = PV2_Visit_Priority_Code, SegmentCode = "PV2", IndexLocation = 21 });
            list.Add(new DataElement { ElementCode = PV2_Visit_Protection_Indicator, SegmentCode = "PV2", IndexLocation = 22 });
            list.Add(new DataElement { ElementCode = PV2_Clinic_Organization_Name, SegmentCode = "PV2", IndexLocation = 23 });
            list.Add(new DataElement { ElementCode = PV2_Patient_Status_Code, SegmentCode = "PV2", IndexLocation = 24 });
            list.Add(new DataElement { ElementCode = PV2_Visit_Priority_Code, SegmentCode = "PV2", IndexLocation = 25 });
            list.Add(new DataElement { ElementCode = PV2_Previous_Treatment_Date, SegmentCode = "PV2", IndexLocation = 26 });
            list.Add(new DataElement { ElementCode = PV2_Expected_Discharge_Disposition, SegmentCode = "PV2", IndexLocation = 27 });
            list.Add(new DataElement { ElementCode = PV2_Signature_on_File_Date, SegmentCode = "PV2", IndexLocation = 28 });
            list.Add(new DataElement { ElementCode = PV2_First_Similar_Illness_Date, SegmentCode = "PV2", IndexLocation = 29 });
            list.Add(new DataElement { ElementCode = PV2_Patient_Charge_Adjustment_Code, SegmentCode = "PV2", IndexLocation = 30 });
            list.Add(new DataElement { ElementCode = PV2_Recurring_Service_Code, SegmentCode = "PV2", IndexLocation = 31 });
            list.Add(new DataElement { ElementCode = PV2_Billing_Media_Code, SegmentCode = "PV2", IndexLocation = 32 });
            list.Add(new DataElement { ElementCode = PV2_Expected_Surgery_Date_and_Time, SegmentCode = "PV2", IndexLocation = 33 });
            list.Add(new DataElement { ElementCode = PV2_Military_Partnership_Code, SegmentCode = "PV2", IndexLocation = 34 });
            list.Add(new DataElement { ElementCode = PV2_Military_Non_Availability_Code, SegmentCode = "PV2", IndexLocation = 35 });
            list.Add(new DataElement { ElementCode = PV2_Newborn_Baby_Indicator, SegmentCode = "PV2", IndexLocation = 36 });
            list.Add(new DataElement { ElementCode = PV2_Baby_Detained_Indicator, SegmentCode = "PV2", IndexLocation = 37 });
            list.Add(new DataElement { ElementCode = PV2_Mode_of_Arrival_Code, SegmentCode = "PV2", IndexLocation = 38 });
            list.Add(new DataElement { ElementCode = PV2_Recreational_Drug_Use_Code, SegmentCode = "PV2", IndexLocation = 39 });
            list.Add(new DataElement { ElementCode = PV2_Admission_Level_of_Care_Code, SegmentCode = "PV2", IndexLocation = 40 });
            list.Add(new DataElement { ElementCode = PV2_Precaution_Code, SegmentCode = "PV2", IndexLocation = 41 });
            list.Add(new DataElement { ElementCode = PV2_Patient_Condition_Code, SegmentCode = "PV2", IndexLocation = 42 });
            list.Add(new DataElement { ElementCode = PV2_Living_Will_Code, SegmentCode = "PV2", IndexLocation = 43 });
            list.Add(new DataElement { ElementCode = PV2_Organ_Donor_Code, SegmentCode = "PV2", IndexLocation = 44 });
            list.Add(new DataElement { ElementCode = PV2_Advance_Directive_Code, SegmentCode = "PV2", IndexLocation = 45 });
            list.Add(new DataElement { ElementCode = PV2_Patient_Status_Effective_Date, SegmentCode = "PV2", IndexLocation = 46 });
            list.Add(new DataElement { ElementCode = PV2_Expected_LOA_Return_Date_Time, SegmentCode = "PV2", IndexLocation = 47 });
            list.Add(new DataElement { ElementCode = PV2_Expected_Preadmission_Testing_Date_Time, SegmentCode = "PV2", IndexLocation = 48 });
            list.Add(new DataElement { ElementCode = PV2_Notify_Clergy_Code, SegmentCode = "PV2", IndexLocation = 49 });
            list.Add(new DataElement { ElementCode = PV2_Advance_Directive_Last_Verified_Date, SegmentCode = "PV2", IndexLocation = 50 });

            #endregion "PV2"

            #region "DRG"

            list.Add(new DataElement { ElementCode = DRG_Diagnostic_Related_Group, SegmentCode = "DRG", IndexLocation = 1 });
            list.Add(new DataElement { ElementCode = DRG_Assigned_Date_Time, SegmentCode = "DRG", IndexLocation = 2 });
            list.Add(new DataElement { ElementCode = DRG_Approval_Indicator, SegmentCode = "DRG", IndexLocation = 3 });
            list.Add(new DataElement { ElementCode = DRG_Grouper_Review_Code, SegmentCode = "DRG", IndexLocation = 4 });
            list.Add(new DataElement { ElementCode = DRG_Outlier_Type, SegmentCode = "DRG", IndexLocation = 5 });
            list.Add(new DataElement { ElementCode = DRG_Outlier_Days, SegmentCode = "DRG", IndexLocation = 6 });
            list.Add(new DataElement { ElementCode = DRG_Outlier_Cost, SegmentCode = "DRG", IndexLocation = 7 });
            list.Add(new DataElement { ElementCode = DRG_Payor, SegmentCode = "DRG", IndexLocation = 8 });
            list.Add(new DataElement { ElementCode = DRG_Outlier_Reimbursement, SegmentCode = "DRG", IndexLocation = 9 });
            list.Add(new DataElement { ElementCode = DRG_Confidential_Indicator, SegmentCode = "DRG", IndexLocation = 10 });
            list.Add(new DataElement { ElementCode = DRG_Transfer_Type, SegmentCode = "DRG", IndexLocation = 11 });
            list.Add(new DataElement { ElementCode = DRG_Name_of_Coder, SegmentCode = "DRG", IndexLocation = 12 });
            list.Add(new DataElement { ElementCode = DRG_Grouper_Status, SegmentCode = "DRG", IndexLocation = 13 });
            list.Add(new DataElement { ElementCode = DRG_PCCL_Value_Code, SegmentCode = "DRG", IndexLocation = 14 });
            list.Add(new DataElement { ElementCode = DRG_Effective_Weight, SegmentCode = "DRG", IndexLocation = 15 });
            list.Add(new DataElement { ElementCode = DRG_Monetary_Amount, SegmentCode = "DRG", IndexLocation = 16 });
            list.Add(new DataElement { ElementCode = DRG_Status_Patient, SegmentCode = "DRG", IndexLocation = 17 });
            list.Add(new DataElement { ElementCode = DRG_Grouper_Software_Name, SegmentCode = "DRG", IndexLocation = 18 });
            list.Add(new DataElement { ElementCode = DRG_Grouper_Software_Version, SegmentCode = "DRG", IndexLocation = 19 });
            list.Add(new DataElement { ElementCode = DRG_Status_Financial_Calculation, SegmentCode = "DRG", IndexLocation = 20 });
            list.Add(new DataElement { ElementCode = DRG_Relative_Discount_Surcharge, SegmentCode = "DRG", IndexLocation = 21 });
            list.Add(new DataElement { ElementCode = DRG_Basic_Charge, SegmentCode = "DRG", IndexLocation = 22 });
            list.Add(new DataElement { ElementCode = DRG_Total_Charge, SegmentCode = "DRG", IndexLocation = 23 });
            list.Add(new DataElement { ElementCode = DRG_Discount_Surcharge, SegmentCode = "DRG", IndexLocation = 24 });
            list.Add(new DataElement { ElementCode = DRG_Calculated_Days, SegmentCode = "DRG", IndexLocation = 25 });
            list.Add(new DataElement { ElementCode = DRG_Status_Gender, SegmentCode = "DRG", IndexLocation = 26 });
            list.Add(new DataElement { ElementCode = DRG_Status_Age, SegmentCode = "DRG", IndexLocation = 27 });
            list.Add(new DataElement { ElementCode = DRG_Status_Length_of_Stay, SegmentCode = "DRG", IndexLocation = 28 });
            list.Add(new DataElement { ElementCode = DRG_Status_Same_Day_Flag, SegmentCode = "DRG", IndexLocation = 29 });
            list.Add(new DataElement { ElementCode = DRG_Status_Separation_Mode, SegmentCode = "DRG", IndexLocation = 30 });
            list.Add(new DataElement { ElementCode = DRG_Status_Weight_at_Birth, SegmentCode = "DRG", IndexLocation = 31 });
            list.Add(new DataElement { ElementCode = DRG_Status_Respiration_Minutes, SegmentCode = "DRG", IndexLocation = 32 });
            list.Add(new DataElement { ElementCode = DRG_Status_Admission, SegmentCode = "DRG", IndexLocation = 33 });

            #endregion "DRG"

            #region "DG1"

            list.Add(new DataElement { ElementCode = DG1_Set_ID, SegmentCode = "DG1", IndexLocation = 1 });
            list.Add(new DataElement { ElementCode = DG1_Diagnosis_Coding_Method, SegmentCode = "DG1", IndexLocation = 2 });
            list.Add(new DataElement { ElementCode = DG1_Diagnosis_Code, SegmentCode = "DG1", IndexLocation = 3 });
            list.Add(new DataElement { ElementCode = DG1_Diagnosis_Description, SegmentCode = "DG1", IndexLocation = 4 });
            list.Add(new DataElement { ElementCode = DG1_Diagnosis_Date_Time, SegmentCode = "DG1", IndexLocation = 5 });
            list.Add(new DataElement { ElementCode = DG1_Diagnosis_Type, SegmentCode = "DG1", IndexLocation = 6 });
            list.Add(new DataElement { ElementCode = DG1_Major_Diagnostic_Category, SegmentCode = "DG1", IndexLocation = 7 });
            list.Add(new DataElement { ElementCode = DG1_Diagnostic_Related_Group, SegmentCode = "DG1", IndexLocation = 8 });
            list.Add(new DataElement { ElementCode = DG1_Approval_Indicator, SegmentCode = "DG1", IndexLocation = 9 });
            list.Add(new DataElement { ElementCode = DG1_Grouper_Review_Code, SegmentCode = "DG1", IndexLocation = 10 });
            list.Add(new DataElement { ElementCode = DG1_Outlier_Type, SegmentCode = "DG1", IndexLocation = 11 });
            list.Add(new DataElement { ElementCode = DG1_Outlier_Days, SegmentCode = "DG1", IndexLocation = 12 });
            list.Add(new DataElement { ElementCode = DG1_Outlier_Cost, SegmentCode = "DG1", IndexLocation = 13 });
            list.Add(new DataElement { ElementCode = DG1_Grouper_Version_Type, SegmentCode = "DG1", IndexLocation = 14 });
            list.Add(new DataElement { ElementCode = DG1_Diagnosis_Priority, SegmentCode = "DG1", IndexLocation = 15 });
            list.Add(new DataElement { ElementCode = DG1_Diagnosing_Clinician, SegmentCode = "DG1", IndexLocation = 16 });
            list.Add(new DataElement { ElementCode = DG1_Diagnosing_Classification, SegmentCode = "DG1", IndexLocation = 17 });
            list.Add(new DataElement { ElementCode = DG1_Confidential_Indicator, SegmentCode = "DG1", IndexLocation = 18 });
            list.Add(new DataElement { ElementCode = DG1_Attestation_Date_Time, SegmentCode = "DG1", IndexLocation = 19 });
            list.Add(new DataElement { ElementCode = DG1_Diagnosis_Identifier, SegmentCode = "DG1", IndexLocation = 20 });
            list.Add(new DataElement { ElementCode = DG1_Diagnosis_Action_Code, SegmentCode = "DG1", IndexLocation = 21 });
            list.Add(new DataElement { ElementCode = DG1_Parent_Diagnosis, SegmentCode = "DG1", IndexLocation = 22 });
            list.Add(new DataElement { ElementCode = DG1_CCL_Value_Code, SegmentCode = "DG1", IndexLocation = 23 });
            list.Add(new DataElement { ElementCode = DG1_Grouping_Usage, SegmentCode = "DG1", IndexLocation = 24 });
            list.Add(new DataElement { ElementCode = DG1_Diagnosis_Determination_Status, SegmentCode = "DG1", IndexLocation = 25 });
            list.Add(new DataElement { ElementCode = DG1_Present_On_Admission_Indicator, SegmentCode = "DG1", IndexLocation = 26 });

            #endregion "DG1"

            #region "GT1"

            list.Add(new DataElement { ElementCode = GT1_Set_ID, SegmentCode = "GT1", IndexLocation = 1 });
            list.Add(new DataElement { ElementCode = GT1_Guarantor_Number, SegmentCode = "GT1", IndexLocation = 2 });
            list.Add(new DataElement { ElementCode = GT1_Guarantor_Name, SegmentCode = "GT1", IndexLocation = 3 });
            list.Add(new DataElement { ElementCode = GT1_Guarantor_Spouse_Name, SegmentCode = "GT1", IndexLocation = 4 });
            list.Add(new DataElement { ElementCode = GT1_Guarantor_Address, SegmentCode = "GT1", IndexLocation = 5 });
            list.Add(new DataElement { ElementCode = GT1_Guarantor_Phone_Home, SegmentCode = "GT1", IndexLocation = 6 });
            list.Add(new DataElement { ElementCode = GT1_Guarantor_Phone_Business, SegmentCode = "GT1", IndexLocation = 7 });
            list.Add(new DataElement { ElementCode = GT1_Guarantor_Date_Time_Of_Birth, SegmentCode = "GT1", IndexLocation = 8 });
            list.Add(new DataElement { ElementCode = GT1_Guarantor_Administrative_Sex, SegmentCode = "GT1", IndexLocation = 9 });
            list.Add(new DataElement { ElementCode = GT1_Guarantor_Type, SegmentCode = "GT1", IndexLocation = 10 });
            list.Add(new DataElement { ElementCode = GT1_Guarantor_Relationship, SegmentCode = "GT1", IndexLocation = 11 });
            list.Add(new DataElement { ElementCode = GT1_Guarantor_SSN, SegmentCode = "GT1", IndexLocation = 12 });
            list.Add(new DataElement { ElementCode = GT1_Guarantor_Date_Begin, SegmentCode = "GT1", IndexLocation = 13 });
            list.Add(new DataElement { ElementCode = GT1_Guarantor_Date_End, SegmentCode = "GT1", IndexLocation = 14 });
            list.Add(new DataElement { ElementCode = GT1_Guarantor_Priority, SegmentCode = "GT1", IndexLocation = 15 });
            list.Add(new DataElement { ElementCode = GT1_Guarantor_Employer_Name, SegmentCode = "GT1", IndexLocation = 16 });
            list.Add(new DataElement { ElementCode = GT1_Guarantor_Employer_Address, SegmentCode = "GT1", IndexLocation = 17 });
            list.Add(new DataElement { ElementCode = GT1_Guarantor_Employer_Phone_Number, SegmentCode = "GT1", IndexLocation = 18 });
            list.Add(new DataElement { ElementCode = GT1_Guarantor_Employee_ID_Number, SegmentCode = "GT1", IndexLocation = 19 });
            list.Add(new DataElement { ElementCode = GT1_Guarantor_Employment_Status, SegmentCode = "GT1", IndexLocation = 20 });
            list.Add(new DataElement { ElementCode = GT1_Guarantor_Organization_Name, SegmentCode = "GT1", IndexLocation = 21 });
            list.Add(new DataElement { ElementCode = GT1_Guarantor_Billing_Hold_Flag, SegmentCode = "GT1", IndexLocation = 22 });
            list.Add(new DataElement { ElementCode = GT1_Guarantor_Credit_Rating_Code, SegmentCode = "GT1", IndexLocation = 23 });
            list.Add(new DataElement { ElementCode = GT1_Guarantor_Death_Date_And_Time, SegmentCode = "GT1", IndexLocation = 24 });
            list.Add(new DataElement { ElementCode = GT1_Guarantor_Death_Flag, SegmentCode = "GT1", IndexLocation = 25 });
            list.Add(new DataElement { ElementCode = GT1_Guarantor_Charge_Adjustment_Code, SegmentCode = "GT1", IndexLocation = 26 });
            list.Add(new DataElement { ElementCode = GT1_Guarantor_Household_Annual_Income, SegmentCode = "GT1", IndexLocation = 27 });
            list.Add(new DataElement { ElementCode = GT1_Guarantor_Household_Size, SegmentCode = "GT1", IndexLocation = 28 });
            list.Add(new DataElement { ElementCode = GT1_Guarantor_Employer_ID_Number, SegmentCode = "GT1", IndexLocation = 29 });
            list.Add(new DataElement { ElementCode = GT1_Guarantor_Marital_Status_Code, SegmentCode = "GT1", IndexLocation = 30 });
            list.Add(new DataElement { ElementCode = GT1_Guarantor_Hire_Effective_Date, SegmentCode = "GT1", IndexLocation = 31 });
            list.Add(new DataElement { ElementCode = GT1_Employment_Stop_Date, SegmentCode = "GT1", IndexLocation = 32 });
            list.Add(new DataElement { ElementCode = GT1_Living_Dependency, SegmentCode = "GT1", IndexLocation = 33 });
            list.Add(new DataElement { ElementCode = GT1_Ambulatory_Status, SegmentCode = "GT1", IndexLocation = 34 });
            list.Add(new DataElement { ElementCode = GT1_Citizenship, SegmentCode = "GT1", IndexLocation = 35 });
            list.Add(new DataElement { ElementCode = GT1_Primary_Language, SegmentCode = "GT1", IndexLocation = 36 });
            list.Add(new DataElement { ElementCode = GT1_Living_Arrangement, SegmentCode = "GT1", IndexLocation = 37 });
            list.Add(new DataElement { ElementCode = GT1_Publicity_Code, SegmentCode = "GT1", IndexLocation = 38 });
            list.Add(new DataElement { ElementCode = GT1_Protection_Indicator, SegmentCode = "GT1", IndexLocation = 39 });
            list.Add(new DataElement { ElementCode = GT1_Student_Indicator, SegmentCode = "GT1", IndexLocation = 40 });
            list.Add(new DataElement { ElementCode = GT1_Religion, SegmentCode = "GT1", IndexLocation = 41 });
            list.Add(new DataElement { ElementCode = GT1_Mothers_Maiden_Name, SegmentCode = "GT1", IndexLocation = 42 });
            list.Add(new DataElement { ElementCode = GT1_Nationality, SegmentCode = "GT1", IndexLocation = 43 });
            list.Add(new DataElement { ElementCode = GT1_Ethnic_Group, SegmentCode = "GT1", IndexLocation = 44 });
            list.Add(new DataElement { ElementCode = GT1_Contact_Persons_Name, SegmentCode = "GT1", IndexLocation = 45 });
            list.Add(new DataElement { ElementCode = GT1_Contact_Persons_Telephone_Number, SegmentCode = "GT1", IndexLocation = 46 });
            list.Add(new DataElement { ElementCode = GT1_Contact_Reason, SegmentCode = "GT1", IndexLocation = 47 });
            list.Add(new DataElement { ElementCode = GT1_Contact_Relationship, SegmentCode = "GT1", IndexLocation = 48 });
            list.Add(new DataElement { ElementCode = GT1_Job_Title, SegmentCode = "GT1", IndexLocation = 49 });
            list.Add(new DataElement { ElementCode = GT1_Job_Code_Class, SegmentCode = "GT1", IndexLocation = 50 });
            list.Add(new DataElement { ElementCode = GT1_Guarantor_Employers_Organization_Name, SegmentCode = "GT1", IndexLocation = 51 });
            list.Add(new DataElement { ElementCode = GT1_Handicap, SegmentCode = "GT1", IndexLocation = 52 });
            list.Add(new DataElement { ElementCode = GT1_Job_Status, SegmentCode = "GT1", IndexLocation = 53 });
            list.Add(new DataElement { ElementCode = GT1_Guarantor_Financial_Class, SegmentCode = "GT1", IndexLocation = 54 });
            list.Add(new DataElement { ElementCode = GT1_Guarantor_Race, SegmentCode = "GT1", IndexLocation = 55 });
            list.Add(new DataElement { ElementCode = GT1_Guarantor_Birth_Place, SegmentCode = "GT1", IndexLocation = 56 });
            list.Add(new DataElement { ElementCode = GT1_VIP_Indicator, SegmentCode = "GT1", IndexLocation = 57 });

            #endregion "GT1"

            #region "IN1"

            list.Add(new DataElement { ElementCode = IN1_Set_ID, SegmentCode = "IN1", IndexLocation = 1 });
            list.Add(new DataElement { ElementCode = IN1_Health_Plan_ID, SegmentCode = "IN1", IndexLocation = 2 });
            list.Add(new DataElement { ElementCode = IN1_Insurance_Company_ID, SegmentCode = "IN1", IndexLocation = 3 });
            list.Add(new DataElement { ElementCode = IN1_Insurance_Company_Name, SegmentCode = "IN1", IndexLocation = 4 });
            list.Add(new DataElement { ElementCode = IN1_Insurance_Company_Address, SegmentCode = "IN1", IndexLocation = 5 });
            list.Add(new DataElement { ElementCode = IN1_Insurance_Company_Contact_Person, SegmentCode = "IN1", IndexLocation = 6 });
            list.Add(new DataElement { ElementCode = IN1_Insurance_Company_Phone_Number, SegmentCode = "IN1", IndexLocation = 7 });
            list.Add(new DataElement { ElementCode = IN1_Group_Number, SegmentCode = "IN1", IndexLocation = 8 });
            list.Add(new DataElement { ElementCode = IN1_Group_Name, SegmentCode = "IN1", IndexLocation = 9 });
            list.Add(new DataElement { ElementCode = IN1_Insureds_Group_Employee_ID, SegmentCode = "IN1", IndexLocation = 10 });
            list.Add(new DataElement { ElementCode = IN1_Insureds_Group_Employee_Name, SegmentCode = "IN1", IndexLocation = 11 });
            list.Add(new DataElement { ElementCode = IN1_Plan_Effective_Date, SegmentCode = "IN1", IndexLocation = 12 });
            list.Add(new DataElement { ElementCode = IN1_Plan_Expiration_Date, SegmentCode = "IN1", IndexLocation = 13 });
            list.Add(new DataElement { ElementCode = IN1_Authorization_Information, SegmentCode = "IN1", IndexLocation = 14 });
            list.Add(new DataElement { ElementCode = IN1_Plan_Type, SegmentCode = "IN1", IndexLocation = 15 });
            list.Add(new DataElement { ElementCode = IN1_Name_Of_Insured, SegmentCode = "IN1", IndexLocation = 16 });
            list.Add(new DataElement { ElementCode = IN1_Insureds_Relationship_To_Patient, SegmentCode = "IN1", IndexLocation = 17 });
            list.Add(new DataElement { ElementCode = IN1_Insureds_Date_Of_Birth, SegmentCode = "IN1", IndexLocation = 18 });
            list.Add(new DataElement { ElementCode = IN1_Insureds_Address, SegmentCode = "IN1", IndexLocation = 19 });
            list.Add(new DataElement { ElementCode = IN1_Assignment_Of_Benefits, SegmentCode = "IN1", IndexLocation = 20 });
            list.Add(new DataElement { ElementCode = IN1_Coordination_Of_Benefits, SegmentCode = "IN1", IndexLocation = 21 });
            list.Add(new DataElement { ElementCode = IN1_Coord_Of_Ben_Priority, SegmentCode = "IN1", IndexLocation = 22 });
            list.Add(new DataElement { ElementCode = IN1_Notice_Of_Admission_Flag, SegmentCode = "IN1", IndexLocation = 23 });
            list.Add(new DataElement { ElementCode = IN1_Notice_Of_Admission_Date, SegmentCode = "IN1", IndexLocation = 24 });
            list.Add(new DataElement { ElementCode = IN1_Report_Of_Eligibility_Flag, SegmentCode = "IN1", IndexLocation = 25 });
            list.Add(new DataElement { ElementCode = IN1_Report_Of_Eligibility_Date, SegmentCode = "IN1", IndexLocation = 26 });
            list.Add(new DataElement { ElementCode = IN1_Release_Information_Code, SegmentCode = "IN1", IndexLocation = 27 });
            list.Add(new DataElement { ElementCode = IN1_Pre_Admit_Cert, SegmentCode = "IN1", IndexLocation = 28 });
            list.Add(new DataElement { ElementCode = IN1_Verification_Date_Time, SegmentCode = "IN1", IndexLocation = 29 });
            list.Add(new DataElement { ElementCode = IN1_Verification_By, SegmentCode = "IN1", IndexLocation = 30 });
            list.Add(new DataElement { ElementCode = IN1_Type_Of_Agreement_Code, SegmentCode = "IN1", IndexLocation = 31 });
            list.Add(new DataElement { ElementCode = IN1_Billing_Status, SegmentCode = "IN1", IndexLocation = 32 });
            list.Add(new DataElement { ElementCode = IN1_Lifetime_Reserve_Days, SegmentCode = "IN1", IndexLocation = 33 });
            list.Add(new DataElement { ElementCode = IN1_Delay_Before_L_R_Day, SegmentCode = "IN1", IndexLocation = 34 });
            list.Add(new DataElement { ElementCode = IN1_Company_Plan_Code, SegmentCode = "IN1", IndexLocation = 35 });
            list.Add(new DataElement { ElementCode = IN1_Policy_Number, SegmentCode = "IN1", IndexLocation = 36 });
            list.Add(new DataElement { ElementCode = IN1_Policy_Deductible, SegmentCode = "IN1", IndexLocation = 37 });
            list.Add(new DataElement { ElementCode = IN1_Policy_Limit_Amount, SegmentCode = "IN1", IndexLocation = 38 });
            list.Add(new DataElement { ElementCode = IN1_Policy_Limit_Days, SegmentCode = "IN1", IndexLocation = 39 });
            list.Add(new DataElement { ElementCode = IN1_Room_Rate_Semi_Private, SegmentCode = "IN1", IndexLocation = 40 });
            list.Add(new DataElement { ElementCode = IN1_Room_Rate_Private, SegmentCode = "IN1", IndexLocation = 41 });
            list.Add(new DataElement { ElementCode = IN1_Insureds_Employment_Status, SegmentCode = "IN1", IndexLocation = 42 });
            list.Add(new DataElement { ElementCode = IN1_Insureds_Administrative_Sex, SegmentCode = "IN1", IndexLocation = 43 });
            list.Add(new DataElement { ElementCode = IN1_Insureds_Employers_Address, SegmentCode = "IN1", IndexLocation = 44 });
            list.Add(new DataElement { ElementCode = IN1_Verification_Status, SegmentCode = "IN1", IndexLocation = 45 });
            list.Add(new DataElement { ElementCode = IN1_Prior_Insurance_Plan_ID, SegmentCode = "IN1", IndexLocation = 46 });
            list.Add(new DataElement { ElementCode = IN1_Coverage_Type, SegmentCode = "IN1", IndexLocation = 47 });
            list.Add(new DataElement { ElementCode = IN1_Handicap, SegmentCode = "IN1", IndexLocation = 48 });
            list.Add(new DataElement { ElementCode = IN1_Insureds_ID_Number, SegmentCode = "IN1", IndexLocation = 49 });
            list.Add(new DataElement { ElementCode = IN1_Signature_Code, SegmentCode = "IN1", IndexLocation = 50 });
            list.Add(new DataElement { ElementCode = IN1_Signature_Code_Date, SegmentCode = "IN1", IndexLocation = 51 });
            list.Add(new DataElement { ElementCode = IN1_Insureds_Birth_Place, SegmentCode = "IN1", IndexLocation = 52 });
            list.Add(new DataElement { ElementCode = IN1_VIP_Indicator, SegmentCode = "IN1", IndexLocation = 53 });
            list.Add(new DataElement { ElementCode = IN1_External_Health_Plan_Identifiers, SegmentCode = "IN1", IndexLocation = 54 });
            list.Add(new DataElement { ElementCode = IN1_Insurance_Action_Code, SegmentCode = "IN1", IndexLocation = 55 });

            #endregion "IN1"

            #region "IN2"

            list.Add(new DataElement { ElementCode = IN2_Insureds_Employee_ID, SegmentCode = "IN2", IndexLocation = 1 });
            list.Add(new DataElement { ElementCode = IN2_Insureds_Social_Security_Number, SegmentCode = "IN2", IndexLocation = 2 });
            list.Add(new DataElement { ElementCode = IN2_Insureds_Employers_Name_and_ID, SegmentCode = "IN2", IndexLocation = 3 });
            list.Add(new DataElement { ElementCode = IN2_Employer_Information_Data, SegmentCode = "IN2", IndexLocation = 4 });
            list.Add(new DataElement { ElementCode = IN2_Mail_Claim_Party, SegmentCode = "IN2", IndexLocation = 5 });
            list.Add(new DataElement { ElementCode = IN2_Medicare_Health_Ins_Card_Number, SegmentCode = "IN2", IndexLocation = 6 });
            list.Add(new DataElement { ElementCode = IN2_Medicaid_Case_Name, SegmentCode = "IN2", IndexLocation = 7 });
            list.Add(new DataElement { ElementCode = IN2_Medicaid_Case_Number, SegmentCode = "IN2", IndexLocation = 8 });
            list.Add(new DataElement { ElementCode = IN2_Military_Sponsor_Name, SegmentCode = "IN2", IndexLocation = 9 });
            list.Add(new DataElement { ElementCode = IN2_Military_ID_Number, SegmentCode = "IN2", IndexLocation = 10 });
            list.Add(new DataElement { ElementCode = IN2_Dependent_Of_Military_Recipient, SegmentCode = "IN2", IndexLocation = 11 });
            list.Add(new DataElement { ElementCode = IN2_Military_Organization, SegmentCode = "IN2", IndexLocation = 12 });
            list.Add(new DataElement { ElementCode = IN2_Military_Station, SegmentCode = "IN2", IndexLocation = 13 });
            list.Add(new DataElement { ElementCode = IN2_Military_Service, SegmentCode = "IN2", IndexLocation = 14 });
            list.Add(new DataElement { ElementCode = IN2_Military_Rank_Grade, SegmentCode = "IN2", IndexLocation = 15 });
            list.Add(new DataElement { ElementCode = IN2_Military_Status, SegmentCode = "IN2", IndexLocation = 16 });
            list.Add(new DataElement { ElementCode = IN2_Military_Retire_Date, SegmentCode = "IN2", IndexLocation = 17 });
            list.Add(new DataElement { ElementCode = IN2_Military_Non_Avail_Cert_On_File, SegmentCode = "IN2", IndexLocation = 18 });
            list.Add(new DataElement { ElementCode = IN2_Baby_Coverage, SegmentCode = "IN2", IndexLocation = 19 });
            list.Add(new DataElement { ElementCode = IN2_Combine_Baby_Bill, SegmentCode = "IN2", IndexLocation = 20 });
            list.Add(new DataElement { ElementCode = IN2_Blood_Deductible, SegmentCode = "IN2", IndexLocation = 21 });
            list.Add(new DataElement { ElementCode = IN2_Special_Coverage_Approval_Name, SegmentCode = "IN2", IndexLocation = 22 });
            list.Add(new DataElement { ElementCode = IN2_Special_Coverage_Approval_Title, SegmentCode = "IN2", IndexLocation = 23 });
            list.Add(new DataElement { ElementCode = IN2_Non_Covered_Insurance_Code, SegmentCode = "IN2", IndexLocation = 24 });
            list.Add(new DataElement { ElementCode = IN2_Payor_ID, SegmentCode = "IN2", IndexLocation = 25 });
            list.Add(new DataElement { ElementCode = IN2_Payor_Subscriber_ID, SegmentCode = "IN2", IndexLocation = 26 });
            list.Add(new DataElement { ElementCode = IN2_Eligibility_Source, SegmentCode = "IN2", IndexLocation = 27 });
            list.Add(new DataElement { ElementCode = IN2_Room_Coverage_Type_Amount, SegmentCode = "IN2", IndexLocation = 28 });
            list.Add(new DataElement { ElementCode = IN2_Policy_Type_Amount, SegmentCode = "IN2", IndexLocation = 29 });
            list.Add(new DataElement { ElementCode = IN2_Daily_Deductible, SegmentCode = "IN2", IndexLocation = 30 });
            list.Add(new DataElement { ElementCode = IN2_Living_Dependency, SegmentCode = "IN2", IndexLocation = 31 });
            list.Add(new DataElement { ElementCode = IN2_Ambulatory_Status, SegmentCode = "IN2", IndexLocation = 32 });
            list.Add(new DataElement { ElementCode = IN2_Citizenship, SegmentCode = "IN2", IndexLocation = 33 });
            list.Add(new DataElement { ElementCode = IN2_Primary_Language, SegmentCode = "IN2", IndexLocation = 34 });
            list.Add(new DataElement { ElementCode = IN2_Living_Arrangement, SegmentCode = "IN2", IndexLocation = 35 });
            list.Add(new DataElement { ElementCode = IN2_Publicity_Code, SegmentCode = "IN2", IndexLocation = 36 });
            list.Add(new DataElement { ElementCode = IN2_Protection_Indicator, SegmentCode = "IN2", IndexLocation = 37 });
            list.Add(new DataElement { ElementCode = IN2_Student_Indicator, SegmentCode = "IN2", IndexLocation = 38 });
            list.Add(new DataElement { ElementCode = IN2_Religion, SegmentCode = "IN2", IndexLocation = 39 });
            list.Add(new DataElement { ElementCode = IN2_Mothers_Maiden_Name, SegmentCode = "IN2", IndexLocation = 40 });
            list.Add(new DataElement { ElementCode = IN2_Nationality, SegmentCode = "IN2", IndexLocation = 41 });
            list.Add(new DataElement { ElementCode = IN2_Ethnic_Group, SegmentCode = "IN2", IndexLocation = 42 });
            list.Add(new DataElement { ElementCode = IN2_Marital_Status, SegmentCode = "IN2", IndexLocation = 43 });
            list.Add(new DataElement { ElementCode = IN2_Insureds_Employment_Start_Date, SegmentCode = "IN2", IndexLocation = 44 });
            list.Add(new DataElement { ElementCode = IN2_Employment_Stop_Date, SegmentCode = "IN2", IndexLocation = 45 });
            list.Add(new DataElement { ElementCode = IN2_Job_Title, SegmentCode = "IN2", IndexLocation = 46 });
            list.Add(new DataElement { ElementCode = IN2_Job_Code_Class, SegmentCode = "IN2", IndexLocation = 47 });
            list.Add(new DataElement { ElementCode = IN2_Job_Status, SegmentCode = "IN2", IndexLocation = 48 });
            list.Add(new DataElement { ElementCode = IN2_Employer_Contact_Person_Name, SegmentCode = "IN2", IndexLocation = 49 });
            list.Add(new DataElement { ElementCode = IN2_Employer_Contact_Person_Phone_Number, SegmentCode = "IN2", IndexLocation = 50 });
            list.Add(new DataElement { ElementCode = IN2_Employer_Contact_Reason, SegmentCode = "IN2", IndexLocation = 51 });
            list.Add(new DataElement { ElementCode = IN2_Insureds_Contact_Persons_Name, SegmentCode = "IN2", IndexLocation = 52 });
            list.Add(new DataElement { ElementCode = IN2_Insureds_Contact_Person_Phone_Number, SegmentCode = "IN2", IndexLocation = 53 });
            list.Add(new DataElement { ElementCode = IN2_Insureds_Contact_Person_Reason, SegmentCode = "IN2", IndexLocation = 54 });
            list.Add(new DataElement { ElementCode = IN2_Relationship_to_the_Patient_Start_Date, SegmentCode = "IN2", IndexLocation = 55 });
            list.Add(new DataElement { ElementCode = IN2_Relationship_to_the_Patient_Stop_Date, SegmentCode = "IN2", IndexLocation = 56 });
            list.Add(new DataElement { ElementCode = IN2_Insurance_Co_Contact_Reason, SegmentCode = "IN2", IndexLocation = 57 });
            list.Add(new DataElement { ElementCode = IN2_Insurance_Co_Contact_Phone_Number, SegmentCode = "IN2", IndexLocation = 58 });
            list.Add(new DataElement { ElementCode = IN2_Policy_Scope, SegmentCode = "IN2", IndexLocation = 59 });
            list.Add(new DataElement { ElementCode = IN2_Policy_Source, SegmentCode = "IN2", IndexLocation = 60 });
            list.Add(new DataElement { ElementCode = IN2_Patient_Member_Number, SegmentCode = "IN2", IndexLocation = 61 });
            list.Add(new DataElement { ElementCode = IN2_Guarantors_Relationship_to_Insured, SegmentCode = "IN2", IndexLocation = 62 });
            list.Add(new DataElement { ElementCode = IN2_Insureds_Phone_Number_Home, SegmentCode = "IN2", IndexLocation = 63 });
            list.Add(new DataElement { ElementCode = IN2_Insureds_Employer_Phone_Number, SegmentCode = "IN2", IndexLocation = 64 });
            list.Add(new DataElement { ElementCode = IN2_Military_Handicapped_Program, SegmentCode = "IN2", IndexLocation = 65 });
            list.Add(new DataElement { ElementCode = IN2_Suspend_Flag, SegmentCode = "IN2", IndexLocation = 66 });
            list.Add(new DataElement { ElementCode = IN2_Copay_Limit_Flag, SegmentCode = "IN2", IndexLocation = 67 });
            list.Add(new DataElement { ElementCode = IN2_Stoploss_Limit_Flag, SegmentCode = "IN2", IndexLocation = 68 });
            list.Add(new DataElement { ElementCode = IN2_Insured_Organization_Name_and_ID, SegmentCode = "IN2", IndexLocation = 69 });
            list.Add(new DataElement { ElementCode = IN2_Insured_Employer_Organization_Name_and_ID, SegmentCode = "IN2", IndexLocation = 70 });
            list.Add(new DataElement { ElementCode = IN2_Race, SegmentCode = "IN2", IndexLocation = 71 });
            list.Add(new DataElement { ElementCode = IN2_Patients_Relationship_to_Insured, SegmentCode = "IN2", IndexLocation = 72 });

            #endregion "IN2"

            #region "IN3"

            list.Add(new DataElement { ElementCode = IN3_Set_ID, SegmentCode = "IN3", IndexLocation = 1 });
            list.Add(new DataElement { ElementCode = IN3_Certification_Number, SegmentCode = "IN3", IndexLocation = 2 });
            list.Add(new DataElement { ElementCode = IN3_Certified_By, SegmentCode = "IN3", IndexLocation = 3 });
            list.Add(new DataElement { ElementCode = IN3_Certification_Required, SegmentCode = "IN3", IndexLocation = 4 });
            list.Add(new DataElement { ElementCode = IN3_Penalty, SegmentCode = "IN3", IndexLocation = 5 });
            list.Add(new DataElement { ElementCode = IN3_Certification_Date_Time, SegmentCode = "IN3", IndexLocation = 6 });
            list.Add(new DataElement { ElementCode = IN3_Certification_Modify_Date_Time, SegmentCode = "IN3", IndexLocation = 7 });
            list.Add(new DataElement { ElementCode = IN3_Operator, SegmentCode = "IN3", IndexLocation = 8 });
            list.Add(new DataElement { ElementCode = IN3_Certification_Begin_Date, SegmentCode = "IN3", IndexLocation = 9 });
            list.Add(new DataElement { ElementCode = IN3_Certification_End_Date, SegmentCode = "IN3", IndexLocation = 10 });
            list.Add(new DataElement { ElementCode = IN3_Days, SegmentCode = "IN3", IndexLocation = 11 });
            list.Add(new DataElement { ElementCode = IN3_Non_Concur_Code_Description, SegmentCode = "IN3", IndexLocation = 12 });
            list.Add(new DataElement { ElementCode = IN3_Non_Concur_Effective_Date_Time, SegmentCode = "IN3", IndexLocation = 13 });
            list.Add(new DataElement { ElementCode = IN3_Physician_Reviewer, SegmentCode = "IN3", IndexLocation = 14 });
            list.Add(new DataElement { ElementCode = IN3_Certification_Contact, SegmentCode = "IN3", IndexLocation = 15 });
            list.Add(new DataElement { ElementCode = IN3_Certification_Contact_Phone_Number, SegmentCode = "IN3", IndexLocation = 16 });
            list.Add(new DataElement { ElementCode = IN3_Appeal_Reason, SegmentCode = "IN3", IndexLocation = 17 });
            list.Add(new DataElement { ElementCode = IN3_Certification_Agency, SegmentCode = "IN3", IndexLocation = 18 });
            list.Add(new DataElement { ElementCode = IN3_Certification_Agency_Phone_Number, SegmentCode = "IN3", IndexLocation = 19 });
            list.Add(new DataElement { ElementCode = IN3_Pre_Certification_Requirement, SegmentCode = "IN3", IndexLocation = 20 });
            list.Add(new DataElement { ElementCode = IN3_Case_Manager, SegmentCode = "IN3", IndexLocation = 21 });
            list.Add(new DataElement { ElementCode = IN3_Second_Opinion_Date, SegmentCode = "IN3", IndexLocation = 22 });
            list.Add(new DataElement { ElementCode = IN3_Second_Opinion_Status, SegmentCode = "IN3", IndexLocation = 23 });
            list.Add(new DataElement { ElementCode = IN3_Second_Opinion_Documentation_Received, SegmentCode = "IN3", IndexLocation = 24 });
            list.Add(new DataElement { ElementCode = IN3_Second_Opinion_Physician, SegmentCode = "IN3", IndexLocation = 25 });
            list.Add(new DataElement { ElementCode = IN3_Certification_Type, SegmentCode = "IN3", IndexLocation = 26 });
            list.Add(new DataElement { ElementCode = IN3_Certification_Category, SegmentCode = "IN3", IndexLocation = 27 });

            #endregion "IN3"

            #region "ACC"

            list.Add(new DataElement { ElementCode = ACC_Accident_Date_Time, SegmentCode = "ACC", IndexLocation = 1 });
            list.Add(new DataElement { ElementCode = ACC_Accident_Code, SegmentCode = "ACC", IndexLocation = 2 });
            list.Add(new DataElement { ElementCode = ACC_Accident_Location, SegmentCode = "ACC", IndexLocation = 3 });
            list.Add(new DataElement { ElementCode = ACC_Auto_Accident_State, SegmentCode = "ACC", IndexLocation = 4 });
            list.Add(new DataElement { ElementCode = ACC_Accident_Job_Related_Indicator, SegmentCode = "ACC", IndexLocation = 5 });
            list.Add(new DataElement { ElementCode = ACC_Accident_Death_Indicator, SegmentCode = "ACC", IndexLocation = 6 });
            list.Add(new DataElement { ElementCode = ACC_Entered_By, SegmentCode = "ACC", IndexLocation = 7 });
            list.Add(new DataElement { ElementCode = ACC_Accident_Description, SegmentCode = "ACC", IndexLocation = 8 });
            list.Add(new DataElement { ElementCode = ACC_Brought_In_By, SegmentCode = "ACC", IndexLocation = 9 });
            list.Add(new DataElement { ElementCode = ACC_Police_Notified_Indicator, SegmentCode = "ACC", IndexLocation = 10 });
            list.Add(new DataElement { ElementCode = ACC_Accident_Address, SegmentCode = "ACC", IndexLocation = 11 });
            list.Add(new DataElement { ElementCode = ACC_Degree_of_Patient_Liability, SegmentCode = "ACC", IndexLocation = 12 });
            list.Add(new DataElement { ElementCode = ACC_Accident_Identifier, SegmentCode = "ACC", IndexLocation = 13 });

            #endregion "ACC"

            #region "AL1"

            list.Add(new DataElement { ElementCode = AL1_Set_ID, SegmentCode = "AL1", IndexLocation = 1 });
            list.Add(new DataElement { ElementCode = AL1_Allergen_Type_Code, SegmentCode = "AL1", IndexLocation = 2 });
            list.Add(new DataElement { ElementCode = AL1_Allergen_Code, SegmentCode = "AL1", IndexLocation = 3 });
            list.Add(new DataElement { ElementCode = AL1_Allergy_Severity_Code, SegmentCode = "AL1", IndexLocation = 4 });
            list.Add(new DataElement { ElementCode = AL1_Allergy_Reaction_code, SegmentCode = "AL1", IndexLocation = 5 });
            list.Add(new DataElement { ElementCode = AL1_Identification_Date, SegmentCode = "AL1", IndexLocation = 6 });

            #endregion "AL1"

            #region "FT1"

            list.Add(new DataElement { ElementCode = FT1_Set_ID, SegmentCode = "FT1", IndexLocation = 1 });
            list.Add(new DataElement { ElementCode = FT1_Transaction_ID, SegmentCode = "FT1", IndexLocation = 2 });
            list.Add(new DataElement { ElementCode = FT1_Transaction_Batch_ID, SegmentCode = "FT1", IndexLocation = 3 });
            list.Add(new DataElement { ElementCode = FT1_Transaction_Date, SegmentCode = "FT1", IndexLocation = 4 });
            list.Add(new DataElement { ElementCode = FT1_Transaction_Posting_Date, SegmentCode = "FT1", IndexLocation = 5 });
            list.Add(new DataElement { ElementCode = FT1_Transaction_Type, SegmentCode = "FT1", IndexLocation = 6 });
            list.Add(new DataElement { ElementCode = FT1_Transaction_Code, SegmentCode = "FT1", IndexLocation = 7 });
            list.Add(new DataElement { ElementCode = FT1_Transaction_Description, SegmentCode = "FT1", IndexLocation = 8 });
            list.Add(new DataElement { ElementCode = FT1_Transaction_Description_Alt, SegmentCode = "FT1", IndexLocation = 9 });
            list.Add(new DataElement { ElementCode = FT1_Transaction_Quantity, SegmentCode = "FT1", IndexLocation = 10 });
            list.Add(new DataElement { ElementCode = FT1_Transaction_Amount_Extended, SegmentCode = "FT1", IndexLocation = 11 });
            list.Add(new DataElement { ElementCode = FT1_Transaction_Amount_Unit, SegmentCode = "FT1", IndexLocation = 12 });
            list.Add(new DataElement { ElementCode = FT1_Department_Code, SegmentCode = "FT1", IndexLocation = 13 });
            list.Add(new DataElement { ElementCode = FT1_Health_Plan_ID, SegmentCode = "FT1", IndexLocation = 14 });
            list.Add(new DataElement { ElementCode = FT1_Insurance_Amount, SegmentCode = "FT1", IndexLocation = 15 });
            list.Add(new DataElement { ElementCode = FT1_Assigned_Patient_Location, SegmentCode = "FT1", IndexLocation = 16 });
            list.Add(new DataElement { ElementCode = FT1_Fee_Schedule, SegmentCode = "FT1", IndexLocation = 17 });
            list.Add(new DataElement { ElementCode = FT1_Patient_Type, SegmentCode = "FT1", IndexLocation = 18 });
            list.Add(new DataElement { ElementCode = FT1_Diagnosis_Code, SegmentCode = "FT1", IndexLocation = 19 });
            list.Add(new DataElement { ElementCode = FT1_Performed_By_Code, SegmentCode = "FT1", IndexLocation = 20 });
            list.Add(new DataElement { ElementCode = FT1_Ordered_By_Code, SegmentCode = "FT1", IndexLocation = 21 });
            list.Add(new DataElement { ElementCode = FT1_Unit_Cost, SegmentCode = "FT1", IndexLocation = 22 });
            list.Add(new DataElement { ElementCode = FT1_Filler_Order_Number, SegmentCode = "FT1", IndexLocation = 23 });
            list.Add(new DataElement { ElementCode = FT1_Entered_By_Code, SegmentCode = "FT1", IndexLocation = 24 });
            list.Add(new DataElement { ElementCode = FT1_Procedure_Code, SegmentCode = "FT1", IndexLocation = 25 });
            list.Add(new DataElement { ElementCode = FT1_Procedure_Code_Modifier, SegmentCode = "FT1", IndexLocation = 26 });
            list.Add(new DataElement { ElementCode = FT1_Advanced_Beneficiary_Notice_Code, SegmentCode = "FT1", IndexLocation = 27 });
            list.Add(new DataElement { ElementCode = FT1_Medically_Necessary_Duplicate_Procedure_Reason, SegmentCode = "FT1", IndexLocation = 28 });
            list.Add(new DataElement { ElementCode = FT1_NDC_Code, SegmentCode = "FT1", IndexLocation = 29 });
            list.Add(new DataElement { ElementCode = FT1_Payment_Reference_ID, SegmentCode = "FT1", IndexLocation = 30 });
            list.Add(new DataElement { ElementCode = FT1_Transaction_Reference_Key, SegmentCode = "FT1", IndexLocation = 31 });
            list.Add(new DataElement { ElementCode = FT1_Performing_Facility, SegmentCode = "FT1", IndexLocation = 32 });
            list.Add(new DataElement { ElementCode = FT1_Ordering_Facility, SegmentCode = "FT1", IndexLocation = 33 });
            list.Add(new DataElement { ElementCode = FT1_Item_Number, SegmentCode = "FT1", IndexLocation = 34 });
            list.Add(new DataElement { ElementCode = FT1_Model_Number, SegmentCode = "FT1", IndexLocation = 35 });
            list.Add(new DataElement { ElementCode = FT1_Special_Processing_Code, SegmentCode = "FT1", IndexLocation = 36 });
            list.Add(new DataElement { ElementCode = FT1_Clinic_Code, SegmentCode = "FT1", IndexLocation = 37 });
            list.Add(new DataElement { ElementCode = FT1_Referral_Number, SegmentCode = "FT1", IndexLocation = 38 });
            list.Add(new DataElement { ElementCode = FT1_Authorization_Number, SegmentCode = "FT1", IndexLocation = 39 });
            list.Add(new DataElement { ElementCode = FT1_Service_Provider_Taxonomy_Code, SegmentCode = "FT1", IndexLocation = 40 });
            list.Add(new DataElement { ElementCode = FT1_Revenue_Code, SegmentCode = "FT1", IndexLocation = 41 });
            list.Add(new DataElement { ElementCode = FT1_Prescription_Number, SegmentCode = "FT1", IndexLocation = 42 });
            list.Add(new DataElement { ElementCode = FT1_NDC_Qty_and_UOM, SegmentCode = "FT1", IndexLocation = 43 });

            #endregion "FT1"

            #region "UB1"

            list.Add(new DataElement { ElementCode = UB1_Set_ID, SegmentCode = "UB1", IndexLocation = 1 });
            list.Add(new DataElement { ElementCode = UB1_Blood_Deductible, SegmentCode = "UB1", IndexLocation = 2 });
            list.Add(new DataElement { ElementCode = UB1_Blood_Furnished_Pints, SegmentCode = "UB1", IndexLocation = 3 });
            list.Add(new DataElement { ElementCode = UB1_Blood_Replaced_Pints, SegmentCode = "UB1", IndexLocation = 4 });
            list.Add(new DataElement { ElementCode = UB1_Blood_Not_Replaced_Pints, SegmentCode = "UB1", IndexLocation = 5 });
            list.Add(new DataElement { ElementCode = UB1_Co_Insurance_Days, SegmentCode = "UB1", IndexLocation = 6 });
            list.Add(new DataElement { ElementCode = UB1_Condition_Code, SegmentCode = "UB1", IndexLocation = 7 });
            list.Add(new DataElement { ElementCode = UB1_Covered_Days, SegmentCode = "UB1", IndexLocation = 8 });
            list.Add(new DataElement { ElementCode = UB1_Non_Covered_Days, SegmentCode = "UB1", IndexLocation = 9 });
            list.Add(new DataElement { ElementCode = UB1_Value_Amount_and_Code, SegmentCode = "UB1", IndexLocation = 10 });
            list.Add(new DataElement { ElementCode = UB1_Number_Of_Grace_Days, SegmentCode = "UB1", IndexLocation = 11 });
            list.Add(new DataElement { ElementCode = UB1_Special_Program_Indicator, SegmentCode = "UB1", IndexLocation = 12 });
            list.Add(new DataElement { ElementCode = UB1_PSRO_UR_Approval_Indicator, SegmentCode = "UB1", IndexLocation = 13 });
            list.Add(new DataElement { ElementCode = UB1_PSRO_UR_Approved_Stay_From, SegmentCode = "UB1", IndexLocation = 14 });
            list.Add(new DataElement { ElementCode = UB1_PSRO_UR_Approved_Stay_To, SegmentCode = "UB1", IndexLocation = 15 });
            list.Add(new DataElement { ElementCode = UB1_Occurrence, SegmentCode = "UB1", IndexLocation = 16 });
            list.Add(new DataElement { ElementCode = UB1_Occurrence_Span, SegmentCode = "UB1", IndexLocation = 17 });
            list.Add(new DataElement { ElementCode = UB1_Occur_Span_Start_Date, SegmentCode = "UB1", IndexLocation = 18 });
            list.Add(new DataElement { ElementCode = UB1_Occur_Span_End_Date, SegmentCode = "UB1", IndexLocation = 19 });
            list.Add(new DataElement { ElementCode = UB1_UB_82_Locator_2, SegmentCode = "UB1", IndexLocation = 20 });
            list.Add(new DataElement { ElementCode = UB1_UB_82_Locator_9, SegmentCode = "UB1", IndexLocation = 21 });
            list.Add(new DataElement { ElementCode = UB1_UB_82_Locator_27, SegmentCode = "UB1", IndexLocation = 22 });
            list.Add(new DataElement { ElementCode = UB1_UB_82_Locator_45, SegmentCode = "UB1", IndexLocation = 23 });

            #endregion "UB1"

            #region "UB2"

            list.Add(new DataElement { ElementCode = UB2_Set_ID, SegmentCode = "UB2", IndexLocation = 1 });
            list.Add(new DataElement { ElementCode = UB2_Co_Insurance_Days_9, SegmentCode = "UB2", IndexLocation = 2 });
            list.Add(new DataElement { ElementCode = UB2_Condition_Code_24_30, SegmentCode = "UB2", IndexLocation = 3 });
            list.Add(new DataElement { ElementCode = UB2_Covered_Days_7, SegmentCode = "UB2", IndexLocation = 4 });
            list.Add(new DataElement { ElementCode = UB2_Non_Covered_Days_8, SegmentCode = "UB2", IndexLocation = 5 });
            list.Add(new DataElement { ElementCode = UB2_Value_Amount_and_Code_39_41_, SegmentCode = "UB2", IndexLocation = 6 });
            list.Add(new DataElement { ElementCode = UB2_Occurrence_Code_and_Date_32_35, SegmentCode = "UB2", IndexLocation = 7 });
            list.Add(new DataElement { ElementCode = UB2_Occurrence_Span_Code_Dates_36, SegmentCode = "UB2", IndexLocation = 8 });
            list.Add(new DataElement { ElementCode = UB2_Uniform_Billing_Locator_2_State, SegmentCode = "UB2", IndexLocation = 9 });
            list.Add(new DataElement { ElementCode = UB2_Uniform_Billing_Locator_11_State, SegmentCode = "UB2", IndexLocation = 10 });
            list.Add(new DataElement { ElementCode = UB2_Uniform_Billing_Locator_31_National, SegmentCode = "UB2", IndexLocation = 11 });
            list.Add(new DataElement { ElementCode = UB2_Document_Control_Number, SegmentCode = "UB2", IndexLocation = 12 });
            list.Add(new DataElement { ElementCode = UB2_Uniform_Billing_Locator_49_National, SegmentCode = "UB2", IndexLocation = 13 });
            list.Add(new DataElement { ElementCode = UB2_Uniform_Billing_Locator_56_State, SegmentCode = "UB2", IndexLocation = 14 });
            list.Add(new DataElement { ElementCode = UB2_Uniform_Billing_Locator_57_National, SegmentCode = "UB2", IndexLocation = 15 });
            list.Add(new DataElement { ElementCode = UB2_Uniform_Billing_Locator_78_State, SegmentCode = "UB2", IndexLocation = 16 });
            list.Add(new DataElement { ElementCode = UB2_Special_Visit_Count, SegmentCode = "UB2", IndexLocation = 17 });

            #endregion "UB2"

            #region "RXR"
            list.Add(new DataElement { ElementCode = RXR_Route, SegmentCode = "RXR", IndexLocation = 1 });
            list.Add(new DataElement { ElementCode = RXR_Administration_Site, SegmentCode = "RXR", IndexLocation = 2 });
            list.Add(new DataElement { ElementCode = RXR_Administration_Device, SegmentCode = "RXR", IndexLocation = 3 });
            list.Add(new DataElement { ElementCode = RXR_Administration_Method, SegmentCode = "RXR", IndexLocation = 4 });
            list.Add(new DataElement { ElementCode = RXR_Routing_Instruction, SegmentCode = "RXR", IndexLocation = 5 });
            list.Add(new DataElement { ElementCode = RXR_Administration_Site_Modifier, SegmentCode = "RXR", IndexLocation = 6 });
            #endregion

            return list;
        }

        public static List<DataElement> GetDataElementsBySegment(string segmentCode)
        {
            return GetAllDataElements().FindAll(x => x.SegmentCode == segmentCode);
        }

        #region "Element Names"

        #region "PID"

        public static readonly string PID_Set_ID = "Set ID";
        public static readonly string PID_Patient_ID = "Patient ID";
        public static readonly string PID_Patient_Identifier_List = "Patient Identifier List";
        public static readonly string PID_Alternate_Patient_ID = "Alternate Patient ID";
        public static readonly string PID_Patient_Name = "Patient Name";
        public static readonly string PID_Mothers_Maiden_Name = "Mothers Maiden Name";
        public static readonly string PID_DateTime_of_Birth = "DateTime of Birth";
        public static readonly string PID_Administrative_Sex = "Administrative Sex";
        public static readonly string PID_Patient_Alias = "Patient Alias";
        public static readonly string PID_Race = "Race";
        public static readonly string PID_Patient_Address = "Patient Address";
        public static readonly string PID_County_Code = "County Code";
        public static readonly string PID_Phone_Number_Home = "Phone Number - Home";
        public static readonly string PID_Phone_Number_Business = "Phone Number - Business";
        public static readonly string PID_Primary_Language = "Primary Language";
        public static readonly string PID_Marital_Status = "Marital Status";
        public static readonly string PID_Religion = "Religion";
        public static readonly string PID_Patient_Account_Number = "Patient Account Number";
        public static readonly string PID_SSN = "SSN";
        public static readonly string PID_Drivers_License_Number = "Drivers License Number";
        public static readonly string PID_Mothers_Identifier = "Mothers Identifier";
        public static readonly string PID_Ethnic_Group = "Ethnic Group";
        public static readonly string PID_Birth_Place = "Birth Place";
        public static readonly string PID_Multiple_Birth_Indicator = "Multiple Birth Indicator";
        public static readonly string PID_Birth_Order = "Birth Order";
        public static readonly string PID_Citizenship = "Citizenship";
        public static readonly string PID_Veterans_Military_Status = "Veterans Military Status";
        public static readonly string PID_Nationality = "Nationality";
        public static readonly string PID_Patient_Death_Date_Time = "Patient Death Date and Time";
        public static readonly string PID_Patient_Death_Indicator = "Patient Death Indicator";
        public static readonly string PID_Identity_Unknown_Indicator = "Identity Unknown Indicator";
        public static readonly string PID_Identity_Reliability_Code = "Identity Reliability Code";
        public static readonly string PID_Last_Update_Date_Time = "Last Update Date Time";
        public static readonly string PID_Last_Update_Facility = "Last Update Facility";
        public static readonly string PID_Taxonomic_Classification_Code = "Taxonomic Classification Code";
        public static readonly string PID_Breed_Code = "Breed Code";
        public static readonly string PID_Strain = "Strain";
        public static readonly string PID_Production_Class_Code = "Production Class Code";
        public static readonly string PID_Tribal_Citizenship = "Tribal Citizenship";
        public static readonly string PID_Patient_Telecommunication_Information = "Patient Telecommunication Information";

        #endregion "PID"

        #region "AIL"

        public static readonly string AIL_Set_ID = "Set ID";
        public static readonly string AIL_Segment_Action_Code = "Segment Action Code";
        public static readonly string AIL_Location_Resource_ID = "Location Resource ID";
        public static readonly string AIL_Location_Type_AIL = "Location Type - AIL";
        public static readonly string AIL_Location_Group = "Location Group";
        public static readonly string AIL_Start_DateTime = "Start DateTime";
        public static readonly string AIL_Start_DateTime_Offset = "Start DateTime Offset";
        public static readonly string AIL_Start_DateTime_Offset_Units = "Start DateTime Offset Units";
        public static readonly string AIL_Duration = "Duration";
        public static readonly string AIL_Duration_Units = "Duration Units";
        public static readonly string AIL_Allow_Subsitiutions = "Allow Subsitiutions";
        public static readonly string AIL_Filler_Status_Code = "Filler Status Code";

        #endregion "AIL"

        #region "EVN"

        public static readonly string EVN_Event_Type_Code = "Event Type Code";
        public static readonly string EVN_Recorded_Date_Time = "Recorded Date Time";
        public static readonly string EVN_Date_Time_Planned_Event = "Date Time Planned Event";
        public static readonly string EVN_Event_Reason_Code = "Event Reason Code";
        public static readonly string EVN_Operator_ID = "Operator ID";
        public static readonly string EVN_Event_Occured = "Event Occured";
        public static readonly string EVN_Event_Facility = "Event Facility";

        #endregion "EVN"

        #region "MSH"

        public static readonly string MSH_Field_Separator = "Field Separator";
        public static readonly string MSH_Encoding_Characters = "Encoding Characters";
        public static readonly string MSH_Sending_Application = "Sending Application";
        public static readonly string MSH_Sending_Facility = "Sending Facility";
        public static readonly string MSH_Receiving_Application = "Receiving Application";
        public static readonly string MSH_Receiving_Facility = "Receiving Facility";
        public static readonly string MSH_Date_Time_of_Message = "Date/Time of Message";
        public static readonly string MSH_Security = "Security";
        public static readonly string MSH_Message_Type = "Message Type";
        public static readonly string MSH_Message_Control_ID = "Message Control ID";
        public static readonly string MSH_Processing_ID = "Processing ID";
        public static readonly string MSH_Version_ID = "Version ID";
        public static readonly string MSH_Sequence_Number = "Sequence Number";
        public static readonly string MSH_Continuation_Pointer = "Continuation Pointer";
        public static readonly string MSH_Accept_Acknowledgment_Type = "Accept Acknowledgment Type";
        public static readonly string MSH_Application_Acknowledgment_Type = "Application Acknowledgment Type";
        public static readonly string MSH_Country_Code = "Country Code";
        public static readonly string MSH_Character_Set = "Character Set";
        public static readonly string MSH_Principal_Language_Of_Message = "Principal Language Of Message";
        public static readonly string MSH_Alternate_Character_Set_Handling_Scheme = "Alternate Character Set Handling Scheme";
        public static readonly string MSH_Message_Profile_Identifier = "Message Profile Identifier";
        public static readonly string MSH_Sending_Responsible_Organization = "Sending Responsible Organization";
        public static readonly string MSH_Receiving_Responsible_Organization = "Receiving Responsible Organization";
        public static readonly string MSH_Sending_Network_Address = "Sending Network Address";
        public static readonly string MSH_Receiving_Network_Address = "Receiving Network Address";

        #endregion "MSH"

        #region "OBR"

        public static readonly string OBR_Set_ID = "Set ID";
        public static readonly string OBR_Placer_Order_Number = "Placer Order Number";
        public static readonly string OBR_Filler_Order_Number = "Filler Order Number";
        public static readonly string OBR_Universal_Service_Identifier = "Universal Service Identifier";
        public static readonly string OBR_Priority = "Priority";
        public static readonly string OBR_Requested_DateTime = "Requested DateTime";
        public static readonly string OBR_Observation_DateTime = "Observation DateTime";
        public static readonly string OBR_Observation_End_DateTime = "Observation End DateTime";
        public static readonly string OBR_Collection_Volume = "Collection Volume";
        public static readonly string OBR_Collector_Identifer = "Collector Identifer";
        public static readonly string OBR_Specimen_Action_Code = "Specimen Action Code";
        public static readonly string OBR_Danger_Code = "Danger Code";
        public static readonly string OBR_Relevant_Clinical_Information = "Relevant Clinical Information";
        public static readonly string OBR_Specimen_Received_DateTime = "Specimen Received DateTime";
        public static readonly string OBR_Specimen_Source = "Specimen Source";
        public static readonly string OBR_Ordering_Provider = "Ordering Provider";
        public static readonly string OBR_Order_Callback_Phone_Number = "Order Callback Phone Number";
        public static readonly string OBR_Placer_Field_1 = "Placer Field 1";
        public static readonly string OBR_Placer_Field_2 = "Placer Field 2";
        public static readonly string OBR_Filler_Field_1 = "Filler Field 1 +";
        public static readonly string OBR_Filler_Field_2 = "Filler Field 2 +";
        public static readonly string OBR_Results_Report_Status_Change_DateTime = "Results Report Status Change DateTime";
        public static readonly string OBR_Charge_to_Practice = "Charge to Practice";
        public static readonly string OBR_Diagnostic_Serv_Sect_ID = "Diagnostic Serv Sect ID";
        public static readonly string OBR_Result_Status = "Result Status";
        public static readonly string OBR_Parent_Status = "Parent Status";
        public static readonly string OBR_QuantityTiming = "QuantityTiming";
        public static readonly string OBR_Result_Copies_To = "Result Copies To";
        public static readonly string OBR_Parent_Results_Observation_Identifier = "Parent Results Observation Identifier";
        public static readonly string OBR_Transportation_Mode = "Transportation Mode";
        public static readonly string OBR_Reason_for_Study = "Reason for Study";
        public static readonly string OBR_Principal_Result_Interpreter = "Principal Result Interpreter";
        public static readonly string OBR_Assistant_Result_Interpreter = "Assistant Result Interpreter";
        public static readonly string OBR_Technician = "Technician";
        public static readonly string OBR_Transcriptionist = "Transcriptionist";
        public static readonly string OBR_Scheduled_DateTime = "Scheduled DateTime";
        public static readonly string OBR_Number_of_Sample_Containers = "Number of Sample Containers";
        public static readonly string OBR_Transport_Logistics_of_Collected_Sample = "Transport Logistics of Collected Sample";
        public static readonly string OBR_Collectors_Comment = "Collectors Comment";
        public static readonly string OBR_Transport_Arrangement_Responsibility = "Transport Arrangement Responsibility";
        public static readonly string OBR_Transport_Arranged = "Transport Arranged";
        public static readonly string OBR_Escort_Required = "Escort Required";
        public static readonly string OBR_Planned_Patient_Transport_Comment = "Planned Patient Transport Comment";
        public static readonly string OBR_Procedure_Code = "Procedure Code";
        public static readonly string OBR_Procedure_Code_Modifier = "Procedure Code Modifier";
        public static readonly string OBR_Placer_Supplemental_Service_Information = "Placer Supplemental Service Information";
        public static readonly string OBR_Filler_Supplemental_Service_Information = "Filler Supplemental Service Information";
        public static readonly string OBR_Medically_Necessary_Duplicate_Procedure_Reason = "Medically Necessary Duplicate Procedure Reason";
        public static readonly string OBR_Result_Handling = "Result Handling";
        public static readonly string OBR_Parent_Universal_Service_Identifier = "Parent Universal Service Identifier";
        public static readonly string OBR_Observation_Group_ID = "Observation Group ID";
        public static readonly string OBR_Parent_Observation_Group_ID = "Parent Observation Group ID";
        public static readonly string OBR_Alternate_Placer_Order_Number = "Alternate Placer Order Number";
        public static readonly string OBR_Parent_Order = "Parent Order";

        #endregion "OBR"

        #region "OBX"

        public static readonly string OBX_Set_ID = "Set ID - OBX";
        public static readonly string OBX_Value_Type = "Value Type";
        public static readonly string OBX_Observation_Identifier = "Observation Identifier";
        public static readonly string OBX_Observation_Sub_ID = "Observation Sub_ID";
        public static readonly string OBX_Observation_Value = "Observation Value";
        public static readonly string OBX_Units = "Units";
        public static readonly string OBX_References_Range = "References Range";
        public static readonly string OBX_Interpretation_Codes = "Interpretation Codes";
        public static readonly string OBX_Probability = "Probability";
        public static readonly string OBX_Nature_of_Abnormal_Test = "Nature of Abnormal Test";
        public static readonly string OBX_Observation_Result_Status = "Observation Result Status";
        public static readonly string OBX_Effective_Date_of_Reference_Range = "Effective Date of Reference Range";
        public static readonly string OBX_User_Defined_Access_Checks = "User Defined Access Checks";
        public static readonly string OBX_DateTime_of_the_Observation = "DateTime of the Observation";
        public static readonly string OBX_Producers_ID = "Producers ID";
        public static readonly string OBX_Responsible_Observer = "Responsible Observer";
        public static readonly string OBX_Observation_Method = "Observation Method";
        public static readonly string OBX_Equipment_Instance_Identifier = "Equipment Instance Identifier";
        public static readonly string OBX_DateTime_of_the_Analysis = "DateTime of the Analysis";
        public static readonly string OBX_Observation_Site = "Observation Site";
        public static readonly string OBX_Observation_Instance_Identifier = "Observation Instance Identifier";
        public static readonly string OBX_Mood_Code = "Mood Code";
        public static readonly string OBX_Performing_Organization_Name = "Performing Organization Name";
        public static readonly string OBX_Performing_Organization_Address = "Performing Organization Address";
        public static readonly string OBX_Performing_Organization_Medical_Director = "Performing Organization Medical Director";
        public static readonly string OBX_Patient_Results_Release_Category = "Patient Results Release Category";
        public static readonly string OBX_Root_Cause = "Root Cause";
        public static readonly string OBX_Local_Process_Control = "Local Process Control";
        public static readonly string OBX_Observation_Type = "Observation Type";
        public static readonly string OBX_Observation_Sub_Type = "Observation Sub-Type";

        #endregion "OBX"

        #region "PV1"

        public static readonly string PV1_Set_ID = "Set ID";
        public static readonly string PV1_Patient_Class = "Patient Class";
        public static readonly string PV1_Assigned_Patient_Location = "Assigned Patient Location";
        public static readonly string PV1_Admission_Type = "Admission Type";
        public static readonly string PV1_Preadmit_Number = "Preadmit Number";
        public static readonly string PV1_Prior_Patient_Location = "Prior Patient Location";
        public static readonly string PV1_Attending_Doctor = "Attending Doctor";
        public static readonly string PV1_Referring_Doctor = "Referring Doctor";
        public static readonly string PV1_Consulting_Doctor = "Consulting Doctor";
        public static readonly string PV1_Hospital_Service = "Hospital Service";
        public static readonly string PV1_Temporary_Location = "Temporary Location";
        public static readonly string PV1_Preadmit_Test_Indicator = "Preadmit Test Indicator";
        public static readonly string PV1_Readmission_Indicator = "Re-admission Indicator";
        public static readonly string PV1_Admit_Source = "Admit Source";
        public static readonly string PV1_Ambulatory_Status = "Ambulatory Status";
        public static readonly string PV1_VIP_Indicator = "VIP Indicator";
        public static readonly string PV1_Admitting_Doctor = "Admitting Doctor";
        public static readonly string PV1_Patient_Type = "Patient Type";
        public static readonly string PV1_Visit_Number = "Visit Number";
        public static readonly string PV1_Financial_Class = "Financial Class";
        public static readonly string PV1_Charge_Price_Indicator = "Charge Price Indicator";
        public static readonly string PV1_Courtesy_Code = "Courtesy Code";
        public static readonly string PV1_Credit_Rating = "Credit Rating";
        public static readonly string PV1_Contract_Code = "Contract Code";
        public static readonly string PV1_Contract_Effective_Date = "Contract Effective Date";
        public static readonly string PV1_Contract_Amount = "Contract Amount";
        public static readonly string PV1_Contract_Period = "Contract Period";
        public static readonly string PV1_Interest_Code = "Interest Code";
        public static readonly string PV1_Transfer_to_Bad_Dept_Code = "Transfer to Bad Dept Code";
        public static readonly string PV1_Transfer_to_Bad_Debt_Date = "Transfer to Bad Debt Date";
        public static readonly string PV1_Bad_Debt_Agency_Code = "Bad Debt Agency Code";
        public static readonly string PV1_Bad_Debt_Transfer_Amount = "Bad Debt Transfer Amount";
        public static readonly string PV1_Bad_Debt_Recovery_Amount = "Bad Debt Recovery Amount";
        public static readonly string PV1_Delete_Account_Indicator = "Delete Account Indicator";
        public static readonly string PV1_Delete_Account_Date = "Delete Account Date";
        public static readonly string PV1_Discharge_Disposition = "Discharge Disposition";
        public static readonly string PV1_Discharged_to_Location = "Discharged to Location";
        public static readonly string PV1_Diet_Type = "Diet Type";
        public static readonly string PV1_Servicing_Facility = "Servicing Facility";
        public static readonly string PV1_Bed_Status = "Bed Status";
        public static readonly string PV1_Account_Status = "Account Status";
        public static readonly string PV1_Pending_Location = "Pending Location";
        public static readonly string PV1_Prior_Temporary_Location = "Prior Temporary Location";
        public static readonly string PV1_Admit_DateTime = "Admit DateTime";
        public static readonly string PV1_Discharge_DateTime = "Discharge DateTime";
        public static readonly string PV1_Current_Patient_Balance = "Current Patient Balance";
        public static readonly string PV1_Total_Charges = "Total Charges";
        public static readonly string PV1_Total_Adjustments = "Total Adjustments";
        public static readonly string PV1_Total_Payments = "Total Payments";
        public static readonly string PV1_Alternate_Visit_ID = "Alternate Visit ID";
        public static readonly string PV1_Visit_Indicator = "Visit Indicator";
        public static readonly string PV1_Other_Healthcare_Provider = "Other Healthcare Provider";
        public static readonly string PV1_Service_Episode_Description = "Service Episode Description";
        public static readonly string PV1_Service_Episode_Identifier = "Service Episode Identifier";

        #endregion "PV1"

        #region "SCH"

        public static readonly string SCH_Placer_Appointment_ID = "Placer Appointment ID";
        public static readonly string SCH_Filler_Appointment_ID = "Filler Appointment ID";
        public static readonly string SCH_Occurrence_Number = "Occurrence Number";
        public static readonly string SCH_Placer_Group_Number = "Placer Group Number";
        public static readonly string SCH_Schedule_ID = "Schedule ID";
        public static readonly string SCH_Event_Reason = "Event Reason";
        public static readonly string SCH_Appointment_Reason = "Appointment Reason";
        public static readonly string SCH_Appointment_Type = "Appointment Type";
        public static readonly string SCH_Appointment_Duration = "Appointment Duration";
        public static readonly string SCH_Appointment_Duration_Units = "Appointment Duration Units";
        public static readonly string SCH_Appointment_Timing_Quantity = "Appointment Timing Quantity";
        public static readonly string SCH_Placer_Contact_Person = "Placer Contact Person";
        public static readonly string SCH_Placer_Contact_Phone_Number = "Placer Contact Phone Number";
        public static readonly string SCH_Placer_Contact_Address = "Placer Contact Address";
        public static readonly string SCH_Placer_Contact_Location = "Placer Contact Location";
        public static readonly string SCH_Filler_Contact_Person = "Filler Contact Person";
        public static readonly string SCH_Filler_Contact_Phone_Number = "Filler Contact Phone Number";
        public static readonly string SCH_Filler_Contact_Address = "Filler Contact Address";
        public static readonly string SCH_Filler_Contact_Location = "Filler Contact Location";
        public static readonly string SCH_Entered_By_Person = "Entered By Person";
        public static readonly string SCH_Entered_By_Phone_Number = "Entered By Phone Number";
        public static readonly string SCH_Entered_By_Location = "Entered By Location";
        public static readonly string SCH_Parent_Placer_Appointment_ID = "Parent Placer Appointment ID";
        public static readonly string SCH_Parent_Filler_Appointment_ID = "Parent Filler Appointment ID";
        public static readonly string SCH_Filler_Status_Code = "Filler Status Code";
        public static readonly string SCH_Placer_Order_Number = "Placer Order Number";
        public static readonly string SCH_Filler_Order_Number = "Filler Order Number";

        #endregion "SCH"

        #region "ORC"

        public static readonly string ORC_Order_Control = "Order Control";
        public static readonly string ORC_Placer_Order_Number = "Placer Order Number";
        public static readonly string ORC_Filler_Order_Number = "Filler Order Number";
        public static readonly string ORC_Placer_Group_Number = "Placer Group Number";
        public static readonly string ORC_Order_Status = "Order Status";
        public static readonly string ORC_Response_Flag = "Response Flag";
        public static readonly string ORC_Quantity_Timing = "Quantity/Timing";
        public static readonly string ORC_Parent_Order = "Parent Order";
        public static readonly string ORC_Date_Time_of_Transaction = "Date/Time of Transaction";
        public static readonly string ORC_Entered_By = "Entered By";
        public static readonly string ORC_Verified_By = "Verified By";
        public static readonly string ORC_Ordering_Provider = "Ordering Provider";
        public static readonly string ORC_Enterers_Location = "Enterers Location";
        public static readonly string ORC_Call_Back_Phone_Number = "Call Back Phone Number";
        public static readonly string ORC_Order_Effective_Date_Time = "Order Effective Date/Time";
        public static readonly string ORC_Order_Control_Code_Reason = "Order Control Code Reason";
        public static readonly string ORC_Entering_Organization = "Entering Organization";
        public static readonly string ORC_Entering_Device = "Entering Device";
        public static readonly string ORC_Action_By = "Action By";
        public static readonly string ORC_Advanced_Beneficiary_Notice_Code = "Advanced Beneficiary Notice Code";
        public static readonly string ORC_Ordering_Facility_Name = "Ordering Facility Name";
        public static readonly string ORC_Ordering_Facility_Address = "Ordering Facility Address";
        public static readonly string ORC_Ordering_Facility_Phone_Number = "Ordering Facility Phone Number";
        public static readonly string ORC_Ordering_Provider_Address = "Ordering Provider Address";
        public static readonly string ORC_Order_Status_Modifier = "Order Status Modifier";
        public static readonly string ORC_Advanced_Beneficiary_Notice_Override_Reason = "Advanced Beneficiary Notice Override Reason";
        public static readonly string ORC_Fillers_Expected_Availability_Date_Time = "Fillers Expected Availability Date/Time";
        public static readonly string ORC_Confidentiality_Code = "Confidentiality Code";
        public static readonly string ORC_Order_Type = "Order Type";
        public static readonly string ORC_Enterer_Authorization_Mode = "Enterer Authorization Mode";
        public static readonly string ORC_Parent_Universal_Service_Identifier = "Parent Universal Service Identifier";
        public static readonly string ORC_Advanced_Beneficiary_Notice_Date = "Advanced Beneficiary Notice Date";
        public static readonly string ORC_Alternate_Placer_Order_Number = "Alternate Placer Order Number";
        public static readonly string ORC_Order_Workflow_Profile = "Order Workflow Profile";

        #endregion "ORC"

        #region "TXA"

        public static readonly string TXA_Set_ID = "Set ID";
        public static readonly string TXA_Document_Type = "Document Type";
        public static readonly string TXA_Document_Content_Presentation = "Document Content Presentation";
        public static readonly string TXA_Activity_DateTime = "Activity DateTime";
        public static readonly string TXA_Primary_Activity_Provider_Code_Name = "Primary Activity Provider Code/Name";
        public static readonly string TXA_Origination_DateTime = "Origination DateTime";
        public static readonly string TXA_Transcription_DateTime = "Transcription DateTime";
        public static readonly string TXA_Edit_DateTime = "Edit DateTime";
        public static readonly string TXA_Originator_Code_Name = "Originator Code/Name";
        public static readonly string TXA_Assigned_Document_Authenticator = "Assigned Document Authenticator";
        public static readonly string TXA_Transcriptionist_Code_Name = "Transcriptionist Code/Name";
        public static readonly string TXA_Unique_Document_Number = "Unique Document Number";
        public static readonly string TXA_Parent_Document_Number = "Parent Document Number";
        public static readonly string TXA_Placer_Order_Number = "Placer Order Number";
        public static readonly string TXA_Filler_Order_Number = "Filler Order Number";
        public static readonly string TXA_Unique_Document_File_Name = "Unique Document File Name";
        public static readonly string TXA_Document_Completion_Status = "Document Completion Status";
        public static readonly string TXA_Document_Confidentiality_Status = "Document Confidentiality Status";
        public static readonly string TXA_Document_Availability_Status = "Document Availability Status";
        public static readonly string TXA_Document_Storage_Status = "Document Storage Status";
        public static readonly string TXA_Document_Change_Reason = "Document Change Reason";
        public static readonly string TXA_Authentication_Person_Time_Stamp = "Authentication Person Time Stamp";
        public static readonly string TXA_Distributed_Copies = "Distributed Copies";
        public static readonly string TXA_Folder_Assignment = "Folder Assignment";
        public static readonly string TXA_Document_Title = "Document Title";
        public static readonly string TXA_Agreed_Due_DateTime = "Agreed Due DateTime";

        #endregion "TXA"

        #region "RXA"

        public static readonly string RXA_Give_Sub_ID_Counter = "Give Sub-ID Counter";
        public static readonly string RXA_Administration_Sub_ID_Counter = "Administration Sub-ID Counter";
        public static readonly string RXA_Date_Time_Start_of_Administration = "Date/Time Start of Administration";
        public static readonly string RXA_Date_Time_End_of_Administration = "Date/Time End of Administration";
        public static readonly string RXA_Administered_Code = "Administered Code";
        public static readonly string RXA_Administered_Amount = "Administered Amount";
        public static readonly string RXA_Administered_Units = "Administered Units";
        public static readonly string RXA_Administered_Dosage_Form = "Administered Dosage Form";
        public static readonly string RXA_Administration_Notes = "Administration Notes";
        public static readonly string RXA_Administering_Provider = "Administering Provider";
        public static readonly string RXA_Administered_at_Location = "Administered-at Location";
        public static readonly string RXA_Administered_Per_Time_Unit = "Administered Per (Time Unit)";
        public static readonly string RXA_Administered_Strength = "Administered Strength";
        public static readonly string RXA_Administered_Strength_Units = "Administered Strength Units";
        public static readonly string RXA_Substance_Lot_Number = "Substance Lot Number";
        public static readonly string RXA_Substance_Expiration_Date = "Substance Expiration Date";
        public static readonly string RXA_Substance_Manufacturer_Name = "Substance Manufacturer Name";
        public static readonly string RXA_Substance_Treatment_Refusal_Reason = "Substance/Treatment Refusal Reason";
        public static readonly string RXA_Indication = "Indication";
        public static readonly string RXA_Completion_Status = "Completion Status";
        public static readonly string RXA_Action_Code = "Action Code";
        public static readonly string RXA_System_Entry_Date_Time = "System Entry Date/Time";
        public static readonly string RXA_Administered_Drug_Strength_Volume = "Administered Drug Strength Volume";
        public static readonly string RXA_Administered_Drug_Strength_Volume_Units = "Administered Drug Strength Volume Units";
        public static readonly string RXA_Administered_Barcode_Identifier = "Administered Barcode Identifier";
        public static readonly string RXA_Pharmacy_Order_Type_ID = "Pharmacy Order Type ID";

        #endregion "RXA"

        #region "RGS"

        public static readonly string RGS_Set_ID = "Set ID";
        public static readonly string RGS_Segment_Action_Code = "Segment Action Code";
        public static readonly string RGS_Resource_Group_ID = "Resource Group ID";

        #endregion "RGS"

        #region "ROL"

        public static readonly string ROL_Role_Instance_ID = "Role Instance ID";
        public static readonly string ROL_Action_Code = "Action Code";
        public static readonly string ROL_Role = "Role";
        public static readonly string ROL_Role_Person = "Role Person";
        public static readonly string ROL_Role_Begin_Date_Time = "Role Begin Date Time";
        public static readonly string ROL_Role_End_Date_Time = "Role End Date Time";
        public static readonly string ROL_Role_Duration = "Role Duration";
        public static readonly string ROL_Role_Action_Reason = "Role Action Reason";
        public static readonly string ROL_Provider_Type = "Provider Type";
        public static readonly string ROL_Organization_Unit_Type = "Organization Unit Type";
        public static readonly string ROL_Office_Home_Address_Birthplace = "Office Home Address Birthplace";
        public static readonly string ROL_Phone = "Phone";
        public static readonly string ROL_Person_Location = "Person Location";
        public static readonly string ROL_Organization = "Organization";

        #endregion "ROL"

        #region "AIS"

        public static readonly string AIS_Set_ID = "Set ID";
        public static readonly string AIS_Segment_Action_Code = "Segment Action Code";
        public static readonly string AIS_Universal_Service_Identifier = "Universal Service Identifier";
        public static readonly string AIS_Start_Date_Time = "Start Date Time";
        public static readonly string AIS_Start_Date_Time_Offset = "Start Date Time Offset";
        public static readonly string AIS_Start_Date_Time_Offset_Units = "Start Date Time Offset Units";
        public static readonly string AIS_Duration = "Duration";
        public static readonly string AIS_Duration_Units = "Duration Units";
        public static readonly string AIS_Allow_Substitution_Code = "Allow Substitution Code";
        public static readonly string AIS_Filler_Status_Code = "Filler Status Code";
        public static readonly string AIS_Placer_Supplemental_Service_Information = "Placer Supplemental Service Information";
        public static readonly string AIS_Filler_Supplemental_Service_Information = "Filler Supplemental Service Information";

        #endregion "AIS"

        #region "AIP"

        public static readonly string AIP_Set_ID = "Set ID";
        public static readonly string AIP_Segment_Action_Code = "Segment Action Code";
        public static readonly string AIP_Personnel_Resource_ID = "Personnel Resource ID";
        public static readonly string AIP_Resource_Type = "Resource Type";
        public static readonly string AIP_Resource_Group = "Resource Group";
        public static readonly string AIP_Start_Date_Time = "Start Date/Time";
        public static readonly string AIP_Start_Date_Time_Offset = "Start Date/Time Offset";
        public static readonly string AIP_Start_Date_Time_Offset_Units = "Start Date/Time Offset Units";
        public static readonly string AIP_Duration = "Duration";
        public static readonly string AIP_Duration_Units = "Duration Units";
        public static readonly string AIP_Allow_Substitution_Code = "Allow Substitution Code";
        public static readonly string AIP_Filler_Status_Code = "Filler Status Code";

        #endregion "AIP"

        #region "PR1"

        public static readonly string PR1_Set_ID = "Set ID";
        public static readonly string PR1_Procedure_Coding_Method = "Procedure Coding Method";
        public static readonly string PR1_Procedure_Code = "Procedure Code";
        public static readonly string PR1_Procedure_Description = "Procedure Description";
        public static readonly string PR1_Procedure_Date_Time = "Procedure Date Time";
        public static readonly string PR1_Procedure_Functional_Type = "Procedure Functional Type";
        public static readonly string PR1_Procedure_Minutes = "Procedure Minutes";
        public static readonly string PR1_Anesthesiologist = "Anesthesiologist";
        public static readonly string PR1_Anesthesia_Code = "Anesthesia Code";
        public static readonly string PR1_Anesthesia_Minutes = "Anesthesia Minutes";
        public static readonly string PR1_Surgeon = "Surgeon";
        public static readonly string PR1_Procedure_Practitioner = "Procedure Practitioner";
        public static readonly string PR1_Consent_Code = "Consent Code";
        public static readonly string PR1_Procedure_Priority = "Procedure Priority";
        public static readonly string PR1_Associated_Diagnosis_Code = "Associated Diagnosis Code";
        public static readonly string PR1_Procedure_Code_Modifier = "Procedure Code Modifier";
        public static readonly string PR1_Procedure_DRG_Type = "Procedure DRG Type";
        public static readonly string PR1_Tissue_Type_Code = "Tissue Type Code";
        public static readonly string PR1_Procedure_Identifier = "Procedure Identifier";
        public static readonly string PR1_Procedure_Action_Code = "Procedure Action Code";
        public static readonly string PR1_DRG_Procedure_Determination_Status = "DRG Procedure Determination Status";
        public static readonly string PR1_DRG_Procedure_Relevance = "DRG Procedure Relevance";
        public static readonly string PR1_Treating_Organizational_Unit = "Treating Organizational Unit";
        public static readonly string PR1_Respiratory_Within_Surgery = "Respiratory Within Surgery";
        public static readonly string PR1_Parent_Procedure_ID = "Parent Procedure ID";

        #endregion "PR1"

        #region "NTE"

        public static readonly string NTE_Set_ID = "Set ID";
        public static readonly string NTE_Source_of_Comment = "Source of Comment";
        public static readonly string NTE_Comment = "Comment";
        public static readonly string NTE_Comment_Type = "Comment Type";
        public static readonly string NTE_Entered_By = "Entered By";
        public static readonly string NTE_Entered_Date_Time = "Entered Date Time";
        public static readonly string NTE_Effective_Start_Date = "Effective Start Date";
        public static readonly string NTE_Expiration_Date = "Expiration Date";

        #endregion "NTE"

        #region "NK1"

        public static readonly string NK1_Set_ID = "Set ID";
        public static readonly string NK1_Name = "Name";
        public static readonly string NK1_Relationship = "Relationship";
        public static readonly string NK1_Address = "Address";
        public static readonly string NK1_Phone_Number = "Phone Number";
        public static readonly string NK1_Business_Phone_Number = "Business Phone Number";
        public static readonly string NK1_Contact_Role = "Contact Role";
        public static readonly string NK1_Start_Date = "Start Date";
        public static readonly string NK1_End_Date = "End Date";
        public static readonly string NK1_Next_of_Kin_Associated_Parties_Job_Title = "Next of Kin Associated Parties Job Title";
        public static readonly string NK1_Next_of_Kin_Associated_Parties_Job_Code_Class = "Next of Kin Associated Parties Job Code Class";
        public static readonly string NK1_Next_of_Kin_Associated_Parties_Employee_Number = "Next of Kin Associated Parties Employee Number";
        public static readonly string NK1_Organization_Name = "Organization Name";
        public static readonly string NK1_Marital_Status = "Marital Status";
        public static readonly string NK1_Administrative_Sex = "Administrative Sex";
        public static readonly string NK1_Date_Time_of_Birth = "Date Time of Birth";
        public static readonly string NK1_Living_Dependency = "Living Dependency";
        public static readonly string NK1_Ambulatory_Status = "Ambulatory Status";
        public static readonly string NK1_Citizenship = "Citizenship";
        public static readonly string NK1_Primary_Language = "Primary Language";
        public static readonly string NK1_Living_Arrangement = "Living Arrangement";
        public static readonly string NK1_Publicity_Code = "Publicity Code";
        public static readonly string NK1_Protection_Indicator = "Protection Indicator";
        public static readonly string NK1_Student_Indicator = "Student Indicator";
        public static readonly string NK1_Religion = "Religion";
        public static readonly string NK1_Mothers_Maiden_Name = "Mothers Maiden Name";
        public static readonly string NK1_Nationality = "Nationality";
        public static readonly string NK1_Ethnic_Group = "Ethnic Group";
        public static readonly string NK1_Contact_Reason = "Contact Reason";
        public static readonly string NK1_Contact_Persons_Name = "Contact Persons Name";
        public static readonly string NK1_Contact_Persons_Telephone_Number = "Contact Persons Telephone Number";
        public static readonly string NK1_Contact_Persons_Address = "Contact Persons Address";
        public static readonly string NK1_Next_of_Kin_Associated_Partys_Identifiers = "Next of Kin Associated Party s Identifiers";
        public static readonly string NK1_Job_Status = "Job Status";
        public static readonly string NK1_Race = "Race";
        public static readonly string NK1_Handicap = "Handicap";
        public static readonly string NK1_Contact_Person_Social_Security_Number = "Contact Person Social Security Number";
        public static readonly string NK1_Next_of_Kin_Birth_Place = "Next of Kin Birth Place";
        public static readonly string NK1_VIP_Indicator = "VIP Indicator";
        public static readonly string NK1_Next_of_Kin_Telecommunication_Information = "Next of Kin Telecommunication Information";
        public static readonly string NK1_Contact_Persons_Telecommunication_Information = "Contact Persons Telecommunication Information";

        #endregion "NK1"

        #region "PV2"

        public static readonly string PV2_Prior_Pending_Location = "Prior Pending Location";
        public static readonly string PV2_Accommodation_Code = "Accommodation Code";
        public static readonly string PV2_Admit_Reason = "Admit Reason";
        public static readonly string PV2_Transfer_Reason = "Transfer Reason";
        public static readonly string PV2_Patient_Valuables = "Patient Valuables";
        public static readonly string PV2_Patient_Valuables_Location = "Patient Valuables Location";
        public static readonly string PV2_Visit_User_Code = "Visit User Code";
        public static readonly string PV2_Expected_Admit_Date_Time = "Expected Admit Date Time";
        public static readonly string PV2_Expected_Discharge_Date_Time = "Expected Discharge Date Time";
        public static readonly string PV2_Estimated_Length_of_Inpatient_Stay = "Estimated Length of Inpatient Stay";
        public static readonly string PV2_Actual_Length_of_Inpatient_Stay = "Actual Length of Inpatient Stay";
        public static readonly string PV2_Visit_Description = "Visit Description";
        public static readonly string PV2_Referral_Source_Code = "Referral Source Code";
        public static readonly string PV2_Previous_Service_Date = "Previous Service Date";
        public static readonly string PV2_Employment_Illness_Related_Indicator = "Employment Illness Related Indicator";
        public static readonly string PV2_Purge_Status_Code = "Purge Status Code";
        public static readonly string PV2_Purge_Status_Date = "Purge Status Date";
        public static readonly string PV2_Special_Program_Code = "Special Program Code";
        public static readonly string PV2_Retention_Indicator = "Retention Indicator";
        public static readonly string PV2_Expected_Number_of_Insurance_Plans = "Expected Number of Insurance Plans";
        public static readonly string PV2_Visit_Publicity_Code = "Visit Publicity Code";
        public static readonly string PV2_Visit_Protection_Indicator = "Visit Protection Indicator";
        public static readonly string PV2_Clinic_Organization_Name = "Clinic Organization Name";
        public static readonly string PV2_Patient_Status_Code = "Patient Status Code";
        public static readonly string PV2_Visit_Priority_Code = "Visit Priority Code";
        public static readonly string PV2_Previous_Treatment_Date = "Previous Treatment Date";
        public static readonly string PV2_Expected_Discharge_Disposition = "Expected Discharge Disposition";
        public static readonly string PV2_Signature_on_File_Date = "Signature on File Date";
        public static readonly string PV2_First_Similar_Illness_Date = "First Similar Illness Date";
        public static readonly string PV2_Patient_Charge_Adjustment_Code = "Patient Charge Adjustment Code";
        public static readonly string PV2_Recurring_Service_Code = "Recurring Service Code";
        public static readonly string PV2_Billing_Media_Code = "Billing Media Code";
        public static readonly string PV2_Expected_Surgery_Date_and_Time = "Expected Surgery Date and Time";
        public static readonly string PV2_Military_Partnership_Code = "Military Partnership Code";
        public static readonly string PV2_Military_Non_Availability_Code = "Military Non-Availability Code";
        public static readonly string PV2_Newborn_Baby_Indicator = "Newborn Baby Indicator";
        public static readonly string PV2_Baby_Detained_Indicator = "Baby Detained Indicator";
        public static readonly string PV2_Mode_of_Arrival_Code = "Mode of Arrival Code";
        public static readonly string PV2_Recreational_Drug_Use_Code = "Recreational Drug Use Code";
        public static readonly string PV2_Admission_Level_of_Care_Code = "Admission Level of Care Code";
        public static readonly string PV2_Precaution_Code = "Precaution Code";
        public static readonly string PV2_Patient_Condition_Code = "Patient Condition Code";
        public static readonly string PV2_Living_Will_Code = "Living Will Code";
        public static readonly string PV2_Organ_Donor_Code = "Organ Donor Code";
        public static readonly string PV2_Advance_Directive_Code = "Advance Directive Code";
        public static readonly string PV2_Patient_Status_Effective_Date = "Patient Status Effective Date";
        public static readonly string PV2_Expected_LOA_Return_Date_Time = "Expected LOA Return Date Time";
        public static readonly string PV2_Expected_Preadmission_Testing_Date_Time = "Expected Preadmission Testing Date Time";
        public static readonly string PV2_Notify_Clergy_Code = "Notify Clergy Code";
        public static readonly string PV2_Advance_Directive_Last_Verified_Date = "Advance Directive Last Verified Date";

        #endregion "PV2"

        #region "DRG"

        public static readonly string DRG_Diagnostic_Related_Group = "Diagnostic Related Group";
        public static readonly string DRG_Assigned_Date_Time = "DRG Assigned Date Time";
        public static readonly string DRG_Approval_Indicator = "DRG Approval Indicator";
        public static readonly string DRG_Grouper_Review_Code = "DRG Grouper Review Code";
        public static readonly string DRG_Outlier_Type = "Outlier Type";
        public static readonly string DRG_Outlier_Days = "Outlier Days";
        public static readonly string DRG_Outlier_Cost = "Outlier Cost";
        public static readonly string DRG_Payor = "DRG Payor";
        public static readonly string DRG_Outlier_Reimbursement = "Outlier Reimbursement";
        public static readonly string DRG_Confidential_Indicator = "Confidential Indicator";
        public static readonly string DRG_Transfer_Type = "DRG Transfer Type";
        public static readonly string DRG_Name_of_Coder = "Name of Coder";
        public static readonly string DRG_Grouper_Status = "Grouper Status";
        public static readonly string DRG_PCCL_Value_Code = "PCCL Value Code";
        public static readonly string DRG_Effective_Weight = "Effective Weight";
        public static readonly string DRG_Monetary_Amount = "Monetary Amount";
        public static readonly string DRG_Status_Patient = "Status Patient";
        public static readonly string DRG_Grouper_Software_Name = "Grouper Software Name";
        public static readonly string DRG_Grouper_Software_Version = "Grouper Software Version";
        public static readonly string DRG_Status_Financial_Calculation = "Status Financial Calculation";
        public static readonly string DRG_Relative_Discount_Surcharge = "Relative Discount Surcharge";
        public static readonly string DRG_Basic_Charge = "Basic Charge";
        public static readonly string DRG_Total_Charge = "Total Charge";
        public static readonly string DRG_Discount_Surcharge = "Discount Surcharge";
        public static readonly string DRG_Calculated_Days = "Calculated Days";
        public static readonly string DRG_Status_Gender = "Status Gender";
        public static readonly string DRG_Status_Age = "Status Age";
        public static readonly string DRG_Status_Length_of_Stay = "Status Length of Stay";
        public static readonly string DRG_Status_Same_Day_Flag = "Status Same Day Flag";
        public static readonly string DRG_Status_Separation_Mode = "Status Separation Mode";
        public static readonly string DRG_Status_Weight_at_Birth = "Status Weight at Birth";
        public static readonly string DRG_Status_Respiration_Minutes = "Status Respiration Minutes";
        public static readonly string DRG_Status_Admission = "Status Admission";

        #endregion "DRG"

        #region "DG1"

        public static readonly string DG1_Set_ID = "Set ID";
        public static readonly string DG1_Diagnosis_Coding_Method = "Diagnosis Coding Method";
        public static readonly string DG1_Diagnosis_Code = "Diagnosis Code";
        public static readonly string DG1_Diagnosis_Description = "Diagnosis Description";
        public static readonly string DG1_Diagnosis_Date_Time = "Diagnosis Date Time";
        public static readonly string DG1_Diagnosis_Type = "Diagnosis Type";
        public static readonly string DG1_Major_Diagnostic_Category = "Major Diagnostic Category";
        public static readonly string DG1_Diagnostic_Related_Group = "Diagnostic Related Group";
        public static readonly string DG1_Approval_Indicator = "Approval Indicator";
        public static readonly string DG1_Grouper_Review_Code = "Grouper Review Code";
        public static readonly string DG1_Outlier_Type = "Outlier Type";
        public static readonly string DG1_Outlier_Days = "Outlier Days";
        public static readonly string DG1_Outlier_Cost = "Outlier Cost";
        public static readonly string DG1_Grouper_Version_Type = "Grouper Version And Type";
        public static readonly string DG1_Diagnosis_Priority = "Diagnosis Priority";
        public static readonly string DG1_Diagnosing_Clinician = "Diagnosing Clinician";
        public static readonly string DG1_Diagnosing_Classification = "Diagnosis Classification";
        public static readonly string DG1_Confidential_Indicator = "Confidential Indicator";
        public static readonly string DG1_Attestation_Date_Time = "Attestation Date Time";
        public static readonly string DG1_Diagnosis_Identifier = "Diagnosis Identifier";
        public static readonly string DG1_Diagnosis_Action_Code = "Diagnosis Action Code";
        public static readonly string DG1_Parent_Diagnosis = "Parent Diagnosis";
        public static readonly string DG1_CCL_Value_Code = "CCL Value Code";
        public static readonly string DG1_Grouping_Usage = "Grouping Usage";
        public static readonly string DG1_Diagnosis_Determination_Status = "Diagnosis Determination Status";
        public static readonly string DG1_Present_On_Admission_Indicator = "Present On Admission Indicator";

        #endregion "DG1"

        #region "GT1"

        public static readonly string GT1_Set_ID = "Set ID";
        public static readonly string GT1_Guarantor_Number = "Guarantor Number";
        public static readonly string GT1_Guarantor_Name = "Guarantor Name";
        public static readonly string GT1_Guarantor_Spouse_Name = "Guarantor Spouse Name";
        public static readonly string GT1_Guarantor_Address = "Guarantor Address";
        public static readonly string GT1_Guarantor_Phone_Home = "Guarantor Phone Home";
        public static readonly string GT1_Guarantor_Phone_Business = "Guarantor Phone Business";
        public static readonly string GT1_Guarantor_Date_Time_Of_Birth = "Guarantor Date Time Of Birth";
        public static readonly string GT1_Guarantor_Administrative_Sex = "Guarantor Administrative Sex";
        public static readonly string GT1_Guarantor_Type = "Guarantor Type";
        public static readonly string GT1_Guarantor_Relationship = "Guarantor Relationship";
        public static readonly string GT1_Guarantor_SSN = "Guarantor SSN";
        public static readonly string GT1_Guarantor_Date_Begin = "Guarantor Date Begin";
        public static readonly string GT1_Guarantor_Date_End = "Guarantor Date End";
        public static readonly string GT1_Guarantor_Priority = "Guarantor Priority";
        public static readonly string GT1_Guarantor_Employer_Name = "Guarantor Employer Name";
        public static readonly string GT1_Guarantor_Employer_Address = "Guarantor Employer Address";
        public static readonly string GT1_Guarantor_Employer_Phone_Number = "Guarantor Employer Phone Number";
        public static readonly string GT1_Guarantor_Employee_ID_Number = "Guarantor Employee ID Number";
        public static readonly string GT1_Guarantor_Employment_Status = "Guarantor Employment Status";
        public static readonly string GT1_Guarantor_Organization_Name = "Guarantor Organization Name";
        public static readonly string GT1_Guarantor_Billing_Hold_Flag = "Guarantor Billing Hold Flag";
        public static readonly string GT1_Guarantor_Credit_Rating_Code = "Guarantor Credit Rating Code";
        public static readonly string GT1_Guarantor_Death_Date_And_Time = "Guarantor Death Date And Time";
        public static readonly string GT1_Guarantor_Death_Flag = "Guarantor Death Flag";
        public static readonly string GT1_Guarantor_Charge_Adjustment_Code = "Guarantor Charge Adjustment Code";
        public static readonly string GT1_Guarantor_Household_Annual_Income = "Guarantor Household Annual Income";
        public static readonly string GT1_Guarantor_Household_Size = "Guarantor Household Size";
        public static readonly string GT1_Guarantor_Employer_ID_Number = "Guarantor Employer ID Number";
        public static readonly string GT1_Guarantor_Marital_Status_Code = "Guarantor Marital Status Code";
        public static readonly string GT1_Guarantor_Hire_Effective_Date = "Guarantor Hire Effective Date";
        public static readonly string GT1_Employment_Stop_Date = "Employment Stop Date";
        public static readonly string GT1_Living_Dependency = "Living Dependency";
        public static readonly string GT1_Ambulatory_Status = "Ambulatory Status";
        public static readonly string GT1_Citizenship = "Citizenship";
        public static readonly string GT1_Primary_Language = "Primary Language";
        public static readonly string GT1_Living_Arrangement = "Living Arrangement";
        public static readonly string GT1_Publicity_Code = "Publicity Code";
        public static readonly string GT1_Protection_Indicator = "Protection Indicator";
        public static readonly string GT1_Student_Indicator = "Student Indicator";
        public static readonly string GT1_Religion = "Religion";
        public static readonly string GT1_Mothers_Maiden_Name = "Mothers Maiden Name";
        public static readonly string GT1_Nationality = "Nationality";
        public static readonly string GT1_Ethnic_Group = "Ethnic Group";
        public static readonly string GT1_Contact_Persons_Name = "Contact Persons Name";
        public static readonly string GT1_Contact_Persons_Telephone_Number = "Contact Persons Telephone Number";
        public static readonly string GT1_Contact_Reason = "Contact Reason";
        public static readonly string GT1_Contact_Relationship = "Contact Relationship";
        public static readonly string GT1_Job_Title = "Job Title";
        public static readonly string GT1_Job_Code_Class = "Job Code Class";
        public static readonly string GT1_Guarantor_Employers_Organization_Name = "Guarantor Employers Organization Name";
        public static readonly string GT1_Handicap = "Handicap";
        public static readonly string GT1_Job_Status = "Job Status";
        public static readonly string GT1_Guarantor_Financial_Class = "Guarantor Financial Class";
        public static readonly string GT1_Guarantor_Race = "Guarantor Race";
        public static readonly string GT1_Guarantor_Birth_Place = "Guarantor Birth Place";
        public static readonly string GT1_VIP_Indicator = "VIP Indicator";

        #endregion "GT1"

        #region "IN1"

        public static readonly string IN1_Set_ID = "Set ID";
        public static readonly string IN1_Health_Plan_ID = "Health Plan ID";
        public static readonly string IN1_Insurance_Company_ID = "Insurance Company ID";
        public static readonly string IN1_Insurance_Company_Name = "Insurance Company Name";
        public static readonly string IN1_Insurance_Company_Address = "Insurance Company Address";
        public static readonly string IN1_Insurance_Company_Contact_Person = "Insurance Company Contact Person";
        public static readonly string IN1_Insurance_Company_Phone_Number = "Insurance Company Phone Number";
        public static readonly string IN1_Group_Number = "Group Number";
        public static readonly string IN1_Group_Name = "Group Name";
        public static readonly string IN1_Insureds_Group_Employee_ID = "Insureds Group Employee ID";
        public static readonly string IN1_Insureds_Group_Employee_Name = "Insureds Group Employee Name";
        public static readonly string IN1_Plan_Effective_Date = "Plan Effective Date";
        public static readonly string IN1_Plan_Expiration_Date = "Plan Expiration Date";
        public static readonly string IN1_Authorization_Information = "Authorization Information";
        public static readonly string IN1_Plan_Type = "Plan Type";
        public static readonly string IN1_Name_Of_Insured = "Name Of Insured";
        public static readonly string IN1_Insureds_Relationship_To_Patient = "Insureds Relationship To Patient";
        public static readonly string IN1_Insureds_Date_Of_Birth = "Insureds Date Of Birth";
        public static readonly string IN1_Insureds_Address = "Insureds Address";
        public static readonly string IN1_Assignment_Of_Benefits = "Assignment Of Benefits";
        public static readonly string IN1_Coordination_Of_Benefits = "Coordination Of Benefits";
        public static readonly string IN1_Coord_Of_Ben_Priority = "Coord Of Ben. Priority";
        public static readonly string IN1_Notice_Of_Admission_Flag = "Notice Of Admission Flag";
        public static readonly string IN1_Notice_Of_Admission_Date = "Notice Of Admission Date";
        public static readonly string IN1_Report_Of_Eligibility_Flag = "Report Of Eligibility Flag";
        public static readonly string IN1_Report_Of_Eligibility_Date = "Report Of Eligibility Date";
        public static readonly string IN1_Release_Information_Code = "Release Information Code";
        public static readonly string IN1_Pre_Admit_Cert = "Pre Admit Cert";
        public static readonly string IN1_Verification_Date_Time = "Verification Date Time";
        public static readonly string IN1_Verification_By = "Verification By";
        public static readonly string IN1_Type_Of_Agreement_Code = "Type Of Agreement Code";
        public static readonly string IN1_Billing_Status = "Billing Status";
        public static readonly string IN1_Lifetime_Reserve_Days = "Lifetime Reserve Days";
        public static readonly string IN1_Delay_Before_L_R_Day = "Delay Before L.R. Day";
        public static readonly string IN1_Company_Plan_Code = "Company Plan Code";
        public static readonly string IN1_Policy_Number = "Policy Number";
        public static readonly string IN1_Policy_Deductible = "Policy Deductible";
        public static readonly string IN1_Policy_Limit_Amount = "Policy Limit Amount";
        public static readonly string IN1_Policy_Limit_Days = "Policy Limit Days";
        public static readonly string IN1_Room_Rate_Semi_Private = "Room Rate Semi Private";
        public static readonly string IN1_Room_Rate_Private = "Room Rate Private";
        public static readonly string IN1_Insureds_Employment_Status = "Insureds Employment Status";
        public static readonly string IN1_Insureds_Administrative_Sex = "Insureds Administrative Sex";
        public static readonly string IN1_Insureds_Employers_Address = "Insureds Employers Address";
        public static readonly string IN1_Verification_Status = "Verification Status";
        public static readonly string IN1_Prior_Insurance_Plan_ID = "Prior Insurance Plan ID";
        public static readonly string IN1_Coverage_Type = "Coverage Type";
        public static readonly string IN1_Handicap = "Handicap";
        public static readonly string IN1_Insureds_ID_Number = "Insureds ID Number";
        public static readonly string IN1_Signature_Code = "Signature Code";
        public static readonly string IN1_Signature_Code_Date = "Signature Code Date";
        public static readonly string IN1_Insureds_Birth_Place = "Insureds Birth Place";
        public static readonly string IN1_VIP_Indicator = "VIP Indicator";
        public static readonly string IN1_External_Health_Plan_Identifiers = "External Health Plan Identifiers";
        public static readonly string IN1_Insurance_Action_Code = "Insurance Action Code";

        #endregion "IN1"

        #region "IN2"

        public static readonly string IN2_Insureds_Employee_ID = "Insureds Employee ID";
        public static readonly string IN2_Insureds_Social_Security_Number = "Insureds Social Security Number";
        public static readonly string IN2_Insureds_Employers_Name_and_ID = "Insureds Employers Name and ID";
        public static readonly string IN2_Employer_Information_Data = "Employer Information Data";
        public static readonly string IN2_Mail_Claim_Party = "Mail Claim Party";
        public static readonly string IN2_Medicare_Health_Ins_Card_Number = "Medicare Health Ins Card Number";
        public static readonly string IN2_Medicaid_Case_Name = "Medicaid Case Name";
        public static readonly string IN2_Medicaid_Case_Number = "Medicaid Case Number";
        public static readonly string IN2_Military_Sponsor_Name = "Military Sponsor Name";
        public static readonly string IN2_Military_ID_Number = "Military ID Number";
        public static readonly string IN2_Dependent_Of_Military_Recipient = "Dependent Of Military Recipient";
        public static readonly string IN2_Military_Organization = "Military Organization";
        public static readonly string IN2_Military_Station = "Military Station";
        public static readonly string IN2_Military_Service = "Military Service";
        public static readonly string IN2_Military_Rank_Grade = "Military Rank Grade";
        public static readonly string IN2_Military_Status = "Military Status";
        public static readonly string IN2_Military_Retire_Date = "Military Retire Date";
        public static readonly string IN2_Military_Non_Avail_Cert_On_File = "Military Non Avail Cert On File";
        public static readonly string IN2_Baby_Coverage = "Baby Coverage";
        public static readonly string IN2_Combine_Baby_Bill = "Combine Baby Bill";
        public static readonly string IN2_Blood_Deductible = "Blood Deductible";
        public static readonly string IN2_Special_Coverage_Approval_Name = "Special Coverage Approval Name";
        public static readonly string IN2_Special_Coverage_Approval_Title = "Special Coverage Approval Title";
        public static readonly string IN2_Non_Covered_Insurance_Code = "Non Covered Insurance Code";
        public static readonly string IN2_Payor_ID = "Payor ID";
        public static readonly string IN2_Payor_Subscriber_ID = "Payor Subscriber ID";
        public static readonly string IN2_Eligibility_Source = "Eligibility Source";
        public static readonly string IN2_Room_Coverage_Type_Amount = "Room Coverage Type Amount";
        public static readonly string IN2_Policy_Type_Amount = "Policy Type Amount";
        public static readonly string IN2_Daily_Deductible = "Daily Deductible";
        public static readonly string IN2_Living_Dependency = "Living Dependency";
        public static readonly string IN2_Ambulatory_Status = "Ambulatory Status";
        public static readonly string IN2_Citizenship = "Citizenship";
        public static readonly string IN2_Primary_Language = "Primary Language";
        public static readonly string IN2_Living_Arrangement = "Living Arrangement";
        public static readonly string IN2_Publicity_Code = "Publicity Code";
        public static readonly string IN2_Protection_Indicator = "Protection Indicator";
        public static readonly string IN2_Student_Indicator = "Student Indicator";
        public static readonly string IN2_Religion = "Religion";
        public static readonly string IN2_Mothers_Maiden_Name = "Mothers Maiden Name";
        public static readonly string IN2_Nationality = "Nationality";
        public static readonly string IN2_Ethnic_Group = "Ethnic Group";
        public static readonly string IN2_Marital_Status = "Marital Status";
        public static readonly string IN2_Insureds_Employment_Start_Date = "Insureds Employment Start Date";
        public static readonly string IN2_Employment_Stop_Date = "Employment Stop Date";
        public static readonly string IN2_Job_Title = "Job Title";
        public static readonly string IN2_Job_Code_Class = "Job Code Class";
        public static readonly string IN2_Job_Status = "Job Status";
        public static readonly string IN2_Employer_Contact_Person_Name = "Employer Contact Person Name";
        public static readonly string IN2_Employer_Contact_Person_Phone_Number = "Employer Contact Person Phone Number";
        public static readonly string IN2_Employer_Contact_Reason = "Employer Contact Reason";
        public static readonly string IN2_Insureds_Contact_Persons_Name = "Insureds Contact Persons Name";
        public static readonly string IN2_Insureds_Contact_Person_Phone_Number = "Insureds Contact Person Phone Number";
        public static readonly string IN2_Insureds_Contact_Person_Reason = "Insureds Contact Person Reason";
        public static readonly string IN2_Relationship_to_the_Patient_Start_Date = "Relationship to the Patient Start Date";
        public static readonly string IN2_Relationship_to_the_Patient_Stop_Date = "Relationship to the Patient Stop Date";
        public static readonly string IN2_Insurance_Co_Contact_Reason = "Insurance Co Contact Reason";
        public static readonly string IN2_Insurance_Co_Contact_Phone_Number = "Insurance Co Contact Phone Number";
        public static readonly string IN2_Policy_Scope = "Policy Scope";
        public static readonly string IN2_Policy_Source = "Policy Source";
        public static readonly string IN2_Patient_Member_Number = "Patient Member Number";
        public static readonly string IN2_Guarantors_Relationship_to_Insured = "Guarantors Relationship to Insured";
        public static readonly string IN2_Insureds_Phone_Number_Home = "Insureds Phone Number Home";
        public static readonly string IN2_Insureds_Employer_Phone_Number = "Insureds Employer Phone Number";
        public static readonly string IN2_Military_Handicapped_Program = "Military Handicapped Program";
        public static readonly string IN2_Suspend_Flag = "Suspend Flag";
        public static readonly string IN2_Copay_Limit_Flag = "Copay Limit Flag";
        public static readonly string IN2_Stoploss_Limit_Flag = "Stoploss Limit Flag";
        public static readonly string IN2_Insured_Organization_Name_and_ID = "Insured Organization Name and ID";
        public static readonly string IN2_Insured_Employer_Organization_Name_and_ID = "Insured Employer Organization Name and ID";
        public static readonly string IN2_Race = "Race";
        public static readonly string IN2_Patients_Relationship_to_Insured = "Patients Relationship to Insured";

        #endregion "IN2"

        #region "IN3"

        public static readonly string IN3_Set_ID = "Set ID";
        public static readonly string IN3_Certification_Number = "Certification Number";
        public static readonly string IN3_Certified_By = "Certified By";
        public static readonly string IN3_Certification_Required = "Certification Required";
        public static readonly string IN3_Penalty = "Penalty";
        public static readonly string IN3_Certification_Date_Time = "Certification Date Time";
        public static readonly string IN3_Certification_Modify_Date_Time = "Certification Modify Date Time";
        public static readonly string IN3_Operator = "Operator";
        public static readonly string IN3_Certification_Begin_Date = "Certification Begin Date";
        public static readonly string IN3_Certification_End_Date = "Certification End Date";
        public static readonly string IN3_Days = "Days";
        public static readonly string IN3_Non_Concur_Code_Description = "Non Concur Code Description";
        public static readonly string IN3_Non_Concur_Effective_Date_Time = "Non Concur Effective Date Time";
        public static readonly string IN3_Physician_Reviewer = "Physician Reviewer";
        public static readonly string IN3_Certification_Contact = "Certification Contact";
        public static readonly string IN3_Certification_Contact_Phone_Number = "Certification Contact Phone Number";
        public static readonly string IN3_Appeal_Reason = "Appeal Reason";
        public static readonly string IN3_Certification_Agency = "Certification Agency";
        public static readonly string IN3_Certification_Agency_Phone_Number = "Certification Agency Phone Number";
        public static readonly string IN3_Pre_Certification_Requirement = "Pre Certification Requirement";
        public static readonly string IN3_Case_Manager = "Case Manager";
        public static readonly string IN3_Second_Opinion_Date = "Second Opinion Date";
        public static readonly string IN3_Second_Opinion_Status = "Second Opinion Status";
        public static readonly string IN3_Second_Opinion_Documentation_Received = "Second Opinion Documentation Received";
        public static readonly string IN3_Second_Opinion_Physician = "Second Opinion Physician";
        public static readonly string IN3_Certification_Type = "Certification Type";
        public static readonly string IN3_Certification_Category = "Certification Category";

        #endregion "IN3"

        #region "ACC"

        public static readonly string ACC_Accident_Date_Time = "Accident Date Time";
        public static readonly string ACC_Accident_Code = "Accident Code";
        public static readonly string ACC_Accident_Location = "Accident Location";
        public static readonly string ACC_Auto_Accident_State = "Auto Accident State";
        public static readonly string ACC_Accident_Job_Related_Indicator = "Accident Job Related Indicator";
        public static readonly string ACC_Accident_Death_Indicator = "Accident Death Indicator";
        public static readonly string ACC_Entered_By = "Entered By";
        public static readonly string ACC_Accident_Description = "Accident Description";
        public static readonly string ACC_Brought_In_By = "Brought In By";
        public static readonly string ACC_Police_Notified_Indicator = "Police Notified Indicator";
        public static readonly string ACC_Accident_Address = "Accident Address";
        public static readonly string ACC_Degree_of_Patient_Liability = "Degree of Patient Liability";
        public static readonly string ACC_Accident_Identifier = "Accident Identifier";

        #endregion "ACC"

        #region "AL1"

        public static readonly string AL1_Set_ID = "Set ID";
        public static readonly string AL1_Allergen_Type_Code = "Allergen Type Code";
        public static readonly string AL1_Allergen_Code = "Allergen Code";
        public static readonly string AL1_Allergy_Severity_Code = "Allergy Severity Code";
        public static readonly string AL1_Allergy_Reaction_code = "Allergy Reaction Code";
        public static readonly string AL1_Identification_Date = "Identification Date";

        #endregion "AL1"

        #region "FT1"

        public static readonly string FT1_Set_ID = "Set ID";
        public static readonly string FT1_Transaction_ID = "Transaction ID";
        public static readonly string FT1_Transaction_Batch_ID = "Transaction Batch ID";
        public static readonly string FT1_Transaction_Date = "Transaction Date";
        public static readonly string FT1_Transaction_Posting_Date = "Transaction Posting Date";
        public static readonly string FT1_Transaction_Type = "Transaction Type";
        public static readonly string FT1_Transaction_Code = "Transaction Code";
        public static readonly string FT1_Transaction_Description = "Transaction Description";
        public static readonly string FT1_Transaction_Description_Alt = "Transaction Description Alt";
        public static readonly string FT1_Transaction_Quantity = "Transaction Quantity";
        public static readonly string FT1_Transaction_Amount_Extended = "Transaction Amount Extended";
        public static readonly string FT1_Transaction_Amount_Unit = "Transaction Amount Unit";
        public static readonly string FT1_Department_Code = "Department Code";
        public static readonly string FT1_Health_Plan_ID = "Health Plan ID";
        public static readonly string FT1_Insurance_Amount = "Insurance Amount";
        public static readonly string FT1_Assigned_Patient_Location = "Assigned Patient Location";
        public static readonly string FT1_Fee_Schedule = "Fee Schedule";
        public static readonly string FT1_Patient_Type = "Patient Type";
        public static readonly string FT1_Diagnosis_Code = "Diagnosis Code";
        public static readonly string FT1_Performed_By_Code = "Performed By Code";
        public static readonly string FT1_Ordered_By_Code = "Ordered By Code";
        public static readonly string FT1_Unit_Cost = "Unit Cost";
        public static readonly string FT1_Filler_Order_Number = "Filler Order Number";
        public static readonly string FT1_Entered_By_Code = "Entered By Code";
        public static readonly string FT1_Procedure_Code = "Procedure Code";
        public static readonly string FT1_Procedure_Code_Modifier = "Procedure Code Modifier";
        public static readonly string FT1_Advanced_Beneficiary_Notice_Code = "Advanced Beneficiary Notice Code";
        public static readonly string FT1_Medically_Necessary_Duplicate_Procedure_Reason = "Medically Necessary Duplicate Procedure Reason";
        public static readonly string FT1_NDC_Code = "NDC Code";
        public static readonly string FT1_Payment_Reference_ID = "Payment Reference ID";
        public static readonly string FT1_Transaction_Reference_Key = "Transaction Reference Key";
        public static readonly string FT1_Performing_Facility = "Performing Facility";
        public static readonly string FT1_Ordering_Facility = "Ordering Facility";
        public static readonly string FT1_Item_Number = "Item Number";
        public static readonly string FT1_Model_Number = "Model Number";
        public static readonly string FT1_Special_Processing_Code = "Special Processing Code";
        public static readonly string FT1_Clinic_Code = "Clinic Code";
        public static readonly string FT1_Referral_Number = "Referral Number";
        public static readonly string FT1_Authorization_Number = "Authorization Number";
        public static readonly string FT1_Service_Provider_Taxonomy_Code = "Service Provider Taxonomy Code";
        public static readonly string FT1_Revenue_Code = "Revenue Code";
        public static readonly string FT1_Prescription_Number = "Prescription Number";
        public static readonly string FT1_NDC_Qty_and_UOM = "NDC Qty and UOM";

        #endregion "FT1"

        #region "UB1"

        public static readonly string UB1_Set_ID = "Set ID";
        public static readonly string UB1_Blood_Deductible = "Blood Deductible";
        public static readonly string UB1_Blood_Furnished_Pints = "Blood Furnished Pints";
        public static readonly string UB1_Blood_Replaced_Pints = "Blood Replaced Pints";
        public static readonly string UB1_Blood_Not_Replaced_Pints = "Blood Not Replaced Pints";
        public static readonly string UB1_Co_Insurance_Days = "Co-Insurance Days";
        public static readonly string UB1_Condition_Code = "Condition Code";
        public static readonly string UB1_Covered_Days = "Covered Days";
        public static readonly string UB1_Non_Covered_Days = "Non Covered Days";
        public static readonly string UB1_Value_Amount_and_Code = "Value Amount and Code";
        public static readonly string UB1_Number_Of_Grace_Days = "Number Of Grace Days";
        public static readonly string UB1_Special_Program_Indicator = "Special Program Indicator";
        public static readonly string UB1_PSRO_UR_Approval_Indicator = "PSRO UR Approval Indicator";
        public static readonly string UB1_PSRO_UR_Approved_Stay_From = "PSRO UR Approved Stay From ";
        public static readonly string UB1_PSRO_UR_Approved_Stay_To = "PSRO UR Approved Stay To";
        public static readonly string UB1_Occurrence = "Occurrence";
        public static readonly string UB1_Occurrence_Span = "Occurrence Span";
        public static readonly string UB1_Occur_Span_Start_Date = "Occur Span Start Date";
        public static readonly string UB1_Occur_Span_End_Date = "Occur Span End Date";
        public static readonly string UB1_UB_82_Locator_2 = "UB 82 Locator 2";
        public static readonly string UB1_UB_82_Locator_9 = "UB 82 Locator 9";
        public static readonly string UB1_UB_82_Locator_27 = "UB 82 Locator 27";
        public static readonly string UB1_UB_82_Locator_45 = "UB 82 Locator 45";

        #endregion "UB1"

        #region "UB2"

        public static readonly string UB2_Set_ID = "UB2_Set ID";
        public static readonly string UB2_Co_Insurance_Days_9 = "UB2_Co Insurance Days (9)";
        public static readonly string UB2_Condition_Code_24_30 = "UB2_Condition Code (24-30)";
        public static readonly string UB2_Covered_Days_7 = "UB2_Covered Days (7)";
        public static readonly string UB2_Non_Covered_Days_8 = "UB2_Non-Covered Days (8)";
        public static readonly string UB2_Value_Amount_and_Code_39_41_ = "UB2_Value Amount and Code (39-41)";
        public static readonly string UB2_Occurrence_Code_and_Date_32_35 = "UB2_Occurrence Code and Date (32-35)";
        public static readonly string UB2_Occurrence_Span_Code_Dates_36 = "UB2_Occurrence Span Code Dates (36)";
        public static readonly string UB2_Uniform_Billing_Locator_2_State = "UB2_Uniform Billing Locator 2 (state)";
        public static readonly string UB2_Uniform_Billing_Locator_11_State = "UB2_Uniform Billing Locator 11 (state)";
        public static readonly string UB2_Uniform_Billing_Locator_31_National = "UB2_Uniform Billing Locator 31 (national)";
        public static readonly string UB2_Document_Control_Number = "UB2_Document Control Number";
        public static readonly string UB2_Uniform_Billing_Locator_49_National = "UB2_Uniform Billing Locator 49 (national)";
        public static readonly string UB2_Uniform_Billing_Locator_56_State = "UB2_Uniform Billing Locator 56 (state)";
        public static readonly string UB2_Uniform_Billing_Locator_57_National = "UB2_Uniform Billing Locator 57 (sational)";
        public static readonly string UB2_Uniform_Billing_Locator_78_State = "UB2_Uniform Billing Locator 78 (state)";
        public static readonly string UB2_Special_Visit_Count = "UB2_Special Visit Count";

        #endregion "UB2"

        #region "RXR"
        public static readonly string RXR_Route = "Route";
        public static readonly string RXR_Administration_Site = "Administration Site";
        public static readonly string RXR_Administration_Device = "Administration Device";
        public static readonly string RXR_Administration_Method = "Administration Method";
        public static readonly string RXR_Routing_Instruction = "Administration Instruction";
        public static readonly string RXR_Administration_Site_Modifier = "Administration Site Modifier";
        #endregion

        #endregion "Element Names"
    }
}