namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CaseOfficialType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CaseOfficialType1))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://niem.gov/niem/domains/jxdm/4.0")]
    public partial class JudicialOfficialType : ComplexObjectType
    {

        private ReferenceType roleOfPersonReferenceField;

        private JudicialOfficialBarMembershipType judicialOfficialBarMembershipField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0", Order = 0)]
        public ReferenceType RoleOfPersonReference
        {
            get
            {
                return this.roleOfPersonReferenceField;
            }
            set
            {
                this.roleOfPersonReferenceField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 1)]
        public JudicialOfficialBarMembershipType JudicialOfficialBarMembership
        {
            get
            {
                return this.judicialOfficialBarMembershipField;
            }
            set
            {
                this.judicialOfficialBarMembershipField = value;
                
            }
        }
    }
}