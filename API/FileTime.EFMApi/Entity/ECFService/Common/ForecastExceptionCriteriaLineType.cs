namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class ForecastExceptionCriteriaLineType
    {

        private ForecastPurposeCodeType forecastPurposeCodeField;

        private ForecastTypeCodeType forecastTypeCodeField;

        private ComparisonDataSourceCodeType comparisonDataSourceCodeField;

        private DataSourceCodeType dataSourceCodeField;

        private TimeDeltaDaysQuantityType timeDeltaDaysQuantityField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public ForecastPurposeCodeType ForecastPurposeCode
        {
            get
            {
                return this.forecastPurposeCodeField;
            }
            set
            {
                this.forecastPurposeCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public ComparisonDataSourceCodeType ComparisonDataSourceCode
        {
            get
            {
                return this.comparisonDataSourceCodeField;
            }
            set
            {
                this.comparisonDataSourceCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public DataSourceCodeType DataSourceCode
        {
            get
            {
                return this.dataSourceCodeField;
            }
            set
            {
                this.dataSourceCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
        public TimeDeltaDaysQuantityType TimeDeltaDaysQuantity
        {
            get
            {
                return this.timeDeltaDaysQuantityField;
            }
            set
            {
                this.timeDeltaDaysQuantityField = value;
                
            }
        }

        

       
    }
}