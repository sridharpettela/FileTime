using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;
using System.Threading.Tasks;
using System.ServiceModel.Description;
using System.Configuration;
using FileTime.EFMApi.Wrappers.Interface;
using FileTime.EFMApi.Models.User;
using FileTime.EFMApi.EFMFirmServices;
using FileTime.EFMApi.Core;
using NLog;
using FileTime.EFMApi.Models.Court;


namespace FileTime.EFMApi.Wrappers
{
	public class FirmServiceWrapper : IFirmServiceWrapper
	{
		#region Properties
		//logger variable to log the serious of steps in fuctionality
		//private ILogger _logger;
		// efm firm service variable
		private IEfmFirmService _efmFirmService;
		// efm firm service client variable		
		//private ClientBase<IEfmFirmService> _efmUserServiceClient; // efm client

		
		#endregion

		#region Firm

		/// <summary>
		/// This is the method to resiter firm users in the database
		/// </summary>
		/// <param name="filer"></param>
		/// <returns></returns>
		public bool RegisterFirm(FilerModel filer)
		{
			_efmFirmService = new EfmFirmServiceClient(); //create instance to firm service client //allocate memory to firm service client

			//_logger.LogTrace(string.Format("Attempting to register User")); // this is for tracing purpose


			try
			{
				var RegisterRequest = MapFilerToRegisterRequestType(filer);//map filer data to request object
				if (filer.Firm.IsIndividual)// check filer is of individual type and convert to enum type
				{
					RegisterRequest.RegistrationType = (EFMFirmServices.RegistrationType)RegistrationType.Individual;
				}
				else
				{
					//for firm administrators
					RegisterRequest.RegistrationType = (EFMFirmServices.RegistrationType)RegistrationType.FirmAdministrator;
				}
				//get response from efm
				var response = _efmFirmService.RegisterUser(RegisterRequest);//register user with efm and get the response
				if (response.Error.ErrorCode != "0")//raise exception if any errors in response object //raise exception if any errors in response object
				{
					throw new AppException(response.Error.ErrorText, false, AppExceptionType.EFM);
				}
				//assign data to all required properties
				filer.EFMUserId = response.UserID;
				filer.Firm.EFMFirmID = response.FirmID;
				filer.Password = response.PasswordHash;
				filer.IsApproved = !response.ActivationRequired;
				return true;
			}
			catch (TimeoutException te)// this is to handle timeout exceptions while interacting with EFM
			{
				//_logger.LogTrace(string.Format(te.Message));
				((EfmFirmServiceClient)_efmFirmService).Abort();
				throw new Exception(
					"The state eFiling system has stopped responding. We cannot proceed. Your information has been saved as a draft. You may continue this filing later.",
					te);
			}
			catch (CommunicationException ce) // this is to handle communication exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
			//	_logger.LogTrace(string.Format(ce.Message));
				throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, ce);
			}
			catch (Exception ex) // this is to handle general exceptions while interacting with EFM
			{
			//	_logger.LogTrace(string.Format(ex.Message));
				((EfmFirmServiceClient)_efmFirmService).Abort();
				if (ex.Message.ToLower().Contains("unknown error"))//if error message has unknown error throw it as technical issue.
				{
					throw new AppException("eFile manager is experiencing technical issues.  Please try again later.", true, AppExceptionType.EFM, ex, "RegisterFirm");
				}
				throw new AppException(ex.Message, true, AppExceptionType.EFM, ex, "RegisterFirm");
			}
			finally
			{
				try
				{
					if ((_efmFirmService) != null)
					{
						((EfmFirmServiceClient)_efmFirmService).Close();// close efm firm service client connection// close efm firm service client connection
					}
				}
				catch (Exception exception)
				{// this is to handle general exceptions while closing efm objects
					throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, exception);
				}
			}
		}

		/// <summary>
		/// This is the method to update firm details in efm.
		/// </summary>
		/// <param name="firm">Firm object with data to update</param>
		/// <param name="admin">Filer data to authenticate the user</param>
		public void UpdateFirm(FirmModel firm, FilerModel admin)
		{
			_efmFirmService = new EfmFirmServiceClient(); //create instance to firm service client//create instance to firm service client

			try
			{
				//add authentication details to the client object to interact with efm
				Util.AddAuthInfoToClient((EfmFirmServiceClient)_efmFirmService, admin.EmailAddress, admin.Password);

				//map firm data to the request object and update  details in efm
				var response = _efmFirmService.UpdateFirm(new UpdateFirmRequestType { Firm = MapFirmToFirmType(firm) });
				if (response.Error.ErrorCode != "0")//raise exception if any errors in response object//raise exception if any errors in response object
				{
					throw new AppException(response.Error.ErrorText, false, AppExceptionType.EFM);
				}

			}
			catch (TimeoutException te)// this is to handle timeout exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				throw new Exception(
					"The state eFiling system has stopped responding. We cannot proceed. Your information has been saved as a draft. You may continue this filing later.",
					te);
			}
			catch (CommunicationException ce) // this is to handle communication exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, ce);
			}
			catch (Exception ex) // this is to handle general exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				if (ex.Message.ToLower().Contains("unknown error"))//if error message has unknown error throw it as technical issue.
				{
					throw new AppException("eFile manager is experiencing technical issues.  Please try again later.", true, AppExceptionType.EFM, ex, "UpdateFirm");
				}
				throw new AppException(ex.Message, true, AppExceptionType.EFM, ex, "UpdateFirm");
			}
			finally
			{
				try
				{
					if ((_efmFirmService) != null)
					{
						((EfmFirmServiceClient)_efmFirmService).Close();// close efm firm service client connection
					}
				}
				catch (Exception exception)
				{// this is to handle general exceptions while closing efm objects
					throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, exception);
				}
			}
		}
		/// <summary>
		/// This is the method to update firm details in efm.
		/// </summary>
		/// <param name="firm">Firm object with data to update</param>
		/// <param name="admin">Filer data to authenticate the user</param>
		public void UpdateFirm(FirmModel firm, FilerModel admin, string StateKeyConfig)
		{
			//OpenConnection(StateKeyConfig); //create instance to firm service client//create instance to firm service client

			try
			{
				//add authentication details to the client object to interact with efm
				Util.AddAuthInfoToClient((EfmFirmServiceClient)_efmFirmService, admin.EmailAddress, admin.Password);

				//map firm data to the request object and update  details in efm
				var response = _efmFirmService.UpdateFirm(new UpdateFirmRequestType { Firm = MapFirmToFirmType(firm) });
				if (response.Error.ErrorCode != "0")//raise exception if any errors in response object//raise exception if any errors in response object
				{
					throw new AppException(response.Error.ErrorText, false, AppExceptionType.EFM);
				}

			}
			catch (TimeoutException te)// this is to handle timeout exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				throw new Exception(
					"The state eFiling system has stopped responding. We cannot proceed. Your information has been saved as a draft. You may continue this filing later.",
					te);
			}
			catch (CommunicationException ce) // this is to handle communication exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, ce);
			}
			catch (Exception ex) // this is to handle general exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				if (ex.Message.ToLower().Contains("unknown error"))//if error message has unknown error throw it as technical issue.
				{
					throw new AppException("eFile manager is experiencing technical issues.  Please try again later.", true, AppExceptionType.EFM, ex, "UpdateFirm");
				}
				throw new AppException(ex.Message, true, AppExceptionType.EFM, ex, "UpdateFirm");
			}
			finally
			{
				//CloseConnection();
			}
		}
		/// <summary>
		/// This is the method to get firm details from efm asynchronously.
		/// </summary>
		/// <param name="username">username for authenticating the user</param>
		/// <param name="password">password for authenticating the user</param>
		/// <returns>returns firm object with data</returns>
		public async Task<FirmModel> GetFirmAsync(string username, string password)
		{

			try
			{
				//add authentication details to the client object to interact with efm
				Util.AddAuthInfoToClient((EfmFirmServiceClient)_efmFirmService, username, password);

				//get response from efm
				var response = await _efmFirmService.GetFirmAsync();
				if (response.Error.ErrorCode != "0")//raise exception if any errors in response object
				{
					throw new AppException(response.Error.ErrorText, false, AppExceptionType.EFM);
				}
				return MapFirmTypeToFirm(response.Firm);// map response data to firm object data and return.

			}
			catch (TimeoutException te)// this is to handle timeout exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				throw new Exception(
					"The state eFiling system has stopped responding. We cannot proceed. Your information has been saved as a draft. You may continue this filing later.",
					te);
			}
			catch (CommunicationException ce) // this is to handle communication exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, ce);
			}
			catch (Exception ex) // this is to handle general exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				if (ex.Message.ToLower().Contains("unknown error"))//if error message has unknown error throw it as technical issue.
				{
					throw new AppException("eFile manager is experiencing technical issues.  Please try again later.", true, AppExceptionType.EFM, ex, "GetFirmAsync");
				}
				throw new AppException(ex.Message, true, AppExceptionType.EFM, ex, "GetFirmAsync");
			}
			//finally
			//{
			//    try
			//    {
			//        if ((_efmFirmService) != null)
			//        {
			//            //((EfmFirmServiceClient)_efmFirmService).Close();
			//        }
			//    }
			//    catch (Exception exception)
			//    {
			//        throw Util.BuildWcfException((EfmFirmServiceClient) _efmFirmService, exception);
			//    }
			//}
		}

		/// <summary>
		/// This is the method to get firm details from efm .
		/// </summary>
		/// <param name="username">username for authenticating the user</param>
		/// <param name="password">password for authenticating the user</param>
		/// <returns>returns firm object with data</returns>
		public FirmModel GetFirm(string username, string password)
		{

			try
			{
				//add authentication details to the client object to interact with efm
				Util.AddAuthInfoToClient((EfmFirmServiceClient)_efmFirmService, username, password);
				//get response from efm
				var response = _efmFirmService.GetFirm();
				if (response.Error.ErrorCode != "0")//raise exception if any errors in response object//raise exception if any errors in response object
				{
					throw new AppException(response.Error.ErrorText, false, AppExceptionType.EFM);
				}
				return MapFirmTypeToFirm(response.Firm);// map response data ti firm object data and return.

			}
			catch (TimeoutException te)// this is to handle timeout exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				throw new Exception(
					"The state eFiling system has stopped responding. We cannot proceed. Your information has been saved as a draft. You may continue this filing later.",
					te);
			}
			catch (CommunicationException ce) // this is to handle communication exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, ce);
			}
			catch (Exception ex) // this is to handle general exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				if (ex.Message.ToLower().Contains("unknown error"))//if error message has unknown error throw it as technical issue.
				{
					throw new AppException("eFile manager is experiencing technical issues.  Please try again later.", true, AppExceptionType.EFM, ex, "GetFirm");
				}
				throw new AppException(ex.Message, true, AppExceptionType.EFM, ex, "GetFirm");
			}
			//finally
			//{
			//    try
			//    {
			//        if ((_efmFirmService) != null)
			//        {
			//            //((EfmFirmServiceClient)_efmFirmService).Close();// close efm firm service client connection
			//        }
			//    }
			//    catch (Exception exception)
			//    {
			//        throw Util.BuildWcfException((EfmFirmServiceClient) _efmFirmService, exception);
			//    }
			//}
		}
		/// <summary>
		/// This is the method to get attorney details from efm with user name and password
		/// </summary>
		/// <param name="username">username for authenticating the user</param>
		/// <param name="password">password for authenticating the user</param>
		/// <returns>returns  IEnumerable<Attorney> of attorney data</returns>
		public IEnumerable<AttorneyModel> GetAttorneys(string username, string password)
		{
			try
			{
				_efmFirmService = new EfmFirmServiceClient(); //create instance to firm service client
															  //add authentication details to the client object to interact with efm
				Util.AddAuthInfoToClient((EfmFirmServiceClient)_efmFirmService, username, password);
				//get response from efm
				var response = _efmFirmService.GetAttorneyList();
				if (response.Error.ErrorCode != "0")//raise exception if any errors in response object
				{
					throw new AppException(response.Error.ErrorText, false, AppExceptionType.EFM);
				}
				return MapAttorneyListResponseToAttorneys(response.Attorney);//map response data to attorney list and return
			}
			catch (TimeoutException te)// this is to handle timeout exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				throw new Exception(
					"The state eFiling system has stopped responding. We cannot proceed. Your information has been saved as a draft. You may continue this filing later.",
					te);
			}
			catch (CommunicationException ce) // this is to handle communication exceptions while interacting with EFM
			{
				throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, ce);
			}
			catch (Exception ex) // this is to handle general exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				if (ex.Message.ToLower().Contains("unknown error"))//if error message has unknown error throw it as technical issue.
				{
					throw new AppException("eFile manager is experiencing technical issues.  Please try again later.", true, AppExceptionType.EFM, ex);
				}
				throw new AppException(ex.Message, true, AppExceptionType.EFM, ex);
			}
			//finally
			//{
			//    try
			//    {
			//        if ((_efmFirmService) != null)
			//        {
			//            //((EfmFirmServiceClient)_efmFirmService).Close();// close efm firm service client connection
			//        }
			//    }
			//    catch (Exception exception)
			//    {
			//        throw Util.BuildWcfException((EfmFirmServiceClient) _efmFirmService, exception);
			//    }
			//}
		}
		/// <summary>
		/// This is the method to get attorney details from efm asynchronously with user name and password
		/// </summary>
		/// <param name="username">username for authenticating the user</param>
		/// <param name="password">password for authenticating the user</param>
		/// <returns>returns  IEnumerable<Attorney> of attorney data</returns>
		public async Task<IEnumerable<AttorneyModel>> GetAttorneysAsync(string username, string password)
		{

			try
			{

				//add authentication details to the client object to interact with efm
				Util.AddAuthInfoToClient((EfmFirmServiceClient)_efmFirmService, username, password);
				//get response from efm
				var response = await _efmFirmService.GetAttorneyListAsync();
				if (response.Error.ErrorCode != "0")//raise exception if any errors in response object
				{
					throw new AppException(response.Error.ErrorText, false, AppExceptionType.EFM);
				}

				return MapAttorneyListResponseToAttorneys(response.Attorney);//map response data to attorney list and return
			}
			catch (TimeoutException te)// this is to handle timeout exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				throw new Exception(
					"The state eFiling system has stopped responding. We cannot proceed. Your information has been saved as a draft. You may continue this filing later.",
					te);
			}
			catch (CommunicationException ce) // this is to handle communication exceptions while interacting with EFM
			{
				throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, ce);
			}
			catch (Exception ex) // this is to handle general exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				if (ex.Message.ToLower().Contains("unknown error"))//if error message has unknown error throw it as technical issue.
				{
					throw new AppException("eFile manager is experiencing technical issues.  Please try again later.", true, AppExceptionType.EFM, ex);
				}
				throw new AppException(ex.Message, true, AppExceptionType.EFM, ex);
			}
			//finally
			//{
			//    try
			//    {
			//        if ((_efmFirmService) != null)
			//        {
			//            //((EfmFirmServiceClient)_efmFirmService).Close();// close efm firm service client connection
			//        }
			//    }
			//    catch (Exception exception)
			//    {
			//        throw Util.BuildWcfException((EfmFirmServiceClient) _efmFirmService, exception);
			//    }
			//}
		}

		#endregion


		#region Filer
		/// <summary>
		/// This is the method to register filer details in efm which required filer data to save and admin details for authentication.
		/// </summary>
		/// <param name="filer">Filer object with data to save in efm</param>
		/// <param name="admin">admin filer details to interact with efm</param>
		/// <returns>true/false of registration status</returns>
		public bool RegisterFiler(FilerModel filer, FilerModel admin)
		{
			try
			{
				_efmFirmService = new EfmFirmServiceClient(); //create instance to firm service client
															  //add authentication details to the client object to interact with efm
				Util.AddAuthInfoToClient((EfmFirmServiceClient)_efmFirmService, admin.EmailAddress, admin.Password);
				//map filer details to register request type
				RegistrationRequestType requestType = MapFilerToRegisterRequestType(filer);
				requestType.RegistrationType = EFMFirmServices.RegistrationType.FirmAdminNewMember;
				requestType.Password = "1Password";  //put dummy password for now.
													 //get response from efm
				var response = _efmFirmService.RegisterUser(requestType);
				if (response.Error.ErrorCode != "0")//raise exception if any errors in response object
				{
					throw new AppException(response.Error.ErrorText, false, AppExceptionType.EFM);
				}
				//fill response data to in fielr object and return
				filer.EFMUserId = response.UserID;
				filer.Password = response.PasswordHash;

				return true;

			}
			catch (TimeoutException te)// this is to handle timeout exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				throw new Exception(
					"The state eFiling system has stopped responding. We cannot proceed. Your information has been saved as a draft. You may continue this filing later.",
					te);
			}
			catch (CommunicationException ce) // this is to handle communication exceptions while interacting with EFM
			{
				throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, ce);
			}
			catch (Exception ex) // this is to handle general exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				if (ex.Message.ToLower().Contains("unknown error"))//if error message has unknown error throw it as technical issue.
				{
					throw new AppException("eFile manager is experiencing technical issues.  Please try again later.", true, AppExceptionType.EFM, ex, "RegisterFiler");
				}
				throw new AppException(ex.Message, true, AppExceptionType.EFM, ex, "RegisterFiler");
			}
			finally
			{
				try
				{
					if ((_efmFirmService) != null)
					{
						((EfmFirmServiceClient)_efmFirmService).Close();// close efm firm service client connection
					}
				}
				catch (Exception exception)
				{// this is to handle general exceptions while closing efm objects
					throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, exception);
				}
			}
		}

		

		/// <summary>
		/// This is the method to get filers data from efm asynchronously
		/// </summary>
		/// <param name="adminEmail">email for authenticating the user</param>
		/// <param name="adminPassword">password for authenticating the user</param>
		/// <returns>returns  IEnumerable<Filer> of filers data</returns>
		public async Task<IEnumerable<FilerModel>> GetFilersAsync(string adminEmail, string adminPassword)
		{
			try
			{
				_efmFirmService = new EfmFirmServiceClient(); //create instance to firm service client
															  //add authentication details to the client object to interact with efm
				Util.AddAuthInfoToClient((EfmFirmServiceClient)_efmFirmService, adminEmail, adminPassword);
				List<FilerModel> filers = new List<FilerModel>();
				//get response from efm
				var response = await _efmFirmService.GetUserListAsync();
				if (response.Error.ErrorCode != "0")//raise exception if any errors in response object
				{
					throw new AppException(response.Error.ErrorText, false, AppExceptionType.EFM);
				}
				//read all users data from response object
				foreach (var userType in response.User)
				{
					//get complete details of filer and add to the filers list
					var getResponse = await _efmFirmService.GetUserAsync(new GetUserRequestType { UserID = userType.UserID });
					FilerModel filer = new FilerModel();
					MapGetUserResponseToFiler(getResponse.User, filer);
					filers.Add(filer);
				}
				return filers; //return filers data
			}
			catch (TimeoutException te)// this is to handle timeout exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				throw new Exception(
					"The state eFiling system has stopped responding. We cannot proceed. Your information has been saved as a draft. You may continue this filing later.",
					te);
			}
			catch (CommunicationException ce) // this is to handle communication exceptions while interacting with EFM
			{
				throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, ce);
			}
			catch (Exception ex) // this is to handle general exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				if (ex.Message.ToLower().Contains("unknown error"))//if error message has unknown error throw it as technical issue.
				{
					throw new AppException("eFile manager is experiencing technical issues.  Please try again later.", true, AppExceptionType.EFM, ex);
				}
				throw new AppException(ex.Message, true, AppExceptionType.EFM, ex);
			}
			finally
			{
				try
				{
					if ((_efmFirmService) != null)
					{
						((EfmFirmServiceClient)_efmFirmService).Close();// close efm firm service client connection
					}
				}
				catch (Exception exception)
				{// this is to handle general exceptions while closing efm objects
					throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, exception);
				}
			}
		}
		/// <summary>
		/// This is the method to get filers data from efm         /// </summary>
		/// <param name="adminEmail">email for authenticating the user</param>
		/// <param name="adminPassword">password for authenticating the user</param>
		/// <returns>returns  IEnumerable<Filer> of filers data</returns>
		public IEnumerable<FilerModel> GetFilers(string adminEmail, string adminPassword)
		{
			try
			{
				_efmFirmService = new EfmFirmServiceClient(); //create instance to firm service client
															  //add authentication details to the client object to interact with efm
				Util.AddAuthInfoToClient((EfmFirmServiceClient)_efmFirmService, adminEmail, adminPassword);
				List<FilerModel> filers = new List<FilerModel>();
				//get response from efm
				var response = _efmFirmService.GetUserList();
				/*var getAttorneyListResponse = _efmFirmService.GetAttorneyListAsync();
                if (getAttorneyListResponse.Result.Error.ErrorCode != "0")
                {
                    throw new AppException(getAttorneyListResponse.Result.Error.ErrorText, false, AppExceptionType.EFM);
                }
                await Task.WhenAll(new Task[] { response, getAttorneyListResponse});*/

				if (response.Error.ErrorCode != "0")//raise exception if any errors in response object
				{
					throw new AppException(response.Error.ErrorText, false, AppExceptionType.EFM);
				}
				//read all users data from response object
				foreach (var userType in response.User)
				{
					//get complete details of filer and add to the filers list
					var getResponse = _efmFirmService.GetUser(new GetUserRequestType { UserID = userType.UserID });
					FilerModel filer = new FilerModel();
					MapGetUserResponseToFiler(getResponse.User, filer);
					filers.Add(filer);
				}

				return filers; //return filers data

			}
			catch (TimeoutException te)// this is to handle timeout exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				throw new Exception(
					"The state eFiling system has stopped responding. We cannot proceed. Your information has been saved as a draft. You may continue this filing later.",
					te);
			}
			catch (CommunicationException ce) // this is to handle communication exceptions while interacting with EFM
			{
				throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, ce);
			}
			catch (Exception ex) // this is to handle general exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				if (ex.Message.ToLower().Contains("unknown error"))//if error message has unknown error throw it as technical issue.
				{
					throw new AppException("eFile manager is experiencing technical issues.  Please try again later.", true, AppExceptionType.EFM, ex);
				}
				throw new AppException(ex.Message, true, AppExceptionType.EFM, ex);
			}
			finally
			{
				try
				{
					if ((_efmFirmService) != null)
					{
						((EfmFirmServiceClient)_efmFirmService).Close();// close efm firm service client connection
					}
				}
				catch (Exception exception) // this is to handle general exceptions while closing efm objects connection
				{
					throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, exception);
				}
			}
		}

		/// <summary>
		/// This is the common method to map filers details in attorneys list
		/// </summary>
		/// <param name="users">filers information to map attorneys</param>
		/// <param name="attorneys">attorneys list to map</param>
		/// <returns>returns IEnumerable<Filer> of filers data with attached attorneys</returns>
		private IEnumerable<FilerModel> MergeFilerWithAttorney(IEnumerable<FilerModel> users, IEnumerable<AttorneyModel> attorneys)
		{
			//loop each filer in users list
			foreach (var filer in users)
			{
				//try to get the attoneys data of for the filer if any.
				var attorney = attorneys.FirstOrDefault(
						x =>
						x.FirstName == filer.FirstName &&
						x.LastName == filer.LastName &&
						x.MiddleName == filer.MiddleName);

				if (attorney != null) // attorney is not null assign to filer object
				{
					filer.AttoneyModel = attorney;
				}
			}
			return users;//return filers list after assigning attorneys data
		}
		/// <summary>
		/// This is the common method to update filer information in efm. Which required complete 
		/// filer details to update and admin details for authentication
		/// </summary>
		/// <param name="filer">filer details to update </param>
		/// <param name="admin"> admin details for authentication</param>
		public void UpdateFiler(FilerModel filer, FilerModel admin)
		{
			try
			{
				//get authentication email address, if both filer and admin are same take latest email address
				string authEmailAddress = admin.EmailAddress;
				if (filer.Id == admin.Id)
					authEmailAddress = filer.CurrentEmailAddress;

				_efmFirmService = new EfmFirmServiceClient(); //create instance to firm service client
															  //add authentication details to the client object to interact with efm
				Util.AddAuthInfoToClient((EfmFirmServiceClient)_efmFirmService, authEmailAddress, admin.Password);
				//get response from efm and map data to usertype object
				var response = _efmFirmService.UpdateUser(new UpdateUserRequestType
				{
					User = MapFilerToUserType(filer)
				});
				if (response.Error.ErrorCode != "0")//raise exception if any errors in response object
				{
					throw new AppException(response.Error.ErrorText, false, AppExceptionType.EFM);
				}


				//re-initializing the FirmServiceClient with updated emailAddress.
				if (admin.Id == filer.Id)
				{
					_efmFirmService = new EfmFirmServiceClient(); //create instance to firm service client
																  //add authentication details to the client object to interact with efm
					Util.AddAuthInfoToClient((EfmFirmServiceClient)_efmFirmService, filer.EmailAddress, admin.Password);
				}

				//Change begins - nithin - 07/31/2014
				//Change - moved this code block down to execute in the context of updated email address. 
				if (filer.IsAttorney)
				{
					var attorneyResponse = _efmFirmService.UpdateAttorney(new UpdateAttorneyRequestType
					{
						Attorney = MapAttorneyToAttorneyType(filer.AttoneyModel)
					});
					if (attorneyResponse.Error.ErrorCode != "0")//raise exception if any errors in attorneyResponse object
					{
						throw new AppException(response.Error.ErrorText, false, AppExceptionType.EFM);
					}
				}
				//Change ends - nithin - 07/31/2014

				//UnCommented as we are updating the user info with roles
				if (!filer.RolesEnum.Contains(FilerRole.Individual))//Individual filer cant update the roles. so removing the update roles
					UpdateFilerRoles(filer);

			}
			catch (TimeoutException te)// this is to handle timeout exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				throw new Exception(
					"The state eFiling system has stopped responding. We cannot proceed. Your information has been saved as a draft. You may continue this filing later.",
					te);
			}
			catch (CommunicationException ce) // this is to handle communication exceptions while interacting with EFM
			{
				throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, ce);
			}
			catch (Exception ex) // this is to handle general exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				if (ex.Message.ToLower().Contains("unknown error"))//if error message has unknown error throw it as technical issue.
				{
					throw new AppException("eFile manager is experiencing technical issues.  Please try again later.", true, AppExceptionType.EFM, ex);
				}
				throw new AppException(ex.Message, true, AppExceptionType.EFM, ex);
			}
			finally
			{
				try
				{
					if ((_efmFirmService) != null)
					{
						((EfmFirmServiceClient)_efmFirmService).Close();// close efm firm service client connection
					}
				}
				catch (Exception exception)
				{// this is to handle general exceptions while closing efm objects
					throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, exception);
				}
			}
		}
		/// <summary>
		/// This is the common method to update filer details in efm 
		/// </summary>
		/// <param name="filer">filer object with data to update</param>
		/// <returns>returns true/false of updated status</returns>
		public bool UpdateRoles(FilerModel filer)
		{
			try
			{
				_efmFirmService = new EfmFirmServiceClient(); //create instance to firm service client
															  //add authentication details to the client object to interact with efm
				Util.AddAuthInfoToClient((EfmFirmServiceClient)_efmFirmService, filer.EmailAddress, filer.Password);
				//update filer rolers and return true status
				UpdateFilerRoles(filer);
				return true;
			}
			catch (TimeoutException te)// this is to handle timeout exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				throw new Exception(
					"The state eFiling system has stopped responding. We cannot proceed. Your information has been saved as a draft. You may continue this filing later.",
					te);
			}
			catch (CommunicationException ce) // this is to handle communication exceptions while interacting with EFM
			{
				throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, ce);
			}
			catch (Exception ex) // this is to handle general exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				if (ex.Message.ToLower().Contains("unknown error"))//if error message has unknown error throw it as technical issue.
				{
					throw new AppException("eFile manager is experiencing technical issues.  Please try again later.", true, AppExceptionType.EFM, ex);
				}
				throw new AppException(ex.Message, true, AppExceptionType.EFM, ex);
			}
			finally
			{
				try
				{
					if ((_efmFirmService) != null)
					{
						((EfmFirmServiceClient)_efmFirmService).Close();// close efm firm service client connection
					}
				}
				catch (Exception exception)// this is to handle general exceptions while closing efm objects
				{
					throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, exception);
				}
			}
		}
		/// <summary>
		/// This is the common method to delete filer details in efm , 
		/// which required admin details also for authentication for delete filer details
		/// </summary>
		/// <param name="filer">filer object with data to delete</param>
		/// <returns>returns true/false of deleted status</returns>
		public void DeleteFiler(FilerModel filer, FilerModel admin)
		{
			try
			{
				_efmFirmService = new EfmFirmServiceClient(); //create instance to firm service client
															  //add authentication details to the client object to interact with efm
				Util.AddAuthInfoToClient((EfmFirmServiceClient)_efmFirmService, admin.EmailAddress, admin.Password);
				//get response from efm
				var response = _efmFirmService.RemoveUser(new RemoveUserRequestType { UserID = filer.EFMUserId });
				if (response.Error.ErrorCode != "0")//raise exception if any errors in response object
				{
					throw new AppException(response.Error.ErrorText, false, AppExceptionType.EFM);
				}
				//if filer is attorney type, delete associated attorneys also
				if (filer.IsAttorney)
				{
					var attorneyResponse = _efmFirmService.RemoveAttorney(new RemoveAttorneyRequestType { AttorneyID = filer.AttoneyModel.AttorneyEFMID });
					if (attorneyResponse.Error.ErrorCode != "0")
					{
						throw new AppException(response.Error.ErrorText, false, AppExceptionType.EFM);
					}
				}

			}
			catch (TimeoutException te)// this is to handle timeout exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				throw new Exception(
					"The state eFiling system has stopped responding. We cannot proceed. Your information has been saved as a draft. You may continue this filing later.",
					te);
			}
			catch (CommunicationException ce) // this is to handle communication exceptions while interacting with EFM
			{
				throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, ce);
			}
			catch (Exception ex) // this is to handle general exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				if (ex.Message.ToLower().Contains("unknown error"))//if error message has unknown error throw it as technical issue.
				{
					throw new AppException("eFile manager is experiencing technical issues.  Please try again later.", true, AppExceptionType.EFM, ex);
				}
				throw new AppException(ex.Message, true, AppExceptionType.EFM, ex);
			}
			finally
			{
				try
				{
					if ((_efmFirmService) != null)
					{
						((EfmFirmServiceClient)_efmFirmService).Close();// close efm firm service client connection
					}
				}
				catch (Exception exception)
				{
					throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, exception);// this is to handle general exceptions while closing efm objects
				}
			}
		}
		/// <summary>
		/// This is the common method to delete filer details in efm , 
		/// which required admin details also for authentication for delete filer details
		/// </summary>
		/// <param name="filer">filer object with data to delete</param>
		/// <returns>returns true/false of deleted status</returns>
		public void DeleteFiler(FilerModel filer, FilerModel admin, string StateKeyConfig)
		{
			try
			{
				//OpenConnection(StateKeyConfig); //create instance to firm service client
												//add authentication details to the client object to interact with efm
				Util.AddAuthInfoToClient((EfmFirmServiceClient)_efmFirmService, admin.EmailAddress, admin.Password);
				//get response from efm
				var response = _efmFirmService.RemoveUser(new RemoveUserRequestType { UserID = filer.EFMUserId });
				if (response.Error.ErrorCode != "0")//raise exception if any errors in response object
				{
					throw new AppException(response.Error.ErrorText, false, AppExceptionType.EFM);
				}
				//if filer is attorney type, delete associated attorneys also
				if (filer.IsAttorney)
				{
					var attorneyResponse = _efmFirmService.RemoveAttorney(new RemoveAttorneyRequestType { AttorneyID = filer.AttoneyModel.AttorneyEFMID });
					if (attorneyResponse.Error.ErrorCode != "0")
					{
						throw new AppException(response.Error.ErrorText, false, AppExceptionType.EFM);
					}
				}

			}
			catch (TimeoutException te)// this is to handle timeout exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				throw new Exception(
					"The state eFiling system has stopped responding. We cannot proceed. Your information has been saved as a draft. You may continue this filing later.",
					te);
			}
			catch (CommunicationException ce) // this is to handle communication exceptions while interacting with EFM
			{
				throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, ce);
			}
			catch (Exception ex) // this is to handle general exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				if (ex.Message.ToLower().Contains("unknown error"))//if error message has unknown error throw it as technical issue.
				{
					throw new AppException("eFile manager is experiencing technical issues.  Please try again later.", true, AppExceptionType.EFM, ex);
				}
				throw new AppException(ex.Message, true, AppExceptionType.EFM, ex);
			}
			finally
			{
				//CloseConnection();
			}
		}
		/// <summary>
		/// This is the common method to resend user activation email of filetime
		/// </summary>
		/// <param name="filer">filer object to know user data</param>
		/// <param name="admin">admin details for authentication to send emails</param>
		/// <returns>returns true/false of sending email status</returns>
		public bool ResendActivationEmail(FilerModel filer, FilerModel admin)
		{
			try
			{
				_efmFirmService = new EfmFirmServiceClient(); //create instance to firm service client
															  //add authentication details to the client object to interact with efm
				Util.AddAuthInfoToClient((EfmFirmServiceClient)_efmFirmService, admin.EmailAddress, admin.Password);
				if (!filer.IsActive)
				{
					//get response from efm
					var response = _efmFirmService.ResendActivationEmail(new ResendActivationEmailRequestType
					{
						UserID = filer.EFMUserId
					});
					if (response.Error.ErrorCode != "0")//raise exception if any errors in response object
					{
						throw new AppException(response.Error.ErrorText, false, AppExceptionType.EFM);
					}
				}
				else
				{   //raise exception if filer is already active
					throw new AppException("Filer is already Active.");
				}

				return true;

			}
			catch (TimeoutException te)// this is to handle timeout exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				throw new Exception(
					"The state eFiling system has stopped responding. We cannot proceed. Your information has been saved as a draft. You may continue this filing later.",
					te);
			}
			catch (CommunicationException ce) // this is to handle communication exceptions while interacting with EFM
			{
				throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, ce);
			}
			catch (Exception ex) // this is to handle general exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				if (ex.Message.ToLower().Contains("unknown error"))//if error message has unknown error throw it as technical issue.
				{
					throw new AppException("eFile manager is experiencing technical issues.  Please try again later.", true, AppExceptionType.EFM, ex);
				}
				throw new AppException(ex.Message, true, AppExceptionType.EFM, ex);
			}
			finally
			{
				try
				{
					if ((_efmFirmService) != null)
					{
						((EfmFirmServiceClient)_efmFirmService).Close();// close efm firm service client connection
					}
				}
				catch (Exception exception)
				{
					throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, exception);// this is to handle general exceptions while closing efm objects
				}
			}
		}
		/// <summary>
		/// This is the common method to resend user activation email of filetime
		/// </summary>
		/// <param name="filer">filer object to know user data</param>      
		/// <returns>returns true/false of sending email status</returns>
		public bool ResendActivationEmail(FilerModel filer)
		{
			try
			{
				_efmFirmService = new EfmFirmServiceClient(); //create instance to firm service client
															  //get response from efm
				var response =
				_efmFirmService.ResendActivationEmail(new ResendActivationEmailRequestType
				{
					UserID = filer.EFMUserId
				});
				if (response.Error.ErrorCode != "0")//raise exception if any errors in response object
				{
					throw new AppException(response.Error.ErrorText, false, AppExceptionType.EFM);
				}


				return true;

			}
			catch (TimeoutException te)// this is to handle timeout exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				throw new Exception(
					"The state eFiling system has stopped responding. We cannot proceed. Your information has been saved as a draft. You may continue this filing later.",
					te);
			}
			catch (CommunicationException ce) // this is to handle communication exceptions while interacting with EFM
			{
				throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, ce);
			}
			catch (Exception ex) // this is to handle general exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				if (ex.Message.ToLower().Contains("unknown error"))//if error message has unknown error throw it as technical issue.
				{
					throw new AppException("eFile manager is experiencing technical issues.  Please try again later.", true, AppExceptionType.EFM, ex);
				}
				throw new AppException(ex.Message, true, AppExceptionType.EFM, ex);
			}
			finally
			{
				try
				{
					if ((_efmFirmService) != null)
					{
						((EfmFirmServiceClient)_efmFirmService).Close();// close efm firm service client connection
					}
				}
				catch (Exception exception)
				{
					throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, exception);// this is to handle general exceptions while closing efm objects
				}
			}
		}
		/// <summary>
		/// This is the method to reset filer password. which required admin details for authentication and user data to update
		/// </summary>
		/// <param name="filer">filer details for email address and efm user id </param>
		/// <param name="password">new password details to update</param>
		/// <param name="admin">admin details for authentication</param>
		/// <returns>returns PasswordHash details</returns>
		public string ResetUserPassword(FilerModel filer, string password, FilerModel admin)
		{
			try
			{
				_efmFirmService = new EfmFirmServiceClient(); //create instance to firm service client
															  //add authentication details to the client object to interact with efm
				Util.AddAuthInfoToClient((EfmFirmServiceClient)_efmFirmService, admin.EmailAddress, admin.Password);
				//Map filer data to update and get response from efm
				var response =
					_efmFirmService.ResetUserPassword(new ResetUserPasswordRequestType
					{
						Email = filer.EmailAddress,
						Password = password,
						UserID = filer.EFMUserId
					});
				if (response.Error.ErrorCode != "0")//raise exception if any errors in response object
				{
					throw new AppException(response.Error.ErrorText, false, AppExceptionType.EFM);
				}
				return response.PasswordHash; //return PasswordHash text

			}
			catch (TimeoutException te)// this is to handle timeout exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				throw new Exception(
					"The state eFiling system has stopped responding. We cannot proceed. Your information has been saved as a draft. You may continue this filing later.",
					te);
			}
			catch (CommunicationException ce) // this is to handle communication exceptions while interacting with EFM
			{
				throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, ce);
			}
			catch (Exception ex) // this is to handle general exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				if (ex.Message.ToLower().Contains("unknown error"))//if error message has unknown error throw it as technical issue.
				{
					throw new AppException("eFile manager is experiencing technical issues.  Please try again later.", true, AppExceptionType.EFM, ex);
				}
				throw new AppException(ex.Message, true, AppExceptionType.EFM, ex);
			}
			finally
			{
				try
				{
					if ((_efmFirmService) != null)
					{
						((EfmFirmServiceClient)_efmFirmService).Close();// close efm firm service client connection
					}
				}
				catch (Exception exception)
				{
					throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, exception);// this is to handle general exceptions while closing efm objects
				}
			}
		}





		#endregion


		#region Payment Account
		/// <summary>
		/// This is the common method to get payment account details of a filer in efm
		/// </summary>
		/// <param name="filer">Filer object wiht data to authenticate</param>
		/// <returns>returns IEnumerable<PaymentAccount> of payment accounts</returns>
		public IEnumerable<PaymentAccountModel> GetPaymentAccounts(FilerModel filer)
		{
			try
			{
				_efmFirmService = new EfmFirmServiceClient(); //create instance to firm service client
															  //add authentication details to the client object to interact with efm
				Util.AddAuthInfoToClient((EfmFirmServiceClient)_efmFirmService, filer.EmailAddress, filer.Password);
				//get response from efm for all payment accounts
				var response = _efmFirmService.GetPaymentAccountList();
				if (response.Error.ErrorCode != "0")//raise exception if any errors in response object
				{
					throw new AppException(response.Error.ErrorText, false, AppExceptionType.EFM);
				}
				return MapPaymentAccountTypeListToPaymentAccount(response.PaymentAccount);//map response data and return

			}
			catch (TimeoutException te)// this is to handle timeout exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				throw new Exception(
					"The state eFiling system has stopped responding. We cannot proceed. Your information has been saved as a draft. You may continue this filing later.",
					te);
			}
			catch (CommunicationException ce) // this is to handle communication exceptions while interacting with EFM
			{
				throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, ce);
			}
			catch (Exception ex) // this is to handle general exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				if (ex.Message.ToLower().Contains("unknown error"))//if error message has unknown error throw it as technical issue.
				{
					throw new AppException("eFile manager is experiencing technical issues.  Please try again later.", true, AppExceptionType.EFM, ex);
				}
				throw new AppException(ex.Message, true, AppExceptionType.EFM, ex);
			}
			finally
			{
				try
				{
					if ((_efmFirmService) != null)
					{
						((EfmFirmServiceClient)_efmFirmService).Close();// close efm firm service client connection
					}
				}
				catch (Exception exception)
				{
					throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, exception);// this is to handle general exceptions while closing efm objects
				}
			}
		}

		/// <summary>
		/// This is the common method to get payment account details of a filer in efm
		/// </summary>
		/// <param name="filer">Filer object wiht data to authenticate</param>
		/// <returns>returns IEnumerable<PaymentAccount> of payment accounts</returns>
		public IEnumerable<PaymentAccountModel> GetPaymentAccounts(FilerModel filer, string StateKeyConfig)
		{
			try
			{
			//	OpenConnection(StateKeyConfig); //create instance to firm service client
												//add authentication details to the client object to interact with efm
				Util.AddAuthInfoToClient((EfmFirmServiceClient)_efmFirmService, filer.EmailAddress, filer.Password);
				//get response from efm for all payment accounts
				var response = _efmFirmService.GetPaymentAccountList();
				if (response.Error.ErrorCode != "0")//raise exception if any errors in response object
				{
					throw new AppException(response.Error.ErrorText, false, AppExceptionType.EFM);
				}
				return MapPaymentAccountTypeListToPaymentAccount(response.PaymentAccount);//map response data and return
			}
			catch (TimeoutException te)// this is to handle timeout exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				throw new Exception(
					"The state eFiling system has stopped responding. We cannot proceed. Your information has been saved as a draft. You may continue this filing later.",
					te);
			}
			catch (CommunicationException ce) // this is to handle communication exceptions while interacting with EFM
			{
				throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, ce);
			}
			catch (Exception ex) // this is to handle general exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				if (ex.Message.ToLower().Contains("unknown error"))//if error message has unknown error throw it as technical issue.
				{
					throw new AppException("eFile manager is experiencing technical issues.  Please try again later.", true, AppExceptionType.EFM, ex);
				}
				throw new AppException(ex.Message, true, AppExceptionType.EFM, ex);
			}
			finally
			{
				try
				{
					if ((_efmFirmService) != null)
					{
						((EfmFirmServiceClient)_efmFirmService).Close();// close efm firm service client connection
					}
				}
				catch (Exception exception)
				{
					throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, exception);// this is to handle general exceptions while closing efm objects
				}
			}
		}
		/// <summary>
		/// This is the common method to get payment account details of a filer in efm asynchronously
		/// </summary>
		/// <param name="filer">Filer object wiht data to authenticate</param>
		/// <returns>returns IEnumerable<PaymentAccount> of payment accounts</returns>
		public async Task<IEnumerable<PaymentAccountModel>> GetPaymentAccountsAsync(FilerModel filer)
		{
			try
			{
				if (((EfmFirmServiceClient)_efmFirmService).State != CommunicationState.Opened)
				{
					_efmFirmService = new EfmFirmServiceClient(); //create instance to firm service client
				}
				//add authentication details to the client object to interact with efm
				Util.AddAuthInfoToClient((EfmFirmServiceClient)_efmFirmService, filer.EmailAddress, filer.Password);
				//get response from efm
				var response = await _efmFirmService.GetPaymentAccountListAsync();
				if (response.Error.ErrorCode != "0")//raise exception if any errors in response object
				{
					throw new AppException(response.Error.ErrorText, false, AppExceptionType.EFM);
				}
				return MapPaymentAccountTypeListToPaymentAccount(response.PaymentAccount);//map response data and return

			}
			catch (TimeoutException te)// this is to handle timeout exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				throw new Exception(
					"The state eFiling system has stopped responding. We cannot proceed. Your information has been saved as a draft. You may continue this filing later.",
					te);
			}
			catch (CommunicationException ce) // this is to handle communication exceptions while interacting with EFM
			{
				throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, ce);
			}
			catch (Exception ex) // this is to handle general exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				if (ex.Message.ToLower().Contains("unknown error"))//if error message has unknown error throw it as technical issue.
				{
					throw new AppException("eFile manager is experiencing technical issues.  Please try again later.", true, AppExceptionType.EFM, ex);
				}
				throw new AppException(ex.Message, true, AppExceptionType.EFM, ex);
			}
			//finally
			//{
			//    try
			//    {
			//        if ((_efmFirmService) != null)
			//        {
			//            //((EfmFirmServiceClient)_efmFirmService).Close();// close efm firm service client connection
			//        }
			//    }
			//    catch (Exception exception)
			//    {
			//        throw Util.BuildWcfException((EfmFirmServiceClient) _efmFirmService, exception);
			//    }
			//}
		}
		/// <summary>
		/// This is the common private method to map PaymentAccountType objects data to PaymentAccount objects data
		/// </summary>
		/// <param name="paymentAccountTypes">PaymentAccountType objects data to map</param>
		/// <returns>returns  IEnumerable<PaymentAccount> of  PaymentAccounts </returns>
		private IEnumerable<PaymentAccountModel> MapPaymentAccountTypeListToPaymentAccount(IEnumerable<PaymentAccountType> paymentAccountTypes)
		{
			if (paymentAccountTypes == null)//return empty list if paymentAccountTypes is null to map
			{
				return new List<PaymentAccountModel>();
			}
			int? cardLast4Number = null;
			return paymentAccountTypes.Select(paymentAccountType => new PaymentAccountModel
			{
				//assign data to all required properties
				CardHolderName = paymentAccountType.AccountName,
				CardLast4Numbers = !string.IsNullOrEmpty(paymentAccountType.CardLast4) ? Convert.ToInt32(paymentAccountType.CardLast4) : cardLast4Number,
				CardToken = paymentAccountType.AccountToken,
				CardType = paymentAccountType.CardType,
				EFMId = paymentAccountType.PaymentAccountID,
				AccountName = paymentAccountType.AccountName,
				ExpirationMonth = paymentAccountType.CardMonth.HasValue ? paymentAccountType.CardMonth.Value : 0,
				ExpirationYear = paymentAccountType.CardYear.HasValue ? paymentAccountType.CardYear.Value : 0,
				Active = paymentAccountType.Active,
				Type = paymentAccountType.PaymentAccountTypeCode == "CC" ? TypeOfPayment.CreditCard : (paymentAccountType.PaymentAccountTypeCode == "WV" ? TypeOfPayment.Waiver : TypeOfPayment.BankAccount)
			});

		}
		/// <summary>
		/// This is the common method to add payment account details of a firm in efm
		/// </summary>
		/// <param name="paymentaccount">payment account details to save</param>
		/// <param name="filer">filer details for authentication</param>
		public void AddPaymentAccont(PaymentAccountModel paymentaccount, FilerModel filer)
		{
			try
			{
				_efmFirmService = new EfmFirmServiceClient(); //create instance to firm service client
															  //add authentication details to the client object to interact with efm
				Util.AddAuthInfoToClient((EfmFirmServiceClient)_efmFirmService, filer.EmailAddress, filer.Password);
				//get response from efm for paymentaccount creation
				var response = _efmFirmService.CreatePaymentAccount(new CreatePaymentAccountRequestType
				{
					PaymentAccount = MapPaymentAccountToPaymentAccountType(paymentaccount)
				});
				if (response.Error.ErrorCode != "0")//raise exception if any errors in response object
				{
					throw new AppException(response.Error.ErrorText, false, AppExceptionType.EFM);
				}
				paymentaccount.EFMId = response.PaymentAccountID;//update efmid 

			}
			catch (TimeoutException te)// this is to handle timeout exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				throw new Exception(
					"The state eFiling system has stopped responding. We cannot proceed. Your information has been saved as a draft. You may continue this filing later.",
					te);
			}
			catch (CommunicationException ce) // this is to handle communication exceptions while interacting with EFM
			{
				throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, ce);
			}
			catch (Exception ex) // this is to handle general exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				if (ex.Message.ToLower().Contains("unknown error"))//if error message has unknown error throw it as technical issue.
				{
					throw new AppException("eFile manager is experiencing technical issues.  Please try again later.", true, AppExceptionType.EFM, ex);
				}
				throw new AppException(ex.Message, true, AppExceptionType.EFM, ex);
			}
			finally
			{
				try
				{
					if ((_efmFirmService) != null)
					{
						((EfmFirmServiceClient)_efmFirmService).Close();// close efm firm service client connection
					}
				}
				catch (Exception exception)
				{
					throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, exception);// this is to handle general exceptions while closing efm objects
				}
			}
		}

		/// <summary>
		/// This is the common method to delete payment account details of a firm in efm
		/// </summary>
		/// <param name="paymentaccount">payment account details to save</param>
		/// <param name="filer">filer details for authentication</param>
		public void DeletePaymentAccount(string paymentAccountId, FilerModel admin)
		{
			try
			{
				_efmFirmService = new EfmFirmServiceClient(); //create instance to firm service client
															  //add authentication details to the client object to interact with efm
				Util.AddAuthInfoToClient((EfmFirmServiceClient)_efmFirmService, admin.EmailAddress, admin.Password);
				//get response from efm of removal action
				var response =
					_efmFirmService.RemovePaymentAccount(new RemovePaymentAccountRequestType
					{
						PaymentAccountID = paymentAccountId
					});
				if (response.Error.ErrorCode != "0")//raise exception if any errors in response object
				{
					throw new AppException(response.Error.ErrorText, false, AppExceptionType.EFM);
				}
			}
			catch (TimeoutException te)// this is to handle timeout exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				throw new Exception(
					"The state eFiling system has stopped responding. We cannot proceed. Your information has been saved as a draft. You may continue this filing later.",
					te);
			}
			catch (CommunicationException ce) // this is to handle communication exceptions while interacting with EFM
			{
				throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, ce);
			}
			catch (Exception ex) // this is to handle general exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				if (ex.Message.ToLower().Contains("unknown error"))//if error message has unknown error throw it as technical issue.
				{
					throw new AppException("eFile manager is experiencing technical issues.  Please try again later.", true, AppExceptionType.EFM, ex);
				}
				throw new AppException(ex.Message, true, AppExceptionType.EFM, ex);
			}
			finally
			{
				try
				{
					if ((_efmFirmService) != null)
					{
						((EfmFirmServiceClient)_efmFirmService).Close();// close efm firm service client connection
					}
				}
				catch (Exception exception)
				{// this is to handle general exceptions while closing efm objects
					throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, exception);
				}
			}
		}


		/// <summary>
		/// This is the common method to get payment account details of a firm in efm
		/// </summary>
		/// <param name="paymentaccount">payment account details to save</param>
		/// <param name="filer">filer details for authentication</param>
		public PaymentAccountModel GetPaymentAccount(string paymentAccountId, FilerModel admin)
		{
			try
			{
				_efmFirmService = new EfmFirmServiceClient(); //create instance to firm service client
															  //add authentication details to the client object to interact with efm
				Util.AddAuthInfoToClient((EfmFirmServiceClient)_efmFirmService, admin.EmailAddress, admin.Password);
				//get response from efm of removal action
				var response =
					_efmFirmService.GetPaymentAccount(new GetPaymentAccountRequestType
					{
						PaymentAccountID = paymentAccountId
					});
				if (response.Error.ErrorCode != "0")//raise exception if any errors in response object
				{
					throw new AppException(response.Error.ErrorText, false, AppExceptionType.EFM);
				}
				else
				{
					int? cardLast4Number = null;
					return new PaymentAccountModel()
					{
						//assign data to all required properties
						CardHolderName = response.PaymentAccount.AccountName,
						CardLast4Numbers = !string.IsNullOrEmpty(response.PaymentAccount.CardLast4) ? Convert.ToInt32(response.PaymentAccount.CardLast4) : cardLast4Number,
						CardToken = response.PaymentAccount.AccountToken,
						CardType = response.PaymentAccount.CardType,
						EFMId = response.PaymentAccount.PaymentAccountID,
						AccountName = response.PaymentAccount.AccountName,
						Active = response.PaymentAccount.Active,
						Type = response.PaymentAccount.PaymentAccountTypeCode == "CC" ? TypeOfPayment.CreditCard : (response.PaymentAccount.PaymentAccountTypeCode == "WV" ? TypeOfPayment.Waiver : TypeOfPayment.BankAccount)
					};
				}

			}
			catch (TimeoutException te)// this is to handle timeout exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				throw new Exception(
					"The state eFiling system has stopped responding. We cannot proceed. Your information has been saved as a draft. You may continue this filing later.",
					te);
			}
			catch (CommunicationException ce) // this is to handle communication exceptions while interacting with EFM
			{
				throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, ce);
			}
			catch (Exception ex) // this is to handle general exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				if (ex.Message.ToLower().Contains("unknown error"))//if error message has unknown error throw it as technical issue.
				{
					throw new AppException("eFile manager is experiencing technical issues.  Please try again later.", true, AppExceptionType.EFM, ex);
				}
				throw new AppException(ex.Message, true, AppExceptionType.EFM, ex);
			}
			finally
			{
				try
				{
					if ((_efmFirmService) != null)
					{
						((EfmFirmServiceClient)_efmFirmService).Close();// close efm firm service client connection
					}
				}
				catch (Exception exception)
				{// this is to handle general exceptions while closing efm objects
					throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, exception);
				}
			}
		}

		#endregion


		#region Global Payment Account
		/// <summary>
		/// This is the common method to add global payment account details of a firm in efm. 
		/// </summary>
		/// <param name="paymentaccount">PaymentAccount details to save</param>
		public void AddGlobalPaymentAccount(PaymentAccountModel paymentaccount)
		{
			try
			{
				_efmFirmService = new EfmFirmServiceClient(); //create instance to firm service client
															  //get response from efm
				var response = _efmFirmService.CreateGlobalPaymentAccount(new CreatePaymentAccountRequestType()
				{
					PaymentAccount = MapPaymentAccountToPaymentAccountType(paymentaccount)
				});
				if (response.Error.ErrorCode != "0")//raise exception if any errors in response object
				{
					throw new AppException(response.Error.ErrorText, false, AppExceptionType.EFM);
				}
				paymentaccount.EFMId = response.PaymentAccountID;//update efm id

			}
			catch (TimeoutException te)// this is to handle timeout exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				throw new Exception(
					"The state eFiling system has stopped responding. We cannot proceed. Your information has been saved as a draft. You may continue this filing later.",
					te);
			}
			catch (CommunicationException ce) // this is to handle communication exceptions while interacting with EFM
			{
				throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, ce);
			}
			catch (Exception ex) // this is to handle general exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				if (ex.Message.ToLower().Contains("unknown error"))//if error message has unknown error throw it as technical issue.
				{
					throw new AppException("eFile manager is experiencing technical issues.  Please try again later.", true, AppExceptionType.EFM, ex);
				}
				throw new AppException(ex.Message, true, AppExceptionType.EFM, ex);
			}
			finally
			{
				try
				{
					if ((_efmFirmService) != null)
					{
						((EfmFirmServiceClient)_efmFirmService).Close();// close efm firm service client connection
					}
				}
				catch (Exception exception)
				{// this is to handle general exceptions while closing efm objects
					throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, exception);
				}
			}
		}
		// <summary>
		/// This is the common method to add global payment account details of a firm for particulat state in efm. 
		/// </summary>
		/// <param name="paymentaccount">PaymentAccount details to save</param>
		public void AddGlobalPaymentAccountWithStateKey(PaymentAccountModel paymentaccount)
		{
			try
			{
				//assign data to CreatePaymentAccountRequestType and call efm service and get response from efm 
				var response = _efmFirmService.CreateGlobalPaymentAccount(new CreatePaymentAccountRequestType()
				{
					PaymentAccount = MapPaymentAccountToPaymentAccountType(paymentaccount)
				});
				if (response.Error.ErrorCode != "0")//raise exception if any errors in response object
				{
					throw new AppException(response.Error.ErrorText, false, AppExceptionType.EFM);
				}
				paymentaccount.EFMId = response.PaymentAccountID;//update efm id

			}
			catch (TimeoutException te)// this is to handle timeout exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				throw new Exception(
					"The state eFiling system has stopped responding. We cannot proceed. Your information has been saved as a draft. You may continue this filing later.",
					te);
			}
			catch (CommunicationException ce) // this is to handle communication exceptions while interacting with EFM
			{
				throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, ce);
			}
			catch (Exception ex) // this is to handle general exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				if (ex.Message.ToLower().Contains("unknown error"))//if error message has unknown error throw it as technical issue.
				{
					throw new AppException("eFile manager is experiencing technical issues.  Please try again later.", true, AppExceptionType.EFM, ex);
				}
				throw new AppException(ex.Message, true, AppExceptionType.EFM, ex);
			}
			//finally
			//{

			//    //if ((_efmFirmService) != null)
			//    //{
			//    //    //((EfmFirmServiceClient) _efmFirmService).Close();// close efm firm service client connection
			//    //}
			//}
		}

		// <summary>
		/// This is the common method to add global payment account details of a firm for particulat state in efm. 
		/// </summary>
		/// <param name="paymentAccountId">to get PaymentAccount details to delete</param>
		public void DeleteGlobalPaymentAccount(string paymentAccountId)
		{
			try
			{
				_efmFirmService = new EfmFirmServiceClient(); //create instance to firm service client
															  //get response from efm
				var response =
					_efmFirmService.RemoveGlobalPaymentAccount(new RemovePaymentAccountRequestType
					{
						PaymentAccountID = paymentAccountId
					});

				if (response.Error.ErrorCode != "0")//raise exception if any errors in response object
				{
					throw new AppException(response.Error.ErrorText, false, AppExceptionType.EFM);
				}
			}
			catch (TimeoutException te)// this is to handle timeout exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				throw new Exception(
					"The state eFiling system has stopped responding. We cannot proceed. Your information has been saved as a draft. You may continue this filing later.",
					te);
			}
			catch (CommunicationException ce) // this is to handle communication exceptions while interacting with EFM
			{
				throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, ce);
			}
			catch (Exception ex) // this is to handle general exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				if (ex.Message.ToLower().Contains("unknown error"))//if error message has unknown error throw it as technical issue.
				{
					throw new AppException("eFile manager is experiencing technical issues.  Please try again later.", true, AppExceptionType.EFM, ex);
				}
				throw new AppException(ex.Message, true, AppExceptionType.EFM, ex);
			}
			finally
			{
				try
				{
					if ((_efmFirmService) != null)
					{
						((EfmFirmServiceClient)_efmFirmService).Close();// close efm firm service client connection
					}
				}
				catch (Exception exception)
				{// this is to handle general exceptions while closing efm objects
					throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, exception);
				}
			}
		}


		/// <summary>
		/// /
		/// </summary>
		public void GetGlobalPaymentAccountList()
		{
			try
			{
				_efmFirmService = new EfmFirmServiceClient(); //create instance to firm service client
															  //get response from efm
				var response =
					_efmFirmService.GetGlobalPaymentAccountList();

				if (response.Error.ErrorCode != "0")//raise exception if any errors in response object
				{
					throw new AppException(response.Error.ErrorText, false, AppExceptionType.EFM);
				}
			}
			catch (TimeoutException te)// this is to handle timeout exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				throw new Exception(
					"The state eFiling system has stopped responding. We cannot proceed. Your information has been saved as a draft. You may continue this filing later.",
					te);
			}
			catch (CommunicationException ce) // this is to handle communication exceptions while interacting with EFM
			{
				throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, ce);
			}
			catch (Exception ex) // this is to handle general exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				if (ex.Message.ToLower().Contains("unknown error"))//if error message has unknown error throw it as technical issue.
				{
					throw new AppException("eFile manager is experiencing technical issues.  Please try again later.", true, AppExceptionType.EFM, ex);
				}
				throw new AppException(ex.Message, true, AppExceptionType.EFM, ex);
			}
			finally
			{
				try
				{
					if ((_efmFirmService) != null)
					{
						((EfmFirmServiceClient)_efmFirmService).Close();// close efm firm service client connection
					}
				}
				catch (Exception exception)
				{// this is to handle general exceptions while closing efm objects
					throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, exception);
				}
			}
		}
		#endregion

		#region Service Contacts
		/// <summary>
		/// This is the method to get service contacts of a filer from efm
		/// </summary>
		/// <param name="filer">filer details to authenticate and fetch the data</param>
		/// <returns>returns IEnumerable<ServiceContact> of service contacts data</returns>
		public IEnumerable<ServiceContactModel> GetServiceContacts(FilerModel filer)
		{
			try
			{
				_efmFirmService = new EfmFirmServiceClient(); //create instance to firm service client
															  //add authentication details to the client object to interact with efm
				Util.AddAuthInfoToClient((EfmFirmServiceClient)_efmFirmService, filer.EmailAddress, filer.Password);
				//get response from efm
				var response = _efmFirmService.GetServiceContactList();
				if (response.Error.ErrorCode != "0")//raise exception if any errors in response object
				{
					throw new AppException(response.Error.ErrorText, false, AppExceptionType.EFM);
				}
				if (response.ServiceContact == null)//if no data in response object send empty list
				{
					return new List<ServiceContactModel>();
				}
				//return service contacts data after converting to service contacts list
				return response.ServiceContact.Select(serviceContactType => GetServiceContact(serviceContactType.ServiceContactID, filer)).ToList();

			}
			catch (TimeoutException te)// this is to handle timeout exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				throw new Exception(
					"The state eFiling system has stopped responding. We cannot proceed. Your information has been saved as a draft. You may continue this filing later.",
					te);
			}
			catch (CommunicationException ce) // this is to handle communication exceptions while interacting with EFM
			{
				throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, ce);
			}
			catch (Exception ex) // this is to handle general exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				if (ex.Message.ToLower().Contains("unknown error"))//if error message has unknown error throw it as technical issue.
				{
					throw new AppException("eFile manager is experiencing technical issues.  Please try again later.", true, AppExceptionType.EFM, ex);
				}
				throw new AppException(ex.Message, true, AppExceptionType.EFM, ex);
			}
			finally
			{
				try
				{
					if ((_efmFirmService) != null)
					{
						((EfmFirmServiceClient)_efmFirmService).Close();// close efm firm service client connection
					}
				}
				catch (Exception exception)
				{// this is to handle general exceptions while closing efm objects
					throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, exception);
				}
			}
		}

		/// <summary>
		/// This is the method to get service contacts of a filer from efm
		/// </summary>
		/// <param name="filer">filer details to authenticate and fetch the data</param>
		/// <returns>returns IEnumerable<ServiceContact> of service contacts data</returns>
		public IEnumerable<ServiceContactModel> GetServiceContacts(FilerModel filer, string StateKeyConfig)
		{
			try
			{
				//OpenConnection(StateKeyConfig);
				//add authentication details to the client object to interact with efm
				Util.AddAuthInfoToClient((EfmFirmServiceClient)_efmFirmService, filer.EmailAddress, filer.Password);
				//get response from efm
				var response = _efmFirmService.GetServiceContactList();
				if (response.Error.ErrorCode != "0")//raise exception if any errors in response object
				{
					throw new AppException(response.Error.ErrorText, false, AppExceptionType.EFM);
				}
				if (response.ServiceContact == null)//if no data in response object send empty list
				{
					return new List<ServiceContactModel>();
				}
				//return service contacts data after converting to service contacts list
				return response.ServiceContact.Select(serviceContactType => GetServiceContact(serviceContactType.ServiceContactID, filer)).ToList();

			}
			catch (TimeoutException te)// this is to handle timeout exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				throw new Exception(
					"The state eFiling system has stopped responding. We cannot proceed. Your information has been saved as a draft. You may continue this filing later.",
					te);
			}
			catch (CommunicationException ce) // this is to handle communication exceptions while interacting with EFM
			{
				throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, ce);
			}
			catch (Exception ex) // this is to handle general exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				if (ex.Message.ToLower().Contains("unknown error"))//if error message has unknown error throw it as technical issue.
				{
					throw new AppException("eFile manager is experiencing technical issues.  Please try again later.", true, AppExceptionType.EFM, ex);
				}
				throw new AppException(ex.Message, true, AppExceptionType.EFM, ex);
			}
			finally
			{
				try
				{
					if ((_efmFirmService) != null)
					{
						((EfmFirmServiceClient)_efmFirmService).Close();// close efm firm service client connection
					}
				}
				catch (Exception exception)
				{// this is to handle general exceptions while closing efm objects
					throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, exception);
				}
			}
		}
		/// <summary>
		/// This is the method to get service contacts of a filer from efm asynchronously
		/// </summary>
		/// <param name="filer">filer details to authenticate and fetch the data</param>
		/// <returns>returns IEnumerable<ServiceContact> of service contacts data</returns>
		public async Task<IEnumerable<ServiceContactModel>> GetServiceContactsAsync(FilerModel filer)
		{
			try
			{
				if (((EfmFirmServiceClient)_efmFirmService).State != CommunicationState.Opened)
				{
					_efmFirmService = new EfmFirmServiceClient(); //create instance to firm service client
				}
				//add authentication details to the client object to interact with efm
				Util.AddAuthInfoToClient((EfmFirmServiceClient)_efmFirmService, filer.EmailAddress, filer.Password);
				//get response from efm
				var response = await _efmFirmService.GetServiceContactListAsync();
				if (response.Error.ErrorCode != "0")//raise exception if any errors in response object
				{
					throw new AppException(response.Error.ErrorText, false, AppExceptionType.EFM);
				}
				if (response.ServiceContact == null)//if no data in response object send empty list
				{
					return new List<ServiceContactModel>();
				}
				//return service contacts data after converting to service contacts list
				return response.ServiceContact.Select(serviceContactType => GetServiceContactBySelect(serviceContactType.ServiceContactID, filer)).ToList();

			}
			catch (TimeoutException te)// this is to handle timeout exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				throw new Exception(
					"The state eFiling system has stopped responding. We cannot proceed. Your information has been saved as a draft. You may continue this filing later.",
					te);
			}
			catch (CommunicationException ce) // this is to handle communication exceptions while interacting with EFM
			{
				throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, ce);
			}
			catch (Exception ex) // this is to handle general exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				if (ex.Message.ToLower().Contains("unknown error"))//if error message has unknown error throw it as technical issue.
				{
					throw new AppException("eFile manager is experiencing technical issues.  Please try again later.", true, AppExceptionType.EFM, ex);
				}
				throw new AppException(ex.Message, true, AppExceptionType.EFM, ex);
			}
			//finally
			//{
			//    try
			//    {
			//        if ((_efmFirmService) != null)
			//        {
			//            //((EfmFirmServiceClient)_efmFirmService).Close();// close efm firm service client connection
			//        }
			//    }
			//    catch (Exception exception)
			//    {
			//        //throw Util.BuildWcfException((EfmFirmServiceClient) _efmFirmService, exception);
			//    }
			//}
		}
		/// <summary>
		/// This is the method to get attorney details from efm by attorneyId
		/// </summary>
		/// <param name="attorneyId">attorneyId to search and get data</param>
		/// <returns>returns attorney object wiht filled data</returns>
		public AttorneyModel GetAttorney(string attorneyId, FilerModel admin)
		{
			try
			{
				if (attorneyId == "Self")//if attorney is null then return null
				{
					return null;
				}
				_efmFirmService = new EfmFirmServiceClient(); //create instance to firm service client
															  //add authentication details to the client object to interact with efm
				Util.AddAuthInfoToClient((EfmFirmServiceClient)_efmFirmService, admin.EmailAddress, admin.Password);
				//get response from efm
				var response = _efmFirmService.GetAttorney(new GetAttorneyRequestType
				{
					AttorneyID = attorneyId
				});
				if (response.Error.ErrorCode != "0")//raise exception if any errors in response object
				{
					throw new AppException(response.Error.ErrorText, false, AppExceptionType.EFM);
				}
				//map response object data to attorney object and send 
				var mapAttorneyTypeToAttorney = MapAttorneyTypeToAttorney(response.Attorney);
				mapAttorneyTypeToAttorney.Firm = admin.Firm;
				return mapAttorneyTypeToAttorney;

			}
			catch (TimeoutException te)// this is to handle timeout exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				throw new Exception(
					"The state eFiling system has stopped responding. We cannot proceed. Your information has been saved as a draft. You may continue this filing later.",
					te);
			}
			catch (CommunicationException ce) // this is to handle communication exceptions while interacting with EFM
			{
				throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, ce);
			}
			catch (Exception ex) // this is to handle general exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				if (ex.Message.ToLower().Contains("unknown error"))//if error message has unknown error throw it as technical issue.
				{
					throw new AppException("eFile manager is experiencing technical issues.  Please try again later.", true, AppExceptionType.EFM, ex);
				}
				throw new AppException(ex.Message, true, AppExceptionType.EFM, ex);
			}
			finally
			{
				try
				{
					if ((_efmFirmService) != null)
					{
						((EfmFirmServiceClient)_efmFirmService).Close();// close efm firm service client connection
					}
				}
				catch (Exception exception)
				{// this is to handle general exceptions while closing efm objects
					throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, exception);
				}
			}
		}

		/// <summary>
		/// This is the method to get setvice contact details from efm by serviceContactId
		/// </summary>
		/// <param name="serviceContactId">serviceContactId to search and get data</param>
		///  <param name="admin">Filer data for authenticate and get data</param>
		/// <returns>returns serviceContact object wiht filled data</returns>
		public ServiceContactModel GetServiceContact(string serviceContactId, FilerModel admin)
		{
			try
			{
				_efmFirmService = new EfmFirmServiceClient(); //create instance to firm service client
															  //add authentication details to the client object to interact with efm
				Util.AddAuthInfoToClient((EfmFirmServiceClient)_efmFirmService, admin.EmailAddress, admin.Password);
				//get response from efm
				var response =
					_efmFirmService.GetServiceContact(new GetServiceContactRequestType
					{
						ServiceContactID = serviceContactId
					});
				if (response.Error.ErrorCode != "0")//raise exception if any errors in response object
				{
					throw new AppException(response.Error.ErrorText, false, AppExceptionType.EFM);
				}
				//map response object data to service contact object and send 
				var mapServiceContactTypeToServiceContact = MapServiceContactTypeToServiceContact(response.ServiceContact);
				mapServiceContactTypeToServiceContact.firm = admin.Firm;
				return mapServiceContactTypeToServiceContact;
			}
			catch (TimeoutException te)// this is to handle timeout exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				throw new Exception("The state eFiling system has stopped responding. We cannot proceed. Your information has been saved as a draft. You may continue this filing later.", te);
			}
			catch (CommunicationException ce) // this is to handle communication exceptions while interacting with EFM
			{
				throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, ce);
			}
			catch (Exception ex) // this is to handle general exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				if (ex.Message.ToLower().Contains("unknown error"))//if error message has unknown error throw it as technical issue.
				{
					throw new AppException("eFile manager is experiencing technical issues.  Please try again later.", true, AppExceptionType.EFM, ex);
				}
				throw new AppException(ex.Message, true, AppExceptionType.EFM, ex);
			}
			finally
			{
				try
				{
					if ((_efmFirmService) != null)
					{
						((EfmFirmServiceClient)_efmFirmService).Close();// close efm firm service client connection
					}
				}
				catch (Exception exception)
				{// this is to handle general exceptions while closing efm objects
					throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, exception);
				}
			}
		}


		/// <summary>
		/// This is the method to get setvice contact details from efm by serviceContactId
		/// </summary>
		/// <param name="serviceContactId">serviceContactId to search and get data</param>
		///  <param name="admin">Filer data for authenticate and get data</param>
		/// <returns>returns serviceContact object wiht filled data</returns>
		private ServiceContactModel GetServiceContactBySelect(string serviceContactId, FilerModel admin)
		{
			ServiceContactModel mapServiceContactTypeToServiceContact = null;
			try
			{
				_efmFirmService = new EfmFirmServiceClient(); //create instance to firm service client
															  //add authentication details to the client object to interact with efm
				Util.AddAuthInfoToClient((EfmFirmServiceClient)_efmFirmService, admin.EmailAddress, admin.Password);
				//get response from efm
				var response =
					_efmFirmService.GetServiceContact(new GetServiceContactRequestType
					{
						ServiceContactID = serviceContactId
					});
				if (response.Error.ErrorCode != "0")//raise exception if any errors in response object
				{
					return null;
				}
				//map response object data to service contact object and send 
				mapServiceContactTypeToServiceContact = MapServiceContactTypeToServiceContact(response.ServiceContact);
				mapServiceContactTypeToServiceContact.firm = admin.Firm;
				return mapServiceContactTypeToServiceContact;
			}
			catch// this is to handle timeout exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
			}
			finally
			{
				try
				{
					if ((_efmFirmService) != null)
					{
						((EfmFirmServiceClient)_efmFirmService).Close();// close efm firm service client connection
					}
				}
				catch
				{// this is to handle general exceptions while closing efm objects

				}
			}
			return mapServiceContactTypeToServiceContact;
		}


		/// <summary>
		/// This is the method to add setvice contact details in efm  
		/// </summary>
		/// <param name="serviceContact">serviceContact object with data to save</param>
		///  <param name="admin">Filer data for authenticate and save data</param>
		public void AddServiceContact(ServiceContactModel serviceContact, FilerModel admin)
		{
			try
			{
				_efmFirmService = new EfmFirmServiceClient(); //create instance to firm service client
															  //add authentication details to the client object to interact with efm
				Util.AddAuthInfoToClient((EfmFirmServiceClient)_efmFirmService, admin.EmailAddress, admin.Password);
				//get response from efm
				var response = _efmFirmService.CreateServiceContact(new CreateServiceContactRequestType
				{
					ServiceContactModel = MapServiceContactToServiceContactType(serviceContact)
				});
				if (response.Error.ErrorCode != "0")//raise exception if any errors in response object
				{
					throw new AppException(response.Error.ErrorText, false, AppExceptionType.EFM);
				}
				serviceContact.EFMId = response.ServiceContactID; //update efm id

			}
			catch (TimeoutException te)// this is to handle timeout exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				throw new Exception("The state eFiling system has stopped responding. We cannot proceed. Your information has been saved as a draft. You may continue this filing later.", te);
			}
			catch (CommunicationException ce) // this is to handle communication exceptions while interacting with EFM
			{
				throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, ce);
			}
			catch (Exception ex) // this is to handle general exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				if (ex.Message.ToLower().Contains("unknown error"))//if error message has unknown error throw it as technical issue.
				{
					throw new AppException("eFile manager is experiencing technical issues.  Please try again later.", true, AppExceptionType.EFM, ex);
				}
				throw new AppException(ex.Message, true, AppExceptionType.EFM, ex);
			}
			finally
			{
				try
				{
					if ((_efmFirmService) != null)
					{
						((EfmFirmServiceClient)_efmFirmService).Close();// close efm firm service client connection
					}
				}
				catch (Exception exception)
				{// this is to handle general exceptions while closing efm objects
					throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, exception);
				}
			}
		}
		/// <summary>
		/// This is the method to delete setvice contact details in efm  
		/// </summary>
		/// <param name="serviceContact">serviceContact object with data to delete</param>
		///  <param name="admin">Filer data for authenticate and save data</param>

		public void DeleteServiceContact(string serviceContactId, FilerModel admin)
		{
			try
			{
				_efmFirmService = new EfmFirmServiceClient(); //create instance to firm service client
															  //add authentication details to the client object to interact with efm
				Util.AddAuthInfoToClient((EfmFirmServiceClient)_efmFirmService, admin.EmailAddress, admin.Password);
				//get response from efm
				var response =
					_efmFirmService.RemoveServiceContact(new RemoveServiceContactRequestType
					{
						ServiceContactID = serviceContactId
					});
				if (response.Error.ErrorCode != "0")//raise exception if any errors in response object
				{
					throw new AppException(response.Error.ErrorText, false, AppExceptionType.EFM);
				}
			}
			catch (TimeoutException te)// this is to handle timeout exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				throw new Exception(
					"The state eFiling system has stopped responding. We cannot proceed. Your information has been saved as a draft. You may continue this filing later.",
					te);
			}
			catch (CommunicationException ce) // this is to handle communication exceptions while interacting with EFM
			{
				throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, ce);
			}
			catch (Exception ex) // this is to handle general exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				if (ex.Message.ToLower().Contains("unknown error"))//if error message has unknown error throw it as technical issue.
				{
					throw new AppException("eFile manager is experiencing technical issues.  Please try again later.", true, AppExceptionType.EFM, ex);
				}
				throw new AppException(ex.Message, true, AppExceptionType.EFM, ex);
			}
			finally
			{
				try
				{
					if ((_efmFirmService) != null)
					{
						((EfmFirmServiceClient)_efmFirmService).Close();// close efm firm service client connection
					}
				}
				catch (Exception exception)
				{// this is to handle general exceptions while closing efm objects
					throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, exception);
				}
			}
		}

		/// <summary>
		/// This is the method to attach setvice contact details to the case and save in efm  
		/// </summary>
		/// <param name="serviceContactId">serviceContactId to get service contact details</param>
		/// <param name="CaseTrackingId">CaseTrackingId to get case details</param>
		/// <param name="casePartyEmfId">casePartyEmfId to get case party details</param>
		public void AttachServiceContact(string serviceContactId, string CaseTrackingId, string casePartyEmfId, FilerModel admin)
		{
			try
			{
				_efmFirmService = new EfmFirmServiceClient(); //create instance to firm service client
															  //add authentication details to the client object to interact with efm
				Util.AddAuthInfoToClient((EfmFirmServiceClient)_efmFirmService, admin.EmailAddress, admin.Password);
				//get response from efm
				var response = _efmFirmService.AttachServiceContact(new AttachServiceContactRequestType
				{
					CaseID = CaseTrackingId,
					ServiceContactID = serviceContactId,
					CasePartyID = casePartyEmfId != null ? casePartyEmfId : ""
				});
				if (response.Error.ErrorCode != "0")//raise exception if any errors in response object
				{
					throw new AppException(response.Error.ErrorText, false, AppExceptionType.EFM);
				}
			}
			catch (TimeoutException te)// this is to handle timeout exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				throw new Exception(
					"The state eFiling system has stopped responding. We cannot proceed. Your information has been saved as a draft. You may continue this filing later.",
					te);
			}
			catch (CommunicationException ce) // this is to handle communication exceptions while interacting with EFM
			{
				throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, ce);
			}
			catch (Exception ex) // this is to handle general exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				if (ex.Message.ToLower().Contains("unknown error"))//if error message has unknown error throw it as technical issue.
				{
					throw new AppException("eFile manager is experiencing technical issues.  Please try again later.", true, AppExceptionType.EFM, ex);
				}
				throw new AppException(ex.Message, true, AppExceptionType.EFM, ex);
			}
			finally
			{
				try
				{
					if ((_efmFirmService) != null)
					{
						((EfmFirmServiceClient)_efmFirmService).Close();// close efm firm service client connection
					}
				}
				catch (Exception exception)
				{// this is to handle general exceptions while closing efm objects
					throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, exception);
				}
			}
		}
		/// <summary>
		/// This is the method to detach setvice contact details to the case and save in efm  
		/// </summary>
		/// <param name="serviceContactId">serviceContactId to get service contact details</param>
		/// <param name="CaseTrackingId">CaseTrackingId to get case details</param>
		///  <param name="admin">Filer data for authenticate and save data</param>

		public void DetachServiceContact(string serviceContactId, string CaseTrackingId, FilerModel admin)
		{
			try
			{
				_efmFirmService = new EfmFirmServiceClient(); //create instance to firm service client
															  //add authentication details to the client object to interact with efm
				Util.AddAuthInfoToClient((EfmFirmServiceClient)_efmFirmService, admin.EmailAddress, admin.Password);
				//get response from efm
				var response =
					_efmFirmService.DetachServiceContact(new DetachServiceContactRequestType
					{
						CaseID = CaseTrackingId,
						ServiceContactID = serviceContactId,
						CasePartyID = ""
					});
				if (response.Error.ErrorCode != "0" && !response.Error.ErrorText.ToString().Contains("Service contact is not attached to the case"))
				{
					throw new AppException(response.Error.ErrorText, false, AppExceptionType.EFM);
				}
			}
			catch (TimeoutException te)// this is to handle timeout exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				throw new Exception(
					"The state eFiling system has stopped responding. We cannot proceed. Your information has been saved as a draft. You may continue this filing later.",
					te);
			}
			catch (CommunicationException ce) // this is to handle communication exceptions while interacting with EFM
			{
				throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, ce);
			}
			catch (Exception ex) // this is to handle general exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				if (ex.Message.ToLower().Contains("unknown error"))//if error message has unknown error throw it as technical issue.
				{
					throw new AppException("eFile manager is experiencing technical issues.  Please try again later.", true, AppExceptionType.EFM, ex);
				}
				throw new AppException(ex.Message, true, AppExceptionType.EFM, ex);
			}
			finally
			{
				try
				{
					if ((_efmFirmService) != null)
					{
						((EfmFirmServiceClient)_efmFirmService).Close();// close efm firm service client connection
					}
				}
				catch (Exception exception)
				{// this is to handle general exceptions while closing efm objects
					throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, exception);
				}
			}
		}

		/// <summary>
		/// This is the method to detach setvice contact details to the case and save in efm  
		/// </summary>
		/// <param name="serviceContact">serviceContact to get service contact details</param>
		///  <param name="admin">Filer data for authenticate and save data</param>

		public void UpdateServiceContact(ServiceContactModel serviceContact, FilerModel admin)
		{
			try
			{
				_efmFirmService = new EfmFirmServiceClient(); //create instance to firm service client
															  //add authentication details to the client object to interact with efm
				Util.AddAuthInfoToClient((EfmFirmServiceClient)_efmFirmService, admin.EmailAddress, admin.Password);

				var req = new UpdateServiceContactRequestType()
				{
					ServiceContact = MapServiceContactToServiceContactType(serviceContact)
				};
				//get response from efm
				var response = _efmFirmService.UpdateServiceContact(req);
				if (response.Error.ErrorCode != "0")//raise exception if any errors in response object
				{
					throw new AppException(response.Error.ErrorText, false, AppExceptionType.EFM);
				}
				serviceContact.EFMId = response.ServiceContactID;//update efm id

			}
			catch (TimeoutException te)// this is to handle timeout exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				throw new Exception(
					"The state eFiling system has stopped responding. We cannot proceed. Your information has been saved as a draft. You may continue this filing later.",
					te);
			}
			catch (CommunicationException ce) // this is to handle communication exceptions while interacting with EFM
			{
				throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, ce);
			}
			catch (Exception ex) // this is to handle general exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				if (ex.Message.ToLower().Contains("unknown error"))//if error message has unknown error throw it as technical issue.
				{
					throw new AppException("eFile manager is experiencing technical issues.  Please try again later.", true, AppExceptionType.EFM, ex);
				}
				throw new AppException(ex.Message, true, AppExceptionType.EFM, ex);
			}
			finally
			{
				try
				{
					if ((_efmFirmService) != null)
					{
						((EfmFirmServiceClient)_efmFirmService).Close();// close efm firm service client connection
					}
				}
				catch (Exception exception)
				{// this is to handle general exceptions while closing efm objects
					throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, exception);
				}
			}
		}
		/// <summary>
		/// This is the method to add attorney details in efm. Admin details are mandatory to interact with efm  
		/// </summary>
		/// <param name="attorney">Attorney to get Attorney details to save</param>
		///  <param name="admin">Filer data for authenticate and save data</param>

		public void AddAttorney(AttorneyModel attorney, FilerModel admin)
		{
			try
			{
				_efmFirmService = new EfmFirmServiceClient(); //create instance to firm service client
															  //add authentication details to the client object to interact with efm
				Util.AddAuthInfoToClient((EfmFirmServiceClient)_efmFirmService, admin.EmailAddress, admin.Password);
				//get response from efm
				var response = _efmFirmService.CreateAttorney(new CreateAttorneyRequestType
				{
					Attorney = MapAttorneyToAttorneyType(attorney)
				});
				if (response.Error.ErrorCode != "0")//raise exception if any errors in response object
				{
					throw new AppException(response.Error.ErrorText, false, AppExceptionType.EFM);
				}
				attorney.AttorneyEFMID = response.AttorneyID;//update AttorneyEFMID

			}
			catch (TimeoutException te)// this is to handle timeout exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				throw new Exception(
					"The state eFiling system has stopped responding. We cannot proceed. Your information has been saved as a draft. You may continue this filing later.",
					te);
			}
			catch (CommunicationException ce) // this is to handle communication exceptions while interacting with EFM
			{
				throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, ce);
			}
			catch (Exception ex) // this is to handle general exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				if (ex.Message.ToLower().Contains("unknown error"))//if error message has unknown error throw it as technical issue.
				{
					throw new AppException("eFile manager is experiencing technical issues.  Please try again later.", true, AppExceptionType.EFM, ex);
				}
				throw new AppException(ex.Message, true, AppExceptionType.EFM, ex);
			}
			finally
			{
				try
				{
					if ((_efmFirmService) != null)
					{
						((EfmFirmServiceClient)_efmFirmService).Close();// close efm firm service client connection
					}
				}
				catch (Exception exception)
				{// this is to handle general exceptions while closing efm objects
					throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, exception);
				}
			}
		}
		/// <summary>
		/// This is the method to update attorney details in efm. Admin details are mandatory to interact with efm  
		/// </summary>
		/// <param name="attorney">Attorney to get Attorney details to save</param>
		///  <param name="admin">Filer data for authenticate and save data</param>

		public void UpdateAttorney(AttorneyModel attorney, FilerModel admin)
		{
			try
			{
				_efmFirmService = new EfmFirmServiceClient(); //create instance to firm service client
															  //add authentication details to the client object to interact with efm
				Util.AddAuthInfoToClient((EfmFirmServiceClient)_efmFirmService, admin.EmailAddress, admin.Password);
				//get response from efm
				var response = _efmFirmService.UpdateAttorney(new UpdateAttorneyRequestType()
				{
					Attorney = MapAttorneyToAttorneyType(attorney)
				});
				if (response.Error.ErrorCode != "0")//raise exception if any errors in response object
				{
					throw new AppException(response.Error.ErrorText, false, AppExceptionType.EFM);
				}

			}
			catch (TimeoutException te)// this is to handle timeout exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				throw new Exception(
					"The state eFiling system has stopped responding. We cannot proceed. Your information has been saved as a draft. You may continue this filing later.",
					te);
			}
			catch (CommunicationException ce) // this is to handle communication exceptions while interacting with EFM
			{
				throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, ce);
			}
			catch (Exception ex) // this is to handle general exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				if (ex.Message.ToLower().Contains("unknown error"))//if error message has unknown error throw it as technical issue.
				{
					throw new AppException("eFile manager is experiencing technical issues.  Please try again later.", true, AppExceptionType.EFM, ex);
				}
				throw new AppException(ex.Message, true, AppExceptionType.EFM, ex);
			}
			finally
			{
				try
				{
					if ((_efmFirmService) != null)
					{
						((EfmFirmServiceClient)_efmFirmService).Close();// close efm firm service client connection
					}
				}
				catch (Exception exception)
				{// this is to handle general exceptions while closing efm objects
					throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, exception);
				}
			}
		}
		/// <summary>
		/// This is the method to delete attorney details in efm. Admin details are mandatory to interact with efm  
		/// </summary>
		/// <param name="attorney">Attorney to get Attorney details to save</param>
		///  <param name="admin">Filer data for authenticate and save data</param>

		public void DeleteAttorney(string attorney, FilerModel admin)
		{
			try
			{
				_efmFirmService = new EfmFirmServiceClient(); //create instance to firm service client
															  //add authentication details to the client object to interact with efm
				Util.AddAuthInfoToClient((EfmFirmServiceClient)_efmFirmService, admin.EmailAddress, admin.Password);
				//get response from efm
				var response =
					_efmFirmService.RemoveAttorney(new RemoveAttorneyRequestType
					{
						AttorneyID = attorney
					});
				if (response.Error.ErrorCode != "0")//raise exception if any errors in response object
				{
					if (!response.Error.ErrorText.Contains("AttorneyID did not match any attorney"))
					{
						throw new AppException(response.Error.ErrorText, false, AppExceptionType.EFM);
					}
				}
			}
			catch (TimeoutException te)// this is to handle timeout exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				throw new Exception(
					"The state eFiling system has stopped responding. We cannot proceed. Your information has been saved as a draft. You may continue this filing later.",
					te);
			}
			catch (CommunicationException ce) // this is to handle communication exceptions while interacting with EFM
			{
				throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, ce);
			}
			catch (Exception ex) // this is to handle general exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				if (ex.Message.ToLower().Contains("unknown error"))//if error message has unknown error throw it as technical issue.
				{
					throw new AppException("eFile manager is experiencing technical issues.  Please try again later.", true, AppExceptionType.EFM, ex);
				}
				throw new AppException(ex.Message, true, AppExceptionType.EFM, ex);
			}
			finally
			{
				try
				{
					if ((_efmFirmService) != null)
					{
						((EfmFirmServiceClient)_efmFirmService).Close();// close efm firm service client connection
					}
				}
				catch (Exception exception)
				{// this is to handle general exceptions while closing efm objects
					throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, exception);
				}
			}
		}


		#region GetPublicServiceContactLists
		/// <summary>
		/// This is the method to get public service contacts list from efm
		/// </summary>
		/// <param name="firstName">first name of the user</param>
		/// <param name="lastName">last name of the user</param>
		/// <param name="firmName">firm name of the user</param>
		/// <param name="emailAddress">email address name of the user</param>
		/// <param name="filer">to get authentication details required</param>
		/// <returns>returns IEnumerable<ServiceContact>  of service contacts</returns>
		public IEnumerable<ServiceContactModel> GetPublicServiceContactLists(string firstName, string lastName, string firmName, string emailAddress, FilerModel filer)
		{
			try
			{
				_efmFirmService = new EfmFirmServiceClient(); //create instance to firm service client
															  //add authentication details to the client object to interact with efm
				Util.AddAuthInfoToClient((EfmFirmServiceClient)_efmFirmService, filer.EmailAddress, filer.Password);
				//get response from efm
				var response =
					_efmFirmService.GetPublicList(new GetPublicListRequestType
					{
						//assign data to all required fieds
						FirstName = firstName,
						LastName = lastName,
						FirmName = firmName,
						Email = emailAddress,

					});
				if (response.Error.ErrorCode != "0")//raise exception if any errors in response object
				{
					throw new AppException(response.Error.ErrorText, false, AppExceptionType.EFM);
				}
				if (response.ServiceContact != null)
				{
					var serviceContactList = new List<ServiceContactModel>();
					foreach (var serviceContact in response.ServiceContact)//loop all response service contacts and add to the service contacts list
					{
						try
						{
							var mapServiceContactTypeToServiceContact = MapServiceContactTypeToServiceContact(serviceContact);
							serviceContactList.Add(mapServiceContactTypeToServiceContact);
						}
						catch (Exception e)
						{
						//	_logger.LogError(string.Format("error while mapping service contact for {0}", serviceContact.FirmName));
						}
					}
					return serviceContactList;
				}
				else { return new List<ServiceContactModel>(); } //if response is null send empty list
			}
			catch (TimeoutException te)// this is to handle timeout exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				throw new Exception(
					"The state eFiling system has stopped responding. We cannot proceed. Your information has been saved as a draft. You may continue this filing later.",
					te);
			}
			catch (CommunicationException ce) // this is to handle communication exceptions while interacting with EFM // this is to handle communication exceptions while interacting with EFM
			{
				throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, ce);
			}
			catch (Exception ex) // this is to handle general exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				if (ex.Message.ToLower().Contains("unknown error"))//if error message has unknown error throw it as technical issue.
				{
					throw new AppException("eFile manager is experiencing technical issues.  Please try again later.", true, AppExceptionType.EFM, ex);
				}
				throw new AppException(ex.Message, true, AppExceptionType.EFM, ex);
			}
			finally
			{
				try
				{
					if ((_efmFirmService) != null)
					{
						((EfmFirmServiceClient)_efmFirmService).Close();// close efm firm service client connection
					}
				}
				catch (Exception exception)
				{// this is to handle general exceptions while closing efm objects
					throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, exception);
				}
			}
		}
		#endregion

		#region GetPublicServiceContactListsWithState
		/// <summary>
		/// This is the method to get public service contacts list from efm
		/// </summary>
		/// <param name="firstName">first name of the user</param>
		/// <param name="lastName">last name of the user</param>
		/// <param name="firmName">firm name of the user</param>
		/// <param name="emailAddress">email address name of the user</param>
		/// <param name="filer">to get authentication details required</param>
		/// <returns>returns IEnumerable<ServiceContact>  of service contacts</returns>
		public IEnumerable<ServiceContactModel> GetPublicServiceContactLists(string firstName, string lastName, string firmName, string emailAddress, FilerModel filer, string stateKeyConfig)
		{
			try
			{
				//OpenConnection(stateKeyConfig); //create instance to firm service client
												//add authentication details to the client object to interact with efm
				Util.AddAuthInfoToClient((EfmFirmServiceClient)_efmFirmService, filer.EmailAddress, filer.Password);
				//get response from efm
				var response =
					_efmFirmService.GetPublicList(new GetPublicListRequestType
					{
						//assign data to all required fieds
						FirstName = firstName,
						LastName = lastName,
						FirmName = firmName,
						Email = emailAddress,

					});
				if (response.Error.ErrorCode != "0")//raise exception if any errors in response object
				{
					throw new AppException(response.Error.ErrorText, false, AppExceptionType.EFM);
				}
				if (response.ServiceContact != null)
				{
					var serviceContactList = new List<ServiceContactModel>();
					foreach (var serviceContact in response.ServiceContact)//loop all response service contacts and add to the service contacts list
					{
						try
						{
							var mapServiceContactTypeToServiceContact = MapServiceContactTypeToServiceContact(serviceContact);
							serviceContactList.Add(mapServiceContactTypeToServiceContact);
						}
						catch (Exception e)
						{
							//_logger.LogError(string.Format("error while mapping service contact for {0}", serviceContact.FirmName));
						}
					}
					return serviceContactList;
				}
				else { return new List<ServiceContactModel>(); } //if response is null send empty list
			}
			catch (TimeoutException te)// this is to handle timeout exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				throw new Exception(
					"The state eFiling system has stopped responding. We cannot proceed. Your information has been saved as a draft. You may continue this filing later.",
					te);
			}
			catch (CommunicationException ce) // this is to handle communication exceptions while interacting with EFM // this is to handle communication exceptions while interacting with EFM
			{
				throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, ce);
			}
			catch (Exception ex) // this is to handle general exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				if (ex.Message.ToLower().Contains("unknown error"))//if error message has unknown error throw it as technical issue.
				{
					throw new AppException("eFile manager is experiencing technical issues.  Please try again later.", true, AppExceptionType.EFM, ex);
				}
				throw new AppException(ex.Message, true, AppExceptionType.EFM, ex);
			}
			finally
			{
				try
				{
					if ((_efmFirmService) != null)
					{
						((EfmFirmServiceClient)_efmFirmService).Close();// close efm firm service client connection
					}
				}
				catch (Exception exception)
				{// this is to handle general exceptions while closing efm objects
					throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, exception);
				}
			}
		}
		#endregion

		/// <summary>
		/// This is the private common method to map AttorneyType object data to Attorney object data
		/// </summary>
		/// <param name="attorneyType">AttorneyType object with data.</param>        
		/// <returns>return Attorney with filled data</returns>
		private AttorneyModel MapAttorneyTypeToAttorney(AttorneyType attorneyType)
		{
			return new AttorneyModel
			{
				FirstName = attorneyType.FirstName,
				MiddleName = attorneyType.MiddleName,
				LastName = attorneyType.LastName,
				BarNumber = attorneyType.BarNumber,
				AttorneyEFMID = attorneyType.AttorneyID
			};
		}


		/// <summary>
		/// This is the private common method to map ServiceContactType object data to ServiceContact object data
		/// </summary>
		/// <param name="serviceContactType">ServiceContactType object with data.</param>        
		/// <returns>return ServiceContact with filled data</returns>
		private ServiceContactModel MapServiceContactTypeToServiceContact(ServiceContactType serviceContactType)
		{
			//create instance and assign data to all required properties
			return new ServiceContactModel
			{
				Email = serviceContactType.Email,
				FirstName = serviceContactType.FirstName,
				MiddleName = serviceContactType.MiddleName,
				LastName = serviceContactType.LastName,
				Address = MapAddressTypeToAddress(serviceContactType.Address),
				EFMId = serviceContactType.ServiceContactID,
				PhoneNumber = serviceContactType.PhoneNumber,
				IsPublic = serviceContactType.IsPublic.HasValue ? serviceContactType.IsPublic.Value : false,
				IsNonFirm = serviceContactType.IsInFirmMasterList.HasValue ? !serviceContactType.IsInFirmMasterList.Value : false,
				firm = new FirmModel() { Name = serviceContactType.FirmName, EFMFirmID = serviceContactType.FirmID },
				AdministrativeCopyEmail = serviceContactType.AdministrativeCopy,
				AddByFirmName = !string.IsNullOrEmpty(serviceContactType.AddByFirmName) && (serviceContactType.AddByFirmName.Contains("Texas Public Service") || serviceContactType.AddByFirmName.Contains("Tyler Public Service")) ? ConfigurationManager.AppSettings["TylerPublicService"].ToString() : serviceContactType.AddByFirmName
			};
		}

		/// <summary>
		/// This is the private common method to map ServiceContact object data to ServiceContactType object data
		/// </summary>
		/// <param name="serviceContact">serviceContact object with data to map</param>        
		/// <returns>return ServiceContactType with filled data</returns>
		private ServiceContactType MapServiceContactToServiceContactType(ServiceContactModel serviceContact)
		{
			//create instance and assign data to all required properties
			return new ServiceContactType
			{
				FirstName = serviceContact.FirstName,
				LastName = serviceContact.LastName,
				MiddleName = serviceContact.MiddleName ?? "",
				Email = serviceContact.Email,
				AdministrativeCopy = !string.IsNullOrEmpty(serviceContact.AdministrativeCopyEmail) ? serviceContact.AdministrativeCopyEmail : "",
				Address = serviceContact.Address != null ? MapAddressToAddressType(serviceContact.Address) : null,
				PhoneNumber = serviceContact.PhoneNumber ?? "",
				IsPublic = serviceContact.IsPublic,
				IsPublicSpecified = true,
				IsInFirmMasterList = !serviceContact.IsNonFirm,
				IsInFirmMasterListSpecified = true,
				ServiceContactID = serviceContact.EFMId,
				FirmID = serviceContact.firm != null ? serviceContact.firm.EFMFirmID : "",
				FirmName = serviceContact.IsNonFirm ? serviceContact.NonFirmName : (serviceContact.firm != null ? serviceContact.firm.Name : ""),
				AddByFirmName = serviceContact.firm != null ? serviceContact.firm.Name : "",
			};
		}

		/// <summary>
		/// This is the private common method to map Address object data to AddressType object data
		/// </summary>
		/// <param name="address">address object with data to map</param>        
		/// <returns>return AddressType with filled data</returns>
		private AddressType MapAddressToAddressType(AddressModel address)
		{
			//create instance and assign data to all required properties
			return new AddressType
			{
				AddressLine1 = address.Address1,
				AddressLine2 = address.Address2 ?? "",
				City = address.City,
				State = address.State,
				ZipCode = address.Zip,
				Country = string.IsNullOrEmpty(address.CountryCode) ? "US" : address.CountryCode // ser default country as "US"
			};
		}

		#endregion

		/// <summary>
		/// This is the private common method to map PaymentAccount object data to PaymentAccountType   data
		/// </summary>
		/// <param name="paymentaccount">paymentaccount object with data to map</param>        
		/// <returns>return all PaymentAccountType data</returns>
		private PaymentAccountType MapPaymentAccountToPaymentAccountType(PaymentAccountModel paymentaccount)
		{
			//create new instance and assign data to all required properties
			return new PaymentAccountType
			{
				AccountName = paymentaccount.AccountName,
				AccountToken = paymentaccount.CardToken,
				//CardLast4Specified = true,
				CardMonthSpecified = true,
				CardYearSpecified = true,
				CardHolderName = paymentaccount.CardHolderName,
				CardLast4 = paymentaccount.CardLast4Numbers != null ? AddLeadingZeros(paymentaccount.CardLast4Numbers.Value.ToString()) : "",
				CardMonth = paymentaccount.ExpirationMonth,
				CardYear = paymentaccount.ExpirationYear,
				CardType = paymentaccount.CardType,

				PaymentAccountTypeCode = paymentaccount.Type == TypeOfPayment.CreditCard ? "CC" : (paymentaccount.Type == TypeOfPayment.BankAccount ? "BankAccount" : "WV"),
			};
		}

		/// <summary>
		/// This is the common method to dispaly last 4 digists and remining with zero
		/// </summary>
		/// <param name="CardLast4Numbers">its a number to convert.</param>
		/// <returns>returns last 4 digits are numbers</returns>
		private string AddLeadingZeros(string CardLast4Numbers)
		{
			string strLast4Number = CardLast4Numbers;
			int count = CardLast4Numbers.Length;
			if (count < 4)//replace with 0 otherthan last 4 digits
			{
				for (int i = 1; i <= (4 - count); i++)//loop and assign zero
				{
					strLast4Number = "0" + strLast4Number;
				}
			}
			return strLast4Number;
		}

		/// <summary>
		/// This is the private common method to map Attorney object data to AttorneyType data
		/// </summary>
		/// <param name="attorney">attorney object with data to map</param>        
		/// <returns>return all attorneytype data</returns>
		private AttorneyType MapAttorneyToAttorneyType(AttorneyModel attorney)
		{    //create new instance and assign data to all required properties
			return new AttorneyType
			{
				LastName = attorney.LastName,
				FirstName = attorney.FirstName,
				AttorneyID = attorney.AttorneyEFMID,
				BarNumber = attorney.BarNumber.TrimStart('0') ?? "",
				MiddleName = attorney.MiddleName ?? "",
				FirmID = attorney.Firm.EFMFirmID
			};
		}

		/// <summary>
		/// This is the private common method to map Filer object data to UserType data
		/// </summary>
		/// <param name="filer">filer object with data to map</param>        
		/// <returns>return all user type data</returns>
		private UserType MapFilerToUserType(FilerModel filer)
		{
			//create new instance and assign data to all required properties
			var userType = new UserType
			{
				Email = filer.EmailAddress,

				FirmID = filer.Firm.EFMFirmID,
				FirstName = filer.FirstName,
				MiddleName = filer.MiddleName ?? "",
				LastName = filer.LastName,
				UserID = filer.EFMUserId,
				LastLoginDate = filer.LastLogin,
				IsApproved = filer.IsApproved,
				IsActive = true,
				IsActivated = filer.IsActive,
				IsLockedOut = filer.IsLockedOut
			};
			List<RoleLocationType> roles = new List<RoleLocationType>();
			if (filer.RolesEnum.Contains(FilerRole.Admin))//check for role and add to the lsit
			{
				roles.Add(new RoleLocationType() { Location = "", RoleName = RoleType.FirmAdmin });
			}
			if (filer.RolesEnum.Contains(FilerRole.Filer))//check for filer role and add to the lsit
			{
				roles.Add(new RoleLocationType() { Location = "", RoleName = RoleType.Filer });
			}

			userType.Role = roles.ToArray();
			return userType;//return all user type data
		}

		/// <summary>
		/// This is the private common method to map Firm object data to FirmType object data
		/// </summary>
		/// <param name="firm">Firm object with data to map</param>
		/// <returns>returns FirmType object with filled data</returns>
		private FirmType MapFirmToFirmType(FirmModel firm)
		{
			//create new instance and assign data to all required properties
			return new FirmType
			{
				Address = MapAddressToAddressType(firm.Address),
				FirmID = firm.EFMFirmID,
				FirmName = firm.Name,
				PhoneNumber = firm.Phone,
				IsIndividual = firm.IsIndividual
			};
		}

		/// <summary>
		/// This is the private common method to map FirmType object data to Firm object data
		/// </summary>
		/// <param name="firm">FirmType object with data to map</param>
		/// <returns>returns Firm object with filled data</returns>
		private FirmModel MapFirmTypeToFirm(FirmType firm)
		{
			//create new instance and assign data to all required properties
			return new FirmModel
			{
				Address = MapAddressTypeToAddress(firm.Address),
				EFMFirmID = firm.FirmID,
				Name = firm.FirmName,
				Phone = firm.PhoneNumber,
				IsIndividual = firm.IsIndividual
			};
		}

		/// <summary>
		/// This is the private common method to map AddressType object data to Address object data
		/// </summary>
		/// <param name="address">AddressType object with data to map</param>
		/// <returns>returns Address object with filled data</returns>
		private static AddressModel MapAddressTypeToAddress(AddressType address)
		{
			if (address != null)
			{//create new instance and assign data to all required properties
				return new AddressModel
				{
					Address1 = address.AddressLine1,
					Address2 = address.AddressLine2 ?? "",
					City = address.City,
					State = !string.IsNullOrEmpty(address.State) ? (address.State.ToLower() == "texas" ? "TX" : address.State) : ConfigurationManager.AppSettings["StateKey"].ToString(),
					Zip = address.ZipCode,
					CountryCode = !string.IsNullOrEmpty(address.Country) ? address.Country : "US",
				};
			}
			else
			{
				return new AddressModel();
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="filer"></param>
		private void UpdateFilerRoles(FilerModel filer)
		{
			BaseResponseType roleResponse;

			if (filer.RolesEnum.Contains(FilerRole.Filer))
				roleResponse = _efmFirmService.AddUserRole(new AddUserRoleRequestType { Role = RoleType.Filer, UserID = filer.EFMUserId });
			else
				roleResponse = _efmFirmService.RemoveUserRole(new RemoveUserRoleRequestType { Role = RoleType.Filer, UserID = filer.EFMUserId });

			if (roleResponse.Error.ErrorCode != "0")
				throw new AppException(roleResponse.Error.ErrorText, false, AppExceptionType.EFM);

			if (filer.RolesEnum.Contains(FilerRole.Admin))
				roleResponse = _efmFirmService.AddUserRole(new AddUserRoleRequestType { Role = RoleType.FirmAdmin, UserID = filer.EFMUserId });
			else
				roleResponse = _efmFirmService.RemoveUserRole(new RemoveUserRoleRequestType { Role = RoleType.FirmAdmin, UserID = filer.EFMUserId });
			if (roleResponse.Error.ErrorCode != "0")
				throw new AppException(roleResponse.Error.ErrorText, false, AppExceptionType.EFM);

			if (filer.IsAttorney)
			{
				if (string.IsNullOrEmpty(filer.AttoneyModel.AttorneyEFMID))
				{
					var createResponse = _efmFirmService.CreateAttorney(new CreateAttorneyRequestType
					{
						Attorney = MapAttorneyToAttorneyType(filer.AttoneyModel)
					});
					if (createResponse.Error.ErrorCode != "0")
						throw new AppException(createResponse.Error.ErrorText, false, AppExceptionType.EFM);

				}
				else
				{
					var updateResponse = _efmFirmService.UpdateAttorney(new UpdateAttorneyRequestType
					{
						Attorney = MapAttorneyToAttorneyType(filer.AttoneyModel)
					});
					if (updateResponse.Error.ErrorCode != "0")
						throw new AppException(updateResponse.Error.ErrorText, false, AppExceptionType.EFM);

				}
			}
			else if (filer.Firm != null && filer.Firm.attorney != null)
			{
				var attorney = filer.Firm.attorney.FirstOrDefault(x => x.FirstName == filer.FirstName && x.LastName == filer.LastName && x.MiddleName == filer.MiddleName);
				if (attorney != null)
				{
					var attorneyResponse = _efmFirmService.GetAttorney(new GetAttorneyRequestType { AttorneyID = attorney.AttorneyEFMID });
					if (attorneyResponse.Error.ErrorCode != "0")
					{
						throw new AppException(attorneyResponse.Error.ErrorText, false, AppExceptionType.EFM);
					}
					if (attorneyResponse.Attorney != null)
					{
						roleResponse = _efmFirmService.RemoveAttorney(new RemoveAttorneyRequestType
						{
							AttorneyID = attorney.AttorneyEFMID
						});
						if (roleResponse.Error.ErrorCode != "0")
						{
							throw new AppException(roleResponse.Error.ErrorText, false, AppExceptionType.EFM);
						}
					}
				}
			}
		}

		/// <summary>
		/// This is the private method to map AttorneyType objects data to Attorney object data
		/// </summary>
		/// <param name="attorneyTypes">AttorneyType list of objects to map</param>
		/// <returns>returns  IList<Attorney> of attorney's data  </returns>
		private IList<AttorneyModel> MapAttorneyListResponseToAttorneys(AttorneyType[] attorneyTypes)
		{
			IList<AttorneyModel> attorneys = new List<AttorneyModel>();
			if (attorneyTypes == null || attorneyTypes.Length <= 0)//if there are no attorney's return attorneys
			{
				return attorneys;
			}
			foreach (var attorneyType in attorneyTypes)//loop each attorney and map with required format
			{
				var user = new AttorneyModel();

				MapAttorneyTypeToAttorney(user, attorneyType);//map user details to attrtney tupe

				attorneys.Add(user); //add to the list

			}
			return attorneys; //retrn with list
		}



		/// <summary>
		/// This is the private static method to map attorneyType object data to Attorney object data
		/// </summary>
		/// <param name="user">Attorney object to fill the data</param>
		/// <param name="attorneyType">AttorneyType object with data to map</param>
		private static void MapAttorneyTypeToAttorney(AttorneyModel user, AttorneyType attorneyType)
		{
			// assign data to all required properties
			user.BarNumber = attorneyType.BarNumber;
			user.AttorneyEFMID = attorneyType.AttorneyID;
			user.FirstName = attorneyType.FirstName;
			user.MiddleName = attorneyType.MiddleName ?? "";
			user.LastName = attorneyType.LastName;
		}



		/// <summary>
		/// This is the private common method to map UserListResponseType object data to Filer objects data
		/// </summary>
		/// <param name="response">UserType object with data to map</param>       
		/// <returns>returns IEnumerable<Filer> of filers data</returns> 
		private IEnumerable<FilerModel> MapGetUserListResponseToFilerList(UserListResponseType response)
		{
			IList<FilerModel> filers = new List<FilerModel>();//declare filers list
			foreach (var userType in response.User) //loop each user and add to filers list with new data
			{// assign data to all required properties
				FilerModel filer = new FilerModel();
				MapGetUserResponseToFiler(userType, filer);
				filers.Add(filer);
			}
			return filers;//return filers list
		}

		/// <summary>
		/// This is the private common method to map UserType object data to Filer object data
		/// </summary>
		/// <param name="response">UserType object with data to map</param>        
		/// <param name="filer">filer object with data to map</param>       

		private void MapGetUserResponseToFiler(UserType response, FilerModel filer)
		{
			// assign data to all required properties
			filer.FirstName = response.FirstName;
			filer.MiddleName = response.MiddleName ?? "";
			filer.LastName = response.LastName;
			filer.EFMUserId = response.UserID;
			filer.EmailAddress = response.Email;
			filer.LastLoginToEFM = response.LastLoginDate;
			filer.IsApproved = response.IsApproved;
			filer.IsActive = response.IsActivated;
			filer.IsLockedOut = response.IsLockedOut;
			filer.RestrictFiling = response.RestrictFiling;
			filer.RestrictFilingComment = response.RestrictFilingComment;
			if (response.Role != null && response.Role.Any(x => x.RoleName == RoleType.Filer))
				filer.Roles = "Filer";          //assign filer role
			if (response.Role != null && response.Role.Any(x => x.RoleName == RoleType.FirmAdmin))
			{
				if (string.IsNullOrEmpty(filer.Roles))
					filer.Roles = "Admin";                //assign admin role
				else
					filer.Roles += ",Admin";        //append admin role         
			}
		}


		/// <summary>
		/// This is the private common method to map Filer object data to RegistrationRequestType object data
		/// </summary>
		/// <param name="filer">filer object with data to map</param>
		/// <returns>returns RegistrationRequestType object with filled data</returns>
		private RegistrationRequestType MapFilerToRegisterRequestType(FilerModel filer)
		{
			//create new instance and assign data to all required properties
			return new RegistrationRequestType
			{
				City = filer.Firm.Address.City,
				CountryCode = filer.Firm.Address.CountryCode,
				Email = filer.EmailAddress,
				FirmName = filer.Firm.Name,
				FirstName = filer.FirstName,
				LastName = filer.LastName,
				MiddleName = filer.MiddleName ?? "",
				Password = filer.Password,
				PasswordQuestion = filer.SecurityQuestion,
				PasswordAnswer = filer.SecurityAnswer,
				PhoneNumber = filer.Firm.Phone,
				StateCode = filer.Firm.Address.State,
				StreetAddressLine1 = filer.Firm.Address.Address1,
				StreetAddressLine2 = filer.Firm.Address.Address2 ?? "",
				ZipCode = filer.Firm.Address.Zip,
			};
		}


		#region Notification Preferences
		/// <summary>
		/// This is the method to get eFile texas notification preferences from EFM
		/// </summary>
		/// <param name="filer">filer object for authentication to interact with EFM</param>
		/// <returns>returns  List<eFileTexasNotification> of notifications</returns>
		public List<eFileTexasNotificationModel> GetNotificationPreferencesList(FilerModel filer)
		{

			try
			{
				//create instance
				_efmFirmService = new EfmFirmServiceClient(); //create instance to firm service client
															  //add authentication details to the client object to interact with efm
				Util.AddAuthInfoToClient((EfmFirmServiceClient)_efmFirmService, filer.EmailAddress, filer.Password);
				//get all notications data from efm
				var response = _efmFirmService.GetNotificationPreferencesList();
				if (response.Error.ErrorCode != "0")//raise exception if any errors in response object //raise error if any errorcode is there in response
				{
					throw new AppException(response.Error.ErrorText, false, AppExceptionType.EFM);
				}
				//if NotificationList is not null , loop all data and assign  to the list items
				if (response.NotificationListItem != null)
				{
					var eFileTexasNotificationList = new List<eFileTexasNotificationModel>();
					foreach (var notificationListItem in response.NotificationListItem)
					{
						try
						{
							eFileTexasNotificationList.Add(new eFileTexasNotificationModel()
							{
								Code = notificationListItem.Code,
								Description = notificationListItem.Description
							});
						}
						catch (Exception e)
						{
							//_logger.LogError(string.Format("error while mapping service contact for {0}", notificationListItem.Description));
						}
					}
					return eFileTexasNotificationList;//return list to the caller
				}
				else { return new List<eFileTexasNotificationModel>(); }//if no data found return empty list.
			}
			catch (TimeoutException te)// this is to handle timeout exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				throw new Exception("The state eFiling system has stopped responding. We cannot proceed. Your information has been saved as a draft. You may continue this filing later.", te);
			}
			catch (CommunicationException ce) // this is to handle communication exceptions while interacting with EFM
			{
				throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, ce);
			}
			catch (Exception ex) // this is to handle general exceptions while interacting with EFM
			{
				((EfmFirmServiceClient)_efmFirmService).Abort();
				if (ex.Message.ToLower().Contains("unknown error"))//if error message has unknown error throw it as technical issue.
				{
					throw new AppException("eFile manager is experiencing technical issues.  Please try again later.", true, AppExceptionType.EFM, ex);
				}
				throw new AppException(ex.Message, true, AppExceptionType.EFM, ex);
			}
			finally
			{
				try
				{
					if ((_efmFirmService) != null)
						((EfmFirmServiceClient)_efmFirmService).Close();// close efm firm service client connection                   
				}
				catch (Exception exception)//This is to handle exceptions
				{// this is to handle general exceptions while closing efm objects
					throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, exception);
				}
			}
		}



		#endregion




	}
}