namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class BillingReferenceType
    {

        private DocumentReferenceType invoiceDocumentReferenceField;

        private DocumentReferenceType selfBilledInvoiceDocumentReferenceField;

        private DocumentReferenceType creditNoteDocumentReferenceField;

        private DocumentReferenceType selfBilledCreditNoteDocumentReferenceField;

        private DocumentReferenceType debitNoteDocumentReferenceField;

        private DocumentReferenceType reminderDocumentReferenceField;

        private DocumentReferenceType additionalDocumentReferenceField;

        private BillingReferenceLineType[] billingReferenceLineField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public DocumentReferenceType InvoiceDocumentReference
        {
            get
            {
                return this.invoiceDocumentReferenceField;
            }
            set
            {
                this.invoiceDocumentReferenceField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public DocumentReferenceType SelfBilledInvoiceDocumentReference
        {
            get
            {
                return this.selfBilledInvoiceDocumentReferenceField;
            }
            set
            {
                this.selfBilledInvoiceDocumentReferenceField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public DocumentReferenceType CreditNoteDocumentReference
        {
            get
            {
                return this.creditNoteDocumentReferenceField;
            }
            set
            {
                this.creditNoteDocumentReferenceField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public DocumentReferenceType SelfBilledCreditNoteDocumentReference
        {
            get
            {
                return this.selfBilledCreditNoteDocumentReferenceField;
            }
            set
            {
                this.selfBilledCreditNoteDocumentReferenceField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public DocumentReferenceType DebitNoteDocumentReference
        {
            get
            {
                return this.debitNoteDocumentReferenceField;
            }
            set
            {
                this.debitNoteDocumentReferenceField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public DocumentReferenceType ReminderDocumentReference
        {
            get
            {
                return this.reminderDocumentReferenceField;
            }
            set
            {
                this.reminderDocumentReferenceField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public DocumentReferenceType AdditionalDocumentReference
        {
            get
            {
                return this.additionalDocumentReferenceField;
            }
            set
            {
                this.additionalDocumentReferenceField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BillingReferenceLine", Order = 7)]
        public BillingReferenceLineType[] BillingReferenceLine
        {
            get
            {
                return this.billingReferenceLineField;
            }
            set
            {
                this.billingReferenceLineField = value;
                
            }
        }

       
    }
}