namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class ForecastLineType
    {

        private IDType idField;

        private NoteType[] noteField;

        private FrozenDocumentIndicatorType frozenDocumentIndicatorField;

        private ForecastTypeCodeType forecastTypeCodeField;

        private PeriodType forecastPeriodField;

        private SalesItemType salesItemField;

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
        [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public NoteType[] Note
        {
            get
            {
                return this.noteField;
            }
            set
            {
                this.noteField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public FrozenDocumentIndicatorType FrozenDocumentIndicator
        {
            get
            {
                return this.frozenDocumentIndicatorField;
            }
            set
            {
                this.frozenDocumentIndicatorField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public ForecastTypeCodeType ForecastTypeCode
        {
            get
            {
                return this.forecastTypeCodeField;
            }
            set
            {
                this.forecastTypeCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public PeriodType ForecastPeriod
        {
            get
            {
                return this.forecastPeriodField;
            }
            set
            {
                this.forecastPeriodField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public SalesItemType SalesItem
        {
            get
            {
                return this.salesItemField;
            }
            set
            {
                this.salesItemField = value;
                
            }
        }

        

       
    }
}