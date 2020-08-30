namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class TransportEventType
    {

        private IdentificationIDType identificationIDField;

        private OccurrenceDateType occurrenceDateField;

        private OccurrenceTimeType occurrenceTimeField;

        private TransportEventTypeCodeType transportEventTypeCodeField;

        private DescriptionType descriptionField;

        private CompletionIndicatorType completionIndicatorField;

        private ShipmentType reportedShipmentField;

        private StatusType1[] currentStatusField;

        private ContactType[] contactField;

        private LocationType1 locationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public IdentificationIDType IdentificationID
        {
            get
            {
                return this.identificationIDField;
            }
            set
            {
                this.identificationIDField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public OccurrenceDateType OccurrenceDate
        {
            get
            {
                return this.occurrenceDateField;
            }
            set
            {
                this.occurrenceDateField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public OccurrenceTimeType OccurrenceTime
        {
            get
            {
                return this.occurrenceTimeField;
            }
            set
            {
                this.occurrenceTimeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public TransportEventTypeCodeType TransportEventTypeCode
        {
            get
            {
                return this.transportEventTypeCodeField;
            }
            set
            {
                this.transportEventTypeCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 5)]
        public CompletionIndicatorType CompletionIndicator
        {
            get
            {
                return this.completionIndicatorField;
            }
            set
            {
                this.completionIndicatorField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public ShipmentType ReportedShipment
        {
            get
            {
                return this.reportedShipmentField;
            }
            set
            {
                this.reportedShipmentField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CurrentStatus", Order = 7)]
        public StatusType1[] CurrentStatus
        {
            get
            {
                return this.currentStatusField;
            }
            set
            {
                this.currentStatusField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Contact", Order = 8)]
        public ContactType[] Contact
        {
            get
            {
                return this.contactField;
            }
            set
            {
                this.contactField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public LocationType1 Location
        {
            get
            {
                return this.locationField;
            }
            set
            {
                this.locationField = value;
                
            }
        }

        
    }
}