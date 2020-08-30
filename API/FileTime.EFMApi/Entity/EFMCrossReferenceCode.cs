using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTime.EFMApi.Entity
{
    public class EFMCrossReferenceCode
    {
        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string CaseTypeCode { get; set; }
        public EFMCaseTypeLookup CaseType { get; set; }
        public EFMLocationLookup Location { get; set; }
        public bool IsDefault { get; set; }
        public bool IsRequired { get; set; }
        public string ValidationRegex { get; set; }
        public string EFSPCode { get; set; }
    }
}
