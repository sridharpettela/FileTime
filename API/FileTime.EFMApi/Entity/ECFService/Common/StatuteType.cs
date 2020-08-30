namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://niem.gov/niem/domains/jxdm/4.0")]
    public partial class StatuteType : ComplexObjectType
    {

        private IdentificationType statuteCodeIdentificationField;

        private IdentificationType statuteCodeSectionIdentificationField;

        private TextType statuteDescriptionTextField;

        private JurisdictionType statuteJurisdictionField;

        private TextType statuteLevelTextField;

        private IdentificationType statuteOffenseIdentificationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 0)]
        public IdentificationType StatuteCodeIdentification
        {
            get
            {
                return this.statuteCodeIdentificationField;
            }
            set
            {
                this.statuteCodeIdentificationField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 1)]
        public IdentificationType StatuteCodeSectionIdentification
        {
            get
            {
                return this.statuteCodeSectionIdentificationField;
            }
            set
            {
                this.statuteCodeSectionIdentificationField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 2)]
        public TextType StatuteDescriptionText
        {
            get
            {
                return this.statuteDescriptionTextField;
            }
            set
            {
                this.statuteDescriptionTextField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 3)]
        public JurisdictionType StatuteJurisdiction
        {
            get
            {
                return this.statuteJurisdictionField;
            }
            set
            {
                this.statuteJurisdictionField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 4)]
        public TextType StatuteLevelText
        {
            get
            {
                return this.statuteLevelTextField;
            }
            set
            {
                this.statuteLevelTextField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 5)]
        public IdentificationType StatuteOffenseIdentification
        {
            get
            {
                return this.statuteOffenseIdentificationField;
            }
            set
            {
                this.statuteOffenseIdentificationField = value;
                
            }
        }
    }
}