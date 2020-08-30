namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:tyler:ecf:extensions:Common")]
    public partial class ProcedureRemedyType
    {

        private TextType[] remedyCodeField;

        private TextType damageAmountCodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RemedyCode", Order = 0)]
        public TextType[] RemedyCode
        {
            get
            {
                return this.remedyCodeField;
            }
            set
            {
                this.remedyCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public TextType DamageAmountCode
        {
            get
            {
                return this.damageAmountCodeField;
            }
            set
            {
                this.damageAmountCodeField = value;
                
            }
        }

        
    }
}