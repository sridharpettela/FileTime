namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class QualificationResolutionType
    {

        private AdmissionCodeType admissionCodeField;

        private ProcurementProjectLotIDType procurementProjectLotIDField;

        private ExclusionReasonType[] exclusionReasonField;

        private ResolutionType[] resolutionField;

        private ResolutionDateType resolutionDateField;

        private ResolutionTimeType resolutionTimeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public AdmissionCodeType AdmissionCode
        {
            get
            {
                return this.admissionCodeField;
            }
            set
            {
                this.admissionCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public ProcurementProjectLotIDType ProcurementProjectLotID
        {
            get
            {
                return this.procurementProjectLotIDField;
            }
            set
            {
                this.procurementProjectLotIDField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ExclusionReason", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public ExclusionReasonType[] ExclusionReason
        {
            get
            {
                return this.exclusionReasonField;
            }
            set
            {
                this.exclusionReasonField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Resolution", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public ResolutionType[] Resolution
        {
            get
            {
                return this.resolutionField;
            }
            set
            {
                this.resolutionField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
        public ResolutionDateType ResolutionDate
        {
            get
            {
                return this.resolutionDateField;
            }
            set
            {
                this.resolutionDateField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 5)]
        public ResolutionTimeType ResolutionTime
        {
            get
            {
                return this.resolutionTimeField;
            }
            set
            {
                this.resolutionTimeField = value;
                
            }
        }

        

    }
}