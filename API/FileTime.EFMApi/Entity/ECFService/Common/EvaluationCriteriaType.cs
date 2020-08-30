namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class EvaluationCriteriaType
    {

        private EvaluationCriteriaTypeCodeType evaluationCriteriaTypeCodeField;

        private DescriptionType[] descriptionField;

        private ThresholdAmountType thresholdAmountField;

        private ThresholdQuantityType thresholdQuantityField;

        private ExpressionCodeType[] expressionCodeField;

        private PeriodType durationPeriodField;

        private EvidenceType[] suggestedEvidenceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public EvaluationCriteriaTypeCodeType EvaluationCriteriaTypeCode
        {
            get
            {
                return this.evaluationCriteriaTypeCodeField;
            }
            set
            {
                this.evaluationCriteriaTypeCodeField = value;
                
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public ThresholdAmountType ThresholdAmount
        {
            get
            {
                return this.thresholdAmountField;
            }
            set
            {
                this.thresholdAmountField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public ThresholdQuantityType ThresholdQuantity
        {
            get
            {
                return this.thresholdQuantityField;
            }
            set
            {
                this.thresholdQuantityField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ExpressionCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
        public ExpressionCodeType[] ExpressionCode
        {
            get
            {
                return this.expressionCodeField;
            }
            set
            {
                this.expressionCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public PeriodType DurationPeriod
        {
            get
            {
                return this.durationPeriodField;
            }
            set
            {
                this.durationPeriodField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SuggestedEvidence", Order = 6)]
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