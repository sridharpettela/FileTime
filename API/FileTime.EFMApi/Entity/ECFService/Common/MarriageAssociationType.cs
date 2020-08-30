namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:DomesticCase-4.0")]
    public partial class MarriageAssociationType : PersonUnionAssociationType
    {

        private MarriageAssociationAugmentationType marriageAssociationAugmentationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://niem.gov/niem/domains/screening/2.0", Order = 0)]
        public MarriageAssociationAugmentationType MarriageAssociationAugmentation
        {
            get
            {
                return this.marriageAssociationAugmentationField;
            }
            set
            {
                this.marriageAssociationAugmentationField = value;
                
            }
        }
    }
}