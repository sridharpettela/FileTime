namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:AppellateCase-4.0")]
    public partial class AppellateCivilCaseType : ComplexObjectType
    {

        private boolean feesWaivedIndicatorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public boolean FeesWaivedIndicator
        {
            get
            {
                return this.feesWaivedIndicatorField;
            }
            set
            {
                this.feesWaivedIndicatorField = value;
                
            }
        }
    }
}