namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:tyler:ecf:extensions:Common")]
    public partial class CaseAbstractorType : CaseParticipantType
    {

        private TextType abstractorNameField;

        private AmountType3 feesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public TextType AbstractorName
        {
            get
            {
                return this.abstractorNameField;
            }
            set
            {
                this.abstractorNameField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public AmountType3 Fees
        {
            get
            {
                return this.feesField;
            }
            set
            {
                this.feesField = value;
                
            }
        }
    }
}