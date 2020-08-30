using NLog;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.SessionState;

namespace FileTime.EFMApi.Core
{
	public interface ILogger<T>
	{
		void LogDebug(string message);
		void LogTrace(string message);
		void LogError(Exception x);
		void LogError(string message);
		void LogFatal(Exception x);
		void LogFatal(string message);
		void LogInfo(string message);
		void LogWarning(string message);
		string GetExceptionInfo(Exception ex);
	}

	public class NLogger<T> : ILogger<T>
	{
		private readonly Logger _logger;

		public NLogger()
		{
			_logger = LogManager.GetLogger(nameof(T));
		}

		#region ILogger Members

		public void LogTrace(string message)
		{
			ReflectedInfo srcInfo = Reflect();

			_logger.Trace(string.Format("Machine ({0}) AssemblyName ({1}) :{2}.{3}.{4} says '{5}'",
										srcInfo.MachineName,
										srcInfo.AssemblyName,
										srcInfo.Namespace,
										srcInfo.ClassName,
										srcInfo.MethodName,
										message));
		}

		public void LogDebug(string message)
		{
			ReflectedInfo srcInfo = Reflect();

			_logger.Debug(string.Format("Machine ({0}) AssemblyName ({1}) :{2}.{3}.{4} says '{5}'",
										srcInfo.MachineName,
										srcInfo.AssemblyName,
										srcInfo.Namespace,
										srcInfo.ClassName,
										srcInfo.MethodName,
										message));
		}

		public void LogError(Exception x)
		{
			_logger.Log(LogLevel.Error, x, GetExceptionInfo(x));
		}

		public void LogError(string message)
		{
			ReflectedInfo srcInfo = Reflect();
			_logger.Log(LogLevel.Error, string.Format("Machine ({0}) AssemblyName ({1}) :{2}.{3}.{4} says '{5}'",
													  srcInfo.MachineName,
													  srcInfo.AssemblyName,
													  srcInfo.Namespace,
													  srcInfo.ClassName,
													  srcInfo.MethodName,
													  message));
		}

		public void LogFatal(Exception x)
		{
			_logger.Log(LogLevel.Error, x, GetExceptionInfo(x));
		}

		public void LogFatal(string message)
		{
			ReflectedInfo srcInfo = Reflect();
			_logger.Log(LogLevel.Fatal, string.Format("Machine ({0}) AssemblyName ({1}) :{2}.{3}.{4} says '{5}'",
													  srcInfo.MachineName,
													  srcInfo.AssemblyName,
													  srcInfo.Namespace,
													  srcInfo.ClassName,
													  srcInfo.MethodName,
													  message));
		}

		public void LogInfo(string message)
		{
			ReflectedInfo srcInfo = Reflect();
			_logger.Log(LogLevel.Info, string.Format("Machine ({0}) AssemblyName ({1}) :{2}.{3}.{4} says '{5}'",
													 srcInfo.MachineName,
													 srcInfo.AssemblyName,
													 srcInfo.Namespace,
													 srcInfo.ClassName,
													 srcInfo.MethodName,
													 message));
		}

		public void LogWarning(string message)
		{
			ReflectedInfo srcInfo = Reflect();
			_logger.Log(LogLevel.Warn, string.Format("Machine ({0}) AssemblyName ({1}) :{2}.{3}.{4} says '{5}'",
													 srcInfo.MachineName,
													 srcInfo.AssemblyName,
													 srcInfo.Namespace,
													 srcInfo.ClassName,
													 srcInfo.MethodName,
													 message));
		}

		#endregion

		/// <summary>
		/// Gets reflected information
		/// </summary>
		/// <returns></returns>
		private ReflectedInfo Reflect()
		{
			MethodBase met = new StackTrace().GetFrame(2).GetMethod();
			return new ReflectedInfo
			{
				MachineName = Environment.MachineName,
				AssemblyName = met.Module.Name,
				Namespace = met.ReflectedType == null ? "" : met.ReflectedType.ReflectedType == null ? met.ReflectedType.Namespace : met.ReflectedType.ReflectedType.Namespace,
				ClassName = met.ReflectedType == null ? "" : met.ReflectedType.ReflectedType == null ? met.ReflectedType.Name : met.ReflectedType.ReflectedType.Name,
				MethodName = met.Name
			};
		}

