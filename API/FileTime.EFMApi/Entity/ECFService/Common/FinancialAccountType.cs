namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class FinancialAccountType
    {

        private IDType idField;

        private NameType1 nameField;

        private AliasNameType aliasNameField;

        private AccountTypeCodeType accountTypeCodeField;

        private AccountFormatCodeType accountFormatCodeField;

        private CurrencyCodeType currencyCodeField;

        private PaymentNoteType[] paymentNoteField;

        private BranchType financialInstitutionBranchField;

        private CountryType countryField;

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
        public NameType1 Name
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public AliasNameType AliasName
        {
            get
            {
                return this.aliasNameField;
            }
            set
            {
                this.aliasNameField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public AccountTypeCodeType AccountTypeCode
        {
            get
            {
                return this.accountTypeCodeField;
            }
            set
            {
                this.accountTypeCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
        public AccountFormatCodeType AccountFormatCode
        {
            get
            {
                return this.accountFormatCodeField;
            }
            set
            {
                this.accountFormatCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 5)]
        public CurrencyCodeType CurrencyCode
        {
            get
            {
                return this.currencyCodeField;
            }
            set
            {
                this.currencyCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PaymentNote", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 6)]
        public PaymentNoteType[] PaymentNote
        {
            get
            {
                return this.paymentNoteField;
            }
            set
            {
                this.paymentNoteField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public BranchType FinancialInstitutionBranch
        {
            get
            {
                return this.financialInstitutionBranchField;
            }
            set
            {
                this.financialInstitutionBranchField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public CountryType Country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
                
            }
        }

        

    }
}