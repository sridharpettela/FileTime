namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:PaymentMessage-4.0")]
    public partial class PaymentMessageType
    {

        private string feeExceptionReasonCodeField;

        private string feeExceptionSupportingTextField;

        private string payerNameField;

        private AllowanceChargeType[] allowanceChargeField;

        private AddressType addressField;

        private PaymentType paymentField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string FeeExceptionReasonCode
        {
            get
            {
                return this.feeExceptionReasonCodeField;
            }
            set
            {
                this.feeExceptionReasonCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string FeeExceptionSupportingText
        {
            get
            {
                return this.feeExceptionSupportingTextField;
            }
            set
            {
                this.feeExceptionSupportingTextField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string PayerName
        {
            get
            {
                return this.payerNameField;
            }
            set
            {
                this.payerNameField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AllowanceCharge", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order = 3)]
        public AllowanceChargeType[] AllowanceCharge
        {
            get
            {
                return this.allowanceChargeField;
            }
            set
            {
                this.allowanceChargeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order = 4)]
        public AddressType Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order = 5)]
        public PaymentType Payment
        {
            get
            {
                return this.paymentField;
            }
            set
            {
                this.paymentField = value;
                
            }
        }

        

    }
}