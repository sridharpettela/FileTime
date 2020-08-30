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
    [XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CoreFilingMessage-4.0")]
    [XmlRoot("CoreFilingMessage", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CoreFilingMessage-4.0")]
    public class CoreFilingMessageType : ElectronicFilingMessageType
    {
        /// <remarks/>
        [XmlElement("Case",Namespace = "http://niem.gov/niem/niem-core/2.0", Order = 0)]
        [XmlElement("CivilCase", typeof(CivilCaseType),
         Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CivilCase-4.0", Order = 0)]
        [XmlElement("DomesticCase", typeof(DomesticCaseType),
          Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:DomesticCase-4.0", Order = 0)]
        [XmlElement("BankruptcyCase", typeof(BankruptcyCaseType),
         Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:BankruptcyCase-4.0", Order = 0)]
        [XmlElement("CitationCase", typeof(CitationCaseType),
         Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CitationCase-4.0", Order = 0)]
        [XmlElement("AppellateCase", typeof(AppellateCaseType),
         Namespace = "http://niem.gov/niem/domains/jxdm/4.0", Order = 0)]
        [XmlElement("AppellateCase", typeof(AppellateCaseType1),
         Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:AppellateCase-4.0", Order = 0)]
        [XmlElement("JuvenileCase", typeof(JuvenileCaseType),
         Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:JuvenileCase-4.0", Order = 0)]
        [XmlElement("CriminalCase", typeof(CriminalCaseType),
         Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CriminalCase-4.0", Order = 0)]
        [XmlElement("CourtCase", typeof(CourtCaseType),
        Namespace = "urn:tyler:ecf:extensions:CourtCase", Order = 0)]
        public CaseType Case { get; set; }

        [XmlElementAttribute(Order = 1)]
        public ProcedureRemedyType ProcedureRemedy { get; set; }

        [XmlElementAttribute(Order = 2)]
        public AmountType CivilClaimAmount { get; set; }

        [XmlElementAttribute(Order = 3)]
        public AmountType ProbateEstateAmount { get; set; }

        /// <remarks/>
        [XmlElementAttribute(Order = 4)]
        public boolean FilingConfidentialityIndicator { get; set; }

        /// <remarks/>
        [XmlElementAttribute("FilingLeadDocument", Namespace = "urn:tyler:ecf:extensions:Common", Order = 5)]
        public ExtendedDocumentType[] FilingLeadDocument { get; set; }

        /// <remarks/>
        [XmlElementAttribute("FilingConnectedDocument", Namespace = "urn:tyler:ecf:extensions:Common", Order = 6)]
        public ExtendedDocumentType[] FilingConnectedDocument { get; set; }
        
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "DocumentType", Namespace = "urn:tyler:ecf:extensions:Common")]
    public class ExtendedDocumentType : DocumentType1
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public TextType FilingCommentsText { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DocumentOptionalService", Order = 1)]
        public DocumentOptionalServiceType[] DocumentOptionalService { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public TextType CourtesyCopiesText { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public TextType PreliminaryCopiesText { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DocumentAttachmentIdentification", Order = 4)]
        public DocumentAttachmentIdentificationType[] DocumentAttachmentIdentification { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public FilingTypeType FilingAction { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FilingActionSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("RedactionIdentification", Order = 6)]
        public RedactionIdentificationType[] RedactionIdentification { get; set; }
    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:tyler:ecf:extensions:Common")]
    public class RedactionIdentificationType
    {
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public ReferenceType AttachmentReference { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public TextType RedactionID { get; set; }
    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:tyler:ecf:extensions:Common")]
    public class DocumentAttachmentIdentificationType 
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public ReferenceType DocumentAttachmentReference { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public @string DocumentID { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public @string CMSID { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:tyler:ecf:extensions:Common")]
    public enum FilingTypeType
    {

        /// <remarks/>
        EFile,

        /// <remarks/>
        EFileAndServe,

        /// <remarks/>
        Serve,
    }
}
