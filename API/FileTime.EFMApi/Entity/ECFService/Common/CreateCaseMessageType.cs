namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:tyler:ecf:extensions:CreateCaseMessage")]
    public partial class CreateCaseMessageType : ElectronicFilingMessageType
    {

        private CaseType caseField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0",  Order = 0)]
        [System.Xml.Serialization.XmlElement("CivilCase", typeof(CivilCaseType),
            Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CivilCase-4.0",  Order = 0)]
        [System.Xml.Serialization.XmlElement("DomesticCase", typeof(DomesticCaseType),
            Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:DomesticCase-4.0",  Order = 0)]
        [System.Xml.Serialization.XmlElement("BankruptcyCase", typeof(BankruptcyCaseType),
            Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:BankruptcyCase-4.0",  Order = 0)]
        [System.Xml.Serialization.XmlElement("CitationCase", typeof(CitationCaseType),
            Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CitationCase-4.0",  Order = 0)]
        [System.Xml.Serialization.XmlElement("AppellateCase", typeof(AppellateCaseType),
            Namespace = "http://niem.gov/niem/domains/jxdm/4.0",  Order = 0)]
        [System.Xml.Serialization.XmlElement("AppellateCase", typeof(AppellateCaseType1),
            Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:AppellateCase-4.0",  Order = 0)]
        [System.Xml.Serialization.XmlElement("JuvenileCase", typeof(JuvenileCaseType),
            Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:JuvenileCase-4.0",  Order = 0)]
        [System.Xml.Serialization.XmlElement("CriminalCase", typeof(CriminalCaseType),
            Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CriminalCase-4.0",  Order = 0)]
        [System.Xml.Serialization.XmlElement("CourtCase", typeof(CourtCaseType),
            Namespace = "urn:tyler:ecf:extensions:CourtCase",  Order = 0)]
        public CaseType Case
        {
            get
            {
                return this.caseField;
            }
            set
            {
                this.caseField = value;
                
            }
        }
    }
}