// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Managed Certificate used for https. </summary>
    public partial class ManagedCertificateProperties : SecretProperties
    {
        /// <summary> Initializes a new instance of ManagedCertificateProperties. </summary>
        public ManagedCertificateProperties()
        {
            SecretType = SecretType.ManagedCertificate;
        }

        /// <summary> Initializes a new instance of ManagedCertificateProperties. </summary>
        /// <param name="secretType"> The type of the secret resource. </param>
        /// <param name="subject"> Subject name in the certificate. </param>
        /// <param name="expirationDate"> Certificate expiration date. </param>
        internal ManagedCertificateProperties(SecretType secretType, string subject, string expirationDate) : base(secretType)
        {
            Subject = subject;
            ExpirationDate = expirationDate;
            SecretType = secretType;
        }

        /// <summary> Subject name in the certificate. </summary>
        public string Subject { get; }
        /// <summary> Certificate expiration date. </summary>
        public string ExpirationDate { get; }
    }
}
