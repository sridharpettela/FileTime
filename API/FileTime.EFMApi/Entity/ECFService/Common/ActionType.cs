namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:tyler:ecf:extensions:ServiceInformationHistoryResponseMessage")]
    public partial class ActionType
    {

        private TextType contactActionField;

        private DateType actionTimestampField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public TextType ContactAction
        {
            get
            {
                return this.contactActionField;
            }
            set
            {
                this.contactActionField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public DateType ActionTimestamp
        {
            get
            {
                return this.actionTimestampField;
            }
            set
            {
                this.actionTimestampField = value;
                
            }
        }
    }
}