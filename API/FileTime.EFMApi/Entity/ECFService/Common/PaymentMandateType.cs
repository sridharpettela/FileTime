namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class PaymentMandateType
    {

        private IDType idField;

        private MandateTypeCodeType mandateTypeCodeField;

        private ClauseType[] clauseField;

        private ClauseCodeType[] clauseCodeField;

        private MaximumPaymentInstructionsNumericType maximumPaymentInstructionsNumericField;

        private MaximumPaidAmountType maximumPaidAmountField;

        private SignatureIDType signatureIDField;

        private PartyType payerPartyField;

        private FinancialAccountType payerFinancialAccountField;

        private PeriodType validityPeriodField;

        private PeriodType paymentReversalPeriodField;

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
        public MandateTypeCodeType MandateTypeCode
        {
            get
            {
                return this.mandateTypeCodeField;
            }
            set
            {
                this.mandateTypeCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Clause", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public ClauseType[] Clause
        {
            get
            {
                return this.clauseField;
            }
            set
            {
                this.clauseField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ClauseCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public ClauseCodeType[] ClauseCode
        {
            get
            {
                return this.clauseCodeField;
            }
            set
            {
                this.clauseCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
        public MaximumPaymentInstructionsNumericType MaximumPaymentInstructionsNumeric
        {
            get
            {
                return this.maximumPaymentInstructionsNumericField;
            }
            set
            {
                this.maximumPaymentInstructionsNumericField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 5)]
        public MaximumPaidAmountType MaximumPaidAmount
        {
            get
            {
                return this.maximumPaidAmountField;
            }
            set
            {
                this.maximumPaidAmountField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 6)]
        public SignatureIDType SignatureID
        {
            get
            {
                return this.signatureIDField;
            }
            set
            {
                this.signatureIDField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public PartyType PayerParty
        {
            get
            {
                return this.payerPartyField;
            }
            set
            {
                this.payerPartyField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public FinancialAccountType PayerFinancialAccount
        {
            get
            {
                return this.payerFinancialAccountField;
            }
            set
            {
                this.payerFinancialAccountField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public PeriodType ValidityPeriod
        {
            get
            {
                return this.validityPeriodField;
            }
            set
            {
                this.validityPeriodField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public PeriodType PaymentReversalPeriod
        {
            get
            {
                return this.paymentReversalPeriodField;
            }
            set
            {
                this.paymentReversalPeriodField = value;
                
            }
        }

        

    }
}