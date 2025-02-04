// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type CrossTenantAccessPolicyConfigurationDefaultRequestBuilder.
    /// </summary>
    public partial class CrossTenantAccessPolicyConfigurationDefaultRequestBuilder : EntityRequestBuilder, ICrossTenantAccessPolicyConfigurationDefaultRequestBuilder
    {

        /// <summary>
        /// Constructs a new CrossTenantAccessPolicyConfigurationDefaultRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public CrossTenantAccessPolicyConfigurationDefaultRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new ICrossTenantAccessPolicyConfigurationDefaultRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new ICrossTenantAccessPolicyConfigurationDefaultRequest Request(IEnumerable<Option> options)
        {
            return new CrossTenantAccessPolicyConfigurationDefaultRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for CrossTenantAccessPolicyConfigurationDefaultResetToSystemDefault.
        /// </summary>
        /// <returns>The <see cref="ICrossTenantAccessPolicyConfigurationDefaultResetToSystemDefaultRequestBuilder"/>.</returns>
        public ICrossTenantAccessPolicyConfigurationDefaultResetToSystemDefaultRequestBuilder ResetToSystemDefault()
        {
            return new CrossTenantAccessPolicyConfigurationDefaultResetToSystemDefaultRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.resetToSystemDefault"),
                this.Client);
        }
    
    }
}
