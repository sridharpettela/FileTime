using FileTime.EFMApi.CourtRecordMDEServices;
using FileTime.EFMApi.Wrappers.Interface;
using System.ServiceModel;

namespace FileTime.EFMApi.Wrappers
{
	public class CourtRecordWrapper: ICourtRecordWrapper
	{
		private CourtRecordMDEPort _courtRecordMdeService;
		private ClientBase<CourtRecordMDEPort> _efmCourtServiceClient;

		~CourtRecordWrapper()
		{
			var clientObject = _courtRecordMdeService as CourtRecordMDEPortClient;
			if (clientObject != null && clientObject.State == System.ServiceModel.CommunicationState.Opened)
			{
				clientObject.Close();
			}
		}
	}
}