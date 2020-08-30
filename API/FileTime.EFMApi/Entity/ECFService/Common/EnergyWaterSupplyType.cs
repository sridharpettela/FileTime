namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class EnergyWaterSupplyType
    {

        private ConsumptionReportType[] consumptionReportField;

        private EnergyTaxReportType[] energyTaxReportField;

        private ConsumptionAverageType[] consumptionAverageField;

        private CorrectionType[] energyWaterCorrectionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ConsumptionReport", Order = 0)]
        public ConsumptionReportType[] ConsumptionReport
        {
            get
            {
                return this.consumptionReportField;
            }
            set
            {
                this.consumptionReportField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EnergyTaxReport", Order = 1)]
        public EnergyTaxReportType[] EnergyTaxReport
        {
            get
            {
                return this.energyTaxReportField;
            }
            set
            {
                this.energyTaxReportField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ConsumptionAverage", Order = 2)]
        public ConsumptionAverageType[] ConsumptionAverage
        {
            get
            {
                return this.consumptionAverageField;
            }
            set
            {
                this.consumptionAverageField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EnergyWaterCorrection", Order = 3)]
        public CorrectionType[] EnergyWaterCorrection
        {
            get
            {
                return this.energyWaterCorrectionField;
            }
            set
            {
                this.energyWaterCorrectionField = value;
                
            }
        }

        

        
    }
}