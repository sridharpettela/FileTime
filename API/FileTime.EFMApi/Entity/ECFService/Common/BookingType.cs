namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://niem.gov/niem/domains/jxdm/4.0")]
    public partial class BookingType : ActivityType
    {

        private IdentificationType bookingAgencyRecordIdentificationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 0)]
        public IdentificationType BookingAgencyRecordIdentification
        {
            get
            {
                return this.bookingAgencyRecordIdentificationField;
            }
            set
            {
                this.bookingAgencyRecordIdentificationField = value;
                
            }
        }
    }
}