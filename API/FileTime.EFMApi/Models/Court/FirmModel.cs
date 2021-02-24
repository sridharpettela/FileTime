using FileTime.EFMApi.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FileTime.EFMApi.Models.Court
{
	public class FirmModel
	{
		public  string EFMFirmID { get; set; }

		public  bool IsIndividual { get; set; }
		public  string Name { get; set; }
		public AddressModel Address { get;  set; }
		public string Phone { get; internal set; }
		public  IList<AttorneyModel> attorney { get; set; }
		// public virtual AttorneyModel Attorneys { get;  set; }
		
	}
}