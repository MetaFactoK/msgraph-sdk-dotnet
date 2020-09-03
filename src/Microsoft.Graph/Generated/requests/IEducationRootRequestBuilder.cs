// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IEducationRootRequestBuilder.
    /// </summary>
    public partial interface IEducationRootRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IEducationRootRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IEducationRootRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for Classes.
        /// </summary>
        /// <returns>The <see cref="IEducationRootClassesCollectionRequestBuilder"/>.</returns>
        IEducationRootClassesCollectionRequestBuilder Classes { get; }

        /// <summary>
        /// Gets the request builder for Me.
        /// </summary>
        /// <returns>The <see cref="IEducationUserRequestBuilder"/>.</returns>
        IEducationUserRequestBuilder Me { get; }

        /// <summary>
        /// Gets the request builder for Schools.
        /// </summary>
        /// <returns>The <see cref="IEducationRootSchoolsCollectionRequestBuilder"/>.</returns>
        IEducationRootSchoolsCollectionRequestBuilder Schools { get; }

        /// <summary>
        /// Gets the request builder for Users.
        /// </summary>
        /// <returns>The <see cref="IEducationRootUsersCollectionRequestBuilder"/>.</returns>
        IEducationRootUsersCollectionRequestBuilder Users { get; }
    
    }
}
