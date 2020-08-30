namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class AwardingCriteriaResponseType
    {

        private IDType idField;

        private AwardingCriteriaIDType awardingCriteriaIDField;

        private AwardingCriteriaDescriptionType[] awardingCriteriaDescriptionField;

        private DescriptionType[] descriptionField;

        private QuantityType2 quantityField;

        private AmountType2 amountField;

        private AwardingCriteriaResponseType[] subordinateAwardingCriteriaResponseField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public IDType ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public AwardingCriteriaIDType AwardingCriteriaID
        {
            get
            {
                return this.awardingCriteriaIDField;
            }
            set
            {
                this.awardingCriteriaIDField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AwardingCriteriaDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public AwardingCriteriaDescriptionType[] AwardingCriteriaDescription
        {
            get
            {
                return this.awardingCriteriaDescriptionField;
            }
            set
            {
                this.awardingCriteriaDescriptionField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
        public QuantityType2 Quantity
        {
            get
            {
                return this.quantityField;
            }
            set
            {
                this.quantityField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 5)]
        public AmountType2 Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SubordinateAwardingCriteriaResponse", Order = 6)]
        public AwardingCriteriaResponseType[] SubordinateAwardingCriteriaResponse
        {
            get
            {
                return this.subordinateAwardingCriteriaResponseField;
            }
            set
            {
                this.subordinateAwardingCriteriaResponseField = value;
                
            }
        }

    }
}