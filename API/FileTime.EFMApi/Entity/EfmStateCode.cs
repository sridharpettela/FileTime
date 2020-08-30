using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTime.EFMApi.Entity
{
    public class EfmStateCode
    {
        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public CountryCode Country { get; set; }
    }

    public class EFMFilingStatusCode
    {
        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
    }

    public class EFMNameSuffixCode
    {
        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
    }

    public class EFMDataFieldConfigCode
    {
        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool IsVisible { get; set; }
        public bool IsRequired { get; set; }
        public string HelpText { get; set; }
        public string GhostText { get; set; }
        public string ContextualHelpData { get; set; }
        public string ValidationMessage { get; set; }
        public string RegularExpression { get; set; }
        public string DefaultValueExpression { get; set; }
        public bool IsReadonly { get; set; }
        public string EFSPCode { get; set; }
        public EFMLocationLookup Location { get; set; }
    }

    public class LocationDataFieldConfig
    {
        public bool FilingDescriptionIsVisible { get; set; }
        public bool FilingDescriptionIsRequired { get; set; }
        public bool FilingAttorneyViewIsVisible { get; set; }
        public bool FilingAttorneyViewIsRequired { get; set; }
        public bool IsPartyAddAnotherPartyButtonSubsequent { get; set; }
    }

}
