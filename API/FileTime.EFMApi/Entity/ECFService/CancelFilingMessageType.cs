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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:tyler:ecf:extensions:CancelFilingMessage")]
    [System.Xml.Serialization.XmlRoot("CancelFilingMessage", Namespace = "urn:tyler:ecf:extensions:CancelFilingMessage")]
    public partial class CancelFilingMessageType : QueryMessageType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0", Order = 0)]
        public IdentificationType DocumentIdentification { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:tyler:ecf:extensions:CancelFilingResponseMessage")]
    [System.Xml.Serialization.XmlRoot("CancelFilingResponseMessage", Namespace = "urn:tyler:ecf:extensions:CancelFilingResponseMessage")]
    public partial class CancelFilingResponseMessageType : QueryResponseMessageType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0", Order = 0)]
        public IdentificationType DocumentIdentification { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CommonTypes-4.0", Order = 1)]
        public FilingStatusType FilingStatus { get; set; }
    }
}
