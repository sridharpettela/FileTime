namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class ItemInstanceType
    {

        private ProductTraceIDType productTraceIDField;

        private ManufactureDateType manufactureDateField;

        private ManufactureTimeType manufactureTimeField;

        private BestBeforeDateType bestBeforeDateField;

        private RegistrationIDType registrationIDField;

        private SerialIDType serialIDField;

        private ItemPropertyType[] additionalItemPropertyField;

        private LotIdentificationType lotIdentificationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public ProductTraceIDType ProductTraceID
        {
            get
            {
                return this.productTraceIDField;
            }
            set
            {
                this.productTraceIDField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public ManufactureDateType ManufactureDate
        {
            get
            {
                return this.manufactureDateField;
            }
            set
            {
                this.manufactureDateField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public ManufactureTimeType ManufactureTime
        {
            get
            {
                return this.manufactureTimeField;
            }
            set
            {
                this.manufactureTimeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public BestBeforeDateType BestBeforeDate
        {
            get
            {
                return this.bestBeforeDateField;
            }
            set
            {
                this.bestBeforeDateField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
        public RegistrationIDType RegistrationID
        {
            get
            {
                return this.registrationIDField;
            }
            set
            {
                this.registrationIDField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 5)]
        public SerialIDType SerialID
        {
            get
            {
                return this.serialIDField;
            }
            set
            {
                this.serialIDField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AdditionalItemProperty", Order = 6)]
        public ItemPropertyType[] AdditionalItemProperty
        {
            get
            {
                return this.additionalItemPropertyField;
            }
            set
            {
                this.additionalItemPropertyField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public LotIdentificationType LotIdentification
        {
            get
            {
                return this.lotIdentificationField;
            }
            set
            {
                this.lotIdentificationField = value;
                
            }
        }

        

        
    }
}