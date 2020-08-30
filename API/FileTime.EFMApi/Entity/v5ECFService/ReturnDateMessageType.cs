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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://docs.oasis-open.org/legalxml-courtfiling/ns/v5.0/MessageWrappers")]
    [XmlRootAttribute("ReturnDateRequest", Namespace = "https://docs.oasis-open.org/legalxml-courtfiling/ns/v5.0/MessageWrappers", IsNullable = false)]
    public partial class ReturnDateRequestType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:tyler:ecf:v5.0:extensions:returndate", Order = 0)]
        public ReturnDateMessageType ReturnDateMessage { get; set; }
    }


    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:tyler:ecf:v5.0:extensions:returndate")]
    [XmlRootAttribute("ReturnDateMessage", Namespace = "urn:tyler:ecf:v5.0:extensions:returndate", IsNullable = false)]
    public partial class ReturnDateMessageType : CaseFilingType
    {

        [XmlElementAttribute(Namespace = "https://docs.oasis-open.org/legalxml-courtfiling/ns/v5.0/ecf", Order = 0)]
        public TextType CaseParticipantRoleCode { get; set; }

        [XmlElementAttribute(Namespace = "http://release.niem.gov/niem/niem-core/4.0/", IsNullable = true, Order = 1)]
        public CaseType Case { get; set; }

        [XmlElementAttribute(Order = 2)]
        public DateType ReturnDate { get; set; }

        [XmlElementAttribute(Namespace = "urn:tyler:ecf:v5.0:extensions:common", Order = 3)]
        public boolean OutOfStateIndicator { get; set; }


        [XmlElementAttribute("ReturnDateMessageAugmentation", Order = 4)]
        public object[] ReturnDateMessageAugmentationPoint { get; set; }
    }
}
