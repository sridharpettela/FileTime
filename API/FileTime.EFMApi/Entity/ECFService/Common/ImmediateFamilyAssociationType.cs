namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public partial class ImmediateFamilyAssociationType : AssociationType
    {

        private ReferenceType personParentReferenceField;

        private ReferenceType personChildReferenceField;

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public ReferenceType PersonParentReference
        {
            get
            {
                return this.personParentReferenceField;
            }
            set
            {
                this.personParentReferenceField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public ReferenceType PersonChildReference
        {
            get
            {
                return this.personChildReferenceField;
            }
            set
            {
                this.personChildReferenceField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FamilyKinshipCode", typeof(FamilyKinshipCodeType),  Order = 2)]
        [System.Xml.Serialization.XmlElementAttribute("FamilyKinshipText", typeof(TextType),  Order = 2)]
        public object Item
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
    }
}