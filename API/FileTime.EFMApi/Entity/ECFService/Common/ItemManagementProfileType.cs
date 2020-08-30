namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class ItemManagementProfileType
    {

        private FrozenPeriodDaysNumericType frozenPeriodDaysNumericField;

        private MinimumInventoryQuantityType minimumInventoryQuantityField;

        private MultipleOrderQuantityType multipleOrderQuantityField;

        private OrderIntervalDaysNumericType orderIntervalDaysNumericField;

        private ReplenishmentOwnerDescriptionType replenishmentOwnerDescriptionField;

        private TargetServicePercentType targetServicePercentField;

        private TargetInventoryQuantityType targetInventoryQuantityField;

        private PeriodType effectivePeriodField;

        private ItemType1 itemField;

        private ItemLocationQuantityType itemLocationQuantityField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public FrozenPeriodDaysNumericType FrozenPeriodDaysNumeric
        {
            get
            {
                return this.frozenPeriodDaysNumericField;
            }
            set
            {
                this.frozenPeriodDaysNumericField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public MinimumInventoryQuantityType MinimumInventoryQuantity
        {
            get
            {
                return this.minimumInventoryQuantityField;
            }
            set
            {
                this.minimumInventoryQuantityField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public MultipleOrderQuantityType MultipleOrderQuantity
        {
            get
            {
                return this.multipleOrderQuantityField;
            }
            set
            {
                this.multipleOrderQuantityField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public OrderIntervalDaysNumericType OrderIntervalDaysNumeric
        {
            get
            {
                return this.orderIntervalDaysNumericField;
            }
            set
            {
                this.orderIntervalDaysNumericField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
        public ReplenishmentOwnerDescriptionType ReplenishmentOwnerDescription
        {
            get
            {
                return this.replenishmentOwnerDescriptionField;
            }
            set
            {
                this.replenishmentOwnerDescriptionField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 5)]
        public TargetServicePercentType TargetServicePercent
        {
            get
            {
                return this.targetServicePercentField;
            }
            set
            {
                this.targetServicePercentField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 6)]
        public TargetInventoryQuantityType TargetInventoryQuantity
        {
            get
            {
                return this.targetInventoryQuantityField;
            }
            set
            {
                this.targetInventoryQuantityField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public PeriodType EffectivePeriod
        {
            get
            {
                return this.effectivePeriodField;
            }
            set
            {
                this.effectivePeriodField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public ItemLocationQuantityType ItemLocationQuantity
        {
            get
            {
                return this.itemLocationQuantityField;
            }
            set
            {
                this.itemLocationQuantityField = value;
                
            }
        }

        

        
    }
}