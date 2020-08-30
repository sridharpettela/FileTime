namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:AppellateCase-4.0")]
    public partial class AppellateCourtRuleCaseType : ComplexObjectType
    {

        private TextType ruleCollectionTextField;

        private NumericType2[] ruleCollectionNumberField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public TextType RuleCollectionText
        {
            get
            {
                return this.ruleCollectionTextField;
            }
            set
            {
                this.ruleCollectionTextField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RuleCollectionNumber", Order = 1)]
        public NumericType2[] RuleCollectionNumber
        {
            get
            {
                return this.ruleCollectionNumberField;
            }
            set
            {
                this.ruleCollectionNumberField = value;
                
            }
        }
    }
}