namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class TransportMeansType
    {

        private JourneyIDType journeyIDField;

        private RegistrationNationalityIDType registrationNationalityIDField;

        private RegistrationNationalityType[] registrationNationalityField;

        private DirectionCodeType directionCodeField;

        private TransportMeansTypeCodeType transportMeansTypeCodeField;

        private TradeServiceCodeType tradeServiceCodeField;

        private StowageType stowageField;

        private AirTransportType airTransportField;

        private RoadTransportType roadTransportField;

        private RailTransportType railTransportField;

        private MaritimeTransportType maritimeTransportField;

        private PartyType ownerPartyField;

        private PartyType[] operatorPartyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public JourneyIDType JourneyID
        {
            get
            {
                return this.journeyIDField;
            }
            set
            {
                this.journeyIDField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public RegistrationNationalityIDType RegistrationNationalityID
        {
            get
            {
                return this.registrationNationalityIDField;
            }
            set
            {
                this.registrationNationalityIDField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RegistrationNationality", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public RegistrationNationalityType[] RegistrationNationality
        {
            get
            {
                return this.registrationNationalityField;
            }
            set
            {
                this.registrationNationalityField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public DirectionCodeType DirectionCode
        {
            get
            {
                return this.directionCodeField;
            }
            set
            {
                this.directionCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
        public TransportMeansTypeCodeType TransportMeansTypeCode
        {
            get
            {
                return this.transportMeansTypeCodeField;
            }
            set
            {
                this.transportMeansTypeCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 5)]
        public TradeServiceCodeType TradeServiceCode
        {
            get
            {
                return this.tradeServiceCodeField;
            }
            set
            {
                this.tradeServiceCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public StowageType Stowage
        {
            get
            {
                return this.stowageField;
            }
            set
            {
                this.stowageField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public AirTransportType AirTransport
        {
            get
            {
                return this.airTransportField;
            }
            set
            {
                this.airTransportField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public RoadTransportType RoadTransport
        {
            get
            {
                return this.roadTransportField;
            }
            set
            {
                this.roadTransportField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public RailTransportType RailTransport
        {
            get
            {
                return this.railTransportField;
            }
            set
            {
                this.railTransportField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public MaritimeTransportType MaritimeTransport
        {
            get
            {
                return this.maritimeTransportField;
            }
            set
            {
                this.maritimeTransportField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public PartyType OwnerParty
        {
            get
            {
                return this.ownerPartyField;
            }
            set
            {
                this.ownerPartyField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OperatorParty", Order = 12)]
        public PartyType[] OperatorParty
        {
            get
            {
                return this.operatorPartyField;
            }
            set
            {
                this.operatorPartyField = value;
                
            }
        }

        
    }
}