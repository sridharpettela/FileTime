using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "OrganizationType", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CommonTypes-4.0")]
    public partial class OrganizationType1 : OrganizationType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://niem.gov/niem/domains/jxdm/4.0", Order = 0)]
        public OrganizationAugmentationType OrganizationAugmentation { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OrganizationAugmentation", Order = 1)]
        public OrganizationAugmentationType1 OrganizationAugmentation1 { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OrganizationType1))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EnforcementUnitType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CourtType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public partial class OrganizationType : ComplexObjectType
    {

        private IdentificationType organizationIdentificationField;

        private LocationType2 organizationLocationField;

        private TextType organizationNameField;

        private ContactInformationType organizationPrimaryContactInformationField;

        private TextType organizationSubUnitNameField;

        private IdentificationType organizationTaxIdentificationField;

        private TextType organizationUnitNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public IdentificationType OrganizationIdentification
        {
            get
            {
                return this.organizationIdentificationField;
            }
            set
            {
                this.organizationIdentificationField = value;

            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public LocationType2 OrganizationLocation
        {
            get
            {
                return this.organizationLocationField;
            }
            set
            {
                this.organizationLocationField = value;

            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public TextType OrganizationName
        {
            get
            {
                return this.organizationNameField;
            }
            set
            {
                this.organizationNameField = value;

            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public ContactInformationType OrganizationPrimaryContactInformation
        {
            get
            {
                return this.organizationPrimaryContactInformationField;
            }
            set
            {
                this.organizationPrimaryContactInformationField = value;

            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public TextType OrganizationSubUnitName
        {
            get
            {
                return this.organizationSubUnitNameField;
            }
            set
            {
                this.organizationSubUnitNameField = value;

            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public IdentificationType OrganizationTaxIdentification
        {
            get
            {
                return this.organizationTaxIdentificationField;
            }
            set
            {
                this.organizationTaxIdentificationField = value;

            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public TextType OrganizationUnitName
        {
            get
            {
                return this.organizationUnitNameField;
            }
            set
            {
                this.organizationUnitNameField = value;

            }
        }
    }

}
