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
    /// The type Ios Update Configuration.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<IosUpdateConfiguration>))]
    public partial class IosUpdateConfiguration : DeviceConfiguration
    {
    
		///<summary>
		/// The IosUpdateConfiguration constructor
		///</summary>
        public IosUpdateConfiguration()
        {
            this.ODataType = "microsoft.graph.iosUpdateConfiguration";
        }
	
        /// <summary>
        /// Gets or sets active hours end.
        /// Active Hours End (active hours mean the time window when updates install should not happen)
        /// </summary>
        [JsonPropertyName("activeHoursEnd")]
        public TimeOfDay ActiveHoursEnd { get; set; }
    
        /// <summary>
        /// Gets or sets active hours start.
        /// Active Hours Start (active hours mean the time window when updates install should not happen)
        /// </summary>
        [JsonPropertyName("activeHoursStart")]
        public TimeOfDay ActiveHoursStart { get; set; }
    
        /// <summary>
        /// Gets or sets scheduled install days.
        /// Days in week for which active hours are configured. This collection can contain a maximum of 7 elements.
        /// </summary>
        [JsonPropertyName("scheduledInstallDays")]
        public IEnumerable<DayOfWeek> ScheduledInstallDays { get; set; }
    
        /// <summary>
        /// Gets or sets utc time offset in minutes.
        /// UTC Time Offset indicated in minutes
        /// </summary>
        [JsonPropertyName("utcTimeOffsetInMinutes")]
        public Int32? UtcTimeOffsetInMinutes { get; set; }
    
    }
}

