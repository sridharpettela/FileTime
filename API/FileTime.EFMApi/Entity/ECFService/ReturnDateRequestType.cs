using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://docs.oasis-open.org/legalxml-courtfiling/ns/v5.0/MessageWrappers")]
    public class ReturnDateRequestType 
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:tyler:ecf:v5.0:extensions:returndate", Order = 0)]
        public ReturnDateMessageType ReturnDateMessage { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:tyler:ecf:v5.0:extensions:returndate")]
    public class ReturnDateMessageType : CaseFilingType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "https://docs.oasis-open.org/legalxml-courtfiling/ns/v5.0/ecf", Order = 0)]
        public TextType CaseParticipantRoleCode { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0", Order = 1)]
        [System.Xml.Serialization.XmlElement("CivilCase", typeof(CivilCaseType),
         Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CivilCase-4.0", Order = 1)]
        [System.Xml.Serialization.XmlElement("DomesticCase", typeof(DomesticCaseType),
           Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:DomesticCase-4.0", Order = 1)]
        [System.Xml.Serialization.XmlElement("BankruptcyCase", typeof(BankruptcyCaseType),
          Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:BankruptcyCase-4.0", Order = 1)]
        [System.Xml.Serialization.XmlElement("CitationCase", typeof(CitationCaseType),
          Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CitationCase-4.0", Order = 1)]
        [System.Xml.Serialization.XmlElement("AppellateCase", typeof(AppellateCaseType),
          Namespace = "http://niem.gov/niem/domains/jxdm/4.0", Order = 1)]
        [System.Xml.Serialization.XmlElement("AppellateCase", typeof(AppellateCaseType1),
          Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:AppellateCase-4.0", Order = 1)]
        [System.Xml.Serialization.XmlElement("JuvenileCase", typeof(JuvenileCaseType),
          Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:JuvenileCase-4.0", Order = 1)]
        [System.Xml.Serialization.XmlElement("CriminalCase", typeof(CriminalCaseType),
          Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CriminalCase-4.0", Order = 1)]
        [System.Xml.Serialization.XmlElement("CourtCase", typeof(CourtCaseType),
        Namespace = "urn:tyler:ecf:extensions:CourtCase", Order = 1)]
        public CaseType Case { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public DateType ReturnDate { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:tyler:ecf:v5.0:extensions:common", Order = 3)]
        public boolean OutOfStateIndicator { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ReturnDateMessageAugmentationPoint", Order = 4)]
        public object[] ReturnDateMessageAugmentationPoint { get; set; }
    }
}
