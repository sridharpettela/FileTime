namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://niem.gov/niem/domains/jxdm/4.0")]
    public partial class RegisteredOffenderType : ComplexObjectType
    {

        private IdentificationType registeredOffenderIdentificationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 0)]
        public IdentificationType RegisteredOffenderIdentification
        {
            get
            {
                return this.registeredOffenderIdentificationField;
            }
            set
            {
                this.registeredOffenderIdentificationField = value;
                
            }
        }
    }
}