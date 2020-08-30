using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.Web;

namespace FileTime.EFMApi.Behaviors
{
	public class AuthHeaderBehavior : IEndpointBehavior
	{
		//the message inspector we will want to add to the client proxy
		private readonly ClientMessageInspector _clientMessageInspector;

		public AuthHeaderBehavior(ClientMessageInspector clientMessageInspector)
		{
			_clientMessageInspector = clientMessageInspector;
		}

		//required functions for the interface, we are only interested in the client behavior in this scenario

		#region IEndpointBehavior Members

		public void AddBindingParameters(ServiceEndpoint endpoint, BindingParameterCollection bindingParameters)
		{
		}

		public void ApplyClientBehavior(ServiceEndpoint endpoint, ClientRuntime clientRuntime)
		{
			clientRuntime.MessageInspectors.Add(_clientMessageInspector);
		}

		public void ApplyDispatchBehavior(ServiceEndpoint endpoint, EndpointDispatcher endpointDispatcher)
		{
		}

		public void Validate(ServiceEndpoint endpoint)
		{
		}

		#endregion
	}
}