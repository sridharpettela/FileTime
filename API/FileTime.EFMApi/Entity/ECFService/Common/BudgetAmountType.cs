namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class BudgetAmountType
    {

        private EstimatedOverallContractAmountType estimatedOverallContractAmountField;

        private TotalAmountType totalAmountField;

        private TaxExclusiveAmountType taxExclusiveAmountField;

        private MinimumAmountType minimumAmountField;

        private MonetaryScopeType[] monetaryScopeField;

        private AverageSubsequentContractAmountType averageSubsequentContractAmountField;

        private TaxCategoryType[] applicableTaxCategoryField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public EstimatedOverallContractAmountType EstimatedOverallContractAmount
        {
            get
            {
                return this.estimatedOverallContractAmountField;
            }
            set
            {
                this.estimatedOverallContractAmountField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public TotalAmountType TotalAmount
        {
            get
            {
                return this.totalAmountField;
            }
            set
            {
                this.totalAmountField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public TaxExclusiveAmountType TaxExclusiveAmount
        {
            get
            {
                return this.taxExclusiveAmountField;
            }
            set
            {
                this.taxExclusiveAmountField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
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
        [System.Xml.Serialization.XmlElementAttribute("MonetaryScope", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
        public MonetaryScopeType[] MonetaryScope
        {
            get
            {
                return this.monetaryScopeField;
            }
            set
            {
                this.monetaryScopeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 5)]
        public AverageSubsequentContractAmountType AverageSubsequentContractAmount
        {
            get
            {
                return this.averageSubsequentContractAmountField;
            }
            set
            {
                this.averageSubsequentContractAmountField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ApplicableTaxCategory", Order = 6)]
        public TaxCategoryType[] ApplicableTaxCategory
        {
            get
            {
                return this.applicableTaxCategoryField;
            }
            set
            {
                this.applicableTaxCategoryField = value;
                
            }
        }

        
    }
}