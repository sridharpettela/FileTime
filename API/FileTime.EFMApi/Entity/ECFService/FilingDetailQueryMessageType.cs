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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:tyler:ecf:extensions:FilingDetailQueryMessage")]
    [System.Xml.Serialization.XmlRoot("FilingDetailQueryMessage", Namespace = "urn:tyler:ecf:extensions:FilingDetailQueryMessage")]
    public class FilingDetailQueryMessageType : QueryMessageType
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:tyler:ecf:extensions:FilingDetailResponseMessage")]
    [System.Xml.Serialization.XmlRoot("FilingDetailResponseMessage", Namespace = "urn:tyler:ecf:extensions:FilingDetailResponseMessage")]
    public class FilingDetailResponseMessageType : QueryResponseMessageType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public DateType FilingSubmissionDate { get; set; }

        /// <remarks/>
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:tyler:ecf:extensions:Common", Order = 2)]
        public ProcedureRemedyType ProcedureRemedy { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 3)]
        [System.Xml.Serialization.XmlArrayItemAttribute("AllowanceCharge", typeof(AllowanceChargeType), Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
        public AllowanceChargeType[] EnvelopeFees { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:tyler:ecf:extensions:Common", Order = 4)]
        public PaymentType1 Payment { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DocumentIdentification", Namespace = "http://niem.gov/niem/niem-core/2.0", Order = 5)]
        public IdentificationType[] DocumentIdentification { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("DocumentSubmitter", Namespace = "http://niem.gov/niem/niem-core/2.0", Order = 6)]
        public EntityType1 DocumentSubmitter { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CommonTypes-4.0", Order = 7)]
        public FilingStatusType FilingStatus { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order = 8, ElementName = "FilingAcceptDate")]
        public DateType FilingAcceptDate { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0", IsNullable = true, Order = 9, ElementName = "DocumentPostDate")]
        public DateType DocumentPostDate { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ServiceRecipientDetail", Order = 10)]
        public ServiceRecipientDetailType[] ServiceRecipientDetail { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 11)]
        [System.Xml.Serialization.XmlArrayItemAttribute("AllowanceCharge", typeof(AllowanceChargeType), Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
        public AllowanceChargeType[] FilingFees { get; set; }

        [XmlElementAttribute("FilingLeadDocument", Namespace = "urn:tyler:ecf:extensions:Common", Order = 12)]
        public ExtendedDocumentType[] FilingLeadDocument { get; set; }
    }
}
