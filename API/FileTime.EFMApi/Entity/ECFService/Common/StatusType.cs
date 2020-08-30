namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MarriageStatusType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FilingStatusType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ServiceRecipientDetailType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ServiceRecipientStatusType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public partial class StatusType : ComplexObjectType
    {

        private TextType statusTextField;

        private DateType statusDateField;

        private TextType[] statusDescriptionTextField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 0)]
        public TextType StatusText
        {
            get
            {
                return this.statusTextField;
            }
            set
            {
                this.statusTextField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 1)]
        public DateType StatusDate
        {
            get
            {
                return this.statusDateField;
            }
            set
            {
                this.statusDateField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("StatusDescriptionText",  Order = 2)]
        public TextType[] StatusDescriptionText
        {
            get
            {
                return this.statusDescriptionTextField;
            }
            set
            {
                this.statusDescriptionTextField = value;
                
            }
        }
    }
}