		public string GetExceptionInfo(Exception ex)
		{
			ReflectedInfo srcInfo = Reflect();
			string exInfo = null;
			var strInfo = new StringBuilder();

			if (HttpContext.Current != null && HttpContext.Current.User != null)
			{
				strInfo.AppendFormat("User: {0}{1}", HttpContext.Current.User.Identity.Name, Environment.NewLine);
			}

			strInfo.AppendFormat(string.Format("Machine ({0}) AssemblyName ({1}) :{2}.{3}.{4} says '{5}'",
											   srcInfo.MachineName,
											   srcInfo.AssemblyName,
											   srcInfo.Namespace,
											   srcInfo.ClassName,
											   srcInfo.MethodName,
											   Regex.Replace(ex.Message, @"[^\d\w\s]", "-")));

			strInfo.AppendFormat(string.Format(
				"RequestedUrl : {0}, SessionID = {1}, UserAddress = {2}, UserAgent = {3}", RequestedUrl, SessionId,
				UserAddress, UserAgent));

			Exception currentException = ex;
			int exceptionCount = 1;

			do
			{
				// Write title information for the exception object.
				strInfo.AppendFormat("{0}{0}{1}) Exception Information{0}{2}", Environment.NewLine,
									 exceptionCount.ToString(), "*********************************************");
				strInfo.AppendFormat("{0}Exception Type: {1}", Environment.NewLine, currentException.GetType().FullName);

				#region Loop through the public properties of the exception object and record their value

				// Loop through the public properties of the exception object and record their value.
				PropertyInfo[] aryPublicProperties = currentException.GetType().GetProperties();
				foreach (PropertyInfo p in aryPublicProperties)
				{
					// Do not log information for the InnerException or StackTrace. This information is captured later in the process.
					if (p.Name != "InnerException" && p.Name != "StackTrace")
					{
						if (p.GetValue(currentException, null) == null)
						{
							strInfo.AppendFormat("{0}{1}: NULL", Environment.NewLine, p.Name);
						}
						else
						{
							// Loop through the collection of AdditionalInformation if the exception type is a BaseApplicationException.
							strInfo.AppendFormat("{0}{1}: {2}", Environment.NewLine, p.Name,
												 p.GetValue(currentException, null));
						}
					}
				}

				#endregion

				#region Record the Exception StackTrace

				// Record the StackTrace with separate label.
				if (currentException.StackTrace != null)
				{
					strInfo.AppendFormat("{0}{0}StackTrace Information{0}{1}", Environment.NewLine,
										 "*********************************************");
					strInfo.AppendFormat("{0}{1}", Environment.NewLine, currentException.StackTrace);
				}

				#endregion

				// Reset the temp exception object and iterate the counter.
				currentException = currentException.InnerException;
				exceptionCount++;
			} while (currentException != null);

			exInfo = strInfo.ToString();

			return exInfo;
		}

		#region HttpContext-safe Properties

		private HttpContext _context
		{
			get { return (HttpContext.Current == null) ? null : HttpContext.Current; }
		}

		private HttpSessionState _session
		{
			get { return (_context == null) ? null : _context.Session; }
		}

		private HttpRequest _request
		{
			get { return (_context == null) ? null : _context.Request; }
		}

		/// <summary>
		/// HttpContext-safe Request Url
		/// </summary>
		private string RequestedUrl
		{
			get { return (null == _request) ? string.Empty : _request.Url.ToString(); }
		}

		/// <summary>
		/// HttpContext-safe UserHostAddress
		/// </summary>
		private string UserAddress
		{
			get { return (null == _request) ? string.Empty : _request.UserHostAddress; }
		}

		/// <summary>
		/// HttpContext-safe UserAgent
		/// </summary>
		private string UserAgent
		{
			get { return (null == _request) ? string.Empty : _request.UserAgent; }
		}

		/// <summary>
		/// HttpContext-safe SessionId
		/// </summary>
		private string SessionId
		{
			get { return (null == _session) ? string.Empty : _session.SessionID; }
		}

		#endregion

		#region Nested type: ReflectedInfo

		/// <summary>
		/// ReflectedInfo from source
		/// </summary>
		private struct ReflectedInfo
		{
			public string AssemblyName;
			public string ClassName;
			public string MachineName;
			public string MethodName;
			public string Namespace;
		}

		#endregion
	}
}