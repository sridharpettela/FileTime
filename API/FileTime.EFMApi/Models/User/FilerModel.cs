using FileTime.EFMApi.Models.Court;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FileTime.EFMApi.Models.User
{
	public class FilerModel
	{
		internal bool RestrictFiling;

		public string Password { get; set; }
		public string username { get; set; }

		public string EfmId { get; set; }
		public string EmailAddress { get;  set; }

		public string FirstName { get; set; }
		public string MiddleName { get; set; }

		public string LastName { get; set; }

		public string EFMUserId { get; set; }
		public DateTime? LastLoginToEFM { get; set; }

		public DateTime? LastLogin { get; set; }
		public bool IsApproved { get; set; }
		public string RestrictFilingComment { get; set; }
		public bool IsActive { get; set; }
		public bool IsLockedOut { get; set; }
		public bool ActiveIndicator { get; set; }
		public string Roles { get; set; }
		public string eFileTexasNotiPref { get; set; }

		public string EFMNotificationPreference { get; set; }

		public virtual FirmModel Firm { get; set; }

	}
}