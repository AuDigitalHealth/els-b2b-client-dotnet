/*
 * Copyright 2011 NEHTA
 *
 * Licensed under the NEHTA Open Source (Apache) License; you may not use this
 * file except in compliance with the License. A copy of the License is in the
 * 'license.txt' file, which should be provided with this work.
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS, WITHOUT
 * WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the
 * License for the specific language governing permissions and limitations
 * under the License.
 */

using System;
using System.ServiceModel.Channels;
using Nehta.ELSv2010;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using Nehta.VendorLibrary.Common;
using Nehta.VendorLibrary.SM.ELS.Properties;

namespace Nehta.VendorLibrary.SM.ELS
{
    /// <summary>
    /// An implementation of a client for the Endpoint Location Service (ELS). This class may be used
    /// to connect to an ELS Server to do lookups and validations of interactions, or to publish interactions.
    /// </summary>
    public class ELSClient : IDisposable
    {
        internal Lookup lookupClient;
        internal Publish publishClient;

        internal SoapInspector.SoapMessages lookupMessages;
        internal SoapInspector.SoapMessages publishMessages;

        private string lastSoapRequest;
        private string lastSoapResponse;

        /// <summary>
        /// Gets the soap request xml for the last service call.
        /// </summary>
        public string LastSoapRequest
        {
            get
            {
                return lastSoapRequest;
            }
        }

        /// <summary>
        /// Gets the soap response xml for the last service call.
        /// </summary>
        public string LastSoapResponse
        {
            get
            {
                return lastSoapResponse;
            }
        }

        #region Constructors
        /// <summary>
        /// Initializes an instance of the ELSClient.
        /// </summary>
        /// <param name="lookupEndpointUrl">Web service endpoint for the ELS lookup service.</param>
        /// <param name="clientCertificate">Certificate containing this client's private key for establishing TLS connections.</param>
        public ELSClient(Uri lookupEndpointUrl, X509Certificate2 clientCertificate)
        {
            Validation.ValidateArgumentRequired("lookupEndpointUrl", lookupEndpointUrl);

            InitializeClient(lookupEndpointUrl.ToString(), null, clientCertificate, null, null);
        }

        /// <summary>
        /// Initializes an instance of the ELSClient.
        /// </summary>
        /// <param name="lookupEndpointUrl">Web service endpoint for the ELS lookup service.</param>
        /// <param name="publishEndpointUrl">Web service endpoint for the ELS publish service.</param>
        /// <param name="clientCertificate">Certificate containing this client's private key for establishing TLS connections.</param>
        public ELSClient(Uri lookupEndpointUrl, Uri publishEndpointUrl, X509Certificate2 clientCertificate)
        {
            Validation.ValidateArgumentRequired("lookupEndpointUrl", lookupEndpointUrl);
            Validation.ValidateArgumentRequired("publishEndpointUrl", publishEndpointUrl);

            InitializeClient(lookupEndpointUrl.ToString(), publishEndpointUrl.ToString(), clientCertificate, null, null);
        }
        
        /// <summary>
        /// Initializes an instance of the ELSClient.
        /// </summary>
        /// <param name="lookupEndpointConfigurationName">Endpoint configuration name for the lookup endpoint.</param>
        /// <param name="clientCertificate">Certificate containing this client's private key for establishing TLS connections.</param>
        public ELSClient(string lookupEndpointConfigurationName, X509Certificate2 clientCertificate)
        {
            Validation.ValidateArgumentRequired("lookupEndpointConfigurationName", lookupEndpointConfigurationName);

            InitializeClient(null, null, clientCertificate, lookupEndpointConfigurationName, null);
        }

        /// <summary>
        /// Initializes an instance of the ELSClient.
        /// </summary>
        /// <param name="lookupEndpointConfigurationName">Endpoint configuration name for the lookup endpoint.</param>
        /// <param name="publishEndpointConfigurationName">Endpoint configuration name for the publish endpoint.</param>
        /// <param name="clientCertificate">Certificate containing this client's private key for establishing TLS connections.</param>
        public ELSClient(string lookupEndpointConfigurationName, string publishEndpointConfigurationName, X509Certificate2 clientCertificate)
        {
            Validation.ValidateArgumentRequired("lookupEndpointConfigurationName", lookupEndpointConfigurationName);
            Validation.ValidateArgumentRequired("publishEndpointConfigurationName", publishEndpointConfigurationName);

            InitializeClient(null, null, clientCertificate, lookupEndpointConfigurationName, publishEndpointConfigurationName);
        }
        #endregion

