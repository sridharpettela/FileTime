using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace FileTime.EFMApi.Entity
{
	[MessageContract(WrapperName = "urn", WrapperNamespace = "urn:tyler:efm:services"), DataContract()]
	public class EFMCredentials
	{

		public const string CredentialsHeader = "UserNameHeader";
		public const string CredentialsNamespace = "urn:tyler:efm:services";

		[DataMember(Order = 1)]
		[MessageBodyMember(Namespace = "urn:tyler:efm:services")]
		public string UserName { get; set; }
		[DataMember(Order = 2)]
		[MessageBodyMember(Namespace = "urn:tyler:efm:services")]
		public string Password { get; set; }

		public MessageHeader ToMessageHeader()
		{
			MessageHeader header = MessageHeader.CreateHeader(CredentialsHeader, CredentialsNamespace, this);
			return header;
		}

		public static EFMCredentials FromMessageHeader(Message message)
		{
			EFMCredentials credentials = null;

			int tokenPosition = message.Headers.FindHeader(CredentialsHeader, CredentialsNamespace);
			if (tokenPosition >= 0)
			{
				credentials = message.Headers.GetHeader<EFMCredentials>(tokenPosition);
			}
			return credentials;
		}
	}
}