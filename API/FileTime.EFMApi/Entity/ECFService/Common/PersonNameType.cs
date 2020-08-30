namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public partial class PersonNameType : ComplexObjectType
    {

        private TextType personNamePrefixTextField;

        private PersonNameTextType personGivenNameField;

        private PersonNameTextType personMiddleNameField;

        private PersonNameTextType personSurNameField;

        private TextType personNameSuffixTextField;

        private PersonNameTextType personMaidenNameField;

        private PersonNameTextType personFullNameField;

        private string personNameCommentTextField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 0)]
        public TextType PersonNamePrefixText
        {
            get
            {
                return this.personNamePrefixTextField;
            }
            set
            {
                this.personNamePrefixTextField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 1)]
        public PersonNameTextType PersonGivenName
        {
            get
            {
                return this.personGivenNameField;
            }
            set
            {
                this.personGivenNameField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 2)]
        public PersonNameTextType PersonMiddleName
        {
            get
            {
                return this.personMiddleNameField;
            }
            set
            {
                this.personMiddleNameField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 3)]
        public PersonNameTextType PersonSurName
        {
            get
            {
                return this.personSurNameField;
            }
            set
            {
                this.personSurNameField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 4)]
        public TextType PersonNameSuffixText
        {
            get
            {
                return this.personNameSuffixTextField;
            }
            set
            {
                this.personNameSuffixTextField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 5)]
        public PersonNameTextType PersonMaidenName
        {
            get
            {
                return this.personMaidenNameField;
            }
            set
            {
                this.personMaidenNameField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 6)]
        public PersonNameTextType PersonFullName
        {
            get
            {
                return this.personFullNameField;
            }
            set
            {
                this.personFullNameField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string personNameCommentText
        {
            get
            {
                return this.personNameCommentTextField;
            }
            set
            {
                this.personNameCommentTextField = value;
                
            }
        }
    }
}