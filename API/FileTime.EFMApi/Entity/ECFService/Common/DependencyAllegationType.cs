namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:JuvenileCase-4.0")]
    public partial class DependencyAllegationType : ComplexObjectType
    {

        private TextType dependencyAllegationCodeField;

        private TextType dependencyAllegationTextField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public TextType DependencyAllegationCode
        {
            get
            {
                return this.dependencyAllegationCodeField;
            }
            set
            {
                this.dependencyAllegationCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public TextType DependencyAllegationText
        {
            get
            {
                return this.dependencyAllegationTextField;
            }
            set
            {
                this.dependencyAllegationTextField = value;
                
            }
        }
    }
}