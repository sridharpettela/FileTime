using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FileTime.EFMApi.Models.Court
{
	public class FirmModel
	{
		
		public virtual string EFMFirmID { get; set; }
		public virtual bool IsIndividual { get; set; }
	}
}