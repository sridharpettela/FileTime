namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CaseAugmentationType2))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "CaseAugmentationType", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CommonTypes-4.0")]
    public partial class CaseAugmentationType1 : ComplexObjectType
    {

        private LanguageCodeType itemField;

        private AliasType[] aliasField;

        private CaseOfficialType1[] caseOfficialField;

        private CaseOfficialType1[] caseOtherEntityAttorneyField;

        private CaseParticipantType[] caseParticipantField;

        private TextType caseShortTitleTextField;

        private OrganizationAssociationType1[] organizationAssociationField;

        private PersonAssociationType1[] personAssociationField;

        private PersonOrganizationAssociationType1[] personOrganizationAssociationField;

        private RelatedCaseAssociationType[] relatedCaseAssociationField;


        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LanguageCode", Namespace = "http://niem.gov/niem/niem-core/2.0",  Order = 0)]
        public LanguageCodeType Item
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
        [System.Xml.Serialization.XmlElementAttribute("Alias", Order = 1)]
        public AliasType[] Alias
        {
            get
            {
                return this.aliasField;
            }
            set
            {
                this.aliasField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CaseOfficial", Order = 2)]
        public CaseOfficialType1[] CaseOfficial
        {
            get
            {
                return this.caseOfficialField;
            }
            set
            {
                this.caseOfficialField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CaseOtherEntityAttorney", Order = 3)]
        public CaseOfficialType1[] CaseOtherEntityAttorney
        {
            get
            {
                return this.caseOtherEntityAttorneyField;
            }
            set
            {
                this.caseOtherEntityAttorneyField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CaseParticipant", Order = 4, Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CommonTypes-4.0")]
        public CaseParticipantType[] CaseParticipant
        {
            get
            {
                return this.caseParticipantField;
            }
            set
            {
                this.caseParticipantField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public TextType CaseShortTitleText
        {
            get
            {
                return this.caseShortTitleTextField;
            }
            set
            {
                this.caseShortTitleTextField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OrganizationAssociation", Order = 6)]
        public OrganizationAssociationType1[] OrganizationAssociation
        {
            get
            {
                return this.organizationAssociationField;
            }
            set
            {
                this.organizationAssociationField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonAssociation", Order = 7)]
        public PersonAssociationType1[] PersonAssociation
        {
            get
            {
                return this.personAssociationField;
            }
            set
            {
                this.personAssociationField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonOrganizationAssociation", Order = 8)]
        public PersonOrganizationAssociationType1[] PersonOrganizationAssociation
        {
            get
            {
                return this.personOrganizationAssociationField;
            }
            set
            {
                this.personOrganizationAssociationField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RelatedCaseAssociation", Order = 9)]
        public RelatedCaseAssociationType[] RelatedCaseAssociation
        {
            get
            {
                return this.relatedCaseAssociationField;
            }
            set
            {
                this.relatedCaseAssociationField = value;
                
            }
        }

    }
}