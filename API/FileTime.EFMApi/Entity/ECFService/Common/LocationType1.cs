namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "LocationType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class LocationType1
    {

        private IDType idField;

        private DescriptionType descriptionField;

        private ConditionsType conditionsField;

        private CountrySubentityType countrySubentityField;

        private CountrySubentityCodeType countrySubentityCodeField;

        private LocationTypeCodeType locationTypeCodeField;

        private InformationURIType informationURIField;

        private PeriodType[] validityPeriodField;

        private AddressType addressField;

        private LocationType1[] subsidiaryLocationField;

        private LocationCoordinateType[] locationCoordinateField;

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
        public DescriptionType Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public ConditionsType Conditions
        {
            get
            {
                return this.conditionsField;
            }
            set
            {
                this.conditionsField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public CountrySubentityType CountrySubentity
        {
            get
            {
                return this.countrySubentityField;
            }
            set
            {
                this.countrySubentityField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
        public CountrySubentityCodeType CountrySubentityCode
        {
            get
            {
                return this.countrySubentityCodeField;
            }
            set
            {
                this.countrySubentityCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 5)]
        public LocationTypeCodeType LocationTypeCode
        {
            get
            {
                return this.locationTypeCodeField;
            }
            set
            {
                this.locationTypeCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 6)]
        public InformationURIType InformationURI
        {
            get
            {
                return this.informationURIField;
            }
            set
            {
                this.informationURIField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ValidityPeriod", Order = 7)]
        public PeriodType[] ValidityPeriod
        {
            get
            {
                return this.validityPeriodField;
            }
            set
            {
                this.validityPeriodField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public AddressType Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SubsidiaryLocation", Order = 9)]
        public LocationType1[] SubsidiaryLocation
        {
            get
            {
                return this.subsidiaryLocationField;
            }
            set
            {
                this.subsidiaryLocationField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LocationCoordinate", Order = 10)]
        public LocationCoordinateType[] LocationCoordinate
        {
            get
            {
                return this.locationCoordinateField;
            }
            set
            {
                this.locationCoordinateField = value;
                
            }
        }

        

       
    }
}