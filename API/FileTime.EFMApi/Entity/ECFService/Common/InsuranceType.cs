namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InsuranceType1))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public partial class InsuranceType : ComplexObjectType
    {

        private TextType insuranceCarrierNameField;

        private boolean insuranceActiveIndicatorField;

        private TextType itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 0)]
        public TextType InsuranceCarrierName
        {
            get
            {
                return this.insuranceCarrierNameField;
            }
            set
            {
                this.insuranceCarrierNameField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 1)]
        public boolean InsuranceActiveIndicator
        {
            get
            {
                return this.insuranceActiveIndicatorField;
            }
            set
            {
                this.insuranceActiveIndicatorField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InsuranceCoverageCategoryText",  Order = 2)]
        public TextType Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
                
            }
        }
    }
}