namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class TransportationServiceType
    {

        private TransportServiceCodeType transportServiceCodeField;

        private TariffClassCodeType tariffClassCodeField;

        private PriorityType priorityField;

        private FreightRateClassCodeType freightRateClassCodeField;

        private TransportationServiceDescriptionType transportationServiceDescriptionField;

        private TransportationServiceDetailsURIType transportationServiceDetailsURIField;

        private NominationDateType nominationDateField;

        private NominationTimeType nominationTimeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public TransportServiceCodeType TransportServiceCode
        {
            get
            {
                return this.transportServiceCodeField;
            }
            set
            {
                this.transportServiceCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public TariffClassCodeType TariffClassCode
        {
            get
            {
                return this.tariffClassCodeField;
            }
            set
            {
                this.tariffClassCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public PriorityType Priority
        {
            get
            {
                return this.priorityField;
            }
            set
            {
                this.priorityField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public FreightRateClassCodeType FreightRateClassCode
        {
            get
            {
                return this.freightRateClassCodeField;
            }
            set
            {
                this.freightRateClassCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
        public TransportationServiceDescriptionType TransportationServiceDescription
        {
            get
            {
                return this.transportationServiceDescriptionField;
            }
            set
            {
                this.transportationServiceDescriptionField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 5)]
        public TransportationServiceDetailsURIType TransportationServiceDetailsURI
        {
            get
            {
                return this.transportationServiceDetailsURIField;
            }
            set
            {
                this.transportationServiceDetailsURIField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 6)]
        public NominationDateType NominationDate
        {
            get
            {
                return this.nominationDateField;
            }
            set
            {
                this.nominationDateField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 7)]
        public NominationTimeType NominationTime
        {
            get
            {
                return this.nominationTimeField;
            }
            set
            {
                this.nominationTimeField = value;
                
            }
        }

        
    }
}