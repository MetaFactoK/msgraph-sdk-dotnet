// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityWithReferenceRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface ICertificateBasedAuthConfigurationWithReferenceRequest.
    /// </summary>
    public partial interface ICertificateBasedAuthConfigurationWithReferenceRequest : IBaseRequest
    {
        /// <summary>
        /// Gets the specified CertificateBasedAuthConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The CertificateBasedAuthConfiguration.</returns>
        System.Threading.Tasks.Task<CertificateBasedAuthConfiguration> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified CertificateBasedAuthConfiguration and returns a <see cref="GraphResponse{CertificateBasedAuthConfiguration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{CertificateBasedAuthConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<CertificateBasedAuthConfiguration>> GetResponseAsync(CancellationToken cancellationToken = default);

		/// <summary>
        /// Creates the specified CertificateBasedAuthConfiguration using POST.
        /// </summary>
        /// <param name="certificateBasedAuthConfigurationToCreate">The CertificateBasedAuthConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created CertificateBasedAuthConfiguration.</returns>
        System.Threading.Tasks.Task<CertificateBasedAuthConfiguration> CreateAsync(CertificateBasedAuthConfiguration certificateBasedAuthConfigurationToCreate, CancellationToken cancellationToken = default);

		/// <summary>
        /// Creates the specified CertificateBasedAuthConfiguration using POST and returns a <see cref="GraphResponse{CertificateBasedAuthConfiguration}"/> object.
        /// </summary>
        /// <param name="certificateBasedAuthConfigurationToCreate">The CertificateBasedAuthConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{CertificateBasedAuthConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<CertificateBasedAuthConfiguration>> CreateResponseAsync(CertificateBasedAuthConfiguration certificateBasedAuthConfigurationToCreate, CancellationToken cancellationToken = default);

		/// <summary>
        /// Updates the specified CertificateBasedAuthConfiguration using PATCH.
        /// </summary>
        /// <param name="certificateBasedAuthConfigurationToUpdate">The CertificateBasedAuthConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated CertificateBasedAuthConfiguration.</returns>
        System.Threading.Tasks.Task<CertificateBasedAuthConfiguration> UpdateAsync(CertificateBasedAuthConfiguration certificateBasedAuthConfigurationToUpdate, CancellationToken cancellationToken = default);

		/// <summary>
        /// Updates the specified CertificateBasedAuthConfiguration using PATCH and returns a <see cref="GraphResponse{CertificateBasedAuthConfiguration}"/> object.
        /// </summary>
        /// <param name="certificateBasedAuthConfigurationToUpdate">The CertificateBasedAuthConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{CertificateBasedAuthConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<CertificateBasedAuthConfiguration>> UpdateResponseAsync(CertificateBasedAuthConfiguration certificateBasedAuthConfigurationToUpdate, CancellationToken cancellationToken = default);

		/// <summary>
        /// Deletes the specified CertificateBasedAuthConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

		/// <summary>
        /// Deletes the specified CertificateBasedAuthConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ICertificateBasedAuthConfigurationWithReferenceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ICertificateBasedAuthConfigurationWithReferenceRequest Expand(Expression<Func<CertificateBasedAuthConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ICertificateBasedAuthConfigurationWithReferenceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ICertificateBasedAuthConfigurationWithReferenceRequest Select(Expression<Func<CertificateBasedAuthConfiguration, object>> selectExpression);

    }
}
