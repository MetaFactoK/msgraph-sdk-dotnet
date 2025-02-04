// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph.SecurityNamespace
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IEdiscoveryEstimateOperationRequestBuilder.
    /// </summary>
    public partial interface IEdiscoveryEstimateOperationRequestBuilder : ICaseOperationRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IEdiscoveryEstimateOperationRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IEdiscoveryEstimateOperationRequest Request(IEnumerable<Microsoft.Graph.Option> options);
    
        /// <summary>
        /// Gets the request builder for Search.
        /// </summary>
        /// <returns>The <see cref="IEdiscoverySearchWithReferenceRequestBuilder"/>.</returns>
        IEdiscoverySearchWithReferenceRequestBuilder Search { get; }
    
    }
}
