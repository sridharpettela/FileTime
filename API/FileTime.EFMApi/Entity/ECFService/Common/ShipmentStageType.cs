namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class ShipmentStageType
    {

        private IDType idField;

        private TransportModeCodeType transportModeCodeField;

        private TransportMeansTypeCodeType transportMeansTypeCodeField;

        private TransitDirectionCodeType transitDirectionCodeField;

        private PreCarriageIndicatorType preCarriageIndicatorField;

        private OnCarriageIndicatorType onCarriageIndicatorField;

        private EstimatedDeliveryDateType estimatedDeliveryDateField;

        private EstimatedDeliveryTimeType estimatedDeliveryTimeField;

        private RequiredDeliveryDateType requiredDeliveryDateField;

        private RequiredDeliveryTimeType requiredDeliveryTimeField;

        private LoadingSequenceIDType loadingSequenceIDField;

        private SuccessiveSequenceIDType successiveSequenceIDField;

        private InstructionsType instructionsField;

        private DemurrageInstructionsType demurrageInstructionsField;

        private PeriodType transitPeriodField;

        private PartyType[] carrierPartyField;

        private TransportMeansType transportMeansField;

        private LocationType1 loadingPortLocationField;

        private LocationType1 unloadingPortLocationField;

        private LocationType1 transshipPortLocationField;

        private TransportEventType loadingTransportEventField;

        private TransportEventType examinationTransportEventField;

        private TransportEventType availabilityTransportEventField;

        private TransportEventType exportationTransportEventField;

        private TransportEventType dischargeTransportEventField;

        private TransportEventType warehousingTransportEventField;

        private TransportEventType takeoverTransportEventField;

        private TransportEventType optionalTakeoverTransportEventField;

        private TransportEventType dropoffTransportEventField;

        private TransportEventType actualPickupTransportEventField;

        private TransportEventType deliveryTransportEventField;

        private TransportEventType receiptTransportEventField;

        private TransportEventType storageTransportEventField;

        private TransportEventType acceptanceTransportEventField;

        private PartyType terminalOperatorPartyField;

        private PartyType customsAgentPartyField;

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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public TransportMeansTypeCodeType TransportMeansTypeCode
        {
            get
            {
                return this.transportMeansTypeCodeField;
            }
            set
            {
                this.transportMeansTypeCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public TransitDirectionCodeType TransitDirectionCode
        {
            get
            {
                return this.transitDirectionCodeField;
            }
            set
            {
                this.transitDirectionCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
        public PreCarriageIndicatorType PreCarriageIndicator
        {
            get
            {
                return this.preCarriageIndicatorField;
            }
            set
            {
                this.preCarriageIndicatorField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 5)]
        public OnCarriageIndicatorType OnCarriageIndicator
        {
            get
            {
                return this.onCarriageIndicatorField;
            }
            set
            {
                this.onCarriageIndicatorField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 6)]
        public EstimatedDeliveryDateType EstimatedDeliveryDate
        {
            get
            {
                return this.estimatedDeliveryDateField;
            }
            set
            {
                this.estimatedDeliveryDateField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 7)]
        public EstimatedDeliveryTimeType EstimatedDeliveryTime
        {
            get
            {
                return this.estimatedDeliveryTimeField;
            }
            set
            {
                this.estimatedDeliveryTimeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 8)]
        public RequiredDeliveryDateType RequiredDeliveryDate
        {
            get
            {
                return this.requiredDeliveryDateField;
            }
            set
            {
                this.requiredDeliveryDateField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 9)]
        public RequiredDeliveryTimeType RequiredDeliveryTime
        {
            get
            {
                return this.requiredDeliveryTimeField;
            }
            set
            {
                this.requiredDeliveryTimeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 10)]
        public LoadingSequenceIDType LoadingSequenceID
        {
            get
            {
                return this.loadingSequenceIDField;
            }
            set
            {
                this.loadingSequenceIDField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 11)]
        public SuccessiveSequenceIDType SuccessiveSequenceID
        {
            get
            {
                return this.successiveSequenceIDField;
            }
            set
            {
                this.successiveSequenceIDField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 12)]
        public InstructionsType Instructions
        {
            get
            {
                return this.instructionsField;
            }
            set
            {
                this.instructionsField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 13)]
        public DemurrageInstructionsType DemurrageInstructions
        {
            get
            {
                return this.demurrageInstructionsField;
            }
            set
            {
                this.demurrageInstructionsField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
        public PeriodType TransitPeriod
        {
            get
            {
                return this.transitPeriodField;
            }
            set
            {
                this.transitPeriodField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CarrierParty", Order = 15)]
        public PartyType[] CarrierParty
        {
            get
            {
                return this.carrierPartyField;
            }
            set
            {
                this.carrierPartyField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 16)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 17)]
        public LocationType1 LoadingPortLocation
        {
            get
            {
                return this.loadingPortLocationField;
            }
            set
            {
                this.loadingPortLocationField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 18)]
        public LocationType1 UnloadingPortLocation
        {
            get
            {
                return this.unloadingPortLocationField;
            }
            set
            {
                this.unloadingPortLocationField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 19)]
        public LocationType1 TransshipPortLocation
        {
            get
            {
                return this.transshipPortLocationField;
            }
            set
            {
                this.transshipPortLocationField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 20)]
        public TransportEventType LoadingTransportEvent
        {
            get
            {
                return this.loadingTransportEventField;
            }
            set
            {
                this.loadingTransportEventField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 21)]
        public TransportEventType ExaminationTransportEvent
        {
            get
            {
                return this.examinationTransportEventField;
            }
            set
            {
                this.examinationTransportEventField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 22)]
        public TransportEventType AvailabilityTransportEvent
        {
            get
            {
                return this.availabilityTransportEventField;
            }
            set
            {
                this.availabilityTransportEventField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 23)]
        public TransportEventType ExportationTransportEvent
        {
            get
            {
                return this.exportationTransportEventField;
            }
            set
            {
                this.exportationTransportEventField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 24)]
        public TransportEventType DischargeTransportEvent
        {
            get
            {
                return this.dischargeTransportEventField;
            }
            set
            {
                this.dischargeTransportEventField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 25)]
        public TransportEventType WarehousingTransportEvent
        {
            get
            {
                return this.warehousingTransportEventField;
            }
            set
            {
                this.warehousingTransportEventField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 26)]
        public TransportEventType TakeoverTransportEvent
        {
            get
            {
                return this.takeoverTransportEventField;
            }
            set
            {
                this.takeoverTransportEventField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 27)]
        public TransportEventType OptionalTakeoverTransportEvent
        {
            get
            {
                return this.optionalTakeoverTransportEventField;
            }
            set
            {
                this.optionalTakeoverTransportEventField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 28)]
        public TransportEventType DropoffTransportEvent
        {
            get
            {
                return this.dropoffTransportEventField;
            }
            set
            {
                this.dropoffTransportEventField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 29)]
        public TransportEventType ActualPickupTransportEvent
        {
            get
            {
                return this.actualPickupTransportEventField;
            }
            set
            {
                this.actualPickupTransportEventField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 30)]
        public TransportEventType DeliveryTransportEvent
        {
            get
            {
                return this.deliveryTransportEventField;
            }
            set
            {
                this.deliveryTransportEventField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 31)]
        public TransportEventType ReceiptTransportEvent
        {
            get
            {
                return this.receiptTransportEventField;
            }
            set
            {
                this.receiptTransportEventField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 32)]
        public TransportEventType StorageTransportEvent
        {
            get
            {
                return this.storageTransportEventField;
            }
            set
            {
                this.storageTransportEventField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 33)]
        public TransportEventType AcceptanceTransportEvent
        {
            get
            {
                return this.acceptanceTransportEventField;
            }
            set
            {
                this.acceptanceTransportEventField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 34)]
        public PartyType TerminalOperatorParty
        {
            get
            {
                return this.terminalOperatorPartyField;
            }
            set
            {
                this.terminalOperatorPartyField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 35)]
        public PartyType CustomsAgentParty
        {
            get
            {
                return this.customsAgentPartyField;
            }
            set
            {
                this.customsAgentPartyField = value;
                
            }
        }

        
    }
}