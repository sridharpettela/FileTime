﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FileTime.EFMApi.Entity.Response
{
	public class EFMFilerEntity
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string MiddleName { get; set; }
		public string EmailAddress { get; set; }
		public string EFMUserId { get; set; }
		public string Password { get; set; }
	}
}