namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DocumentRenditionMetadataType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DocumentRenditionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DocumentType1))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ReviewedDocumentType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ReviewedDocumentType1))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CourtEventDocumentType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExtendedDocumentType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AppellateCaseNoticeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CaseFilingType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ServiceCallbackMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ElectronicFilingMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CreateCaseMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ReviewFilingRequestMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RecordDocketingMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RecordFilingRequestMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NotifyFilingReviewCompleteRequestMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CoreFilingMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ElectronicFilingCallbackMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ReviewFilingCallbackMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RecordDocketingCallbackMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MessageReceiptMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ServiceReceiptMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CourtPolicyQueryMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MatchingFilingType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public class DocumentType : ComplexObjectType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0, Namespace = "urn:tyler:ecf:extensions:Common")]
        public TextType CaseTitle { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CaseNumber", Order = 1, Namespace = "urn:tyler:ecf:extensions:Common")]
        public TextType CaseNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2, Namespace = "urn:tyler:ecf:extensions:Common")]
        public TextType FilingType { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3, Namespace = "urn:tyler:ecf:extensions:Common")]
        public TextType FilingAttorney { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4, Namespace = "urn:tyler:ecf:extensions:Common")]
        public TextType FilingCode { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public ApplicationNameType DocumentApplicationName { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public BinaryType DocumentBinary { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DocumentCategoryText", Order = 7)]
        public TextType[] DocumentCategoryText { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public TextType DocumentDescriptionText { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public DateType DocumentEffectiveDate { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public @string DocumentFileControlID { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public DateType DocumentFiledDate { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DocumentIdentification", Order = 12)]
        public IdentificationType[] DocumentIdentification { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
        public DateType DocumentInformationCutOffDate { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
        public DateType DocumentPostDate { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 15)]
        public DateType DocumentReceivedDate { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 16)]
        public @string DocumentSequenceID { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 17)]
        public StatusType DocumentStatus { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 18)]
        public TextType DocumentTitleText { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DocumentLanguageCode", Order = 19)]
        public LanguageCodeType Item { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 20)]
        public EntityType DocumentSubmitter { get; set; }
    }
}