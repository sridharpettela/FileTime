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
    [RoutePrefix("api/v1/user")]
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
        public async Task<UserLoginResponseModel> Test()
        {
            return await _userServiceWrapper.LoginAsync(new UserLoginRequestModel() { UserName = "sirishapettela@gmail.com", Password = "Abcd1234" });
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
