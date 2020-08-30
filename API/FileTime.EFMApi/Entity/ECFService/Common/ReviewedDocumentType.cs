namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ReviewedDocumentType1))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CommonTypes-4.0")]
    public partial class ReviewedDocumentType : DocumentType1
    {

        private TextType documentHashTextField;

        private IdentificationType documentDocketIDField;

        private boolean sealDocumentIndicatorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public TextType DocumentHashText
        {
            get
            {
                return this.documentHashTextField;
            }
            set
            {
                this.documentHashTextField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public IdentificationType DocumentDocketID
        {
            get
            {
                return this.documentDocketIDField;
            }
            set
            {
                this.documentDocketIDField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public boolean SealDocumentIndicator
        {
            get
            {
                return this.sealDocumentIndicatorField;
            }
            set
            {
                this.sealDocumentIndicatorField = value;
                
            }
        }
    }
}