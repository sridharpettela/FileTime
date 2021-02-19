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
        //To get filer details with username and password
        Task<UserLoginResponseModel> LoginAsync(UserLoginRequestModel requestModel);

        ////to reset the password
        string ResetPassword(string emailAddress);


        ////to get password question asynchronously
        Task<string> GetPasswordQuestionAsync(string emailAddress);

        ////to get password question  details
        string GetPasswordQuestion(string emailAddress);

        ////to reset and password of a filer
        string ChangePassword(FilerModel filer, string password, string newPassword, string question, string answer);

             

        ////get user details from efm with efm id asynchronously
        Task<FilerModel> GetUserFromEFMAsync(string username, string password, string EfmId);

        ////get user details from efm with efm id        
        FilerModel GetUserFromEFM(string username, string password, string EfmId);

        ////to send self activation mail to the user
        bool SelfResendActivationEmail(string emailAddress);

        ////to get efile texas notification preferences of a filer
        List<eFileTexasNotificationModel> GetNotificationPreferences(FilerModel filer);

        ////to update notofication preferences of a filer
        void UpdateNotificationPreferences(FilerModel filer);
    }


}

    