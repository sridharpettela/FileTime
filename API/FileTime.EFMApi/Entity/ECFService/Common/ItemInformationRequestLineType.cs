namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class ItemInformationRequestLineType
    {

        private TimeFrequencyCodeType timeFrequencyCodeField;

        private SupplyChainActivityTypeCodeType supplyChainActivityTypeCodeField;

        private ForecastTypeCodeType forecastTypeCodeField;

        private PerformanceMetricTypeCodeType performanceMetricTypeCodeField;

        private PeriodType[] periodField;

        private SalesItemType[] salesItemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public TimeFrequencyCodeType TimeFrequencyCode
        {
            get
            {
                return this.timeFrequencyCodeField;
            }
            set
            {
                this.timeFrequencyCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public SupplyChainActivityTypeCodeType SupplyChainActivityTypeCode
        {
            get
            {
                return this.supplyChainActivityTypeCodeField;
            }
            set
            {
                this.supplyChainActivityTypeCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public ForecastTypeCodeType ForecastTypeCode
        {
            get
            {
                return this.forecastTypeCodeField;
            }
            set
            {
                this.forecastTypeCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public PerformanceMetricTypeCodeType PerformanceMetricTypeCode
        {
            get
            {
                return this.performanceMetricTypeCodeField;
            }
            set
            {
                this.performanceMetricTypeCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Period", Order = 4)]
        public PeriodType[] Period
        {
            get
            {
                return this.periodField;
            }
            set
            {
                this.periodField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SalesItem", Order = 5)]
        public SalesItemType[] SalesItem
        {
            get
            {
                return this.salesItemField;
            }
            set
            {
                this.salesItemField = value;
                
            }
        }

        

        
    }
}