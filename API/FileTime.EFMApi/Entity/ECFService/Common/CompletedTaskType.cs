namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class CompletedTaskType
    {

        private AnnualAverageAmountType annualAverageAmountField;

        private TotalTaskAmountType totalTaskAmountField;

        private PartyCapacityAmountType partyCapacityAmountField;

        private DescriptionType[] descriptionField;

        private EvidenceSuppliedIDType evidenceSuppliedIDField;

        private PeriodType periodField;

        private CustomerPartyType recipientCustomerPartyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public AnnualAverageAmountType AnnualAverageAmount
        {
            get
            {
                return this.annualAverageAmountField;
            }
            set
            {
                this.annualAverageAmountField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public TotalTaskAmountType TotalTaskAmount
        {
            get
            {
                return this.totalTaskAmountField;
            }
            set
            {
                this.totalTaskAmountField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public PartyCapacityAmountType PartyCapacityAmount
        {
            get
            {
                return this.partyCapacityAmountField;
            }
            set
            {
                this.partyCapacityAmountField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public DescriptionType[] Description
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
        public EvidenceSuppliedIDType EvidenceSuppliedID
        {
            get
            {
                return this.evidenceSuppliedIDField;
            }
            set
            {
                this.evidenceSuppliedIDField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public PeriodType Period
        {
            get
            {
                return this.periodField;
            }
            set
            {
                this.periodField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public CustomerPartyType RecipientCustomerParty
        {
            get
            {
                return this.recipientCustomerPartyField;
            }
            set
            {
                this.recipientCustomerPartyField = value;
                
            }
        }

    }
}