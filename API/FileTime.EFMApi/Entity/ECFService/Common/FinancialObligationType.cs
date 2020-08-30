namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:DomesticCase-4.0")]
    public partial class FinancialObligationType : ObligationType
    {

        private AmountType3[] obligationPaymentAmountField;

        private boolean obligationIncomeAttachedIndicatorField;

        private boolean obligationStateDisbursementIndicatorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ObligationPaymentAmount", Order = 0)]
        public AmountType3[] ObligationPaymentAmount
        {
            get
            {
                return this.obligationPaymentAmountField;
            }
            set
            {
                this.obligationPaymentAmountField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public boolean ObligationIncomeAttachedIndicator
        {
            get
            {
                return this.obligationIncomeAttachedIndicatorField;
            }
            set
            {
                this.obligationIncomeAttachedIndicatorField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public boolean ObligationStateDisbursementIndicator
        {
            get
            {
                return this.obligationStateDisbursementIndicatorField;
            }
            set
            {
                this.obligationStateDisbursementIndicatorField = value;
                
            }
        }
    }
}