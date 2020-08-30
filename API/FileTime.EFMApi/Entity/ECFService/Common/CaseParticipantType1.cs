namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CaseListQueryMessage-4.0")]
    public partial class CaseParticipantType1 : ComplexObjectType
    {

        private ComplexObjectType itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FilingSubmissionSubmitterID", typeof(IdentificationType), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("CaseParticipant", typeof(CaseParticipantType), Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CommonTypes-4.0", Order = 0)]
        public ComplexObjectType Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
                
            }
        }
    }
}