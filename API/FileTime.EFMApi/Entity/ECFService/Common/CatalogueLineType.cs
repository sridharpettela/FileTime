namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class CatalogueLineType
    {

        private IDType idField;

        private ActionCodeType actionCodeField;

        private LifeCycleStatusCodeType lifeCycleStatusCodeField;

        private ContractSubdivisionType contractSubdivisionField;

        private NoteType[] noteField;

        private OrderableIndicatorType orderableIndicatorField;

        private OrderableUnitType orderableUnitField;

        private ContentUnitQuantityType contentUnitQuantityField;

        private OrderQuantityIncrementNumericType orderQuantityIncrementNumericField;

        private MinimumOrderQuantityType minimumOrderQuantityField;

        private MaximumOrderQuantityType maximumOrderQuantityField;

        private WarrantyInformationType[] warrantyInformationField;

        private PackLevelCodeType packLevelCodeField;

        private CustomerPartyType contractorCustomerPartyField;

        private SupplierPartyType sellerSupplierPartyField;

        private PartyType warrantyPartyField;

        private PeriodType warrantyValidityPeriodField;

        private PeriodType lineValidityPeriodField;

        private ItemComparisonType[] itemComparisonField;

        private RelatedItemType[] componentRelatedItemField;

        private RelatedItemType[] accessoryRelatedItemField;

        private RelatedItemType[] requiredRelatedItemField;

        private RelatedItemType[] replacementRelatedItemField;

        private RelatedItemType[] complementaryRelatedItemField;

        private ItemLocationQuantityType[] requiredItemLocationQuantityField;

        private DocumentReferenceType[] documentReferenceField;

        private ItemType1 itemField;

        private ItemPropertyType[] keywordItemPropertyField;

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
        public ActionCodeType ActionCode
        {
            get
            {
                return this.actionCodeField;
            }
            set
            {
                this.actionCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public LifeCycleStatusCodeType LifeCycleStatusCode
        {
            get
            {
                return this.lifeCycleStatusCodeField;
            }
            set
            {
                this.lifeCycleStatusCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public ContractSubdivisionType ContractSubdivision
        {
            get
            {
                return this.contractSubdivisionField;
            }
            set
            {
                this.contractSubdivisionField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
        public NoteType[] Note
        {
            get
            {
                return this.noteField;
            }
            set
            {
                this.noteField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 5)]
        public OrderableIndicatorType OrderableIndicator
        {
            get
            {
                return this.orderableIndicatorField;
            }
            set
            {
                this.orderableIndicatorField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 6)]
        public OrderableUnitType OrderableUnit
        {
            get
            {
                return this.orderableUnitField;
            }
            set
            {
                this.orderableUnitField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 7)]
        public ContentUnitQuantityType ContentUnitQuantity
        {
            get
            {
                return this.contentUnitQuantityField;
            }
            set
            {
                this.contentUnitQuantityField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 8)]
        public OrderQuantityIncrementNumericType OrderQuantityIncrementNumeric
        {
            get
            {
                return this.orderQuantityIncrementNumericField;
            }
            set
            {
                this.orderQuantityIncrementNumericField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 9)]
        public MinimumOrderQuantityType MinimumOrderQuantity
        {
            get
            {
                return this.minimumOrderQuantityField;
            }
            set
            {
                this.minimumOrderQuantityField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 10)]
        public MaximumOrderQuantityType MaximumOrderQuantity
        {
            get
            {
                return this.maximumOrderQuantityField;
            }
            set
            {
                this.maximumOrderQuantityField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("WarrantyInformation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 11)]
        public WarrantyInformationType[] WarrantyInformation
        {
            get
            {
                return this.warrantyInformationField;
            }
            set
            {
                this.warrantyInformationField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 12)]
        public PackLevelCodeType PackLevelCode
        {
            get
            {
                return this.packLevelCodeField;
            }
            set
            {
                this.packLevelCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
        public CustomerPartyType ContractorCustomerParty
        {
            get
            {
                return this.contractorCustomerPartyField;
            }
            set
            {
                this.contractorCustomerPartyField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
        public SupplierPartyType SellerSupplierParty
        {
            get
            {
                return this.sellerSupplierPartyField;
            }
            set
            {
                this.sellerSupplierPartyField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 15)]
        public PartyType WarrantyParty
        {
            get
            {
                return this.warrantyPartyField;
            }
            set
            {
                this.warrantyPartyField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 16)]
        public PeriodType WarrantyValidityPeriod
        {
            get
            {
                return this.warrantyValidityPeriodField;
            }
            set
            {
                this.warrantyValidityPeriodField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 17)]
        public PeriodType LineValidityPeriod
        {
            get
            {
                return this.lineValidityPeriodField;
            }
            set
            {
                this.lineValidityPeriodField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemComparison", Order = 18)]
        public ItemComparisonType[] ItemComparison
        {
            get
            {
                return this.itemComparisonField;
            }
            set
            {
                this.itemComparisonField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ComponentRelatedItem", Order = 19)]
        public RelatedItemType[] ComponentRelatedItem
        {
            get
            {
                return this.componentRelatedItemField;
            }
            set
            {
                this.componentRelatedItemField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AccessoryRelatedItem", Order = 20)]
        public RelatedItemType[] AccessoryRelatedItem
        {
            get
            {
                return this.accessoryRelatedItemField;
            }
            set
            {
                this.accessoryRelatedItemField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RequiredRelatedItem", Order = 21)]
        public RelatedItemType[] RequiredRelatedItem
        {
            get
            {
                return this.requiredRelatedItemField;
            }
            set
            {
                this.requiredRelatedItemField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ReplacementRelatedItem", Order = 22)]
        public RelatedItemType[] ReplacementRelatedItem
        {
            get
            {
                return this.replacementRelatedItemField;
            }
            set
            {
                this.replacementRelatedItemField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ComplementaryRelatedItem", Order = 23)]
        public RelatedItemType[] ComplementaryRelatedItem
        {
            get
            {
                return this.complementaryRelatedItemField;
            }
            set
            {
                this.complementaryRelatedItemField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RequiredItemLocationQuantity", Order = 24)]
        public ItemLocationQuantityType[] RequiredItemLocationQuantity
        {
            get
            {
                return this.requiredItemLocationQuantityField;
            }
            set
            {
                this.requiredItemLocationQuantityField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DocumentReference", Order = 25)]
        public DocumentReferenceType[] DocumentReference
        {
            get
            {
                return this.documentReferenceField;
            }
            set
            {
                this.documentReferenceField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 26)]
        public ItemType1 Item
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
        [System.Xml.Serialization.XmlElementAttribute("KeywordItemProperty", Order = 27)]
        public ItemPropertyType[] KeywordItemProperty
        {
            get
            {
                return this.keywordItemPropertyField;
            }
            set
            {
                this.keywordItemPropertyField = value;
                
            }
        }

    }
}