namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CommonTypes-4.0")]
    public partial class DocumentMetadataType : MetadataType
    {

        private TextType registerActionDescriptionTextField;

        private ReferenceType parentDocumentReferenceField;

        private IdentificationType priorRelatedDocumentIDField;

        private IdentificationType filingAttorneyIDField;

        private IdentificationType[] filingPartyIDField;

        private TextType specialHandlingInstructionsField;

        private boolean redactionRequiredIndicatorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://niem.gov/niem/domains/jxdm/4.0",  Order = 0)]
        public TextType RegisterActionDescriptionText
        {
            get
            {
                return this.registerActionDescriptionTextField;
            }
            set
            {
                this.registerActionDescriptionTextField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public ReferenceType ParentDocumentReference
        {
            get
            {
                return this.parentDocumentReferenceField;
            }
            set
            {
                this.parentDocumentReferenceField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public IdentificationType PriorRelatedDocumentID
        {
            get
            {
                return this.priorRelatedDocumentIDField;
            }
            set
            {
                this.priorRelatedDocumentIDField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public IdentificationType FilingAttorneyID
        {
            get
            {
                return this.filingAttorneyIDField;
            }
            set
            {
                this.filingAttorneyIDField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FilingPartyID", Order = 4)]
        public IdentificationType[] FilingPartyID
        {
            get
            {
                return this.filingPartyIDField;
            }
            set
            {
                this.filingPartyIDField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public TextType SpecialHandlingInstructions
        {
            get
            {
                return this.specialHandlingInstructionsField;
            }
            set
            {
                this.specialHandlingInstructionsField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public boolean RedactionRequiredIndicator
        {
            get
            {
                return this.redactionRequiredIndicatorField;
            }
            set
            {
                this.redactionRequiredIndicatorField = value;
                
            }
        }
    }
}