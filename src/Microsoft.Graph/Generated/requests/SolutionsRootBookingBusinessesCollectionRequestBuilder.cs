// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type SolutionsRootBookingBusinessesCollectionRequestBuilder.
    /// </summary>
    public partial class SolutionsRootBookingBusinessesCollectionRequestBuilder : BaseRequestBuilder, ISolutionsRootBookingBusinessesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new SolutionsRootBookingBusinessesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public SolutionsRootBookingBusinessesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public ISolutionsRootBookingBusinessesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public ISolutionsRootBookingBusinessesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new SolutionsRootBookingBusinessesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IBookingBusinessRequestBuilder"/> for the specified SolutionsRootBookingBusiness.
        /// </summary>
        /// <param name="id">The ID for the SolutionsRootBookingBusiness.</param>
        /// <returns>The <see cref="IBookingBusinessRequestBuilder"/>.</returns>
        public IBookingBusinessRequestBuilder this[string id]
        {
            get
            {
                return new BookingBusinessRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
