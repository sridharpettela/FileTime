using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FileTime.EFMApi.Models.Court
{
	public class AttorneyModel
	{
		public string FirstName { get;  set; }
		public string LastName { get;  set; }
		public string MiddleName { get;  set; }
		
		public string BarNumber { get;  set; }
	
		
		
		public  string AttorneyEFMID { get; set; }

		public  FirmModel Firm { get; set; }

		





	}
}