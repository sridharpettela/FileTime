namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class DeclarationType
    {

        private NameType1[] nameField;

        private DeclarationTypeCodeType declarationTypeCodeField;

        private DescriptionType[] descriptionField;

        private EvidenceSuppliedIDType[] evidenceSuppliedIDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Name", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public NameType1[] Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public DeclarationTypeCodeType DeclarationTypeCode
        {
            get
            {
                return this.declarationTypeCodeField;
            }
            set
            {
                this.declarationTypeCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
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

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EvidenceSuppliedID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public EvidenceSuppliedIDType[] EvidenceSuppliedID
        {
            get
            {
                return this.evidenceSuppliedIDField;
            }
            set
            {
                this.evidenceSuppliedIDField = value;
                
            }
        }

        

    }
}