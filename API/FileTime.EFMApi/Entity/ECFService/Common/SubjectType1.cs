namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "SubjectType", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CriminalCase-4.0")]
    public partial class SubjectType1 : SubjectType
    {

        private PersonAugmentationType1 personAugmentationField;

        private PersonAugmentationType personAugmentation1Field;

        private boolean personInCustodyIndicatorField;

        private boolean warrantIssuedIndicatorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://niem.gov/niem/domains/jxdm/4.0", Order = 0)]
        public PersonAugmentationType1 PersonAugmentation
        {
            get
            {
                return this.personAugmentationField;
            }
            set
            {
                this.personAugmentationField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonAugmentation", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CommonTypes-4.0", Order = 1)]
        public PersonAugmentationType PersonAugmentation1
        {
            get
            {
                return this.personAugmentation1Field;
            }
            set
            {
                this.personAugmentation1Field = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public boolean PersonInCustodyIndicator
        {
            get
            {
                return this.personInCustodyIndicatorField;
            }
            set
            {
                this.personInCustodyIndicatorField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public boolean WarrantIssuedIndicator
        {
            get
            {
                return this.warrantIssuedIndicatorField;
            }
            set
            {
                this.warrantIssuedIndicatorField = value;
                
            }
        }
    }
}