namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://niem.gov/niem/domains/jxdm/4.0")]
    public partial class ArrestType : ActivityType
    {

        private OrganizationType arrestAgencyField;

        private IdentificationType arrestAgencyRecordIdentificationField;

        private TextType arrestBailRecommendationTextField;

        private TextType arrestBloodAlcoholContentNumberTextField;

        private ChargeType1[] arrestChargeField;

        private LocationType2 arrestLocationField;

        private EnforcementOfficialType[] arrestOfficialField;

        private SubjectType arrestSubjectField;

        private WarrantType arrestWarrantField;

        private BookingType bookingField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 0)]
        public OrganizationType ArrestAgency
        {
            get
            {
                return this.arrestAgencyField;
            }
            set
            {
                this.arrestAgencyField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 1)]
        public IdentificationType ArrestAgencyRecordIdentification
        {
            get
            {
                return this.arrestAgencyRecordIdentificationField;
            }
            set
            {
                this.arrestAgencyRecordIdentificationField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 2)]
        public TextType ArrestBailRecommendationText
        {
            get
            {
                return this.arrestBailRecommendationTextField;
            }
            set
            {
                this.arrestBailRecommendationTextField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 3)]
        public TextType ArrestBloodAlcoholContentNumberText
        {
            get
            {
                return this.arrestBloodAlcoholContentNumberTextField;
            }
            set
            {
                this.arrestBloodAlcoholContentNumberTextField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ArrestCharge",  Order = 4)]
        public ChargeType1[] ArrestCharge
        {
            get
            {
                return this.arrestChargeField;
            }
            set
            {
                this.arrestChargeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 5)]
        public LocationType2 ArrestLocation
        {
            get
            {
                return this.arrestLocationField;
            }
            set
            {
                this.arrestLocationField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ArrestOfficial",  Order = 6)]
        public EnforcementOfficialType[] ArrestOfficial
        {
            get
            {
                return this.arrestOfficialField;
            }
            set
            {
                this.arrestOfficialField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 7)]
        public SubjectType ArrestSubject
        {
            get
            {
                return this.arrestSubjectField;
            }
            set
            {
                this.arrestSubjectField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 8)]
        public WarrantType ArrestWarrant
        {
            get
            {
                return this.arrestWarrantField;
            }
            set
            {
                this.arrestWarrantField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 9)]
        public BookingType Booking
        {
            get
            {
                return this.bookingField;
            }
            set
            {
                this.bookingField = value;
                
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "LocationType", Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public partial class LocationType2 : ComplexObjectType
    {

        private AddressType1 locationAddressField;

        private TextType locationDescriptionTextField;

        private ProperNameTextType locationNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public AddressType1 LocationAddress
        {
            get
            {
                return this.locationAddressField;
            }
            set
            {
                this.locationAddressField = value;

            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public TextType LocationDescriptionText
        {
            get
            {
                return this.locationDescriptionTextField;
            }
            set
            {
                this.locationDescriptionTextField = value;

            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public ProperNameTextType LocationName
        {
            get
            {
                return this.locationNameField;
            }
            set
            {
                this.locationNameField = value;

            }
        }
    }
}