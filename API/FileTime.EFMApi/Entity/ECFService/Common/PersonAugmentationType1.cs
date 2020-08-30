namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "PersonAugmentationType", Namespace = "http://niem.gov/niem/domains/jxdm/4.0")]
    public partial class PersonAugmentationType1 : AugmentationType
    {

        private IdentificationType personAFISIdentificationField;

        private IdentificationType personFBIIdentificationField;

        private BiometricType personPalmPrintField;

        private IdentificationType personStateFingerprintIdentificationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 0)]
        public IdentificationType PersonAFISIdentification
        {
            get
            {
                return this.personAFISIdentificationField;
            }
            set
            {
                this.personAFISIdentificationField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 1)]
        public IdentificationType PersonFBIIdentification
        {
            get
            {
                return this.personFBIIdentificationField;
            }
            set
            {
                this.personFBIIdentificationField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 2)]
        public BiometricType PersonPalmPrint
        {
            get
            {
                return this.personPalmPrintField;
            }
            set
            {
                this.personPalmPrintField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 3)]
        public IdentificationType PersonStateFingerprintIdentification
        {
            get
            {
                return this.personStateFingerprintIdentificationField;
            }
            set
            {
                this.personStateFingerprintIdentificationField = value;
                
            }
        }
    }
}