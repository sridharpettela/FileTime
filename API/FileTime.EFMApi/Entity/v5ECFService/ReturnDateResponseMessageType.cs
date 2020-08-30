using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTime.EFMApi.Entity.v5ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:tyler:ecf:v5.0:extensions:returndateresponse")]
    public partial class ReturnDateResponseMessageType : ResponseMessageType
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://release.niem.gov/niem/niem-core/4.0/", IsNullable = true, Order = 0)]
        public CaseType Case { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Namespace = "urn:ietf:params:xml:ns:icalendar-2.0", Order = 1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("vcalendar", IsNullable = false)]
        public VcalendarType[] icalendar { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public DateType ReturnDate { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ReturnDateResponseMessageAugmentation", Order = 3)]
        public object[] ReturnDateResponseMessageAugmentationPoint { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://docs.oasis-open.org/legalxml-courtfiling/ns/v5.0/MessageWrappers")]
    [System.Xml.Serialization.XmlRoot("ReturnDateResponse", Namespace = "https://docs.oasis-open.org/legalxml-courtfiling/ns/v5.0/MessageWrappers")]
    public partial class ReturnDateResponse
    {
        [System.Xml.Serialization.XmlElementAttribute("ReturnDateResponseMessage", Namespace = "urn:tyler:ecf:v5.0:extensions:returndateresponse", Order = 0)]
        public ReturnDateResponseMessageType ReturnDateResponseMessageType { get; set; }
    }
}
