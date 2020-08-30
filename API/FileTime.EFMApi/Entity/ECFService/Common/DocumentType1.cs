namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ReviewedDocumentType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ReviewedDocumentType1))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CourtEventDocumentType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExtendedDocumentType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "DocumentType", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CommonTypes-4.0")]
    public class DocumentType1 : DocumentType
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public DocumentMetadataType DocumentMetadata { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DocumentRendition", Order = 1)]
        public DocumentRenditionType[] DocumentRendition { get; set; }
    }
}