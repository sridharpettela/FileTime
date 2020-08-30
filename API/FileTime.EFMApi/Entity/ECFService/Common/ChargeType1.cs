namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ChargeType2))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ChargeType3))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ChargeType", Namespace = "http://niem.gov/niem/domains/jxdm/4.0")]
    public partial class ChargeType1 : ComplexObjectType
    {

        private TextType chargeApplicabilityTextField;

        private TextType chargeDegreeTextField;

        private TextType chargeDescriptionTextField;

        private ChargeDispositionType chargeDispositionField;

        private ChargeType1 chargeEnhancingAllegationChargeField;

        private OFFCodeType chargeNCICCodeField;

        private IdentificationType chargeSequenceIDField;

        private SeverityLevelType chargeSeverityLevelField;

        private TextType chargeSpecialAllegationTextField;

        private StatuteType chargeStatuteField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 0)]
        public TextType ChargeApplicabilityText
        {
            get
            {
                return this.chargeApplicabilityTextField;
            }
            set
            {
                this.chargeApplicabilityTextField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 1)]
        public TextType ChargeDegreeText
        {
            get
            {
                return this.chargeDegreeTextField;
            }
            set
            {
                this.chargeDegreeTextField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 2)]
        public TextType ChargeDescriptionText
        {
            get
            {
                return this.chargeDescriptionTextField;
            }
            set
            {
                this.chargeDescriptionTextField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 3)]
        public ChargeDispositionType ChargeDisposition
        {
            get
            {
                return this.chargeDispositionField;
            }
            set
            {
                this.chargeDispositionField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 4)]
        public ChargeType1 ChargeEnhancingAllegationCharge
        {
            get
            {
                return this.chargeEnhancingAllegationChargeField;
            }
            set
            {
                this.chargeEnhancingAllegationChargeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 5)]
        public OFFCodeType ChargeNCICCode
        {
            get
            {
                return this.chargeNCICCodeField;
            }
            set
            {
                this.chargeNCICCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 6)]
        public IdentificationType ChargeSequenceID
        {
            get
            {
                return this.chargeSequenceIDField;
            }
            set
            {
                this.chargeSequenceIDField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 7)]
        public SeverityLevelType ChargeSeverityLevel
        {
            get
            {
                return this.chargeSeverityLevelField;
            }
            set
            {
                this.chargeSeverityLevelField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 8)]
        public TextType ChargeSpecialAllegationText
        {
            get
            {
                return this.chargeSpecialAllegationTextField;
            }
            set
            {
                this.chargeSpecialAllegationTextField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 9)]
        public StatuteType ChargeStatute
        {
            get
            {
                return this.chargeStatuteField;
            }
            set
            {
                this.chargeStatuteField = value;
                
            }
        }
    }
}