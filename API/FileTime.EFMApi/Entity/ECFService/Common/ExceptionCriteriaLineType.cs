namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class ExceptionCriteriaLineType
    {

        private IDType idField;

        private NoteType[] noteField;

        private ThresholdValueComparisonCodeType thresholdValueComparisonCodeField;

        private ThresholdQuantityType thresholdQuantityField;

        private ExceptionStatusCodeType exceptionStatusCodeField;

        private CollaborationPriorityCodeType collaborationPriorityCodeField;

        private ExceptionResolutionCodeType[] exceptionResolutionCodeField;

        private SupplyChainActivityTypeCodeType supplyChainActivityTypeCodeField;

        private PerformanceMetricTypeCodeType performanceMetricTypeCodeField;

        private PeriodType effectivePeriodField;

        private ItemType1[] supplyItemField;

        private ForecastExceptionCriteriaLineType forecastExceptionCriteriaLineField;

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
        [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public NoteType[] Note
        {
            get
            {
                return this.noteField;
            }
            set
            {
                this.noteField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public ThresholdValueComparisonCodeType ThresholdValueComparisonCode
        {
            get
            {
                return this.thresholdValueComparisonCodeField;
            }
            set
            {
                this.thresholdValueComparisonCodeField = value;
                
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
        public ExceptionStatusCodeType ExceptionStatusCode
        {
            get
            {
                return this.exceptionStatusCodeField;
            }
            set
            {
                this.exceptionStatusCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 5)]
        public CollaborationPriorityCodeType CollaborationPriorityCode
        {
            get
            {
                return this.collaborationPriorityCodeField;
            }
            set
            {
                this.collaborationPriorityCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ExceptionResolutionCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 6)]
        public ExceptionResolutionCodeType[] ExceptionResolutionCode
        {
            get
            {
                return this.exceptionResolutionCodeField;
            }
            set
            {
                this.exceptionResolutionCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 7)]
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 8)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public PeriodType EffectivePeriod
        {
            get
            {
                return this.effectivePeriodField;
            }
            set
            {
                this.effectivePeriodField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SupplyItem", Order = 10)]
        public ItemType1[] SupplyItem
        {
            get
            {
                return this.supplyItemField;
            }
            set
            {
                this.supplyItemField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public ForecastExceptionCriteriaLineType ForecastExceptionCriteriaLine
        {
            get
            {
                return this.forecastExceptionCriteriaLineField;
            }
            set
            {
                this.forecastExceptionCriteriaLineField = value;
                
            }
        }

        

        
    }
}