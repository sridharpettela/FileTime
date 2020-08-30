namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:JuvenileCase-4.0")]
    public partial class JuvenileType : SubjectType2
    {

        private PersonOrganizationAssociationType[] personGangAssociationField;

        private RegisteredOffenderType registeredSexOffenderField;

        private GuardianAssociationType1[] guardianAssociationField;

        private boolean personEmancipatedIndicatorField;

        private PlacementAssociationType placementAssociationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonGangAssociation", Namespace = "http://niem.gov/niem/niem-core/2.0",  Order = 0)]
        public PersonOrganizationAssociationType[] PersonGangAssociation
        {
            get
            {
                return this.personGangAssociationField;
            }
            set
            {
                this.personGangAssociationField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://niem.gov/niem/domains/jxdm/4.0",  Order = 1)]
        public RegisteredOffenderType RegisteredSexOffender
        {
            get
            {
                return this.registeredSexOffenderField;
            }
            set
            {
                this.registeredSexOffenderField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("GuardianAssociation", Order = 2)]
        public GuardianAssociationType1[] GuardianAssociation
        {
            get
            {
                return this.guardianAssociationField;
            }
            set
            {
                this.guardianAssociationField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public boolean PersonEmancipatedIndicator
        {
            get
            {
                return this.personEmancipatedIndicatorField;
            }
            set
            {
                this.personEmancipatedIndicatorField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public PlacementAssociationType PlacementAssociation
        {
            get
            {
                return this.placementAssociationField;
            }
            set
            {
                this.placementAssociationField = value;
                
            }
        }
    }
}