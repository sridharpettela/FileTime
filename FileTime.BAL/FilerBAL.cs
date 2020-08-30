using FileTime.IBAL;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Threading.Tasks;
using FileTime.IDAL;
using FileTime.IEFM;
using FileTime.DAO;
using FileTime.DAO.EFM;

namespace FileTime.BAL
{
	public class FilerBAL : IFilerBAL
	{
		private IConfigurationRoot _config = null;
		private IFilerDAL _filerDal = null;
		private IUserServiceWrapper _userServiceWrapper = null;

		public FilerBAL(IFilerDAL filerDal, IUserServiceWrapper userServiceWrapper)
		{
			_config = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory())
				.AddJsonFile("appsettings.json")
				.Build();
			_filerDal = filerDal;
			_userServiceWrapper = userServiceWrapper;
		}

		public async Task<Filer> Login(string emailAddress, string password)
		{
			Filer retFiler = null;
			FilerLogin filerRequest = new FilerLogin()
			{
				UserName = emailAddress,
				Password = password
			};

			var filerResponse = await _userServiceWrapper.Login(filerRequest);
			if (filerResponse != null && !string.IsNullOrEmpty(filerResponse.EFMUserId))
			{
				retFiler = await _filerDal.GetAndUpdateFiler(filerResponse.UserName, filerResponse.EFMUserId,
					filerResponse.Password) ?? new Filer
				{
					EmailAddress = emailAddress,
					Password = password
				};
			}

			return retFiler;
		}
	}
}

