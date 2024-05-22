using System.Collections.Generic;
using Nehta.ELSv2010;

namespace Nehta.VendorLibrary.SM.ELS
{
    /// <summary>
    /// Extension methods to assist with ELS service.
    /// </summary>
    public static class ELSExtensions
    {
        /// <summary>
        /// Adds a new ElsCertRefType to a generic list of ElsCertRefType.
        /// </summary>
        /// <param name="certRefs">The current list of ElsCertREfType.</param>
        /// <param name="useQualifier">The use qualifier of the certificate.</param>
        /// <param name="type">The type of certificate.</param>
        /// <param name="value">The value of the certificate.</param>
        public static void AddCertRef(this List<ElsCertRefType> certRefs, string useQualifier, string type, string value)
        {
            certRefs.Add(new ElsCertRefType()
            {
                useQualifier = useQualifier,
                qualifiedCertRef = new QualifiedCertRefType()
                {
                    type = type,
                    value = value
                }
            });
        }

        /// <summary>
        /// ApplicationException CertRefsNotSet 
        /// </summary>
        public const string CertRefsNotSet = "certRefs must be instantiated with at least one certificate reference";

        /// <summary>
        /// ApplicationException InvalidClientCertificate 
        /// </summary>
        public const string InvalidClientCertificate = "clientCertificate must be a valid X509Certificate2 object";

        /// <summary>
        /// ApplicationException LookupEndpointNotSet 
        /// </summary>
        public const string LookupEndpointNotSet = "lookupEndpointUrl or lookupEndpointConfigurationName must be specified in the ELSClient constructor for this operation";

        /// <summary>
        /// ApplicationException PublishEndpointNotSet 
        /// </summary>
        public const string PublishEndpointNotSet = "publishEndpointUrl or publishEndpointConfigurationName must be specified in the ELSClient constructor for this operation";


        /// <summary>
        /// ApplicationException UnexpectedServiceResponse 
        /// </summary>
        public const string UnexpectedServiceResponse = "Unexpected response received from the service";
    }
}
