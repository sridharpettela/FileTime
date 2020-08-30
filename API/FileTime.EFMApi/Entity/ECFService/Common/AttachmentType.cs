namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class AttachmentType
    {

        private EmbeddedDocumentBinaryObjectType embeddedDocumentBinaryObjectField;

        private ExternalReferenceType externalReferenceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public EmbeddedDocumentBinaryObjectType EmbeddedDocumentBinaryObject
        {
            get
            {
                return this.embeddedDocumentBinaryObjectField;
            }
            set
            {
                this.embeddedDocumentBinaryObjectField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public ExternalReferenceType ExternalReference
        {
            get
            {
                return this.externalReferenceField;
            }
            set
            {
                this.externalReferenceField = value;
                
            }
        }

        
    }
}