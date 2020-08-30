namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:JuvenileCase-4.0")]
    public abstract partial class PlacementAssociationType : AssociationType
    {

        private TextType placementTypeCodeField;

        private DateType placementStartDateField;

        private EntityType placementEntityField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public TextType PlacementTypeCode
        {
            get
            {
                return this.placementTypeCodeField;
            }
            set
            {
                this.placementTypeCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public DateType PlacementStartDate
        {
            get
            {
                return this.placementStartDateField;
            }
            set
            {
                this.placementStartDateField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public EntityType PlacementEntity
        {
            get
            {
                return this.placementEntityField;
            }
            set
            {
                this.placementEntityField = value;
                
            }
        }
    }
}