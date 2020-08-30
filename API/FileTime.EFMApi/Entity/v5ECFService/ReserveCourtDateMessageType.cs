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
    [XmlTypeAttribute(Namespace = "https://docs.oasis-open.org/legalxml-courtfiling/ns/v5.0/reservedate")]
    [XmlRootAttribute("ReserveCourtDateMessage", Namespace = "https://docs.oasis-open.org/legalxml-courtfiling/ns/v5.0/reservedate")]
    public partial class ReserveCourtDateMessageType : CaseFilingType
    {
        [XmlElementAttribute(Namespace = "https://docs.oasis-open.org/legalxml-courtfiling/ns/v5.0/ecf", Order = 0)]
        public TextType CaseParticipantRoleCode { get; set; }

        [XmlElementAttribute(Namespace = "http://release.niem.gov/niem/niem-core/4.0/", Order = 1)]
        public CaseType Case { get; set; }

        [XmlElementAttribute(Order = 2)]
        public duration EstimatedDuration { get; set; }

        [XmlElementAttribute("PotentialStartTimeRange", Order = 3)]
        public DateRangeType[] PotentialStartTimeRange { get; set; }

        [XmlElementAttribute("ReserveCourtDateMessageAugmentationPoint", Order = 4)]
        public object[] ReserveCourtDateMessageAugmentationPoint { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://docs.oasis-open.org/legalxml-courtfiling/ns/v5.0/MessageWrappers")]
    [XmlRootAttribute("ReserveCourtDateRequest", Namespace = "https://docs.oasis-open.org/legalxml-courtfiling/ns/v5.0/MessageWrappers")]
    public partial class ReserveCourtDateRequestType : object
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "https://docs.oasis-open.org/legalxml-courtfiling/ns/v5.0/reservedate", Order = 0)]
        public ReserveCourtDateMessageType ReserveCourtDateMessage { get; set; }
    }

}
