namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public partial class DNALocusType : ComplexObjectType
    {

        private TextType dNALocusCategoryTextField;

        private TextType[] dNALocusValueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 0)]
        public TextType DNALocusCategoryText
        {
            get
            {
                return this.dNALocusCategoryTextField;
            }
            set
            {
                this.dNALocusCategoryTextField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DNALocusValue",  Order = 1)]
        public TextType[] DNALocusValue
        {
            get
            {
                return this.dNALocusValueField;
            }
            set
            {
                this.dNALocusValueField = value;
                
            }
        }
    }
}