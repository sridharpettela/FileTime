namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class TenderingTermsType
    {

        private AwardingMethodTypeCodeType awardingMethodTypeCodeField;

        private PriceEvaluationCodeType priceEvaluationCodeField;

        private MaximumVariantQuantityType maximumVariantQuantityField;

        private VariantConstraintIndicatorType variantConstraintIndicatorField;

        private AcceptedVariantsDescriptionType[] acceptedVariantsDescriptionField;

        private PriceRevisionFormulaDescriptionType[] priceRevisionFormulaDescriptionField;

        private FundingProgramCodeType fundingProgramCodeField;

        private FundingProgramType[] fundingProgramField;

        private MaximumAdvertisementAmountType maximumAdvertisementAmountField;

        private NoteType[] noteField;

        private PaymentFrequencyCodeType paymentFrequencyCodeField;

        private EconomicOperatorRegistryURIType economicOperatorRegistryURIField;

        private PenaltyClausesType[] penaltyClausesField;

        private RequiredCurriculaIndicatorType requiredCurriculaIndicatorField;

        private FinancialGuaranteeType[] requiredFinancialGuaranteeField;

        private DocumentReferenceType procurementLegislationDocumentReferenceField;

        private DocumentReferenceType fiscalLegislationDocumentReferenceField;

        private DocumentReferenceType environmentalLegislationDocumentReferenceField;

        private DocumentReferenceType employmentLegislationDocumentReferenceField;

        private DocumentReferenceType[] contractualDocumentReferenceField;

        private DocumentReferenceType callForTenderDocumentReferenceField;

        private PeriodType warrantyValidityPeriodField;

        private PaymentTermsType[] paymentTermsField;

        private TendererQualificationRequestType tendererQualificationRequestField;

        private SubcontractTermsType[] allowedSubcontractTermsField;

        private TenderPreparationType[] tenderPreparationField;

        private ContractExecutionRequirementType[] contractExecutionRequirementField;

        private AwardingTermsType awardingTermsField;

        private PartyType additionalInformationPartyField;

        private PartyType documentProviderPartyField;

        private PartyType tenderRecipientPartyField;

        private PartyType contractResponsiblePartyField;

        private PartyType[] tenderEvaluationPartyField;

        private PeriodType tenderValidityPeriodField;

        private PeriodType contractAcceptancePeriodField;

        private AppealTermsType appealTermsField;

        private object[] itemsField;

        private BudgetAccountLineType[] budgetAccountLineField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public AwardingMethodTypeCodeType AwardingMethodTypeCode
        {
            get
            {
                return this.awardingMethodTypeCodeField;
            }
            set
            {
                this.awardingMethodTypeCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public PriceEvaluationCodeType PriceEvaluationCode
        {
            get
            {
                return this.priceEvaluationCodeField;
            }
            set
            {
                this.priceEvaluationCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public MaximumVariantQuantityType MaximumVariantQuantity
        {
            get
            {
                return this.maximumVariantQuantityField;
            }
            set
            {
                this.maximumVariantQuantityField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public VariantConstraintIndicatorType VariantConstraintIndicator
        {
            get
            {
                return this.variantConstraintIndicatorField;
            }
            set
            {
                this.variantConstraintIndicatorField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AcceptedVariantsDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
        public AcceptedVariantsDescriptionType[] AcceptedVariantsDescription
        {
            get
            {
                return this.acceptedVariantsDescriptionField;
            }
            set
            {
                this.acceptedVariantsDescriptionField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PriceRevisionFormulaDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 5)]
        public PriceRevisionFormulaDescriptionType[] PriceRevisionFormulaDescription
        {
            get
            {
                return this.priceRevisionFormulaDescriptionField;
            }
            set
            {
                this.priceRevisionFormulaDescriptionField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 6)]
        public FundingProgramCodeType FundingProgramCode
        {
            get
            {
                return this.fundingProgramCodeField;
            }
            set
            {
                this.fundingProgramCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FundingProgram", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 7)]
        public FundingProgramType[] FundingProgram
        {
            get
            {
                return this.fundingProgramField;
            }
            set
            {
                this.fundingProgramField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 8)]
        public MaximumAdvertisementAmountType MaximumAdvertisementAmount
        {
            get
            {
                return this.maximumAdvertisementAmountField;
            }
            set
            {
                this.maximumAdvertisementAmountField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 9)]
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 10)]
        public PaymentFrequencyCodeType PaymentFrequencyCode
        {
            get
            {
                return this.paymentFrequencyCodeField;
            }
            set
            {
                this.paymentFrequencyCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 11)]
        public EconomicOperatorRegistryURIType EconomicOperatorRegistryURI
        {
            get
            {
                return this.economicOperatorRegistryURIField;
            }
            set
            {
                this.economicOperatorRegistryURIField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PenaltyClauses", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 12)]
        public PenaltyClausesType[] PenaltyClauses
        {
            get
            {
                return this.penaltyClausesField;
            }
            set
            {
                this.penaltyClausesField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 13)]
        public RequiredCurriculaIndicatorType RequiredCurriculaIndicator
        {
            get
            {
                return this.requiredCurriculaIndicatorField;
            }
            set
            {
                this.requiredCurriculaIndicatorField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RequiredFinancialGuarantee", Order = 14)]
        public FinancialGuaranteeType[] RequiredFinancialGuarantee
        {
            get
            {
                return this.requiredFinancialGuaranteeField;
            }
            set
            {
                this.requiredFinancialGuaranteeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 15)]
        public DocumentReferenceType ProcurementLegislationDocumentReference
        {
            get
            {
                return this.procurementLegislationDocumentReferenceField;
            }
            set
            {
                this.procurementLegislationDocumentReferenceField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 16)]
        public DocumentReferenceType FiscalLegislationDocumentReference
        {
            get
            {
                return this.fiscalLegislationDocumentReferenceField;
            }
            set
            {
                this.fiscalLegislationDocumentReferenceField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 17)]
        public DocumentReferenceType EnvironmentalLegislationDocumentReference
        {
            get
            {
                return this.environmentalLegislationDocumentReferenceField;
            }
            set
            {
                this.environmentalLegislationDocumentReferenceField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 18)]
        public DocumentReferenceType EmploymentLegislationDocumentReference
        {
            get
            {
                return this.employmentLegislationDocumentReferenceField;
            }
            set
            {
                this.employmentLegislationDocumentReferenceField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ContractualDocumentReference", Order = 19)]
        public DocumentReferenceType[] ContractualDocumentReference
        {
            get
            {
                return this.contractualDocumentReferenceField;
            }
            set
            {
                this.contractualDocumentReferenceField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 20)]
        public DocumentReferenceType CallForTenderDocumentReference
        {
            get
            {
                return this.callForTenderDocumentReferenceField;
            }
            set
            {
                this.callForTenderDocumentReferenceField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 21)]
        public PeriodType WarrantyValidityPeriod
        {
            get
            {
                return this.warrantyValidityPeriodField;
            }
            set
            {
                this.warrantyValidityPeriodField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PaymentTerms", Order = 22)]
        public PaymentTermsType[] PaymentTerms
        {
            get
            {
                return this.paymentTermsField;
            }
            set
            {
                this.paymentTermsField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 23)]
        public TendererQualificationRequestType TendererQualificationRequest
        {
            get
            {
                return this.tendererQualificationRequestField;
            }
            set
            {
                this.tendererQualificationRequestField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AllowedSubcontractTerms", Order = 24)]
        public SubcontractTermsType[] AllowedSubcontractTerms
        {
            get
            {
                return this.allowedSubcontractTermsField;
            }
            set
            {
                this.allowedSubcontractTermsField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TenderPreparation", Order = 25)]
        public TenderPreparationType[] TenderPreparation
        {
            get
            {
                return this.tenderPreparationField;
            }
            set
            {
                this.tenderPreparationField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ContractExecutionRequirement", Order = 26)]
        public ContractExecutionRequirementType[] ContractExecutionRequirement
        {
            get
            {
                return this.contractExecutionRequirementField;
            }
            set
            {
                this.contractExecutionRequirementField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 27)]
        public AwardingTermsType AwardingTerms
        {
            get
            {
                return this.awardingTermsField;
            }
            set
            {
                this.awardingTermsField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 28)]
        public PartyType AdditionalInformationParty
        {
            get
            {
                return this.additionalInformationPartyField;
            }
            set
            {
                this.additionalInformationPartyField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 29)]
        public PartyType DocumentProviderParty
        {
            get
            {
                return this.documentProviderPartyField;
            }
            set
            {
                this.documentProviderPartyField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 30)]
        public PartyType TenderRecipientParty
        {
            get
            {
                return this.tenderRecipientPartyField;
            }
            set
            {
                this.tenderRecipientPartyField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 31)]
        public PartyType ContractResponsibleParty
        {
            get
            {
                return this.contractResponsiblePartyField;
            }
            set
            {
                this.contractResponsiblePartyField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TenderEvaluationParty", Order = 32)]
        public PartyType[] TenderEvaluationParty
        {
            get
            {
                return this.tenderEvaluationPartyField;
            }
            set
            {
                this.tenderEvaluationPartyField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 33)]
        public PeriodType TenderValidityPeriod
        {
            get
            {
                return this.tenderValidityPeriodField;
            }
            set
            {
                this.tenderValidityPeriodField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 34)]
        public PeriodType ContractAcceptancePeriod
        {
            get
            {
                return this.contractAcceptancePeriodField;
            }
            set
            {
                this.contractAcceptancePeriodField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 35)]
        public AppealTermsType AppealTerms
        {
            get
            {
                return this.appealTermsField;
            }
            set
            {
                this.appealTermsField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LanguageCode", typeof(LanguageCodeType), Namespace = "http://niem.gov/niem/niem-core/2.0",  Order = 36)]
        [System.Xml.Serialization.XmlElementAttribute("Language", typeof(LanguageType), Order = 36)]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BudgetAccountLine", Order = 37)]
        public BudgetAccountLineType[] BudgetAccountLine
        {
            get
            {
                return this.budgetAccountLineField;
            }
            set
            {
                this.budgetAccountLineField = value;
                
            }
        }

       
    }
}