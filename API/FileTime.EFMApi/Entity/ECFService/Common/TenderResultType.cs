namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class TenderResultType
    {

        private TenderResultCodeType tenderResultCodeField;

        private DescriptionType[] descriptionField;

        private AdvertisementAmountType advertisementAmountField;

        private AwardDateType awardDateField;

        private AwardTimeType awardTimeField;

        private ReceivedTenderQuantityType receivedTenderQuantityField;

        private LowerTenderAmountType lowerTenderAmountField;

        private HigherTenderAmountType higherTenderAmountField;

        private StartDateType startDateField;

        private ContractType contractField;

        private PartyType winningPartyField;

        private TenderedProjectType awardedTenderedProjectField;

        private PeriodType contractFormalizationPeriodField;

        private SubcontractTermsType[] subcontractTermsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public TenderResultCodeType TenderResultCode
        {
            get
            {
                return this.tenderResultCodeField;
            }
            set
            {
                this.tenderResultCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public AdvertisementAmountType AdvertisementAmount
        {
            get
            {
                return this.advertisementAmountField;
            }
            set
            {
                this.advertisementAmountField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public AwardDateType AwardDate
        {
            get
            {
                return this.awardDateField;
            }
            set
            {
                this.awardDateField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
        public AwardTimeType AwardTime
        {
            get
            {
                return this.awardTimeField;
            }
            set
            {
                this.awardTimeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 5)]
        public ReceivedTenderQuantityType ReceivedTenderQuantity
        {
            get
            {
                return this.receivedTenderQuantityField;
            }
            set
            {
                this.receivedTenderQuantityField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 6)]
        public LowerTenderAmountType LowerTenderAmount
        {
            get
            {
                return this.lowerTenderAmountField;
            }
            set
            {
                this.lowerTenderAmountField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 7)]
        public HigherTenderAmountType HigherTenderAmount
        {
            get
            {
                return this.higherTenderAmountField;
            }
            set
            {
                this.higherTenderAmountField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 8)]
        public StartDateType StartDate
        {
            get
            {
                return this.startDateField;
            }
            set
            {
                this.startDateField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public ContractType Contract
        {
            get
            {
                return this.contractField;
            }
            set
            {
                this.contractField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public PartyType WinningParty
        {
            get
            {
                return this.winningPartyField;
            }
            set
            {
                this.winningPartyField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public TenderedProjectType AwardedTenderedProject
        {
            get
            {
                return this.awardedTenderedProjectField;
            }
            set
            {
                this.awardedTenderedProjectField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public PeriodType ContractFormalizationPeriod
        {
            get
            {
                return this.contractFormalizationPeriodField;
            }
            set
            {
                this.contractFormalizationPeriodField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SubcontractTerms", Order = 13)]
        public SubcontractTermsType[] SubcontractTerms
        {
            get
            {
                return this.subcontractTermsField;
            }
            set
            {
                this.subcontractTermsField = value;
                
            }
        }

    }
}