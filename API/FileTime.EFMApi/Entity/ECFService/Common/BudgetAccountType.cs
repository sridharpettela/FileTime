namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class BudgetAccountType
    {

        private IDType idField;

        private BudgetYearNumericType budgetYearNumericField;

        private ClassificationSchemeType requiredClassificationSchemeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public IDType ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public BudgetYearNumericType BudgetYearNumeric
        {
            get
            {
                return this.budgetYearNumericField;
            }
            set
            {
                this.budgetYearNumericField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public ClassificationSchemeType RequiredClassificationScheme
        {
            get
            {
                return this.requiredClassificationSchemeField;
            }
            set
            {
                this.requiredClassificationSchemeField = value;
                
            }
        }

        
    }
}