using System;
using System.IO;
using System.Threading.Tasks;
using FileTime.DAO.EFM;
using FileTime.EFM.Core;
using FileTime.IEFM;
using Microsoft.Extensions.Configuration;

namespace FileTime.EFM
{
	public class UserServiceWrapper : IUserServiceWrapper
	{
		private HttpClientWrapper _apiClient = null;
		private IConfigurationRoot _config = null;
		public UserServiceWrapper()
		{
			_config = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory())
				.AddJsonFile("appsettings.json")
				.Build();
			_apiClient = new HttpClientWrapper(new Uri(_config.GetSection("appsettings").GetSection("EFMApiUri").Value));
		}

		public async Task<FilerLogin> Login(FilerLogin request)
		{
			return await _apiClient.PostAsync<FilerLogin>(RequestUrl.login, request);
		}
	}
}
