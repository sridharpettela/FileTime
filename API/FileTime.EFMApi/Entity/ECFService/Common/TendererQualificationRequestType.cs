namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class TendererQualificationRequestType
    {

        private LegalFormType[] legalFormField;

        private PersonalSituationType[] personalSituationField;

        private OperatingYearsQuantityType operatingYearsQuantityField;

        private EmployeeQuantityType employeeQuantityField;

        private DescriptionType[] descriptionField;

        private ClassificationSchemeType[] requiredBusinessClassificationSchemeField;

        private EvaluationCriteriaType[] technicalEvaluationCriteriaField;

        private EvaluationCriteriaType[] financialEvaluationCriteriaField;

        private TendererRequirementType[] specificTendererRequirementField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LegalForm", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public LegalFormType[] LegalForm
        {
            get
            {
                return this.legalFormField;
            }
            set
            {
                this.legalFormField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonalSituation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public PersonalSituationType[] PersonalSituation
        {
            get
            {
                return this.personalSituationField;
            }
            set
            {
                this.personalSituationField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public OperatingYearsQuantityType OperatingYearsQuantity
        {
            get
            {
                return this.operatingYearsQuantityField;
            }
            set
            {
                this.operatingYearsQuantityField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public EmployeeQuantityType EmployeeQuantity
        {
            get
            {
                return this.employeeQuantityField;
            }
            set
            {
                this.employeeQuantityField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
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
        [System.Xml.Serialization.XmlElementAttribute("RequiredBusinessClassificationScheme", Order = 5)]
        public ClassificationSchemeType[] RequiredBusinessClassificationScheme
        {
            get
            {
                return this.requiredBusinessClassificationSchemeField;
            }
            set
            {
                this.requiredBusinessClassificationSchemeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TechnicalEvaluationCriteria", Order = 6)]
        public EvaluationCriteriaType[] TechnicalEvaluationCriteria
        {
            get
            {
                return this.technicalEvaluationCriteriaField;
            }
            set
            {
                this.technicalEvaluationCriteriaField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FinancialEvaluationCriteria", Order = 7)]
        public EvaluationCriteriaType[] FinancialEvaluationCriteria
        {
            get
            {
                return this.financialEvaluationCriteriaField;
            }
            set
            {
                this.financialEvaluationCriteriaField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SpecificTendererRequirement", Order = 8)]
        public TendererRequirementType[] SpecificTendererRequirement
        {
            get
            {
                return this.specificTendererRequirementField;
            }
            set
            {
                this.specificTendererRequirementField = value;
                
            }
        }

        
    }
}