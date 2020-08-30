namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "SentenceType", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CriminalCase-4.0")]
    public partial class SentenceType1 : SentenceType
    {

        private RelatedActivityAssociationType[] sentenceConcurrentAssociationField;

        private AmountType3[] sentenceFineAmountField;

        private ReferenceType[] chargeReferenceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SentenceConcurrentAssociation", Order = 0)]
        public RelatedActivityAssociationType[] SentenceConcurrentAssociation
        {
            get
            {
                return this.sentenceConcurrentAssociationField;
            }
            set
            {
                this.sentenceConcurrentAssociationField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SentenceFineAmount", Order = 1)]
        public AmountType3[] SentenceFineAmount
        {
            get
            {
                return this.sentenceFineAmountField;
            }
            set
            {
                this.sentenceFineAmountField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ChargeReference", Namespace = "http://niem.gov/niem/domains/jxdm/4.0", Order = 2)]
        public ReferenceType[] ChargeReference
        {
            get
            {
                return this.chargeReferenceField;
            }
            set
            {
                this.chargeReferenceField = value;
                
            }
        }
    }
}