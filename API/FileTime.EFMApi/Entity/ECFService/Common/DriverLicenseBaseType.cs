namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DriverLicenseType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public partial class DriverLicenseBaseType : ComplexObjectType
    {

        private IdentificationType driverLicenseIdentificationField;

        private DateType driverLicenseExpirationDateField;

        private DateType driverLicenseIssueDateField;

        private DrivingRestrictionType driverLicenseRestrictionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 0)]
        public IdentificationType DriverLicenseIdentification
        {
            get
            {
                return this.driverLicenseIdentificationField;
            }
            set
            {
                this.driverLicenseIdentificationField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 1)]
        public DateType DriverLicenseExpirationDate
        {
            get
            {
                return this.driverLicenseExpirationDateField;
            }
            set
            {
                this.driverLicenseExpirationDateField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 2)]
        public DateType DriverLicenseIssueDate
        {
            get
            {
                return this.driverLicenseIssueDateField;
            }
            set
            {
                this.driverLicenseIssueDateField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 3)]
        public DrivingRestrictionType DriverLicenseRestriction
        {
            get
            {
                return this.driverLicenseRestrictionField;
            }
            set
            {
                this.driverLicenseRestrictionField = value;
                
            }
        }
    }
}