namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public partial class ObligationExemptionType : ComplexObjectType
    {

        private AmountType3 financialObligationExemptionAmountField;

        private TextType obligationExemptionDescriptionTextField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 0)]
        public AmountType3 FinancialObligationExemptionAmount
        {
            get
            {
                return this.financialObligationExemptionAmountField;
            }
            set
            {
                this.financialObligationExemptionAmountField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 1)]
        public TextType ObligationExemptionDescriptionText
        {
            get
            {
                return this.obligationExemptionDescriptionTextField;
            }
            set
            {
                this.obligationExemptionDescriptionTextField = value;
                
            }
        }
    }
}