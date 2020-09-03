// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Message Rule.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class MessageRule : Entity
    {
    
		///<summary>
		/// The MessageRule constructor
		///</summary>
        public MessageRule()
        {
            this.ODataType = "microsoft.graph.messageRule";
        }
	
        /// <summary>
        /// Gets or sets actions.
        /// Actions to be taken on a message when the corresponding conditions are fulfilled.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "actions", Required = Newtonsoft.Json.Required.Default)]
        public MessageRuleActions Actions { get; set; }
    
        /// <summary>
        /// Gets or sets conditions.
        /// Conditions that when fulfilled, will trigger the corresponding actions for that rule.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "conditions", Required = Newtonsoft.Json.Required.Default)]
        public MessageRulePredicates Conditions { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The display name of the rule.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets exceptions.
        /// Exception conditions for the rule.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "exceptions", Required = Newtonsoft.Json.Required.Default)]
        public MessageRulePredicates Exceptions { get; set; }
    
        /// <summary>
        /// Gets or sets has error.
        /// Indicates whether the rule is in an error condition. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "hasError", Required = Newtonsoft.Json.Required.Default)]
        public bool? HasError { get; set; }
    
        /// <summary>
        /// Gets or sets is enabled.
        /// Indicates whether the rule is enabled to be applied to messages.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets is read only.
        /// Indicates if the rule is read-only and cannot be modified or deleted by the rules REST API.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isReadOnly", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsReadOnly { get; set; }
    
        /// <summary>
        /// Gets or sets sequence.
        /// Indicates the order in which the rule is executed, among other rules.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sequence", Required = Newtonsoft.Json.Required.Default)]
        public Int32? Sequence { get; set; }
    
    }
}

