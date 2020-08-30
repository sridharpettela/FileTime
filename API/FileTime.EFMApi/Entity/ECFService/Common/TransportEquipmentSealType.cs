namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class TransportEquipmentSealType
    {

        private IDType idField;

        private SealIssuerTypeCodeType sealIssuerTypeCodeField;

        private ConditionType conditionField;

        private SealStatusCodeType sealStatusCodeField;

        private SealingPartyTypeType sealingPartyTypeField;

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
        public SealIssuerTypeCodeType SealIssuerTypeCode
        {
            get
            {
                return this.sealIssuerTypeCodeField;
            }
            set
            {
                this.sealIssuerTypeCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public ConditionType Condition
        {
            get
            {
                return this.conditionField;
            }
            set
            {
                this.conditionField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public SealStatusCodeType SealStatusCode
        {
            get
            {
                return this.sealStatusCodeField;
            }
            set
            {
                this.sealStatusCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
        public SealingPartyTypeType SealingPartyType
        {
            get
            {
                return this.sealingPartyTypeField;
            }
            set
            {
                this.sealingPartyTypeField = value;
                
            }
        }

        
    }
}