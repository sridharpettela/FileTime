namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:ServiceReceiptMessage-4.0")]
    public partial class ServiceRecipientStatusType : StatusType
    {

        private IdentificationType serviceRecipientIDField;

        private string serviceStatusCodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CommonTypes-4.0", Order = 0)]
        public IdentificationType ServiceRecipientID
        {
            get
            {
                return this.serviceRecipientIDField;
            }
            set
            {
                this.serviceRecipientIDField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString", Order = 1)]
        public string ServiceStatusCode
        {
            get
            {
                return this.serviceStatusCodeField;
            }
            set
            {
                this.serviceStatusCodeField = value;
                
            }
        }
    }
}