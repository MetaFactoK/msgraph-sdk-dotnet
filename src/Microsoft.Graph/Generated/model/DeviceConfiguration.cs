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
    /// The type Device Configuration.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<DeviceConfiguration>))]
    public partial class DeviceConfiguration : Entity
    {
    
        ///<summary>
        /// The internal DeviceConfiguration constructor
        ///</summary>
        protected internal DeviceConfiguration()
        {
            // Don't allow initialization of abstract entity types
        }
    
        /// <summary>
        /// Gets or sets created date time.
        /// DateTime the object was created.
        /// </summary>
        [JsonPropertyName("createdDateTime")]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// Admin provided description of the Device Configuration.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// Admin provided name of the device configuration.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// DateTime the object was last modified.
        /// </summary>
        [JsonPropertyName("lastModifiedDateTime")]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets version.
        /// Version of the device configuration.
        /// </summary>
        [JsonPropertyName("version")]
        public Int32? Version { get; set; }
    
        /// <summary>
        /// Gets or sets assignments.
        /// The list of assignments for the device configuration profile.
        /// </summary>
        [JsonPropertyName("assignments")]
        public IDeviceConfigurationAssignmentsCollectionPage Assignments { get; set; }

        /// <summary>
        /// Gets or sets assignmentsNextLink.
        /// </summary>
        [JsonPropertyName("assignments@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string AssignmentsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets device setting state summaries.
        /// Device Configuration Setting State Device Summary
        /// </summary>
        [JsonPropertyName("deviceSettingStateSummaries")]
        public IDeviceConfigurationDeviceSettingStateSummariesCollectionPage DeviceSettingStateSummaries { get; set; }

        /// <summary>
        /// Gets or sets deviceSettingStateSummariesNextLink.
        /// </summary>
        [JsonPropertyName("deviceSettingStateSummaries@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string DeviceSettingStateSummariesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets device statuses.
        /// Device configuration installation status by device.
        /// </summary>
        [JsonPropertyName("deviceStatuses")]
        public IDeviceConfigurationDeviceStatusesCollectionPage DeviceStatuses { get; set; }

        /// <summary>
        /// Gets or sets deviceStatusesNextLink.
        /// </summary>
        [JsonPropertyName("deviceStatuses@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string DeviceStatusesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets device status overview.
        /// Device Configuration devices status overview
        /// </summary>
        [JsonPropertyName("deviceStatusOverview")]
        public DeviceConfigurationDeviceOverview DeviceStatusOverview { get; set; }
    
        /// <summary>
        /// Gets or sets user statuses.
        /// Device configuration installation status by user.
        /// </summary>
        [JsonPropertyName("userStatuses")]
        public IDeviceConfigurationUserStatusesCollectionPage UserStatuses { get; set; }

        /// <summary>
        /// Gets or sets userStatusesNextLink.
        /// </summary>
        [JsonPropertyName("userStatuses@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string UserStatusesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets user status overview.
        /// Device Configuration users status overview
        /// </summary>
        [JsonPropertyName("userStatusOverview")]
        public DeviceConfigurationUserOverview UserStatusOverview { get; set; }
    
    }
}

