namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class TendererRequirementType
    {

        private NameType1[] nameField;

        private TendererRequirementTypeCodeType tendererRequirementTypeCodeField;

        private DescriptionType[] descriptionField;

        private EvidenceType[] suggestedEvidenceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Name", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public NameType1[] Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public TendererRequirementTypeCodeType TendererRequirementTypeCode
        {
            get
            {
                return this.tendererRequirementTypeCodeField;
            }
            set
            {
                this.tendererRequirementTypeCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
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
        [System.Xml.Serialization.XmlElementAttribute("SuggestedEvidence", Order = 3)]
        public EvidenceType[] SuggestedEvidence
        {
            get
            {
                return this.suggestedEvidenceField;
            }
            set
            {
                this.suggestedEvidenceField = value;
                
            }
        }

    }
}