using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FileTime.EFMApi.Entity
{
	public class SOAPAction
	{
		public string OpertionName { get; set; }
		public string WSDLNamespace { get; set; }
		public string PortName { get; set; }
	}
}