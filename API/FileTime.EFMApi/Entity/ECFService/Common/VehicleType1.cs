namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "VehicleType", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CitationCase-4.0")]
    public partial class VehicleType1 : VehicleType
    {

        private InsuranceType1 vehicleOwnerInsuranceCoverageField;

        private InsuranceType1 vehicleOperatorInsuranceCoverageField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public InsuranceType1 VehicleOwnerInsuranceCoverage
        {
            get
            {
                return this.vehicleOwnerInsuranceCoverageField;
            }
            set
            {
                this.vehicleOwnerInsuranceCoverageField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public InsuranceType1 VehicleOperatorInsuranceCoverage
        {
            get
            {
                return this.vehicleOperatorInsuranceCoverageField;
            }
            set
            {
                this.vehicleOperatorInsuranceCoverageField = value;
                
            }
        }
    }
}