namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class TradingTermsType
    {

        private InformationType[] informationField;

        private ReferenceType1 referenceField;

        private AddressType applicableAddressField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Information", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public InformationType[] Information
        {
            get
            {
                return this.informationField;
            }
            set
            {
                this.informationField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public ReferenceType1 Reference
        {
            get
            {
                return this.referenceField;
            }
            set
            {
                this.referenceField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public AddressType ApplicableAddress
        {
            get
            {
                return this.applicableAddressField;
            }
            set
            {
                this.applicableAddressField = value;
                
            }
        }

        
    }
}