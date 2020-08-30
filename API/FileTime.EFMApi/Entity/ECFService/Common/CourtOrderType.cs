namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DomesticCaseOrderType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WarrantType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://niem.gov/niem/domains/jxdm/4.0")]
    public partial class CourtOrderType : ActivityType
    {

        private StatusType courtOrderStatusField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 0)]
        public StatusType CourtOrderStatus
        {
            get
            {
                return this.courtOrderStatusField;
            }
            set
            {
                this.courtOrderStatusField = value;
                
            }
        }
    }
}