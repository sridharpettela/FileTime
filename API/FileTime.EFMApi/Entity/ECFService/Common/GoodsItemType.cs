namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class GoodsItemType
    {

        private IDType idField;

        private SequenceNumberIDType sequenceNumberIDField;

        private DescriptionType[] descriptionField;

        private HazardousRiskIndicatorType hazardousRiskIndicatorField;

        private DeclaredCustomsValueAmountType declaredCustomsValueAmountField;

        private DeclaredForCarriageValueAmountType declaredForCarriageValueAmountField;

        private DeclaredStatisticsValueAmountType declaredStatisticsValueAmountField;

        private FreeOnBoardValueAmountType freeOnBoardValueAmountField;

        private InsuranceValueAmountType insuranceValueAmountField;

        private ValueAmountType valueAmountField;

        private GrossWeightMeasureType grossWeightMeasureField;

        private NetWeightMeasureType netWeightMeasureField;

        private NetNetWeightMeasureType netNetWeightMeasureField;

        private ChargeableWeightMeasureType chargeableWeightMeasureField;

        private GrossVolumeMeasureType grossVolumeMeasureField;

        private NetVolumeMeasureType netVolumeMeasureField;

        private QuantityType2 quantityField;

        private PreferenceCriterionCodeType preferenceCriterionCodeField;

        private RequiredCustomsIDType requiredCustomsIDField;

        private CustomsStatusCodeType customsStatusCodeField;

        private CustomsTariffQuantityType customsTariffQuantityField;

        private CustomsImportClassifiedIndicatorType customsImportClassifiedIndicatorField;

        private ChargeableQuantityType chargeableQuantityField;

        private ReturnableQuantityType returnableQuantityField;

        private ItemType1[] itemField;

        private GoodsItemContainerType[] goodsItemContainerField;

        private AllowanceChargeType[] freightAllowanceChargeField;

        private InvoiceLineType[] invoiceLineField;

        private TemperatureType[] temperatureField;

        private GoodsItemType[] containedGoodsItemField;

        private AddressType originAddressField;

        private DeliveryType deliveryField;

        private PickupType pickupField;

        private DespatchType despatchField;

        private DimensionType[] measurementDimensionField;

        private PackageType[] containingPackageField;

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
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public HazardousRiskIndicatorType HazardousRiskIndicator
        {
            get
            {
                return this.hazardousRiskIndicatorField;
            }
            set
            {
                this.hazardousRiskIndicatorField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 5)]
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 6)]
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 7)]
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 8)]
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 9)]
        public ValueAmountType ValueAmount
        {
            get
            {
                return this.valueAmountField;
            }
            set
            {
                this.valueAmountField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 10)]
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 11)]
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 12)]
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 13)]
        public ChargeableWeightMeasureType ChargeableWeightMeasure
        {
            get
            {
                return this.chargeableWeightMeasureField;
            }
            set
            {
                this.chargeableWeightMeasureField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 14)]
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 15)]
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 16)]
        public QuantityType2 Quantity
        {
            get
            {
                return this.quantityField;
            }
            set
            {
                this.quantityField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 17)]
        public PreferenceCriterionCodeType PreferenceCriterionCode
        {
            get
            {
                return this.preferenceCriterionCodeField;
            }
            set
            {
                this.preferenceCriterionCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 18)]
        public RequiredCustomsIDType RequiredCustomsID
        {
            get
            {
                return this.requiredCustomsIDField;
            }
            set
            {
                this.requiredCustomsIDField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 19)]
        public CustomsStatusCodeType CustomsStatusCode
        {
            get
            {
                return this.customsStatusCodeField;
            }
            set
            {
                this.customsStatusCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 20)]
        public CustomsTariffQuantityType CustomsTariffQuantity
        {
            get
            {
                return this.customsTariffQuantityField;
            }
            set
            {
                this.customsTariffQuantityField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 21)]
        public CustomsImportClassifiedIndicatorType CustomsImportClassifiedIndicator
        {
            get
            {
                return this.customsImportClassifiedIndicatorField;
            }
            set
            {
                this.customsImportClassifiedIndicatorField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 22)]
        public ChargeableQuantityType ChargeableQuantity
        {
            get
            {
                return this.chargeableQuantityField;
            }
            set
            {
                this.chargeableQuantityField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 23)]
        public ReturnableQuantityType ReturnableQuantity
        {
            get
            {
                return this.returnableQuantityField;
            }
            set
            {
                this.returnableQuantityField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Item", Order = 24)]
        public ItemType1[] Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("GoodsItemContainer", Order = 25)]
        public GoodsItemContainerType[] GoodsItemContainer
        {
            get
            {
                return this.goodsItemContainerField;
            }
            set
            {
                this.goodsItemContainerField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FreightAllowanceCharge", Order = 26)]
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
        [System.Xml.Serialization.XmlElementAttribute("InvoiceLine", Order = 27)]
        public InvoiceLineType[] InvoiceLine
        {
            get
            {
                return this.invoiceLineField;
            }
            set
            {
                this.invoiceLineField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Temperature", Order = 28)]
        public TemperatureType[] Temperature
        {
            get
            {
                return this.temperatureField;
            }
            set
            {
                this.temperatureField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ContainedGoodsItem", Order = 29)]
        public GoodsItemType[] ContainedGoodsItem
        {
            get
            {
                return this.containedGoodsItemField;
            }
            set
            {
                this.containedGoodsItemField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 30)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 31)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 32)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 33)]
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
        [System.Xml.Serialization.XmlElementAttribute("MeasurementDimension", Order = 34)]
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
        [System.Xml.Serialization.XmlElementAttribute("ContainingPackage", Order = 35)]
        public PackageType[] ContainingPackage
        {
            get
            {
                return this.containingPackageField;
            }
            set
            {
                this.containingPackageField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 36)]
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