using FileTime.EFMApi.Models.User;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;

namespace FileTime.EFMApi.Test
{
	public class UserControllerTest
	{
		private Uri _baseUrl = new Uri("https://localhost:44378/");
		public void Login()
		{
			HttpClientWrapper httpClientWrapper = new HttpClientWrapper(_baseUrl);
			UserLoginRequestModel userLoginRequestModel = new UserLoginRequestModel();

			var resp = httpClientWrapper.PostAsync<UserLoginRequestModel>("/api/v1/user/login", userLoginRequestModel);
		}
	}
}
