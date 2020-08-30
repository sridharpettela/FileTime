namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SubjectType2))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SubjectType3))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(JuvenileType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SubjectType1))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://niem.gov/niem/domains/jxdm/4.0")]
    public partial class SubjectType : ComplexObjectType
    {

        private ReferenceType roleOfPersonReferenceField;

        private IdentificationType subjectIdentificationField;

        private SupervisionType subjectSupervisionField;

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
        public IdentificationType SubjectIdentification
        {
            get
            {
                return this.subjectIdentificationField;
            }
            set
            {
                this.subjectIdentificationField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 2)]
        public SupervisionType SubjectSupervision
        {
            get
            {
                return this.subjectSupervisionField;
            }
            set
            {
                this.subjectSupervisionField = value;
                
            }
        }
    }
}