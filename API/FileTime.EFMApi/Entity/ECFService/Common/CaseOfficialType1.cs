namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "CaseOfficialType", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CommonTypes-4.0")]
    public partial class CaseOfficialType1 : CaseOfficialType
    {

        private ReferenceType[] caseRepresentedPartyReferenceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CaseRepresentedPartyReference", Order = 0)]
        public ReferenceType[] CaseRepresentedPartyReference
        {
            get
            {
                return this.caseRepresentedPartyReferenceField;
            }
            set
            {
                this.caseRepresentedPartyReferenceField = value;
                
            }
        }
    }
}