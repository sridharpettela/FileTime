namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class LocationCoordinateType
    {

        private CoordinateSystemCodeType coordinateSystemCodeField;

        private LatitudeDegreesMeasureType latitudeDegreesMeasureField;

        private LatitudeMinutesMeasureType latitudeMinutesMeasureField;

        private LatitudeDirectionCodeType latitudeDirectionCodeField;

        private LongitudeDegreesMeasureType longitudeDegreesMeasureField;

        private LongitudeMinutesMeasureType longitudeMinutesMeasureField;

        private LongitudeDirectionCodeType longitudeDirectionCodeField;

        private AltitudeMeasureType altitudeMeasureField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public CoordinateSystemCodeType CoordinateSystemCode
        {
            get
            {
                return this.coordinateSystemCodeField;
            }
            set
            {
                this.coordinateSystemCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public LatitudeDegreesMeasureType LatitudeDegreesMeasure
        {
            get
            {
                return this.latitudeDegreesMeasureField;
            }
            set
            {
                this.latitudeDegreesMeasureField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public LatitudeMinutesMeasureType LatitudeMinutesMeasure
        {
            get
            {
                return this.latitudeMinutesMeasureField;
            }
            set
            {
                this.latitudeMinutesMeasureField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public LatitudeDirectionCodeType LatitudeDirectionCode
        {
            get
            {
                return this.latitudeDirectionCodeField;
            }
            set
            {
                this.latitudeDirectionCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
        public LongitudeDegreesMeasureType LongitudeDegreesMeasure
        {
            get
            {
                return this.longitudeDegreesMeasureField;
            }
            set
            {
                this.longitudeDegreesMeasureField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 5)]
        public LongitudeMinutesMeasureType LongitudeMinutesMeasure
        {
            get
            {
                return this.longitudeMinutesMeasureField;
            }
            set
            {
                this.longitudeMinutesMeasureField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 6)]
        public LongitudeDirectionCodeType LongitudeDirectionCode
        {
            get
            {
                return this.longitudeDirectionCodeField;
            }
            set
            {
                this.longitudeDirectionCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 7)]
        public AltitudeMeasureType AltitudeMeasure
        {
            get
            {
                return this.altitudeMeasureField;
            }
            set
            {
                this.altitudeMeasureField = value;
                
            }
        }

        

       
    }
}