using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FileTime.EFMApi.Models.User
{
	public class eFileTexasNotificationModel
	{
		public virtual string Code { get; set; }
		public virtual string Description { get; set; }
		public virtual bool IsSelected { get; set; }
	}
}