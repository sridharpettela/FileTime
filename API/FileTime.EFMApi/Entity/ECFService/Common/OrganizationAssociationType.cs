namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OrganizationAssociationType1))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public partial class OrganizationAssociationType : AssociationType
    {

        private ReferenceType[] organizationReferenceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OrganizationReference", Order = 0)]
        public ReferenceType[] OrganizationReference
        {
            get
            {
                return this.organizationReferenceField;
            }
            set
            {
                this.organizationReferenceField = value;
                
            }
        }
    }
}