namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    //[System.SerializableAttribute()]
    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.ComponentModel.DesignerCategoryAttribute("code")]
    //[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:ReviewFilingCallbackMessage-4." +
    //    "0")]
    //public partial class ReviewFilingCallbackMessageType : ElectronicFilingCallbackMessageType
    //{
    //    public ReviewFilingCallbackMessageType()
    //    {
    //        RejectReason = new TextType();
    //        ReviewComments = new TextType();
    //    }

    //    [XmlElement(Order = 0, ElementName = "ReviewComments")]
    //    public TextType ReviewComments { get; set; }

    //    [XmlElement(Order = 1, ElementName = "RejectReason")]
    //    public TextType RejectReason { get; set; }
    //}

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ReviewFilingCallbackMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RecordDocketingCallbackMessageType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CommonTypes-4.0")]
    public abstract partial class ElectronicFilingCallbackMessageType : CaseFilingType
    {

        private CaseType caseField;

        private DateType filingCompletionDateField;

        private FilingStatusType filingStatusField;

        private ReviewedDocumentType1 reviewedLeadDocumentField;

        private ReviewedDocumentType1[] reviewedConnectedDocumentField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0",  Order = 0)]
        [System.Xml.Serialization.XmlElement("CivilCase", typeof(CivilCaseType),
            Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CivilCase-4.0",  Order = 0)]
        [System.Xml.Serialization.XmlElement("DomesticCase", typeof(DomesticCaseType),
            Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:DomesticCase-4.0",  Order = 0)]
        [System.Xml.Serialization.XmlElement("BankruptcyCase", typeof(BankruptcyCaseType),
            Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:BankruptcyCase-4.0",  Order = 0)]
        [System.Xml.Serialization.XmlElement("CitationCase", typeof(CitationCaseType),
            Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CitationCase-4.0",  Order = 0)]
        [System.Xml.Serialization.XmlElement("AppellateCase", typeof(AppellateCaseType),
            Namespace = "http://niem.gov/niem/domains/jxdm/4.0",  Order = 0)]
        [System.Xml.Serialization.XmlElement("AppellateCase", typeof(AppellateCaseType1),
            Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:AppellateCase-4.0",  Order = 0)]
        [System.Xml.Serialization.XmlElement("JuvenileCase", typeof(JuvenileCaseType),
            Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:JuvenileCase-4.0",  Order = 0)]
        [System.Xml.Serialization.XmlElement("CriminalCase", typeof(CriminalCaseType),
            Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CriminalCase-4.0",  Order = 0)]
        [System.Xml.Serialization.XmlElement("CourtCase", typeof(CourtCaseType),
            Namespace = "urn:tyler:ecf:extensions:CourtCase",  Order = 0)]
        public CaseType Case
        {
            get
            {
                return this.caseField;
            }
            set
            {
                this.caseField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public DateType FilingCompletionDate
        {
            get
            {
                return this.filingCompletionDateField;
            }
            set
            {
                this.filingCompletionDateField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public FilingStatusType FilingStatus
        {
            get
            {
                return this.filingStatusField;
            }
            set
            {
                this.filingStatusField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:tyler:ecf:extensions:Common", Order = 3)]
        public ReviewedDocumentType1 ReviewedLeadDocument
        {
            get
            {
                return this.reviewedLeadDocumentField;
            }
            set
            {
                this.reviewedLeadDocumentField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ReviewedConnectedDocument", Namespace = "urn:tyler:ecf:extensions:Common", Order = 4)]
        public ReviewedDocumentType1[] ReviewedConnectedDocument
        {
            get
            {
                return this.reviewedConnectedDocumentField;
            }
            set
            {
                this.reviewedConnectedDocumentField = value;
                
            }
        }
    }
}