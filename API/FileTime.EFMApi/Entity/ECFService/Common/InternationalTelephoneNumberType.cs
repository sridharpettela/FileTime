namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public partial class InternationalTelephoneNumberType : ComplexObjectType
    {

        private @string telephoneCountryCodeIDField;

        private @string telephoneNumberIDField;

        private @string telephoneSuffixIDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 0)]
        public @string TelephoneCountryCodeID
        {
            get
            {
                return this.telephoneCountryCodeIDField;
            }
            set
            {
                this.telephoneCountryCodeIDField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 1)]
        public @string TelephoneNumberID
        {
            get
            {
                return this.telephoneNumberIDField;
            }
            set
            {
                this.telephoneNumberIDField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 2)]
        public @string TelephoneSuffixID
        {
            get
            {
                return this.telephoneSuffixIDField;
            }
            set
            {
                this.telephoneSuffixIDField = value;
                
            }
        }
    }
}