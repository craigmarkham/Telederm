//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BOL
{
    using System;
    using System.Collections.Generic;
    
    public partial class SPatient
    {
        public int PatientSID { get; set; }
        public string PatientIEN { get; set; }
        public short Sta3n { get; set; }
        public string PatientName { get; set; }
        public string PatientLastName { get; set; }
        public string PatientFirstName { get; set; }
        public string PatientSSN { get; set; }
        public string ScrSSN { get; set; }
        public string StreetAddress1 { get; set; }
        public string StreetAddress2 { get; set; }
        public string StreetAddress3 { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public string Zip4 { get; set; }
        public string PostalCode { get; set; }
        public string Province { get; set; }
        public Nullable<int> CountrySID { get; set; }
        public string Country { get; set; }
        public string PhoneResidence { get; set; }
        public string PhoneWork { get; set; }
        public string PhoneCellular { get; set; }
        public string MothersMaidenName { get; set; }
        public Nullable<System.DateTime> DateOfDeath { get; set; }
        public string DateOfDeathText { get; set; }
        public string EmailAddress { get; set; }
        public string BadAddressIndicator { get; set; }
        public string ExcludeFromFacilityDirectoryFlag { get; set; }
        public Nullable<int> AddressChangeInstitutionSID { get; set; }
        public Nullable<int> AddressChangeStaffSID { get; set; }
        public Nullable<System.DateTime> NOKPrimaryChangeDateTime { get; set; }
        public string NOKPrimaryChangeVistaErrorDate { get; set; }
        public Nullable<long> NOKPrimaryChangeDateTimeTransformSID { get; set; }
        public Nullable<System.DateTime> NOKSecondaryChangeDateTime { get; set; }
        public string NOKSecondaryChangeVistaErrorDate { get; set; }
        public Nullable<long> NOKSecondaryChangeDateTimeTransformSID { get; set; }
        public string NOKRelationshipToPatient { get; set; }
        public string NOKDesigneeSameAsFlag { get; set; }
        public string NOKEmergencyContactSameAsFlag { get; set; }
        public string TemporaryAddressActiveFlag { get; set; }
        public Nullable<System.DateTime> TemporaryAddressLastEditedDateTime { get; set; }
        public string TemporaryAddressLastEditedVistaErrorDate { get; set; }
        public Nullable<long> TemporaryAddressLastEditedDateTimeTransformSID { get; set; }
        public Nullable<int> TemporaryAddressChangeInstitutionSID { get; set; }
        public Nullable<System.DateTime> TemporaryAddressStartDate { get; set; }
        public string TemporaryAddressStartVistaErrorDate { get; set; }
        public Nullable<long> TemporaryAddressStartDateTransformSID { get; set; }
        public Nullable<System.DateTime> TemporaryAddressEndDate { get; set; }
        public string TemporaryAddressEndVistaErrorDate { get; set; }
        public Nullable<long> TemporaryAddressEndDateTransformSID { get; set; }
        public string ConfidentialAddressActiveFlag { get; set; }
        public string CDFlag { get; set; }
        public string CDDecidedByName { get; set; }
        public Nullable<System.DateTime> CDDecisionDate { get; set; }
        public string CDDecisionVistaErrorDate { get; set; }
        public Nullable<long> CDDecisionDateTransformSID { get; set; }
        public Nullable<System.DateTime> CDReviewedDate { get; set; }
        public string CDReviewedVistaErrorDate { get; set; }
        public Nullable<long> CDReviewedDateTransformSID { get; set; }
        public Nullable<int> CDDeterminingInstitutionSID { get; set; }
        public string CDDeterminationType { get; set; }
        public string CurrentPurpleHeartDecisionType { get; set; }
        public string CurrentPurpleHeartStatus { get; set; }
        public Nullable<int> PurpleHeartInstitutionSID { get; set; }
        public string MedicaidNumber { get; set; }
        public Nullable<int> RaceSID { get; set; }
        public string Gender { get; set; }
        public Nullable<decimal> Age { get; set; }
        public Nullable<int> StateSID { get; set; }
        public string State { get; set; }
        public string County { get; set; }
        public string Deceased { get; set; }
        public string PatientICN { get; set; }
        public string PatientICNChecksum { get; set; }
        public string PseudoSSNFlag { get; set; }
        public Nullable<int> PeriodOfServiceSID { get; set; }
        public string PeriodOfService { get; set; }
        public Nullable<int> CurrentMeansTestStatusSID { get; set; }
        public Nullable<int> MaritalStatusSID { get; set; }
        public string MaritalStatus { get; set; }
        public Nullable<int> PercentServiceConnect { get; set; }
        public string InsuranceCoverageFlag { get; set; }
        public Nullable<int> ReligionSID { get; set; }
        public string Religion { get; set; }
        public string AgentOrangeExposureFlag { get; set; }
        public string AgentOrangeLocationCode { get; set; }
        public string RadiationExposureCode { get; set; }
        public string IonizingRadiationExposureFlag { get; set; }
        public string SHADFlag { get; set; }
        public string VeteranFlag { get; set; }
        public string CombatFlag { get; set; }
        public Nullable<System.DateTime> CombatEligibilityEndDate { get; set; }
        public string CombatEligibilityEndVistaErrorDate { get; set; }
        public Nullable<long> CombatEligibilityEndDateTransformSID { get; set; }
        public string TestPatientFlag { get; set; }
        public string CDWPossibleTestPatientFlag { get; set; }
        public string SpinalCordInjuryType { get; set; }
        public Nullable<System.DateTime> EnteredIntoFileDate { get; set; }
        public string EnteredIntoFileVistaErrorDate { get; set; }
        public Nullable<long> EnteredIntoFileDateTransformSID { get; set; }
        public string EmergencyResponseIndicator { get; set; }
        public Nullable<int> EligibilitySID { get; set; }
        public string Eligibility { get; set; }
        public Nullable<decimal> EligibilityVACode { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public string DateOfBirthText { get; set; }
        public string SensitiveFlag { get; set; }
        public Nullable<System.DateTime> LastServiceEntryDate { get; set; }
        public string LastServiceEntryVistaErrorDate { get; set; }
        public Nullable<long> LastServiceEntryDateTransformSID { get; set; }
        public Nullable<System.DateTime> LastServiceSeparationDate { get; set; }
        public string LastServiceSeparationVistaErrorDate { get; set; }
        public Nullable<long> LastServiceSeparationDateTransformSID { get; set; }
        public Nullable<int> PreferredInstitutionSID { get; set; }
        public string POWFlag { get; set; }
        public Nullable<int> POWLocationSID { get; set; }
        public string POWFromVistaDate { get; set; }
        public string POWToVistaDate { get; set; }
        public string CombatFromVistaDate { get; set; }
        public string CombatToVistaDate { get; set; }
        public string ClaimNumber { get; set; }
        public Nullable<int> RoomBedSID { get; set; }
        public Nullable<System.DateTime> IneligibleDate { get; set; }
        public string IneligibleVistaErrorDate { get; set; }
        public Nullable<long> IneligibleDateTransformSID { get; set; }
        public string IneligibleReason { get; set; }
        public string EligibilityStatus { get; set; }
        public string EligibilityVerificationSource { get; set; }
        public string GISLocatorName { get; set; }
        public string GISMatchStatusCode { get; set; }
        public Nullable<int> GISMatchScore { get; set; }
        public string GISMatchMethodCode { get; set; }
        public string GISMatchedAddress { get; set; }
        public string GISAddressType { get; set; }
        public string GISStreetSide { get; set; }
        public Nullable<double> GISPatientAddressLongitude { get; set; }
        public Nullable<double> GISPatientAddressLatitude { get; set; }
        public Nullable<System.DateTime> GISAddressUpdatedDate { get; set; }
        public string GISFIPSCode { get; set; }
        public string GISMarket { get; set; }
        public string GISSubmarket { get; set; }
        public string GISSector { get; set; }
        public string GISURH { get; set; }
        public string GISCongressDistrict { get; set; }
    
        public virtual Telederm_Patient Telederm_Patient { get; set; }
    }
}
