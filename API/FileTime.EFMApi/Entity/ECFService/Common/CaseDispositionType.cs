namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public partial class CaseDispositionType : DispositionType
    {

        private DateType caseDispositionFinalDateField;

        private CaseDispositionDecisionType[] caseDispositionDecisionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 0)]
        public DateType CaseDispositionFinalDate
        {
            get
            {
                return this.caseDispositionFinalDateField;
            }
            set
            {
                this.caseDispositionFinalDateField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CaseDispositionDecision",  Order = 1)]
        public CaseDispositionDecisionType[] CaseDispositionDecision
        {
            get
            {
                return this.caseDispositionDecisionField;
            }
            set
            {
                this.caseDispositionDecisionField = value;
                
            }
        }
    }
}