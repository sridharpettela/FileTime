using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FileTime.EFMApi.Models.Common
{
	public class ErrorResponseModel
	{
		public string ErrorCode { get; set; }
		public string ErroDesc { get; set; }
	}

	public class ErrorResponseListModel
	{
		public List<ErrorResponseModel> Errors { get; set; }
	}
}