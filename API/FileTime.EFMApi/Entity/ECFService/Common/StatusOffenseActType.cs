namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:JuvenileCase-4.0")]
    public partial class StatusOffenseActType : IncidentType
    {

        private StatuteType statusOffenseActStatuteField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public StatuteType StatusOffenseActStatute
        {
            get
            {
                return this.statusOffenseActStatuteField;
            }
            set
            {
                this.statusOffenseActStatuteField = value;
                
            }
        }
    }
}