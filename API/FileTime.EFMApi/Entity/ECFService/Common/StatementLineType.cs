namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class StatementLineType
    {

        private IDType idField;

        private NoteType[] noteField;

        private UUIDType uUIDField;

        private BalanceBroughtForwardIndicatorType balanceBroughtForwardIndicatorField;

        private DebitLineAmountType debitLineAmountField;

        private CreditLineAmountType creditLineAmountField;

        private BalanceAmountType balanceAmountField;

        private PaymentPurposeCodeType paymentPurposeCodeField;

        private PaymentMeansType paymentMeansField;

        private PaymentTermsType[] paymentTermsField;

        private CustomerPartyType buyerCustomerPartyField;

        private SupplierPartyType sellerSupplierPartyField;

        private CustomerPartyType originatorCustomerPartyField;

        private CustomerPartyType accountingCustomerPartyField;

        private SupplierPartyType accountingSupplierPartyField;

        private PartyType payeePartyField;

        private PeriodType[] invoicePeriodField;

        private BillingReferenceType[] billingReferenceField;

        private DocumentReferenceType[] documentReferenceField;

        private ExchangeRateType exchangeRateField;

        private AllowanceChargeType[] allowanceChargeField;

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
        [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public NoteType[] Note
        {
            get
            {
                return this.noteField;
            }
            set
            {
                this.noteField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public UUIDType UUID
        {
            get
            {
                return this.uUIDField;
            }
            set
            {
                this.uUIDField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public BalanceBroughtForwardIndicatorType BalanceBroughtForwardIndicator
        {
            get
            {
                return this.balanceBroughtForwardIndicatorField;
            }
            set
            {
                this.balanceBroughtForwardIndicatorField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
        public DebitLineAmountType DebitLineAmount
        {
            get
            {
                return this.debitLineAmountField;
            }
            set
            {
                this.debitLineAmountField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 5)]
        public CreditLineAmountType CreditLineAmount
        {
            get
            {
                return this.creditLineAmountField;
            }
            set
            {
                this.creditLineAmountField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 6)]
        public BalanceAmountType BalanceAmount
        {
            get
            {
                return this.balanceAmountField;
            }
            set
            {
                this.balanceAmountField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 7)]
        public PaymentPurposeCodeType PaymentPurposeCode
        {
            get
            {
                return this.paymentPurposeCodeField;
            }
            set
            {
                this.paymentPurposeCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public PaymentMeansType PaymentMeans
        {
            get
            {
                return this.paymentMeansField;
            }
            set
            {
                this.paymentMeansField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PaymentTerms", Order = 9)]
        public PaymentTermsType[] PaymentTerms
        {
            get
            {
                return this.paymentTermsField;
            }
            set
            {
                this.paymentTermsField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public CustomerPartyType BuyerCustomerParty
        {
            get
            {
                return this.buyerCustomerPartyField;
            }
            set
            {
                this.buyerCustomerPartyField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public SupplierPartyType SellerSupplierParty
        {
            get
            {
                return this.sellerSupplierPartyField;
            }
            set
            {
                this.sellerSupplierPartyField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public CustomerPartyType OriginatorCustomerParty
        {
            get
            {
                return this.originatorCustomerPartyField;
            }
            set
            {
                this.originatorCustomerPartyField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
        public CustomerPartyType AccountingCustomerParty
        {
            get
            {
                return this.accountingCustomerPartyField;
            }
            set
            {
                this.accountingCustomerPartyField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
        public SupplierPartyType AccountingSupplierParty
        {
            get
            {
                return this.accountingSupplierPartyField;
            }
            set
            {
                this.accountingSupplierPartyField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 15)]
        public PartyType PayeeParty
        {
            get
            {
                return this.payeePartyField;
            }
            set
            {
                this.payeePartyField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InvoicePeriod", Order = 16)]
        public PeriodType[] InvoicePeriod
        {
            get
            {
                return this.invoicePeriodField;
            }
            set
            {
                this.invoicePeriodField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BillingReference", Order = 17)]
        public BillingReferenceType[] BillingReference
        {
            get
            {
                return this.billingReferenceField;
            }
            set
            {
                this.billingReferenceField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DocumentReference", Order = 18)]
        public DocumentReferenceType[] DocumentReference
        {
            get
            {
                return this.documentReferenceField;
            }
            set
            {
                this.documentReferenceField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 19)]
        public ExchangeRateType ExchangeRate
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
        [System.Xml.Serialization.XmlElementAttribute("AllowanceCharge", Order = 20)]
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

        
    }
}