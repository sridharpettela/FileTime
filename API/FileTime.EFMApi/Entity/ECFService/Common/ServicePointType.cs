namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class ServicePointType
    {

        private SequenceNumberIDType sequenceNumberIDField;

        private TransportModeCodeType transportModeCodeField;

        private RemarksType[] remarksField;

        private LocationType1 servicePointLocationField;

        private TransportMeansType transportMeansField;

        private PeriodType plannedDeparturePeriodField;

        private PeriodType plannedArrivalPeriodField;

        private PeriodType despatchPeriodField;

        private PeriodType deliveryPeriodField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public SequenceNumberIDType SequenceNumberID
        {
            get
            {
                return this.sequenceNumberIDField;
            }
            set
            {
                this.sequenceNumberIDField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public TransportModeCodeType TransportModeCode
        {
            get
            {
                return this.transportModeCodeField;
            }
            set
            {
                this.transportModeCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Remarks", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public RemarksType[] Remarks
        {
            get
            {
                return this.remarksField;
            }
            set
            {
                this.remarksField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public LocationType1 ServicePointLocation
        {
            get
            {
                return this.servicePointLocationField;
            }
            set
            {
                this.servicePointLocationField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public TransportMeansType TransportMeans
        {
            get
            {
                return this.transportMeansField;
            }
            set
            {
                this.transportMeansField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public PeriodType PlannedDeparturePeriod
        {
            get
            {
                return this.plannedDeparturePeriodField;
            }
            set
            {
                this.plannedDeparturePeriodField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public PeriodType PlannedArrivalPeriod
        {
            get
            {
                return this.plannedArrivalPeriodField;
            }
            set
            {
                this.plannedArrivalPeriodField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public PeriodType DespatchPeriod
        {
            get
            {
                return this.despatchPeriodField;
            }
            set
            {
                this.despatchPeriodField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public PeriodType DeliveryPeriod
        {
            get
            {
                return this.deliveryPeriodField;
            }
            set
            {
                this.deliveryPeriodField = value;
                
            }
        }

        
    }
}