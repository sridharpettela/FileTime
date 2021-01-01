﻿using FileTime.Log.Entity;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace FileTime.Log.Sql
{
    public class SqlLogging
    {
        public void InsertErrorLog(ApiError apiError)
        {
            try
            {
                using (var sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["APILoggingConnection"].ConnectionString))
                {
                    sqlConnection.Open();
                    var cmd =
                        new SqlCommand("FTSP_APIErrorLogging", connection: sqlConnection)
                        {
                            CommandType = CommandType.StoredProcedure
                        };
                    cmd.Parameters.AddWithValue("@TimeUtc", apiError.TimeUtc);
                    cmd.Parameters.AddWithValue("@RequestUri", apiError.RequestUri);
                    cmd.Parameters.AddWithValue("@Message", apiError.Message);
                    cmd.Parameters.AddWithValue("@RequestMethod", apiError.RequestMethod);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void InsertAPILog(ApiLog apiLog)
        {
            try
            {
                using (var sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["APILoggingConnection"].ConnectionString))
                {
                    sqlConnection.Open();
                    var cmd =
                        new SqlCommand("FTSP_APILogging", connection: sqlConnection)
                        {
                            CommandType = CommandType.StoredProcedure
                        };
                    cmd.Parameters.AddWithValue("@Host", apiLog.Host);
                    cmd.Parameters.AddWithValue("@Headers", apiLog.Headers);
                    cmd.Parameters.AddWithValue("@StatusCode", apiLog.StatusCode);
                    cmd.Parameters.AddWithValue("@RequestBody", apiLog.RequestBody);
                    cmd.Parameters.AddWithValue("@RequestedMethod", apiLog.RequestedMethod);
                    cmd.Parameters.AddWithValue("@UserHostAddress", apiLog.UserHostAddress);
                    cmd.Parameters.AddWithValue("@Useragent", apiLog.Useragent);
                    cmd.Parameters.AddWithValue("@AbsoluteUri", apiLog.AbsoluteUri);
                    cmd.Parameters.AddWithValue("@RequestType", apiLog.RequestType);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
