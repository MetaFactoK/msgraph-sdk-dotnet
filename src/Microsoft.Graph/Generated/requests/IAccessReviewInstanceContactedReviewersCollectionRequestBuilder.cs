// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IAccessReviewInstanceContactedReviewersCollectionRequestBuilder.
    /// </summary>
    public partial interface IAccessReviewInstanceContactedReviewersCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IAccessReviewInstanceContactedReviewersCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IAccessReviewInstanceContactedReviewersCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IAccessReviewReviewerRequestBuilder"/> for the specified AccessReviewReviewer.
        /// </summary>
        /// <param name="id">The ID for the AccessReviewReviewer.</param>
        /// <returns>The <see cref="IAccessReviewReviewerRequestBuilder"/>.</returns>
        IAccessReviewReviewerRequestBuilder this[string id] { get; }

        
    }
}
