using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:tyler:ecf:extensions:ServiceInformationHistoryQueryMessage")]
    [System.Xml.Serialization.XmlRoot(ElementName = "ServiceInformationHistoryQueryMessage", Namespace = "urn:tyler:ecf:extensions:ServiceInformationHistoryQueryMessage")]
    public partial class ServiceInformationHistoryQueryMessageType : QueryMessageType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0", Order = 0)]
        public @string CaseTrackingID { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:tyler:ecf:extensions:ServiceInformationHistoryResponseMessage")]
    [System.Xml.Serialization.XmlRoot(ElementName = "ServiceInformationHistoryResponseMessage", Namespace = "urn:tyler:ecf:extensions:ServiceInformationHistoryResponseMessage")]
    public partial class ServiceInformationHistoryResponseMessageType : QueryResponseMessageType
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0", Order = 0)]
        public @string CaseTrackingID { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ServiceRecipient", Order = 1)]
        public ServiceRecipientType[] ServiceRecipient { get; set; }
    }
}
