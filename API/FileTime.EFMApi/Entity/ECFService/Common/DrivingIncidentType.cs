namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DrivingIncidentType1))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://niem.gov/niem/domains/jxdm/4.0")]
    public partial class DrivingIncidentType : IncidentType
    {

        private AccidentSeverityCodeType item1Field;

        private MeasureType3 drivingIncidentRecordedSpeedRateField;

        private HazMatCodeType item2Field;

        private boolean drivingIncidentLaserDetectionIndicatorField;

        private MeasureType3 drivingIncidentLegalSpeedRateField;

        private TextType drivingIncidentPassengerQuantityTextField;

        private boolean[] drivingIncidentRadarDetectionIndicatorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DrivingAccidentSeverityCode",  Order = 0)]
        public AccidentSeverityCodeType Item1
        {
            get
            {
                return this.item1Field;
            }
            set
            {
                this.item1Field = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 1)]
        public MeasureType3 DrivingIncidentRecordedSpeedRate
        {
            get
            {
                return this.drivingIncidentRecordedSpeedRateField;
            }
            set
            {
                this.drivingIncidentRecordedSpeedRateField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DrivingIncidentHazMatCode",  Order = 2)]
        public HazMatCodeType Item2
        {
            get
            {
                return this.item2Field;
            }
            set
            {
                this.item2Field = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 3)]
        public boolean DrivingIncidentLaserDetectionIndicator
        {
            get
            {
                return this.drivingIncidentLaserDetectionIndicatorField;
            }
            set
            {
                this.drivingIncidentLaserDetectionIndicatorField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 4)]
        public MeasureType3 DrivingIncidentLegalSpeedRate
        {
            get
            {
                return this.drivingIncidentLegalSpeedRateField;
            }
            set
            {
                this.drivingIncidentLegalSpeedRateField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 5)]
        public TextType DrivingIncidentPassengerQuantityText
        {
            get
            {
                return this.drivingIncidentPassengerQuantityTextField;
            }
            set
            {
                this.drivingIncidentPassengerQuantityTextField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DrivingIncidentRadarDetectionIndicator",  Order = 6)]
        public boolean[] DrivingIncidentRadarDetectionIndicator
        {
            get
            {
                return this.drivingIncidentRadarDetectionIndicatorField;
            }
            set
            {
                this.drivingIncidentRadarDetectionIndicatorField = value;
                
            }
        }
    }
}