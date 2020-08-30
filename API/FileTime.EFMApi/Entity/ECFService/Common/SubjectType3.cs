namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "SubjectType", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CitationCase-4.0")]
    public partial class SubjectType3 : SubjectType2
    {

        private TextType personBloodAlcoholNumberField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public TextType PersonBloodAlcoholNumber
        {
            get
            {
                return this.personBloodAlcoholNumberField;
            }
            set
            {
                this.personBloodAlcoholNumberField = value;
                
            }
        }
    }
}