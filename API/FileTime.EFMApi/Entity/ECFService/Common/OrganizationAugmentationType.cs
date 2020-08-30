namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "OrganizationAugmentationType", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CommonTypes-4.0")]
    public partial class OrganizationAugmentationType1 : AugmentationType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public ElectronicServiceInformationType ElectronicServiceInformation { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ContactInformation", Namespace = "http://niem.gov/niem/niem-core/2.0", Order = 1)]
        public ContactInformationType[] ContactInformation { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OrganizationContactInformationAssociation", Namespace = "http://niem.gov/niem/niem-core/2.0", Order = 2)]
        public OrganizationContactInformationAssociationType[] OrganizationContactInformationAssociation { get; set; }
    }
}