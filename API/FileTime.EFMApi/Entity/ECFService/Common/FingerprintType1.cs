namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "FingerprintType", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CriminalCase-4.0")]
    public partial class FingerprintType1 : FingerprintType
    {

        private ImageType[] fingerprintImageField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FingerprintImage", Order = 0)]
        public ImageType[] FingerprintImage
        {
            get
            {
                return this.fingerprintImageField;
            }
            set
            {
                this.fingerprintImageField = value;
                
            }
        }
    }
}