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
    [Route("api/v1/user")]
    public class UserController : ApiController
    {
        private readonly IUserServiceWrapper _userServiceWrapper;
        public UserController(IUserServiceWrapper userServiceWrapper)
        {
            _userServiceWrapper = userServiceWrapper;
            _userServiceWrapper.CheckArgumentIsNull(nameof(userServiceWrapper));
        }

        [AllowAnonymous]
        [HttpGet()]
        [Route("test")]
        public bool Test()
        {
            return true;
        }

        [AllowAnonymous]
        [HttpPost()]
        [Route("login")]
        public async Task<UserLoginResponseModel> Login(UserLoginRequestModel model)
        {
            return await _userServiceWrapper.LoginAsync(model);
        }
    }
}
