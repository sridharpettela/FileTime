using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace FileTime.EFMApi.Core
{
	[Serializable]
	public enum AppExceptionType
	{
		Data,
		Service,
		Business,
		Validation,
		Core,
		EFM,
		Web
	}

	[Serializable]
	public enum AppExceptionLevel
	{
		Critical, //Something that causes the prevents user to do anything
		Warning,  //Error  
		Info,
		Jobs
	}

	[Serializable]
	public class AppException : Exception, ISerializable
	{
		#region Properties

		public bool SendEmail { get; protected internal set; }

		public ILookup<string, string> Errors { get; protected internal set; }

		public AppExceptionType ExceptionType { get; protected internal set; }

		public AppExceptionLevel ExceptionLevel { get; protected internal set; }

		public string MethodName { get; protected internal set; }

		#endregion

		#region Constructors

		protected AppException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}

		public AppException(string message)
			: base(message)
		{
		}

		public AppException(string message, Exception innerException)
			: base(message, innerException.GetBaseException())
		{
		}

		public AppException(string message, bool sendEmail, AppExceptionType exceptionType)
			: base(message)
		{
			SendEmail = sendEmail;
			ExceptionType = exceptionType;
		}

		public AppException(string message, bool sendEmail, AppExceptionType exceptionType, string methodName)
			: base(message)
		{
			MethodName = methodName;
			SendEmail = sendEmail;
			ExceptionType = exceptionType;
		}

		public AppException(string message, bool sendEmail, AppExceptionType exceptionType, ILookup<string, string> errors)
			: base(message)
		{
			SendEmail = sendEmail;
			ExceptionType = exceptionType;
			Errors = errors;
		}

		public AppException(string message, bool sendEmail, AppExceptionType exceptionType, Exception innerException)
			: base(message, innerException.GetBaseException())
		{
			SendEmail = sendEmail;
			ExceptionType = exceptionType;
		}

		public AppException(string message, bool sendEmail, AppExceptionType exceptionType, Exception innerException, string methodName)
			: base(message, innerException.GetBaseException())
		{
			MethodName = methodName;
			SendEmail = sendEmail;
			ExceptionType = exceptionType;
		}

		public AppException(string message, bool sendEmail, AppExceptionType exceptionType, Exception innerException, ILookup<string, string> errors)
			: base(message, innerException.GetBaseException())
		{
			SendEmail = sendEmail;
			ExceptionType = exceptionType;
			Errors = errors;
		}

		#endregion

		#region ISerializable Members

		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("sendEmail", SendEmail);
			info.AddValue("exceptionType", ExceptionType);
		}

		#endregion
	}
}