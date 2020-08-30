using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FileTime.EFMApi.Entity.ECFService
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:FilingListQueryMessage-4.0")]
    [System.Xml.Serialization.XmlRoot("FilingListQueryMessage", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:FilingListQueryMessage-4.0")]
    public class FilingListQueryMessageType : QueryMessageType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0", Order = 0)]
        public @string CaseTrackingID { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0", Order = 1)]
        public EntityType1 DocumentSubmitter { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DateRange", Namespace = "http://niem.gov/niem/niem-core/2.0", Order = 2)]
        public DateRangeType[] DateRange { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0")]
    public partial class EntityType1 : EntityType
    {

        [XmlElement("EntityFiler", typeof(PersonFilerType),
            Namespace = "urn:tyler:ecf:extensions:Common",
            Order = 0)]
        public PersonFilerType PersonFilerType { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:FilingListResponseMessage-4.0")]
    [System.Xml.Serialization.XmlRoot("FilingListResponseMessage", Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:FilingListResponseMessage-4.0")]
    public class FilingListResponseMessageType : QueryResponseMessageType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MatchingFiling", Order = 0)]
        public MatchingFilingType[] MatchingFiling { get; set; }
    }
}
