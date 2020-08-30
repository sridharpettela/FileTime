namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:JuvenileCase-4.0")]
    public partial class DelinquentActType : IncidentType
    {

        private StatuteType delinquentActStatuteField;

        private TextType delinquentActSeverityCodeField;

        private TextType delinquentActDegreeCodeField;

        private TextType delinquentActApplicabilityCodeField;

        private TextType delinquentActSpecialAllegationCodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public StatuteType DelinquentActStatute
        {
            get
            {
                return this.delinquentActStatuteField;
            }
            set
            {
                this.delinquentActStatuteField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public TextType DelinquentActSeverityCode
        {
            get
            {
                return this.delinquentActSeverityCodeField;
            }
            set
            {
                this.delinquentActSeverityCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public TextType DelinquentActDegreeCode
        {
            get
            {
                return this.delinquentActDegreeCodeField;
            }
            set
            {
                this.delinquentActDegreeCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public TextType DelinquentActApplicabilityCode
        {
            get
            {
                return this.delinquentActApplicabilityCodeField;
            }
            set
            {
                this.delinquentActApplicabilityCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public TextType DelinquentActSpecialAllegationCode
        {
            get
            {
                return this.delinquentActSpecialAllegationCodeField;
            }
            set
            {
                this.delinquentActSpecialAllegationCodeField = value;
                
            }
        }
    }
}