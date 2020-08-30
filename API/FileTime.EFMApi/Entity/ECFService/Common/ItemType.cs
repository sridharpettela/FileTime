namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TangibleItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConveyanceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VehicleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VehicleType1))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public partial class ItemType : ComplexObjectType
    {

        private TextType itemDescriptionTextField;

        private IdentificationType itemOtherIdentificationField;

        private ItemValueType itemValueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 0)]
        public TextType ItemDescriptionText
        {
            get
            {
                return this.itemDescriptionTextField;
            }
            set
            {
                this.itemDescriptionTextField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 1)]
        public IdentificationType ItemOtherIdentification
        {
            get
            {
                return this.itemOtherIdentificationField;
            }
            set
            {
                this.itemOtherIdentificationField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 2)]
        public ItemValueType ItemValue
        {
            get
            {
                return this.itemValueField;
            }
            set
            {
                this.itemValueField = value;
                
            }
        }
    }
}