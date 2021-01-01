using System;
using System.Collections.Generic;
using System.Text;

namespace FileTime.Log.Entity
{
    public class ApiError
    {
        public string Message { get; set; }
        public string RequestMethod { get; set; }
        public string RequestUri { get; set; }
        public DateTime TimeUtc { get; set; }
    }
}
