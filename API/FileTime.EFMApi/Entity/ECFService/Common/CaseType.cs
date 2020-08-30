using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BankruptcyCaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(JuvenileCaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CivilCaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CitationCaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CriminalCaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AppellateCaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AppellateCaseType1))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DomesticCaseType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public partial class CaseType : ActivityType
    {

        private TextType caseTitleTextField;

        private TextType caseCategoryTextField;

        private @string caseTrackingIDField;

        private @string caseDocketIDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public TextType CaseTitleText
        {
            get
            {
                return this.caseTitleTextField;
            }
            set
            {
                this.caseTitleTextField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public TextType CaseCategoryText
        {
            get
            {
                return this.caseCategoryTextField;
            }
            set
            {
                this.caseCategoryTextField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public @string CaseTrackingID
        {
            get
            {
                return this.caseTrackingIDField;
            }
            set
            {
                this.caseTrackingIDField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public @string CaseDocketID
        {
            get
            {
                return this.caseDocketIDField;
            }
            set
            {
                this.caseDocketIDField = value;
                
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:BankruptcyCase-4.0")]
    public partial class BankruptcyCaseType : CaseType
    {

        private CaseAugmentationType caseAugmentationField;

        private CaseAugmentationType2 caseAugmentation1Field;

        private boolean assetNoticeIndicatorField;

        private string numberOfCreditorsValueLevelCodeField;

        private string estimatedAssetsValueLevelCodeField;

        private string estimatedDebtsValueLevelCodeField;

        private boolean smallBusinessIndicatorField;

        private boolean section1121eIndicatorField;

        private string debtorTypeCodeField;

        private boolean jointPetitionIndicatorField;

        private string natureOfDebtCodeField;

        private boolean voluntaryIndicatorField;

        private StatuteType bankruptcyStatuteField;

        private EntityType[] debtorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://niem.gov/niem/domains/jxdm/4.0", Order = 0)]
        public CaseAugmentationType CaseAugmentation
        {
            get
            {
                return this.caseAugmentationField;
            }
            set
            {
                this.caseAugmentationField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CaseAugmentation", Namespace = "urn:tyler:ecf:extensions:Common", Order = 1)]
        public CaseAugmentationType2 CaseAugmentation1
        {
            get
            {
                return this.caseAugmentation1Field;
            }
            set
            {
                this.caseAugmentation1Field = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public boolean AssetNoticeIndicator
        {
            get
            {
                return this.assetNoticeIndicatorField;
            }
            set
            {
                this.assetNoticeIndicatorField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString", Order = 3)]
        public string NumberOfCreditorsValueLevelCode
        {
            get
            {
                return this.numberOfCreditorsValueLevelCodeField;
            }
            set
            {
                this.numberOfCreditorsValueLevelCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString", Order = 4)]
        public string EstimatedAssetsValueLevelCode
        {
            get
            {
                return this.estimatedAssetsValueLevelCodeField;
            }
            set
            {
                this.estimatedAssetsValueLevelCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString", Order = 5)]
        public string EstimatedDebtsValueLevelCode
        {
            get
            {
                return this.estimatedDebtsValueLevelCodeField;
            }
            set
            {
                this.estimatedDebtsValueLevelCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public boolean SmallBusinessIndicator
        {
            get
            {
                return this.smallBusinessIndicatorField;
            }
            set
            {
                this.smallBusinessIndicatorField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public boolean Section1121eIndicator
        {
            get
            {
                return this.section1121eIndicatorField;
            }
            set
            {
                this.section1121eIndicatorField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString", Order = 8)]
        public string DebtorTypeCode
        {
            get
            {
                return this.debtorTypeCodeField;
            }
            set
            {
                this.debtorTypeCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public boolean JointPetitionIndicator
        {
            get
            {
                return this.jointPetitionIndicatorField;
            }
            set
            {
                this.jointPetitionIndicatorField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString", Order = 10)]
        public string NatureOfDebtCode
        {
            get
            {
                return this.natureOfDebtCodeField;
            }
            set
            {
                this.natureOfDebtCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public boolean VoluntaryIndicator
        {
            get
            {
                return this.voluntaryIndicatorField;
            }
            set
            {
                this.voluntaryIndicatorField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public StatuteType BankruptcyStatute
        {
            get
            {
                return this.bankruptcyStatuteField;
            }
            set
            {
                this.bankruptcyStatuteField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Debtor", Order = 13)]
        public EntityType[] Debtor
        {
            get
            {
                return this.debtorField;
            }
            set
            {
                this.debtorField = value;
                
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:JuvenileCase-4.0")]
    public partial class JuvenileCaseType : CaseType
    {

        private CaseAugmentationType caseAugmentationField;

        private CaseAugmentationType2 caseAugmentation1Field;

        private JuvenileType juvenileCaseJuvenileField;

        private ArrestType caseArrestField;

        private DependencyAllegationType[] dependencyAllegationField;

        private IncidentType[] items1Field;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://niem.gov/niem/domains/jxdm/4.0", Order = 0)]
        public CaseAugmentationType CaseAugmentation
        {
            get
            {
                return this.caseAugmentationField;
            }
            set
            {
                this.caseAugmentationField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CaseAugmentation", Namespace = "urn:tyler:ecf:extensions:Common", Order = 1)]
        public CaseAugmentationType2 CaseAugmentation1
        {
            get
            {
                return this.caseAugmentation1Field;
            }
            set
            {
                this.caseAugmentation1Field = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public JuvenileType JuvenileCaseJuvenile
        {
            get
            {
                return this.juvenileCaseJuvenileField;
            }
            set
            {
                this.juvenileCaseJuvenileField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public ArrestType CaseArrest
        {
            get
            {
                return this.caseArrestField;
            }
            set
            {
                this.caseArrestField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DependencyAllegation", Order = 4)]
        public DependencyAllegationType[] DependencyAllegation
        {
            get
            {
                return this.dependencyAllegationField;
            }
            set
            {
                this.dependencyAllegationField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DelinquentAct", typeof(DelinquentActType), Order = 5)]
        [System.Xml.Serialization.XmlElementAttribute("StatusOffenseAct", typeof(StatusOffenseActType), Order = 5)]
        public IncidentType[] Items1
        {
            get
            {
                return this.items1Field;
            }
            set
            {
                this.items1Field = value;
                
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CivilCase-4.0")]
    public partial class CivilCaseType : CaseType
    {

        private CaseAugmentationType caseAugmentationField;

        private CaseAugmentationType2 caseAugmentation1Field;

        private TextType[] causeOfActionCodeField;

        private AmountType3 amountInControversyField;

        private boolean classActionIndicatorField;

        private TextType[] jurisdictionalGroundsCodeField;

        private boolean juryDemandIndicatorField;

        private TextType[] reliefTypeCodeField;

        private ComplexObjectType item1Field;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://niem.gov/niem/domains/jxdm/4.0", Order = 0)]
        public CaseAugmentationType CaseAugmentation
        {
            get
            {
                return this.caseAugmentationField;
            }
            set
            {
                this.caseAugmentationField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CaseAugmentation", Namespace = "urn:tyler:ecf:extensions:Common", Order = 1)]
        public CaseAugmentationType2 CaseAugmentation1
        {
            get
            {
                return this.caseAugmentation1Field;
            }
            set
            {
                this.caseAugmentation1Field = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CauseOfActionCode", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CommonTypes-4.0", Order = 2)]
        public TextType[] CauseOfActionCode
        {
            get
            {
                return this.causeOfActionCodeField;
            }
            set
            {
                this.causeOfActionCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public AmountType3 AmountInControversy
        {
            get
            {
                return this.amountInControversyField;
            }
            set
            {
                this.amountInControversyField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public boolean ClassActionIndicator
        {
            get
            {
                return this.classActionIndicatorField;
            }
            set
            {
                this.classActionIndicatorField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("JurisdictionalGroundsCode", Order = 5)]
        public TextType[] JurisdictionalGroundsCode
        {
            get
            {
                return this.jurisdictionalGroundsCodeField;
            }
            set
            {
                this.jurisdictionalGroundsCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public boolean JuryDemandIndicator
        {
            get
            {
                return this.juryDemandIndicatorField;
            }
            set
            {
                this.juryDemandIndicatorField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ReliefTypeCode", Order = 7)]
        public TextType[] ReliefTypeCode
        {
            get
            {
                return this.reliefTypeCodeField;
            }
            set
            {
                this.reliefTypeCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DecedentEstateCase", typeof(DecedentEstateCaseType), Order = 8)]
        [System.Xml.Serialization.XmlElementAttribute("FiduciaryCase", typeof(FiduciaryCaseType), Order = 8)]
        public ComplexObjectType Item1
        {
            get
            {
                return this.item1Field;
            }
            set
            {
                this.item1Field = value;
                
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CitationCase-4.0")]
    public partial class CitationCaseType : CaseType
    {

        private CaseAugmentationType caseAugmentationField;

        private CaseAugmentationType2 caseAugmentation1Field;

        private CitationCaseAugmentationType citationCaseAugmentationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://niem.gov/niem/domains/jxdm/4.0", Order = 0)]
        public CaseAugmentationType CaseAugmentation
        {
            get
            {
                return this.caseAugmentationField;
            }
            set
            {
                this.caseAugmentationField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CaseAugmentation", Namespace = "urn:tyler:ecf:extensions:Common", Order = 1)]
        public CaseAugmentationType2 CaseAugmentation1
        {
            get
            {
                return this.caseAugmentation1Field;
            }
            set
            {
                this.caseAugmentation1Field = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public CitationCaseAugmentationType CitationCaseAugmentation
        {
            get
            {
                return this.citationCaseAugmentationField;
            }
            set
            {
                this.citationCaseAugmentationField = value;
                
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CriminalCase-4.0")]
    public partial class CriminalCaseType : CaseType
    {

        private CaseAugmentationType caseAugmentationField;

        private CaseAugmentationType2 caseAugmentation1Field;

        private ArrestType caseArrestField;

        private ChargeType2[] caseChargeField;

        private duration preliminaryHearingEstimatedDurationField;

        private TextType prosecutionRecommendedBailTextField;

        private SentenceType1[] sentenceField;

        private CitationCaseAugmentationType citationCaseAugmentationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://niem.gov/niem/domains/jxdm/4.0", Order = 0)]
        public CaseAugmentationType CaseAugmentation
        {
            get
            {
                return this.caseAugmentationField;
            }
            set
            {
                this.caseAugmentationField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CaseAugmentation", Namespace = "urn:tyler:ecf:extensions:Common", Order = 1)]
        public CaseAugmentationType2 CaseAugmentation1
        {
            get
            {
                return this.caseAugmentation1Field;
            }
            set
            {
                this.caseAugmentation1Field = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public ArrestType CaseArrest
        {
            get
            {
                return this.caseArrestField;
            }
            set
            {
                this.caseArrestField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CaseCharge", Order = 3)]
        public ChargeType2[] CaseCharge
        {
            get
            {
                return this.caseChargeField;
            }
            set
            {
                this.caseChargeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public duration PreliminaryHearingEstimatedDuration
        {
            get
            {
                return this.preliminaryHearingEstimatedDurationField;
            }
            set
            {
                this.preliminaryHearingEstimatedDurationField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public TextType ProsecutionRecommendedBailText
        {
            get
            {
                return this.prosecutionRecommendedBailTextField;
            }
            set
            {
                this.prosecutionRecommendedBailTextField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Sentence", Order = 6)]
        public SentenceType1[] Sentence
        {
            get
            {
                return this.sentenceField;
            }
            set
            {
                this.sentenceField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CitationCase-4.0", Order = 7)]
        public CitationCaseAugmentationType CitationCaseAugmentation
        {
            get
            {
                return this.citationCaseAugmentationField;
            }
            set
            {
                this.citationCaseAugmentationField = value;
                
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18058")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:tyler:ecf:extensions:CourtCase", TypeName = "CourtCaseType")]
    [System.Xml.Serialization.XmlRootAttribute("CourtCase", Namespace = "urn:tyler:ecf:extensions:CourtCase", IsNullable = false, ElementName = "CourtCaseType")]
    public class CourtCaseType : CaseType
    {
        private TextType[] propertyAccountNumberField;

        private FilingAssociationType[] filingAssociationField;

        private PartyServiceType[] partyServiceField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0, ElementName = "CaseTypeText")]
        public TextType CaseTypeText { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(Order = 1, ElementName = "CaseOtherDocketID")]
        public TextType CaseOtherDocketID { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(Order = 2, ElementName = "LowerCourtText")]
        public TextType LowerCourtText { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(Order = 3, ElementName = "LowerCourtCaseDocketID")]
        public TextType LowerCourtCaseDocketID { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(Order = 4, ElementName = "LowerCourtCaseTitleText")]
        public TextType LowerCourtCaseTitleText { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(Order = 5, ElementName = "LowerCourtJudgeText")]
        public TextType LowerCourtJudgeText { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(Order = 6, ElementName = "FilerTypeText")]
        public TextType FilerTypeText { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(Order = 7, ElementName = "AttachServiceContactIndicator")]
        public Boolean AttachServiceContactIndicator { get; set; }
        [System.Xml.Serialization.XmlElementAttribute("PropertyAccountNumber", Order = 8, ElementName = "PropertyAccountNumber")]
        public TextType[] PropertyAccountNumber { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://niem.gov/niem/domains/jxdm/4.0", Order = 9, ElementName = "CaseAugmentation")]
        public CaseAugmentationType CaseAugmentation { get; set; }
        [System.Xml.Serialization.XmlElementAttribute("CaseAugmentation", Namespace = "urn:tyler:ecf:extensions:Common", Order = 10)]
        public CaseAugmentationType2 CaseAugmentation1 { get; set; }
        [System.Xml.Serialization.XmlElementAttribute("FilingAssociation", Order = 11, ElementName = "FilingAssociation")]
        public FilingAssociationType[] FilingAssociation { get; set; }
        [System.Xml.Serialization.XmlElementAttribute("PartyService", Order = 12, ElementName = "PartyService")]
        public PartyServiceType[] PartyService { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(Order = 13, ElementName = "AmountInControversy")]
        public AmountType AmountInControversy { get; set; }

        public CourtCaseType()
        {
            //this.AmountInControversy = new AmountType();
            this.CaseAugmentation1 = new CaseAugmentationType2();
            this.CaseAugmentation = new CaseAugmentationType();
            this.AttachServiceContactIndicator = new Boolean();
            this.FilerTypeText = new TextType();
            this.LowerCourtJudgeText = new TextType();
            this.LowerCourtCaseTitleText = new TextType();
            this.LowerCourtCaseDocketID = new TextType();
            this.LowerCourtText = new TextType();
            this.CaseOtherDocketID = new TextType();
            this.CaseTypeText = new TextType();
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AppellateCaseType1))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://niem.gov/niem/domains/jxdm/4.0")]
    public partial class AppellateCaseType : CaseType
    {

        private AppellateCaseNoticeType appellateCaseNoticeField;

        private CaseType[] appellateCaseOriginalCaseField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public AppellateCaseNoticeType AppellateCaseNotice
        {
            get
            {
                return this.appellateCaseNoticeField;
            }
            set
            {
                this.appellateCaseNoticeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AppellateCaseOriginalCase", Order = 1)]
        public CaseType[] AppellateCaseOriginalCase
        {
            get
            {
                return this.appellateCaseOriginalCaseField;
            }
            set
            {
                this.appellateCaseOriginalCaseField = value;
                
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AppellateCaseType", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:AppellateCase-4.0")]
    [XmlRoot("AppellateCase", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:AppellateCase-4.0", IsNullable = false)]
    public partial class AppellateCaseType1 : AppellateCaseType
    {
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://niem.gov/niem/domains/jxdm/4.0", Order = 0, ElementName = "CaseAugmentation")]
        public CaseAugmentationType CaseAugmentation { get; set; }
        [System.Xml.Serialization.XmlElementAttribute("CaseAugmentation", Namespace = "urn:tyler:ecf:extensions:Common", Order = 1)]
        public CaseAugmentationType2 CaseAugmentation1 { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(Order = 2, ElementName = "AppellantInCustodyIndicator")]
        public Boolean AppellantInCustodyIndicator { get; set; }
        [System.Xml.Serialization.XmlElementAttribute("AppellateCaseAddedParty", Order = 3, ElementName = "AppellateCaseAddedParty")]
        public AppellateCaseAddedPartyType[] AppellateCaseAddedParty { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(Order = 4, ElementName = "AppellateCaseJurisdictionBasisText")]
        public TextType AppellateCaseJurisdictionBasisText { get; set; }
        [System.Xml.Serialization.XmlElementAttribute(Order = 5, ElementName = "AppellateCaseSettlementRequestText")]
        public TextType AppellateCaseSettlementRequestText { get; set; }
        [System.Xml.Serialization.XmlElementAttribute("AppellateCaseRemovedParty", Order = 6, ElementName = "AppellateCaseRemovedParty")]
        public AppellateCaseRemovedPartyType[] AppellateCaseRemovedParty { get; set; }
        [System.Xml.Serialization.XmlElementAttribute("AppellateCivilCase", typeof(AppellateCivilCaseType), Order = 7, ElementName = "Item1")]
        [System.Xml.Serialization.XmlElementAttribute("AppellateCourtRuleCase", typeof(AppellateCourtRuleCaseType), Order = 7)]
        public ComplexObjectType Item1 { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:DomesticCase-4.0")]
    [XmlRoot("DomesticCase", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:DomesticCase-4.0", IsNullable = false)]
    public partial class DomesticCaseType : CaseType
    {

        private CaseAugmentationType caseAugmentationField;

        private CaseAugmentationType2 caseAugmentation1Field;

        private ImmediateFamilyAssociationType[] immediateFamilyAssociationField;

        private TextType causeOfActionCodeField;

        private boolean caseContestedIndicatorField;

        private PersonType2[] domesticCasePersonField;

        private DomesticCaseViolencePetitionType domesticCaseViolencePetitionField;

        private DomesticCaseChildSupportPetitionType[] domesticCaseChildSupportPetitionField;

        private DomesticCaseOrderType[] domesticCaseOrderField;

        private MarriageAssociationType[] marriageAssociationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://niem.gov/niem/domains/jxdm/4.0", Order = 0)]
        public CaseAugmentationType CaseAugmentation
        {
            get
            {
                return this.caseAugmentationField;
            }
            set
            {
                this.caseAugmentationField = value;

            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CaseAugmentation", Namespace = "urn:tyler:ecf:extensions:Common", Order = 1)]
        public CaseAugmentationType2 CaseAugmentation1
        {
            get
            {
                return this.caseAugmentation1Field;
            }
            set
            {
                this.caseAugmentation1Field = value;

            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ImmediateFamilyAssociation", Namespace = "http://niem.gov/niem/niem-core/2.0", Order = 2)]
        public ImmediateFamilyAssociationType[] ImmediateFamilyAssociation
        {
            get
            {
                return this.immediateFamilyAssociationField;
            }
            set
            {
                this.immediateFamilyAssociationField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CommonTypes-4.0", Order = 3)]
        public TextType CauseOfActionCode
        {
            get
            {
                return this.causeOfActionCodeField;
            }
            set
            {
                this.causeOfActionCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public boolean CaseContestedIndicator
        {
            get
            {
                return this.caseContestedIndicatorField;
            }
            set
            {
                this.caseContestedIndicatorField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DomesticCasePerson", Order = 5)]
        public PersonType2[] DomesticCasePerson
        {
            get
            {
                return this.domesticCasePersonField;
            }
            set
            {
                this.domesticCasePersonField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public DomesticCaseViolencePetitionType DomesticCaseViolencePetition
        {
            get
            {
                return this.domesticCaseViolencePetitionField;
            }
            set
            {
                this.domesticCaseViolencePetitionField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DomesticCaseChildSupportPetition", Order = 7)]
        public DomesticCaseChildSupportPetitionType[] DomesticCaseChildSupportPetition
        {
            get
            {
                return this.domesticCaseChildSupportPetitionField;
            }
            set
            {
                this.domesticCaseChildSupportPetitionField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DomesticCaseOrder", Order = 8)]
        public DomesticCaseOrderType[] DomesticCaseOrder
        {
            get
            {
                return this.domesticCaseOrderField;
            }
            set
            {
                this.domesticCaseOrderField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MarriageAssociation", Order = 9)]
        public MarriageAssociationType[] MarriageAssociation
        {
            get
            {
                return this.marriageAssociationField;
            }
            set
            {
                this.marriageAssociationField = value;
                
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ChargeType3))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ChargeType", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CriminalCase-4.0")]
    public partial class ChargeType2 : ChargeType1
    {

        private IncidentType chargeOffenseField;

        private StatuteType[] chargeChargingAgencyJurisdictionStatuteField;

        private boolean chargeAmendedIndicatorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public IncidentType ChargeOffense
        {
            get
            {
                return this.chargeOffenseField;
            }
            set
            {
                this.chargeOffenseField = value;

            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ChargeChargingAgencyJurisdictionStatute", Order = 1)]
        public StatuteType[] ChargeChargingAgencyJurisdictionStatute
        {
            get
            {
                return this.chargeChargingAgencyJurisdictionStatuteField;
            }
            set
            {
                this.chargeChargingAgencyJurisdictionStatuteField = value;

            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public boolean ChargeAmendedIndicator
        {
            get
            {
                return this.chargeAmendedIndicatorField;
            }
            set
            {
                this.chargeAmendedIndicatorField = value;

            }
        }
    }

}
