using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;
using System.Web;
using FileTime.EFMApi.Core;
using FileTime.EFMApi.EFMUserServices;
using FileTime.EFMApi.Models.User;
using FileTime.EFMApi.Wrappers.Interface;

namespace FileTime.EFMApi.Wrappers
{
	public class UserServiceWrapper : IUserServiceWrapper
	{
		private IEfmUserService _efmUserService;// efm user service variable
		private ClientBase<IEfmUserService> _efmUserServiceClient; // efm client

		//This is the constructor to instanciate the logger classes
		public UserServiceWrapper()
		{
		}

		//This is the destructor to release memory of efm clietns the logger classes
		~UserServiceWrapper()
		{
			var clientObject = _efmUserService as EfmUserServiceClient;
			if (clientObject != null && clientObject.State == System.ServiceModel.CommunicationState.Opened)
				clientObject.Close();
		}

        /// <summary>
        ///  This is the method to validate the filer against efm data with user name and password asynchronously and return the filer details
        /// </summary>
        /// <param name="requestModel"></param>
        /// <returns></returns>
        public async Task<UserLoginResponseModel> LoginAsync(UserLoginRequestModel requestModel)
        {
            try
            {
                _efmUserService = new EfmUserServiceClient();//get the user service client
                // make sure authenticate the user with email and password
                AuthenticateResponseType response =
                    await
                    _efmUserService.AuthenticateUserAsync(new AuthenticateRequestType
                    {
                        Email = requestModel.UserName,
                        Password = requestModel.Password
                    });
                if (response.Error.ErrorCode != "0")//raise exception if any errors in response object
                {
                    throw new AppException(response.Error.ErrorText, false, AppExceptionType.EFM);
                }
                //return new filer object with data
                return new UserLoginResponseModel
                {
                    FirstName = response.FirstName,
                    LastName = response.LastName,
                    EmailAddress = response.Email,
                    EFMUserId = response.UserID,
                    Password = response.PasswordHash

                };
            }
            catch (TimeoutException te)//this is to handle timeout exceptions
            {
                ((EfmUserServiceClient)_efmUserService).Abort();//abort the sercive any any from semding message
                throw new Exception(
                    "The state eFiling system has stopped responding. We cannot proceed. Your information has been saved as a draft. You may continue this filing later.",
                    te);
            }
            catch (CommunicationException ce)//this is to handle communication exceptions
            {
                throw Util.BuildWcfException((EfmUserServiceClient)_efmUserService, ce); // throw wcf exceptions if any 
            }
            catch (Exception e)//this is to handle general exceptions
            {
                ((EfmUserServiceClient)_efmUserService).Abort();
                if (e.Message.ToLower().Contains("unknown error"))//if error message has unknown error throw it as technical issue.
                {
                    throw new AppException("eFile manager is experiencing technical issues.  Please try again later.", true, AppExceptionType.EFM, e);
                }
                throw new AppException(e.Message, true, AppExceptionType.EFM, e);
            }
            finally
            {
                try
                {
                    if ((_efmUserService) != null)//finally try to close the wrapper instance if not null
                    {
                        ((EfmUserServiceClient)_efmUserService).Close();
                    }
                }
                catch (Exception exception)//this is to handle exceptions
                {
                    throw Util.BuildWcfException((EfmUserServiceClient)_efmUserService, exception);
                }
            }
        }

    }
}