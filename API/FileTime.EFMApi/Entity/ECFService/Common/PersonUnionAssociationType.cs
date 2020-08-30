namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MarriageAssociationType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public partial class PersonUnionAssociationType : PersonAssociationType
    {

        private MarriageCategoryCodeType itemField;

        private MarriageStatusType personUnionStatusField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonUnionCategoryCode",  Order = 0)]
        public MarriageCategoryCodeType Item
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
        [System.Xml.Serialization.XmlElementAttribute( Order = 1)]
        public MarriageStatusType PersonUnionStatus
        {
            get
            {
                return this.personUnionStatusField;
            }
            set
            {
                this.personUnionStatusField = value;
                
            }
        }
    }
}