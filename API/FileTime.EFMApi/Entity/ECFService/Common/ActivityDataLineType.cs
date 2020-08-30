namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class ActivityDataLineType
    {

        private IDType idField;

        private SupplyChainActivityTypeCodeType supplyChainActivityTypeCodeField;

        private CustomerPartyType buyerCustomerPartyField;

        private SupplierPartyType sellerSupplierPartyField;

        private PeriodType activityPeriodField;

        private LocationType1 activityOriginLocationField;

        private LocationType1 activityFinalLocationField;

        private SalesItemType[] salesItemField;

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
        public SupplyChainActivityTypeCodeType SupplyChainActivityTypeCode
        {
            get
            {
                return this.supplyChainActivityTypeCodeField;
            }
            set
            {
                this.supplyChainActivityTypeCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public CustomerPartyType BuyerCustomerParty
        {
            get
            {
                return this.buyerCustomerPartyField;
            }
            set
            {
                this.buyerCustomerPartyField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public SupplierPartyType SellerSupplierParty
        {
            get
            {
                return this.sellerSupplierPartyField;
            }
            set
            {
                this.sellerSupplierPartyField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public PeriodType ActivityPeriod
        {
            get
            {
                return this.activityPeriodField;
            }
            set
            {
                this.activityPeriodField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public LocationType1 ActivityOriginLocation
        {
            get
            {
                return this.activityOriginLocationField;
            }
            set
            {
                this.activityOriginLocationField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public LocationType1 ActivityFinalLocation
        {
            get
            {
                return this.activityFinalLocationField;
            }
            set
            {
                this.activityFinalLocationField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SalesItem", Order = 7)]
        public SalesItemType[] SalesItem
        {
            get
            {
                return this.salesItemField;
            }
            set
            {
                this.salesItemField = value;
                
            }
        }
    }
}