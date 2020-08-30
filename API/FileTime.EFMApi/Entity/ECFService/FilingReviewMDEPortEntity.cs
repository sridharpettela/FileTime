using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Linq;

namespace FileTime.EFMApi.Entity.ECFService
{
	#region GetFilingService
	#region Request
	[DebuggerStepThroughAttribute()]
	[GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	[MessageContractAttribute(IsWrapped = false)]
	public partial class GetFilingServiceRequest
	{
		[MessageBodyMemberAttribute(Name = "FTXmlRequest", Namespace = "http://filetime.com/", Order = 0)]
		[System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 0)]
		public XElement FTXmlRequest;

		public GetFilingServiceRequest()
		{
		}

		public GetFilingServiceRequest(XElement FTXmlRequest)
		{
			this.FTXmlRequest = FTXmlRequest;
		}
	}
	#endregion

	#region Response
	[DebuggerStepThroughAttribute()]
	[GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	[MessageContractAttribute(IsWrapped = false)]
	public partial class GetFilingServiceResponse
	{
		[MessageBodyMemberAttribute(Name = "FTXmlResponse", Namespace = "http://filetime.com/", Order = 0)]
		public XElement FTXmlResponse;

		public GetFilingServiceResponse()
		{
		}

		public GetFilingServiceResponse(XElement FTXmlResponse)
		{
			this.FTXmlResponse = FTXmlResponse;
		}
	}
	#endregion
	#endregion

	#region  GetFilingList
	#region Request
	[DebuggerStepThroughAttribute()]
	[GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	[MessageContractAttribute(IsWrapped = false)]
	public partial class GetFilingListRequest
	{

		[MessageBodyMemberAttribute(Name = "FTXmlRequest", Namespace = "http://filetime.com/", Order = 0)]
		[System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 0)]
		public XElement FTXmlRequest;

		public GetFilingListRequest()
		{
		}

		public GetFilingListRequest(XElement FTXmlRequest)
		{
			this.FTXmlRequest = FTXmlRequest;
		}
	}
	#endregion

	#region Response
	[DebuggerStepThroughAttribute()]
	[GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	[MessageContractAttribute(IsWrapped = false)]
	public partial class GetFilingListResponse
	{
		[MessageBodyMemberAttribute(Name = "FTXmlResponse", Namespace = "http://filetime.com/", Order = 0)]
		public XElement FTXmlResponse;

		public GetFilingListResponse()
		{
		}

		public GetFilingListResponse(XElement FTXmlResponse)
		{
			this.FTXmlResponse = FTXmlResponse;
		}
	}
	#endregion
	#endregion

	#region GetFilingDetails
	#region Request
	[DebuggerStepThroughAttribute()]
	[GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	[MessageContractAttribute(IsWrapped = false)]
	public partial class GetFilingDetailsRequest
	{
		[MessageBodyMemberAttribute(Name = "FTXmlRequest", Namespace = "http://filetime.com/", Order = 0)]
		[System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 0)]
		public XElement FTXmlRequest;

		public GetFilingDetailsRequest()
		{
		}

		public GetFilingDetailsRequest(XElement FTXmlRequest)
		{
			this.FTXmlRequest = FTXmlRequest;
		}
	}
	#endregion
	#region Response
	[DebuggerStepThroughAttribute()]
	[GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	[MessageContractAttribute(IsWrapped = false)]
	public partial class GetFilingDetailsResponse
	{
		[MessageBodyMemberAttribute(Name = "FTXmlResponse", Namespace = "http://filetime.com/", Order = 0)]
		public XElement FTXmlResponse;

		public GetFilingDetailsResponse()
		{
		}

		public GetFilingDetailsResponse(XElement FTXmlResponse)
		{
			this.FTXmlResponse = FTXmlResponse;
		}
	}
	#endregion
	#endregion

	#region GetFilingStatus
	#region Request
	[DebuggerStepThroughAttribute()]
	[GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	[MessageContractAttribute(IsWrapped = false)]
	public partial class GetFilingStatusRequest
	{
		[MessageBodyMemberAttribute(Name = "FTXmlRequest", Namespace = "http://filetime.com/", Order = 0)]
		[System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 0)]
		public XElement FTXmlRequest;

		public GetFilingStatusRequest()
		{
		}

		public GetFilingStatusRequest(XElement FTXmlRequest)
		{
			this.FTXmlRequest = FTXmlRequest;
		}
	}
	#endregion

	#region Response
	[DebuggerStepThroughAttribute()]
	[GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
	[MessageContractAttribute(IsWrapped = false)]
	public partial class GetFilingStatusResponse
	{
		[MessageBodyMemberAttribute(Name = "FTXmlResponse", Namespace = "http://filetime.com/", Order = 0)]
		public XElement FTXmlResponse;

		public GetFilingStatusResponse()
		{
		}

		public GetFilingStatusResponse(XElement FTXmlResponse)
		{
			this.FTXmlResponse = FTXmlResponse;
		}
	}
	#endregion
	#endregion
}
