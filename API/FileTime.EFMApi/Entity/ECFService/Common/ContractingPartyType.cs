namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class ContractingPartyType
    {

        private ContractingPartyTypeCodeType contractingPartyTypeCodeField;

        private ActivityCodeType[] activityCodeField;

        private BuyerProfileURIType buyerProfileURIField;

        private PartyType partyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public ContractingPartyTypeCodeType ContractingPartyTypeCode
        {
            get
            {
                return this.contractingPartyTypeCodeField;
            }
            set
            {
                this.contractingPartyTypeCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ActivityCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public ActivityCodeType[] ActivityCode
        {
            get
            {
                return this.activityCodeField;
            }
            set
            {
                this.activityCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public BuyerProfileURIType BuyerProfileURI
        {
            get
            {
                return this.buyerProfileURIField;
            }
            set
            {
                this.buyerProfileURIField = value;
                
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

        

        
    }
}