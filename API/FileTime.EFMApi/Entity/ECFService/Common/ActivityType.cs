namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BookingType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CourtOrderType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DomesticCaseOrderType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WarrantType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CitationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TermType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SentenceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SentenceType1))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DomesticCaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BankruptcyCaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CitationCaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AppellateCaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AppellateCaseType1))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CivilCaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(JuvenileCaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CriminalCaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CourtEventType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CourtEventType1))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DriverLicenseWithdrawalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IncidentType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ParkingViolationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DrivingIncidentType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DrivingIncidentType1))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StatusOffenseActType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DelinquentActType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ArrestType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public partial class ActivityType : ComplexObjectType
    {

        private IdentificationType[] activityIdentificationField;

        private ComplexObjectType itemField;

        private TextType activityDescriptionTextField;

        private StatusType activityStatusField;

        private DispositionType[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ActivityIdentification",  Order = 0)]
        public IdentificationType[] ActivityIdentification
        {
            get
            {
                return this.activityIdentificationField;
            }
            set
            {
                this.activityIdentificationField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ActivityDate", typeof(DateType),  Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("ActivityDateRange", typeof(DateRangeType),  Order = 1)]
        public ComplexObjectType Item
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
        [System.Xml.Serialization.XmlElementAttribute( Order = 2)]
        public TextType ActivityDescriptionText
        {
            get
            {
                return this.activityDescriptionTextField;
            }
            set
            {
                this.activityDescriptionTextField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 3)]
        public StatusType ActivityStatus
        {
            get
            {
                return this.activityStatusField;
            }
            set
            {
                this.activityStatusField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ActivityDisposition", typeof(DispositionType),  Order = 4)]
        [System.Xml.Serialization.XmlElementAttribute("CaseDisposition", typeof(CaseDispositionType),  Order = 4)]
        public DispositionType[] Items
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
    }
}