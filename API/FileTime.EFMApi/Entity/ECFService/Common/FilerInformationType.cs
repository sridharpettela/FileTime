namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:tyler:ecf:extensions:Common")]
    public partial class FilerInformationType
    {

        private TextType filerNameField;

        private TextType firmNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public TextType FilerName
        {
            get
            {
                return this.filerNameField;
            }
            set
            {
                this.filerNameField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public TextType FirmName
        {
            get
            {
                return this.firmNameField;
            }
            set
            {
                this.firmNameField = value;
                
            }
        }

        

      
    }
}