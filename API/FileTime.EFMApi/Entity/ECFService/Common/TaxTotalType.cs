namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class TaxTotalType
    {

        private TaxAmountType taxAmountField;

        private RoundingAmountType roundingAmountField;

        private TaxEvidenceIndicatorType taxEvidenceIndicatorField;

        private TaxIncludedIndicatorType taxIncludedIndicatorField;

        private TaxSubtotalType[] taxSubtotalField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public TaxAmountType TaxAmount
        {
            get
            {
                return this.taxAmountField;
            }
            set
            {
                this.taxAmountField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public RoundingAmountType RoundingAmount
        {
            get
            {
                return this.roundingAmountField;
            }
            set
            {
                this.roundingAmountField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public TaxEvidenceIndicatorType TaxEvidenceIndicator
        {
            get
            {
                return this.taxEvidenceIndicatorField;
            }
            set
            {
                this.taxEvidenceIndicatorField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public TaxIncludedIndicatorType TaxIncludedIndicator
        {
            get
            {
                return this.taxIncludedIndicatorField;
            }
            set
            {
                this.taxIncludedIndicatorField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TaxSubtotal", Order = 4)]
        public TaxSubtotalType[] TaxSubtotal
        {
            get
            {
                return this.taxSubtotalField;
            }
            set
            {
                this.taxSubtotalField = value;
                
            }
        }

        
    }
}