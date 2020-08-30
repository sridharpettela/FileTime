namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class TransportationSegmentType
    {

        private SequenceNumberIDType sequenceNumberIDField;

        private TransportExecutionPlanReferenceIDType transportExecutionPlanReferenceIDField;

        private TransportModeCodeType transportModeCodeField;

        private TransportMeansTypeCodeType transportMeansTypeCodeField;

        private TransportationServiceType transportationServiceField;

        private PartyType transportServiceProviderPartyField;

        private TransportEquipmentType carryingTransportEquipmentField;

        private PackageType carryingPackageField;

        private TransportMeansType carryingTransportMeansField;

        private TransportLocationType departureTransportLocationField;

        private TransportLocationType[] intermediateTransportLocationField;

        private TransportLocationType arrivalTransportLocationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public SequenceNumberIDType SequenceNumberID
        {
            get
            {
                return this.sequenceNumberIDField;
            }
            set
            {
                this.sequenceNumberIDField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public TransportExecutionPlanReferenceIDType TransportExecutionPlanReferenceID
        {
            get
            {
                return this.transportExecutionPlanReferenceIDField;
            }
            set
            {
                this.transportExecutionPlanReferenceIDField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public TransportModeCodeType TransportModeCode
        {
            get
            {
                return this.transportModeCodeField;
            }
            set
            {
                this.transportModeCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public TransportationServiceType TransportationService
        {
            get
            {
                return this.transportationServiceField;
            }
            set
            {
                this.transportationServiceField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public PartyType TransportServiceProviderParty
        {
            get
            {
                return this.transportServiceProviderPartyField;
            }
            set
            {
                this.transportServiceProviderPartyField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public TransportEquipmentType CarryingTransportEquipment
        {
            get
            {
                return this.carryingTransportEquipmentField;
            }
            set
            {
                this.carryingTransportEquipmentField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public PackageType CarryingPackage
        {
            get
            {
                return this.carryingPackageField;
            }
            set
            {
                this.carryingPackageField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public TransportMeansType CarryingTransportMeans
        {
            get
            {
                return this.carryingTransportMeansField;
            }
            set
            {
                this.carryingTransportMeansField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public TransportLocationType DepartureTransportLocation
        {
            get
            {
                return this.departureTransportLocationField;
            }
            set
            {
                this.departureTransportLocationField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IntermediateTransportLocation", Order = 10)]
        public TransportLocationType[] IntermediateTransportLocation
        {
            get
            {
                return this.intermediateTransportLocationField;
            }
            set
            {
                this.intermediateTransportLocationField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public TransportLocationType ArrivalTransportLocation
        {
            get
            {
                return this.arrivalTransportLocationField;
            }
            set
            {
                this.arrivalTransportLocationField = value;
                
            }
        }

        
    }
}