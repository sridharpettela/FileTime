using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTime.EFMApi.Entity.ECFService
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class NotifyEventRequest
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:tyler:ecf:extensions:EventCallbackMessage", Order = 0)]
        public EventCallbackMessageType EventCallbackMessage;

        public NotifyEventRequest()
        {
        }

        public NotifyEventRequest(EventCallbackMessageType EventCallbackMessage)
        {
            this.EventCallbackMessage = EventCallbackMessage;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class NotifyEventResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:MessageReceiptMessage-4.0", Order = 0)]
        public MessageReceiptMessageType MessageReceiptMessage;

        public NotifyEventResponse()
        {
        }

        public NotifyEventResponse(MessageReceiptMessageType MessageReceiptMessage)
        {
            this.MessageReceiptMessage = MessageReceiptMessage;
        }
    }




    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class NotifyFilingReviewCompleteRequest
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServicesProfile-Definitions-4.0", Order = 0)]
        public NotifyFilingReviewCompleteRequestMessageType NotifyFilingReviewCompleteRequestMessage;

        public NotifyFilingReviewCompleteRequest()
        {
        }

        public NotifyFilingReviewCompleteRequest(NotifyFilingReviewCompleteRequestMessageType NotifyFilingReviewCompleteRequestMessage)
        {
            this.NotifyFilingReviewCompleteRequestMessage = NotifyFilingReviewCompleteRequestMessage;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class NotifyFilingReviewCompleteResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:MessageReceiptMessage-4.0", Order = 0)]
        public MessageReceiptMessageType MessageReceiptMessage;

        public NotifyFilingReviewCompleteResponse()
        {
        }

        public NotifyFilingReviewCompleteResponse(MessageReceiptMessageType MessageReceiptMessage)
        {
            this.MessageReceiptMessage = MessageReceiptMessage;
        }
    }


    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class NotifyServiceCompleteRequest
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:tyler:ecf:extensions:ServiceCallbackMessage", Order = 0)]
        public ServiceCallbackMessageType ServiceCallbackMessage;

        public NotifyServiceCompleteRequest()
        {
        }

        public NotifyServiceCompleteRequest(ServiceCallbackMessageType ServiceCallbackMessage)
        {
            this.ServiceCallbackMessage = ServiceCallbackMessage;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class NotifyServiceCompleteResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:MessageReceiptMessage-4.0", Order = 0)]
        public MessageReceiptMessageType MessageReceiptMessage;

        public NotifyServiceCompleteResponse()
        {
        }

        public NotifyServiceCompleteResponse(MessageReceiptMessageType MessageReceiptMessage)
        {
            this.MessageReceiptMessage = MessageReceiptMessage;
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRoot("NotifyFilingReviewCompleteRequestMessage", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServicesProfile-Definitions-4.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServicesProfile-Definitions-4.0")]
    public partial class NotifyFilingReviewCompleteRequestMessageType : ElectronicFilingMessageType
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:ReviewFilingCallbackMessage-4." +
            "0", Order = 0)]
        public ReviewFilingCallbackMessageType ReviewFilingCallbackMessage { set; get; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:PaymentReceiptMessage-4.0", Order = 1)]
        public PaymentMessageType PaymentReceiptMessage { set; get; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRoot("ServiceCallbackMessage", Namespace = "urn:tyler:ecf:extensions:ServiceCallbackMessage")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:tyler:ecf:extensions:ServiceCallbackMessage")]
    public partial class ServiceCallbackMessageType : CaseFilingType
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0", Order = 0)]
        [System.Xml.Serialization.XmlElement("CivilCase", typeof(CivilCaseType),
         Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CivilCase-4.0", Order = 0)]
        [System.Xml.Serialization.XmlElement("DomesticCase", typeof(DomesticCaseType),
          Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:DomesticCase-4.0", Order = 0)]
        [System.Xml.Serialization.XmlElement("BankruptcyCase", typeof(BankruptcyCaseType),
         Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:BankruptcyCase-4.0", Order = 0)]
        [System.Xml.Serialization.XmlElement("CitationCase", typeof(CitationCaseType),
         Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CitationCase-4.0", Order = 0)]
        [System.Xml.Serialization.XmlElement("AppellateCase", typeof(AppellateCaseType),
         Namespace = "http://niem.gov/niem/domains/jxdm/4.0", Order = 0)]
        [System.Xml.Serialization.XmlElement("AppellateCase", typeof(AppellateCaseType1),
         Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:AppellateCase-4.0", Order = 0)]
        [System.Xml.Serialization.XmlElement("JuvenileCase", typeof(JuvenileCaseType),
         Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:JuvenileCase-4.0", Order = 0)]
        [System.Xml.Serialization.XmlElement("CriminalCase", typeof(CriminalCaseType),
         Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CriminalCase-4.0", Order = 0)]
        [System.Xml.Serialization.XmlElement("CourtCase", typeof(CourtCaseType),
       Namespace = "urn:tyler:ecf:extensions:CourtCase", Order = 0)]
        public CaseType Case { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:tyler:ecf:extensions:Common", Order = 1)]
        public DateType ServiceDate { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CommonTypes-4.0", Order = 2)]
        public ElectronicServiceInformationType ElectronicServiceInformation { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:tyler:ecf:extensions:Common", Order = 3)]
        public FilerInformationType FilerInformation { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:tyler:ecf:extensions:Common", Order = 4)]
        public RecipientInformationType RecipientInformation { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:tyler:ecf:extensions:Common", Order = 5)]
        public SubmitterInformationType SubmitterInformation { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:tyler:ecf:extensions:Common", Order = 6)]
        public ReviewedDocumentType1 ReviewedLeadDocument { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ReviewedConnectedDocument", Namespace = "urn:tyler:ecf:extensions:Common", Order = 7)]
        public ReviewedDocumentType1[] ReviewedConnectedDocument { get; set; }
    }


    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:tyler:ecf:extensions:Common")]
    public partial class SubmitterInformationType
    {
        public TextType SubmitterName { get; set; }

        public TextType SubmitterFirmName { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:tyler:ecf:extensions:Common")]
    public partial class RecipientInformationType
    {
        public TextType RecipientName { get; set; }

        public TextType RecipientFirmName { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ReviewedDocumentType", Namespace = "urn:tyler:ecf:extensions:Common")]
    public partial class ReviewedDocumentType1 : ReviewedDocumentType
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public EntityType DocumentReviewer { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public DateType DocumentReviewDate { get; set; }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public TextType FilingReviewCommentsText { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public TextType RejectReasonText { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public boolean WaiverIndicator { get; set; }
    }

}
