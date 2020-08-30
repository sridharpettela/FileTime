using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FileTime.EFMApi.Models.User
{
	public class UserLoginRequestModel
	{
		public string UserName { get; set; }
		public string Password { get; set; }
	}
}