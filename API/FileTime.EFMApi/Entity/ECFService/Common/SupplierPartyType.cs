namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class SupplierPartyType
    {

        private CustomerAssignedAccountIDType customerAssignedAccountIDField;

        private AdditionalAccountIDType[] additionalAccountIDField;

        private DataSendingCapabilityType dataSendingCapabilityField;

        private PartyType partyField;

        private ContactType despatchContactField;

        private ContactType accountingContactField;

        private ContactType sellerContactField;

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
        [System.Xml.Serialization.XmlElementAttribute("AdditionalAccountID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public DataSendingCapabilityType DataSendingCapability
        {
            get
            {
                return this.dataSendingCapabilityField;
            }
            set
            {
                this.dataSendingCapabilityField = value;
                
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
        public ContactType DespatchContact
        {
            get
            {
                return this.despatchContactField;
            }
            set
            {
                this.despatchContactField = value;
                
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
        public ContactType SellerContact
        {
            get
            {
                return this.sellerContactField;
            }
            set
            {
                this.sellerContactField = value;
                
            }
        }

        
    }
}