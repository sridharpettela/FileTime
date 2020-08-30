namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CreateCaseMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ReviewFilingRequestMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RecordDocketingMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RecordFilingRequestMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NotifyFilingReviewCompleteRequestMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CoreFilingMessageType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CommonTypes-4.0")]
    public abstract partial class ElectronicFilingMessageType : CaseFilingType
    {

        private ElectronicServiceInformationType[] electronicServiceInformationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ElectronicServiceInformation", Order = 0)]
        public ElectronicServiceInformationType[] ElectronicServiceInformation
        {
            get
            {
                return this.electronicServiceInformationField;
            }
            set
            {
                this.electronicServiceInformationField = value;
                
            }
        }
    }
}