namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class HazardousGoodsTransitType
    {

        private TransportEmergencyCardCodeType transportEmergencyCardCodeField;

        private PackingCriteriaCodeType packingCriteriaCodeField;

        private HazardousRegulationCodeType hazardousRegulationCodeField;

        private InhalationToxicityZoneCodeType inhalationToxicityZoneCodeField;

        private TransportAuthorizationCodeType transportAuthorizationCodeField;

        private TemperatureType maximumTemperatureField;

        private TemperatureType minimumTemperatureField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public TransportEmergencyCardCodeType TransportEmergencyCardCode
        {
            get
            {
                return this.transportEmergencyCardCodeField;
            }
            set
            {
                this.transportEmergencyCardCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public PackingCriteriaCodeType PackingCriteriaCode
        {
            get
            {
                return this.packingCriteriaCodeField;
            }
            set
            {
                this.packingCriteriaCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public HazardousRegulationCodeType HazardousRegulationCode
        {
            get
            {
                return this.hazardousRegulationCodeField;
            }
            set
            {
                this.hazardousRegulationCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public InhalationToxicityZoneCodeType InhalationToxicityZoneCode
        {
            get
            {
                return this.inhalationToxicityZoneCodeField;
            }
            set
            {
                this.inhalationToxicityZoneCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
        public TransportAuthorizationCodeType TransportAuthorizationCode
        {
            get
            {
                return this.transportAuthorizationCodeField;
            }
            set
            {
                this.transportAuthorizationCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public TemperatureType MaximumTemperature
        {
            get
            {
                return this.maximumTemperatureField;
            }
            set
            {
                this.maximumTemperatureField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public TemperatureType MinimumTemperature
        {
            get
            {
                return this.minimumTemperatureField;
            }
            set
            {
                this.minimumTemperatureField = value;
                
            }
        }

        

       
    }
}