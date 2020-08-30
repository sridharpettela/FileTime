namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class MeterReadingType
    {

        private MeterReadingTypeType meterReadingType1Field;

        private MeterReadingTypeCodeType meterReadingTypeCodeField;

        private PreviousMeterReadingDateType previousMeterReadingDateField;

        private PreviousMeterQuantityType previousMeterQuantityField;

        private LatestMeterReadingDateType latestMeterReadingDateField;

        private LatestMeterQuantityType latestMeterQuantityField;

        private MeterReadingMethodType meterReadingMethodField;

        private MeterReadingMethodCodeType meterReadingMethodCodeField;

        private MeterReadingCommentsType[] meterReadingCommentsField;

        private DeliveredQuantityType deliveredQuantityField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MeterReadingType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public MeterReadingTypeType MeterReadingType1
        {
            get
            {
                return this.meterReadingType1Field;
            }
            set
            {
                this.meterReadingType1Field = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public MeterReadingTypeCodeType MeterReadingTypeCode
        {
            get
            {
                return this.meterReadingTypeCodeField;
            }
            set
            {
                this.meterReadingTypeCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public PreviousMeterReadingDateType PreviousMeterReadingDate
        {
            get
            {
                return this.previousMeterReadingDateField;
            }
            set
            {
                this.previousMeterReadingDateField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public PreviousMeterQuantityType PreviousMeterQuantity
        {
            get
            {
                return this.previousMeterQuantityField;
            }
            set
            {
                this.previousMeterQuantityField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
        public LatestMeterReadingDateType LatestMeterReadingDate
        {
            get
            {
                return this.latestMeterReadingDateField;
            }
            set
            {
                this.latestMeterReadingDateField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 5)]
        public LatestMeterQuantityType LatestMeterQuantity
        {
            get
            {
                return this.latestMeterQuantityField;
            }
            set
            {
                this.latestMeterQuantityField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 6)]
        public MeterReadingMethodType MeterReadingMethod
        {
            get
            {
                return this.meterReadingMethodField;
            }
            set
            {
                this.meterReadingMethodField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 7)]
        public MeterReadingMethodCodeType MeterReadingMethodCode
        {
            get
            {
                return this.meterReadingMethodCodeField;
            }
            set
            {
                this.meterReadingMethodCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MeterReadingComments", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 8)]
        public MeterReadingCommentsType[] MeterReadingComments
        {
            get
            {
                return this.meterReadingCommentsField;
            }
            set
            {
                this.meterReadingCommentsField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 9)]
        public DeliveredQuantityType DeliveredQuantity
        {
            get
            {
                return this.deliveredQuantityField;
            }
            set
            {
                this.deliveredQuantityField = value;
                
            }
        }

        

      
    }
}