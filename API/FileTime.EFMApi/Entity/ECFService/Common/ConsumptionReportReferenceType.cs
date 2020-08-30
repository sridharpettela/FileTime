namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class ConsumptionReportReferenceType
    {

        private ConsumptionReportIDType consumptionReportIDField;

        private ConsumptionTypeType consumptionTypeField;

        private ConsumptionTypeCodeType consumptionTypeCodeField;

        private TotalConsumedQuantityType totalConsumedQuantityField;

        private PeriodType periodField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public ConsumptionReportIDType ConsumptionReportID
        {
            get
            {
                return this.consumptionReportIDField;
            }
            set
            {
                this.consumptionReportIDField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public ConsumptionTypeType ConsumptionType
        {
            get
            {
                return this.consumptionTypeField;
            }
            set
            {
                this.consumptionTypeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public ConsumptionTypeCodeType ConsumptionTypeCode
        {
            get
            {
                return this.consumptionTypeCodeField;
            }
            set
            {
                this.consumptionTypeCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public TotalConsumedQuantityType TotalConsumedQuantity
        {
            get
            {
                return this.totalConsumedQuantityField;
            }
            set
            {
                this.totalConsumedQuantityField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public PeriodType Period
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
    }
}