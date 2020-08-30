namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class ProcurementProjectType
    {

        private IDType idField;

        private NameType1[] nameField;

        private DescriptionType[] descriptionField;

        private ProcurementTypeCodeType procurementTypeCodeField;

        private ProcurementSubTypeCodeType procurementSubTypeCodeField;

        private QualityControlCodeType qualityControlCodeField;

        private RequiredFeeAmountType requiredFeeAmountField;

        private FeeDescriptionType[] feeDescriptionField;

        private RequestedDeliveryDateType requestedDeliveryDateField;

        private EstimatedOverallContractQuantityType estimatedOverallContractQuantityField;

        private BudgetAmountType budgetAmountField;

        private CommodityClassificationType[] requiredCommodityClassificationField;

        private LocationType1[] realizedLocationField;

        private PeriodType plannedPeriodField;

        private ContractExtensionType contractExtensionField;

        private RequestForTenderLineType[] requestForTenderLineField;

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
        [System.Xml.Serialization.XmlElementAttribute("Name", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public NameType1[] Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public DescriptionType[] Description
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public ProcurementTypeCodeType ProcurementTypeCode
        {
            get
            {
                return this.procurementTypeCodeField;
            }
            set
            {
                this.procurementTypeCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
        public ProcurementSubTypeCodeType ProcurementSubTypeCode
        {
            get
            {
                return this.procurementSubTypeCodeField;
            }
            set
            {
                this.procurementSubTypeCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 5)]
        public QualityControlCodeType QualityControlCode
        {
            get
            {
                return this.qualityControlCodeField;
            }
            set
            {
                this.qualityControlCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 6)]
        public RequiredFeeAmountType RequiredFeeAmount
        {
            get
            {
                return this.requiredFeeAmountField;
            }
            set
            {
                this.requiredFeeAmountField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FeeDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 7)]
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 8)]
        public RequestedDeliveryDateType RequestedDeliveryDate
        {
            get
            {
                return this.requestedDeliveryDateField;
            }
            set
            {
                this.requestedDeliveryDateField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 9)]
        public EstimatedOverallContractQuantityType EstimatedOverallContractQuantity
        {
            get
            {
                return this.estimatedOverallContractQuantityField;
            }
            set
            {
                this.estimatedOverallContractQuantityField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public BudgetAmountType BudgetAmount
        {
            get
            {
                return this.budgetAmountField;
            }
            set
            {
                this.budgetAmountField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RequiredCommodityClassification", Order = 11)]
        public CommodityClassificationType[] RequiredCommodityClassification
        {
            get
            {
                return this.requiredCommodityClassificationField;
            }
            set
            {
                this.requiredCommodityClassificationField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RealizedLocation", Order = 12)]
        public LocationType1[] RealizedLocation
        {
            get
            {
                return this.realizedLocationField;
            }
            set
            {
                this.realizedLocationField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
        public PeriodType PlannedPeriod
        {
            get
            {
                return this.plannedPeriodField;
            }
            set
            {
                this.plannedPeriodField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
        public ContractExtensionType ContractExtension
        {
            get
            {
                return this.contractExtensionField;
            }
            set
            {
                this.contractExtensionField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RequestForTenderLine", Order = 15)]
        public RequestForTenderLineType[] RequestForTenderLine
        {
            get
            {
                return this.requestForTenderLineField;
            }
            set
            {
                this.requestForTenderLineField = value;
                
            }
        }

        
    }
}