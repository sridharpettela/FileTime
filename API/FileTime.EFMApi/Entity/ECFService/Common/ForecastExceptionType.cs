namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class ForecastExceptionType
    {

        private ForecastPurposeCodeType forecastPurposeCodeField;

        private ForecastTypeCodeType forecastTypeCodeField;

        private IssueDateType issueDateField;

        private IssueTimeType issueTimeField;

        private DataSourceCodeType dataSourceCodeField;

        private ComparisonDataCodeType comparisonDataCodeField;

        private ComparisonForecastIssueTimeType comparisonForecastIssueTimeField;

        private ComparisonForecastIssueDateType comparisonForecastIssueDateField;

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
        public IssueDateType IssueDate
        {
            get
            {
                return this.issueDateField;
            }
            set
            {
                this.issueDateField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public IssueTimeType IssueTime
        {
            get
            {
                return this.issueTimeField;
            }
            set
            {
                this.issueTimeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 5)]
        public ComparisonDataCodeType ComparisonDataCode
        {
            get
            {
                return this.comparisonDataCodeField;
            }
            set
            {
                this.comparisonDataCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 6)]
        public ComparisonForecastIssueTimeType ComparisonForecastIssueTime
        {
            get
            {
                return this.comparisonForecastIssueTimeField;
            }
            set
            {
                this.comparisonForecastIssueTimeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 7)]
        public ComparisonForecastIssueDateType ComparisonForecastIssueDate
        {
            get
            {
                return this.comparisonForecastIssueDateField;
            }
            set
            {
                this.comparisonForecastIssueDateField = value;
                
            }
        }

        

    }
}