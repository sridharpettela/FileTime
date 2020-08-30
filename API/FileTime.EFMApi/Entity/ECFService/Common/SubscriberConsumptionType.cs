namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class SubscriberConsumptionType
    {

        private ConsumptionIDType consumptionIDField;

        private SpecificationTypeCodeType specificationTypeCodeField;

        private NoteType[] noteField;

        private TotalMeteredQuantityType totalMeteredQuantityField;

        private PartyType subscriberPartyField;

        private ConsumptionPointType utilityConsumptionPointField;

        private OnAccountPaymentType[] onAccountPaymentField;

        private ConsumptionType consumptionField;

        private SupplierConsumptionType[] supplierConsumptionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public ConsumptionIDType ConsumptionID
        {
            get
            {
                return this.consumptionIDField;
            }
            set
            {
                this.consumptionIDField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public SpecificationTypeCodeType SpecificationTypeCode
        {
            get
            {
                return this.specificationTypeCodeField;
            }
            set
            {
                this.specificationTypeCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public TotalMeteredQuantityType TotalMeteredQuantity
        {
            get
            {
                return this.totalMeteredQuantityField;
            }
            set
            {
                this.totalMeteredQuantityField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public PartyType SubscriberParty
        {
            get
            {
                return this.subscriberPartyField;
            }
            set
            {
                this.subscriberPartyField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public ConsumptionPointType UtilityConsumptionPoint
        {
            get
            {
                return this.utilityConsumptionPointField;
            }
            set
            {
                this.utilityConsumptionPointField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OnAccountPayment", Order = 6)]
        public OnAccountPaymentType[] OnAccountPayment
        {
            get
            {
                return this.onAccountPaymentField;
            }
            set
            {
                this.onAccountPaymentField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
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
        [System.Xml.Serialization.XmlElementAttribute("SupplierConsumption", Order = 8)]
        public SupplierConsumptionType[] SupplierConsumption
        {
            get
            {
                return this.supplierConsumptionField;
            }
            set
            {
                this.supplierConsumptionField = value;
                
            }
        }

        
    }
}