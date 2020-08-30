namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class TransportHandlingUnitType
    {

        private IDType idField;

        private TransportHandlingUnitTypeCodeType transportHandlingUnitTypeCodeField;

        private HandlingCodeType handlingCodeField;

        private HandlingInstructionsType handlingInstructionsField;

        private HazardousRiskIndicatorType hazardousRiskIndicatorField;

        private TotalGoodsItemQuantityType totalGoodsItemQuantityField;

        private TotalPackageQuantityType totalPackageQuantityField;

        private DamageRemarksType[] damageRemarksField;

        private ShippingMarksType[] shippingMarksField;

        private DespatchLineType[] handlingUnitDespatchLineField;

        private PackageType[] actualPackageField;

        private ReceiptLineType[] receivedHandlingUnitReceiptLineField;

        private TransportEquipmentType[] transportEquipmentField;

        private TransportMeansType[] transportMeansField;

        private HazardousGoodsTransitType[] hazardousGoodsTransitField;

        private DimensionType[] measurementDimensionField;

        private TemperatureType minimumTemperatureField;

        private TemperatureType maximumTemperatureField;

        private GoodsItemType[] goodsItemField;

        private DimensionType floorSpaceMeasurementDimensionField;

        private DimensionType palletSpaceMeasurementDimensionField;

        private DocumentReferenceType[] shipmentDocumentReferenceField;

        private StatusType1[] statusField;

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
        public TransportHandlingUnitTypeCodeType TransportHandlingUnitTypeCode
        {
            get
            {
                return this.transportHandlingUnitTypeCodeField;
            }
            set
            {
                this.transportHandlingUnitTypeCodeField = value;
                
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 5)]
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 6)]
        public TotalPackageQuantityType TotalPackageQuantity
        {
            get
            {
                return this.totalPackageQuantityField;
            }
            set
            {
                this.totalPackageQuantityField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DamageRemarks", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 7)]
        public DamageRemarksType[] DamageRemarks
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
        [System.Xml.Serialization.XmlElementAttribute("ShippingMarks", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 8)]
        public ShippingMarksType[] ShippingMarks
        {
            get
            {
                return this.shippingMarksField;
            }
            set
            {
                this.shippingMarksField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("HandlingUnitDespatchLine", Order = 9)]
        public DespatchLineType[] HandlingUnitDespatchLine
        {
            get
            {
                return this.handlingUnitDespatchLineField;
            }
            set
            {
                this.handlingUnitDespatchLineField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ActualPackage", Order = 10)]
        public PackageType[] ActualPackage
        {
            get
            {
                return this.actualPackageField;
            }
            set
            {
                this.actualPackageField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ReceivedHandlingUnitReceiptLine", Order = 11)]
        public ReceiptLineType[] ReceivedHandlingUnitReceiptLine
        {
            get
            {
                return this.receivedHandlingUnitReceiptLineField;
            }
            set
            {
                this.receivedHandlingUnitReceiptLineField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TransportEquipment", Order = 12)]
        public TransportEquipmentType[] TransportEquipment
        {
            get
            {
                return this.transportEquipmentField;
            }
            set
            {
                this.transportEquipmentField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TransportMeans", Order = 13)]
        public TransportMeansType[] TransportMeans
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
        [System.Xml.Serialization.XmlElementAttribute("HazardousGoodsTransit", Order = 14)]
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
        [System.Xml.Serialization.XmlElementAttribute("MeasurementDimension", Order = 15)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 16)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 17)]
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
        [System.Xml.Serialization.XmlElementAttribute("GoodsItem", Order = 18)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 19)]
        public DimensionType FloorSpaceMeasurementDimension
        {
            get
            {
                return this.floorSpaceMeasurementDimensionField;
            }
            set
            {
                this.floorSpaceMeasurementDimensionField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 20)]
        public DimensionType PalletSpaceMeasurementDimension
        {
            get
            {
                return this.palletSpaceMeasurementDimensionField;
            }
            set
            {
                this.palletSpaceMeasurementDimensionField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ShipmentDocumentReference", Order = 21)]
        public DocumentReferenceType[] ShipmentDocumentReference
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

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Status", Order = 22)]
        public StatusType1[] Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
                
            }
        }

     
    }
}