namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class ConsumptionLineType
    {

        private IDType idField;

        private ParentDocumentLineReferenceIDType parentDocumentLineReferenceIDField;

        private InvoicedQuantityType invoicedQuantityField;

        private LineExtensionAmountType lineExtensionAmountField;

        private PeriodType periodField;

        private DeliveryType[] deliveryField;

        private AllowanceChargeType[] allowanceChargeField;

        private TaxTotalType[] taxTotalField;

        private UtilityItemType utilityItemField;

        private PriceType priceField;

        private UnstructuredPriceType unstructuredPriceField;

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
        public ParentDocumentLineReferenceIDType ParentDocumentLineReferenceID
        {
            get
            {
                return this.parentDocumentLineReferenceIDField;
            }
            set
            {
                this.parentDocumentLineReferenceIDField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public InvoicedQuantityType InvoicedQuantity
        {
            get
            {
                return this.invoicedQuantityField;
            }
            set
            {
                this.invoicedQuantityField = value;
                
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public PeriodType Period
        {
            get
            {
                return this.periodField;
            }
            set
            {
                this.periodField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Delivery", Order = 5)]
        public DeliveryType[] Delivery
        {
            get
            {
                return this.deliveryField;
            }
            set
            {
                this.deliveryField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AllowanceCharge", Order = 6)]
        public AllowanceChargeType[] AllowanceCharge
        {
            get
            {
                return this.allowanceChargeField;
            }
            set
            {
                this.allowanceChargeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TaxTotal", Order = 7)]
        public TaxTotalType[] TaxTotal
        {
            get
            {
                return this.taxTotalField;
            }
            set
            {
                this.taxTotalField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public UtilityItemType UtilityItem
        {
            get
            {
                return this.utilityItemField;
            }
            set
            {
                this.utilityItemField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public PriceType Price
        {
            get
            {
                return this.priceField;
            }
            set
            {
                this.priceField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public UnstructuredPriceType UnstructuredPrice
        {
            get
            {
                return this.unstructuredPriceField;
            }
            set
            {
                this.unstructuredPriceField = value;
                
            }
        }

    }
}