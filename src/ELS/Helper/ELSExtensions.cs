using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    }
}
