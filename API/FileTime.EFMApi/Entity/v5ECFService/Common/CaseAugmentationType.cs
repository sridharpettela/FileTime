using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTime.EFMApi.Entity.v5ECFService
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute("CaseAugmentation", Namespace = "https://docs.oasis-open.org/legalxml-courtfiling/ns/v5.0/civil")]
    [System.Xml.Serialization.XmlRootAttribute("CaseAugmentation", Namespace = "https://docs.oasis-open.org/legalxml-courtfiling/ns/v5.0/civil", IsNullable = false)]
    public partial class CivilCaseAugmentationType : AugmentationType
    {
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public AmountType AmountInControversy { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public boolean CivilClassActionIndicator { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public DecedentEstateCaseType DecedentEstateCase { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public FiduciaryCaseAssociationType FiduciaryCaseAssociation { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public TextType JurisdictionalGroundsCode { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public boolean JuryDemandIndicator { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Namespace = "https://docs.oasis-open.org/legalxml-courtfiling/ns/v5.0/ecf", Order = 7)]
        public TextType CauseOfActionCode { get; set; }


        [System.Xml.Serialization.XmlElementAttribute("ReliefTypeCode", Order = 6)]
        public TextType[] ReliefTypeCode { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://docs.oasis-open.org/legalxml-courtfiling/ns/v5.0/civil")]
    [System.Xml.Serialization.XmlRootAttribute("DecedentEstateCase", Namespace = "https://docs.oasis-open.org/legalxml-courtfiling/ns/v5.0/civil", IsNullable = false)]
    public partial class DecedentEstateCaseType : ObjectType
    {

        [System.Xml.Serialization.XmlElementAttribute( Order = 0)]
        public PersonType Decedent { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public DateType WillFilingDate { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://release.niem.gov/niem/niem-core/4.0/", Order = 2)]
        public DateType PersonDeathDate { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://docs.oasis-open.org/legalxml-courtfiling/ns/v5.0/civil")]
    [System.Xml.Serialization.XmlRootAttribute("FiduciaryCaseAssociation", Namespace = "https://docs.oasis-open.org/legalxml-courtfiling/ns/v5.0/civil", IsNullable = false)]
    public partial class FiduciaryCaseAssociationType : PersonCaseAssociationType
    {

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public TextType FiduciaryTypeCode { get; set; }

    }

    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FiduciaryCaseAssociationType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://release.niem.gov/niem/domains/humanServices/4.0/")]
    public partial class PersonCaseAssociationType : AssociationType1
    {

        private PersonType[] personField;

        private object[] personCaseAssociationAugmentationPointField;

        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://release.niem.gov/niem/niem-core/4.0/",  Order = 1)]
        public CaseType Case { get; set; }


        [System.Xml.Serialization.XmlElementAttribute("Person", Namespace = "http://release.niem.gov/niem/niem-core/4.0/",  Order = 0)]
        public PersonType[] Person
        {
            get
            {
                return this.personField;
            }
            set
            {
                this.personField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("PersonCaseAssociationAugmentationPoint", Order = 2)]
        public object[] PersonCaseAssociationAugmentationPoint
        {
            get
            {
                return this.personCaseAssociationAugmentationPointField;
            }
            set
            {
                this.personCaseAssociationAugmentationPointField = value;
            }
        }
    }
}
