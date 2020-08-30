using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTime.EFMApi.Entity
{
    public class EfmFileTypeLookup
    {
        public long Id { get; set; }
        public EFMLocationLookup Location { get; set; } 
        public string Code { get; set; }
        public string Name { get; set; }
    }
}
