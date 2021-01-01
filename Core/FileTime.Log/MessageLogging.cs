using FileTime.Log.Entity;
using FileTime.Log.Sql;
using System;
using System.Collections.Generic;
using System.Text;

namespace FileTime.Log
{
    public class MessageLogging
    {
        public void IncomingMessageAsync(ApiLog apiLog)
        {
            apiLog.RequestType = "Request";
            var sqlLogging = new SqlLogging();
            sqlLogging.InsertAPILog(apiLog);
        }

        public void OutgoingMessageAsync(ApiLog apiLog)
        {
            apiLog.RequestType = "Response";
            var sqlLogging = new SqlLogging();
            sqlLogging.InsertAPILog(apiLog);
        }
    }
}
