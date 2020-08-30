namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class MonetaryTotalType
    {

        private LineExtensionAmountType lineExtensionAmountField;

        private TaxExclusiveAmountType taxExclusiveAmountField;

        private TaxInclusiveAmountType taxInclusiveAmountField;

        private AllowanceTotalAmountType allowanceTotalAmountField;

        private ChargeTotalAmountType chargeTotalAmountField;

        private PrepaidAmountType prepaidAmountField;

        private PayableRoundingAmountType payableRoundingAmountField;

        private PayableAmountType payableAmountField;

        private PayableAlternativeAmountType payableAlternativeAmountField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public TaxExclusiveAmountType TaxExclusiveAmount
        {
            get
            {
                return this.taxExclusiveAmountField;
            }
            set
            {
                this.taxExclusiveAmountField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public TaxInclusiveAmountType TaxInclusiveAmount
        {
            get
            {
                return this.taxInclusiveAmountField;
            }
            set
            {
                this.taxInclusiveAmountField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public AllowanceTotalAmountType AllowanceTotalAmount
        {
            get
            {
                return this.allowanceTotalAmountField;
            }
            set
            {
                this.allowanceTotalAmountField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
        public ChargeTotalAmountType ChargeTotalAmount
        {
            get
            {
                return this.chargeTotalAmountField;
            }
            set
            {
                this.chargeTotalAmountField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 5)]
        public PrepaidAmountType PrepaidAmount
        {
            get
            {
                return this.prepaidAmountField;
            }
            set
            {
                this.prepaidAmountField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 6)]
        public PayableRoundingAmountType PayableRoundingAmount
        {
            get
            {
                return this.payableRoundingAmountField;
            }
            set
            {
                this.payableRoundingAmountField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 7)]
        public PayableAmountType PayableAmount
        {
            get
            {
                return this.payableAmountField;
            }
            set
            {
                this.payableAmountField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 8)]
        public PayableAlternativeAmountType PayableAlternativeAmount
        {
            get
            {
                return this.payableAlternativeAmountField;
            }
            set
            {
                this.payableAlternativeAmountField = value;
                
            }
        }

        

       
    }
}