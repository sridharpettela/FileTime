using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTime.EFMApi.Entity.ECFService
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ServiceRecipientType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CaseParticipantType1))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CaseAbstractorType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:legalxml-courtfiling:schema:xsd:CommonTypes-4.0")]
    public partial class EntityType : ComplexObjectType
    {

        private object itemField;

        private ItemChoiceType2 itemElementNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EntityOrganization", typeof(OrganizationType1), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityOrganizationReference", typeof(ReferenceType), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityPerson", typeof(PersonType2), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityPersonReference", typeof(ReferenceType), Order = 0)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType2 ItemElementName
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
    public enum ItemChoiceType2
    {

        /// <remarks/>
        EntityOrganization,

        /// <remarks/>
        EntityOrganizationReference,

        /// <remarks/>
        EntityPerson,

        /// <remarks/>
        EntityPersonReference,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:tyler:ecf:extensions:ServiceInformationHistoryResponseMessage")]
    public partial class ServiceRecipientType : EntityType
    {

        private ActionType[] actionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Action", Order = 0)]
        public ActionType[] Action
        {
            get
            {
                return this.actionField;
            }
            set
            {
                this.actionField = value;

            }
        }
    }
}
