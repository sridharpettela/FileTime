namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServicesProfile-Definitions-4.0")]
    public partial class RecordFilingRequestMessageType : ElectronicFilingMessageType
    {

        private RecordDocketingMessageType recordDocketingMessageField;

        private CoreFilingMessageType coreFilingMessageField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:RecordDocketingMessage-4.0", Order = 0)]
        public RecordDocketingMessageType RecordDocketingMessage
        {
            get
            {
                return this.recordDocketingMessageField;
            }
            set
            {
                this.recordDocketingMessageField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CoreFilingMessage-4.0", Order = 1)]
        public CoreFilingMessageType CoreFilingMessage
        {
            get
            {
                return this.coreFilingMessageField;
            }
            set
            {
                this.coreFilingMessageField = value;
                
            }
        }
    }
}