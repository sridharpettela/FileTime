using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SecureCaseMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FilingServiceQueryMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CancelFilingMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FilingDetailQueryMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ServiceAttachCaseListQueryMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ServiceInformationHistoryQueryMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ServiceInformationQueryMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FilingStatusQueryMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FilingListQueryMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FeesCalculationQueryMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DocumentQueryMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CaseQueryMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CaseListQueryMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CourtPolicyQueryMessageType1))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CommonTypes-4.0")]
    public partial class QueryMessageType : ComplexObjectType
    {

        private IdentificationType sendingMDELocationIDField;

        private string sendingMDEProfileCodeField;

        private EntityType querySubmitterField;

        private CourtType caseCourtField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public IdentificationType SendingMDELocationID
        {
            get
            {
                return this.sendingMDELocationIDField;
            }
            set
            {
                this.sendingMDELocationIDField = value;

            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString", Order = 1)]
        public string SendingMDEProfileCode
        {
            get
            {
                return this.sendingMDEProfileCodeField;
            }
            set
            {
                this.sendingMDEProfileCodeField = value;

            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public EntityType QuerySubmitter
        {
            get
            {
                return this.querySubmitterField;
            }
            set
            {
                this.querySubmitterField = value;

            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://niem.gov/niem/domains/jxdm/4.0", IsNullable = true, Order = 3)]
        public CourtType CaseCourt
        {
            get
            {
                return this.caseCourtField;
            }
            set
            {
                this.caseCourtField = value;

            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FilingServiceResponseMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CancelFilingResponseMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FilingDetailResponseMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ServiceAttachCaseListResponseMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ServiceInformationHistoryResponseMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ServiceInformationResponseMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FilingStatusResponseMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FilingListResponseMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DocumentResponseMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CaseResponseMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CaseListResponseMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FeesCalculationResponseMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CourtPolicyResponseMessageType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CommonTypes-4.0")]
    public partial class QueryResponseMessageType : ComplexObjectType
    {

        private IdentificationType sendingMDELocationIDField;

        private string sendingMDEProfileCodeField;

        private CourtType caseCourtField;

        private ErrorType[] errorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public IdentificationType SendingMDELocationID
        {
            get
            {
                return this.sendingMDELocationIDField;
            }
            set
            {
                this.sendingMDELocationIDField = value;

            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "normalizedString", Order = 1)]
        public string SendingMDEProfileCode
        {
            get
            {
                return this.sendingMDEProfileCodeField;
            }
            set
            {
                this.sendingMDEProfileCodeField = value;

            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://niem.gov/niem/domains/jxdm/4.0", Order = 2)]
        public CourtType CaseCourt
        {
            get
            {
                return this.caseCourtField;
            }
            set
            {
                this.caseCourtField = value;

            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Error", Order = 3)]
        public ErrorType[] Error
        {
            get
            {
                return this.errorField;
            }
            set
            {
                this.errorField = value;

            }
        }
    }
}
