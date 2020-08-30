namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://niem.gov/niem/domains/jxdm/4.0")]
    public partial class AppellateCaseNoticeType : DocumentType
    {

        private TextType appellateCaseNoticeReasonTextField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 0)]
        public TextType AppellateCaseNoticeReasonText
        {
            get
            {
                return this.appellateCaseNoticeReasonTextField;
            }
            set
            {
                this.appellateCaseNoticeReasonTextField = value;
                
            }
        }
    }
}