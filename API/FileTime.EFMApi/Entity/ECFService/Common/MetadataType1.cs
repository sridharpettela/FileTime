namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "MetadataType", Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public partial class MetadataType1 : MetadataType
    {

        private TextType sensitivityTextField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 0)]
        public TextType SensitivityText
        {
            get
            {
                return this.sensitivityTextField;
            }
            set
            {
                this.sensitivityTextField = value;
                
            }
        }
    }
}