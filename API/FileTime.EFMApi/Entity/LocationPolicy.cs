using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTime.EFMApi.Entity
{
    public class LocationPolicy
    {
        public string Id { get; set; }
        public List<LocationUrl> LookupURL { get; set; }
        public IList<SupportedType> SupportedCaseType { get; set; }
        public string LocationId { get; set; }
    }

    public class SupportedType
    {
        public LocationPolicy LocationPolicy { get; set; }
        public string Type { get; set; }
    }

    public class LocationUrl
    {
        public LocationPolicy LocationPolicy { get; set; }
        public string code { get; set; }
        public string  Name { get; set; }
        
    }
}
