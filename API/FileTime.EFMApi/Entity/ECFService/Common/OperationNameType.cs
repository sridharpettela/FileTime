namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CourtPolicyResponseMessage-4.0" +
                                                           "")]
    public partial class OperationNameType
    {

        private string idField;

        private string metadataField;

        private string linkMetadataField;

        private OperationNameSimpleType valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://niem.gov/niem/structures/2.0", DataType = "ID")]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://niem.gov/niem/structures/2.0", DataType = "IDREFS")]
        public string metadata
        {
            get
            {
                return this.metadataField;
            }
            set
            {
                this.metadataField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://niem.gov/niem/structures/2.0", DataType = "IDREFS")]
        public string linkMetadata
        {
            get
            {
                return this.linkMetadataField;
            }
            set
            {
                this.linkMetadataField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public OperationNameSimpleType Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
                
            }
        }

        

        
    }
}