namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ItemType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class ItemType1
    {

        private DescriptionType[] descriptionField;

        private PackQuantityType packQuantityField;

        private PackSizeNumericType packSizeNumericField;

        private CatalogueIndicatorType catalogueIndicatorField;

        private NameType1 nameField;

        private HazardousRiskIndicatorType hazardousRiskIndicatorField;

        private AdditionalInformationType additionalInformationField;

        private KeywordType[] keywordField;

        private BrandNameType[] brandNameField;

        private ModelNameType[] modelNameField;

        private ItemIdentificationType buyersItemIdentificationField;

        private ItemIdentificationType sellersItemIdentificationField;

        private ItemIdentificationType[] manufacturersItemIdentificationField;

        private ItemIdentificationType standardItemIdentificationField;

        private ItemIdentificationType catalogueItemIdentificationField;

        private ItemIdentificationType[] additionalItemIdentificationField;

        private DocumentReferenceType catalogueDocumentReferenceField;

        private DocumentReferenceType[] itemSpecificationDocumentReferenceField;

        private CountryType originCountryField;

        private CommodityClassificationType[] commodityClassificationField;

        private TransactionConditionsType[] transactionConditionsField;

        private HazardousItemType[] hazardousItemField;

        private TaxCategoryType[] classifiedTaxCategoryField;

        private ItemPropertyType[] additionalItemPropertyField;

        private PartyType[] manufacturerPartyField;

        private PartyType informationContentProviderPartyField;

        private AddressType[] originAddressField;

        private ItemInstanceType[] itemInstanceField;

        private CertificateType[] certificateField;

        private DimensionType[] dimensionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public PackQuantityType PackQuantity
        {
            get
            {
                return this.packQuantityField;
            }
            set
            {
                this.packQuantityField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public PackSizeNumericType PackSizeNumeric
        {
            get
            {
                return this.packSizeNumericField;
            }
            set
            {
                this.packSizeNumericField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public CatalogueIndicatorType CatalogueIndicator
        {
            get
            {
                return this.catalogueIndicatorField;
            }
            set
            {
                this.catalogueIndicatorField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
        public NameType1 Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 5)]
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 6)]
        public AdditionalInformationType AdditionalInformation
        {
            get
            {
                return this.additionalInformationField;
            }
            set
            {
                this.additionalInformationField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Keyword", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 7)]
        public KeywordType[] Keyword
        {
            get
            {
                return this.keywordField;
            }
            set
            {
                this.keywordField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BrandName", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 8)]
        public BrandNameType[] BrandName
        {
            get
            {
                return this.brandNameField;
            }
            set
            {
                this.brandNameField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ModelName", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 9)]
        public ModelNameType[] ModelName
        {
            get
            {
                return this.modelNameField;
            }
            set
            {
                this.modelNameField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public ItemIdentificationType BuyersItemIdentification
        {
            get
            {
                return this.buyersItemIdentificationField;
            }
            set
            {
                this.buyersItemIdentificationField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public ItemIdentificationType SellersItemIdentification
        {
            get
            {
                return this.sellersItemIdentificationField;
            }
            set
            {
                this.sellersItemIdentificationField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ManufacturersItemIdentification", Order = 12)]
        public ItemIdentificationType[] ManufacturersItemIdentification
        {
            get
            {
                return this.manufacturersItemIdentificationField;
            }
            set
            {
                this.manufacturersItemIdentificationField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
        public ItemIdentificationType StandardItemIdentification
        {
            get
            {
                return this.standardItemIdentificationField;
            }
            set
            {
                this.standardItemIdentificationField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
        public ItemIdentificationType CatalogueItemIdentification
        {
            get
            {
                return this.catalogueItemIdentificationField;
            }
            set
            {
                this.catalogueItemIdentificationField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AdditionalItemIdentification", Order = 15)]
        public ItemIdentificationType[] AdditionalItemIdentification
        {
            get
            {
                return this.additionalItemIdentificationField;
            }
            set
            {
                this.additionalItemIdentificationField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 16)]
        public DocumentReferenceType CatalogueDocumentReference
        {
            get
            {
                return this.catalogueDocumentReferenceField;
            }
            set
            {
                this.catalogueDocumentReferenceField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemSpecificationDocumentReference", Order = 17)]
        public DocumentReferenceType[] ItemSpecificationDocumentReference
        {
            get
            {
                return this.itemSpecificationDocumentReferenceField;
            }
            set
            {
                this.itemSpecificationDocumentReferenceField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 18)]
        public CountryType OriginCountry
        {
            get
            {
                return this.originCountryField;
            }
            set
            {
                this.originCountryField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CommodityClassification", Order = 19)]
        public CommodityClassificationType[] CommodityClassification
        {
            get
            {
                return this.commodityClassificationField;
            }
            set
            {
                this.commodityClassificationField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TransactionConditions", Order = 20)]
        public TransactionConditionsType[] TransactionConditions
        {
            get
            {
                return this.transactionConditionsField;
            }
            set
            {
                this.transactionConditionsField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("HazardousItem", Order = 21)]
        public HazardousItemType[] HazardousItem
        {
            get
            {
                return this.hazardousItemField;
            }
            set
            {
                this.hazardousItemField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ClassifiedTaxCategory", Order = 22)]
        public TaxCategoryType[] ClassifiedTaxCategory
        {
            get
            {
                return this.classifiedTaxCategoryField;
            }
            set
            {
                this.classifiedTaxCategoryField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AdditionalItemProperty", Order = 23)]
        public ItemPropertyType[] AdditionalItemProperty
        {
            get
            {
                return this.additionalItemPropertyField;
            }
            set
            {
                this.additionalItemPropertyField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ManufacturerParty", Order = 24)]
        public PartyType[] ManufacturerParty
        {
            get
            {
                return this.manufacturerPartyField;
            }
            set
            {
                this.manufacturerPartyField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 25)]
        public PartyType InformationContentProviderParty
        {
            get
            {
                return this.informationContentProviderPartyField;
            }
            set
            {
                this.informationContentProviderPartyField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OriginAddress", Order = 26)]
        public AddressType[] OriginAddress
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
        [System.Xml.Serialization.XmlElementAttribute("ItemInstance", Order = 27)]
        public ItemInstanceType[] ItemInstance
        {
            get
            {
                return this.itemInstanceField;
            }
            set
            {
                this.itemInstanceField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Certificate", Order = 28)]
        public CertificateType[] Certificate
        {
            get
            {
                return this.certificateField;
            }
            set
            {
                this.certificateField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Dimension", Order = 29)]
        public DimensionType[] Dimension
        {
            get
            {
                return this.dimensionField;
            }
            set
            {
                this.dimensionField = value;
                
            }
        }

        

        
    }
}