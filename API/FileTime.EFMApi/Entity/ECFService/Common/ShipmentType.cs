namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class ShipmentType
    {

        private IDType idField;

        private ShippingPriorityLevelCodeType shippingPriorityLevelCodeField;

        private HandlingCodeType handlingCodeField;

        private HandlingInstructionsType handlingInstructionsField;

        private InformationType informationField;

        private GrossWeightMeasureType grossWeightMeasureField;

        private NetWeightMeasureType netWeightMeasureField;

        private NetNetWeightMeasureType netNetWeightMeasureField;

        private GrossVolumeMeasureType grossVolumeMeasureField;

        private NetVolumeMeasureType netVolumeMeasureField;

        private TotalGoodsItemQuantityType totalGoodsItemQuantityField;

        private TotalTransportHandlingUnitQuantityType totalTransportHandlingUnitQuantityField;

        private InsuranceValueAmountType insuranceValueAmountField;

        private DeclaredCustomsValueAmountType declaredCustomsValueAmountField;

        private DeclaredForCarriageValueAmountType declaredForCarriageValueAmountField;

        private DeclaredStatisticsValueAmountType declaredStatisticsValueAmountField;

        private FreeOnBoardValueAmountType freeOnBoardValueAmountField;

        private SpecialInstructionsType[] specialInstructionsField;

        private DeliveryInstructionsType[] deliveryInstructionsField;

        private SplitConsignmentIndicatorType splitConsignmentIndicatorField;

        private ConsignmentQuantityType consignmentQuantityField;

        private ConsignmentType[] consignmentField;

        private GoodsItemType[] goodsItemField;

        private ShipmentStageType[] shipmentStageField;

        private DeliveryType deliveryField;

        private TransportHandlingUnitType[] transportHandlingUnitField;

        private AddressType returnAddressField;

        private AddressType originAddressField;

        private LocationType1 firstArrivalPortLocationField;

        private LocationType1 lastExitPortLocationField;

        private CountryType exportCountryField;

        private AllowanceChargeType[] freightAllowanceChargeField;

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
        public ShippingPriorityLevelCodeType ShippingPriorityLevelCode
        {
            get
            {
                return this.shippingPriorityLevelCodeField;
            }
            set
            {
                this.shippingPriorityLevelCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public HandlingCodeType HandlingCode
        {
            get
            {
                return this.handlingCodeField;
            }
            set
            {
                this.handlingCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public HandlingInstructionsType HandlingInstructions
        {
            get
            {
                return this.handlingInstructionsField;
            }
            set
            {
                this.handlingInstructionsField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 5)]
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 6)]
        public NetWeightMeasureType NetWeightMeasure
        {
            get
            {
                return this.netWeightMeasureField;
            }
            set
            {
                this.netWeightMeasureField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 7)]
        public NetNetWeightMeasureType NetNetWeightMeasure
        {
            get
            {
                return this.netNetWeightMeasureField;
            }
            set
            {
                this.netNetWeightMeasureField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 8)]
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 9)]
        public NetVolumeMeasureType NetVolumeMeasure
        {
            get
            {
                return this.netVolumeMeasureField;
            }
            set
            {
                this.netVolumeMeasureField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 10)]
        public TotalGoodsItemQuantityType TotalGoodsItemQuantity
        {
            get
            {
                return this.totalGoodsItemQuantityField;
            }
            set
            {
                this.totalGoodsItemQuantityField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 11)]
        public TotalTransportHandlingUnitQuantityType TotalTransportHandlingUnitQuantity
        {
            get
            {
                return this.totalTransportHandlingUnitQuantityField;
            }
            set
            {
                this.totalTransportHandlingUnitQuantityField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 12)]
        public InsuranceValueAmountType InsuranceValueAmount
        {
            get
            {
                return this.insuranceValueAmountField;
            }
            set
            {
                this.insuranceValueAmountField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 13)]
        public DeclaredCustomsValueAmountType DeclaredCustomsValueAmount
        {
            get
            {
                return this.declaredCustomsValueAmountField;
            }
            set
            {
                this.declaredCustomsValueAmountField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 14)]
        public DeclaredForCarriageValueAmountType DeclaredForCarriageValueAmount
        {
            get
            {
                return this.declaredForCarriageValueAmountField;
            }
            set
            {
                this.declaredForCarriageValueAmountField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 15)]
        public DeclaredStatisticsValueAmountType DeclaredStatisticsValueAmount
        {
            get
            {
                return this.declaredStatisticsValueAmountField;
            }
            set
            {
                this.declaredStatisticsValueAmountField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 16)]
        public FreeOnBoardValueAmountType FreeOnBoardValueAmount
        {
            get
            {
                return this.freeOnBoardValueAmountField;
            }
            set
            {
                this.freeOnBoardValueAmountField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SpecialInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 17)]
        public SpecialInstructionsType[] SpecialInstructions
        {
            get
            {
                return this.specialInstructionsField;
            }
            set
            {
                this.specialInstructionsField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DeliveryInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 18)]
        public DeliveryInstructionsType[] DeliveryInstructions
        {
            get
            {
                return this.deliveryInstructionsField;
            }
            set
            {
                this.deliveryInstructionsField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 19)]
        public SplitConsignmentIndicatorType SplitConsignmentIndicator
        {
            get
            {
                return this.splitConsignmentIndicatorField;
            }
            set
            {
                this.splitConsignmentIndicatorField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 20)]
        public ConsignmentQuantityType ConsignmentQuantity
        {
            get
            {
                return this.consignmentQuantityField;
            }
            set
            {
                this.consignmentQuantityField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Consignment", Order = 21)]
        public ConsignmentType[] Consignment
        {
            get
            {
                return this.consignmentField;
            }
            set
            {
                this.consignmentField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("GoodsItem", Order = 22)]
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
        [System.Xml.Serialization.XmlElementAttribute("ShipmentStage", Order = 23)]
        public ShipmentStageType[] ShipmentStage
        {
            get
            {
                return this.shipmentStageField;
            }
            set
            {
                this.shipmentStageField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 24)]
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
        [System.Xml.Serialization.XmlElementAttribute("TransportHandlingUnit", Order = 25)]
        public TransportHandlingUnitType[] TransportHandlingUnit
        {
            get
            {
                return this.transportHandlingUnitField;
            }
            set
            {
                this.transportHandlingUnitField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 26)]
        public AddressType ReturnAddress
        {
            get
            {
                return this.returnAddressField;
            }
            set
            {
                this.returnAddressField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 27)]
        public AddressType OriginAddress
        {
            get
            {
                return this.originAddressField;
            }
            set
            {
                this.originAddressField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 28)]
        public LocationType1 FirstArrivalPortLocation
        {
            get
            {
                return this.firstArrivalPortLocationField;
            }
            set
            {
                this.firstArrivalPortLocationField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 29)]
        public LocationType1 LastExitPortLocation
        {
            get
            {
                return this.lastExitPortLocationField;
            }
            set
            {
                this.lastExitPortLocationField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 30)]
        public CountryType ExportCountry
        {
            get
            {
                return this.exportCountryField;
            }
            set
            {
                this.exportCountryField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FreightAllowanceCharge", Order = 31)]
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

        

    }
}