namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CaseOfficialType1))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://niem.gov/niem/domains/jxdm/4.0")]
    public partial class CaseOfficialType : JudicialOfficialType
    {

        private IdentificationType caseOfficialCaseIdentificationField;

        private TextType caseOfficialRoleTextField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 0)]
        public IdentificationType CaseOfficialCaseIdentification
        {
            get
            {
                return this.caseOfficialCaseIdentificationField;
            }
            set
            {
                this.caseOfficialCaseIdentificationField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 1)]
        public TextType CaseOfficialRoleText
        {
            get
            {
                return this.caseOfficialRoleTextField;
            }
            set
            {
                this.caseOfficialRoleTextField = value;
                
            }
        }
    }
}