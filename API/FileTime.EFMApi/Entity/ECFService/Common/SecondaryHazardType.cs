namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class SecondaryHazardType
    {

        private IDType idField;

        private PlacardNotationType placardNotationField;

        private PlacardEndorsementType placardEndorsementField;

        private EmergencyProceduresCodeType emergencyProceduresCodeField;

        private ExtensionType extensionField;

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
        public PlacardNotationType PlacardNotation
        {
            get
            {
                return this.placardNotationField;
            }
            set
            {
                this.placardNotationField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public PlacardEndorsementType PlacardEndorsement
        {
            get
            {
                return this.placardEndorsementField;
            }
            set
            {
                this.placardEndorsementField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public EmergencyProceduresCodeType EmergencyProceduresCode
        {
            get
            {
                return this.emergencyProceduresCodeField;
            }
            set
            {
                this.emergencyProceduresCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
        public ExtensionType Extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
                
            }
        }

    }
}