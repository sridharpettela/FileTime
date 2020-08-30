namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SubjectType3))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(JuvenileType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "SubjectType", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CommonTypes-4.0")]
    public partial class SubjectType2 : SubjectType
    {

        private PersonAugmentationType personAugmentationField;

        private IdentificationType subjectICEIdentificationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public PersonAugmentationType PersonAugmentation
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public IdentificationType SubjectICEIdentification
        {
            get
            {
                return this.subjectICEIdentificationField;
            }
            set
            {
                this.subjectICEIdentificationField = value;
                
            }
        }
    }
}