namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class TenderingProcessType
    {

        private IDType idField;

        private OriginalContractingSystemIDType originalContractingSystemIDField;

        private DescriptionType[] descriptionField;

        private NegotiationDescriptionType[] negotiationDescriptionField;

        private ProcedureCodeType procedureCodeField;

        private UrgencyCodeType urgencyCodeField;

        private ExpenseCodeType expenseCodeField;

        private PartPresentationCodeType partPresentationCodeField;

        private ContractingSystemCodeType contractingSystemCodeField;

        private SubmissionMethodCodeType submissionMethodCodeField;

        private CandidateReductionConstraintIndicatorType candidateReductionConstraintIndicatorField;

        private GovernmentAgreementConstraintIndicatorType governmentAgreementConstraintIndicatorField;

        private PeriodType documentAvailabilityPeriodField;

        private PeriodType tenderSubmissionDeadlinePeriodField;

        private PeriodType invitationSubmissionPeriodField;

        private PeriodType participationRequestReceptionPeriodField;

        private DocumentReferenceType[] noticeDocumentReferenceField;

        private DocumentReferenceType[] additionalDocumentReferenceField;

        private ProcessJustificationType[] processJustificationField;

        private EconomicOperatorShortListType economicOperatorShortListField;

        private EventType[] openTenderEventField;

        private AuctionTermsType auctionTermsField;

        private FrameworkAgreementType frameworkAgreementField;

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
        public OriginalContractingSystemIDType OriginalContractingSystemID
        {
            get
            {
                return this.originalContractingSystemIDField;
            }
            set
            {
                this.originalContractingSystemIDField = value;
                
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
        [System.Xml.Serialization.XmlElementAttribute("NegotiationDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public NegotiationDescriptionType[] NegotiationDescription
        {
            get
            {
                return this.negotiationDescriptionField;
            }
            set
            {
                this.negotiationDescriptionField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
        public ProcedureCodeType ProcedureCode
        {
            get
            {
                return this.procedureCodeField;
            }
            set
            {
                this.procedureCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 5)]
        public UrgencyCodeType UrgencyCode
        {
            get
            {
                return this.urgencyCodeField;
            }
            set
            {
                this.urgencyCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 6)]
        public ExpenseCodeType ExpenseCode
        {
            get
            {
                return this.expenseCodeField;
            }
            set
            {
                this.expenseCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 7)]
        public PartPresentationCodeType PartPresentationCode
        {
            get
            {
                return this.partPresentationCodeField;
            }
            set
            {
                this.partPresentationCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 8)]
        public ContractingSystemCodeType ContractingSystemCode
        {
            get
            {
                return this.contractingSystemCodeField;
            }
            set
            {
                this.contractingSystemCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 9)]
        public SubmissionMethodCodeType SubmissionMethodCode
        {
            get
            {
                return this.submissionMethodCodeField;
            }
            set
            {
                this.submissionMethodCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 10)]
        public CandidateReductionConstraintIndicatorType CandidateReductionConstraintIndicator
        {
            get
            {
                return this.candidateReductionConstraintIndicatorField;
            }
            set
            {
                this.candidateReductionConstraintIndicatorField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 11)]
        public GovernmentAgreementConstraintIndicatorType GovernmentAgreementConstraintIndicator
        {
            get
            {
                return this.governmentAgreementConstraintIndicatorField;
            }
            set
            {
                this.governmentAgreementConstraintIndicatorField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public PeriodType DocumentAvailabilityPeriod
        {
            get
            {
                return this.documentAvailabilityPeriodField;
            }
            set
            {
                this.documentAvailabilityPeriodField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
        public PeriodType TenderSubmissionDeadlinePeriod
        {
            get
            {
                return this.tenderSubmissionDeadlinePeriodField;
            }
            set
            {
                this.tenderSubmissionDeadlinePeriodField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
        public PeriodType InvitationSubmissionPeriod
        {
            get
            {
                return this.invitationSubmissionPeriodField;
            }
            set
            {
                this.invitationSubmissionPeriodField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 15)]
        public PeriodType ParticipationRequestReceptionPeriod
        {
            get
            {
                return this.participationRequestReceptionPeriodField;
            }
            set
            {
                this.participationRequestReceptionPeriodField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NoticeDocumentReference", Order = 16)]
        public DocumentReferenceType[] NoticeDocumentReference
        {
            get
            {
                return this.noticeDocumentReferenceField;
            }
            set
            {
                this.noticeDocumentReferenceField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AdditionalDocumentReference", Order = 17)]
        public DocumentReferenceType[] AdditionalDocumentReference
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
        [System.Xml.Serialization.XmlElementAttribute("ProcessJustification", Order = 18)]
        public ProcessJustificationType[] ProcessJustification
        {
            get
            {
                return this.processJustificationField;
            }
            set
            {
                this.processJustificationField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 19)]
        public EconomicOperatorShortListType EconomicOperatorShortList
        {
            get
            {
                return this.economicOperatorShortListField;
            }
            set
            {
                this.economicOperatorShortListField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OpenTenderEvent", Order = 20)]
        public EventType[] OpenTenderEvent
        {
            get
            {
                return this.openTenderEventField;
            }
            set
            {
                this.openTenderEventField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 21)]
        public AuctionTermsType AuctionTerms
        {
            get
            {
                return this.auctionTermsField;
            }
            set
            {
                this.auctionTermsField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 22)]
        public FrameworkAgreementType FrameworkAgreement
        {
            get
            {
                return this.frameworkAgreementField;
            }
            set
            {
                this.frameworkAgreementField = value;
                
            }
        }

        

    }
}