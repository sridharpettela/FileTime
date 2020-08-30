namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class ContractExtensionType
    {

        private OptionsDescriptionType[] optionsDescriptionField;

        private MinimumNumberNumericType minimumNumberNumericField;

        private MaximumNumberNumericType maximumNumberNumericField;

        private PeriodType optionValidityPeriodField;

        private RenewalType[] renewalField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OptionsDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public OptionsDescriptionType[] OptionsDescription
        {
            get
            {
                return this.optionsDescriptionField;
            }
            set
            {
                this.optionsDescriptionField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public MinimumNumberNumericType MinimumNumberNumeric
        {
            get
            {
                return this.minimumNumberNumericField;
            }
            set
            {
                this.minimumNumberNumericField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public MaximumNumberNumericType MaximumNumberNumeric
        {
            get
            {
                return this.maximumNumberNumericField;
            }
            set
            {
                this.maximumNumberNumericField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public PeriodType OptionValidityPeriod
        {
            get
            {
                return this.optionValidityPeriodField;
            }
            set
            {
                this.optionValidityPeriodField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Renewal", Order = 4)]
        public RenewalType[] Renewal
        {
            get
            {
                return this.renewalField;
            }
            set
            {
                this.renewalField = value;
                
            }
        }

        

       
    }
}