namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:tyler:ecf:extensions:FilingDetailResponseMessage")]
    public partial class ServiceRecipientDetailType : StatusType
    {

        private IdentificationType serviceRecipientIDField;

        private string statusCodeField;

        private EntityType servedRecipientField;

        private TextType firmNameField;

        private bool isOpenedField;

        private DateType servedDateField;

        private DateType openedDateField;

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
        public string StatusCode
        {
            get
            {
                return this.statusCodeField;
            }
            set
            {
                this.statusCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public EntityType ServedRecipient
        {
            get
            {
                return this.servedRecipientField;
            }
            set
            {
                this.servedRecipientField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:tyler:ecf:extensions:Common", Order = 3)]
        public TextType FirmName
        {
            get
            {
                return this.firmNameField;
            }
            set
            {
                this.firmNameField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public bool IsOpened
        {
            get
            {
                return this.isOpenedField;
            }
            set
            {
                this.isOpenedField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public DateType ServedDate
        {
            get
            {
                return this.servedDateField;
            }
            set
            {
                this.servedDateField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public DateType OpenedDate
        {
            get
            {
                return this.openedDateField;
            }
            set
            {
                this.openedDateField = value;
                
            }
        }
    }
}