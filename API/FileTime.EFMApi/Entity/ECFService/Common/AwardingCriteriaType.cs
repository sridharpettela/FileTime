namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class AwardingCriteriaType
    {

        private IDType idField;

        private AwardingCriteriaTypeCodeType awardingCriteriaTypeCodeField;

        private DescriptionType[] descriptionField;

        private WeightNumericType weightNumericField;

        private WeightType[] weightField;

        private CalculationExpressionType[] calculationExpressionField;

        private CalculationExpressionCodeType calculationExpressionCodeField;

        private MinimumQuantityType minimumQuantityField;

        private MaximumQuantityType maximumQuantityField;

        private MinimumAmountType minimumAmountField;

        private MaximumAmountType maximumAmountField;

        private MinimumImprovementBidType[] minimumImprovementBidField;

        private AwardingCriteriaType[] subordinateAwardingCriteriaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public IDType ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public AwardingCriteriaTypeCodeType AwardingCriteriaTypeCode
        {
            get
            {
                return this.awardingCriteriaTypeCodeField;
            }
            set
            {
                this.awardingCriteriaTypeCodeField = value;
                
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public WeightNumericType WeightNumeric
        {
            get
            {
                return this.weightNumericField;
            }
            set
            {
                this.weightNumericField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Weight", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
        public WeightType[] Weight
        {
            get
            {
                return this.weightField;
            }
            set
            {
                this.weightField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CalculationExpression", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 5)]
        public CalculationExpressionType[] CalculationExpression
        {
            get
            {
                return this.calculationExpressionField;
            }
            set
            {
                this.calculationExpressionField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 6)]
        public CalculationExpressionCodeType CalculationExpressionCode
        {
            get
            {
                return this.calculationExpressionCodeField;
            }
            set
            {
                this.calculationExpressionCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 7)]
        public MinimumQuantityType MinimumQuantity
        {
            get
            {
                return this.minimumQuantityField;
            }
            set
            {
                this.minimumQuantityField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 8)]
        public MaximumQuantityType MaximumQuantity
        {
            get
            {
                return this.maximumQuantityField;
            }
            set
            {
                this.maximumQuantityField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 9)]
        public MinimumAmountType MinimumAmount
        {
            get
            {
                return this.minimumAmountField;
            }
            set
            {
                this.minimumAmountField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 10)]
        public MaximumAmountType MaximumAmount
        {
            get
            {
                return this.maximumAmountField;
            }
            set
            {
                this.maximumAmountField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MinimumImprovementBid", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 11)]
        public MinimumImprovementBidType[] MinimumImprovementBid
        {
            get
            {
                return this.minimumImprovementBidField;
            }
            set
            {
                this.minimumImprovementBidField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SubordinateAwardingCriteria", Order = 12)]
        public AwardingCriteriaType[] SubordinateAwardingCriteria
        {
            get
            {
                return this.subordinateAwardingCriteriaField;
            }
            set
            {
                this.subordinateAwardingCriteriaField = value;
                
            }
        }

    }
}