namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WeightMeasureType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SpeedMeasureType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LengthMeasureType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "MeasureType", Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public partial class MeasureType3 : ComplexObjectType
    {

        private TextType itemField;

        private TextType measureUnitTextField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MeasureText",  Order = 0)]
        public TextType Item
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
        public TextType MeasureUnitText
        {
            get
            {
                return this.measureUnitTextField;
            }
            set
            {
                this.measureUnitTextField = value;
                
            }
        }
    }
}