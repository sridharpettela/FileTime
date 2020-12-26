using FileTime.EFMApi.App_Start;
using FileTime.EFMApi.Models.User;
using FileTime.EFMApi.Wrappers.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace FileTime.EFMApi.Controllers
{
    public class UserController : ApiController
    {
        private readonly IUserServiceWrapper _userServiceWrapper;
        public UserController(IUserServiceWrapper userServiceWrapper)
        {
            _userServiceWrapper = userServiceWrapper;
            _userServiceWrapper.CheckArgumentIsNull(nameof(userServiceWrapper));
        }

        public async Task<UserLoginResponseModel> Login(UserLoginRequestModel model)
        {
            return await _userServiceWrapper.LoginAsync(model);
        }
    }
}
