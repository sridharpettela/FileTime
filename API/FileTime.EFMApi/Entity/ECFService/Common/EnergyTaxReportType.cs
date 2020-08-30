namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class EnergyTaxReportType
    {

        private TaxEnergyAmountType taxEnergyAmountField;

        private TaxEnergyOnAccountAmountType taxEnergyOnAccountAmountField;

        private TaxEnergyBalanceAmountType taxEnergyBalanceAmountField;

        private TaxSchemeType taxSchemeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public TaxEnergyAmountType TaxEnergyAmount
        {
            get
            {
                return this.taxEnergyAmountField;
            }
            set
            {
                this.taxEnergyAmountField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public TaxEnergyOnAccountAmountType TaxEnergyOnAccountAmount
        {
            get
            {
                return this.taxEnergyOnAccountAmountField;
            }
            set
            {
                this.taxEnergyOnAccountAmountField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public TaxEnergyBalanceAmountType TaxEnergyBalanceAmount
        {
            get
            {
                return this.taxEnergyBalanceAmountField;
            }
            set
            {
                this.taxEnergyBalanceAmountField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public TaxSchemeType TaxScheme
        {
            get
            {
                return this.taxSchemeField;
            }
            set
            {
                this.taxSchemeField = value;
                
            }
        }

        

      
    }
}