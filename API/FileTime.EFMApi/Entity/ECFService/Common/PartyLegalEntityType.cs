namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class PartyLegalEntityType
    {

        private RegistrationNameType registrationNameField;

        private CompanyIDType companyIDField;

        private RegistrationDateType registrationDateField;

        private RegistrationExpirationDateType registrationExpirationDateField;

        private CompanyLegalFormCodeType companyLegalFormCodeField;

        private SoleProprietorshipIndicatorType soleProprietorshipIndicatorField;

        private CompanyLiquidationStatusCodeType companyLiquidationStatusCodeField;

        private CorporateStockAmountType corporateStockAmountField;

        private FullyPaidSharesIndicatorType fullyPaidSharesIndicatorField;

        private AddressType registrationAddressField;

        private CorporateRegistrationSchemeType corporateRegistrationSchemeField;

        private PartyType headPartyField;

        private ShareholderPartyType[] shareholderPartyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public RegistrationNameType RegistrationName
        {
            get
            {
                return this.registrationNameField;
            }
            set
            {
                this.registrationNameField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public CompanyIDType CompanyID
        {
            get
            {
                return this.companyIDField;
            }
            set
            {
                this.companyIDField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public RegistrationDateType RegistrationDate
        {
            get
            {
                return this.registrationDateField;
            }
            set
            {
                this.registrationDateField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public RegistrationExpirationDateType RegistrationExpirationDate
        {
            get
            {
                return this.registrationExpirationDateField;
            }
            set
            {
                this.registrationExpirationDateField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
        public CompanyLegalFormCodeType CompanyLegalFormCode
        {
            get
            {
                return this.companyLegalFormCodeField;
            }
            set
            {
                this.companyLegalFormCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 5)]
        public SoleProprietorshipIndicatorType SoleProprietorshipIndicator
        {
            get
            {
                return this.soleProprietorshipIndicatorField;
            }
            set
            {
                this.soleProprietorshipIndicatorField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 6)]
        public CompanyLiquidationStatusCodeType CompanyLiquidationStatusCode
        {
            get
            {
                return this.companyLiquidationStatusCodeField;
            }
            set
            {
                this.companyLiquidationStatusCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 7)]
        public CorporateStockAmountType CorporateStockAmount
        {
            get
            {
                return this.corporateStockAmountField;
            }
            set
            {
                this.corporateStockAmountField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 8)]
        public FullyPaidSharesIndicatorType FullyPaidSharesIndicator
        {
            get
            {
                return this.fullyPaidSharesIndicatorField;
            }
            set
            {
                this.fullyPaidSharesIndicatorField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public AddressType RegistrationAddress
        {
            get
            {
                return this.registrationAddressField;
            }
            set
            {
                this.registrationAddressField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public CorporateRegistrationSchemeType CorporateRegistrationScheme
        {
            get
            {
                return this.corporateRegistrationSchemeField;
            }
            set
            {
                this.corporateRegistrationSchemeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public PartyType HeadParty
        {
            get
            {
                return this.headPartyField;
            }
            set
            {
                this.headPartyField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ShareholderParty", Order = 12)]
        public ShareholderPartyType[] ShareholderParty
        {
            get
            {
                return this.shareholderPartyField;
            }
            set
            {
                this.shareholderPartyField = value;
                
            }
        }

        

    }
}