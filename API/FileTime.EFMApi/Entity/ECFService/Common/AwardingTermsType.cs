namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class AwardingTermsType
    {

        private WeightingAlgorithmCodeType weightingAlgorithmCodeField;

        private DescriptionType[] descriptionField;

        private TechnicalCommitteeDescriptionType[] technicalCommitteeDescriptionField;

        private LowTendersDescriptionType[] lowTendersDescriptionField;

        private AwardingCriteriaType[] awardingCriteriaField;

        private PersonType[] technicalCommitteePersonField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public WeightingAlgorithmCodeType WeightingAlgorithmCode
        {
            get
            {
                return this.weightingAlgorithmCodeField;
            }
            set
            {
                this.weightingAlgorithmCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public DescriptionType[] Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TechnicalCommitteeDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public TechnicalCommitteeDescriptionType[] TechnicalCommitteeDescription
        {
            get
            {
                return this.technicalCommitteeDescriptionField;
            }
            set
            {
                this.technicalCommitteeDescriptionField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LowTendersDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public LowTendersDescriptionType[] LowTendersDescription
        {
            get
            {
                return this.lowTendersDescriptionField;
            }
            set
            {
                this.lowTendersDescriptionField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AwardingCriteria", Order = 4)]
        public AwardingCriteriaType[] AwardingCriteria
        {
            get
            {
                return this.awardingCriteriaField;
            }
            set
            {
                this.awardingCriteriaField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TechnicalCommitteePerson", Order = 5)]
        public PersonType[] TechnicalCommitteePerson
        {
            get
            {
                return this.technicalCommitteePersonField;
            }
            set
            {
                this.technicalCommitteePersonField = value;
                
            }
        }
    }
}