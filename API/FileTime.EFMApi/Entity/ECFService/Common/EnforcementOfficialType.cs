namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://niem.gov/niem/domains/jxdm/4.0")]
    public partial class EnforcementOfficialType : ComplexObjectType
    {

        private ReferenceType roleOfPersonReferenceField;

        private IdentificationType enforcementOfficialBadgeIdentificationField;

        private ScheduleDayType enforcementOfficialUnavailableScheduleField;

        private EnforcementUnitType enforcementOfficialUnitField;

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
        public IdentificationType EnforcementOfficialBadgeIdentification
        {
            get
            {
                return this.enforcementOfficialBadgeIdentificationField;
            }
            set
            {
                this.enforcementOfficialBadgeIdentificationField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 2)]
        public ScheduleDayType EnforcementOfficialUnavailableSchedule
        {
            get
            {
                return this.enforcementOfficialUnavailableScheduleField;
            }
            set
            {
                this.enforcementOfficialUnavailableScheduleField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 3)]
        public EnforcementUnitType EnforcementOfficialUnit
        {
            get
            {
                return this.enforcementOfficialUnitField;
            }
            set
            {
                this.enforcementOfficialUnitField = value;
                
            }
        }
    }
}