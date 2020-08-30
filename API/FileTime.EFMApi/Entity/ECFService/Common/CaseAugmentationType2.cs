using System.Xml.Serialization;

namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = "CaseAugmentationType", Namespace = "urn:tyler:ecf:extensions:Common")]
    [XmlRoot("CaseAugmentation", Namespace = "urn:tyler:ecf:extensions:Common", IsNullable = false)]
    public partial class CaseAugmentationType2 : CaseAugmentationType1
    {
        private TextType caseTypeTextField;

        private TextType filerTypeTextField;

        private TextType lowerCourtTextField;

        private TextType lowerCourtJudgeTextField;

        private boolean attachServiceContactIndicatorField;

        private ProcedureRemedyType procedureRemedyField;

        private ProviderChargeType providerChargeField;

        private TextType[] propertyAccountNumberField;

        private AmountType3 civilClaimAmountField;

        private AmountType3 probateEstateAmountField;

        private FilingAssociationType[] filingAssociationField;

        private PartyServiceType[] partyServiceField;

        private ExtendedDataType[] itemsField;

        private AmountType maxFeeAmountField;

        private CaseSecurityType caseSecurityField;

        private bool caseSecurityFieldSpecified;

        private TextType caseSubTypeTextField;

        private PhysicalFeatureType1[] physicalFeatureField;

        private DateType returnDateField;

        private HearingScheduleType hearingScheduleField;

        private boolean outOfStateIndicatorField;

        /// <remarks/>
        [XmlElementAttribute(Order = 0)]
        public TextType CaseTypeText
        {
            get
            {
                return this.caseTypeTextField;
            }
            set
            {
                this.caseTypeTextField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 1)]
        public TextType FilerTypeText
        {
            get
            {
                return this.filerTypeTextField;
            }
            set
            {
                this.filerTypeTextField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 2)]
        public TextType LowerCourtText
        {
            get
            {
                return this.lowerCourtTextField;
            }
            set
            {
                this.lowerCourtTextField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 3)]
        public TextType LowerCourtJudgeText
        {
            get
            {
                return this.lowerCourtJudgeTextField;
            }
            set
            {
                this.lowerCourtJudgeTextField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 4)]
        public boolean AttachServiceContactIndicator
        {
            get
            {
                return this.attachServiceContactIndicatorField;
            }
            set
            {
                this.attachServiceContactIndicatorField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 5)]
        public ProcedureRemedyType ProcedureRemedy
        {
            get
            {
                return this.procedureRemedyField;
            }
            set
            {
                this.procedureRemedyField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 6)]
        public ProviderChargeType ProviderCharge
        {
            get
            {
                return this.providerChargeField;
            }
            set
            {
                this.providerChargeField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute("PropertyAccountNumber", Order = 7)]
        public TextType[] PropertyAccountNumber
        {
            get
            {
                return this.propertyAccountNumberField;
            }
            set
            {
                this.propertyAccountNumberField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 8)]
        public AmountType3 CivilClaimAmount
        {
            get
            {
                return this.civilClaimAmountField;
            }
            set
            {
                this.civilClaimAmountField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 9)]
        public AmountType3 ProbateEstateAmount
        {
            get
            {
                return this.probateEstateAmountField;
            }
            set
            {
                this.probateEstateAmountField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute("FilingAssociation", Order = 10)]
        public FilingAssociationType[] FilingAssociation
        {
            get
            {
                return this.filingAssociationField;
            }
            set
            {
                this.filingAssociationField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute("PartyService", Order = 11)]
        public PartyServiceType[] PartyService
        {
            get
            {
                return this.partyServiceField;
            }
            set
            {
                this.partyServiceField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute("CaseEvent", typeof(CaseEventType), Order = 12)]
        [XmlElementAttribute("ExtendedData", typeof(ExtendedDataType), Order = 12)]
        public ExtendedDataType[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 13)]
        public AmountType MaxFeeAmount
        {
            get
            {
                return this.maxFeeAmountField;
            }
            set
            {
                this.maxFeeAmountField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 14)]
        public CaseSecurityType CaseSecurity
        {
            get
            {
                return this.caseSecurityField;
            }
            set
            {
                this.caseSecurityField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool CaseSecuritySpecified
        {
            get
            {
                return this.caseSecurityFieldSpecified;
            }
            set
            {
                this.caseSecurityFieldSpecified = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 15)]
        public TextType CaseSubTypeText
        {
            get
            {
                return this.caseSubTypeTextField;
            }
            set
            {
                this.caseSubTypeTextField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute("PhysicalFeature", Order = 16)]
        public PhysicalFeatureType1[] PhysicalFeature
        {
            get
            {
                return this.physicalFeatureField;
            }
            set
            {
                this.physicalFeatureField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 17)]
        public DateType ReturnDate
        {
            get
            {
                return this.returnDateField;
            }
            set
            {
                this.returnDateField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 18)]
        public HearingScheduleType HearingSchedule
        {
            get
            {
                return this.hearingScheduleField;
            }
            set
            {
                this.hearingScheduleField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 19)]
        public boolean OutOfStateIndicator
        {
            get
            {
                return this.outOfStateIndicatorField;
            }
            set
            {
                this.outOfStateIndicatorField = value;
            }
        }

    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:tyler:ecf:extensions:Common")]
    public partial class PartyServiceType
    {

        private ReferenceType partyReferenceField;

        private IdentificationType[] itemOtherIdentificationField;

        /// <remarks/>
        [XmlElementAttribute(Order = 0)]
        public ReferenceType PartyReference
        {
            get
            {
                return this.partyReferenceField;
            }
            set
            {
                this.partyReferenceField = value;

            }
        }

        /// <remarks/>
        [XmlElementAttribute("ItemOtherIdentification", Namespace = "http://niem.gov/niem/niem-core/2.0", Order = 1)]
        public IdentificationType[] ItemOtherIdentification
        {
            get
            {
                return this.itemOtherIdentificationField;
            }
            set
            {
                this.itemOtherIdentificationField = value;

            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:tyler:ecf:extensions:Common")]
    public partial class CaseEventType : ExtendedDataType
    {

        private DocumentType1[] filingEventField;

        private DocumentAttachmentIdentificationType[] documentAttachmentIdentificationField;

        /// <remarks/>
        [XmlElementAttribute("FilingEvent", Order = 0)]
        public DocumentType1[] FilingEvent
        {
            get
            {
                return this.filingEventField;
            }
            set
            {
                this.filingEventField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute("DocumentAttachmentIdentification", Order = 1)]
        public DocumentAttachmentIdentificationType[] DocumentAttachmentIdentification
        {
            get
            {
                return this.documentAttachmentIdentificationField;
            }
            set
            {
                this.documentAttachmentIdentificationField = value;
            }
        }
    }

    /// <remarks/>
    [XmlIncludeAttribute(typeof(CaseEventType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:tyler:ecf:extensions:Common")]
    public class ExtendedDataType : object
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "urn:tyler:ecf:extensions:Common")]
    public enum CaseSecurityType
    {

        /// <remarks/>
        PublicFilingPrivateView,

        /// <remarks/>
        PublicFilingPublicView,

        /// <remarks/>
        PrivateFilingPrivateView,

        /// <remarks/>
        PrivateFilingPublicView,

        /// <remarks/>
        Sealed,

        /// <remarks/>
        Expunged,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName = "PhysicalFeatureType", Namespace = "urn:tyler:ecf:extensions:Common")]
    public partial class PhysicalFeatureType1 : object
    {

        private TextType physicalFeatureDescriptionTextField;

        private ReferenceType physicalFeatureReferenceField;

        /// <remarks/>
        [XmlElementAttribute(Order = 0)]
        public TextType PhysicalFeatureDescriptionText
        {
            get
            {
                return this.physicalFeatureDescriptionTextField;
            }
            set
            {
                this.physicalFeatureDescriptionTextField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 1)]
        public ReferenceType PhysicalFeatureReference
        {
            get
            {
                return this.physicalFeatureReferenceField;
            }
            set
            {
                this.physicalFeatureReferenceField = value;
            }
        }

      
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:tyler:ecf:extensions:Common")]
    public partial class HearingScheduleType : object
    {

        private DateType scheduleDayStartTimeField;

        private DateType scheduleDayEndTimeField;

        private TextType courtRoomField;

        private TextType courtStreetField;

        private TextType courtCityStateZipField;

        /// <remarks/>
        [XmlElementAttribute(Order = 0)]
        public DateType ScheduleDayStartTime
        {
            get
            {
                return this.scheduleDayStartTimeField;
            }
            set
            {
                this.scheduleDayStartTimeField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 1)]
        public DateType ScheduleDayEndTime
        {
            get
            {
                return this.scheduleDayEndTimeField;
            }
            set
            {
                this.scheduleDayEndTimeField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 2)]
        public TextType CourtRoom
        {
            get
            {
                return this.courtRoomField;
            }
            set
            {
                this.courtRoomField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 3)]
        public TextType CourtStreet
        {
            get
            {
                return this.courtStreetField;
            }
            set
            {
                this.courtStreetField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 4)]
        public TextType CourtCityStateZip
        {
            get
            {
                return this.courtCityStateZipField;
            }
            set
            {
                this.courtCityStateZipField = value;
            }
        }
    }

}