namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ChargeType", Namespace = "urn:tyler:ecf:extensions:Criminal")]
    public partial class ChargeType3 : ChargeType2
    {

        private boolean dateOnOrAboutIndicatorField;

        private boolean timeOnOrAboutIndicatorField;

        private StatuteType[] additionalStatuteField;

        private BondType bondField;

        private AmountType3 fineAmountField;

        private ChargeComponentType[] chargeComponentField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public boolean DateOnOrAboutIndicator
        {
            get
            {
                return this.dateOnOrAboutIndicatorField;
            }
            set
            {
                this.dateOnOrAboutIndicatorField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public boolean TimeOnOrAboutIndicator
        {
            get
            {
                return this.timeOnOrAboutIndicatorField;
            }
            set
            {
                this.timeOnOrAboutIndicatorField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AdditionalStatute", Order = 2)]
        public StatuteType[] AdditionalStatute
        {
            get
            {
                return this.additionalStatuteField;
            }
            set
            {
                this.additionalStatuteField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public BondType Bond
        {
            get
            {
                return this.bondField;
            }
            set
            {
                this.bondField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public AmountType3 FineAmount
        {
            get
            {
                return this.fineAmountField;
            }
            set
            {
                this.fineAmountField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ChargeComponent", Order = 5)]
        public ChargeComponentType[] ChargeComponent
        {
            get
            {
                return this.chargeComponentField;
            }
            set
            {
                this.chargeComponentField = value;
                
            }
        }
    }
}