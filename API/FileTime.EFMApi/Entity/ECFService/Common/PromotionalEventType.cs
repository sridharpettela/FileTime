namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class PromotionalEventType
    {

        private PromotionalEventTypeCodeType promotionalEventTypeCodeField;

        private SubmissionDateType submissionDateField;

        private FirstShipmentAvailibilityDateType firstShipmentAvailibilityDateField;

        private LatestProposalAcceptanceDateType latestProposalAcceptanceDateField;

        private PromotionalSpecificationType[] promotionalSpecificationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public PromotionalEventTypeCodeType PromotionalEventTypeCode
        {
            get
            {
                return this.promotionalEventTypeCodeField;
            }
            set
            {
                this.promotionalEventTypeCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public SubmissionDateType SubmissionDate
        {
            get
            {
                return this.submissionDateField;
            }
            set
            {
                this.submissionDateField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public FirstShipmentAvailibilityDateType FirstShipmentAvailibilityDate
        {
            get
            {
                return this.firstShipmentAvailibilityDateField;
            }
            set
            {
                this.firstShipmentAvailibilityDateField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public LatestProposalAcceptanceDateType LatestProposalAcceptanceDate
        {
            get
            {
                return this.latestProposalAcceptanceDateField;
            }
            set
            {
                this.latestProposalAcceptanceDateField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PromotionalSpecification", Order = 4)]
        public PromotionalSpecificationType[] PromotionalSpecification
        {
            get
            {
                return this.promotionalSpecificationField;
            }
            set
            {
                this.promotionalSpecificationField = value;
                
            }
        }

        
    }
}