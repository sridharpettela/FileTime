namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RelatedCaseAssociationType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public partial class RelatedActivityAssociationType : AssociationType
    {

        private ReferenceType[] activityReferenceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ActivityReference", Order = 0)]
        public ReferenceType[] ActivityReference
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
    }
}