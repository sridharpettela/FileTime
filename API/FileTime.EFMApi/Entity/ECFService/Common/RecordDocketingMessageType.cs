namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:RecordDocketingMessage-4.0")]
    public partial class RecordDocketingMessageType : ElectronicFilingMessageType
    {

        private CourtType caseCourtField;

        private @string caseTrackingIDField;

        private ReviewedDocumentType reviewedLeadDocumentField;

        private ReviewedDocumentType[] reviewedConnectedDocumentField;

        private boolean sealCaseIndicatorField;

        private TextType filingReviewCommentsTextField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://niem.gov/niem/domains/jxdm/4.0",  Order = 0)]
        public CourtType CaseCourt
        {
            get
            {
                return this.caseCourtField;
            }
            set
            {
                this.caseCourtField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0",  Order = 1)]
        public @string CaseTrackingID
        {
            get
            {
                return this.caseTrackingIDField;
            }
            set
            {
                this.caseTrackingIDField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CommonTypes-4.0", Order = 2)]
        public ReviewedDocumentType ReviewedLeadDocument
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
        [System.Xml.Serialization.XmlElementAttribute("ReviewedConnectedDocument", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CommonTypes-4.0", Order = 3)]
        public ReviewedDocumentType[] ReviewedConnectedDocument
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

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public boolean SealCaseIndicator
        {
            get
            {
                return this.sealCaseIndicatorField;
            }
            set
            {
                this.sealCaseIndicatorField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public TextType FilingReviewCommentsText
        {
            get
            {
                return this.filingReviewCommentsTextField;
            }
            set
            {
                this.filingReviewCommentsTextField = value;
                
            }
        }
    }
}