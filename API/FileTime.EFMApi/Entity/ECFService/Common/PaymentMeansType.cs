namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class PaymentMeansType
    {

        private IDType idField;

        private PaymentMeansCodeType paymentMeansCodeField;

        private PaymentDueDateType paymentDueDateField;

        private PaymentChannelCodeType paymentChannelCodeField;

        private InstructionIDType instructionIDField;

        private InstructionNoteType[] instructionNoteField;

        private PaymentIDType[] paymentIDField;

        private CardAccountType cardAccountField;

        private FinancialAccountType payerFinancialAccountField;

        private FinancialAccountType payeeFinancialAccountField;

        private CreditAccountType creditAccountField;

        private PaymentMandateType paymentMandateField;

        private TradeFinancingType tradeFinancingField;

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
        public PaymentMeansCodeType PaymentMeansCode
        {
            get
            {
                return this.paymentMeansCodeField;
            }
            set
            {
                this.paymentMeansCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public PaymentDueDateType PaymentDueDate
        {
            get
            {
                return this.paymentDueDateField;
            }
            set
            {
                this.paymentDueDateField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public PaymentChannelCodeType PaymentChannelCode
        {
            get
            {
                return this.paymentChannelCodeField;
            }
            set
            {
                this.paymentChannelCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
        public InstructionIDType InstructionID
        {
            get
            {
                return this.instructionIDField;
            }
            set
            {
                this.instructionIDField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InstructionNote", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 5)]
        public InstructionNoteType[] InstructionNote
        {
            get
            {
                return this.instructionNoteField;
            }
            set
            {
                this.instructionNoteField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PaymentID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 6)]
        public PaymentIDType[] PaymentID
        {
            get
            {
                return this.paymentIDField;
            }
            set
            {
                this.paymentIDField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public CardAccountType CardAccount
        {
            get
            {
                return this.cardAccountField;
            }
            set
            {
                this.cardAccountField = value;
                
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
        public FinancialAccountType PayeeFinancialAccount
        {
            get
            {
                return this.payeeFinancialAccountField;
            }
            set
            {
                this.payeeFinancialAccountField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public CreditAccountType CreditAccount
        {
            get
            {
                return this.creditAccountField;
            }
            set
            {
                this.creditAccountField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public PaymentMandateType PaymentMandate
        {
            get
            {
                return this.paymentMandateField;
            }
            set
            {
                this.paymentMandateField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public TradeFinancingType TradeFinancing
        {
            get
            {
                return this.tradeFinancingField;
            }
            set
            {
                this.tradeFinancingField = value;
                
            }
        }

        

    }
}