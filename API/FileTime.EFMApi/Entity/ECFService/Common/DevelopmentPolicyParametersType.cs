namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CourtPolicyResponseMessage-4.0" +
                                                           "")]
    public partial class DevelopmentPolicyParametersType : ComplexObjectType
    {

        private boolean uRLAttachmentSupportedIndicatorField;

        private boolean acceptDocumentsRequiringFeesIndicatorField;

        private boolean acceptConfidentialFilingsIndicatorField;

        private boolean acceptMultipleLeadDocumentsIndicatorField;

        private MeasureType3 maximumAllowedAttachmentSizeField;

        private MeasureType3 maximumAllowedMessageSizeField;

        private TextType[] supportedMessageProfileCodeField;

        private TextType[] supportedSignatureProfileCodeField;

        private OperationNameType[] supportedOperationNameField;

        private CaseTypeCodeType[] supportedCaseTypeField;

        private CourtExtensionType[] courtExtensionField;

        private boolean filingFeesMayBeApplicableIndicatorField;

        private DateType effectiveDateField;

        private DateType expirationDateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public boolean URLAttachmentSupportedIndicator
        {
            get
            {
                return this.uRLAttachmentSupportedIndicatorField;
            }
            set
            {
                this.uRLAttachmentSupportedIndicatorField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public boolean AcceptDocumentsRequiringFeesIndicator
        {
            get
            {
                return this.acceptDocumentsRequiringFeesIndicatorField;
            }
            set
            {
                this.acceptDocumentsRequiringFeesIndicatorField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public boolean AcceptConfidentialFilingsIndicator
        {
            get
            {
                return this.acceptConfidentialFilingsIndicatorField;
            }
            set
            {
                this.acceptConfidentialFilingsIndicatorField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public boolean AcceptMultipleLeadDocumentsIndicator
        {
            get
            {
                return this.acceptMultipleLeadDocumentsIndicatorField;
            }
            set
            {
                this.acceptMultipleLeadDocumentsIndicatorField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public MeasureType3 MaximumAllowedAttachmentSize
        {
            get
            {
                return this.maximumAllowedAttachmentSizeField;
            }
            set
            {
                this.maximumAllowedAttachmentSizeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public MeasureType3 MaximumAllowedMessageSize
        {
            get
            {
                return this.maximumAllowedMessageSizeField;
            }
            set
            {
                this.maximumAllowedMessageSizeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SupportedMessageProfileCode", Order = 6)]
        public TextType[] SupportedMessageProfileCode
        {
            get
            {
                return this.supportedMessageProfileCodeField;
            }
            set
            {
                this.supportedMessageProfileCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SupportedSignatureProfileCode", Order = 7)]
        public TextType[] SupportedSignatureProfileCode
        {
            get
            {
                return this.supportedSignatureProfileCodeField;
            }
            set
            {
                this.supportedSignatureProfileCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SupportedOperationName", Order = 8)]
        public OperationNameType[] SupportedOperationName
        {
            get
            {
                return this.supportedOperationNameField;
            }
            set
            {
                this.supportedOperationNameField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SupportedCaseType", Order = 9)]
        public CaseTypeCodeType[] SupportedCaseType
        {
            get
            {
                return this.supportedCaseTypeField;
            }
            set
            {
                this.supportedCaseTypeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CourtExtension", Order = 10)]
        public CourtExtensionType[] CourtExtension
        {
            get
            {
                return this.courtExtensionField;
            }
            set
            {
                this.courtExtensionField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public boolean FilingFeesMayBeApplicableIndicator
        {
            get
            {
                return this.filingFeesMayBeApplicableIndicatorField;
            }
            set
            {
                this.filingFeesMayBeApplicableIndicatorField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public DateType EffectiveDate
        {
            get
            {
                return this.effectiveDateField;
            }
            set
            {
                this.effectiveDateField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
        public DateType ExpirationDate
        {
            get
            {
                return this.expirationDateField;
            }
            set
            {
                this.expirationDateField = value;
                
            }
        }
    }
}