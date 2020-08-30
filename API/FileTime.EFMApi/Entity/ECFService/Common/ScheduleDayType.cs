namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public partial class ScheduleDayType : ComplexObjectType
    {

        private TextType scheduleActivityTextField;

        private DateType scheduleDateField;

        private time scheduleDayEndTimeField;

        private time scheduleDayStartTimeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 0)]
        public TextType ScheduleActivityText
        {
            get
            {
                return this.scheduleActivityTextField;
            }
            set
            {
                this.scheduleActivityTextField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 1)]
        public DateType ScheduleDate
        {
            get
            {
                return this.scheduleDateField;
            }
            set
            {
                this.scheduleDateField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 2)]
        public time ScheduleDayEndTime
        {
            get
            {
                return this.scheduleDayEndTimeField;
            }
            set
            {
                this.scheduleDayEndTimeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 3)]
        public time ScheduleDayStartTime
        {
            get
            {
                return this.scheduleDayStartTimeField;
            }
            set
            {
                this.scheduleDayStartTimeField = value;
                
            }
        }
    }
}