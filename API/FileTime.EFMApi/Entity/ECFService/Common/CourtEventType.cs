namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CourtEventType1))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://niem.gov/niem/domains/jxdm/4.0")]
    public partial class CourtEventType : ActivityType
    {

        private JudicialOfficialType[] courtEventJudgeField;

        private ScheduleDayType[] courtEventScheduleField;

        private IdentificationType courtEventSequenceIDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CourtEventJudge",  Order = 0)]
        public JudicialOfficialType[] CourtEventJudge
        {
            get
            {
                return this.courtEventJudgeField;
            }
            set
            {
                this.courtEventJudgeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CourtEventSchedule",  Order = 1)]
        public ScheduleDayType[] CourtEventSchedule
        {
            get
            {
                return this.courtEventScheduleField;
            }
            set
            {
                this.courtEventScheduleField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 2)]
        public IdentificationType CourtEventSequenceID
        {
            get
            {
                return this.courtEventSequenceIDField;
            }
            set
            {
                this.courtEventSequenceIDField = value;
                
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "CourtEventType", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CommonTypes-4.0")]
    public partial class CourtEventType1 : CourtEventType
    {

        private ReferenceType[] childDocketReferenceField;

        private DateType courtEventEnteredOnDocketDateField;

        private TextType courtEventTypeCodeField;

        private CourtEventDocumentType courtEventDocumentField;

        private ReferenceType courtEventDocumentReferenceField;

        private CourtEventActorType courtEventActorField;

        private CourtEventOnBehalfOfActorType courtEventOnBehalfOfActorField;

        private TextType courtEventLocationCodeField;

        private TextType courtEventLocationTextField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ChildDocketReference", Order = 0)]
        public ReferenceType[] ChildDocketReference
        {
            get
            {
                return this.childDocketReferenceField;
            }
            set
            {
                this.childDocketReferenceField = value;

            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public DateType CourtEventEnteredOnDocketDate
        {
            get
            {
                return this.courtEventEnteredOnDocketDateField;
            }
            set
            {
                this.courtEventEnteredOnDocketDateField = value;

            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public TextType CourtEventTypeCode
        {
            get
            {
                return this.courtEventTypeCodeField;
            }
            set
            {
                this.courtEventTypeCodeField = value;

            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public CourtEventDocumentType CourtEventDocument
        {
            get
            {
                return this.courtEventDocumentField;
            }
            set
            {
                this.courtEventDocumentField = value;

            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public ReferenceType CourtEventDocumentReference
        {
            get
            {
                return this.courtEventDocumentReferenceField;
            }
            set
            {
                this.courtEventDocumentReferenceField = value;

            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public CourtEventActorType CourtEventActor
        {
            get
            {
                return this.courtEventActorField;
            }
            set
            {
                this.courtEventActorField = value;

            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public CourtEventOnBehalfOfActorType CourtEventOnBehalfOfActor
        {
            get
            {
                return this.courtEventOnBehalfOfActorField;
            }
            set
            {
                this.courtEventOnBehalfOfActorField = value;

            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public TextType CourtEventLocationCode
        {
            get
            {
                return this.courtEventLocationCodeField;
            }
            set
            {
                this.courtEventLocationCodeField = value;

            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public TextType CourtEventLocationText
        {
            get
            {
                return this.courtEventLocationTextField;
            }
            set
            {
                this.courtEventLocationTextField = value;

            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CommonTypes-4.0")]
    public partial class CourtEventActorType : ComplexObjectType
    {

        private ReferenceType itemField;

        private ItemChoiceType itemElementNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RoleOfItemReference", typeof(ReferenceType), Namespace = "http://niem.gov/niem/niem-core/2.0", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("RoleOfOrganizationReference", typeof(ReferenceType), Namespace = "http://niem.gov/niem/niem-core/2.0", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("RoleOfPersonReference", typeof(ReferenceType), Namespace = "http://niem.gov/niem/niem-core/2.0", Order = 0)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public ReferenceType Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;

            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;

            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CommonTypes-4.0", IncludeInSchema = false)]
    public enum ItemChoiceType
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://niem.gov/niem/niem-core/2.0:RoleOfItemReference")]
        RoleOfItemReference,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://niem.gov/niem/niem-core/2.0:RoleOfOrganizationReference")]
        RoleOfOrganizationReference,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://niem.gov/niem/niem-core/2.0:RoleOfPersonReference")]
        RoleOfPersonReference,
    }
}