namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class DespatchType
    {

        private IDType idField;

        private RequestedDespatchDateType requestedDespatchDateField;

        private RequestedDespatchTimeType requestedDespatchTimeField;

        private EstimatedDespatchDateType estimatedDespatchDateField;

        private EstimatedDespatchTimeType estimatedDespatchTimeField;

        private ActualDespatchDateType actualDespatchDateField;

        private ActualDespatchTimeType actualDespatchTimeField;

        private GuaranteedDespatchDateType guaranteedDespatchDateField;

        private GuaranteedDespatchTimeType guaranteedDespatchTimeField;

        private ReleaseIDType releaseIDField;

        private InstructionsType instructionsField;

        private AddressType despatchAddressField;

        private LocationType1 despatchLocationField;

        private PartyType despatchPartyField;

        private PartyType carrierPartyField;

        private PartyType[] notifyPartyField;

        private ContactType contactField;

        private PeriodType estimatedDespatchPeriodField;

        private PeriodType requestedDespatchPeriodField;

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
        public RequestedDespatchDateType RequestedDespatchDate
        {
            get
            {
                return this.requestedDespatchDateField;
            }
            set
            {
                this.requestedDespatchDateField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public RequestedDespatchTimeType RequestedDespatchTime
        {
            get
            {
                return this.requestedDespatchTimeField;
            }
            set
            {
                this.requestedDespatchTimeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public EstimatedDespatchDateType EstimatedDespatchDate
        {
            get
            {
                return this.estimatedDespatchDateField;
            }
            set
            {
                this.estimatedDespatchDateField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
        public EstimatedDespatchTimeType EstimatedDespatchTime
        {
            get
            {
                return this.estimatedDespatchTimeField;
            }
            set
            {
                this.estimatedDespatchTimeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 5)]
        public ActualDespatchDateType ActualDespatchDate
        {
            get
            {
                return this.actualDespatchDateField;
            }
            set
            {
                this.actualDespatchDateField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 6)]
        public ActualDespatchTimeType ActualDespatchTime
        {
            get
            {
                return this.actualDespatchTimeField;
            }
            set
            {
                this.actualDespatchTimeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 7)]
        public GuaranteedDespatchDateType GuaranteedDespatchDate
        {
            get
            {
                return this.guaranteedDespatchDateField;
            }
            set
            {
                this.guaranteedDespatchDateField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 8)]
        public GuaranteedDespatchTimeType GuaranteedDespatchTime
        {
            get
            {
                return this.guaranteedDespatchTimeField;
            }
            set
            {
                this.guaranteedDespatchTimeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 9)]
        public ReleaseIDType ReleaseID
        {
            get
            {
                return this.releaseIDField;
            }
            set
            {
                this.releaseIDField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 10)]
        public InstructionsType Instructions
        {
            get
            {
                return this.instructionsField;
            }
            set
            {
                this.instructionsField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public AddressType DespatchAddress
        {
            get
            {
                return this.despatchAddressField;
            }
            set
            {
                this.despatchAddressField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public LocationType1 DespatchLocation
        {
            get
            {
                return this.despatchLocationField;
            }
            set
            {
                this.despatchLocationField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
        public PartyType DespatchParty
        {
            get
            {
                return this.despatchPartyField;
            }
            set
            {
                this.despatchPartyField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
        public PartyType CarrierParty
        {
            get
            {
                return this.carrierPartyField;
            }
            set
            {
                this.carrierPartyField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NotifyParty", Order = 15)]
        public PartyType[] NotifyParty
        {
            get
            {
                return this.notifyPartyField;
            }
            set
            {
                this.notifyPartyField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 16)]
        public ContactType Contact
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 17)]
        public PeriodType EstimatedDespatchPeriod
        {
            get
            {
                return this.estimatedDespatchPeriodField;
            }
            set
            {
                this.estimatedDespatchPeriodField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 18)]
        public PeriodType RequestedDespatchPeriod
        {
            get
            {
                return this.requestedDespatchPeriodField;
            }
            set
            {
                this.requestedDespatchPeriodField = value;
                
            }
        }

        

       
    }
}