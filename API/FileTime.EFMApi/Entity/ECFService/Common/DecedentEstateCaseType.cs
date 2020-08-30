namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CivilCase-4.0")]
    public partial class DecedentEstateCaseType : ComplexObjectType
    {

        private PersonNameTextType personFullNameField;

        private DateType personDeathDateField;

        private DateType willFilingDateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0",  Order = 0)]
        public PersonNameTextType PersonFullName
        {
            get
            {
                return this.personFullNameField;
            }
            set
            {
                this.personFullNameField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0",  Order = 1)]
        public DateType PersonDeathDate
        {
            get
            {
                return this.personDeathDateField;
            }
            set
            {
                this.personDeathDateField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public DateType WillFilingDate
        {
            get
            {
                return this.willFilingDateField;
            }
            set
            {
                this.willFilingDateField = value;
                
            }
        }
    }
}