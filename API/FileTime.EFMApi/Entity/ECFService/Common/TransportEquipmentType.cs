namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class TransportEquipmentType
    {

        private IDType idField;

        private ReferencedConsignmentIDType referencedConsignmentIDField;

        private TransportEquipmentTypeCodeType transportEquipmentTypeCodeField;

        private ProviderTypeCodeType providerTypeCodeField;

        private OwnerTypeCodeType ownerTypeCodeField;

        private SizeTypeCodeType sizeTypeCodeField;

        private DispositionCodeType dispositionCodeField;

        private FullnessIndicationCodeType fullnessIndicationCodeField;

        private RefrigerationOnIndicatorType refrigerationOnIndicatorField;

        private InformationType informationField;

        private ReturnabilityIndicatorType returnabilityIndicatorField;

        private LegalStatusIndicatorType legalStatusIndicatorField;

        private AirFlowPercentType airFlowPercentField;

        private HumidityPercentType humidityPercentField;

        private AnimalFoodApprovedIndicatorType animalFoodApprovedIndicatorField;

        private HumanFoodApprovedIndicatorType humanFoodApprovedIndicatorField;

        private DangerousGoodsApprovedIndicatorType dangerousGoodsApprovedIndicatorField;

        private RefrigeratedIndicatorType refrigeratedIndicatorField;

        private CharacteristicsType characteristicsField;

        private DamageRemarksType damageRemarksField;

        private DescriptionType descriptionField;

        private SpecialTransportRequirmentsType specialTransportRequirmentsField;

        private GrossWeightMeasureType grossWeightMeasureField;

        private GrossVolumeMeasureType grossVolumeMeasureField;

        private TareWeightMeasureType tareWeightMeasureField;

        private TrackingDeviceCodeType trackingDeviceCodeField;

        private PowerIndicatorType powerIndicatorField;

        private TraceIDType traceIDField;

        private DimensionType[] measurementDimensionField;

        private TransportEquipmentSealType[] transportEquipmentSealField;

        private TemperatureType minimumTemperatureField;

        private TemperatureType maximumTemperatureField;

        private PartyType providerPartyField;

        private PartyType loadingProofPartyField;

        private SupplierPartyType supplierPartyField;

        private PartyType ownerPartyField;

        private PartyType operatingPartyField;

        private LocationType1 loadingLocationField;

        private LocationType1 unloadingLocationField;

        private LocationType1 storageLocationField;

        private TransportEventType[] positioningTransportEventField;

        private TransportEventType[] quarantineTransportEventField;

        private TransportEventType[] deliveryTransportEventField;

        private TransportEventType[] pickupTransportEventField;

        private TransportEventType[] handlingTransportEventField;

        private TransportEventType[] loadingTransportEventField;

        private TransportEventType[] transportEventField;

        private TransportMeansType applicableTransportMeansField;

        private TradingTermsType[] haulageTradingTermsField;

        private HazardousGoodsTransitType[] hazardousGoodsTransitField;

        private TransportHandlingUnitType[] packagedTransportHandlingUnitField;

        private AllowanceChargeType[] serviceAllowanceChargeField;

        private AllowanceChargeType[] freightAllowanceChargeField;

        private TransportEquipmentType[] attachedTransportEquipmentField;

        private GoodsItemType[] goodsItemField;

        private DeliveryType deliveryField;

        private TransportEquipmentType[] containedInTransportEquipmentField;

        private PickupType pickupField;

        private DespatchType despatchField;

        private DocumentReferenceType shipmentDocumentReferenceField;

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
        public ReferencedConsignmentIDType ReferencedConsignmentID
        {
            get
            {
                return this.referencedConsignmentIDField;
            }
            set
            {
                this.referencedConsignmentIDField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public TransportEquipmentTypeCodeType TransportEquipmentTypeCode
        {
            get
            {
                return this.transportEquipmentTypeCodeField;
            }
            set
            {
                this.transportEquipmentTypeCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public ProviderTypeCodeType ProviderTypeCode
        {
            get
            {
                return this.providerTypeCodeField;
            }
            set
            {
                this.providerTypeCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
        public OwnerTypeCodeType OwnerTypeCode
        {
            get
            {
                return this.ownerTypeCodeField;
            }
            set
            {
                this.ownerTypeCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 5)]
        public SizeTypeCodeType SizeTypeCode
        {
            get
            {
                return this.sizeTypeCodeField;
            }
            set
            {
                this.sizeTypeCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 6)]
        public DispositionCodeType DispositionCode
        {
            get
            {
                return this.dispositionCodeField;
            }
            set
            {
                this.dispositionCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 7)]
        public FullnessIndicationCodeType FullnessIndicationCode
        {
            get
            {
                return this.fullnessIndicationCodeField;
            }
            set
            {
                this.fullnessIndicationCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 8)]
        public RefrigerationOnIndicatorType RefrigerationOnIndicator
        {
            get
            {
                return this.refrigerationOnIndicatorField;
            }
            set
            {
                this.refrigerationOnIndicatorField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 9)]
        public InformationType Information
        {
            get
            {
                return this.informationField;
            }
            set
            {
                this.informationField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 10)]
        public ReturnabilityIndicatorType ReturnabilityIndicator
        {
            get
            {
                return this.returnabilityIndicatorField;
            }
            set
            {
                this.returnabilityIndicatorField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 11)]
        public LegalStatusIndicatorType LegalStatusIndicator
        {
            get
            {
                return this.legalStatusIndicatorField;
            }
            set
            {
                this.legalStatusIndicatorField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 12)]
        public AirFlowPercentType AirFlowPercent
        {
            get
            {
                return this.airFlowPercentField;
            }
            set
            {
                this.airFlowPercentField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 13)]
        public HumidityPercentType HumidityPercent
        {
            get
            {
                return this.humidityPercentField;
            }
            set
            {
                this.humidityPercentField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 14)]
        public AnimalFoodApprovedIndicatorType AnimalFoodApprovedIndicator
        {
            get
            {
                return this.animalFoodApprovedIndicatorField;
            }
            set
            {
                this.animalFoodApprovedIndicatorField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 15)]
        public HumanFoodApprovedIndicatorType HumanFoodApprovedIndicator
        {
            get
            {
                return this.humanFoodApprovedIndicatorField;
            }
            set
            {
                this.humanFoodApprovedIndicatorField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 16)]
        public DangerousGoodsApprovedIndicatorType DangerousGoodsApprovedIndicator
        {
            get
            {
                return this.dangerousGoodsApprovedIndicatorField;
            }
            set
            {
                this.dangerousGoodsApprovedIndicatorField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 17)]
        public RefrigeratedIndicatorType RefrigeratedIndicator
        {
            get
            {
                return this.refrigeratedIndicatorField;
            }
            set
            {
                this.refrigeratedIndicatorField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 18)]
        public CharacteristicsType Characteristics
        {
            get
            {
                return this.characteristicsField;
            }
            set
            {
                this.characteristicsField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 19)]
        public DamageRemarksType DamageRemarks
        {
            get
            {
                return this.damageRemarksField;
            }
            set
            {
                this.damageRemarksField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 20)]
        public DescriptionType Description
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 21)]
        public SpecialTransportRequirmentsType SpecialTransportRequirments
        {
            get
            {
                return this.specialTransportRequirmentsField;
            }
            set
            {
                this.specialTransportRequirmentsField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 22)]
        public GrossWeightMeasureType GrossWeightMeasure
        {
            get
            {
                return this.grossWeightMeasureField;
            }
            set
            {
                this.grossWeightMeasureField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 23)]
        public GrossVolumeMeasureType GrossVolumeMeasure
        {
            get
            {
                return this.grossVolumeMeasureField;
            }
            set
            {
                this.grossVolumeMeasureField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 24)]
        public TareWeightMeasureType TareWeightMeasure
        {
            get
            {
                return this.tareWeightMeasureField;
            }
            set
            {
                this.tareWeightMeasureField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 25)]
        public TrackingDeviceCodeType TrackingDeviceCode
        {
            get
            {
                return this.trackingDeviceCodeField;
            }
            set
            {
                this.trackingDeviceCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 26)]
        public PowerIndicatorType PowerIndicator
        {
            get
            {
                return this.powerIndicatorField;
            }
            set
            {
                this.powerIndicatorField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 27)]
        public TraceIDType TraceID
        {
            get
            {
                return this.traceIDField;
            }
            set
            {
                this.traceIDField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MeasurementDimension", Order = 28)]
        public DimensionType[] MeasurementDimension
        {
            get
            {
                return this.measurementDimensionField;
            }
            set
            {
                this.measurementDimensionField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TransportEquipmentSeal", Order = 29)]
        public TransportEquipmentSealType[] TransportEquipmentSeal
        {
            get
            {
                return this.transportEquipmentSealField;
            }
            set
            {
                this.transportEquipmentSealField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 30)]
        public TemperatureType MinimumTemperature
        {
            get
            {
                return this.minimumTemperatureField;
            }
            set
            {
                this.minimumTemperatureField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 31)]
        public TemperatureType MaximumTemperature
        {
            get
            {
                return this.maximumTemperatureField;
            }
            set
            {
                this.maximumTemperatureField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 32)]
        public PartyType ProviderParty
        {
            get
            {
                return this.providerPartyField;
            }
            set
            {
                this.providerPartyField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 33)]
        public PartyType LoadingProofParty
        {
            get
            {
                return this.loadingProofPartyField;
            }
            set
            {
                this.loadingProofPartyField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 34)]
        public SupplierPartyType SupplierParty
        {
            get
            {
                return this.supplierPartyField;
            }
            set
            {
                this.supplierPartyField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 35)]
        public PartyType OwnerParty
        {
            get
            {
                return this.ownerPartyField;
            }
            set
            {
                this.ownerPartyField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 36)]
        public PartyType OperatingParty
        {
            get
            {
                return this.operatingPartyField;
            }
            set
            {
                this.operatingPartyField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 37)]
        public LocationType1 LoadingLocation
        {
            get
            {
                return this.loadingLocationField;
            }
            set
            {
                this.loadingLocationField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 38)]
        public LocationType1 UnloadingLocation
        {
            get
            {
                return this.unloadingLocationField;
            }
            set
            {
                this.unloadingLocationField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 39)]
        public LocationType1 StorageLocation
        {
            get
            {
                return this.storageLocationField;
            }
            set
            {
                this.storageLocationField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PositioningTransportEvent", Order = 40)]
        public TransportEventType[] PositioningTransportEvent
        {
            get
            {
                return this.positioningTransportEventField;
            }
            set
            {
                this.positioningTransportEventField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("QuarantineTransportEvent", Order = 41)]
        public TransportEventType[] QuarantineTransportEvent
        {
            get
            {
                return this.quarantineTransportEventField;
            }
            set
            {
                this.quarantineTransportEventField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DeliveryTransportEvent", Order = 42)]
        public TransportEventType[] DeliveryTransportEvent
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
        [System.Xml.Serialization.XmlElementAttribute("PickupTransportEvent", Order = 43)]
        public TransportEventType[] PickupTransportEvent
        {
            get
            {
                return this.pickupTransportEventField;
            }
            set
            {
                this.pickupTransportEventField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("HandlingTransportEvent", Order = 44)]
        public TransportEventType[] HandlingTransportEvent
        {
            get
            {
                return this.handlingTransportEventField;
            }
            set
            {
                this.handlingTransportEventField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LoadingTransportEvent", Order = 45)]
        public TransportEventType[] LoadingTransportEvent
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
        [System.Xml.Serialization.XmlElementAttribute("TransportEvent", Order = 46)]
        public TransportEventType[] TransportEvent
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 47)]
        public TransportMeansType ApplicableTransportMeans
        {
            get
            {
                return this.applicableTransportMeansField;
            }
            set
            {
                this.applicableTransportMeansField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("HaulageTradingTerms", Order = 48)]
        public TradingTermsType[] HaulageTradingTerms
        {
            get
            {
                return this.haulageTradingTermsField;
            }
            set
            {
                this.haulageTradingTermsField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("HazardousGoodsTransit", Order = 49)]
        public HazardousGoodsTransitType[] HazardousGoodsTransit
        {
            get
            {
                return this.hazardousGoodsTransitField;
            }
            set
            {
                this.hazardousGoodsTransitField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PackagedTransportHandlingUnit", Order = 50)]
        public TransportHandlingUnitType[] PackagedTransportHandlingUnit
        {
            get
            {
                return this.packagedTransportHandlingUnitField;
            }
            set
            {
                this.packagedTransportHandlingUnitField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ServiceAllowanceCharge", Order = 51)]
        public AllowanceChargeType[] ServiceAllowanceCharge
        {
            get
            {
                return this.serviceAllowanceChargeField;
            }
            set
            {
                this.serviceAllowanceChargeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FreightAllowanceCharge", Order = 52)]
        public AllowanceChargeType[] FreightAllowanceCharge
        {
            get
            {
                return this.freightAllowanceChargeField;
            }
            set
            {
                this.freightAllowanceChargeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AttachedTransportEquipment", Order = 53)]
        public TransportEquipmentType[] AttachedTransportEquipment
        {
            get
            {
                return this.attachedTransportEquipmentField;
            }
            set
            {
                this.attachedTransportEquipmentField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("GoodsItem", Order = 54)]
        public GoodsItemType[] GoodsItem
        {
            get
            {
                return this.goodsItemField;
            }
            set
            {
                this.goodsItemField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 55)]
        public DeliveryType Delivery
        {
            get
            {
                return this.deliveryField;
            }
            set
            {
                this.deliveryField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ContainedInTransportEquipment", Order = 56)]
        public TransportEquipmentType[] ContainedInTransportEquipment
        {
            get
            {
                return this.containedInTransportEquipmentField;
            }
            set
            {
                this.containedInTransportEquipmentField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 57)]
        public PickupType Pickup
        {
            get
            {
                return this.pickupField;
            }
            set
            {
                this.pickupField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 58)]
        public DespatchType Despatch
        {
            get
            {
                return this.despatchField;
            }
            set
            {
                this.despatchField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 59)]
        public DocumentReferenceType ShipmentDocumentReference
        {
            get
            {
                return this.shipmentDocumentReferenceField;
            }
            set
            {
                this.shipmentDocumentReferenceField = value;
                
            }
        }

    }
}