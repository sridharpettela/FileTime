namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://niem.gov/niem/domains/jxdm/4.0")]
    public partial class CaseAugmentationType : AugmentationType
    {

        private ChargeType1[] caseChargeField;

        private CourtType caseCourtField;

        private CourtEventType[] caseCourtEventField;

        private EntityType[] caseDefendantPartyField;

        private CaseOfficialType[] caseDefenseAttorneyField;

        private EntityType[] caseInitiatingPartyField;

        private CaseOfficialType[] caseJudgeField;

        private CaseType[] caseLineageCaseField;

        private CaseOfficialType[] caseOfficialField;

        private EntityType[] caseOtherEntityField;

        private CaseOfficialType[] caseProsecutionAttorneyField;

        private CaseOfficialType[] caseRespondentAttorneyField;

        private EntityType[] caseRespondentPartyField;

        private CaseOfficialType[] caseInitiatingAttorneyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CaseCharge",  Order = 0)]
        public ChargeType1[] CaseCharge
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
        [System.Xml.Serialization.XmlElementAttribute( Order = 1)]
        public CourtType CaseCourt
        {
            get
            {
                return this.caseCourtField;
            }
            set
            {
                this.caseCourtField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CaseCourtEvent",  Order = 2)]
        public CourtEventType[] CaseCourtEvent
        {
            get
            {
                return this.caseCourtEventField;
            }
            set
            {
                this.caseCourtEventField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CaseDefendantParty",  Order = 3)]
        public EntityType[] CaseDefendantParty
        {
            get
            {
                return this.caseDefendantPartyField;
            }
            set
            {
                this.caseDefendantPartyField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CaseDefenseAttorney",  Order = 4)]
        public CaseOfficialType[] CaseDefenseAttorney
        {
            get
            {
                return this.caseDefenseAttorneyField;
            }
            set
            {
                this.caseDefenseAttorneyField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CaseInitiatingParty",  Order = 5)]
        public EntityType[] CaseInitiatingParty
        {
            get
            {
                return this.caseInitiatingPartyField;
            }
            set
            {
                this.caseInitiatingPartyField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CaseJudge",  Order = 6)]
        public CaseOfficialType[] CaseJudge
        {
            get
            {
                return this.caseJudgeField;
            }
            set
            {
                this.caseJudgeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CaseLineageCase",  Order = 7)]
        public CaseType[] CaseLineageCase
        {
            get
            {
                return this.caseLineageCaseField;
            }
            set
            {
                this.caseLineageCaseField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CaseOfficial",  Order = 8)]
        public CaseOfficialType[] CaseOfficial
        {
            get
            {
                return this.caseOfficialField;
            }
            set
            {
                this.caseOfficialField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CaseOtherEntity",  Order = 9)]
        public EntityType[] CaseOtherEntity
        {
            get
            {
                return this.caseOtherEntityField;
            }
            set
            {
                this.caseOtherEntityField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CaseProsecutionAttorney",  Order = 10)]
        public CaseOfficialType[] CaseProsecutionAttorney
        {
            get
            {
                return this.caseProsecutionAttorneyField;
            }
            set
            {
                this.caseProsecutionAttorneyField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CaseRespondentAttorney",  Order = 11)]
        public CaseOfficialType[] CaseRespondentAttorney
        {
            get
            {
                return this.caseRespondentAttorneyField;
            }
            set
            {
                this.caseRespondentAttorneyField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CaseRespondentParty",  Order = 12)]
        public EntityType[] CaseRespondentParty
        {
            get
            {
                return this.caseRespondentPartyField;
            }
            set
            {
                this.caseRespondentPartyField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CaseInitiatingAttorney",  Order = 13)]
        public CaseOfficialType[] CaseInitiatingAttorney
        {
            get
            {
                return this.caseInitiatingAttorneyField;
            }
            set
            {
                this.caseInitiatingAttorneyField = value;
                
            }
        }
    }
}