using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTime.EFMApi.Entity.Redaction
{
    public class TylerRedactionEntity
    {
        public int PageNumber { get; set; }
        public TylerRedactionRegion Region { get; set; }
        public List<TylerRedactionOcrSource> OCRSources { get; set; }
        public string User { get; set; }
        public DateTime Date { get; set; }
        public string AnnotationId { get; set; }
    }
}
