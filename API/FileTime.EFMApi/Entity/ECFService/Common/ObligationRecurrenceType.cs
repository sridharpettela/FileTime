namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DomesticCaseObligationType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public partial class ObligationRecurrenceType : ObligationType
    {

        private DateType obligationEndDateField;

        private TextType obligationPeriodTextField;

        private DateType obligationStartDateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 0)]
        public DateType ObligationEndDate
        {
            get
            {
                return this.obligationEndDateField;
            }
            set
            {
                this.obligationEndDateField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 1)]
        public TextType ObligationPeriodText
        {
            get
            {
                return this.obligationPeriodTextField;
            }
            set
            {
                this.obligationPeriodTextField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 2)]
        public DateType ObligationStartDate
        {
            get
            {
                return this.obligationStartDateField;
            }
            set
            {
                this.obligationStartDateField = value;
                
            }
        }
    }
}