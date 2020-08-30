namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CommonTypes-4.0")]
    public partial class PersonAugmentationType : AugmentationType
    {

        private DriverLicenseType personDriverLicenseField;

        private InsuranceType1[] personInsuranceField;

        private ElectronicServiceInformationType electronicServiceInformationField;

        private ContactInformationType[] contactInformationField;

        private PersonContactInformationAssociationType[] personContactInformationAssociationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public DriverLicenseType PersonDriverLicense
        {
            get
            {
                return this.personDriverLicenseField;
            }
            set
            {
                this.personDriverLicenseField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonInsurance", Order = 1)]
        public InsuranceType1[] PersonInsurance
        {
            get
            {
                return this.personInsuranceField;
            }
            set
            {
                this.personInsuranceField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public ElectronicServiceInformationType ElectronicServiceInformation
        {
            get
            {
                return this.electronicServiceInformationField;
            }
            set
            {
                this.electronicServiceInformationField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ContactInformation", Namespace = "http://niem.gov/niem/niem-core/2.0",  Order = 3)]
        public ContactInformationType[] ContactInformation
        {
            get
            {
                return this.contactInformationField;
            }
            set
            {
                this.contactInformationField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonContactInformationAssociation", Namespace = "http://niem.gov/niem/niem-core/2.0",  Order = 4)]
        public PersonContactInformationAssociationType[] PersonContactInformationAssociation
        {
            get
            {
                return this.personContactInformationAssociationField;
            }
            set
            {
                this.personContactInformationAssociationField = value;
                
            }
        }
    }
}