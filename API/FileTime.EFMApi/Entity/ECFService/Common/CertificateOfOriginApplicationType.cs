namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class CertificateOfOriginApplicationType
    {

        private ReferenceIDType referenceIDField;

        private CertificateTypeType certificateTypeField;

        private ApplicationStatusCodeType applicationStatusCodeField;

        private OriginalJobIDType originalJobIDField;

        private PreviousJobIDType previousJobIDField;

        private RemarksType remarksField;

        private ShipmentType shipmentField;

        private EndorserPartyType[] endorserPartyField;

        private PartyType preparationPartyField;

        private PartyType issuerPartyField;

        private PartyType exporterPartyField;

        private PartyType importerPartyField;

        private CountryType issuingCountryField;

        private DocumentDistributionType[] documentDistributionField;

        private DocumentReferenceType[] supportingDocumentReferenceField;

        private SignatureType2[] signatureField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public ReferenceIDType ReferenceID
        {
            get
            {
                return this.referenceIDField;
            }
            set
            {
                this.referenceIDField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public CertificateTypeType CertificateType
        {
            get
            {
                return this.certificateTypeField;
            }
            set
            {
                this.certificateTypeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public ApplicationStatusCodeType ApplicationStatusCode
        {
            get
            {
                return this.applicationStatusCodeField;
            }
            set
            {
                this.applicationStatusCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public OriginalJobIDType OriginalJobID
        {
            get
            {
                return this.originalJobIDField;
            }
            set
            {
                this.originalJobIDField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
        public PreviousJobIDType PreviousJobID
        {
            get
            {
                return this.previousJobIDField;
            }
            set
            {
                this.previousJobIDField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 5)]
        public RemarksType Remarks
        {
            get
            {
                return this.remarksField;
            }
            set
            {
                this.remarksField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public ShipmentType Shipment
        {
            get
            {
                return this.shipmentField;
            }
            set
            {
                this.shipmentField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EndorserParty", Order = 7)]
        public EndorserPartyType[] EndorserParty
        {
            get
            {
                return this.endorserPartyField;
            }
            set
            {
                this.endorserPartyField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public PartyType PreparationParty
        {
            get
            {
                return this.preparationPartyField;
            }
            set
            {
                this.preparationPartyField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public PartyType IssuerParty
        {
            get
            {
                return this.issuerPartyField;
            }
            set
            {
                this.issuerPartyField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public PartyType ExporterParty
        {
            get
            {
                return this.exporterPartyField;
            }
            set
            {
                this.exporterPartyField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public PartyType ImporterParty
        {
            get
            {
                return this.importerPartyField;
            }
            set
            {
                this.importerPartyField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public CountryType IssuingCountry
        {
            get
            {
                return this.issuingCountryField;
            }
            set
            {
                this.issuingCountryField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DocumentDistribution", Order = 13)]
        public DocumentDistributionType[] DocumentDistribution
        {
            get
            {
                return this.documentDistributionField;
            }
            set
            {
                this.documentDistributionField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SupportingDocumentReference", Order = 14)]
        public DocumentReferenceType[] SupportingDocumentReference
        {
            get
            {
                return this.supportingDocumentReferenceField;
            }
            set
            {
                this.supportingDocumentReferenceField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Signature", Order = 15)]
        public SignatureType2[] Signature
        {
            get
            {
                return this.signatureField;
            }
            set
            {
                this.signatureField = value;
                
            }
        }

        
    }
}