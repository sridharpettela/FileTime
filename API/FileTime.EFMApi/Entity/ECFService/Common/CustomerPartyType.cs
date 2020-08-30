namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class CustomerPartyType
    {

        private CustomerAssignedAccountIDType customerAssignedAccountIDField;

        private SupplierAssignedAccountIDType supplierAssignedAccountIDField;

        private AdditionalAccountIDType[] additionalAccountIDField;

        private PartyType partyField;

        private ContactType deliveryContactField;

        private ContactType accountingContactField;

        private ContactType buyerContactField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public CustomerAssignedAccountIDType CustomerAssignedAccountID
        {
            get
            {
                return this.customerAssignedAccountIDField;
            }
            set
            {
                this.customerAssignedAccountIDField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public SupplierAssignedAccountIDType SupplierAssignedAccountID
        {
            get
            {
                return this.supplierAssignedAccountIDField;
            }
            set
            {
                this.supplierAssignedAccountIDField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AdditionalAccountID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public AdditionalAccountIDType[] AdditionalAccountID
        {
            get
            {
                return this.additionalAccountIDField;
            }
            set
            {
                this.additionalAccountIDField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public PartyType Party
        {
            get
            {
                return this.partyField;
            }
            set
            {
                this.partyField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public ContactType DeliveryContact
        {
            get
            {
                return this.deliveryContactField;
            }
            set
            {
                this.deliveryContactField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public ContactType AccountingContact
        {
            get
            {
                return this.accountingContactField;
            }
            set
            {
                this.accountingContactField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public ContactType BuyerContact
        {
            get
            {
                return this.buyerContactField;
            }
            set
            {
                this.buyerContactField = value;
                
            }
        }

        

     
    }
}