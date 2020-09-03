// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph.CallRecords
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type ParticipantEndpoint.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class ParticipantEndpoint : Endpoint
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ParticipantEndpoint"/> class.
        /// </summary>
        public ParticipantEndpoint()
        {
            this.ODataType = "microsoft.graph.callRecords.participantEndpoint";
        }

        /// <summary>
        /// Gets or sets feedback.
        /// The feedback provided by the user of this endpoint about the quality of the session.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "feedback", Required = Newtonsoft.Json.Required.Default)]
        public UserFeedback Feedback { get; set; }
    
        /// <summary>
        /// Gets or sets identity.
        /// Identity associated with the endpoint.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "identity", Required = Newtonsoft.Json.Required.Default)]
        public Microsoft.Graph.IdentitySet Identity { get; set; }
    
    }
}
