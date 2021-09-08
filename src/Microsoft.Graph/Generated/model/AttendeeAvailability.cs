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
    /// The type AttendeeAvailability.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<AttendeeAvailability>))]
    public partial class AttendeeAvailability
    {

        /// <summary>
        /// Gets or sets attendee.
        /// The email address and type of attendee - whether it's a person or a resource, and whether required or optional if it's a person.
        /// </summary>
        [JsonPropertyName("attendee")]
        public AttendeeBase Attendee { get; set; }
    
        /// <summary>
        /// Gets or sets availability.
        /// The availability status of the attendee. The possible values are: free, tentative, busy, oof, workingElsewhere, unknown.
        /// </summary>
        [JsonPropertyName("availability")]
        public FreeBusyStatus? Availability { get; set; }
    
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
