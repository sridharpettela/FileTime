namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://niem.gov/niem/domains/jxdm/4.0")]
    public partial class SeverityLevelType : ComplexObjectType
    {

        private TextType severityLevelDescriptionTextField;

        private IdentificationType severityLevelIdentificationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 0)]
        public TextType SeverityLevelDescriptionText
        {
            get
            {
                return this.severityLevelDescriptionTextField;
            }
            set
            {
                this.severityLevelDescriptionTextField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 1)]
        public IdentificationType SeverityLevelIdentification
        {
            get
            {
                return this.severityLevelIdentificationField;
            }
            set
            {
                this.severityLevelIdentificationField = value;
                
            }
        }
    }
}