namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class EconomicOperatorShortListType
    {

        private LimitationDescriptionType[] limitationDescriptionField;

        private ExpectedQuantityType expectedQuantityField;

        private MaximumQuantityType maximumQuantityField;

        private MinimumQuantityType minimumQuantityField;

        private PartyType[] preSelectedPartyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LimitationDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public LimitationDescriptionType[] LimitationDescription
        {
            get
            {
                return this.limitationDescriptionField;
            }
            set
            {
                this.limitationDescriptionField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public ExpectedQuantityType ExpectedQuantity
        {
            get
            {
                return this.expectedQuantityField;
            }
            set
            {
                this.expectedQuantityField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public MaximumQuantityType MaximumQuantity
        {
            get
            {
                return this.maximumQuantityField;
            }
            set
            {
                this.maximumQuantityField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public MinimumQuantityType MinimumQuantity
        {
            get
            {
                return this.minimumQuantityField;
            }
            set
            {
                this.minimumQuantityField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PreSelectedParty", Order = 4)]
        public PartyType[] PreSelectedParty
        {
            get
            {
                return this.preSelectedPartyField;
            }
            set
            {
                this.preSelectedPartyField = value;
                
            }
        }

        

    }
}