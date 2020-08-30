namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class TradeFinancingType
    {

        private IDType idField;

        private FinancingInstrumentCodeType financingInstrumentCodeField;

        private ClauseCodeType[] clauseCodeField;

        private ClauseType[] clauseField;

        private DocumentReferenceType contractDocumentReferenceField;

        private DocumentReferenceType[] documentReferenceField;

        private PartyType financingPartyField;

        private FinancialAccountType financingFinancialAccountField;

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
        public FinancingInstrumentCodeType FinancingInstrumentCode
        {
            get
            {
                return this.financingInstrumentCodeField;
            }
            set
            {
                this.financingInstrumentCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ClauseCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public ClauseCodeType[] ClauseCode
        {
            get
            {
                return this.clauseCodeField;
            }
            set
            {
                this.clauseCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Clause", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public ClauseType[] Clause
        {
            get
            {
                return this.clauseField;
            }
            set
            {
                this.clauseField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public DocumentReferenceType ContractDocumentReference
        {
            get
            {
                return this.contractDocumentReferenceField;
            }
            set
            {
                this.contractDocumentReferenceField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DocumentReference", Order = 5)]
        public DocumentReferenceType[] DocumentReference
        {
            get
            {
                return this.documentReferenceField;
            }
            set
            {
                this.documentReferenceField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public PartyType FinancingParty
        {
            get
            {
                return this.financingPartyField;
            }
            set
            {
                this.financingPartyField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public FinancialAccountType FinancingFinancialAccount
        {
            get
            {
                return this.financingFinancialAccountField;
            }
            set
            {
                this.financingFinancialAccountField = value;
                
            }
        }

      
    }
}