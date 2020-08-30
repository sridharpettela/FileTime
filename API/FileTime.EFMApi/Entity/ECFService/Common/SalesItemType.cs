namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class SalesItemType
    {

        private QuantityType2 quantityField;

        private ActivityPropertyType[] activityPropertyField;

        private PriceType[] taxExclusivePriceField;

        private PriceType[] taxInclusivePriceField;

        private ItemType1 itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
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
        [System.Xml.Serialization.XmlElementAttribute("ActivityProperty", Order = 1)]
        public ActivityPropertyType[] ActivityProperty
        {
            get
            {
                return this.activityPropertyField;
            }
            set
            {
                this.activityPropertyField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TaxExclusivePrice", Order = 2)]
        public PriceType[] TaxExclusivePrice
        {
            get
            {
                return this.taxExclusivePriceField;
            }
            set
            {
                this.taxExclusivePriceField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TaxInclusivePrice", Order = 3)]
        public PriceType[] TaxInclusivePrice
        {
            get
            {
                return this.taxInclusivePriceField;
            }
            set
            {
                this.taxInclusivePriceField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
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

        
    }
}