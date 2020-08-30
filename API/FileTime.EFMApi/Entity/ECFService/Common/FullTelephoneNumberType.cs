namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public partial class FullTelephoneNumberType : ComplexObjectType
    {

        private @string telephoneNumberFullIDField;

        private @string telephoneSuffixIDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 0)]
        public @string TelephoneNumberFullID
        {
            get
            {
                return this.telephoneNumberFullIDField;
            }
            set
            {
                this.telephoneNumberFullIDField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 1)]
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