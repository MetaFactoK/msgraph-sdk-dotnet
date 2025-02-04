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
    /// The type IncomingContext.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<IncomingContext>))]
    public partial class IncomingContext
    {

        /// <summary>
        /// Gets or sets observedParticipantId.
        /// The ID of the participant that is under observation. Read-only.
        /// </summary>
        [JsonPropertyName("observedParticipantId")]
        public string ObservedParticipantId { get; set; }
    
        /// <summary>
        /// Gets or sets onBehalfOf.
        /// The identity that the call is happening on behalf of.
        /// </summary>
        [JsonPropertyName("onBehalfOf")]
        public IdentitySet OnBehalfOf { get; set; }
    
        /// <summary>
        /// Gets or sets sourceParticipantId.
        /// The ID of the participant that triggered the incoming call. Read-only.
        /// </summary>
        [JsonPropertyName("sourceParticipantId")]
        public string SourceParticipantId { get; set; }
    
        /// <summary>
        /// Gets or sets transferor.
        /// The identity that transferred the call.
        /// </summary>
        [JsonPropertyName("transferor")]
        public IdentitySet Transferor { get; set; }
    
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
