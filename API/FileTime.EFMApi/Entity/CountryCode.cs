using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTime.EFMApi.Entity
{
    public class CountryCode
    {
        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public IList<EfmStateCode> States { get; set; }
    }
}
