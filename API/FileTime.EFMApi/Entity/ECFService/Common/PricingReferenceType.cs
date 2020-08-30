namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class PricingReferenceType
    {

        private ItemLocationQuantityType originalItemLocationQuantityField;

        private PriceType[] alternativeConditionPriceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public ItemLocationQuantityType OriginalItemLocationQuantity
        {
            get
            {
                return this.originalItemLocationQuantityField;
            }
            set
            {
                this.originalItemLocationQuantityField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AlternativeConditionPrice", Order = 1)]
        public PriceType[] AlternativeConditionPrice
        {
            get
            {
                return this.alternativeConditionPriceField;
            }
            set
            {
                this.alternativeConditionPriceField = value;
                
            }
        }

        

    }
}