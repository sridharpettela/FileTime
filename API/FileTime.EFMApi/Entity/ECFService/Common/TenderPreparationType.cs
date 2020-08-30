namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class TenderPreparationType
    {

        private TenderEnvelopeIDType tenderEnvelopeIDField;

        private TenderEnvelopeTypeCodeType tenderEnvelopeTypeCodeField;

        private DescriptionType[] descriptionField;

        private OpenTenderIDType openTenderIDField;

        private ProcurementProjectLotIDType[] procurementProjectLotIDField;

        private TenderRequirementType[] documentTenderRequirementField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public TenderEnvelopeIDType TenderEnvelopeID
        {
            get
            {
                return this.tenderEnvelopeIDField;
            }
            set
            {
                this.tenderEnvelopeIDField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public TenderEnvelopeTypeCodeType TenderEnvelopeTypeCode
        {
            get
            {
                return this.tenderEnvelopeTypeCodeField;
            }
            set
            {
                this.tenderEnvelopeTypeCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public OpenTenderIDType OpenTenderID
        {
            get
            {
                return this.openTenderIDField;
            }
            set
            {
                this.openTenderIDField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProcurementProjectLotID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
        public ProcurementProjectLotIDType[] ProcurementProjectLotID
        {
            get
            {
                return this.procurementProjectLotIDField;
            }
            set
            {
                this.procurementProjectLotIDField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DocumentTenderRequirement", Order = 5)]
        public TenderRequirementType[] DocumentTenderRequirement
        {
            get
            {
                return this.documentTenderRequirementField;
            }
            set
            {
                this.documentTenderRequirementField = value;
                
            }
        }

       
    }
}