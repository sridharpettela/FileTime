namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public partial class DNAType : ComplexObjectType
    {

        private DNALocusType[] dNALocusField;

        private ImageType dNAImageField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DNALocus",  Order = 0)]
        public DNALocusType[] DNALocus
        {
            get
            {
                return this.dNALocusField;
            }
            set
            {
                this.dNALocusField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 1)]
        public ImageType DNAImage
        {
            get
            {
                return this.dNAImageField;
            }
            set
            {
                this.dNAImageField = value;
                
            }
        }
    }
}