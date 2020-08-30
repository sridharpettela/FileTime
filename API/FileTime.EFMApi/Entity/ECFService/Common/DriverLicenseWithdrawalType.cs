namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public partial class DriverLicenseWithdrawalType : ActivityType
    {

        private DateType driverLicenseWithdrawalEffectiveDateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 0)]
        public DateType DriverLicenseWithdrawalEffectiveDate
        {
            get
            {
                return this.driverLicenseWithdrawalEffectiveDateField;
            }
            set
            {
                this.driverLicenseWithdrawalEffectiveDateField = value;
                
            }
        }
    }
}