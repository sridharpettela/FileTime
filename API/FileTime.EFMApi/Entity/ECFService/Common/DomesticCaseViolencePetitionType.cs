namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:DomesticCase-4.0")]
    public partial class DomesticCaseViolencePetitionType : ComplexObjectType
    {

        private TextType requestToVacateCodeField;

        private TextType requestToVacateTextField;

        private TextType stayawayDistanceTextField;

        private TextType noContactCodeField;

        private TextType custodyDescriptionTextField;

        private TextType childSupportTextField;

        private boolean respondentDangerAlertIndicatorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public TextType RequestToVacateCode
        {
            get
            {
                return this.requestToVacateCodeField;
            }
            set
            {
                this.requestToVacateCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public TextType RequestToVacateText
        {
            get
            {
                return this.requestToVacateTextField;
            }
            set
            {
                this.requestToVacateTextField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public TextType StayawayDistanceText
        {
            get
            {
                return this.stayawayDistanceTextField;
            }
            set
            {
                this.stayawayDistanceTextField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public TextType NoContactCode
        {
            get
            {
                return this.noContactCodeField;
            }
            set
            {
                this.noContactCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public TextType CustodyDescriptionText
        {
            get
            {
                return this.custodyDescriptionTextField;
            }
            set
            {
                this.custodyDescriptionTextField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public TextType ChildSupportText
        {
            get
            {
                return this.childSupportTextField;
            }
            set
            {
                this.childSupportTextField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public boolean RespondentDangerAlertIndicator
        {
            get
            {
                return this.respondentDangerAlertIndicatorField;
            }
            set
            {
                this.respondentDangerAlertIndicatorField = value;
                
            }
        }
    }
}