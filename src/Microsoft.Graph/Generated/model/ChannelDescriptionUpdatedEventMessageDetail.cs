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
    /// The type ChannelDescriptionUpdatedEventMessageDetail.
    /// </summary>
    public partial class ChannelDescriptionUpdatedEventMessageDetail : EventMessageDetail
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelDescriptionUpdatedEventMessageDetail"/> class.
        /// </summary>
        public ChannelDescriptionUpdatedEventMessageDetail()
        {
            this.ODataType = "microsoft.graph.channelDescriptionUpdatedEventMessageDetail";
        }

        /// <summary>
        /// Gets or sets channelDescription.
        /// The updated description of the channel.
        /// </summary>
        [JsonPropertyName("channelDescription")]
        public string ChannelDescription { get; set; }
    
        /// <summary>
        /// Gets or sets channelId.
        /// Unique identifier of the channel.
        /// </summary>
        [JsonPropertyName("channelId")]
        public string ChannelId { get; set; }
    
        /// <summary>
        /// Gets or sets initiator.
        /// Initiator of the event.
        /// </summary>
        [JsonPropertyName("initiator")]
        public IdentitySet Initiator { get; set; }
    
    }
}
