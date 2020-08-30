namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://niem.gov/niem/domains/jxdm/4.0")]
    public partial class WarrantType : CourtOrderType
    {

        private EXLCodeType item1Field;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("WarrantExtraditionLimitationCode",  Order = 0)]
        public EXLCodeType Item1
        {
            get
            {
                return this.item1Field;
            }
            set
            {
                this.item1Field = value;
                
            }
        }
    }
}