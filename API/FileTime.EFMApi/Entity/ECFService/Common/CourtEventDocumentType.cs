namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CommonTypes-4.0")]
    public partial class CourtEventDocumentType : DocumentType1
    {

        private DocumentType[] connectedDocumentField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ConnectedDocument", Order = 0)]
        public DocumentType[] ConnectedDocument
        {
            get
            {
                return this.connectedDocumentField;
            }
            set
            {
                this.connectedDocumentField = value;
                
            }
        }
    }
}