namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:AppellateCase-4.0")]
    public partial class AppellateCaseRemovedPartyType : ComplexObjectType
    {

        private TextType appellateCasePartyRemovedReasonTextField;

        private EntityType appellateCasePartyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public TextType AppellateCasePartyRemovedReasonText
        {
            get
            {
                return this.appellateCasePartyRemovedReasonTextField;
            }
            set
            {
                this.appellateCasePartyRemovedReasonTextField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public EntityType AppellateCaseParty
        {
            get
            {
                return this.appellateCasePartyField;
            }
            set
            {
                this.appellateCasePartyField = value;
                
            }
        }
    }
}