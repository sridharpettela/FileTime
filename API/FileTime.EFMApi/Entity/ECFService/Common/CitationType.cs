namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://niem.gov/niem/domains/jxdm/4.0")]
    public partial class CitationType : ActivityType
    {

        private OrganizationType citationAgencyField;

        private boolean citationDismissalConditionIndicatorField;

        private EnforcementOfficialType citationIssuingOfficialField;

        private SubjectType citationSubjectField;

        private IncidentType[] citationViolationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 0)]
        public OrganizationType CitationAgency
        {
            get
            {
                return this.citationAgencyField;
            }
            set
            {
                this.citationAgencyField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 1)]
        public boolean CitationDismissalConditionIndicator
        {
            get
            {
                return this.citationDismissalConditionIndicatorField;
            }
            set
            {
                this.citationDismissalConditionIndicatorField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 2)]
        public EnforcementOfficialType CitationIssuingOfficial
        {
            get
            {
                return this.citationIssuingOfficialField;
            }
            set
            {
                this.citationIssuingOfficialField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 3)]
        public SubjectType CitationSubject
        {
            get
            {
                return this.citationSubjectField;
            }
            set
            {
                this.citationSubjectField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CitationViolation",  Order = 4)]
        public IncidentType[] CitationViolation
        {
            get
            {
                return this.citationViolationField;
            }
            set
            {
                this.citationViolationField = value;
                
            }
        }
    }
}