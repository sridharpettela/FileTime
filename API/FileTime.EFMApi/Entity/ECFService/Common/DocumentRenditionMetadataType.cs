namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CommonTypes-4.0")]
    public partial class DocumentRenditionMetadataType : ComplexObjectType
    {

        private DocumentAttachmentType[] documentAttachmentField;

        private boolean colorRelevantIndicatorField;

        private boolean redactedIndicatorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DocumentAttachment", Order = 0)]
        public DocumentAttachmentType[] DocumentAttachment
        {
            get
            {
                return this.documentAttachmentField;
            }
            set
            {
                this.documentAttachmentField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public boolean ColorRelevantIndicator
        {
            get
            {
                return this.colorRelevantIndicatorField;
            }
            set
            {
                this.colorRelevantIndicatorField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public boolean RedactedIndicator
        {
            get
            {
                return this.redactedIndicatorField;
            }
            set
            {
                this.redactedIndicatorField = value;
                
            }
        }
    }
}