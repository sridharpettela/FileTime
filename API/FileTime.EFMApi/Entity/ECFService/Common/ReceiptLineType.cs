namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class ReceiptLineType
    {

        private IDType idField;

        private UUIDType uUIDField;

        private NoteType[] noteField;

        private ReceivedQuantityType receivedQuantityField;

        private ShortQuantityType shortQuantityField;

        private ShortageActionCodeType shortageActionCodeField;

        private RejectedQuantityType rejectedQuantityField;

        private RejectReasonCodeType rejectReasonCodeField;

        private RejectReasonType rejectReasonField;

        private RejectActionCodeType rejectActionCodeField;

        private QuantityDiscrepancyCodeType quantityDiscrepancyCodeField;

        private OversupplyQuantityType oversupplyQuantityField;

        private ReceivedDateType receivedDateField;

        private TimingComplaintCodeType timingComplaintCodeField;

        private TimingComplaintType timingComplaintField;

        private OrderLineReferenceType orderLineReferenceField;

        private LineReferenceType[] despatchLineReferenceField;

        private DocumentReferenceType[] documentReferenceField;

        private ItemType1[] itemField;

        private ShipmentType[] shipmentField;

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
        public UUIDType UUID
        {
            get
            {
                return this.uUIDField;
            }
            set
            {
                this.uUIDField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public NoteType[] Note
        {
            get
            {
                return this.noteField;
            }
            set
            {
                this.noteField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public ReceivedQuantityType ReceivedQuantity
        {
            get
            {
                return this.receivedQuantityField;
            }
            set
            {
                this.receivedQuantityField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
        public ShortQuantityType ShortQuantity
        {
            get
            {
                return this.shortQuantityField;
            }
            set
            {
                this.shortQuantityField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 5)]
        public ShortageActionCodeType ShortageActionCode
        {
            get
            {
                return this.shortageActionCodeField;
            }
            set
            {
                this.shortageActionCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 6)]
        public RejectedQuantityType RejectedQuantity
        {
            get
            {
                return this.rejectedQuantityField;
            }
            set
            {
                this.rejectedQuantityField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 7)]
        public RejectReasonCodeType RejectReasonCode
        {
            get
            {
                return this.rejectReasonCodeField;
            }
            set
            {
                this.rejectReasonCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 8)]
        public RejectReasonType RejectReason
        {
            get
            {
                return this.rejectReasonField;
            }
            set
            {
                this.rejectReasonField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 9)]
        public RejectActionCodeType RejectActionCode
        {
            get
            {
                return this.rejectActionCodeField;
            }
            set
            {
                this.rejectActionCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 10)]
        public QuantityDiscrepancyCodeType QuantityDiscrepancyCode
        {
            get
            {
                return this.quantityDiscrepancyCodeField;
            }
            set
            {
                this.quantityDiscrepancyCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 11)]
        public OversupplyQuantityType OversupplyQuantity
        {
            get
            {
                return this.oversupplyQuantityField;
            }
            set
            {
                this.oversupplyQuantityField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 12)]
        public ReceivedDateType ReceivedDate
        {
            get
            {
                return this.receivedDateField;
            }
            set
            {
                this.receivedDateField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 13)]
        public TimingComplaintCodeType TimingComplaintCode
        {
            get
            {
                return this.timingComplaintCodeField;
            }
            set
            {
                this.timingComplaintCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 14)]
        public TimingComplaintType TimingComplaint
        {
            get
            {
                return this.timingComplaintField;
            }
            set
            {
                this.timingComplaintField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 15)]
        public OrderLineReferenceType OrderLineReference
        {
            get
            {
                return this.orderLineReferenceField;
            }
            set
            {
                this.orderLineReferenceField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DespatchLineReference", Order = 16)]
        public LineReferenceType[] DespatchLineReference
        {
            get
            {
                return this.despatchLineReferenceField;
            }
            set
            {
                this.despatchLineReferenceField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DocumentReference", Order = 17)]
        public DocumentReferenceType[] DocumentReference
        {
            get
            {
                return this.documentReferenceField;
            }
            set
            {
                this.documentReferenceField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Item", Order = 18)]
        public ItemType1[] Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Shipment", Order = 19)]
        public ShipmentType[] Shipment
        {
            get
            {
                return this.shipmentField;
            }
            set
            {
                this.shipmentField = value;
                
            }
        }

    }
}