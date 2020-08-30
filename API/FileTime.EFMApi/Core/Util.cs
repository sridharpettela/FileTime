using FileTime.EFMApi.Behaviors;
using FileTime.EFMApi.Entity;
using FileTime.EFMApi.Entity.ECFService;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Web;
using System.Web.Services.Protocols;
using System.Xml;
using System.Xml.XPath;

namespace FileTime.EFMApi.Core
{
    public static class Util
    {
        public static void AddAuthInfoToClient<T>(ClientBase<T> client, string username, string password)
            where T : class
        {
            if (string.IsNullOrEmpty(username))
            {
                throw new ArgumentException("Must supply a use name");
            }

            if (string.IsNullOrEmpty(password))
            {
                throw new ArgumentException("Must supply a Password");
            }
            if (client.Endpoint.Behaviors.Contains(typeof(AuthHeaderBehavior)))
            {
                client.Endpoint.Behaviors.Remove(typeof(AuthHeaderBehavior));
            }

            var inserter = new ClientMessageInspector
            {
                Credentials =
                    new EFMCredentials { UserName = username, Password = password }
            };
            client.Endpoint.Behaviors.Add(new AuthHeaderBehavior(inserter));

        }

        public static void HandleEFMError(IEnumerable<ErrorType> errorTypes)
        {
            throw new AppException(string.Format("Errors: {0}",
                                                 errorTypes.Select(x => x.ErrorText.Value)
                                                                               .Aggregate("\n",
                                                                                          (current, error) =>
                                                                                          current + (error + "\n"))), true,
                                   AppExceptionType.EFM);
        }

        public static SoapException BuildWcfException<TChannel>(ClientBase<TChannel> wcf, Exception ex)
            where TChannel : class
        {
            SoapException soapEx;
            try
            {
                soapEx = BuildSoapException(ex, ex.InnerException);
            }
            catch (Exception buildEx)
            {
                string exMsg = ex.Message;
                var sb = new StringBuilder();
                sb.AppendLine(exMsg);
                sb.AppendLine("================= wcf.abort() exception trace ===============");
                sb.AppendLine(buildEx.ToString());
                exMsg = sb.ToString();
                soapEx = new SoapException("General Web Exception on: " + exMsg, XmlQualifiedName.Empty, ex);
            }

            try
            {
                if (wcf != null) wcf.Abort();
            }
            catch (Exception abortEx)
            {
                soapEx = BuildSoapException(ex, abortEx);
            }

            return soapEx;
        }

        public static SoapException BuildSoapException(Exception commEx, Exception innerException)
        {
            XPathDocument xPath;
            try
            {
                xPath = new XPathDocument(new StringReader(commEx.Message));
            }
            catch (Exception ex)
            {
                return new SoapException(commEx.Message, SoapException.ClientFaultCode);
            }
            XPathNavigator binder = xPath.CreateNavigator();

            string errorCode = GetValue(binder, "detail/detailElement/@errorCode");
            string errorMsg = GetValue(binder, "detail/detailElement");
            int errorCodeValue = 0;
            try
            {
                errorCodeValue = int.Parse(errorCode);
            }
            catch
            {
                throw new ApplicationException(string.Format("Unable to parse: {0} for error code", errorCodeValue));
            }
            var xDoc = new XmlDocument();
            XmlNode node = xDoc.CreateNode(XmlNodeType.Element, SoapException.DetailElementName.Name,
                                           SoapException.DetailElementName.Namespace);
            XPathNavigator selectSingleNode = binder.SelectSingleNode("detail");
            if (selectSingleNode != null) node.InnerXml = selectSingleNode.InnerXml;
            string uri = OperationContext.Current == null
                             ? "urn:kpmg-com:efiling-texas"
                             : OperationContext.Current.Channel.LocalAddress.Uri.AbsoluteUri;
            SoapException soapEx = innerException == null
                                       ? new SoapException(errorMsg, SoapException.ClientFaultCode, uri, node)
                                       : new SoapException(errorMsg, SoapException.ClientFaultCode, uri, node,
                                                           innerException);
            return soapEx;
        }

        /// <summary>
        ///  // helper function to retrieve a text from the current element
        /// </summary>
        /// <param name="nav"></param>
        /// <param name="xPathExpression"></param>
        /// <returns></returns>
        private static string GetValue(XPathNavigator nav, string xPathExpression)
        {
            object result = nav.Evaluate(xPathExpression);

            if (result is XPathNodeIterator)
            {
                var resultIterator = result as XPathNodeIterator;
                if (resultIterator.MoveNext())
                {
                    if (resultIterator.Current != null) return resultIterator.Current.Value;
                }
            }

            return "";
        }
    }
}