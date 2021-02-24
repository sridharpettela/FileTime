using FileTime.EFMApi.Models.Court;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FileTime.EFMApi.Models.User
{
	public class ServiceContactModel
	{
		public FirmModel firm { get;  set; }
		public string EFMId { get;  set; }
		public string Email { get;  set; }
		public string FirstName { get;  set; }
		public string MiddleName { get;  set; }
		public string LastName { get;  set; }
		public  AddressModel Address { get; set; }
		public string PhoneNumber { get;  set; }
		public bool IsPublic { get;  set; }
		public bool IsNonFirm { get;  set; }
		public string AdministrativeCopyEmail { get;  set; }
		public string AddByFirmName { get;  set; }
		public string NonFirmName { get;  set; }

		public  long Id { get; set; }
		
	}
}