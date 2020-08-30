namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class EventTacticEnumerationType
    {

        private ConsumerIncentiveTacticTypeCodeType consumerIncentiveTacticTypeCodeField;

        private DisplayTacticTypeCodeType displayTacticTypeCodeField;

        private FeatureTacticTypeCodeType featureTacticTypeCodeField;

        private TradeItemPackingLabelingTypeCodeType tradeItemPackingLabelingTypeCodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public ConsumerIncentiveTacticTypeCodeType ConsumerIncentiveTacticTypeCode
        {
            get
            {
                return this.consumerIncentiveTacticTypeCodeField;
            }
            set
            {
                this.consumerIncentiveTacticTypeCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public DisplayTacticTypeCodeType DisplayTacticTypeCode
        {
            get
            {
                return this.displayTacticTypeCodeField;
            }
            set
            {
                this.displayTacticTypeCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public FeatureTacticTypeCodeType FeatureTacticTypeCode
        {
            get
            {
                return this.featureTacticTypeCodeField;
            }
            set
            {
                this.featureTacticTypeCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public TradeItemPackingLabelingTypeCodeType TradeItemPackingLabelingTypeCode
        {
            get
            {
                return this.tradeItemPackingLabelingTypeCodeField;
            }
            set
            {
                this.tradeItemPackingLabelingTypeCodeField = value;
                
            }
        }

        

        
    }
}