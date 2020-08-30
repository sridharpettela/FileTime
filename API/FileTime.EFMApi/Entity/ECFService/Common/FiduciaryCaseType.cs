namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CivilCase-4.0")]
    public partial class FiduciaryCaseType : ComplexObjectType
    {

        private TextType fiduciaryTypeCodeField;

        private TextType personFiduciaryAssociationTypeTextField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public TextType FiduciaryTypeCode
        {
            get
            {
                return this.fiduciaryTypeCodeField;
            }
            set
            {
                this.fiduciaryTypeCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
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