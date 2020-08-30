namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public partial class PersonContactInformationAssociationType : AssociationType
    {

        private ReferenceType personReferenceField;

        private ReferenceType contactInformationReferenceField;

        private boolean contactInformationIsPrimaryIndicatorField;

        private boolean contactInformationIsHomeIndicatorField;

        private boolean contactInformationIsWorkIndicatorField;

        private boolean contactInformationIsEmergencyIndicatorField;

        private boolean contactInformationIsDayIndicatorField;

        private boolean contactInformationIsEveningIndicatorField;

        private boolean contactInformationIsNightIndicatorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public ReferenceType PersonReference
        {
            get
            {
                return this.personReferenceField;
            }
            set
            {
                this.personReferenceField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public ReferenceType ContactInformationReference
        {
            get
            {
                return this.contactInformationReferenceField;
            }
            set
            {
                this.contactInformationReferenceField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 2)]
        public boolean ContactInformationIsPrimaryIndicator
        {
            get
            {
                return this.contactInformationIsPrimaryIndicatorField;
            }
            set
            {
                this.contactInformationIsPrimaryIndicatorField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 3)]
        public boolean ContactInformationIsHomeIndicator
        {
            get
            {
                return this.contactInformationIsHomeIndicatorField;
            }
            set
            {
                this.contactInformationIsHomeIndicatorField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 4)]
        public boolean ContactInformationIsWorkIndicator
        {
            get
            {
                return this.contactInformationIsWorkIndicatorField;
            }
            set
            {
                this.contactInformationIsWorkIndicatorField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 5)]
        public boolean ContactInformationIsEmergencyIndicator
        {
            get
            {
                return this.contactInformationIsEmergencyIndicatorField;
            }
            set
            {
                this.contactInformationIsEmergencyIndicatorField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 6)]
        public boolean ContactInformationIsDayIndicator
        {
            get
            {
                return this.contactInformationIsDayIndicatorField;
            }
            set
            {
                this.contactInformationIsDayIndicatorField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 7)]
        public boolean ContactInformationIsEveningIndicator
        {
            get
            {
                return this.contactInformationIsEveningIndicatorField;
            }
            set
            {
                this.contactInformationIsEveningIndicatorField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 8)]
        public boolean ContactInformationIsNightIndicator
        {
            get
            {
                return this.contactInformationIsNightIndicatorField;
            }
            set
            {
                this.contactInformationIsNightIndicatorField = value;
                
            }
        }
    }
}