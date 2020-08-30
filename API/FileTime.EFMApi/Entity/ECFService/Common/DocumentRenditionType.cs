namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CommonTypes-4.0")]
    public partial class DocumentRenditionType : ComplexObjectType
    {

        private DocumentSignatureType[] documentSignatureField;

        private DocumentRenditionMetadataType documentRenditionMetadataField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DocumentSignature", Order = 0)]
        public DocumentSignatureType[] DocumentSignature
        {
            get
            {
                return this.documentSignatureField;
            }
            set
            {
                this.documentSignatureField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public DocumentRenditionMetadataType DocumentRenditionMetadata
        {
            get
            {
                return this.documentRenditionMetadataField;
            }
            set
            {
                this.documentRenditionMetadataField = value;
                
            }
        }
    }
}