namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class MeterType
    {

        private MeterNumberType meterNumberField;

        private MeterNameType meterNameField;

        private MeterConstantType meterConstantField;

        private MeterConstantCodeType meterConstantCodeField;

        private TotalDeliveredQuantityType totalDeliveredQuantityField;

        private MeterReadingType[] meterReadingField;

        private MeterPropertyType[] meterPropertyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public MeterNumberType MeterNumber
        {
            get
            {
                return this.meterNumberField;
            }
            set
            {
                this.meterNumberField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public MeterNameType MeterName
        {
            get
            {
                return this.meterNameField;
            }
            set
            {
                this.meterNameField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public MeterConstantType MeterConstant
        {
            get
            {
                return this.meterConstantField;
            }
            set
            {
                this.meterConstantField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public MeterConstantCodeType MeterConstantCode
        {
            get
            {
                return this.meterConstantCodeField;
            }
            set
            {
                this.meterConstantCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
        public TotalDeliveredQuantityType TotalDeliveredQuantity
        {
            get
            {
                return this.totalDeliveredQuantityField;
            }
            set
            {
                this.totalDeliveredQuantityField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MeterReading", Order = 5)]
        public MeterReadingType[] MeterReading
        {
            get
            {
                return this.meterReadingField;
            }
            set
            {
                this.meterReadingField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MeterProperty", Order = 6)]
        public MeterPropertyType[] MeterProperty
        {
            get
            {
                return this.meterPropertyField;
            }
            set
            {
                this.meterPropertyField = value;
                
            }
        }

        

        
    }
}