using System;

namespace FileTime.DAO
{
	public class Filer
	{
		public long Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string MiddleName { get; set; }
		public string EmailAddress { get; set; }
		public string EFMUserId { get; set; }
		public string Password { get; set; }
		public string SecurityQuestion { get; set; }
		public string SecurityAnswer { get; set; }
		public string Roles { get; set; }
		public bool? IsApproved { get; set; }
		public bool? IsActive { get; set; }
		public bool? IsLockedOut { get; set; }
		public bool? ActiveIndicator { get; set; }
		public DateTime? LastUpdateFromEFM { get; set; }
		public DateTime? LastLogin { get; set; }
		public DateTime? LastLoginToEFM { get; set; }
		public DateTime? UserSince { get; set; }
		public DateTime? FTUserSince { get; set; }
		public bool? FilingAcceptedNotification { get; set; }
		public bool? FilingRejectedNotification { get; set; }
		public bool? FilingSubmitedNotification { get; set; }
		public bool? FilingFailedNotification { get; set; }
		public bool? ServiceStatusNotification { get; set; }
		public string eFileTexasNotiPref { get; set; }
		public bool? FirmSubmissionsWaitingOnClerkReview { get; set; }
		public bool? FirmSubmissionsReturnedByTheClerk { get; set; }
		public bool? RestrictFiling { get; set; }
		public string RestrictFilingComment { get; set; }
		public bool? ShowWelcomePageAtLogin { get; set; }
		public long Firm_id { get; set; }
		public long? Attoney_id { get; set; }
		public string HeardAboutFiletime { get; set; }
		public string ReferrerEmailAddress { get; set; }
		public string Other { get; set; }
		public string ActivationLink { get; set; }
		public string PasswordResetLink { get; set; }
		public DateTime? LastFilingUpdateFromEFM { get; set; }
	}
}
