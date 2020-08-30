namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class ExternalReferenceType
    {

        private URIType uRIField;

        private DocumentHashType documentHashField;

        private HashAlgorithmMethodType[] hashAlgorithmMethodField;

        private ExpiryDateType expiryDateField;

        private ExpiryTimeType expiryTimeField;

        private MimeCodeType mimeCodeField;

        private FormatCodeType formatCodeField;

        private EncodingCodeType encodingCodeField;

        private CharacterSetCodeType characterSetCodeField;

        private FileNameType fileNameField;

        private DescriptionType[] descriptionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public URIType URI
        {
            get
            {
                return this.uRIField;
            }
            set
            {
                this.uRIField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public DocumentHashType DocumentHash
        {
            get
            {
                return this.documentHashField;
            }
            set
            {
                this.documentHashField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("HashAlgorithmMethod", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public HashAlgorithmMethodType[] HashAlgorithmMethod
        {
            get
            {
                return this.hashAlgorithmMethodField;
            }
            set
            {
                this.hashAlgorithmMethodField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public ExpiryDateType ExpiryDate
        {
            get
            {
                return this.expiryDateField;
            }
            set
            {
                this.expiryDateField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
        public ExpiryTimeType ExpiryTime
        {
            get
            {
                return this.expiryTimeField;
            }
            set
            {
                this.expiryTimeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 5)]
        public MimeCodeType MimeCode
        {
            get
            {
                return this.mimeCodeField;
            }
            set
            {
                this.mimeCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 6)]
        public FormatCodeType FormatCode
        {
            get
            {
                return this.formatCodeField;
            }
            set
            {
                this.formatCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 7)]
        public EncodingCodeType EncodingCode
        {
            get
            {
                return this.encodingCodeField;
            }
            set
            {
                this.encodingCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 8)]
        public CharacterSetCodeType CharacterSetCode
        {
            get
            {
                return this.characterSetCodeField;
            }
            set
            {
                this.characterSetCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 9)]
        public FileNameType FileName
        {
            get
            {
                return this.fileNameField;
            }
            set
            {
                this.fileNameField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 10)]
        public DescriptionType[] Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
                
            }
        }

        

      
    }
}