        #region Lookup Operations

        /// <summary>
        /// Queries an ELS server for interactions for a target organisation.
        /// </summary>
        /// <param name="request">
        /// Information specifying the interactions to match.
        /// <list type="bullet">
        /// <item><description>serviceCategory (Mandatory): The service categories that should be matched.</description></item>
        /// <item><description>serviceInterface (Optional): The service interface of the interaction to be added.</description></item>
        /// <item><description>target (Mandatory): The qualified HPIO for the target organisation.</description></item>
        /// </list>
        /// </param>
        /// <returns>List of interaction types matching the query.</returns>
        public InteractionType[] ListInteractions(InteractionRequestType request)
        {
            Validation.ValidateArgumentRequired("request", request);
            //Only for testing
            //Validation.ValidateArgumentRequired("request.serviceCategory", request.serviceCategory);
            Validation.ValidateArgumentRequired("request.target", request.target);

            listInteractionsRequest envelope = new listInteractionsRequest();
            envelope.listInteractions = new listInteractions();
            envelope.listInteractions.interactionRequest = request;

            listInteractionsResponse response;
            try
            {
                response = lookupClient.listInteractions(envelope);
            }
            finally
            {
                SetLookupSoapMessages();
            }

            if (response != null)
                return response.listInteractionsResponse1;
            else
                throw new ApplicationException(Resources.UnexpectedServiceResponse);
        }

        /// <summary>
        /// Queries an ELS server to validate an interaction.
        /// </summary>
        /// <param name="request">
        /// Information specifying the interaction to validate.
        /// <list type="bullet">
        /// <item><description>serviceCategory (Mandatory): The service category of the interaction to be validated.</description></item>
        /// <item><description>serviceInterface (Mandatory): The service interface of the interaction to be validated.</description></item>
        /// <item><description>serviceEndpoint (Mandatory): The service endpoint of the interaction to be validated.</description></item>
        /// <item><description>serviceProvider (Mandatory): The service provider of the interaction to be validated.</description></item>
        /// <item><description>target (Mandatory): The qualified HPIO for the target organisation of the interaction to be validated.</description></item>
        /// <item><description>certRef (Optional): The certificate references of the interaction to be validated.</description></item>
        /// </list>
        /// </param>
        /// <returns><i>true</i> if the interaction is valid, otherwise <i>false</i>.</returns>
        public bool ValidateInteraction(InteractionType request)
        {
            Validation.ValidateArgumentRequired("request", request);
            Validation.ValidateArgumentRequired("request.serviceCategory", request.serviceCategory);
            Validation.ValidateArgumentRequired("request.serviceInterface", request.serviceInterface);
            Validation.ValidateArgumentRequired("request.serviceEndpoint", request.serviceEndpoint);
            Validation.ValidateArgumentRequired("request.serviceProvider", request.serviceProvider);
            Validation.ValidateArgumentRequired("request.target", request.target);

            validateInteractionRequest envelope = new validateInteractionRequest();
            envelope.validateInteraction = new validateInteraction();
            envelope.validateInteraction.interaction = request;

            validateInteractionResponse1 response;
            try
            {
                response = lookupClient.validateInteraction(envelope);
            }
            finally
            {
                SetLookupSoapMessages();
            }

            if (response != null && response.validateInteractionResponse != null)
                return response.validateInteractionResponse.isValid;
            else
                throw new ApplicationException(Resources.UnexpectedServiceResponse);
        }

        #endregion

        #region Publish Operations

