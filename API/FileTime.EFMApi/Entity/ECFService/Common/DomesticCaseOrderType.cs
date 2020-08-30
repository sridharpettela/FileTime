namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:DomesticCase-4.0")]
    public partial class DomesticCaseOrderType : CourtOrderType
    {

        private TextType domesticCaseOrderTypeTextField;

        private TextType courtFindingsTextField;

        private DomesticCaseObligationType[] domesticCaseObligationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public TextType DomesticCaseOrderTypeText
        {
            get
            {
                return this.domesticCaseOrderTypeTextField;
            }
            set
            {
                this.domesticCaseOrderTypeTextField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public TextType CourtFindingsText
        {
            get
            {
                return this.courtFindingsTextField;
            }
            set
            {
                this.courtFindingsTextField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DomesticCaseObligation", Order = 2)]
        public DomesticCaseObligationType[] DomesticCaseObligation
        {
            get
            {
                return this.domesticCaseObligationField;
            }
            set
            {
                this.domesticCaseObligationField = value;
                
            }
        }
    }
}