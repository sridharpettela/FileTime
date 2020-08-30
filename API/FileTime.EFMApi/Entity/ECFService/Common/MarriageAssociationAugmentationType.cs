namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://niem.gov/niem/domains/screening/2.0")]
    public partial class MarriageAssociationAugmentationType : AugmentationType
    {

        private boolean[] divorceDecreeIndicatorField;

        private TextType[] marriageCityNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DivorceDecreeIndicator",  Order = 0)]
        public boolean[] DivorceDecreeIndicator
        {
            get
            {
                return this.divorceDecreeIndicatorField;
            }
            set
            {
                this.divorceDecreeIndicatorField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MarriageCityName",  Order = 1)]
        public TextType[] MarriageCityName
        {
            get
            {
                return this.marriageCityNameField;
            }
            set
            {
                this.marriageCityNameField = value;
                
            }
        }
    }
}