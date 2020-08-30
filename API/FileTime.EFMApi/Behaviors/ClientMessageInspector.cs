using FileTime.EFMApi.Core;
using FileTime.EFMApi.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Configuration;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.Text;
using System.Web;
using System.Xml;

namespace FileTime.EFMApi.Behaviors
{
	public class ClientMessageInspector : BehaviorExtensionElement, IClientMessageInspector, IEndpointBehavior, IDispatchMessageInspector
	{
		public EFMCredentials Credentials { get; set; }


		public ILogger<ClientMessageInspector> Logger
		{
			get { return new NLogger<ClientMessageInspector>(); }
		}

		public override Type BehaviorType
		{
			get { return GetType(); }
		}

		#region IClientMessageInspector Members

		public void AfterReceiveReply(ref Message reply, object correlationState)
		{
			MessageBuffer buffer = reply.CreateBufferedCopy(Int32.MaxValue);
			reply = buffer.CreateMessage();
			Message msg = buffer.CreateMessage();
			StringBuilder sb = new StringBuilder();
			XmlWriter xw = XmlWriter.Create(sb);
			msg.WriteBody(xw);
			xw.Close();
			Logger.LogTrace(string.Format("\nReceived: \n{0}", msg.ToString()));
			Logger.LogTrace(string.Format("\nBody: \n{0}", sb.ToString()));

			//------------------------------------------------------------------------
			if (
					sb.ToString().Contains("CaseListResponseMessage")
				|| sb.ToString().Contains("ServiceAttachCaseListResponseMessage")
				|| sb.ToString().Contains("CaseResponseMessage")
				|| sb.ToString().Contains("ServiceInformationResponseMessage")
				|| sb.ToString().Contains("ServiceInformationHistoryResponseMessage")
				|| sb.ToString().Contains("CourtPolicyResponseMessage")
				|| sb.ToString().Contains("FilingListResponseMessage") || sb.ToString().Contains("FilingDetailResponseMessage")
				|| sb.ToString().Contains("FilingStatusResponseMessage")
				|| sb.ToString().Contains("CancelFilingResponseMessage")
				|| sb.ToString().Contains("FeesCalculationResponseMessage")
				|| sb.ToString().Contains("MessageReceiptMessage")
				|| sb.ToString().Contains("FilingServiceResponseMessage") || sb.ToString().Contains("ServiceReceiptMessage")
				 || sb.ToString().Contains("ReturnDateResponseMessage") || sb.ToString().Contains("ReserveCourtDateSyncResponse")
				)
			{
				MemoryStream memStream = new MemoryStream();
				XmlDictionaryWriter xdw = XmlDictionaryWriter.CreateBinaryWriter(memStream);
				XmlDictionaryReader xDicReader = reply.GetReaderAtBodyContents();

				xdw.WriteStartElement("FTXmlResponse", "http://filetime.com/");
				xdw.WriteNode(xDicReader, false);
				xdw.WriteEndElement();
				xdw.Flush();
				memStream.Position = 0;

				XmlDictionaryReaderQuotas quotas = new XmlDictionaryReaderQuotas();
				XmlDictionaryReader xdr = XmlDictionaryReader.CreateBinaryReader(memStream, quotas);

				Message replacedMessage = Message.CreateMessage(reply.Version, null, xdr);
				replacedMessage.Headers.CopyHeadersFrom(reply.Headers);
				replacedMessage.Properties.CopyProperties(reply.Properties);
				reply = replacedMessage;
			}

		}

		public object BeforeSendRequest(ref Message request, IClientChannel channel)
		{
			request.Headers.Add(Credentials.ToMessageHeader());

			request = AddCustomNamespace(request);

			MessageBuffer buffer = request.CreateBufferedCopy(Int32.MaxValue);
			var tempRequest = buffer.CreateMessage();
			HttpRequestMessageProperty httpRequest = GetHttpRequestProp(tempRequest);
			if (httpRequest != null)
			{
				if (string.IsNullOrEmpty(httpRequest.Headers[HttpRequestHeader.ContentLength]))
				{
					httpRequest.Headers.Add(HttpRequestHeader.ContentLength, buffer.BufferSize.ToString());
					Logger.LogTrace(string.Format("\nContentLength: \n{0}", buffer.BufferSize.ToString()));
				}

			}
			request = tempRequest;
			request.Properties[HttpRequestMessageProperty.Name] = httpRequest;

			Logger.LogTrace(string.Format("\nSending: \n{0}", buffer.CreateMessage()));
			return null;
		}

		private HttpRequestMessageProperty GetHttpRequestProp(Message request)
		{
			if (!request.Properties.ContainsKey(HttpRequestMessageProperty.Name))
			{
				request.Properties.Add(HttpRequestMessageProperty.Name, new HttpRequestMessageProperty());
			}
			return request.Properties[HttpRequestMessageProperty.Name] as HttpRequestMessageProperty;
		}

		private Message AddCustomNamespace(Message reply)
		{
			Message newReply;

			MessageBuffer buffer = reply.CreateBufferedCopy(Int32.MaxValue);
			reply = buffer.CreateMessage();
			Message msg = buffer.CreateMessage();
			StringBuilder sb = new StringBuilder();
			XmlWriter xw = XmlWriter.Create(sb);
			msg.WriteMessage(xw);
			xw.Close();
			var strXmlString = sb.ToString().Replace("<FTXmlRequest xmlns=\"http://filetime.com/\">", "").Replace("</FTXmlRequest>", "");
			var doc = new XmlDocument();
			doc.LoadXml(strXmlString);

			if (doc.GetElementsByTagName("s:Envelope").Count > 0)
			{
				var myElement = (XmlElement)(doc.GetElementsByTagName("s:Envelope").Item(0));
				myElement.SetAttribute("xmlns:" + "urn",
									   "urn:tyler:efm:services");

				var nms = new MemoryStream();
				XmlDictionaryWriter newWriter = XmlDictionaryWriter.CreateTextWriter(nms);
				doc.WriteTo(newWriter);
				newWriter.Flush();
				nms.Position = 0;
				var reader = XmlDictionaryReader.CreateTextReader(nms, XmlDictionaryReaderQuotas.Max);
				newReply = Message.CreateMessage(reader, int.MaxValue, reply.Version);
			}
			else
			{
				newReply = reply;
			}
			return newReply;
		}

		#endregion

		#region IEndpointBehavior Members

		public void AddBindingParameters(ServiceEndpoint endpoint, BindingParameterCollection bindingParameters)
		{
		}

		public void ApplyClientBehavior(ServiceEndpoint endpoint, ClientRuntime clientRuntime)
		{
			return;
		}

		public void ApplyDispatchBehavior(ServiceEndpoint endpoint, EndpointDispatcher endpointDispatcher)
		{
		}

		public void Validate(ServiceEndpoint endpoint)
		{
		}

		#endregion

		protected override object CreateBehavior()
		{
			return this;
		}

		public object AfterReceiveRequest(ref Message request, IClientChannel channel, InstanceContext instanceContext)
		{
			request.Headers.Add(Credentials.ToMessageHeader());
			return null;
		}

		public void BeforeSendReply(ref Message reply, object correlationState)
		{
		}
	}
}