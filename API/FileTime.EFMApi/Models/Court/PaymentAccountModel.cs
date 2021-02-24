using FileTime.EFMApi.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FileTime.EFMApi.Models.Court
{
	public class PaymentAccountModel
	{
		public string CardHolderName { get;  set; }
		public int? CardLast4Numbers { get;  set; }
		public string CardToken { get;  set; }
		public string CardType { get;  set; }
		public string EFMId { get;  set; }
		public string AccountName { get;  set; }
		public int ExpirationMonth { get;  set; }
		public int ExpirationYear { get;  set; }
		public bool? Active { get;  set; }

		public  TypeOfPayment Type { get; set; }

	}
}