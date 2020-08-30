namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public partial class DateRangeType : ComplexObjectType
    {

        private DateType startDateField;

        private DateType endDateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 0)]
        public DateType StartDate
        {
            get
            {
                return this.startDateField;
            }
            set
            {
                this.startDateField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 1)]
        public DateType EndDate
        {
            get
            {
                return this.endDateField;
            }
            set
            {
                this.endDateField = value;
                
            }
        }
    }
}