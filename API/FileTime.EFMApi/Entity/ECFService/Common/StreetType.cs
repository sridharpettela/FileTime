namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public partial class StreetType : ComplexObjectType
    {

        private TextType streetFullTextField;

        private TextType streetNumberTextField;

        private TextType streetPredirectionalTextField;

        private ProperNameTextType streetNameField;

        private TextType streetCategoryTextField;

        private TextType streetPostdirectionalTextField;

        private TextType streetExtensionTextField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 0)]
        public TextType StreetFullText
        {
            get
            {
                return this.streetFullTextField;
            }
            set
            {
                this.streetFullTextField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 1)]
        public TextType StreetNumberText
        {
            get
            {
                return this.streetNumberTextField;
            }
            set
            {
                this.streetNumberTextField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 2)]
        public TextType StreetPredirectionalText
        {
            get
            {
                return this.streetPredirectionalTextField;
            }
            set
            {
                this.streetPredirectionalTextField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 3)]
        public ProperNameTextType StreetName
        {
            get
            {
                return this.streetNameField;
            }
            set
            {
                this.streetNameField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 4)]
        public TextType StreetCategoryText
        {
            get
            {
                return this.streetCategoryTextField;
            }
            set
            {
                this.streetCategoryTextField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 5)]
        public TextType StreetPostdirectionalText
        {
            get
            {
                return this.streetPostdirectionalTextField;
            }
            set
            {
                this.streetPostdirectionalTextField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 6)]
        public TextType StreetExtensionText
        {
            get
            {
                return this.streetExtensionTextField;
            }
            set
            {
                this.streetExtensionTextField = value;
                
            }
        }
    }
}