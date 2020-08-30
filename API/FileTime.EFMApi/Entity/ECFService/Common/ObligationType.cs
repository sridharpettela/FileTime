namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FinancialObligationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ObligationRecurrenceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DomesticCaseObligationType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public partial class ObligationType : ComplexObjectType
    {

        private AmountType3 itemField;

        private ObligationExemptionType obligationExemptionField;

        private TextType obligationRequirementDescriptionTextField;

        private TextType obligationCategoryTextField;

        private EntityType obligationEntityField;

        private EntityType obligationRecipientField;

        private ObligationRecurrenceType obligationRecurrenceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ObligationDueAmount",  Order = 0)]
        public AmountType3 Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 1)]
        public ObligationExemptionType ObligationExemption
        {
            get
            {
                return this.obligationExemptionField;
            }
            set
            {
                this.obligationExemptionField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 2)]
        public TextType ObligationRequirementDescriptionText
        {
            get
            {
                return this.obligationRequirementDescriptionTextField;
            }
            set
            {
                this.obligationRequirementDescriptionTextField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 3)]
        public TextType ObligationCategoryText
        {
            get
            {
                return this.obligationCategoryTextField;
            }
            set
            {
                this.obligationCategoryTextField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 4)]
        public EntityType ObligationEntity
        {
            get
            {
                return this.obligationEntityField;
            }
            set
            {
                this.obligationEntityField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 5)]
        public EntityType ObligationRecipient
        {
            get
            {
                return this.obligationRecipientField;
            }
            set
            {
                this.obligationRecipientField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 6)]
        public ObligationRecurrenceType ObligationRecurrence
        {
            get
            {
                return this.obligationRecurrenceField;
            }
            set
            {
                this.obligationRecurrenceField = value;
                
            }
        }
    }
}