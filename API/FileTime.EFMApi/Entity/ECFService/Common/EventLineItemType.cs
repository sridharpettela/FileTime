namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class EventLineItemType
    {

        private LineNumberNumericType lineNumberNumericField;

        private LocationType1 participatingLocationsLocationField;

        private RetailPlannedImpactType[] retailPlannedImpactField;

        private ItemType1 supplyItemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public LineNumberNumericType LineNumberNumeric
        {
            get
            {
                return this.lineNumberNumericField;
            }
            set
            {
                this.lineNumberNumericField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public LocationType1 ParticipatingLocationsLocation
        {
            get
            {
                return this.participatingLocationsLocationField;
            }
            set
            {
                this.participatingLocationsLocationField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RetailPlannedImpact", Order = 2)]
        public RetailPlannedImpactType[] RetailPlannedImpact
        {
            get
            {
                return this.retailPlannedImpactField;
            }
            set
            {
                this.retailPlannedImpactField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public ItemType1 SupplyItem
        {
            get
            {
                return this.supplyItemField;
            }
            set
            {
                this.supplyItemField = value;
                
            }
        }

        

       
    }
}