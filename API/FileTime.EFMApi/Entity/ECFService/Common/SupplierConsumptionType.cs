namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class SupplierConsumptionType
    {

        private DescriptionType descriptionField;

        private PartyType utilitySupplierPartyField;

        private PartyType utilityCustomerPartyField;

        private ConsumptionType consumptionField;

        private ConsumptionLineType[] consumptionLineField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public DescriptionType Description
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public PartyType UtilitySupplierParty
        {
            get
            {
                return this.utilitySupplierPartyField;
            }
            set
            {
                this.utilitySupplierPartyField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public PartyType UtilityCustomerParty
        {
            get
            {
                return this.utilityCustomerPartyField;
            }
            set
            {
                this.utilityCustomerPartyField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public ConsumptionType Consumption
        {
            get
            {
                return this.consumptionField;
            }
            set
            {
                this.consumptionField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ConsumptionLine", Order = 4)]
        public ConsumptionLineType[] ConsumptionLine
        {
            get
            {
                return this.consumptionLineField;
            }
            set
            {
                this.consumptionLineField = value;
                
            }
        }

        
    }
}