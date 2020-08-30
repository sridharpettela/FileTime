using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTime.EFMApi.Entity.Redaction
{
    public class TylerRedactionSettings
    {
        public static string TYLER_REDACTION_SERVICE_HOST { get { return ConfigurationSettings.AppSettings["TYLER_REDACTION_SERVICE_HOST"]; } }
        public static string TYLER_REDACTION_SERVICE_PATH { get { return ConfigurationSettings.AppSettings["TYLER_REDACTION_SERVICE_PATH"]; } }
        public static string TYLER_REDACTION_BASIC_AUTH_USERNAME { get { return ConfigurationSettings.AppSettings["TYLER_REDACTION_BASIC_AUTH_USERNAME"]; } }
        public static string TYLER_REDACTION_BASIC_AUTH_PASSWORD { get { return ConfigurationSettings.AppSettings["TYLER_REDACTION_BASIC_AUTH_PASSWORD"]; } }
        public static string TYLER_REDACTION_DOCUMENTS_COLLECTION { get { return ConfigurationSettings.AppSettings["TYLER_REDACTION_DOCUMENTS_COLLECTION"]; } }
        public static string TYLER_REDACTION_OPERATION_NAMESPACE { get { return ConfigurationSettings.AppSettings["TYLER_REDACTION_OPERATION_NAMESPACE"]; } }
        public static string TYLER_REDACTION_SCAN_OPERATION_SUFFIX { get { return ConfigurationSettings.AppSettings["TYLER_REDACTION_SCAN_OPERATION_SUFFIX"]; } }
        public static string TYLER_REDACTION_CALCULATE_OPERATION_SUFFIX { get { return ConfigurationSettings.AppSettings["TYLER_REDACTION_CALCULATE_OPERATION_SUFFIX"]; } }
        public static string TYLER_REDACTION_SCAN_AND_REDACT_OPERATION_SUFFIX { get { return ConfigurationSettings.AppSettings["TYLER_REDACTION_SCAN_AND_REDACT_OPERATION_SUFFIX"]; } }
        public static string TYLER_REDACTION_MEDIA_ROOT { get { return ConfigurationSettings.AppSettings["TYLER_REDACTION_MEDIA_ROOT"]; } }
        public static string TYLER_REDACTION_MINOR_NAME_COLLECTION { get { return ConfigurationSettings.AppSettings["TYLER_REDACTION_MINOR_NAME_COLLECTION"]; } }
        public static string TYLER_REDACTION_MINOR_DOB_COLLECTION { get { return ConfigurationSettings.AppSettings["TYLER_REDACTION_MINOR_DOB_COLLECTION"]; } }
        public static string TYLER_REDACTION_MINOR_ADDRESS_COLLECTION { get { return ConfigurationSettings.AppSettings["TYLER_REDACTION_MINOR_ADDRESS_COLLECTION"]; } }
    }
}
