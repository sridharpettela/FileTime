using System;
using System.Collections.Generic;
using System.Text;

namespace FileTime.DAO.Common
{
	public class AppSettings
    {
        public string StateKeyList { get; set; }
        public string StateKey { get; set; }
        public string DocStorageAPIKey { get; set; }
        public string DocStorageUserName { get; set; }
        public string CertificateFileName { get; set; }
        public string CertificateFilePath { get; set; }
        public string CertificatePassword { get; set; }
    }
}
