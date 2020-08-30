

namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CommonTypes-4.0")]
    public abstract partial class CaseFilingType : DocumentType
    {

        private IdentificationType sendingMDELocationIDField;

        private string sendingMDEProfileCodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public IdentificationType SendingMDELocationID
        {
            get
            {
                return this.sendingMDELocationIDField;
            }
            set
            {
                this.sendingMDELocationIDField = value;

            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString", Order = 1)]
        public string SendingMDEProfileCode
        {
            get
            {
                return this.sendingMDEProfileCodeField;
            }
            set
            {
                this.sendingMDEProfileCodeField = value;

            }
        }
    }

}