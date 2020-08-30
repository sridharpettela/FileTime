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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:tyler:ecf:extensions:ServiceAttachCaseListQueryMessage")]
    [XmlRoot(ElementName = "ServiceAttachCaseListQueryMessage", Namespace = "urn:tyler:ecf:extensions:ServiceAttachCaseListQueryMessage")]
    public partial class ServiceAttachCaseListQueryMessageType : QueryMessageType
    {
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:tyler:ecf:extensions:ServiceAttachCaseListQueryMessage", Order = 0)]
        public ServiceContactIdentificationType ServiceContactIdentification { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:tyler:ecf:extensions:ServiceAttachCaseListResponseMessage")]
    [XmlRoot(ElementName = "ServiceAttachCaseListResponseMessage", Namespace = "urn:tyler:ecf:extensions:ServiceAttachCaseListResponseMessage")]
    public partial class ServiceAttachCaseListResponseMessageType : QueryResponseMessageType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Case", Namespace = "http://niem.gov/niem/niem-core/2.0", Order = 0)]
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
        public CaseType[] Case { get; set; }
    }
}
