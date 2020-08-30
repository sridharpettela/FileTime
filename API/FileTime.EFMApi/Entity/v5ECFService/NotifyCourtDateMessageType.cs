using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FileTime.EFMApi.Entity.v5ECFService
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "https://docs.oasis-open.org/legalxml-courtfiling/ns/v5.0/datecallback")]
    [XmlRootAttribute("NotifyCourtDateMessage", Namespace = "https://docs.oasis-open.org/legalxml-courtfiling/ns/v5.0/datecallback", IsNullable = false)]
    public partial class NotifyCourtDateMessageType : CaseFilingType
    {
        [XmlElementAttribute(Namespace = "http://release.niem.gov/niem/niem-core/4.0/", IsNullable = true, Order = 0)]
        public CaseType Case { get; set; }

        [XmlArrayAttribute(Namespace = "urn:ietf:params:xml:ns:icalendar-2.0", Order = 1)]
        [XmlArrayItemAttribute("vcalendar", IsNullable = false)]
        public VcalendarType[] icalendar { get; set; }

        [XmlElementAttribute("NotifyCourtDateMessageAugmentationPoint", Order = 2)]
        public object[] NotifyCourtDateMessageAugmentationPoint { get; set; }
    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://docs.oasis-open.org/legalxml-courtfiling/ns/v5.0/MessageWrappers")]
    [XmlRootAttribute("NotifyCourtDateRequest", Namespace = "https://docs.oasis-open.org/legalxml-courtfiling/ns/v5.0/MessageWrappers", IsNullable = false)]
    public partial class NotifyCourtDateRequestType : object
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "https://docs.oasis-open.org/legalxml-courtfiling/ns/v5.0/datecallback", Order = 0)]
        public NotifyCourtDateMessageType NotifyCourtDateMessage { get; set; }
    }

}
