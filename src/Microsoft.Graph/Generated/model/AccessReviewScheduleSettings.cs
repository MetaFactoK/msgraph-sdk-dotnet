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
    /// The type AccessReviewScheduleSettings.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<AccessReviewScheduleSettings>))]
    public partial class AccessReviewScheduleSettings
    {

        /// <summary>
        /// Gets or sets applyActions.
        /// Optional field. Describes the  actions to take once a review is complete. There are two types that are currently supported: removeAccessApplyAction (default) and disableAndDeleteUserApplyAction. Field only needs to be specified in the case of disableAndDeleteUserApplyAction.
        /// </summary>
        [JsonPropertyName("applyActions")]
        public IEnumerable<AccessReviewApplyAction> ApplyActions { get; set; }
    
        /// <summary>
        /// Gets or sets autoApplyDecisionsEnabled.
        /// Indicates whether decisions are automatically applied. When set to false, an admin must apply the decisions manually once the reviewer completes the access review. When set to true, decisions are applied automatically after the access review instance duration ends, whether or not the reviewers have responded. Default value is false.
        /// </summary>
        [JsonPropertyName("autoApplyDecisionsEnabled")]
        public bool? AutoApplyDecisionsEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets defaultDecision.
        /// Decision chosen if defaultDecisionEnabled is true. Can be one of Approve, Deny, or Recommendation.
        /// </summary>
        [JsonPropertyName("defaultDecision")]
        public string DefaultDecision { get; set; }
    
        /// <summary>
        /// Gets or sets defaultDecisionEnabled.
        /// Indicates whether the default decision is enabled or disabled when reviewers do not respond. Default value is false.
        /// </summary>
        [JsonPropertyName("defaultDecisionEnabled")]
        public bool? DefaultDecisionEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets instanceDurationInDays.
        /// Duration of each recurrence of review (accessReviewInstance) in number of days.
        /// </summary>
        [JsonPropertyName("instanceDurationInDays")]
        public Int32? InstanceDurationInDays { get; set; }
    
        /// <summary>
        /// Gets or sets justificationRequiredOnApproval.
        /// Indicates whether reviewers are required to provide justification with their decision. Default value is false.
        /// </summary>
        [JsonPropertyName("justificationRequiredOnApproval")]
        public bool? JustificationRequiredOnApproval { get; set; }
    
        /// <summary>
        /// Gets or sets mailNotificationsEnabled.
        /// Indicates whether emails are enabled or disabled. Default value is false.
        /// </summary>
        [JsonPropertyName("mailNotificationsEnabled")]
        public bool? MailNotificationsEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets recommendationsEnabled.
        /// Indicates whether decision recommendations are enabled or disabled.
        /// </summary>
        [JsonPropertyName("recommendationsEnabled")]
        public bool? RecommendationsEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets recurrence.
        /// Detailed settings for recurrence using the standard Outlook recurrence object.  Note: Only dayOfMonth, interval, and type (weekly, absoluteMonthly) properties are supported. Use the property startDate on recurrenceRange to determine the day the review starts.
        /// </summary>
        [JsonPropertyName("recurrence")]
        public PatternedRecurrence Recurrence { get; set; }
    
        /// <summary>
        /// Gets or sets reminderNotificationsEnabled.
        /// Indicates whether reminders are enabled or disabled. Default value is false.
        /// </summary>
        [JsonPropertyName("reminderNotificationsEnabled")]
        public bool? ReminderNotificationsEnabled { get; set; }
    
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
