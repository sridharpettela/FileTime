namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public partial class StructuredAddressType : ComplexObjectType
    {

        private TextType addressRecipientNameField;

        private object[] itemsField;

        private ItemsChoiceType[] itemsElementNameField;

        private ProperNameTextType locationCityNameField;

        private object itemField;

        private object item1Field;

        private object item2Field;

        private @string locationPostalCodeField;

        private @string locationPostalExtensionCodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 0)]
        public TextType AddressRecipientName
        {
            get
            {
                return this.addressRecipientNameField;
            }
            set
            {
                this.addressRecipientNameField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AddressDeliveryPointID", typeof(@string),  Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("AddressDeliveryPointText", typeof(TextType),  Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("AddressPrivateMailboxText", typeof(TextType),  Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("AddressSecondaryUnitText", typeof(TextType),  Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("LocationRouteName", typeof(TextType),  Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("LocationStreet", typeof(StreetType),  Order = 1)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName", Order = 2)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 3)]
        public ProperNameTextType LocationCityName
        {
            get
            {
                return this.locationCityNameField;
            }
            set
            {
                this.locationCityNameField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LocationCountyCode", typeof(USCountyCodeType),  Order = 4)]
        [System.Xml.Serialization.XmlElementAttribute("LocationCountyName", typeof(ProperNameTextType),  Order = 4)]
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

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LocationStateName", typeof(ProperNameTextType),  Order = 5)]
        [System.Xml.Serialization.XmlElementAttribute("LocationStateUSPostalServiceCode", typeof(USStateCodeType),  Order = 5)]
        public object Item1
        {
            get
            {
                return this.item1Field;
            }
            set
            {
                this.item1Field = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LocationCountryFIPS10-4Code", typeof(CountryCodeType),  Order = 6)]
        [System.Xml.Serialization.XmlElementAttribute("LocationCountryName", typeof(ProperNameTextType),  Order = 6)]
        public object Item2
        {
            get
            {
                return this.item2Field;
            }
            set
            {
                this.item2Field = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 7)]
        public @string LocationPostalCode
        {
            get
            {
                return this.locationPostalCodeField;
            }
            set
            {
                this.locationPostalCodeField = value;
                
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( Order = 8)]
        public @string LocationPostalExtensionCode
        {
            get
            {
                return this.locationPostalExtensionCodeField;
            }
            set
            {
                this.locationPostalExtensionCodeField = value;
                
            }
        }
    }
}