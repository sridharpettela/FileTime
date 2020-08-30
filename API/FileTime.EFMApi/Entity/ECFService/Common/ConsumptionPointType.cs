namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class ConsumptionPointType
    {

        private IDType idField;

        private DescriptionType descriptionField;

        private SubscriberIDType subscriberIDField;

        private SubscriberTypeIdentifierType subscriberTypeIdentifierField;

        private SubscriberTypeCodeType subscriberTypeCodeField;

        private TotalDeliveredQuantityType totalDeliveredQuantityField;

        private AddressType addressField;

        private WebSiteAccessType webSiteAccessField;

        private MeterType[] utilityMeterField;

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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public SubscriberTypeIdentifierType SubscriberTypeIdentifier
        {
            get
            {
                return this.subscriberTypeIdentifierField;
            }
            set
            {
                this.subscriberTypeIdentifierField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
        public SubscriberTypeCodeType SubscriberTypeCode
        {
            get
            {
                return this.subscriberTypeCodeField;
            }
            set
            {
                this.subscriberTypeCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 5)]
        public TotalDeliveredQuantityType TotalDeliveredQuantity
        {
            get
            {
                return this.totalDeliveredQuantityField;
            }
            set
            {
                this.totalDeliveredQuantityField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public AddressType Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public WebSiteAccessType WebSiteAccess
        {
            get
            {
                return this.webSiteAccessField;
            }
            set
            {
                this.webSiteAccessField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UtilityMeter", Order = 8)]
        public MeterType[] UtilityMeter
        {
            get
            {
                return this.utilityMeterField;
            }
            set
            {
                this.utilityMeterField = value;
                
            }
        }

        
    }
}