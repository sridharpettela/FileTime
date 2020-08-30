namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class QualifyingPartyType
    {

        private ParticipationPercentType participationPercentField;

        private PersonalSituationType[] personalSituationField;

        private OperatingYearsQuantityType operatingYearsQuantityField;

        private EmployeeQuantityType employeeQuantityField;

        private BusinessClassificationEvidenceIDType businessClassificationEvidenceIDField;

        private BusinessIdentityEvidenceIDType businessIdentityEvidenceIDField;

        private ClassificationSchemeType businessClassificationSchemeField;

        private CapabilityType1[] technicalCapabilityField;

        private CapabilityType1[] financialCapabilityField;

        private CompletedTaskType[] completedTaskField;

        private DeclarationType[] declarationField;

        private PartyType partyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public ParticipationPercentType ParticipationPercent
        {
            get
            {
                return this.participationPercentField;
            }
            set
            {
                this.participationPercentField = value;
                
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
        public BusinessClassificationEvidenceIDType BusinessClassificationEvidenceID
        {
            get
            {
                return this.businessClassificationEvidenceIDField;
            }
            set
            {
                this.businessClassificationEvidenceIDField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 5)]
        public BusinessIdentityEvidenceIDType BusinessIdentityEvidenceID
        {
            get
            {
                return this.businessIdentityEvidenceIDField;
            }
            set
            {
                this.businessIdentityEvidenceIDField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public ClassificationSchemeType BusinessClassificationScheme
        {
            get
            {
                return this.businessClassificationSchemeField;
            }
            set
            {
                this.businessClassificationSchemeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TechnicalCapability", Order = 7)]
        public CapabilityType1[] TechnicalCapability
        {
            get
            {
                return this.technicalCapabilityField;
            }
            set
            {
                this.technicalCapabilityField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FinancialCapability", Order = 8)]
        public CapabilityType1[] FinancialCapability
        {
            get
            {
                return this.financialCapabilityField;
            }
            set
            {
                this.financialCapabilityField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CompletedTask", Order = 9)]
        public CompletedTaskType[] CompletedTask
        {
            get
            {
                return this.completedTaskField;
            }
            set
            {
                this.completedTaskField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Declaration", Order = 10)]
        public DeclarationType[] Declaration
        {
            get
            {
                return this.declarationField;
            }
            set
            {
                this.declarationField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public PartyType Party
        {
            get
            {
                return this.partyField;
            }
            set
            {
                this.partyField = value;
                
            }
        }

        

    }
}