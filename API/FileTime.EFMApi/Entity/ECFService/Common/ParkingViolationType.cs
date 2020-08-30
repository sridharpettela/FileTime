namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CitationCase-4.0")]
    public partial class ParkingViolationType : IncidentType
    {

        private IncidentAugmentationType incidentAugmentationField;

        private ActivityConveyanceAssociationType incidentVehicleAssociationField;

        private TextType parkingFacilityNameField;

        private NumericType2 parkingMeterSpaceNumberField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://niem.gov/niem/domains/jxdm/4.0", Order = 0)]
        public IncidentAugmentationType IncidentAugmentation
        {
            get
            {
                return this.incidentAugmentationField;
            }
            set
            {
                this.incidentAugmentationField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0",  Order = 1)]
        public ActivityConveyanceAssociationType IncidentVehicleAssociation
        {
            get
            {
                return this.incidentVehicleAssociationField;
            }
            set
            {
                this.incidentVehicleAssociationField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public TextType ParkingFacilityName
        {
            get
            {
                return this.parkingFacilityNameField;
            }
            set
            {
                this.parkingFacilityNameField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public NumericType2 ParkingMeterSpaceNumber
        {
            get
            {
                return this.parkingMeterSpaceNumberField;
            }
            set
            {
                this.parkingMeterSpaceNumberField = value;
                
            }
        }
    }
}