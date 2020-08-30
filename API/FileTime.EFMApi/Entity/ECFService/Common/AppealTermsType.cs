namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class AppealTermsType
    {

        private DescriptionType[] descriptionField;

        private PeriodType presentationPeriodField;

        private PartyType appealInformationPartyField;

        private PartyType appealReceiverPartyField;

        private PartyType mediationPartyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public DescriptionType[] Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public PeriodType PresentationPeriod
        {
            get
            {
                return this.presentationPeriodField;
            }
            set
            {
                this.presentationPeriodField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public PartyType AppealInformationParty
        {
            get
            {
                return this.appealInformationPartyField;
            }
            set
            {
                this.appealInformationPartyField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public PartyType AppealReceiverParty
        {
            get
            {
                return this.appealReceiverPartyField;
            }
            set
            {
                this.appealReceiverPartyField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public PartyType MediationParty
        {
            get
            {
                return this.mediationPartyField;
            }
            set
            {
                this.mediationPartyField = value;
                
            }
        }

        
    }
}