using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:ServiceInformationQueryMessage" +
        "-4.0")]
    [XmlRoot(ElementName = "ServiceInformationQueryMessage", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:ServiceInformationQueryMessage-4.0")]
    public partial class ServiceInformationQueryMessageType : QueryMessageType
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:ServiceInformationResponseMessage-4.0")]
    [System.Xml.Serialization.XmlRoot(ElementName = "ServiceInformationResponseMessage", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:ServiceInformationResponseMessage-4.0")]
    public partial class ServiceInformationResponseMessageType : QueryResponseMessageType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0", Order = 0)]
        public @string CaseTrackingID { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ServiceRecipient", Order = 1)]
        public EntityType[] ServiceRecipient { get; set; }
    }
}
