namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:DomesticCase-4.0")]
    public partial class DomesticCaseObligationType : ObligationRecurrenceType
    {

        private FinancialObligationType[] financialObligationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FinancialObligation", Order = 0)]
        public FinancialObligationType[] FinancialObligation
        {
            get
            {
                return this.financialObligationField;
            }
            set
            {
                this.financialObligationField = value;
                
            }
        }
    }
}