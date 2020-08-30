namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class UtilityItemType
    {

        private IDType idField;

        private SubscriberIDType subscriberIDField;

        private SubscriberIDTypeType subscriberIDTypeField;

        private SubscriberIDTypeCodeType subscriberIDTypeCodeField;

        private DescriptionType[] descriptionField;

        private PackQuantityType packQuantityField;

        private PackSizeNumericType packSizeNumericField;

        private ConsumptionTypeType consumptionTypeField;

        private ConsumptionTypeCodeType consumptionTypeCodeField;

        private CurrentChargeTypeType currentChargeTypeField;

        private CurrentChargeTypeCodeType currentChargeTypeCodeField;

        private OneTimeChargeTypeType oneTimeChargeTypeField;

        private OneTimeChargeTypeCodeType oneTimeChargeTypeCodeField;

        private TaxCategoryType taxCategoryField;

        private ContractType contractField;

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
        public SubscriberIDType SubscriberID
        {
            get
            {
                return this.subscriberIDField;
            }
            set
            {
                this.subscriberIDField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public SubscriberIDTypeType SubscriberIDType
        {
            get
            {
                return this.subscriberIDTypeField;
            }
            set
            {
                this.subscriberIDTypeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public SubscriberIDTypeCodeType SubscriberIDTypeCode
        {
            get
            {
                return this.subscriberIDTypeCodeField;
            }
            set
            {
                this.subscriberIDTypeCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 5)]
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 6)]
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 7)]
        public ConsumptionTypeType ConsumptionType
        {
            get
            {
                return this.consumptionTypeField;
            }
            set
            {
                this.consumptionTypeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 8)]
        public ConsumptionTypeCodeType ConsumptionTypeCode
        {
            get
            {
                return this.consumptionTypeCodeField;
            }
            set
            {
                this.consumptionTypeCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 9)]
        public CurrentChargeTypeType CurrentChargeType
        {
            get
            {
                return this.currentChargeTypeField;
            }
            set
            {
                this.currentChargeTypeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 10)]
        public CurrentChargeTypeCodeType CurrentChargeTypeCode
        {
            get
            {
                return this.currentChargeTypeCodeField;
            }
            set
            {
                this.currentChargeTypeCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 11)]
        public OneTimeChargeTypeType OneTimeChargeType
        {
            get
            {
                return this.oneTimeChargeTypeField;
            }
            set
            {
                this.oneTimeChargeTypeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 12)]
        public OneTimeChargeTypeCodeType OneTimeChargeTypeCode
        {
            get
            {
                return this.oneTimeChargeTypeCodeField;
            }
            set
            {
                this.oneTimeChargeTypeCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
        public TaxCategoryType TaxCategory
        {
            get
            {
                return this.taxCategoryField;
            }
            set
            {
                this.taxCategoryField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
        public ContractType Contract
        {
            get
            {
                return this.contractField;
            }
            set
            {
                this.contractField = value;
                
            }
        }

        
    }
}