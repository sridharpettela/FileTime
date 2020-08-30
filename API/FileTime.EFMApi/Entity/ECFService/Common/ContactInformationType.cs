namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public partial class ContactInformationType : ComplexObjectType
    {

        private object[] itemsField;

        private EntityType contactEntityField;

        private TextType contactEntityDescriptionTextField;

        private TextType contactInformationDescriptionTextField;

        private PersonType1 contactResponderField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ContactEmailID", typeof(@string),  Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("ContactMailingAddress", typeof(AddressType1),  Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("ContactTelephoneNumber", typeof(TelephoneNumberType),  Order = 0)]
        public object[] Items
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

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 1)]
        public EntityType ContactEntity
        {
            get
            {
                return this.contactEntityField;
            }
            set
            {
                this.contactEntityField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 2)]
        public TextType ContactEntityDescriptionText
        {
            get
            {
                return this.contactEntityDescriptionTextField;
            }
            set
            {
                this.contactEntityDescriptionTextField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 3)]
        public TextType ContactInformationDescriptionText
        {
            get
            {
                return this.contactInformationDescriptionTextField;
            }
            set
            {
                this.contactInformationDescriptionTextField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 4)]
        public PersonType1 ContactResponder
        {
            get
            {
                return this.contactResponderField;
            }
            set
            {
                this.contactResponderField = value;
                
            }
        }
    }
}