namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class PartyType
    {

        private MarkCareIndicatorType markCareIndicatorField;

        private MarkAttentionIndicatorType markAttentionIndicatorField;

        private WebsiteURIType websiteURIField;

        private LogoReferenceIDType logoReferenceIDField;

        private EndpointIDType endpointIDField;

        private IndustryClassificationCodeType industryClassificationCodeField;

        private PartyIdentificationType[] partyIdentificationField;

        private PartyNameType[] partyNameField;

        private object itemField;

        private AddressType postalAddressField;

        private LocationType1 physicalLocationField;

        private PartyTaxSchemeType[] partyTaxSchemeField;

        private PartyLegalEntityType[] partyLegalEntityField;

        private ContactType contactField;

        private PersonType[] personField;

        private PartyType agentPartyField;

        private ServiceProviderPartyType[] serviceProviderPartyField;

        private PowerOfAttorneyType[] powerOfAttorneyField;

        private FinancialAccountType financialAccountField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public MarkCareIndicatorType MarkCareIndicator
        {
            get
            {
                return this.markCareIndicatorField;
            }
            set
            {
                this.markCareIndicatorField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public MarkAttentionIndicatorType MarkAttentionIndicator
        {
            get
            {
                return this.markAttentionIndicatorField;
            }
            set
            {
                this.markAttentionIndicatorField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public WebsiteURIType WebsiteURI
        {
            get
            {
                return this.websiteURIField;
            }
            set
            {
                this.websiteURIField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public LogoReferenceIDType LogoReferenceID
        {
            get
            {
                return this.logoReferenceIDField;
            }
            set
            {
                this.logoReferenceIDField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
        public EndpointIDType EndpointID
        {
            get
            {
                return this.endpointIDField;
            }
            set
            {
                this.endpointIDField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 5)]
        public IndustryClassificationCodeType IndustryClassificationCode
        {
            get
            {
                return this.industryClassificationCodeField;
            }
            set
            {
                this.industryClassificationCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PartyIdentification", Order = 6)]
        public PartyIdentificationType[] PartyIdentification
        {
            get
            {
                return this.partyIdentificationField;
            }
            set
            {
                this.partyIdentificationField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PartyName", Order = 7)]
        public PartyNameType[] PartyName
        {
            get
            {
                return this.partyNameField;
            }
            set
            {
                this.partyNameField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LanguageCode", typeof(LanguageCodeType), Namespace = "http://niem.gov/niem/niem-core/2.0",  Order = 8)]
        [System.Xml.Serialization.XmlElementAttribute("Language", typeof(LanguageType), Order = 8)]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public AddressType PostalAddress
        {
            get
            {
                return this.postalAddressField;
            }
            set
            {
                this.postalAddressField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public LocationType1 PhysicalLocation
        {
            get
            {
                return this.physicalLocationField;
            }
            set
            {
                this.physicalLocationField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PartyTaxScheme", Order = 11)]
        public PartyTaxSchemeType[] PartyTaxScheme
        {
            get
            {
                return this.partyTaxSchemeField;
            }
            set
            {
                this.partyTaxSchemeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PartyLegalEntity", Order = 12)]
        public PartyLegalEntityType[] PartyLegalEntity
        {
            get
            {
                return this.partyLegalEntityField;
            }
            set
            {
                this.partyLegalEntityField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
        public ContactType Contact
        {
            get
            {
                return this.contactField;
            }
            set
            {
                this.contactField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Person", Order = 14)]
        public PersonType[] Person
        {
            get
            {
                return this.personField;
            }
            set
            {
                this.personField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 15)]
        public PartyType AgentParty
        {
            get
            {
                return this.agentPartyField;
            }
            set
            {
                this.agentPartyField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ServiceProviderParty", Order = 16)]
        public ServiceProviderPartyType[] ServiceProviderParty
        {
            get
            {
                return this.serviceProviderPartyField;
            }
            set
            {
                this.serviceProviderPartyField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PowerOfAttorney", Order = 17)]
        public PowerOfAttorneyType[] PowerOfAttorney
        {
            get
            {
                return this.powerOfAttorneyField;
            }
            set
            {
                this.powerOfAttorneyField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 18)]
        public FinancialAccountType FinancialAccount
        {
            get
            {
                return this.financialAccountField;
            }
            set
            {
                this.financialAccountField = value;
                
            }
        }

        

    }
}