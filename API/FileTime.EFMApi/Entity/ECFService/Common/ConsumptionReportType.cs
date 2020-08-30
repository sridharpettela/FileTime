namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class ConsumptionReportType
    {

        private IDType idField;

        private ConsumptionTypeType consumptionTypeField;

        private ConsumptionTypeCodeType consumptionTypeCodeField;

        private DescriptionType[] descriptionField;

        private TotalConsumedQuantityType totalConsumedQuantityField;

        private BasicConsumedQuantityType basicConsumedQuantityField;

        private ResidentOccupantsNumericType residentOccupantsNumericField;

        private ConsumersEnergyLevelCodeType consumersEnergyLevelCodeField;

        private ConsumersEnergyLevelType consumersEnergyLevelField;

        private ResidenceTypeType residenceTypeField;

        private ResidenceTypeCodeType residenceTypeCodeField;

        private HeatingTypeType heatingTypeField;

        private HeatingTypeCodeType heatingTypeCodeField;

        private PeriodType periodField;

        private DocumentReferenceType guidanceDocumentReferenceField;

        private DocumentReferenceType documentReferenceField;

        private ConsumptionReportReferenceType[] consumptionReportReferenceField;

        private ConsumptionHistoryType[] consumptionHistoryField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public IDType ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public ConsumptionTypeType ConsumptionType
        {
            get
            {
                return this.consumptionTypeField;
            }
            set
            {
                this.consumptionTypeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public ConsumptionTypeCodeType ConsumptionTypeCode
        {
            get
            {
                return this.consumptionTypeCodeField;
            }
            set
            {
                this.consumptionTypeCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public DescriptionType[] Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
        public TotalConsumedQuantityType TotalConsumedQuantity
        {
            get
            {
                return this.totalConsumedQuantityField;
            }
            set
            {
                this.totalConsumedQuantityField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 5)]
        public BasicConsumedQuantityType BasicConsumedQuantity
        {
            get
            {
                return this.basicConsumedQuantityField;
            }
            set
            {
                this.basicConsumedQuantityField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 6)]
        public ResidentOccupantsNumericType ResidentOccupantsNumeric
        {
            get
            {
                return this.residentOccupantsNumericField;
            }
            set
            {
                this.residentOccupantsNumericField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 7)]
        public ConsumersEnergyLevelCodeType ConsumersEnergyLevelCode
        {
            get
            {
                return this.consumersEnergyLevelCodeField;
            }
            set
            {
                this.consumersEnergyLevelCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 8)]
        public ConsumersEnergyLevelType ConsumersEnergyLevel
        {
            get
            {
                return this.consumersEnergyLevelField;
            }
            set
            {
                this.consumersEnergyLevelField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 9)]
        public ResidenceTypeType ResidenceType
        {
            get
            {
                return this.residenceTypeField;
            }
            set
            {
                this.residenceTypeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 10)]
        public ResidenceTypeCodeType ResidenceTypeCode
        {
            get
            {
                return this.residenceTypeCodeField;
            }
            set
            {
                this.residenceTypeCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 11)]
        public HeatingTypeType HeatingType
        {
            get
            {
                return this.heatingTypeField;
            }
            set
            {
                this.heatingTypeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 12)]
        public HeatingTypeCodeType HeatingTypeCode
        {
            get
            {
                return this.heatingTypeCodeField;
            }
            set
            {
                this.heatingTypeCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
        public PeriodType Period
        {
            get
            {
                return this.periodField;
            }
            set
            {
                this.periodField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
        public DocumentReferenceType GuidanceDocumentReference
        {
            get
            {
                return this.guidanceDocumentReferenceField;
            }
            set
            {
                this.guidanceDocumentReferenceField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 15)]
        public DocumentReferenceType DocumentReference
        {
            get
            {
                return this.documentReferenceField;
            }
            set
            {
                this.documentReferenceField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ConsumptionReportReference", Order = 16)]
        public ConsumptionReportReferenceType[] ConsumptionReportReference
        {
            get
            {
                return this.consumptionReportReferenceField;
            }
            set
            {
                this.consumptionReportReferenceField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ConsumptionHistory", Order = 17)]
        public ConsumptionHistoryType[] ConsumptionHistory
        {
            get
            {
                return this.consumptionHistoryField;
            }
            set
            {
                this.consumptionHistoryField = value;
                
            }
        }

        

        
    }
}