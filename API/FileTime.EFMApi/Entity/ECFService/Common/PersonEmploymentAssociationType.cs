namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public partial class PersonEmploymentAssociationType : AssociationType
    {

        private ReferenceType employeeReferenceField;

        private EntityType employerField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public ReferenceType EmployeeReference
        {
            get
            {
                return this.employeeReferenceField;
            }
            set
            {
                this.employeeReferenceField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 1)]
        public EntityType Employer
        {
            get
            {
                return this.employerField;
            }
            set
            {
                this.employerField = value;
                
            }
        }
    }
}