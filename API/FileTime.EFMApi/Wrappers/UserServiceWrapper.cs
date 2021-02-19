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
using NLog;

namespace FileTime.EFMApi.Wrappers
{
	public class UserServiceWrapper : IUserServiceWrapper
	{
        private readonly ILogger _logger;//logger variable to log the serious of steps in fuctionality
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

        public string ResetPassword(string emailAddress)
        {
           // _logger.LogTrace(string.Format("resetting password for  {0}", emailAddress));//this is for tracing purpose
            try
            {
                _efmUserService = new EfmUserServiceClient();//create instance to the efm client
                var response = _efmUserService.ResetPassword(new ResetPasswordRequestType
                {
                    Email = emailAddress,
                });
                if (response.Error.ErrorCode != "0")//raise app exception if any erros in response object
                {
                    throw new AppException(response.Error.ErrorText, false, AppExceptionType.EFM);
                }
                return response.PasswordHash;
            }
            catch (TimeoutException te)// this is to handle timeout exceptions while interacting wiht EFM
            {
                ((EfmUserServiceClient)_efmUserService).Abort();
                throw new Exception("The state eFiling system has stopped responding. Please try again later.", te);
            }
            catch (CommunicationException ce) // this is to handle communication exceptions while interacting with EFM
            {
                throw Util.BuildWcfException((EfmUserServiceClient)_efmUserService, ce);
            }
            catch (Exception e)            // this is to handle general exceptions while interacting wiht EFM
            {
                ((EfmUserServiceClient)_efmUserService).Abort();
                if (e.Message.ToLower().Contains("unknown error"))//if error message has unknown error throw it as technical issue.             
                    throw new AppException("eFile manager is experiencing technical issues.  Please try again later.", true, AppExceptionType.EFM, e);
                throw new AppException(e.Message, true, AppExceptionType.EFM, e);
            }
            finally
            {
                try
                {
                    if ((_efmUserService) != null)//finally try to close the wrapper instance if not null
                        ((EfmUserServiceClient)_efmUserService).Close();
                }
                catch (Exception exception)
                {
                    throw Util.BuildWcfException((EfmUserServiceClient)_efmUserService, exception);
                }
            }
        }


        public string GetPasswordQuestion(string emailAddress)
        {
            //_logger.LogTrace(string.Format("getting  password question for  {0}", emailAddress));//for tracing purpose

            try
            {
                _efmUserService = new EfmUserServiceClient();// create istance to the user service client
                var response = _efmUserService.GetPasswordQuestion(new GetPasswordQuestionRequestType { Email = emailAddress });
                if (response.Error.ErrorCode != "0")//raise app exception if any erros in response object
                {
                    throw new AppException(response.Error.ErrorText, false, AppExceptionType.EFM);
                }
                return response.PasswordQuestion;//return the question
            }
            catch (TimeoutException te)// this is to handle timeout exceptions while interacting wiht EFM
            {
                ((EfmUserServiceClient)_efmUserService).Abort();
                throw new Exception(
                    "The state eFiling system has stopped responding. We cannot proceed. Your information has been saved as a draft. You may continue this filing later.",
                    te);
            }
            catch (CommunicationException ce) // this is to handle communication exceptions while interacting with EFM
            {
                throw Util.BuildWcfException((EfmUserServiceClient)_efmUserService, ce);
            }
            catch (Exception e)            // this is to handle general exceptions while interacting wiht EFM
            {
                ((EfmUserServiceClient)_efmUserService).Abort();
                if (e.Message.ToLower().Contains("unknown error"))//if error message has unknown error throw it as technical issue.
                {
                    throw new AppException("eFile manager is experiencing technical issues.  Please try again later.", true, AppExceptionType.EFM, e);
                }
                throw new AppException(e.Message, false, AppExceptionType.EFM, e);
            }
            finally
            {
                //close the client if it is active
                try
                {
                    if ((_efmUserService) != null)//finally try to close the wrapper instance if not null
                    {
                        ((EfmUserServiceClient)_efmUserService).Close();
                    }
                }
                catch (Exception exception)    // this is to handle general exceptions
                {
                    throw Util.BuildWcfException((EfmUserServiceClient)_efmUserService, exception);
                }
            }
        }

