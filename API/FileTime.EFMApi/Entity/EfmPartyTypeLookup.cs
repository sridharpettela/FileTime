using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTime.EFMApi.Entity
{
    public class EfmPartyTypeLookup
    {
        public long Id { get; set; }
        public EFMCaseTypeLookup CaseType { get; set; }
        public string CaseTypeCode { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool IsAvailableForNewParties { get; set; }
        public bool IsRequired { get; set; }
        public decimal Amount { get; set; }
        public int NumberOfPartiesToIgnore { get; set; }
        public EFMLocationLookup Location { get; set; }
        public string LocationCode { get; set; }
        public string EFSPCode { get; set; }
    }
}
