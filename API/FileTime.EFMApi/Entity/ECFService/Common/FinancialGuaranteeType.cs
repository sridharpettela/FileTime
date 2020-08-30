namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class FinancialGuaranteeType
    {

        private GuaranteeTypeCodeType guaranteeTypeCodeField;

        private DescriptionType[] descriptionField;

        private LiabilityAmountType liabilityAmountField;

        private AmountRateType amountRateField;

        private PeriodType constitutionPeriodField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public GuaranteeTypeCodeType GuaranteeTypeCode
        {
            get
            {
                return this.guaranteeTypeCodeField;
            }
            set
            {
                this.guaranteeTypeCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public DescriptionType[] Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public LiabilityAmountType LiabilityAmount
        {
            get
            {
                return this.liabilityAmountField;
            }
            set
            {
                this.liabilityAmountField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public AmountRateType AmountRate
        {
            get
            {
                return this.amountRateField;
            }
            set
            {
                this.amountRateField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public PeriodType ConstitutionPeriod
        {
            get
            {
                return this.constitutionPeriodField;
            }
            set
            {
                this.constitutionPeriodField = value;
                
            }
        }

        

       
    }
}