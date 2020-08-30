using FileTime.IBAL;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FileTime.GrpcService
{
	public class FilerService : Filer.FilerBase
	{
		private readonly ILogger<GreeterService> _logger;
		private readonly IFilerBAL _filerBal;
		public FilerService(ILogger<GreeterService> logger, IFilerBAL filerBal)
		{
			_logger = logger;
			_filerBal = filerBal;
		}

		public override async Task<FilerLoginReply> FilerLogin(FilerLoginRequest request, ServerCallContext context)
		{
			var filerLoginReply = new FilerLoginReply();
			var filer = await  _filerBal.Login(request.EmailAddress, request.Password);
			if (filer != null)
			{
				filerLoginReply.EmailAddress = filer.EmailAddress;
				filerLoginReply.Password = filer.Password;
			}
			return await Task.FromResult(filerLoginReply);
		}
	}
}
