
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;

namespace FileTime.EFMApi.Entity.ECFService
{
   

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProperNameTextType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PersonNameTextType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public partial class TextType : @string
    {
    }


    ///// <remarks/>
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    //[System.SerializableAttribute()]
    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.ComponentModel.DesignerCategoryAttribute("code")]
    //[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:wsdl:WebServicesProfile-Definitions-4.0")]
    //public partial class NotifyFilingReviewCompleteRequestMessageType : ElectronicFilingMessageType
    //{

    //    private ReviewFilingCallbackMessageType reviewFilingCallbackMessageField;

    //    private PaymentMessageType paymentReceiptMessageField;

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:ReviewFilingCallbackMessage-4." +
    //        "0", Order = 0)]
    //    public ReviewFilingCallbackMessageType ReviewFilingCallbackMessage
    //    {
    //        get
    //        {
    //            return this.reviewFilingCallbackMessageField;
    //        }
    //        set
    //        {
    //            this.reviewFilingCallbackMessageField = value;
    //            
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:PaymentReceiptMessage-4.0", Order = 1)]
    //    public PaymentMessageType PaymentReceiptMessage
    //    {
    //        get
    //        {
    //            return this.paymentReceiptMessageField;
    //        }
    //        set
    //        {
    //            this.paymentReceiptMessageField = value;
    //            
    //        }
    //    }
    //}
}
