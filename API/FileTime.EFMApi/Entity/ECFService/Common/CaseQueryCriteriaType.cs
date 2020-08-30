namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CaseQueryMessage-4.0")]
    public partial class CaseQueryCriteriaType : ComplexObjectType
    {

        private boolean includeParticipantsIndicatorField;

        private boolean includeDocketEntryIndicatorField;

        private boolean includeCalendarEventIndicatorField;

        private TextType docketEntryTypeCodeFilterTextField;

        private TextType calendarEventTypeCodeFilterTextField;

        private DateRangeType docketEntryTimeRangeField;

        private DateRangeType calendarEventTimeRangeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public boolean IncludeParticipantsIndicator
        {
            get
            {
                return this.includeParticipantsIndicatorField;
            }
            set
            {
                this.includeParticipantsIndicatorField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public boolean IncludeDocketEntryIndicator
        {
            get
            {
                return this.includeDocketEntryIndicatorField;
            }
            set
            {
                this.includeDocketEntryIndicatorField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public boolean IncludeCalendarEventIndicator
        {
            get
            {
                return this.includeCalendarEventIndicatorField;
            }
            set
            {
                this.includeCalendarEventIndicatorField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public TextType DocketEntryTypeCodeFilterText
        {
            get
            {
                return this.docketEntryTypeCodeFilterTextField;
            }
            set
            {
                this.docketEntryTypeCodeFilterTextField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public TextType CalendarEventTypeCodeFilterText
        {
            get
            {
                return this.calendarEventTypeCodeFilterTextField;
            }
            set
            {
                this.calendarEventTypeCodeFilterTextField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public DateRangeType DocketEntryTimeRange
        {
            get
            {
                return this.docketEntryTimeRangeField;
            }
            set
            {
                this.docketEntryTimeRangeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public DateRangeType CalendarEventTimeRange
        {
            get
            {
                return this.calendarEventTimeRangeField;
            }
            set
            {
                this.calendarEventTimeRangeField = value;
                
            }
        }
    }
}