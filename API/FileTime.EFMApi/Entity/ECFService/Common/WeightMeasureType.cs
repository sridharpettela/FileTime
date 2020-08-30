namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public partial class WeightMeasureType : MeasureType3
    {

        private MassCodeType weightUnitCodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 0)]
        public MassCodeType WeightUnitCode
        {
            get
            {
                return this.weightUnitCodeField;
            }
            set
            {
                this.weightUnitCodeField = value;
                
            }
        }
    }
}