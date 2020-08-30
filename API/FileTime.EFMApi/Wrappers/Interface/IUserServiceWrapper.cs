using FileTime.EFMApi.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTime.EFMApi.Wrappers.Interface
{
	public interface IUserServiceWrapper
	{
		Task<UserLoginResponseModel> LoginAsync(UserLoginRequestModel requestModel);
	}
}
