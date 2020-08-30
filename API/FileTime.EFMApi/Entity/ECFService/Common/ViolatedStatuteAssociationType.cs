namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://niem.gov/niem/domains/jxdm/4.0")]
    public partial class ViolatedStatuteAssociationType : AssociationType
    {

        private ReferenceType subjectReferenceField;

        private ReferenceType[] victimReferenceField;

        private ReferenceType incidentReferenceField;

        private ReferenceType[] statuteReferenceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public ReferenceType SubjectReference
        {
            get
            {
                return this.subjectReferenceField;
            }
            set
            {
                this.subjectReferenceField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("VictimReference", Order = 1)]
        public ReferenceType[] VictimReference
        {
            get
            {
                return this.victimReferenceField;
            }
            set
            {
                this.victimReferenceField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0", Order = 2)]
        public ReferenceType IncidentReference
        {
            get
            {
                return this.incidentReferenceField;
            }
            set
            {
                this.incidentReferenceField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("StatuteReference", Order = 3)]
        public ReferenceType[] StatuteReference
        {
            get
            {
                return this.statuteReferenceField;
            }
            set
            {
                this.statuteReferenceField = value;
                
            }
        }
    }
}