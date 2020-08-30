namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "PaymentType", Namespace = "urn:tyler:ecf:extensions:Common")]
    public partial class PaymentType1
    {

        private string accountNameField;

        private boolean waiverIndicatorField;

        private string cardTypeField;

        private int last4DigitsField;

        private int expirationMonthField;

        private int expirationYearField;

        private AmountType3 transactionAmountField;

        private string transactionResponseField;

        private string transactionIDField;

        private string orderIDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string AccountName
        {
            get
            {
                return this.accountNameField;
            }
            set
            {
                this.accountNameField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public boolean WaiverIndicator
        {
            get
            {
                return this.waiverIndicatorField;
            }
            set
            {
                this.waiverIndicatorField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string CardType
        {
            get
            {
                return this.cardTypeField;
            }
            set
            {
                this.cardTypeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public int Last4Digits { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public int ExpirationMonth { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public int ExpirationYear { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public AmountType3 TransactionAmount
        {
            get
            {
                return this.transactionAmountField;
            }
            set
            {
                this.transactionAmountField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string TransactionResponse
        {
            get
            {
                return this.transactionResponseField;
            }
            set
            {
                this.transactionResponseField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string TransactionID
        {
            get
            {
                return this.transactionIDField;
            }
            set
            {
                this.transactionIDField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string OrderID
        {
            get
            {
                return this.orderIDField;
            }
            set
            {
                this.orderIDField = value;
                
            }
        }

        

    }
}