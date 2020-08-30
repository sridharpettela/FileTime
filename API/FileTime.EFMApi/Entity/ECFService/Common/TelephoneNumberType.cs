namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public partial class TelephoneNumberType : ComplexObjectType
    {

        private ComplexObjectType itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FullTelephoneNumber", typeof(FullTelephoneNumberType),  Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("InternationalTelephoneNumber", typeof(InternationalTelephoneNumberType),  Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("NANPTelephoneNumber", typeof(NANPTelephoneNumberType),  Order = 0)]
        public ComplexObjectType Item
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
    }
}