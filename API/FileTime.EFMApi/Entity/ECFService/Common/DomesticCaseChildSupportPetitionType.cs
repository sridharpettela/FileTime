namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:DomesticCase-4.0")]
    public partial class DomesticCaseChildSupportPetitionType : ComplexObjectType
    {

        private ImmediateFamilyAssociationType[] immediateFamilyAssociationField;

        private TextType jurisdictionReasonTextField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ImmediateFamilyAssociation", Namespace = "http://niem.gov/niem/niem-core/2.0",  Order = 0)]
        public ImmediateFamilyAssociationType[] ImmediateFamilyAssociation
        {
            get
            {
                return this.immediateFamilyAssociationField;
            }
            set
            {
                this.immediateFamilyAssociationField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public TextType JurisdictionReasonText
        {
            get
            {
                return this.jurisdictionReasonTextField;
            }
            set
            {
                this.jurisdictionReasonTextField = value;
                
            }
        }
    }
}