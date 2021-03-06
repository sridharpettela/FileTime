namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://niem.gov/niem/domains/jxdm/4.0")]
    public partial class ActivityLocationAssociationType : AssociationType
    {

        private ReferenceType activityReferenceField;

        private ReferenceType locationReferenceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0", Order = 0)]
        public ReferenceType ActivityReference
        {
            get
            {
                return this.activityReferenceField;
            }
            set
            {
                this.activityReferenceField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0", Order = 1)]
        public ReferenceType LocationReference
        {
            get
            {
                return this.locationReferenceField;
            }
            set
            {
                this.locationReferenceField = value;
                
            }
        }
    }
}