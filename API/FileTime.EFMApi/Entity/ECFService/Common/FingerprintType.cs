namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FingerprintType1))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://niem.gov/niem/ansi-nist/2.0")]
    public partial class FingerprintType : ComplexObjectType
    {

        private FPCCodeType fingerPositionCodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 0)]
        public FPCCodeType FingerPositionCode
        {
            get
            {
                return this.fingerPositionCodeField;
            }
            set
            {
                this.fingerPositionCodeField = value;
                
            }
        }
    }
}