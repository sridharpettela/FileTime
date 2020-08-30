using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FileTime.EFMApi.Entity.v5ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:tyler:ecf:v5.0:extensions:reservedateresponse")]
    [XmlRootAttribute("ReserveDateResponseMessage", Namespace = "urn:tyler:ecf:v5.0:extensions:reservedateresponse", IsNullable = false)]
    public partial class ReserveDateResponseMessageType : ResponseMessageType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://release.niem.gov/niem/niem-core/4.0/", IsNullable = true, Order = 0)]
        public CaseType Case { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Namespace = "urn:ietf:params:xml:ns:icalendar-2.0", Order = 1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("vcalendar", IsNullable = false)]
        public VcalendarType[] icalendar { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ReserveDateResponseMessageAugmentationPoint", Order = 2)]
        public object[] ReserveDateResponseMessageAugmentationPoint { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://docs.oasis-open.org/legalxml-courtfiling/ns/v5.0/MessageWrappers")]
    [System.Xml.Serialization.XmlRoot("ReserveCourtDateSyncResponse", Namespace = "https://docs.oasis-open.org/legalxml-courtfiling/ns/v5.0/MessageWrappers")]
    public partial class ReserveCourtDateSyncResponseType
    {
        [System.Xml.Serialization.XmlElementAttribute("ReserveDateResponseMessage", Namespace = "urn:tyler:ecf:v5.0:extensions:reservedateresponse", Order = 0)]
        public ReserveDateResponseMessageType ReserveDateResponseMessageType { get; set; }
    }
}
