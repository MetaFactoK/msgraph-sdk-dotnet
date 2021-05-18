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
    /// The type TeleconferenceDeviceVideoQuality.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<TeleconferenceDeviceVideoQuality>))]
    public partial class TeleconferenceDeviceVideoQuality : TeleconferenceDeviceMediaQuality
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeleconferenceDeviceVideoQuality"/> class.
        /// </summary>
        public TeleconferenceDeviceVideoQuality()
        {
            this.ODataType = "microsoft.graph.teleconferenceDeviceVideoQuality";
        }

        /// <summary>
        /// Gets or sets averageInboundBitRate.
        /// The average inbound stream video bit rate per second.
        /// </summary>
        [JsonPropertyName("averageInboundBitRate")]
        public double? AverageInboundBitRate { get; set; }
    
        /// <summary>
        /// Gets or sets averageInboundFrameRate.
        /// The average inbound stream video frame rate per second.
        /// </summary>
        [JsonPropertyName("averageInboundFrameRate")]
        public double? AverageInboundFrameRate { get; set; }
    
        /// <summary>
        /// Gets or sets averageOutboundBitRate.
        /// The average outbound stream video bit rate per second.
        /// </summary>
        [JsonPropertyName("averageOutboundBitRate")]
        public double? AverageOutboundBitRate { get; set; }
    
        /// <summary>
        /// Gets or sets averageOutboundFrameRate.
        /// The average outbound stream video frame rate per second.
        /// </summary>
        [JsonPropertyName("averageOutboundFrameRate")]
        public double? AverageOutboundFrameRate { get; set; }
    
    }
}
