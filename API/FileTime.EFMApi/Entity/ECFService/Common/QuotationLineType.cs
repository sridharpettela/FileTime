namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class QuotationLineType
    {

        private IDType idField;

        private NoteType[] noteField;

        private QuantityType2 quantityField;

        private LineExtensionAmountType lineExtensionAmountField;

        private TotalTaxAmountType totalTaxAmountField;

        private RequestForQuotationLineIDType requestForQuotationLineIDField;

        private DocumentReferenceType[] documentReferenceField;

        private LineItemType lineItemField;

        private LineItemType[] sellerProposedSubstituteLineItemField;

        private LineItemType[] alternativeLineItemField;

        private LineReferenceType requestLineReferenceField;

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
        [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public QuantityType2 Quantity
        {
            get
            {
                return this.quantityField;
            }
            set
            {
                this.quantityField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public LineExtensionAmountType LineExtensionAmount
        {
            get
            {
                return this.lineExtensionAmountField;
            }
            set
            {
                this.lineExtensionAmountField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
        public TotalTaxAmountType TotalTaxAmount
        {
            get
            {
                return this.totalTaxAmountField;
            }
            set
            {
                this.totalTaxAmountField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 5)]
        public RequestForQuotationLineIDType RequestForQuotationLineID
        {
            get
            {
                return this.requestForQuotationLineIDField;
            }
            set
            {
                this.requestForQuotationLineIDField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DocumentReference", Order = 6)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public LineItemType LineItem
        {
            get
            {
                return this.lineItemField;
            }
            set
            {
                this.lineItemField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SellerProposedSubstituteLineItem", Order = 8)]
        public LineItemType[] SellerProposedSubstituteLineItem
        {
            get
            {
                return this.sellerProposedSubstituteLineItemField;
            }
            set
            {
                this.sellerProposedSubstituteLineItemField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AlternativeLineItem", Order = 9)]
        public LineItemType[] AlternativeLineItem
        {
            get
            {
                return this.alternativeLineItemField;
            }
            set
            {
                this.alternativeLineItemField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public LineReferenceType RequestLineReference
        {
            get
            {
                return this.requestLineReferenceField;
            }
            set
            {
                this.requestLineReferenceField = value;
                
            }
        }

        
    }
}