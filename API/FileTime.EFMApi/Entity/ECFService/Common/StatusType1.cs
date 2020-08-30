namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "StatusType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class StatusType1
    {

        private ConditionCodeType conditionCodeField;

        private ReferenceDateType referenceDateField;

        private ReferenceTimeType referenceTimeField;

        private DescriptionType[] descriptionField;

        private StatusReasonCodeType statusReasonCodeField;

        private StatusReasonType[] statusReasonField;

        private SequenceIDType sequenceIDField;

        private TextType3[] textField;

        private IndicationIndicatorType indicationIndicatorField;

        private PercentType1 percentField;

        private ConditionValueMeasureType[] conditionValueMeasureField;

        private ReliabilityPercentType reliabilityPercentField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public ConditionCodeType ConditionCode
        {
            get
            {
                return this.conditionCodeField;
            }
            set
            {
                this.conditionCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public ReferenceDateType ReferenceDate
        {
            get
            {
                return this.referenceDateField;
            }
            set
            {
                this.referenceDateField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public ReferenceTimeType ReferenceTime
        {
            get
            {
                return this.referenceTimeField;
            }
            set
            {
                this.referenceTimeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
        public StatusReasonCodeType StatusReasonCode
        {
            get
            {
                return this.statusReasonCodeField;
            }
            set
            {
                this.statusReasonCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("StatusReason", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 5)]
        public StatusReasonType[] StatusReason
        {
            get
            {
                return this.statusReasonField;
            }
            set
            {
                this.statusReasonField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 6)]
        public SequenceIDType SequenceID
        {
            get
            {
                return this.sequenceIDField;
            }
            set
            {
                this.sequenceIDField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Text", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 7)]
        public TextType3[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 8)]
        public IndicationIndicatorType IndicationIndicator
        {
            get
            {
                return this.indicationIndicatorField;
            }
            set
            {
                this.indicationIndicatorField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 9)]
        public PercentType1 Percent
        {
            get
            {
                return this.percentField;
            }
            set
            {
                this.percentField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ConditionValueMeasure", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 10)]
        public ConditionValueMeasureType[] ConditionValueMeasure
        {
            get
            {
                return this.conditionValueMeasureField;
            }
            set
            {
                this.conditionValueMeasureField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 11)]
        public ReliabilityPercentType ReliabilityPercent
        {
            get
            {
                return this.reliabilityPercentField;
            }
            set
            {
                this.reliabilityPercentField = value;
                
            }
        }

        
    }
}