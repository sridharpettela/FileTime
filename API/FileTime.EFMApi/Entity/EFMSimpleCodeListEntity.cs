using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FileTime.EFMApi.Entity
{
    [XmlRoot("SimpleCodeList")]
    public class EFMSimpleCodeListEntity
    {
        [XmlElement("Row")]
        public List<EFMRowEntity> Row { get; set; }
    }

    [XmlRoot("Row")]
    public class EFMRowEntity
    {
        [XmlElement("Value")]
        public List<EFMValueEntity> Value { get; set; }
    }

    [XmlRoot("Value")]
    public class EFMValueEntity
    {
        [XmlAttribute("ColumnRef")]
        public string ColumnRef { get; set; }
        [XmlElement("SimpleValue")]
        public string SimpleValue { get; set; }

    }
}
