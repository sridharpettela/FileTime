namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class TenderLineType
    {

        private IDType idField;

        private NoteType[] noteField;

        private QuantityType2 quantityField;

        private LineExtensionAmountType lineExtensionAmountField;

        private TotalTaxAmountType totalTaxAmountField;

        private OrderableUnitType[] orderableUnitField;

        private ContentUnitQuantityType contentUnitQuantityField;

        private OrderQuantityIncrementNumericType orderQuantityIncrementNumericField;

        private MinimumOrderQuantityType minimumOrderQuantityField;

        private MaximumOrderQuantityType maximumOrderQuantityField;

        private WarrantyInformationType[] warrantyInformationField;

        private PackLevelCodeType packLevelCodeField;

        private DocumentReferenceType[] documentReferenceField;

        private ItemType1 itemField;

        private ItemLocationQuantityType[] offeredItemLocationQuantityField;

        private RelatedItemType[] replacementRelatedItemField;

        private PartyType warrantyPartyField;

        private PeriodType warrantyValidityPeriodField;

        private TenderLineType[] subTenderLineField;

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
        [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public LineExtensionAmountType LineExtensionAmount
        {
            get
            {
                return this.lineExtensionAmountField;
            }
            set
            {
                this.lineExtensionAmountField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
        public TotalTaxAmountType TotalTaxAmount
        {
            get
            {
                return this.totalTaxAmountField;
            }
            set
            {
                this.totalTaxAmountField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OrderableUnit", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 5)]
        public OrderableUnitType[] OrderableUnit
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 6)]
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 7)]
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 8)]
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 9)]
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
        [System.Xml.Serialization.XmlElementAttribute("WarrantyInformation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 10)]
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 11)]
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
        [System.Xml.Serialization.XmlElementAttribute("DocumentReference", Order = 12)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
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
        [System.Xml.Serialization.XmlElementAttribute("OfferedItemLocationQuantity", Order = 14)]
        public ItemLocationQuantityType[] OfferedItemLocationQuantity
        {
            get
            {
                return this.offeredItemLocationQuantityField;
            }
            set
            {
                this.offeredItemLocationQuantityField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ReplacementRelatedItem", Order = 15)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 16)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 17)]
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
        [System.Xml.Serialization.XmlElementAttribute("SubTenderLine", Order = 18)]
        public TenderLineType[] SubTenderLine
        {
            get
            {
                return this.subTenderLineField;
            }
            set
            {
                this.subTenderLineField = value;
                
            }
        }
    }
}