        /// <summary>
        /// Adds an interaction to an ELS server.
        /// </summary>
        /// <param name="request">
        /// Information specifying the interaction to add.
        /// <list type="bullet">
        /// <item><description>serviceCategory (Mandatory): The service category of the interaction to be added.</description></item>
        /// <item><description>serviceInterface (Mandatory): The service interface of the interaction to be added.</description></item>
        /// <item><description>serviceEndpoint (Mandatory): The service endpoint of the interaction to be added.</description></item>
        /// <item><description>serviceProvider (Mandatory): The service provider of the interaction to be added.</description></item>
        /// <item><description>target (Mandatory): The qualified HPIO for the target organisation of the interaction to be added.</description></item>
        /// <item><description>certRef (Optional): The certificate references of the interaction to be added.</description></item>
        /// </list>
        /// </param>
        /// <returns>Value indicating if the operation is successful.</returns>
        public PublishReturnCodeType AddInteraction(InteractionType request)
        {
            if (publishClient == null) throw new ApplicationException(Resources.PublishEndpointNotSet);

            Validation.ValidateArgumentRequired("serviceCategory", request.serviceCategory);
            Validation.ValidateArgumentRequired("serviceInterface", request.serviceInterface);
            Validation.ValidateArgumentRequired("serviceEndpointUrl", request.serviceEndpoint);
            Validation.ValidateArgumentRequired("serviceProvider", request.serviceProvider);
            Validation.ValidateArgumentRequired("target", request.target);

            addInteractionRequest envelope = new addInteractionRequest();
            envelope.addInteraction = new addInteraction();
            envelope.addInteraction.interaction = request;

            addInteractionResponse1 response;
            try
            {
                response = publishClient.addInteraction(envelope);
            }
            finally
            {
                SetPublishSoapMessages();
            }

            if (response != null && response.addInteractionResponse != null)
                return response.addInteractionResponse.returnCode;
            else
                throw new ApplicationException(Resources.UnexpectedServiceResponse);
        }
                
        /// <summary>
        /// Removes an interaction from an ELS server.
        /// </summary>
        /// <param name="request">
        /// Information specifying the interaction to remove.
        /// <list type="bullet">
        /// <item><description>serviceCategory (Mandatory): The service category of the interaction to be removed.</description></item>
        /// <item><description>serviceInterface (Mandatory): The service interface of the interaction to be removed.</description></item>
        /// <item><description>serviceEndpoint (Mandatory): The service endpoint of the interaction to be removed.</description></item>
        /// <item><description>serviceProvider (Mandatory): The service provider of the interaction to be removed.</description></item>
        /// <item><description>target (Mandatory): The qualified HPIO for the target organisation of the interaction to be removed.</description></item>
        /// <item><description>certRef (Optional): The certificate references of the interaction to be removed.</description></item>
        /// </list>
        /// </param>
        /// <returns>Value indicating if the operation is successful.</returns>
        public PublishReturnCodeType RemoveInteraction(InteractionType request)
        {
            if (publishClient == null) throw new ApplicationException(Resources.PublishEndpointNotSet);

            Validation.ValidateArgumentRequired("serviceCategory", request.serviceCategory);
            Validation.ValidateArgumentRequired("serviceInterface", request.serviceInterface);
            Validation.ValidateArgumentRequired("serviceEndpoint", request.serviceEndpoint);
            Validation.ValidateArgumentRequired("serviceProvider", request.serviceProvider);
            Validation.ValidateArgumentRequired("target", request.target);
            
            removeInteractionRequest envelope = new removeInteractionRequest();
            envelope.removeInteraction = new removeInteraction();
            envelope.removeInteraction.interaction = request;

            removeInteractionResponse1 response;
            try
            {
                response = publishClient.removeInteraction(envelope);
            }
            finally
            {
                SetPublishSoapMessages();
            }

            if (response != null && response.removeInteractionResponse != null)
                return response.removeInteractionResponse.returnCode;
            else
                throw new ApplicationException(Resources.UnexpectedServiceResponse);
        }

        #endregion

