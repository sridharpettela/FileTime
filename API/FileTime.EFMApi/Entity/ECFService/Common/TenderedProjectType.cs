namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class TenderedProjectType
    {

        private ProcurementProjectLotIDType procurementProjectLotIDField;

        private VariantIDType variantIDField;

        private FeeAmountType feeAmountField;

        private FeeDescriptionType[] feeDescriptionField;

        private TaxTotalType[] taxTotalField;

        private MonetaryTotalType legalMonetaryTotalField;

        private TenderLineType[] tenderLineField;

        private AwardingCriteriaResponseType[] awardingCriteriaResponseField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public ProcurementProjectLotIDType ProcurementProjectLotID
        {
            get
            {
                return this.procurementProjectLotIDField;
            }
            set
            {
                this.procurementProjectLotIDField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public VariantIDType VariantID
        {
            get
            {
                return this.variantIDField;
            }
            set
            {
                this.variantIDField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public FeeAmountType FeeAmount
        {
            get
            {
                return this.feeAmountField;
            }
            set
            {
                this.feeAmountField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FeeDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public FeeDescriptionType[] FeeDescription
        {
            get
            {
                return this.feeDescriptionField;
            }
            set
            {
                this.feeDescriptionField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TaxTotal", Order = 4)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public MonetaryTotalType LegalMonetaryTotal
        {
            get
            {
                return this.legalMonetaryTotalField;
            }
            set
            {
                this.legalMonetaryTotalField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TenderLine", Order = 6)]
        public TenderLineType[] TenderLine
        {
            get
            {
                return this.tenderLineField;
            }
            set
            {
                this.tenderLineField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AwardingCriteriaResponse", Order = 7)]
        public AwardingCriteriaResponseType[] AwardingCriteriaResponse
        {
            get
            {
                return this.awardingCriteriaResponseField;
            }
            set
            {
                this.awardingCriteriaResponseField = value;
                
            }
        }

        
    }
}