        public async Task<string> GetPasswordQuestionAsync(string emailAddress)
        {
           // _logger.LogTrace(string.Format("getting  password question for  {0}", emailAddress));//this is for tracing purpose

            try
            {
                var response = await _efmUserService.GetPasswordQuestionAsync(new GetPasswordQuestionRequestType { Email = emailAddress });
                if (response.Error.ErrorCode != "0")
                    throw new AppException(response.Error.ErrorText, false, AppExceptionType.EFM);
                return response.PasswordQuestion;
            }
            catch (TimeoutException te)// this is to handle timeout exceptions while interacting wiht EFM
            {
                ((EfmUserServiceClient)_efmUserService).Abort();
                throw new Exception("The state eFiling system has stopped responding. We cannot proceed. Your information has been saved as a draft. You may continue this filing later.", te);
            }
            catch (CommunicationException ce)            // this is to handle communication exceptions while interacting with EFM
            {
                throw Util.BuildWcfException((EfmUserServiceClient)_efmUserService, ce);
            }
            catch (Exception e)            // this is to handle general exceptions while interacting wiht EFM
            {
                ((EfmUserServiceClient)_efmUserService).Abort();
                if (e.Message.ToLower().Contains("unknown error"))//if error message has unknown error throw it as technical issue.
                {
                    throw new AppException("eFile manager is experiencing technical issues.  Please try again later.", true, AppExceptionType.EFM, e);
                }
                throw new AppException(e.Message, true, AppExceptionType.EFM, e);
            }



        }
        public bool SelfResendActivationEmail(string emailAddress)
        {
           // _logger.LogTrace(string.Format("Self Resend Activation Email For {0}", emailAddress));//for tracing purpose
            try
            {
                _efmUserService = new EfmUserServiceClient();//create instance to user service client
                //get response of notification email
                var response = _efmUserService.SelfResendActivationEmail(new SelfResendActivationEmailRequestType
                {
                    Email = emailAddress,
                });
                if (response.Error.ErrorCode != "0")//raise app exception if any errors in response object
                {
                    throw new AppException(response.Error.ErrorText, false, AppExceptionType.EFM);
                }
                return true;
            }
            catch (TimeoutException te)// this is to handle timeout exceptions while interacting wiht EFM
            {
                ((EfmUserServiceClient)_efmUserService).Abort();
                throw new Exception(
                     "The state eFiling system has stopped responding. Please try again later.",
                    te);
            }
            catch (CommunicationException ce) // this is to handle communication exceptions while interacting with EFM
            {
                throw Util.BuildWcfException((EfmUserServiceClient)_efmUserService, ce);
            }
            catch (Exception e)            // this is to handle general exceptions while interacting wiht EFM
            {
                ((EfmUserServiceClient)_efmUserService).Abort();
                if (e.Message.ToLower().Contains("unknown error"))//if error message has unknown error throw it as technical issue.
                {
                    throw new AppException("eFile manager is experiencing technical issues.  Please try again later.", true, AppExceptionType.EFM, e, "SelfResendActivationEmail");
                }
                throw new AppException(e.Message, true, AppExceptionType.EFM, e, "SelfResendActivationEmail");
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
                catch (Exception exception)
                {
                    throw Util.BuildWcfException((EfmUserServiceClient)_efmUserService, exception);
                }
            }
        }
        /// <summary>
        /// This is the method to change password of the filer
        /// </summary>
        /// <param name="filer">filer details to know before procedding </param>
        /// <param name="password">old password details</param>
        /// <param name="newPassword">new password details</param>
        /// <param name="question">security question</param>
        /// <param name="answer">security answer</param>
        /// <returns>returns PasswordHash value</returns>
        public string ChangePassword(FilerModel filer, string password, string newPassword, string question, string answer)
        {
           // _logger.LogTrace(string.Format("changing password for  {0}", filer.EmailAddress));//this is for tracing purpose


            try
            {
                _efmUserService = new EfmUserServiceClient();// create istance to the user service client
                //add authentication data to the client
                Util.AddAuthInfoToClient((EfmUserServiceClient)_efmUserService, filer.EmailAddress, filer.Password);
                //get response of changepassword call
                var response = _efmUserService.ChangePassword(new ChangePasswordRequestType
                {
                    PasswordQuestion = "question",
                    PasswordAnswer = "answer",
                    NewPassword = newPassword,
                    OldPassword = password
                });
                if (response.Error.ErrorText == "Old Password does not match existing password.")
                { response.Error.ErrorText = "Current Password does not match existing password."; }
                if (response.Error.ErrorCode != "0")//raise app exception if any errors in response object
                {
                    throw new AppException(response.Error.ErrorText, false, AppExceptionType.EFM);
                }
                return response.PasswordHash;//return the response
            }
            catch (TimeoutException te)// this is to handle timeout exceptions while interacting wiht EFM
            {
                ((EfmUserServiceClient)_efmUserService).Abort();
                throw new Exception(
                    "The state eFiling system has stopped responding. We cannot proceed. Your information has been saved as a draft. You may continue this filing later.",
                    te);
            }
            catch (CommunicationException ce) // this is to handle communication exceptions while interacting with EFM
            {
                throw Util.BuildWcfException((EfmUserServiceClient)_efmUserService, ce);
            }
            catch (Exception e)            // this is to handle general exceptions while interacting wiht EFM
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
                catch (Exception exception)//throw wcf exceptions
                {
                    throw Util.BuildWcfException((EfmUserServiceClient)_efmUserService, exception);
                }
            }
        }
        /// <summary>
        /// This is the method to ger user information from efm asynchronously
        /// </summary>           
        /// <param name="username">filer email address to authenticate before getting data</param>
        /// <param name="password">filer password to authenticate</param>
        /// <param name="EfmId">efm id for searching filers data</param>
        /// <returns>returns Filer obect </returns>
        public async Task<FilerModel> GetUserFromEFMAsync(string username, string password, string EfmId)
        {
            //_logger.LogTrace(string.Format("Getting User info for  {0}", EfmId));//this is for tracing purpose
            try
            {
                //_efmUserService = new EfmUserServiceClient();
                //add authentication data to the client
                Util.AddAuthInfoToClient((EfmUserServiceClient)_efmUserService, username, password);
                //get user response from efm
                var response =
                    await _efmUserService.GetUserAsync(new GetUserRequestType
                    {
                        UserID = EfmId
                    });
                if (response.Error.ErrorCode != "0")//raise app exception if any errors in response object
                {
                    throw new AppException(response.Error.ErrorText, false, AppExceptionType.EFM);
                }
                return MapGetUserResponseToFiler(response.User);//map user data and send as Filer object
            }
            catch (TimeoutException te)// this is to handle timeout exceptions while interacting wiht EFM
            {
                ((EfmUserServiceClient)_efmUserService).Abort();
                throw new Exception(
                    "The state eFiling system has stopped responding. We cannot proceed. Your information has been saved as a draft. You may continue this filing later.",
                    te);
            }
            catch (CommunicationException ce) // this is to handle communication exceptions while interacting with EFM
            {
                throw Util.BuildWcfException((EfmUserServiceClient)_efmUserService, ce);
            }
            catch (Exception e)            // this is to handle general exceptions while interacting wiht EFM
            {
                ((EfmUserServiceClient)_efmUserService).Abort();
                if (e.Message.ToLower().Contains("unknown error"))//if error message has unknown error throw it as technical issue.
                {
                    throw new AppException("eFile manager is experiencing technical issues.  Please try again later.", true, AppExceptionType.EFM, e);
                }
                throw new AppException(e.Message, true, AppExceptionType.EFM, e);
            }
            //finally
            //{
            //    try
            //    {
            //        if ((_efmUserService) != null)
            //        {
            //            //((EfmUserServiceClient)_efmUserService).Close();
            //        }
            //    }
            //    catch (Exception exception)
            //    {
            //        throw Util.BuildWcfException((EfmUserServiceClient)_efmUserService, exception);
            //    }
            //}
        }
        /// <summary>
        /// This is the method to ger user information from efm asynchronously
        /// </summary>           
        /// <param name="username">filer email address to authenticate before getting data</param>
        /// <param name="password">filer password to authenticate</param>
        /// <param name="EfmId">efm id for searching filers data</param>
        /// <returns>returns Filer obect </returns>
        public FilerModel GetUserFromEFM(string username, string password, string EfmId)
        {
           // _logger.LogTrace(string.Format("Getting User info for  {0}", EfmId));//this is for tracing purpose
            try
            {
                //_efmUserService = new EfmUserServiceClient();
                //add authentication data to the client
                Util.AddAuthInfoToClient((EfmUserServiceClient)_efmUserService, username, password);
                //get user response from efm
                var response = _efmUserService.GetUser(new GetUserRequestType
                {
                    UserID = EfmId
                });
                if (response.Error.ErrorCode != "0")//raise app exception if any errors in response object
                {
                    throw new AppException(response.Error.ErrorText, false, AppExceptionType.EFM);
                }
                return MapGetUserResponseToFiler(response.User);//map user data and send as Filer object
            }
            catch (TimeoutException te)// this is to handle timeout exceptions while interacting wiht EFM
            {
                ((EfmUserServiceClient)_efmUserService).Abort();
                throw new Exception("The state eFiling system has stopped responding. We cannot proceed. Your information has been saved as a draft. You may continue this filing later.", te);
            }
            catch (CommunicationException ce) // this is to handle communication exceptions while interacting with EFM
            {
                throw Util.BuildWcfException((EfmUserServiceClient)_efmUserService, ce);
            }
            catch (Exception e)            // this is to handle general exceptions while interacting wiht EFM
            {
                ((EfmUserServiceClient)_efmUserService).Abort();
                if (e.Message.ToLower().Contains("unknown error"))//if error message has unknown error throw it as technical issue.
                {
                    throw new AppException("eFile manager is experiencing technical issues.  Please try again later.", true, AppExceptionType.EFM, e);
                }
                throw new AppException(e.Message, true, AppExceptionType.EFM, e);
            }
            //finally
            //{
            //    try
            //    {
            //        if ((_efmUserService) != null)
            //        {
            //            //((EfmUserServiceClient)_efmUserService).Close();
            //        }
            //    }
            //    catch (Exception exception)
            //    {
            //        throw Util.BuildWcfException((EfmUserServiceClient)_efmUserService, exception);
            //    }
            //}
        }
        /// <summary>
        /// This is the method to filer notification Preferencess data
        /// </summary>
        /// <param name="filer">filer object to get data</param>
        /// <returns>returns List<eFileTexasNotification> of  notification preferencess</returns>
        public List<eFileTexasNotificationModel> GetNotificationPreferences(FilerModel filer)
        {

            try
            {
                //add authentication data to the client
                Util.AddAuthInfoToClient((EfmUserServiceClient)_efmUserService, filer.EmailAddress, filer.Password);
                //get notifications response from efm
                var response = _efmUserService.GetNotificationPreferences();
                if (response.Error.ErrorCode != "0")//raise app exception if any errors in response object
                {
                    throw new AppException(response.Error.ErrorText, false, AppExceptionType.EFM);
                }
                if (response.Notification != null)//check      //get Notification data is there or not
                {
                    var eFileTexasNotificationList = new List<eFileTexasNotificationModel>();
                    foreach (var notificationItem in response.Notification) //loop Notification data and add to the list
                    {
                        eFileTexasNotificationList.Add(new eFileTexasNotificationModel()
                        {//assign data to all required properties
                            Code = notificationItem.Code,
                            Description = notificationItem.Description,
                            IsSelected = notificationItem.IsActive,
                        });
                    }
                    return eFileTexasNotificationList; // return Notification list
                }
                else { return new List<eFileTexasNotificationModel>(); }
            }
            catch (TimeoutException te)// this is to handle timeout exceptions while interacting wiht EFM
            {
                ((EfmUserServiceClient)_efmUserService).Abort();
                throw new Exception(
                    "The state eFiling system has stopped responding. We cannot proceed. Your information has been saved as a draft. You may continue this filing later.",
                    te);
            }
            catch (CommunicationException ce) // this is to handle communication exceptions while interacting with EFM
            {
                throw Util.BuildWcfException((EfmUserServiceClient)_efmUserService, ce);
            }
            catch (Exception e)            // this is to handle general exceptions while interacting wiht EFM
            {
                ((EfmUserServiceClient)_efmUserService).Abort();
                if (e.Message.ToLower().Contains("unknown error"))//if error message has unknown error throw it as technical issue.
                {
                    throw new AppException("eFile manager is experiencing technical issues.  Please try again later.", true, AppExceptionType.EFM, e);
                }
                throw new AppException(e.Message, true, AppExceptionType.EFM, e);
            }
            //finally
            //{
            //    try
            //    {
            //        if ((_efmUserService) != null)
            //        {
            //            //((EfmUserServiceClient)_efmUserService).Close();
            //        }
            //    }
            //    catch (Exception exception)
            //    {
            //        throw Util.BuildWcfException((EfmUserServiceClient)_efmUserService, exception);
            //    }
            //}
        }
        /// <summary>
        /// This is the method to update notification preferences data of a filer
        /// </summary>
        /// <param name="filer">filer object with data to authenticate the user</param>
        public void UpdateNotificationPreferences(FilerModel filer)
        {
            try
            {
                //add authentication data to the client       
                Util.AddAuthInfoToClient((EfmUserServiceClient)_efmUserService, filer.EmailAddress, filer.Password);
                //create instance
                var UpdateNotificationPreferencesRequestType = new UpdateNotificationPreferencesRequestType();
                var notificationTypeList = new List<NotificationType>();
                //check fier has notifications data 
                if (!string.IsNullOrEmpty(filer.eFileTexasNotiPref))
                {
                    string[] spiltNotiPref = filer.EFMNotificationPreference.Split(',');//split data by comma
                    if (spiltNotiPref != null && spiltNotiPref.Length > 0) //if length is greater than zero 

                    {
                        foreach (var splt in spiltNotiPref) //loop all preferences and add to the list
                        {
                            if (!string.IsNullOrEmpty(splt))
                            {
                                if (filer.eFileTexasNotiPref.Contains(splt))
                                    notificationTypeList.Add(new NotificationType() { Code = splt, IsActive = true });
                                else
                                    notificationTypeList.Add(new NotificationType() { Code = splt, IsActive = false });
                            }
                        }
                    }
                }
                //assign notification list to the request object and update in efm
                UpdateNotificationPreferencesRequestType.Notification = notificationTypeList.ToArray();
                //get notifications response from efm
                var response = _efmUserService.UpdateNotificationPreferences(UpdateNotificationPreferencesRequestType);
                if (response.Error.ErrorCode != "0")//send error message if response has errors
                {
                    throw new AppException(response.Error.ErrorText, false, AppExceptionType.EFM);
                }

            }
            catch (TimeoutException te)// this is to handle timeout exceptions while interacting wiht EFM
            {
                ((EfmUserServiceClient)_efmUserService).Abort();
                throw new Exception("The state eFiling system has stopped responding. We cannot proceed. Your information has been saved as a draft. You may continue this filing later.", te);
            }
            catch (CommunicationException ce) // this is to handle communication exceptions while interacting with EFM
            {
                throw Util.BuildWcfException((EfmUserServiceClient)_efmUserService, ce);
            }
            catch (Exception e)// this is to handle general exceptions while interacting wiht EFM
            {
                ((EfmUserServiceClient)_efmUserService).Abort();
                if (e.Message.ToLower().Contains("unknown error"))//if error message has unknown error throw it as technical issue.
                {
                    throw new AppException("eFile manager is experiencing technical issues.  Please try again later.", true, AppExceptionType.EFM, e);
                }
                throw new AppException(e.Message, true, AppExceptionType.EFM, e);
            }
            //finally
            //{
            //    try
            //    {
            //        if ((_efmUserService) != null)
            //        {
            //            //((EfmUserServiceClient)_efmUserService).Close();
            //        }
            //    }
            //    catch (Exception exception)// this is to handle general exceptions while interacting wiht EFM
            //    {
            //        throw Util.BuildWcfException((EfmUserServiceClient)_efmUserService, exception);
            //    }
            //}
        }

