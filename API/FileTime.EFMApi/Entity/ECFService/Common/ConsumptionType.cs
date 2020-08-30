namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class ConsumptionType
    {

        private UtilityStatementTypeCodeType utilityStatementTypeCodeField;

        private PeriodType mainPeriodField;

        private AllowanceChargeType[] allowanceChargeField;

        private TaxTotalType[] taxTotalField;

        private EnergyWaterSupplyType energyWaterSupplyField;

        private TelecommunicationsSupplyType telecommunicationsSupplyField;

        private MonetaryTotalType legalMonetaryTotalField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public UtilityStatementTypeCodeType UtilityStatementTypeCode
        {
            get
            {
                return this.utilityStatementTypeCodeField;
            }
            set
            {
                this.utilityStatementTypeCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public PeriodType MainPeriod
        {
            get
            {
                return this.mainPeriodField;
            }
            set
            {
                this.mainPeriodField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AllowanceCharge", Order = 2)]
        public AllowanceChargeType[] AllowanceCharge
        {
            get
            {
                return this.allowanceChargeField;
            }
            set
            {
                this.allowanceChargeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TaxTotal", Order = 3)]
        public TaxTotalType[] TaxTotal
        {
            get
            {
                return this.taxTotalField;
            }
            set
            {
                this.taxTotalField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public EnergyWaterSupplyType EnergyWaterSupply
        {
            get
            {
                return this.energyWaterSupplyField;
            }
            set
            {
                this.energyWaterSupplyField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public TelecommunicationsSupplyType TelecommunicationsSupply
        {
            get
            {
                return this.telecommunicationsSupplyField;
            }
            set
            {
                this.telecommunicationsSupplyField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public MonetaryTotalType LegalMonetaryTotal
        {
            get
            {
                return this.legalMonetaryTotalField;
            }
            set
            {
                this.legalMonetaryTotalField = value;
                
            }
        }

        

       
    }
}