namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class TransportLocationType
    {

        private PeriodType plannedDeparturePeriodField;

        private PeriodType plannedArrivalPeriodField;

        private PeriodType estimatedDeparturePeriodField;

        private PeriodType estimatedArrivalPeriodField;

        private TransportEventType actualDepartureTransportEventField;

        private TransportEventType transportEventField;

        private LocationType1 locationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public PeriodType EstimatedDeparturePeriod
        {
            get
            {
                return this.estimatedDeparturePeriodField;
            }
            set
            {
                this.estimatedDeparturePeriodField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public PeriodType EstimatedArrivalPeriod
        {
            get
            {
                return this.estimatedArrivalPeriodField;
            }
            set
            {
                this.estimatedArrivalPeriodField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public TransportEventType ActualDepartureTransportEvent
        {
            get
            {
                return this.actualDepartureTransportEventField;
            }
            set
            {
                this.actualDepartureTransportEventField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public TransportEventType TransportEvent
        {
            get
            {
                return this.transportEventField;
            }
            set
            {
                this.transportEventField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public LocationType1 Location
        {
            get
            {
                return this.locationField;
            }
            set
            {
                this.locationField = value;
                
            }
        }

    }
}