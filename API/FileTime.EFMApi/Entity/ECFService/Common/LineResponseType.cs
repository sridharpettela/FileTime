namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class LineResponseType
    {

        private LineReferenceType lineReferenceField;

        private ResponseType[] responseField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public LineReferenceType LineReference
        {
            get
            {
                return this.lineReferenceField;
            }
            set
            {
                this.lineReferenceField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Response", Order = 1)]
        public ResponseType[] Response
        {
            get
            {
                return this.responseField;
            }
            set
            {
                this.responseField = value;
                
            }
        }

        

        
    }
}