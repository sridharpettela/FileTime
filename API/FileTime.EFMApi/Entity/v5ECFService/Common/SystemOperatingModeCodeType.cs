using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTime.EFMApi.Entity.v5ECFService
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://release.niem.gov/niem/codes/cbrncl/4.0/")]
    [System.Xml.Serialization.XmlRootAttribute("SystemOperatingModeCode", Namespace = "http://release.niem.gov/niem/domains/cbrn/4.0/", IsNullable = false)]
    public partial class SystemOperatingModeCodeType
    {

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://release.niem.gov/niem/structures/4.0/", DataType = "ID")]
        public string id { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://release.niem.gov/niem/structures/4.0/", DataType = "IDREF")]
        public string @ref { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://release.niem.gov/niem/structures/4.0/", DataType = "anyURI")]
        public string uri { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://release.niem.gov/niem/structures/4.0/", DataType = "IDREFS")]
        public string metadata { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://release.niem.gov/niem/structures/4.0/", DataType = "IDREFS")]
        public string relationshipMetadata { get; set; }

        [System.Xml.Serialization.XmlTextAttribute()]
        public SystemOperatingModeCodeSimpleType Value { get; set; }


        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://release.niem.gov/niem/codes/cbrncl/4.0/")]
    public enum SystemOperatingModeCodeSimpleType
    {

        /// <remarks/>
        Exercise,

        /// <remarks/>
        Ops,

        /// <remarks/>
        Other,

        /// <remarks/>
        Test,

        /// <remarks/>
        Unknown,
    }
}
