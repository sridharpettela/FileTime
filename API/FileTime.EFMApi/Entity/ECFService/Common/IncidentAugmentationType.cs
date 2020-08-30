namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://niem.gov/niem/domains/jxdm/4.0")]
    public partial class IncidentAugmentationType : AugmentationType
    {

        private ReferenceType incidentDamagedPropertyReferenceField;

        private boolean incidentOfficialPresentIndicatorField;

        private boolean incidentTrafficAccidentInvolvedIndicatorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public ReferenceType IncidentDamagedPropertyReference
        {
            get
            {
                return this.incidentDamagedPropertyReferenceField;
            }
            set
            {
                this.incidentDamagedPropertyReferenceField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 1)]
        public boolean IncidentOfficialPresentIndicator
        {
            get
            {
                return this.incidentOfficialPresentIndicatorField;
            }
            set
            {
                this.incidentOfficialPresentIndicatorField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 2)]
        public boolean IncidentTrafficAccidentInvolvedIndicator
        {
            get
            {
                return this.incidentTrafficAccidentInvolvedIndicatorField;
            }
            set
            {
                this.incidentTrafficAccidentInvolvedIndicatorField = value;
                
            }
        }
    }
}