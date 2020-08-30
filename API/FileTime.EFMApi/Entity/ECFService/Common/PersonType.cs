namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class PersonType
    {

        private IDType idField;

        private FirstNameType firstNameField;

        private FamilyNameType familyNameField;

        private TitleType titleField;

        private MiddleNameType middleNameField;

        private NameSuffixType nameSuffixField;

        private JobTitleType jobTitleField;

        private NationalityIDType nationalityIDField;

        private GenderCodeType genderCodeField;

        private BirthDateType birthDateField;

        private OrganizationDepartmentType organizationDepartmentField;

        private ContactType contactField;

        private FinancialAccountType financialAccountField;

        private DocumentReferenceType identityDocumentReferenceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public IDType ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public FirstNameType FirstName
        {
            get
            {
                return this.firstNameField;
            }
            set
            {
                this.firstNameField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public FamilyNameType FamilyName
        {
            get
            {
                return this.familyNameField;
            }
            set
            {
                this.familyNameField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public TitleType Title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
        public MiddleNameType MiddleName
        {
            get
            {
                return this.middleNameField;
            }
            set
            {
                this.middleNameField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 5)]
        public NameSuffixType NameSuffix
        {
            get
            {
                return this.nameSuffixField;
            }
            set
            {
                this.nameSuffixField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 6)]
        public JobTitleType JobTitle
        {
            get
            {
                return this.jobTitleField;
            }
            set
            {
                this.jobTitleField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 7)]
        public NationalityIDType NationalityID
        {
            get
            {
                return this.nationalityIDField;
            }
            set
            {
                this.nationalityIDField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 8)]
        public GenderCodeType GenderCode
        {
            get
            {
                return this.genderCodeField;
            }
            set
            {
                this.genderCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 9)]
        public BirthDateType BirthDate
        {
            get
            {
                return this.birthDateField;
            }
            set
            {
                this.birthDateField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 10)]
        public OrganizationDepartmentType OrganizationDepartment
        {
            get
            {
                return this.organizationDepartmentField;
            }
            set
            {
                this.organizationDepartmentField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public ContactType Contact
        {
            get
            {
                return this.contactField;
            }
            set
            {
                this.contactField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public FinancialAccountType FinancialAccount
        {
            get
            {
                return this.financialAccountField;
            }
            set
            {
                this.financialAccountField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
        public DocumentReferenceType IdentityDocumentReference
        {
            get
            {
                return this.identityDocumentReferenceField;
            }
            set
            {
                this.identityDocumentReferenceField = value;
                
            }
        }

        

    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PersonFilerType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "PersonType", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CommonTypes-4.0")]
    public partial class PersonType2 : PersonType1
    {

        private PersonAugmentationType personAugmentationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public PersonAugmentationType PersonAugmentation
        {
            get
            {
                return this.personAugmentationField;
            }
            set
            {
                this.personAugmentationField = value;

            }
        }
    }

    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PersonType2))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PersonFilerType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "PersonType", Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public partial class PersonType1 : ComplexObjectType
    {

        private DateType personBirthDateField;

        private CapabilityType personCapabilityField;

        private CountryCodeType[] itemsField;

        private DNAType personDNAField;

        private object itemField;

        private EYECodeType item1Field;

        private FingerprintSetType[] personFingerprintSetField;

        private HAICodeType item2Field;

        private LengthMeasureType personHeightMeasureField;

        private boolean personLanguageEnglishIndicatorField;

        private PersonNameType personNameField;

        private IdentificationType[] personOtherIdentificationField;

        private PhysicalFeatureType[] personPhysicalFeatureField;

        private PersonLanguageType personPrimaryLanguageField;

        private object item3Field;

        private SEXCodeType item4Field;

        private IdentificationType personStateIdentificationField;

        private IdentificationType personTaxIdentificationField;

        private WeightMeasureType personWeightMeasureField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public DateType PersonBirthDate
        {
            get
            {
                return this.personBirthDateField;
            }
            set
            {
                this.personBirthDateField = value;

            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public CapabilityType PersonCapability
        {
            get
            {
                return this.personCapabilityField;
            }
            set
            {
                this.personCapabilityField = value;

            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonCitizenshipFIPS10-4Code", Order = 2)]
        public CountryCodeType[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;

            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public DNAType PersonDNA
        {
            get
            {
                return this.personDNAField;
            }
            set
            {
                this.personDNAField = value;

            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonEthnicityCode", typeof(EthnicityCodeType), Order = 4)]
        [System.Xml.Serialization.XmlElementAttribute("PersonEthnicityText", typeof(TextType), Order = 4)]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;

            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonEyeColorCode", Order = 5)]
        public EYECodeType Item1
        {
            get
            {
                return this.item1Field;
            }
            set
            {
                this.item1Field = value;

            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonFingerprintSet", Order = 6)]
        public FingerprintSetType[] PersonFingerprintSet
        {
            get
            {
                return this.personFingerprintSetField;
            }
            set
            {
                this.personFingerprintSetField = value;

            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonHairColorCode", Order = 7)]
        public HAICodeType Item2
        {
            get
            {
                return this.item2Field;
            }
            set
            {
                this.item2Field = value;

            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public LengthMeasureType PersonHeightMeasure
        {
            get
            {
                return this.personHeightMeasureField;
            }
            set
            {
                this.personHeightMeasureField = value;

            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public boolean PersonLanguageEnglishIndicator
        {
            get
            {
                return this.personLanguageEnglishIndicatorField;
            }
            set
            {
                this.personLanguageEnglishIndicatorField = value;

            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public PersonNameType PersonName
        {
            get
            {
                return this.personNameField;
            }
            set
            {
                this.personNameField = value;

            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonOtherIdentification", Order = 11)]
        public IdentificationType[] PersonOtherIdentification
        {
            get
            {
                return this.personOtherIdentificationField;
            }
            set
            {
                this.personOtherIdentificationField = value;

            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonPhysicalFeature", Order = 12)]
        public PhysicalFeatureType[] PersonPhysicalFeature
        {
            get
            {
                return this.personPhysicalFeatureField;
            }
            set
            {
                this.personPhysicalFeatureField = value;

            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
        public PersonLanguageType PersonPrimaryLanguage
        {
            get
            {
                return this.personPrimaryLanguageField;
            }
            set
            {
                this.personPrimaryLanguageField = value;

            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonRaceCode", typeof(RACCodeType), Order = 14)]
        [System.Xml.Serialization.XmlElementAttribute("PersonRaceText", typeof(TextType), Order = 14)]
        public object Item3
        {
            get
            {
                return this.item3Field;
            }
            set
            {
                this.item3Field = value;

            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonSexCode", Order = 15)]
        public SEXCodeType Item4
        {
            get
            {
                return this.item4Field;
            }
            set
            {
                this.item4Field = value;

            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 16)]
        public IdentificationType PersonStateIdentification
        {
            get
            {
                return this.personStateIdentificationField;
            }
            set
            {
                this.personStateIdentificationField = value;

            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 17)]
        public IdentificationType PersonTaxIdentification
        {
            get
            {
                return this.personTaxIdentificationField;
            }
            set
            {
                this.personTaxIdentificationField = value;

            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 18)]
        public WeightMeasureType PersonWeightMeasure
        {
            get
            {
                return this.personWeightMeasureField;
            }
            set
            {
                this.personWeightMeasureField = value;

            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:tyler:ecf:extensions:Common")]
    public partial class PersonFilerType : PersonType2
    {

        private TextType firmNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public TextType FirmName
        {
            get
            {
                return this.firmNameField;
            }
            set
            {
                this.firmNameField = value;

            }
        }
    }
}