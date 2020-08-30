namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class TelecommunicationsSupplyType
    {

        private TelecommunicationsSupplyTypeType telecommunicationsSupplyType1Field;

        private TelecommunicationsSupplyTypeCodeType telecommunicationsSupplyTypeCodeField;

        private PrivacyCodeType privacyCodeField;

        private DescriptionType descriptionField;

        private TotalAmountType totalAmountField;

        private TelecommunicationsSupplyLineType[] telecommunicationsSupplyLineField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TelecommunicationsSupplyType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public TelecommunicationsSupplyTypeType TelecommunicationsSupplyType1
        {
            get
            {
                return this.telecommunicationsSupplyType1Field;
            }
            set
            {
                this.telecommunicationsSupplyType1Field = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public TelecommunicationsSupplyTypeCodeType TelecommunicationsSupplyTypeCode
        {
            get
            {
                return this.telecommunicationsSupplyTypeCodeField;
            }
            set
            {
                this.telecommunicationsSupplyTypeCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public PrivacyCodeType PrivacyCode
        {
            get
            {
                return this.privacyCodeField;
            }
            set
            {
                this.privacyCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public DescriptionType Description
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
        public TotalAmountType TotalAmount
        {
            get
            {
                return this.totalAmountField;
            }
            set
            {
                this.totalAmountField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TelecommunicationsSupplyLine", Order = 5)]
        public TelecommunicationsSupplyLineType[] TelecommunicationsSupplyLine
        {
            get
            {
                return this.telecommunicationsSupplyLineField;
            }
            set
            {
                this.telecommunicationsSupplyLineField = value;
                
            }
        }

       
    }
}