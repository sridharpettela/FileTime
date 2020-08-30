namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CaseDispositionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ChargeDispositionType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public partial class DispositionType : ComplexObjectType
    {

        private DateType dispositionDateField;

        private TextType dispositionDescriptionTextField;

        private TextType dispositionTextField;

        private TextType dispositionCategoryTextField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 0)]
        public DateType DispositionDate
        {
            get
            {
                return this.dispositionDateField;
            }
            set
            {
                this.dispositionDateField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 1)]
        public TextType DispositionDescriptionText
        {
            get
            {
                return this.dispositionDescriptionTextField;
            }
            set
            {
                this.dispositionDescriptionTextField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 2)]
        public TextType DispositionText
        {
            get
            {
                return this.dispositionTextField;
            }
            set
            {
                this.dispositionTextField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 3)]
        public TextType DispositionCategoryText
        {
            get
            {
                return this.dispositionCategoryTextField;
            }
            set
            {
                this.dispositionCategoryTextField = value;
                
            }
        }
    }
}