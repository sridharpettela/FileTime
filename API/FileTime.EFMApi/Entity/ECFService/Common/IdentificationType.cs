namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ServiceContactIdentificationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OrganizationIdentificationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DocumentOptionalServiceType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public partial class IdentificationType : ComplexObjectType
    {

        private @string identificationIDField;

        private TextType itemField;

        private object identificationJurisdictionField;

        private TextType identificationSourceTextField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order = 0)]
        public @string IdentificationID
        {
            get
            {
                return this.identificationIDField;
            }
            set
            {
                this.identificationIDField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IdentificationCategoryText",  Order = 1)]
        public TextType Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public object IdentificationJurisdiction
        {
            get
            {
                return this.identificationJurisdictionField;
            }
            set
            {
                this.identificationJurisdictionField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 3)]
        public TextType IdentificationSourceText
        {
            get
            {
                return this.identificationSourceTextField;
            }
            set
            {
                this.identificationSourceTextField = value;
                
            }
        }
    }
}