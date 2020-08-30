namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class CommodityClassificationType
    {

        private NatureCodeType natureCodeField;

        private CargoTypeCodeType cargoTypeCodeField;

        private CommodityCodeType commodityCodeField;

        private ItemClassificationCodeType itemClassificationCodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public NatureCodeType NatureCode
        {
            get
            {
                return this.natureCodeField;
            }
            set
            {
                this.natureCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public CargoTypeCodeType CargoTypeCode
        {
            get
            {
                return this.cargoTypeCodeField;
            }
            set
            {
                this.cargoTypeCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public CommodityCodeType CommodityCode
        {
            get
            {
                return this.commodityCodeField;
            }
            set
            {
                this.commodityCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public ItemClassificationCodeType ItemClassificationCode
        {
            get
            {
                return this.itemClassificationCodeField;
            }
            set
            {
                this.itemClassificationCodeField = value;
                
            }
        }

        
    }
}