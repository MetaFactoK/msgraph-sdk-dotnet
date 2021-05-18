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
    /// The type Authorization Policy.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<AuthorizationPolicy>))]
    public partial class AuthorizationPolicy : PolicyBase
    {
    
		///<summary>
		/// The AuthorizationPolicy constructor
		///</summary>
        public AuthorizationPolicy()
        {
            this.ODataType = "microsoft.graph.authorizationPolicy";
        }
	
        /// <summary>
        /// Gets or sets allowed to sign up email based subscriptions.
        /// Indicates whether users can sign up for email based subscriptions.
        /// </summary>
        [JsonPropertyName("allowedToSignUpEmailBasedSubscriptions")]
        public bool? AllowedToSignUpEmailBasedSubscriptions { get; set; }
    
        /// <summary>
        /// Gets or sets allowed to use sspr.
        /// Indicates whether the Self-Serve Password Reset feature can be used by users on the tenant.
        /// </summary>
        [JsonPropertyName("allowedToUseSSPR")]
        public bool? AllowedToUseSSPR { get; set; }
    
        /// <summary>
        /// Gets or sets allow email verified users to join organization.
        /// Indicates whether a user can join the tenant by email validation.
        /// </summary>
        [JsonPropertyName("allowEmailVerifiedUsersToJoinOrganization")]
        public bool? AllowEmailVerifiedUsersToJoinOrganization { get; set; }
    
        /// <summary>
        /// Gets or sets allow invites from.
        /// Indicates who can invite external users to the organization. Possible values are: none, adminsAndGuestInviters, adminsGuestInvitersAndAllMembers, everyone.  everyone is the default setting for all cloud environments except US Government. See more in the table below.
        /// </summary>
        [JsonPropertyName("allowInvitesFrom")]
        public AllowInvitesFrom? AllowInvitesFrom { get; set; }
    
        /// <summary>
        /// Gets or sets block msol power shell.
        /// To disable the use of MSOL PowerShell set this property to true. This will also disable user-based access to the legacy service endpoint used by MSOL PowerShell. This does not affect Azure AD Connect or Microsoft Graph.
        /// </summary>
        [JsonPropertyName("blockMsolPowerShell")]
        public bool? BlockMsolPowerShell { get; set; }
    
        /// <summary>
        /// Gets or sets default user role permissions.
        /// Specifies certain customizable permissions for default user role.
        /// </summary>
        [JsonPropertyName("defaultUserRolePermissions")]
        public DefaultUserRolePermissions DefaultUserRolePermissions { get; set; }
    
    }
}

