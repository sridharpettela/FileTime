using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTime.EFMApi.Entity
{
    public class EfmDocumentTypeCode
    {
        public long Id { get; set; }
        public EFMLocationLookup Location { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string FilingCodeId { get; set; }
        public bool IsCourtUseOnly { get; set; }
        public bool IsSelected { get; set; }
        public string EFSPCode { get; set; }
    }
}
