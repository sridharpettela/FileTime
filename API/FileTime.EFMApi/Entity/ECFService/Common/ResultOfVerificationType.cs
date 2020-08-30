namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class ResultOfVerificationType
    {

        private ValidatorIDType validatorIDField;

        private ValidationResultCodeType validationResultCodeField;

        private ValidationDateType validationDateField;

        private ValidationTimeType validationTimeField;

        private ValidateProcessType validateProcessField;

        private ValidateToolType validateToolField;

        private ValidateToolVersionType validateToolVersionField;

        private PartyType signatoryPartyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public ValidatorIDType ValidatorID
        {
            get
            {
                return this.validatorIDField;
            }
            set
            {
                this.validatorIDField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public ValidationResultCodeType ValidationResultCode
        {
            get
            {
                return this.validationResultCodeField;
            }
            set
            {
                this.validationResultCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public ValidationDateType ValidationDate
        {
            get
            {
                return this.validationDateField;
            }
            set
            {
                this.validationDateField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public ValidationTimeType ValidationTime
        {
            get
            {
                return this.validationTimeField;
            }
            set
            {
                this.validationTimeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
        public ValidateProcessType ValidateProcess
        {
            get
            {
                return this.validateProcessField;
            }
            set
            {
                this.validateProcessField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 5)]
        public ValidateToolType ValidateTool
        {
            get
            {
                return this.validateToolField;
            }
            set
            {
                this.validateToolField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 6)]
        public ValidateToolVersionType ValidateToolVersion
        {
            get
            {
                return this.validateToolVersionField;
            }
            set
            {
                this.validateToolVersionField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public PartyType SignatoryParty
        {
            get
            {
                return this.signatoryPartyField;
            }
            set
            {
                this.signatoryPartyField = value;
                
            }
        }

        
    }
}