namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CaseAbstractorType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "CaseParticipantType")]
    public partial class CaseParticipantType : EntityType
    {

        private TextType caseParticipantRoleCodeField;

        private ContactInformationType[] contactInformationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0, Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CommonTypes-4.0")]
        public TextType CaseParticipantRoleCode
        {
            get
            {
                return this.caseParticipantRoleCodeField;
            }
            set
            {
                this.caseParticipantRoleCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ContactInformation", Namespace = "http://niem.gov/niem/niem-core/2.0",  Order = 1)]
        public ContactInformationType[] ContactInformation
        {
            get
            {
                return this.contactInformationField;
            }
            set
            {
                this.contactInformationField = value;
                
            }
        }
    }
}