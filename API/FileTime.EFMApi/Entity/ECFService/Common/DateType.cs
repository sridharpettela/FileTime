namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public partial class DateType : ComplexObjectType
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Date", typeof(date),  Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("DateTime", typeof(dateTime),  Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("Year", typeof(gYear),  Order = 0)]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
                
            }
        }
    }
}