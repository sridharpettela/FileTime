namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public partial class DrivingRestrictionType : ComplexObjectType
    {

        private object itemField;

        private DateType drivingRestrictionEndDateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DrivingRestrictionCode", typeof(DrivingRestrictionCodeType),  Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("DrivingRestrictionText", typeof(TextType),  Order = 0)]
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

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 1)]
        public DateType DrivingRestrictionEndDate
        {
            get
            {
                return this.drivingRestrictionEndDateField;
            }
            set
            {
                this.drivingRestrictionEndDateField = value;
                
            }
        }
    }
}