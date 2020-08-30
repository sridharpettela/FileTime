namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CivilCase-4.0")]
    public partial class PersonFiduciaryAssociationType : PersonAssociationType
    {

        private TextType personFiduciaryAssociationTypeTextField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public TextType PersonFiduciaryAssociationTypeText
        {
            get
            {
                return this.personFiduciaryAssociationTypeTextField;
            }
            set
            {
                this.personFiduciaryAssociationTypeTextField = value;
                
            }
        }
    }
}