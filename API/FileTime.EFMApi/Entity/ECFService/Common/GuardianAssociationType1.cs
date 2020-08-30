namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "GuardianAssociationType", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:JuvenileCase-4.0")]
    public partial class GuardianAssociationType1 : GuardianAssociationType
    {

        private TextType guardianAssociationTypeCodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public TextType GuardianAssociationTypeCode
        {
            get
            {
                return this.guardianAssociationTypeCodeField;
            }
            set
            {
                this.guardianAssociationTypeCodeField = value;
                
            }
        }
    }
}