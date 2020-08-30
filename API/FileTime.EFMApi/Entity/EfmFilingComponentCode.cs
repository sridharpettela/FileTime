using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTime.EFMApi.Entity
{
    public class EfmFilingComponentCode
    {
        public long Id { get; set; }
        public EFMLocationLookup Location { get; set; }
        public EfmFilingLookup EfmFilingLookupType { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool IsRequired { get; set; }
        public bool AllowMultiple { get; set; }
        public string EFSPCode { get; set; }


    }
    public class EFMOptionalServiceCode
    {
        public long Id { get; set; }
        public EFMLocationLookup Location { get; set; }
        public EfmFilingLookup EfmFilingLookupType { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal Fee { get; set; }
        public bool Multiplier { get; set; }
        public int DisplayOrder { get; set; }
        public string AltFeeDesc { get; set; }
        public string EFSPCode { get; set; }
    }
}
