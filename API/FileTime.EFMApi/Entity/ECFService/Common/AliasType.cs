namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CommonTypes-4.0")]
    public partial class AliasType : ComplexObjectType
    {

        private TextType aliasAlternateNameField;

        private TextType[] aliasAlternateNameTypeCodeField;

        private ReferenceType[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public TextType AliasAlternateName
        {
            get
            {
                return this.aliasAlternateNameField;
            }
            set
            {
                this.aliasAlternateNameField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AliasAlternateNameTypeCode", Order = 1)]
        public TextType[] AliasAlternateNameTypeCode
        {
            get
            {
                return this.aliasAlternateNameTypeCodeField;
            }
            set
            {
                this.aliasAlternateNameTypeCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EntityReference", Namespace = "http://niem.gov/niem/niem-core/2.0", Order = 2)]
        public ReferenceType[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
                
            }
        }
    }
}