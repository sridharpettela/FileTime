namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class NotificationRequirementType
    {

        private NotificationTypeCodeType notificationTypeCodeField;

        private PartyType[] notifyPartyField;

        private PeriodType preEventPeriodField;

        private PeriodType postEventPeriodField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public NotificationTypeCodeType NotificationTypeCode
        {
            get
            {
                return this.notificationTypeCodeField;
            }
            set
            {
                this.notificationTypeCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NotifyParty", Order = 1)]
        public PartyType[] NotifyParty
        {
            get
            {
                return this.notifyPartyField;
            }
            set
            {
                this.notifyPartyField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public PeriodType PreEventPeriod
        {
            get
            {
                return this.preEventPeriodField;
            }
            set
            {
                this.preEventPeriodField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public PeriodType PostEventPeriod
        {
            get
            {
                return this.postEventPeriodField;
            }
            set
            {
                this.postEventPeriodField = value;
                
            }
        }

        

       
    }
}