using System.Xml.Serialization;

namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ImageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DocumentAttachmentType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public partial class BinaryType : ComplexObjectType
    {

        private base64Binary itemField;

        private DateType binaryCaptureDateField;

        private EntityType binaryCapturerField;

        private TextType binaryDescriptionTextField;

        private TextType binaryFormatStandardNameField;

        private anyURI binaryLocationURIField;

        private NonNegativeDecimalType binarySizeValueField;

        private string pageCount;

        private TextType binaryCategoryTextField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BinaryBase64Object",  Order = 0)]
        public base64Binary Item
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
        public DateType BinaryCaptureDate
        {
            get
            {
                return this.binaryCaptureDateField;
            }
            set
            {
                this.binaryCaptureDateField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 2)]
        public EntityType BinaryCapturer
        {
            get
            {
                return this.binaryCapturerField;
            }
            set
            {
                this.binaryCapturerField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 3)]
        public TextType BinaryDescriptionText
        {
            get
            {
                return this.binaryDescriptionTextField;
            }
            set
            {
                this.binaryDescriptionTextField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 4)]
        public TextType BinaryFormatStandardName
        {
            get
            {
                return this.binaryFormatStandardNameField;
            }
            set
            {
                this.binaryFormatStandardNameField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 5)]
        public anyURI BinaryLocationURI
        {
            get
            {
                return this.binaryLocationURIField;
            }
            set
            {
                this.binaryLocationURIField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 6)]
        public NonNegativeDecimalType BinarySizeValue
        {
            get
            {
                return this.binarySizeValueField;
            }
            set
            {
                this.binarySizeValueField = value;
                
            }
        }

        [XmlElementAttribute("PageCount", Namespace = "urn:tyler:ecf:extensions:Common", Order = 7)]
        public string PageCount
        {
            get
            {
                return this.pageCount;
            }
            set
            {
                this.pageCount = value;

            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 8)]
        public TextType BinaryCategoryText
        {
            get
            {
                return this.binaryCategoryTextField;
            }
            set
            {
                this.binaryCategoryTextField = value;
                
            }
        }
    }
}