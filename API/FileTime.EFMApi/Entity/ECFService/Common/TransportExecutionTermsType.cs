namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class TransportExecutionTermsType
    {

        private TransportUserSpecialTermsType[] transportUserSpecialTermsField;

        private TransportServiceProviderSpecialTermsType[] transportServiceProviderSpecialTermsField;

        private ChangeConditionsType[] changeConditionsField;

        private PaymentTermsType paymentTermsField;

        private DeliveryTermsType[] deliveryTermsField;

        private PaymentTermsType bonusPaymentTermsField;

        private PaymentTermsType commissionPaymentTermsField;

        private PaymentTermsType penaltyPaymentTermsField;

        private EnvironmentalEmissionType[] environmentalEmissionField;

        private NotificationRequirementType[] notificationRequirementField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TransportUserSpecialTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public TransportUserSpecialTermsType[] TransportUserSpecialTerms
        {
            get
            {
                return this.transportUserSpecialTermsField;
            }
            set
            {
                this.transportUserSpecialTermsField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TransportServiceProviderSpecialTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public TransportServiceProviderSpecialTermsType[] TransportServiceProviderSpecialTerms
        {
            get
            {
                return this.transportServiceProviderSpecialTermsField;
            }
            set
            {
                this.transportServiceProviderSpecialTermsField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ChangeConditions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public ChangeConditionsType[] ChangeConditions
        {
            get
            {
                return this.changeConditionsField;
            }
            set
            {
                this.changeConditionsField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public PaymentTermsType PaymentTerms
        {
            get
            {
                return this.paymentTermsField;
            }
            set
            {
                this.paymentTermsField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DeliveryTerms", Order = 4)]
        public DeliveryTermsType[] DeliveryTerms
        {
            get
            {
                return this.deliveryTermsField;
            }
            set
            {
                this.deliveryTermsField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public PaymentTermsType BonusPaymentTerms
        {
            get
            {
                return this.bonusPaymentTermsField;
            }
            set
            {
                this.bonusPaymentTermsField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public PaymentTermsType CommissionPaymentTerms
        {
            get
            {
                return this.commissionPaymentTermsField;
            }
            set
            {
                this.commissionPaymentTermsField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public PaymentTermsType PenaltyPaymentTerms
        {
            get
            {
                return this.penaltyPaymentTermsField;
            }
            set
            {
                this.penaltyPaymentTermsField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EnvironmentalEmission", Order = 8)]
        public EnvironmentalEmissionType[] EnvironmentalEmission
        {
            get
            {
                return this.environmentalEmissionField;
            }
            set
            {
                this.environmentalEmissionField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NotificationRequirement", Order = 9)]
        public NotificationRequirementType[] NotificationRequirement
        {
            get
            {
                return this.notificationRequirementField;
            }
            set
            {
                this.notificationRequirementField = value;
                
            }
        }

        
    }
}