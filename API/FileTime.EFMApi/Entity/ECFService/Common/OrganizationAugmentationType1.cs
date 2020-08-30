namespace FileTime.EFMApi.Entity.ECFService
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://niem.gov/niem/domains/jxdm/4.0")]
    public partial class OrganizationAugmentationType : AugmentationType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true,Order = 0)]
        public IdentificationType OrganizationORIIdentification { get; set; }
    }
}