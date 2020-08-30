namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SentenceType1))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://niem.gov/niem/domains/jxdm/4.0")]
    public partial class SentenceType : ActivityType
    {

        private ChargeType1[] sentenceChargeField;

        private TextType sentenceDescriptionTextField;

        private TermType sentenceTermField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SentenceCharge",  Order = 0)]
        public ChargeType1[] SentenceCharge
        {
            get
            {
                return this.sentenceChargeField;
            }
            set
            {
                this.sentenceChargeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 1)]
        public TextType SentenceDescriptionText
        {
            get
            {
                return this.sentenceDescriptionTextField;
            }
            set
            {
                this.sentenceDescriptionTextField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 2)]
        public TermType SentenceTerm
        {
            get
            {
                return this.sentenceTermField;
            }
            set
            {
                this.sentenceTermField = value;
                
            }
        }
    }
}