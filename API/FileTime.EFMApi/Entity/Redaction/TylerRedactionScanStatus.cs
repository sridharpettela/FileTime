using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTime.EFMApi.Entity.Redaction
{
    public class TylerRedactionScanStatus
    {
        public bool OcrModified { get; set; }
        public List<int> FailedPages { get; set; }
    }
}
