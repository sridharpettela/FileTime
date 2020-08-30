namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
   

   

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:DocumentQueryMessage-4.0")]
    public partial class DocumentQueryMessageType : QueryMessageType
    {

        private @string caseTrackingIDField;

        private @string caseDocketIDField;

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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0",  Order = 1)]
        public @string CaseDocketID
        {
            get
            {
                return this.caseDocketIDField;
            }
            set
            {
                this.caseDocketIDField = value;
                
            }
        }
    }
}