namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class MiscellaneousEventType
    {

        private MiscellaneousEventTypeCodeType miscellaneousEventTypeCodeField;

        private EventLineItemType[] eventLineItemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public MiscellaneousEventTypeCodeType MiscellaneousEventTypeCode
        {
            get
            {
                return this.miscellaneousEventTypeCodeField;
            }
            set
            {
                this.miscellaneousEventTypeCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EventLineItem", Order = 1)]
        public EventLineItemType[] EventLineItem
        {
            get
            {
                return this.eventLineItemField;
            }
            set
            {
                this.eventLineItemField = value;
                
            }
        }

        

        
    }
}