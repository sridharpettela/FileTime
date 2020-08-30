namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class OrderLineType
    {

        private SubstitutionStatusCodeType substitutionStatusCodeField;

        private NoteType[] noteField;

        private LineItemType lineItemField;

        private LineItemType[] sellerProposedSubstituteLineItemField;

        private LineItemType[] sellerSubstitutedLineItemField;

        private LineItemType[] buyerProposedSubstituteLineItemField;

        private LineReferenceType catalogueLineReferenceField;

        private LineReferenceType quotationLineReferenceField;

        private DocumentReferenceType[] documentReferenceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public SubstitutionStatusCodeType SubstitutionStatusCode
        {
            get
            {
                return this.substitutionStatusCodeField;
            }
            set
            {
                this.substitutionStatusCodeField = value;
                
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
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
        [System.Xml.Serialization.XmlElementAttribute("SellerProposedSubstituteLineItem", Order = 3)]
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
        [System.Xml.Serialization.XmlElementAttribute("SellerSubstitutedLineItem", Order = 4)]
        public LineItemType[] SellerSubstitutedLineItem
        {
            get
            {
                return this.sellerSubstitutedLineItemField;
            }
            set
            {
                this.sellerSubstitutedLineItemField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BuyerProposedSubstituteLineItem", Order = 5)]
        public LineItemType[] BuyerProposedSubstituteLineItem
        {
            get
            {
                return this.buyerProposedSubstituteLineItemField;
            }
            set
            {
                this.buyerProposedSubstituteLineItemField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public LineReferenceType CatalogueLineReference
        {
            get
            {
                return this.catalogueLineReferenceField;
            }
            set
            {
                this.catalogueLineReferenceField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public LineReferenceType QuotationLineReference
        {
            get
            {
                return this.quotationLineReferenceField;
            }
            set
            {
                this.quotationLineReferenceField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DocumentReference", Order = 8)]
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

        

        
    }
}