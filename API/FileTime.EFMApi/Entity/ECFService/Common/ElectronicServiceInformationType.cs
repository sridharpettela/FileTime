namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CommonTypes-4.0")]
    public partial class ElectronicServiceInformationType : ComplexObjectType
    {

        private IdentificationType serviceRecipientIDField;

        private IdentificationType receivingMDELocationIDField;

        private string receivingMDEProfileCodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public IdentificationType ReceivingMDELocationID
        {
            get
            {
                return this.receivingMDELocationIDField;
            }
            set
            {
                this.receivingMDELocationIDField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString", Order = 2)]
        public string ReceivingMDEProfileCode
        {
            get
            {
                return this.receivingMDEProfileCodeField;
            }
            set
            {
                this.receivingMDEProfileCodeField = value;
                
            }
        }
    }
}