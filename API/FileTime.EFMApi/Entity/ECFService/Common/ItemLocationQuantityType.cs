namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class ItemLocationQuantityType
    {

        private LeadTimeMeasureType leadTimeMeasureField;

        private MinimumQuantityType minimumQuantityField;

        private MaximumQuantityType maximumQuantityField;

        private HazardousRiskIndicatorType hazardousRiskIndicatorField;

        private TradingRestrictionsType[] tradingRestrictionsField;

        private AddressType[] applicableTerritoryAddressField;

        private PriceType priceField;

        private DeliveryUnitType[] deliveryUnitField;

        private TaxCategoryType[] applicableTaxCategoryField;

        private PackageType packageField;

        private AllowanceChargeType[] allowanceChargeField;

        private DependentPriceReferenceType dependentPriceReferenceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public LeadTimeMeasureType LeadTimeMeasure
        {
            get
            {
                return this.leadTimeMeasureField;
            }
            set
            {
                this.leadTimeMeasureField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public MinimumQuantityType MinimumQuantity
        {
            get
            {
                return this.minimumQuantityField;
            }
            set
            {
                this.minimumQuantityField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public MaximumQuantityType MaximumQuantity
        {
            get
            {
                return this.maximumQuantityField;
            }
            set
            {
                this.maximumQuantityField = value;
                
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
        [System.Xml.Serialization.XmlElementAttribute("TradingRestrictions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
        public TradingRestrictionsType[] TradingRestrictions
        {
            get
            {
                return this.tradingRestrictionsField;
            }
            set
            {
                this.tradingRestrictionsField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ApplicableTerritoryAddress", Order = 5)]
        public AddressType[] ApplicableTerritoryAddress
        {
            get
            {
                return this.applicableTerritoryAddressField;
            }
            set
            {
                this.applicableTerritoryAddressField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public PriceType Price
        {
            get
            {
                return this.priceField;
            }
            set
            {
                this.priceField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DeliveryUnit", Order = 7)]
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
        [System.Xml.Serialization.XmlElementAttribute("ApplicableTaxCategory", Order = 8)]
        public TaxCategoryType[] ApplicableTaxCategory
        {
            get
            {
                return this.applicableTaxCategoryField;
            }
            set
            {
                this.applicableTaxCategoryField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public PackageType Package
        {
            get
            {
                return this.packageField;
            }
            set
            {
                this.packageField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AllowanceCharge", Order = 10)]
        public AllowanceChargeType[] AllowanceCharge
        {
            get
            {
                return this.allowanceChargeField;
            }
            set
            {
                this.allowanceChargeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public DependentPriceReferenceType DependentPriceReference
        {
            get
            {
                return this.dependentPriceReferenceField;
            }
            set
            {
                this.dependentPriceReferenceField = value;
                
            }
        }

        

       
    }
}