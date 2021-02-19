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
		private ILogger _logger;
		// efm firm service variable
		private IEfmFirmService _efmFirmService;
		// efm firm service client variable		
		private ClientBase<IEfmFirmService> _efmUserServiceClient; // efm client

		#endregion		
		

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
				//_logger.LogTrace(string.Format(ce.Message));
				throw Util.BuildWcfException((EfmFirmServiceClient)_efmFirmService, ce);
			}
			catch (Exception ex) // this is to handle general exceptions while interacting with EFM
			{
				//_logger.LogTrace(string.Format(ex.Message));
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
	/// This is the method to get firm details from efm asynchronously.
	/// </summary>
	/// <param name="username">username for authenticating the user</param>
	/// <param name="password">password for authenticating the user</param>
	/// <returns>returns firm object with data</returns>
	/// 
	
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
  }
}