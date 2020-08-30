namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignaturePropertiesType
    {

        private SignaturePropertyType[] signaturePropertyField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SignatureProperty", Order = 0)]
        public SignaturePropertyType[] SignatureProperty
        {
            get
            {
                return this.signaturePropertyField;
            }
            set
            {
                this.signaturePropertyField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
                
            }
        }

        

    }
}