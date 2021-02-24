using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileTime.EFMApi.Models.User;
using FileTime.EFMApi.Models.Court;

namespace FileTime.EFMApi.Wrappers.Interface
{
	interface IFirmServiceWrapper
	{
		//to register the new firm details in efm       
		bool RegisterFirm(FilerModel filer);
		////get firm details by username and password asynchronously
		Task<FirmModel> GetFirmAsync(string username, string password);

		////get firm details by username and password 
		FirmModel GetFirm(string username, string password);

		///*Task<Filer> GetFilerAndFirmAsync(string username, string password, string filerEfmId);*/
		
		////get filer detailsfrom efm asynchronously
		Task<IEnumerable<FilerModel>> GetFilersAsync(string adminEmail, string adminPassword);

		////get all filers data of a firm
		IEnumerable<FilerModel> GetFilers(string adminEmail, string adminPassword);

		////to update roles of a filer in efm
		bool UpdateRoles(FilerModel filer);

		////to update details of registered filer in efm
		bool RegisterFiler(FilerModel filer, FilerModel admin);
		////to update firm details in efm
		void UpdateFirm(FirmModel firm, FilerModel admin);
		////to update firm details in efm
		void UpdateFirm(FirmModel firm, FilerModel admin, string StateKeyConfig);
		////to update filer details in efm
		void UpdateFiler(FilerModel filer, FilerModel admin);
		////to add payment account details in nefm
		void AddPaymentAccont(PaymentAccountModel paymentaccount, FilerModel filer);
		////to delete payment account details in nefm
		void DeletePaymentAccount(string paymentAccountId, FilerModel admin);
		////
		//PaymentAccount GetPaymentAccount(string paymentAccountId, FilerModel admin);
		////to delete filer details in nefm
		void DeleteFiler(FilerModel filer, FilerModel admin);
		void DeleteFiler(FilerModel filer, FilerModel admin, string StateKeyConfig);
		////to resend avtication meail to the filer
		bool ResendActivationEmail(FilerModel filer, FilerModel admin);
		////to resend avtication meail to the filer
		bool ResendActivationEmail(FilerModel filer);

		////to reset filer password details
		string ResetUserPassword(FilerModel filer, string password, FilerModel admin);
		////to get service contacts of a filer
		IEnumerable<ServiceContactModel> GetServiceContacts(FilerModel filer);
		IEnumerable<ServiceContactModel> GetServiceContacts(FilerModel filer, string StateKeyConfig);
		////to get service contacts of a asynchronously
		Task<IEnumerable<ServiceContactModel>> GetServiceContactsAsync(FilerModel filer);
		////to get service contact by its id
		ServiceContactModel GetServiceContact(string serviceContactId, FilerModel admin);
		void AddServiceContact(ServiceContactModel serviceContact, FilerModel admin);
		////to update service contactdetails in efm
		void UpdateServiceContact(ServiceContactModel serviceContact, FilerModel admin);
		////to delete service contactdetails in efm
		void DeleteServiceContact(string serviceContactId, FilerModel admin);
		////to get payment accounts data of a filer
		IEnumerable<PaymentAccountModel> GetPaymentAccounts(FilerModel filer);
		IEnumerable<PaymentAccountModel> GetPaymentAccounts(FilerModel filer, string StateKeyConfig);
		//to get payment accounts data of filer asynchronously
		Task<IEnumerable<PaymentAccountModel>> GetPaymentAccountsAsync(FilerModel filer);
		////to get attorneys data asynchronously
		Task<IEnumerable<AttorneyModel>> GetAttorneysAsync(string username, string password);
		IEnumerable<AttorneyModel> GetAttorneys(string username, string password);
		////to get attorneys details of a admin filer and attorney
		AttorneyModel GetAttorney(string attorneyId, FilerModel admin);
		////to add  Attorney details in efm
		void AddAttorney(AttorneyModel Attorney, FilerModel admin);
		////to uodate  Attorney details in efm
		void UpdateAttorney(AttorneyModel attorney, FilerModel admin);
		////to delete  Attorney details in efm
	     void DeleteAttorney(string attorney, FilerModel admin);

		////to detach service contacts
		void DetachServiceContact(string serviceContactId, string CaseTrackingId, FilerModel admin);

		////to attach service contacts
		void AttachServiceContact(string serviceContactId, string CaseTrackingId, string casePartyEmfId, FilerModel admin);

		////To create a new Global Payment Account
		void AddGlobalPaymentAccount(PaymentAccountModel paymentaccount);
		////To create a new Global Payment Account with statekey
		void AddGlobalPaymentAccountWithStateKey(PaymentAccountModel paymentaccount);
		////To delete a Global Payment Account
		void DeleteGlobalPaymentAccount(string paymentAccountId);
		////To get list of Global Payment Account
		void GetGlobalPaymentAccountList();
		IEnumerable<ServiceContactModel> GetPublicServiceContactLists(string firstName, string lastName, string firmName, string emailAddress, FilerModel filer);
		IEnumerable<ServiceContactModel> GetPublicServiceContactLists(string firstName, string lastName, string firmName, string emailAddress, FilerModel filer, string stateKeyConfig);

		////to get Notification Preferences data in list format
		List<eFileTexasNotificationModel> GetNotificationPreferencesList(FilerModel filer);

	}
}
