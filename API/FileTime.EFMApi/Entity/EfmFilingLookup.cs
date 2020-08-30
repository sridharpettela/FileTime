using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTime.EFMApi.Entity
{
    public class EfmFilingLookup
    {
        public long Id { get; set; }
        public EFMLocationLookup Location { get; set; }
        public EFMCaseCategoryLookup Category { get; set; }
        public EFMCaseTypeLookup CaseType{ get; set; }
        public string CategoryCode { get; set; }
        public string CaseTypeCode { get; set; }
        public string EfmId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal Fee { get; set; }
        //public FilingLevel Level { get; set; }
        public IList<EFMOptionalServiceCode> OptionalServiceCodes { get; set; }
        public bool IsCourtUseOnly { get; set; }
        public string CivilClaimAmount { get; set; }
        public string ProbateEstateAmount { get; set; }
        public string AmountInControversy { get; set; }
        public bool UseDueDate { get; set; }
        public bool IsProposedOrder { get; set; }
        public string ESFPCode { get; set; }
        
    }
}
