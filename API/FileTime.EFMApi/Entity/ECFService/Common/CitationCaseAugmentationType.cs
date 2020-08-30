namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CitationCase-4.0")]
    public partial class CitationCaseAugmentationType : ComplexObjectType
    {

        private CitationType citationField;

        private ChargeType1[] caseChargeField;

        private ViolatedStatuteAssociationType[] violatedStatuteAssociationField;

        private CourtAppearanceType courtAppearanceField;

        private SubjectType3 citationSubjectField;

        private VehicleType1[] vehicleField;

        private IncidentType itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://niem.gov/niem/domains/jxdm/4.0",  Order = 0)]
        public CitationType Citation
        {
            get
            {
                return this.citationField;
            }
            set
            {
                this.citationField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CaseCharge", Namespace = "http://niem.gov/niem/domains/jxdm/4.0",  Order = 1)]
        public ChargeType1[] CaseCharge
        {
            get
            {
                return this.caseChargeField;
            }
            set
            {
                this.caseChargeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ViolatedStatuteAssociation", Namespace = "http://niem.gov/niem/domains/jxdm/4.0",  Order = 2)]
        public ViolatedStatuteAssociationType[] ViolatedStatuteAssociation
        {
            get
            {
                return this.violatedStatuteAssociationField;
            }
            set
            {
                this.violatedStatuteAssociationField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://niem.gov/niem/domains/jxdm/4.0",  Order = 3)]
        public CourtAppearanceType CourtAppearance
        {
            get
            {
                return this.courtAppearanceField;
            }
            set
            {
                this.courtAppearanceField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public SubjectType3 CitationSubject
        {
            get
            {
                return this.citationSubjectField;
            }
            set
            {
                this.citationSubjectField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Vehicle", Order = 5)]
        public VehicleType1[] Vehicle
        {
            get
            {
                return this.vehicleField;
            }
            set
            {
                this.vehicleField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DrivingIncident", typeof(DrivingIncidentType1), Order = 6)]
        [System.Xml.Serialization.XmlElementAttribute("ParkingViolation", typeof(ParkingViolationType), Order = 6)]
        public IncidentType Item
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
    }
}