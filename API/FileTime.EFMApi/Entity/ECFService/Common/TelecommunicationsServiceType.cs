namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class TelecommunicationsServiceType
    {

        private IDType idField;

        private CallDateType callDateField;

        private CallTimeType callTimeField;

        private ServiceNumberCalledType serviceNumberCalledField;

        private TelecommunicationsServiceCategoryType telecommunicationsServiceCategoryField;

        private TelecommunicationsServiceCategoryCodeType telecommunicationsServiceCategoryCodeField;

        private MovieTitleType movieTitleField;

        private RoamingPartnerNameType[] roamingPartnerNameField;

        private PayPerViewType payPerViewField;

        private QuantityType2 quantityField;

        private TelecommunicationsServiceCallType telecommunicationsServiceCallField;

        private TelecommunicationsServiceCallCodeType telecommunicationsServiceCallCodeField;

        private CallBaseAmountType callBaseAmountField;

        private CallExtensionAmountType callExtensionAmountField;

        private PriceType priceField;

        private CountryType countryField;

        private ExchangeRateType[] exchangeRateField;

        private AllowanceChargeType[] allowanceChargeField;

        private TaxTotalType[] taxTotalField;

        private DutyType1[] callDutyField;

        private DutyType1[] timeDutyField;

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
        public CallDateType CallDate
        {
            get
            {
                return this.callDateField;
            }
            set
            {
                this.callDateField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public CallTimeType CallTime
        {
            get
            {
                return this.callTimeField;
            }
            set
            {
                this.callTimeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public ServiceNumberCalledType ServiceNumberCalled
        {
            get
            {
                return this.serviceNumberCalledField;
            }
            set
            {
                this.serviceNumberCalledField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
        public TelecommunicationsServiceCategoryType TelecommunicationsServiceCategory
        {
            get
            {
                return this.telecommunicationsServiceCategoryField;
            }
            set
            {
                this.telecommunicationsServiceCategoryField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 5)]
        public TelecommunicationsServiceCategoryCodeType TelecommunicationsServiceCategoryCode
        {
            get
            {
                return this.telecommunicationsServiceCategoryCodeField;
            }
            set
            {
                this.telecommunicationsServiceCategoryCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 6)]
        public MovieTitleType MovieTitle
        {
            get
            {
                return this.movieTitleField;
            }
            set
            {
                this.movieTitleField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RoamingPartnerName", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 7)]
        public RoamingPartnerNameType[] RoamingPartnerName
        {
            get
            {
                return this.roamingPartnerNameField;
            }
            set
            {
                this.roamingPartnerNameField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 8)]
        public PayPerViewType PayPerView
        {
            get
            {
                return this.payPerViewField;
            }
            set
            {
                this.payPerViewField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 9)]
        public QuantityType2 Quantity
        {
            get
            {
                return this.quantityField;
            }
            set
            {
                this.quantityField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 10)]
        public TelecommunicationsServiceCallType TelecommunicationsServiceCall
        {
            get
            {
                return this.telecommunicationsServiceCallField;
            }
            set
            {
                this.telecommunicationsServiceCallField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 11)]
        public TelecommunicationsServiceCallCodeType TelecommunicationsServiceCallCode
        {
            get
            {
                return this.telecommunicationsServiceCallCodeField;
            }
            set
            {
                this.telecommunicationsServiceCallCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 12)]
        public CallBaseAmountType CallBaseAmount
        {
            get
            {
                return this.callBaseAmountField;
            }
            set
            {
                this.callBaseAmountField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 13)]
        public CallExtensionAmountType CallExtensionAmount
        {
            get
            {
                return this.callExtensionAmountField;
            }
            set
            {
                this.callExtensionAmountField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
        public PriceType Price
        {
            get
            {
                return this.priceField;
            }
            set
            {
                this.priceField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 15)]
        public CountryType Country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ExchangeRate", Order = 16)]
        public ExchangeRateType[] ExchangeRate
        {
            get
            {
                return this.exchangeRateField;
            }
            set
            {
                this.exchangeRateField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AllowanceCharge", Order = 17)]
        public AllowanceChargeType[] AllowanceCharge
        {
            get
            {
                return this.allowanceChargeField;
            }
            set
            {
                this.allowanceChargeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TaxTotal", Order = 18)]
        public TaxTotalType[] TaxTotal
        {
            get
            {
                return this.taxTotalField;
            }
            set
            {
                this.taxTotalField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CallDuty", Order = 19)]
        public DutyType1[] CallDuty
        {
            get
            {
                return this.callDutyField;
            }
            set
            {
                this.callDutyField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TimeDuty", Order = 20)]
        public DutyType1[] TimeDuty
        {
            get
            {
                return this.timeDutyField;
            }
            set
            {
                this.timeDutyField = value;
                
            }
        }

       
    }
}