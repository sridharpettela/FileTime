namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class TransportScheduleType
    {

        private SequenceNumberIDType sequenceNumberIDField;

        private ReferenceDateType referenceDateField;

        private ReferenceTimeType referenceTimeField;

        private ReliabilityPercentType reliabilityPercentField;

        private RemarksType[] remarksField;

        private LocationType1 statusLocationField;

        private PeriodType estimatedArrivalPeriodField;

        private PeriodType estimatedDeparturePeriodField;

        private TransportEventType actualArrivalTransportEventField;

        private TransportEventType actualDepartureTransportEventField;

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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
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

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Remarks", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public LocationType1 StatusLocation
        {
            get
            {
                return this.statusLocationField;
            }
            set
            {
                this.statusLocationField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public TransportEventType ActualArrivalTransportEvent
        {
            get
            {
                return this.actualArrivalTransportEventField;
            }
            set
            {
                this.actualArrivalTransportEventField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
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

        

    }
}