namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "PersonOrganizationAssociationType", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CommonTypes-4.0")]
    public partial class PersonOrganizationAssociationType1 : PersonOrganizationAssociationType
    {

        private TextType entityAssociationTypeCodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public TextType EntityAssociationTypeCode
        {
            get
            {
                return this.entityAssociationTypeCodeField;
            }
            set
            {
                this.entityAssociationTypeCodeField = value;
                
            }
        }
    }
}