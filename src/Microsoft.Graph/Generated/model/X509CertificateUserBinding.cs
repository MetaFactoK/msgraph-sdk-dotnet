// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type X509CertificateUserBinding.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<X509CertificateUserBinding>))]
    public partial class X509CertificateUserBinding
    {

        /// <summary>
        /// Gets or sets priority.
        /// </summary>
        [JsonPropertyName("priority")]
        public Int32? Priority { get; set; }
    
        /// <summary>
        /// Gets or sets userProperty.
        /// </summary>
        [JsonPropertyName("userProperty")]
        public string UserProperty { get; set; }
    
        /// <summary>
        /// Gets or sets x509CertificateField.
        /// </summary>
        [JsonPropertyName("x509CertificateField")]
        public string X509CertificateField { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}
