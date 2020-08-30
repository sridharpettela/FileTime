namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:tyler:ecf:extensions:Criminal")]
    public partial class BondType
    {

        private TextType bondTypeTextField;

        private AmountType3 bondAmountField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public TextType BondTypeText
        {
            get
            {
                return this.bondTypeTextField;
            }
            set
            {
                this.bondTypeTextField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public AmountType3 BondAmount
        {
            get
            {
                return this.bondAmountField;
            }
            set
            {
                this.bondAmountField = value;
                
            }
        }

    }
}