        /// <summary>
        /// This is the common private method to map user type data to filer object data
        /// </summary>
        /// <param name="response">UserType object with data to map</param>
        /// <returns>return Filer object with mapped data </returns>
        private FilerModel MapGetUserResponseToFiler(UserType response)
        {
            //create new filer instance and assign data to all required properties
            FilerModel filer = new FilerModel
            {
                FirstName = response.FirstName,
                MiddleName = response.MiddleName ?? "",
                LastName = response.LastName,
                EFMUserId = response.UserID,
                EmailAddress = response.Email,
                LastLoginToEFM = response.LastLoginDate,
                LastLogin = response.LastLoginDate,
                IsApproved = response.IsApproved,
                RestrictFiling = response.RestrictFiling,
                RestrictFilingComment = response.RestrictFilingComment,
                IsActive = true,
                IsLockedOut = response.IsLockedOut,
                ActiveIndicator = true,
            };
            //add filer role
            if (response.Role != null && response.Role.Any(x => x.RoleName == RoleType.Filer))
                filer.Roles = "Filer";
            //add admin firm role
            if (response.Role != null && response.Role.Any(x => x.RoleName == RoleType.FirmAdmin))
            {
                if (string.IsNullOrEmpty(filer.Roles))     //assign only admin role         
                    filer.Roles = "Admin";
                else
                    filer.Roles += ",Admin";// add admin role
            }
            return filer;//return updated filer object
        }
    }
}