namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public partial class BiometricType : ComplexObjectType
    {

        private ImageType[] biometricImageField;

        private EntityType biometricCapturerField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BiometricImage",  Order = 0)]
        public ImageType[] BiometricImage
        {
            get
            {
                return this.biometricImageField;
            }
            set
            {
                this.biometricImageField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 1)]
        public EntityType BiometricCapturer
        {
            get
            {
                return this.biometricCapturerField;
            }
            set
            {
                this.biometricCapturerField = value;
                
            }
        }
    }
}