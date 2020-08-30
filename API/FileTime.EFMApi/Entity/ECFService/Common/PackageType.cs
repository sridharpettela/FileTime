namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class PackageType
    {

        private IDType idField;

        private QuantityType2 quantityField;

        private ReturnableMaterialIndicatorType returnableMaterialIndicatorField;

        private PackageLevelCodeType packageLevelCodeField;

        private PackagingTypeCodeType packagingTypeCodeField;

        private PackingMaterialType[] packingMaterialField;

        private TraceIDType traceIDField;

        private PackageType[] containedPackageField;

        private TransportEquipmentType containingTransportEquipmentField;

        private GoodsItemType[] goodsItemField;

        private DimensionType[] measurementDimensionField;

        private DeliveryUnitType[] deliveryUnitField;

        private DeliveryType deliveryField;

        private PickupType pickupField;

        private DespatchType despatchField;

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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public ReturnableMaterialIndicatorType ReturnableMaterialIndicator
        {
            get
            {
                return this.returnableMaterialIndicatorField;
            }
            set
            {
                this.returnableMaterialIndicatorField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public PackageLevelCodeType PackageLevelCode
        {
            get
            {
                return this.packageLevelCodeField;
            }
            set
            {
                this.packageLevelCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
        public PackagingTypeCodeType PackagingTypeCode
        {
            get
            {
                return this.packagingTypeCodeField;
            }
            set
            {
                this.packagingTypeCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PackingMaterial", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 5)]
        public PackingMaterialType[] PackingMaterial
        {
            get
            {
                return this.packingMaterialField;
            }
            set
            {
                this.packingMaterialField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 6)]
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
        [System.Xml.Serialization.XmlElementAttribute("ContainedPackage", Order = 7)]
        public PackageType[] ContainedPackage
        {
            get
            {
                return this.containedPackageField;
            }
            set
            {
                this.containedPackageField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public TransportEquipmentType ContainingTransportEquipment
        {
            get
            {
                return this.containingTransportEquipmentField;
            }
            set
            {
                this.containingTransportEquipmentField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("GoodsItem", Order = 9)]
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
        [System.Xml.Serialization.XmlElementAttribute("MeasurementDimension", Order = 10)]
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
        [System.Xml.Serialization.XmlElementAttribute("DeliveryUnit", Order = 11)]
        public DeliveryUnitType[] DeliveryUnit
        {
            get
            {
                return this.deliveryUnitField;
            }
            set
            {
                this.deliveryUnitField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
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

        

      
    }
}