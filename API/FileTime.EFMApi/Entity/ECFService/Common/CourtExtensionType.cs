namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CourtPolicyResponseMessage-4.0" +
                                                           "")]
    public partial class CourtExtensionType : ComplexObjectType
    {

        private TextType eCFElementNameField;

        private IdentificationType courtExtensionURIField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public TextType ECFElementName
        {
            get
            {
                return this.eCFElementNameField;
            }
            set
            {
                this.eCFElementNameField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public IdentificationType CourtExtensionURI
        {
            get
            {
                return this.courtExtensionURIField;
            }
            set
            {
                this.courtExtensionURIField = value;
                
            }
        }
    }
}