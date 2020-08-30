namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class ExchangeRateType
    {

        private SourceCurrencyCodeType sourceCurrencyCodeField;

        private SourceCurrencyBaseRateType sourceCurrencyBaseRateField;

        private TargetCurrencyCodeType targetCurrencyCodeField;

        private TargetCurrencyBaseRateType targetCurrencyBaseRateField;

        private ExchangeMarketIDType exchangeMarketIDField;

        private CalculationRateType calculationRateField;

        private MathematicOperatorCodeType mathematicOperatorCodeField;

        private DateType2 dateField;

        private ContractType foreignExchangeContractField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public SourceCurrencyCodeType SourceCurrencyCode
        {
            get
            {
                return this.sourceCurrencyCodeField;
            }
            set
            {
                this.sourceCurrencyCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public SourceCurrencyBaseRateType SourceCurrencyBaseRate
        {
            get
            {
                return this.sourceCurrencyBaseRateField;
            }
            set
            {
                this.sourceCurrencyBaseRateField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public TargetCurrencyCodeType TargetCurrencyCode
        {
            get
            {
                return this.targetCurrencyCodeField;
            }
            set
            {
                this.targetCurrencyCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public TargetCurrencyBaseRateType TargetCurrencyBaseRate
        {
            get
            {
                return this.targetCurrencyBaseRateField;
            }
            set
            {
                this.targetCurrencyBaseRateField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
        public ExchangeMarketIDType ExchangeMarketID
        {
            get
            {
                return this.exchangeMarketIDField;
            }
            set
            {
                this.exchangeMarketIDField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 5)]
        public CalculationRateType CalculationRate
        {
            get
            {
                return this.calculationRateField;
            }
            set
            {
                this.calculationRateField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 6)]
        public MathematicOperatorCodeType MathematicOperatorCode
        {
            get
            {
                return this.mathematicOperatorCodeField;
            }
            set
            {
                this.mathematicOperatorCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 7)]
        public DateType2 Date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public ContractType ForeignExchangeContract
        {
            get
            {
                return this.foreignExchangeContractField;
            }
            set
            {
                this.foreignExchangeContractField = value;
                
            }
        }

        

       
    }
}