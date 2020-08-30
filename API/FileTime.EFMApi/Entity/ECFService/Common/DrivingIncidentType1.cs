namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "DrivingIncidentType", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CitationCase-4.0")]
    public partial class DrivingIncidentType1 : DrivingIncidentType
    {

        private IncidentAugmentationType incidentAugmentationField;

        private ActivityConveyanceAssociationType[] incidentVehicleAssociationField;

        private boolean redLightCameraIndicatorField;

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
        [System.Xml.Serialization.XmlElementAttribute("IncidentVehicleAssociation", Namespace = "http://niem.gov/niem/niem-core/2.0",  Order = 1)]
        public ActivityConveyanceAssociationType[] IncidentVehicleAssociation
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
        public boolean RedLightCameraIndicator
        {
            get
            {
                return this.redLightCameraIndicatorField;
            }
            set
            {
                this.redLightCameraIndicatorField = value;
                
            }
        }
    }
}