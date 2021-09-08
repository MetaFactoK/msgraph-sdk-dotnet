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
    /// The type ParticipantInfo.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<ParticipantInfo>))]
    public partial class ParticipantInfo
    {

        /// <summary>
        /// Gets or sets countryCode.
        /// The ISO 3166-1 Alpha-2 country code of the participant's best estimated physical location at the start of the call. Read-only.
        /// </summary>
        [JsonPropertyName("countryCode")]
        public string CountryCode { get; set; }
    
        /// <summary>
        /// Gets or sets endpointType.
        /// The type of endpoint the participant is using. Possible values are: default, skypeForBusiness, or skypeForBusinessVoipPhone. Read-only.
        /// </summary>
        [JsonPropertyName("endpointType")]
        public EndpointType? EndpointType { get; set; }
    
        /// <summary>
        /// Gets or sets identity.
        /// The identitySet associated with this participant. Read-only.
        /// </summary>
        [JsonPropertyName("identity")]
        public IdentitySet Identity { get; set; }
    
        /// <summary>
        /// Gets or sets languageId.
        /// The language culture string. Read-only.
        /// </summary>
        [JsonPropertyName("languageId")]
        public string LanguageId { get; set; }
    
        /// <summary>
        /// Gets or sets region.
        /// The home region of the participant. This can be a country, a continent, or a larger geographic region. This does not change based on the participant's current physical location. Read-only.
        /// </summary>
        [JsonPropertyName("region")]
        public string Region { get; set; }
    
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
