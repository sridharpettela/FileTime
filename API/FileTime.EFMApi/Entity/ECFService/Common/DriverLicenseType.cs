namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public partial class DriverLicenseType : DriverLicenseBaseType
    {

        private DriverLicenseClassCodeType itemField;

        private DriverLicenseWithdrawalType driverLicenseWithdrawalField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DriverLicenseCommercialClassCode",  Order = 0)]
        public DriverLicenseClassCodeType Item
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
        public DriverLicenseWithdrawalType DriverLicenseWithdrawal
        {
            get
            {
                return this.driverLicenseWithdrawalField;
            }
            set
            {
                this.driverLicenseWithdrawalField = value;
                
            }
        }
    }
}