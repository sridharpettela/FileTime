namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConveyanceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VehicleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VehicleType1))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public partial class TangibleItemType : ItemType
    {

        private object itemField;

        private gYear itemModelYearDateField;

        private VSTCodeType item1Field;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ConveyanceColorPrimaryText", typeof(TextType),  Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("VehicleColorPrimaryCode", typeof(VCOCodeType),  Order = 0)]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 1)]
        public gYear ItemModelYearDate
        {
            get
            {
                return this.itemModelYearDateField;
            }
            set
            {
                this.itemModelYearDateField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("VehicleStyleCode",  Order = 2)]
        public VSTCodeType Item1
        {
            get
            {
                return this.item1Field;
            }
            set
            {
                this.item1Field = value;
                
            }
        }
    }
}