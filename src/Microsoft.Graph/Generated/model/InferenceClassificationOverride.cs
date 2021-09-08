// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Inference Classification Override.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<InferenceClassificationOverride>))]
    public partial class InferenceClassificationOverride : Entity
    {
    
        /// <summary>
        /// Gets or sets classify as.
        /// Specifies how incoming messages from a specific sender should always be classified as. The possible values are: focused, other.
        /// </summary>
        [JsonPropertyName("classifyAs")]
        public InferenceClassificationType? ClassifyAs { get; set; }
    
        /// <summary>
        /// Gets or sets sender email address.
        /// The email address information of the sender for whom the override is created.
        /// </summary>
        [JsonPropertyName("senderEmailAddress")]
        public EmailAddress SenderEmailAddress { get; set; }
    
    }
}

