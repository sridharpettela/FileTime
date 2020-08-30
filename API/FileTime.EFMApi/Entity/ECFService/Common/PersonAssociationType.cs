namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PersonUnionAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MarriageAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PersonAssociationType1))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PersonFiduciaryAssociationType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public partial class PersonAssociationType : AssociationType
    {

        private ReferenceType[] personReferenceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonReference", Order = 0)]
        public ReferenceType[] PersonReference
        {
            get
            {
                return this.personReferenceField;
            }
            set
            {
                this.personReferenceField = value;
                
            }
        }
    }
}