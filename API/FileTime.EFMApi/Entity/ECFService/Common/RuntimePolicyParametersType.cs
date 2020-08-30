namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CourtPolicyResponseMessage-4.0" +
                                                           "")]
    public partial class RuntimePolicyParametersType : ComplexObjectType
    {

        private PublicKeyInformationType publicKeyInformationField;

        private CourtCodelistType[] courtCodelistField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public PublicKeyInformationType PublicKeyInformation
        {
            get
            {
                return this.publicKeyInformationField;
            }
            set
            {
                this.publicKeyInformationField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CourtCodelist", Order = 1)]
        public CourtCodelistType[] CourtCodelist
        {
            get
            {
                return this.courtCodelistField;
            }
            set
            {
                this.courtCodelistField = value;
                
            }
        }
    }
}