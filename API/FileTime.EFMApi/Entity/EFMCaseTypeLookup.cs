using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTime.EFMApi.Entity
{
    public class EFMCaseTypeLookup
    {
        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string CategoryCode { get; set; }
        public EFMCaseCategoryLookup Category { get; set; }
        public EFMLocationLookup Location { get; set; }
        public string EfmId { get; set; }
        public bool AllowInitial { get; set; }
        public decimal Fee { get; set; }
        public string EFSPCode { get; set; }
    }

    public class EFMCaseSubTypeLookup
    {
        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string CategoryCode { get; set; }
        public EFMCaseCategoryLookup Category { get; set; }
        public EFMLocationLookup Location { get; set; }
        public bool AllowInitial { get; set; }
    }
}
