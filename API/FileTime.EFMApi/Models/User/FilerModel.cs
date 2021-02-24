using FileTime.EFMApi.Models.Court;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
		public string EmailAddress { get; set; }

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

		public  FirmModel Firm { get; set; }
		public AttorneyModel AttoneyModel { get; set; }
        //public object Id { get; set; }
        public  long Id { get; set; }
        public string CurrentEmailAddress { get; set; }
		public bool IsAttorney { get; set; }
        public static object Individual { get; set; }
        public string SecurityQuestion { get; internal set; }
        public string SecurityAnswer { get; internal set; }
        public  AttorneyModel Attorneys { get; set; }


        public  ReadOnlyCollection<FilerRole> RolesEnum
        {
            get
            {
                List<FilerRole> roles = new List<FilerRole>();
                if (Roles != null && !Roles.Contains(","))
                {
                    FilerRole roleEnum;
                    if (Enum.TryParse(Roles, true, out roleEnum))
                    {
                        roles.Add(roleEnum);
                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(Roles))
                    {
                        foreach (var role in Roles.Split(','))
                        {
                            FilerRole roleEnum;
                            if (Enum.TryParse(role, true, out roleEnum))
                            {
                                roles.Add(roleEnum);
                            }
                        }
                    }
                }
                if (IsAttorney)
                {
                    roles.Add(FilerRole.Attorney);
                }

                return roles.AsReadOnly();
            }
        }
    }
		
}

