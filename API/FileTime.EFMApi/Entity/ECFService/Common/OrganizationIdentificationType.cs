namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:tyler:ecf:extensions:Common")]
    public partial class OrganizationIdentificationType : IdentificationType
    {

        private IdentificationType[] identificationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Identification", Order = 0)]
        public IdentificationType[] Identification
        {
            get
            {
                return this.identificationField;
            }
            set
            {
                this.identificationField = value;
                
            }
        }
    }
}