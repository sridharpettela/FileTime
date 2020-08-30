namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public partial class DriverLicenseAssociationType : AssociationType
    {

        private ReferenceType driverLicenseReferenceField;

        private ReferenceType personReferenceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public ReferenceType DriverLicenseReference
        {
            get
            {
                return this.driverLicenseReferenceField;
            }
            set
            {
                this.driverLicenseReferenceField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public ReferenceType PersonReference
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