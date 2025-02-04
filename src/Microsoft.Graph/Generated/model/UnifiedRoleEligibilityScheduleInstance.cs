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
    /// The type Unified Role Eligibility Schedule Instance.
    /// </summary>
    public partial class UnifiedRoleEligibilityScheduleInstance : UnifiedRoleScheduleInstanceBase
    {
    
        /// <summary>
        /// Gets or sets end date time.
        /// The end date of the schedule instance.
        /// </summary>
        [JsonPropertyName("endDateTime")]
        public DateTimeOffset? EndDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets member type.
        /// How the role eligibility is inherited. It can either be Inherited, Direct, or Group. It can further imply whether the unifiedRoleEligibilitySchedule can be managed by the caller. Supports $filter (eq, ne).
        /// </summary>
        [JsonPropertyName("memberType")]
        public string MemberType { get; set; }
    
        /// <summary>
        /// Gets or sets role eligibility schedule id.
        /// The identifier of the unifiedRoleEligibilitySchedule object from which this instance was created. Supports $filter (eq, ne).
        /// </summary>
        [JsonPropertyName("roleEligibilityScheduleId")]
        public string RoleEligibilityScheduleId { get; set; }
    
        /// <summary>
        /// Gets or sets start date time.
        /// When this instance starts.
        /// </summary>
        [JsonPropertyName("startDateTime")]
        public DateTimeOffset? StartDateTime { get; set; }
    
    }
}

