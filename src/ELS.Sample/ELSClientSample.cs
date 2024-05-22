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
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Nehta.VendorLibrary.Common;
using Nehta.ELSv2010;

namespace Nehta.VendorLibrary.SM.ELS.Sample
{
    /// <summary>
    /// Requirements to using the ELS Client:
    /// a) A certificate for authenticating the client to an ELS server during the Transport Layer
    ///    Security (TLS) connection.
    /// b) The Lookup and Publish TLS web services endpoint URLs for your ELS server(s).
    /// </summary>
    class ELSClientSample
    {
        public void Sample()
        {
            // ------------------------------------------------------------------------------
            // Set up
            // ------------------------------------------------------------------------------

            // Obtain the certificate by serial number
            X509Certificate2 tlsCert = X509CertificateUtil.GetCertificate(
                "Serial Number",
                X509FindType.FindBySerialNumber,
                StoreName.My,
                StoreLocation.CurrentUser,
                true
                );

            // ------------------------------------------------------------------------------
            // Client instantiation
            // ------------------------------------------------------------------------------

            // Instantiating the client with the client certificate and client service endpoint 
            // url in "Lookup" mode. Only operations associated with the "Lookup" interface
            // can be invoked
            ELSClient lookupClient = new ELSClient(
                new Uri("https://LookupServiceEndpointUrl"),
                tlsCert);

            // Instantiating the client with the client certificate and client service endpoint urls 
            // in "Lookup and Publish" mode. Operations associated with both "Lookup" and "Publish"
            // interfaces can be invoked
            ELSClient lookupAndPublishClient = new ELSClient(
                new Uri("https://LookupServiceEndpointUrl"),
                new Uri("https://PublishServiceEndpointUrl"),
                tlsCert);

            // ------------------------------------------------------------------------------
            // List
            // ------------------------------------------------------------------------------

            // Set up request
            InteractionRequestType listRequest = new InteractionRequestType();
            listRequest.serviceCategory = new string[] { "ServiceCategoryToList" };
            listRequest.serviceInterface = new string[] { "ServiceInterfaceToList" };
            listRequest.target = HIQualifiers.HPIOQualifier + "16 digit HPIO of target organisation";

            // Invoke operation
            InteractionType[] interactions = lookupAndPublishClient.ListInteractions(listRequest);

            // ------------------------------------------------------------------------------
            // Validate
            // ------------------------------------------------------------------------------

            // Set up interaction to validate
            InteractionType validateInteraction = new InteractionType();
            validateInteraction.serviceCategory = "ServiceCategoryToValidate";
            validateInteraction.serviceEndpoint = "https://EndpointToValidate";
            validateInteraction.serviceInterface = "ServiceInterfacetoValidate";
            validateInteraction.serviceProvider = HIQualifiers.HPIOQualifier + "16 digit HPIO of service provider organisation to validate";
            validateInteraction.target = HIQualifiers.HPIOQualifier + "16 digit HPIO of target organisation to validate";

            // Invoke operation
            lookupAndPublishClient.ValidateInteraction(validateInteraction);

            // ------------------------------------------------------------------------------
            // Add
            // ------------------------------------------------------------------------------

            // Set up cert ref
            List<ElsCertRefType> addCertRefList = new List<ElsCertRefType>();
            addCertRefList.AddCertRef(
                ELSCertRefContants.Qualifier,
                ELSCertRefContants.Type,
                X509CertificateUtil.GetCertificatePEM(tlsCert));

            // Set up interaction to add
            InteractionType addInteraction = new InteractionType();
            validateInteraction.serviceCategory = "ServiceCategoryToAdd";
            validateInteraction.serviceEndpoint = "https://EndpointToAdd";
            validateInteraction.serviceInterface = "ServiceInterfacetoAdd";
            validateInteraction.serviceProvider = HIQualifiers.HPIOQualifier + "16 digit HPIO of service provider organisation to add";
            validateInteraction.target = HIQualifiers.HPIOQualifier + "16 digit HPIO of target organisation to add";
            validateInteraction.certRef = addCertRefList.ToArray();

            // Invoke operation
            lookupAndPublishClient.AddInteraction(addInteraction);

            // ------------------------------------------------------------------------------
            // Remove
            // ------------------------------------------------------------------------------

            // Set up interaction to remove
            InteractionType removeInteraction = new InteractionType();
            removeInteraction.serviceCategory = "ServiceCategoryToRemove";
            removeInteraction.serviceEndpoint = "https://EndpointToRemove";
            removeInteraction.serviceInterface = "ServiceInterfacetoRemove";
            removeInteraction.serviceProvider = HIQualifiers.HPIOQualifier + "16 digit HPIO of service provider organisation to remove";
            removeInteraction.target = HIQualifiers.HPIOQualifier + "16 digit HPIO of target organisation to remove";

            // Invoke operation
            lookupAndPublishClient.RemoveInteraction(removeInteraction);
        }
    }
}
