using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FileTime.EFMApi.Models.User
{
	public class AddressModel
	{
        public  string Address1 { get; set; }
        public  string Address2 { get; set; }
        public  string City { get; set; }
        public  string State { get; set; }
        public  int StateId { get; set; }
        public  string StateCode { get; set; }
        public  string Zip { get; set; }
        public  string CountryCode { get; set; }
    }
}