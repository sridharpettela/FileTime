namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ParkingViolationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DrivingIncidentType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DrivingIncidentType1))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StatusOffenseActType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DelinquentActType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public partial class IncidentType : ActivityType
    {

        private LocationType2 incidentLocationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 0)]
        public LocationType2 IncidentLocation
        {
            get
            {
                return this.incidentLocationField;
            }
            set
            {
                this.incidentLocationField = value;
                
            }
        }
    }
}