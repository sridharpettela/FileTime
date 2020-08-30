namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class PromotionalSpecificationType
    {

        private SpecificationIDType specificationIDField;

        private PromotionalEventLineItemType[] promotionalEventLineItemField;

        private EventTacticType[] eventTacticField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public SpecificationIDType SpecificationID
        {
            get
            {
                return this.specificationIDField;
            }
            set
            {
                this.specificationIDField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PromotionalEventLineItem", Order = 1)]
        public PromotionalEventLineItemType[] PromotionalEventLineItem
        {
            get
            {
                return this.promotionalEventLineItemField;
            }
            set
            {
                this.promotionalEventLineItemField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EventTactic", Order = 2)]
        public EventTacticType[] EventTactic
        {
            get
            {
                return this.eventTacticField;
            }
            set
            {
                this.eventTacticField = value;
                
            }
        }

        
    }
}