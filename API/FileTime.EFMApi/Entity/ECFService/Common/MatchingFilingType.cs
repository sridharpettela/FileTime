namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:FilingListResponseMessage-4.0")]
    public partial class MatchingFilingType : DocumentType
    {

        private @string caseTrackingIDField;

        private FilingStatusType filingStatusField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0",  Order = 0)]
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CommonTypes-4.0", Order = 1)]
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
    }
}