namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class ImmobilizedSecurityType
    {

        private ImmobilizationCertificateIDType immobilizationCertificateIDField;

        private SecurityIDType securityIDField;

        private IssueDateType issueDateField;

        private FaceValueAmountType faceValueAmountField;

        private MarketValueAmountType marketValueAmountField;

        private SharesNumberQuantityType sharesNumberQuantityField;

        private PartyType issuerPartyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public ImmobilizationCertificateIDType ImmobilizationCertificateID
        {
            get
            {
                return this.immobilizationCertificateIDField;
            }
            set
            {
                this.immobilizationCertificateIDField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public SecurityIDType SecurityID
        {
            get
            {
                return this.securityIDField;
            }
            set
            {
                this.securityIDField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public IssueDateType IssueDate
        {
            get
            {
                return this.issueDateField;
            }
            set
            {
                this.issueDateField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public FaceValueAmountType FaceValueAmount
        {
            get
            {
                return this.faceValueAmountField;
            }
            set
            {
                this.faceValueAmountField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
        public MarketValueAmountType MarketValueAmount
        {
            get
            {
                return this.marketValueAmountField;
            }
            set
            {
                this.marketValueAmountField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 5)]
        public SharesNumberQuantityType SharesNumberQuantity
        {
            get
            {
                return this.sharesNumberQuantityField;
            }
            set
            {
                this.sharesNumberQuantityField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public PartyType IssuerParty
        {
            get
            {
                return this.issuerPartyField;
            }
            set
            {
                this.issuerPartyField = value;
                
            }
        }

        

       
    }
}