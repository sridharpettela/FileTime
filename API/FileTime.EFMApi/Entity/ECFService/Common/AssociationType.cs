namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RelatedActivityAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RelatedCaseAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PersonOrganizationAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PersonOrganizationAssociationType1))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PersonEmploymentAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PersonContactInformationAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PersonAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PersonUnionAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MarriageAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PersonAssociationType1))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PersonFiduciaryAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OrganizationContactInformationAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OrganizationAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OrganizationAssociationType1))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ImmediateFamilyAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GuardianAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GuardianAssociationType1))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DriverLicenseAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ActivityConveyanceAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ViolatedStatuteAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PersonChargeAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DocumentCourtAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ActivityLocationAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FilingAssociationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PlacementAssociationType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public partial class AssociationType : ComplexObjectType
    {
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:tyler:ecf:extensions:Common")]
    public partial class FilingAssociationType : AssociationType
    {

        private ReferenceType partyReferenceField;

        private ReferenceType filingReferenceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public ReferenceType PartyReference
        {
            get
            {
                return this.partyReferenceField;
            }
            set
            {
                this.partyReferenceField = value;

            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public ReferenceType FilingReference
        {
            get
            {
                return this.filingReferenceField;
            }
            set
            {
                this.filingReferenceField = value;

            }
        }
    }
}