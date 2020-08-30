namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class TendererPartyQualificationType
    {

        private InterestedProcurementLotsIDType[] interestedProcurementLotsIDField;

        private QualifyingPartyType mainQualifyingPartyField;

        private QualifyingPartyType[] additionalQualifyingPartyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InterestedProcurementLotsID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public InterestedProcurementLotsIDType[] InterestedProcurementLotsID
        {
            get
            {
                return this.interestedProcurementLotsIDField;
            }
            set
            {
                this.interestedProcurementLotsIDField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public QualifyingPartyType MainQualifyingParty
        {
            get
            {
                return this.mainQualifyingPartyField;
            }
            set
            {
                this.mainQualifyingPartyField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AdditionalQualifyingParty", Order = 2)]
        public QualifyingPartyType[] AdditionalQualifyingParty
        {
            get
            {
                return this.additionalQualifyingPartyField;
            }
            set
            {
                this.additionalQualifyingPartyField = value;
                
            }
        }

      
    }
}