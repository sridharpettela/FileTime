using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ItemRegistrationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(QueryResponseMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FilingServiceResponseMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CancelFilingResponseMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FilingDetailResponseMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ServiceAttachCaseListResponseMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ServiceInformationHistoryResponseMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ServiceInformationResponseMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FilingStatusResponseMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FilingListResponseMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DocumentResponseMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CaseResponseMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CaseListResponseMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FeesCalculationResponseMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CourtPolicyResponseMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(QueryMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SecureCaseMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FilingServiceQueryMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CancelFilingMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FilingDetailQueryMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ServiceAttachCaseListQueryMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ServiceInformationHistoryQueryMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ServiceInformationQueryMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FilingStatusQueryMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FilingListQueryMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FeesCalculationQueryMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DocumentQueryMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CaseQueryMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CaseListQueryMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CourtPolicyQueryMessageType1))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VictimType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RuntimePolicyParametersType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PublicKeyInformationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DevelopmentPolicyParametersType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CourtExtensionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CourtCodelistType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CaseQueryCriteriaType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CourtEventOnBehalfOfActorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CourtEventActorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ErrorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SignatureType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DocumentSignatureType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DependencyAllegationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DecedentEstateCaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FiduciaryCaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ItemValueType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TangibleItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConveyanceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VehicleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VehicleType1))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CourtAppearanceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RegisteredOffenderType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BiometricType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FacilityType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SupervisionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SubjectType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SubjectType2))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(JuvenileType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SubjectType3))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SubjectType1))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EnforcementOfficialType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CitationCaseAugmentationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AppellateCourtRuleCaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AppellateCivilCaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AppellateCaseRemovedPartyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AppellateCaseAddedPartyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ObligationExemptionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ObligationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FinancialObligationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ObligationRecurrenceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DomesticCaseObligationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DomesticCaseChildSupportPetitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DomesticCaseViolencePetitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RelatedActivityAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RelatedCaseAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PersonOrganizationAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PersonOrganizationAssociationType1))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PersonEmploymentAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PersonContactInformationAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PersonAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PersonUnionAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MarriageAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PersonFiduciaryAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PersonAssociationType1))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OrganizationContactInformationAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OrganizationAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OrganizationAssociationType1))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ImmediateFamilyAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GuardianAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GuardianAssociationType1))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DriverLicenseAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ActivityConveyanceAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PlacementAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FilingAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ViolatedStatuteAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PersonChargeAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DocumentCourtAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ActivityLocationAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ElectronicServiceInformationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InsuranceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InsuranceType1))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DrivingRestrictionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DriverLicenseBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DriverLicenseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PersonLanguageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PhysicalFeatureType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PersonNameType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FingerprintType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FingerprintType1))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FingerprintSetType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DNALocusType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DNAType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CapabilityType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PersonType1))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PersonType2))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PersonFilerType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NANPTelephoneNumberType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InternationalTelephoneNumberType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FullTelephoneNumberType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TelephoneNumberType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ContactInformationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AliasType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CaseAugmentationType1))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CaseAugmentationType2))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BinaryType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ImageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DocumentAttachmentType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DocumentType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DocumentRenditionMetadataType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DocumentRenditionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DocumentType1))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ReviewedDocumentType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ReviewedDocumentType1))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CourtEventDocumentType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExtendedDocumentType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CaseFilingType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ElectronicFilingMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CreateCaseMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ReviewFilingRequestMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RecordDocketingMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RecordFilingRequestMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NotifyFilingReviewCompleteRequestMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CoreFilingMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ElectronicFilingCallbackMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ReviewFilingCallbackMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RecordDocketingCallbackMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MessageReceiptMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ServiceReceiptMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CourtPolicyQueryMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ServiceCallbackMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AppellateCaseNoticeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MatchingFilingType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ScheduleDayType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(JudicialOfficialBarMembershipType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(JudicialOfficialType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CaseOfficialType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CaseOfficialType1))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MeasureType3))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeightMeasureType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SpeedMeasureType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LengthMeasureType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StreetType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StructuredAddressType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AddressType1))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LocationType2))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(JurisdictionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StatuteType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SeverityLevelType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ChargeType1))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ChargeType2))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ChargeType3))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CaseDispositionDecisionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DispositionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CaseDispositionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ChargeDispositionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StatusType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MarriageStatusType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FilingStatusType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ServiceRecipientDetailType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ServiceRecipientStatusType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DateRangeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ActivityType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BookingType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CitationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TermType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SentenceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SentenceType1))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CourtOrderType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WarrantType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DomesticCaseOrderType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DriverLicenseWithdrawalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BankruptcyCaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(JuvenileCaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CivilCaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CitationCaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CriminalCaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AppellateCaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AppellateCaseType1))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DomesticCaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CourtEventType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CourtEventType1))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IncidentType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StatusOffenseActType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DelinquentActType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ParkingViolationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DrivingIncidentType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DrivingIncidentType1))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ArrestType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IdentificationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ServiceContactIdentificationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OrganizationIdentificationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DocumentOptionalServiceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OrganizationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OrganizationType1))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EnforcementUnitType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CourtType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ServiceRecipientType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CaseParticipantType1))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CaseAbstractorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CaseParticipantType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://niem.gov/niem/structures/2.0")]
    public abstract partial class ComplexObjectType
    {

        private string idField;

        private string metadataField;

        private string linkMetadataField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "ID")]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;

            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "IDREFS")]
        public string metadata
        {
            get
            {
                return this.metadataField;
            }
            set
            {
                this.metadataField = value;

            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "IDREFS")]
        public string linkMetadata
        {
            get
            {
                return this.linkMetadataField;
            }
            set
            {
                this.linkMetadataField = value;

            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:tyler:ecf:extensions:SecureCaseMessage")]
    public partial class SecureCaseMessageType : QueryMessageType
    {

        private IdentificationType documentIdentificationField;

        private bool isSecuredField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0", Order = 0)]
        public IdentificationType DocumentIdentification
        {
            get
            {
                return this.documentIdentificationField;
            }
            set
            {
                this.documentIdentificationField = value;

            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public bool IsSecured
        {
            get
            {
                return this.isSecuredField;
            }
            set
            {
                this.isSecuredField = value;

            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CommonTypes-4.0")]
    public partial class CourtEventOnBehalfOfActorType : ComplexObjectType
    {

        private ReferenceType itemField;

        private ItemChoiceType1 itemElementNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RoleOfItemReference", typeof(ReferenceType), Namespace = "http://niem.gov/niem/niem-core/2.0", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("RoleOfOrganizationReference", typeof(ReferenceType), Namespace = "http://niem.gov/niem/niem-core/2.0", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("RoleOfPersonReference", typeof(ReferenceType), Namespace = "http://niem.gov/niem/niem-core/2.0", Order = 0)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public ReferenceType Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;

            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType1 ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;

            }
        }
    }
}
