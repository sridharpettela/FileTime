namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class TransportStatusType
    {

        private TimeDeviationIndicatorType timeDeviationIndicatorField;

        private ConditionDeviationIndicatorType conditionDeviationIndicatorField;

        private DeliveryType updatedDeliveryField;

        private DespatchType updatedDespatchField;

        private LocationType1 statusLocationField;

        private TransportHandlingUnitType[] referencedTransportHandlingUnitField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public TimeDeviationIndicatorType TimeDeviationIndicator
        {
            get
            {
                return this.timeDeviationIndicatorField;
            }
            set
            {
                this.timeDeviationIndicatorField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public ConditionDeviationIndicatorType ConditionDeviationIndicator
        {
            get
            {
                return this.conditionDeviationIndicatorField;
            }
            set
            {
                this.conditionDeviationIndicatorField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public DeliveryType UpdatedDelivery
        {
            get
            {
                return this.updatedDeliveryField;
            }
            set
            {
                this.updatedDeliveryField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public DespatchType UpdatedDespatch
        {
            get
            {
                return this.updatedDespatchField;
            }
            set
            {
                this.updatedDespatchField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public LocationType1 StatusLocation
        {
            get
            {
                return this.statusLocationField;
            }
            set
            {
                this.statusLocationField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ReferencedTransportHandlingUnit", Order = 5)]
        public TransportHandlingUnitType[] ReferencedTransportHandlingUnit
        {
            get
            {
                return this.referencedTransportHandlingUnitField;
            }
            set
            {
                this.referencedTransportHandlingUnitField = value;
                
            }
        }

        

    }
}