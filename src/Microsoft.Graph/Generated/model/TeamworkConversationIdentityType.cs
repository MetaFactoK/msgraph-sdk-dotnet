// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EnumType.cs.tt


namespace Microsoft.Graph
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// The enum TeamworkConversationIdentityType.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TeamworkConversationIdentityType
    {
    
        /// <summary>
        /// Team
        /// </summary>
        Team = 0,
	
        /// <summary>
        /// Channel
        /// </summary>
        Channel = 1,
	
        /// <summary>
        /// Chat
        /// </summary>
        Chat = 2,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 3,
	
    }
}