        #region Private and internal methods
        /// <summary>
        /// Initialization work for the ELSClient.
        /// </summary>
        /// <param name="lookupEndpointUrl">Web service endpoint for the ELS lookup service.</param>
        /// <param name="publishEndpointUrl">Web service endpoint for the ELS publish service.</param>
        /// <param name="clientCertificate">Certificate containing this client's private key for establishing TLS connections.</param>
        /// <param name="lookupConfigurationName">Endpoint configuration name for the lookup endpoint.</param>
        /// <param name="publishConfigurationName">Endpoint configuration name for the publish endpoint.</param>
        private void InitializeClient(string lookupEndpointUrl, string publishEndpointUrl, X509Certificate2 clientCertificate, string lookupConfigurationName, string publishConfigurationName)
        {
            if (clientCertificate == null)
                throw new ArgumentException(Resources.InvalidClientCertificate);

            publishMessages = new SoapInspector.SoapMessages();
            lookupMessages = new SoapInspector.SoapMessages();
            lastSoapRequest = string.Empty;
            lastSoapResponse = string.Empty;

            CustomBinding tlsBinding = GetBinding();

            // Set up publish client
            PublishClient pubClient = null;
            if (!string.IsNullOrEmpty(publishConfigurationName))
                pubClient = new PublishClient(publishConfigurationName);
            else if (!string.IsNullOrEmpty(publishEndpointUrl))
            {
                EndpointAddress publishAddress = new EndpointAddress(publishEndpointUrl);
                pubClient = new PublishClient(tlsBinding, publishAddress);
            }
            if (pubClient != null)
            {
                if (clientCertificate != null) pubClient.ClientCredentials.ClientCertificate.Certificate = clientCertificate;
                SoapInspector.InspectEndpoint(pubClient.Endpoint, publishMessages);
                publishClient = pubClient;
            }

            // Set up lookup client
            LookupClient lookClient = null;
            if (!string.IsNullOrEmpty(lookupConfigurationName))
                lookClient = new LookupClient(lookupConfigurationName);
            else if (!string.IsNullOrEmpty(lookupEndpointUrl))
            {
                EndpointAddress lookupAddress = new EndpointAddress(lookupEndpointUrl);
                lookClient = new LookupClient(tlsBinding, lookupAddress);
            }
            if (lookClient != null)            
            {        
                if (clientCertificate != null) lookClient.ClientCredentials.ClientCertificate.Certificate = clientCertificate;
                SoapInspector.InspectEndpoint(lookClient.Endpoint, lookupMessages);
                lookupClient = lookClient;
            }
        }

        /// <summary>
        /// Gets the binding configuration for the client.
        /// </summary>
        /// <returns>Configured CustomBinding instance.</returns>
        internal CustomBinding GetBinding()
        {
            // Set up binding
            CustomBinding tlsBinding = new CustomBinding();

            TextMessageEncodingBindingElement tlsEncoding = new TextMessageEncodingBindingElement();
            tlsEncoding.ReaderQuotas.MaxDepth = 2147483647;
            tlsEncoding.ReaderQuotas.MaxStringContentLength = 2147483647;
            tlsEncoding.ReaderQuotas.MaxArrayLength = 2147483647;
            tlsEncoding.ReaderQuotas.MaxBytesPerRead = 2147483647;
            tlsEncoding.ReaderQuotas.MaxNameTableCharCount = 2147483647;

            HttpsTransportBindingElement httpsTransport = new HttpsTransportBindingElement();
            httpsTransport.RequireClientCertificate = true;
            httpsTransport.MaxReceivedMessageSize = 2147483647;
            httpsTransport.MaxBufferSize = 2147483647;

            tlsBinding.Elements.Add(tlsEncoding);
            tlsBinding.Elements.Add(httpsTransport);

            return tlsBinding;
        }

        /// <summary>
        /// Sets lastSoapRequest and lastSoapResponse to the messages set on the Lookup client.
        /// </summary>
        private void SetLookupSoapMessages()
        {
            lastSoapRequest = lookupMessages.SoapRequest;
            lastSoapResponse = lookupMessages.SoapResponse;
        }

        /// <summary>
        /// Sets lastSoapRequest and lastSoapResponse to the messages set on the Publish client.
        /// </summary>
        private void SetPublishSoapMessages()
        {
            lastSoapRequest = publishMessages.SoapRequest;
            lastSoapResponse = publishMessages.SoapResponse;
        }
        #endregion

        #region IDisposable Members

        /// <summary>
        /// Closes and disposes the client.
        /// </summary>
        public void Dispose()
        {
            ClientBase<Lookup> lClient;
            ClientBase<Publish> pClient;

            if (lookupClient is ClientBase<Lookup>)
            {
                lClient = (ClientBase<Lookup>)lookupClient;
                if (lClient.State != CommunicationState.Closed)
                    lClient.Close();
            }

            if (publishClient is ClientBase<Publish>)
            {
                pClient = (ClientBase<Publish>)publishClient;
                if (pClient.State != CommunicationState.Closed)
                    pClient.Close();
            }
        }

        #endregion

    }
}
