// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequest.cs.tt

namespace Microsoft.Graph.ExternalConnectors
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type ExternalConnectionRequest.
    /// </summary>
    public partial class ExternalConnectionRequest : Microsoft.Graph.BaseRequest, IExternalConnectionRequest
    {
        /// <summary>
        /// Constructs a new ExternalConnectionRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public ExternalConnectionRequest(
            string requestUrl,
            Microsoft.Graph.IBaseClient client,
            IEnumerable<Microsoft.Graph.Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified ExternalConnection using POST.
        /// </summary>
        /// <param name="externalConnectionToCreate">The ExternalConnection to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ExternalConnection.</returns>
        public async System.Threading.Tasks.Task<ExternalConnection> CreateAsync(ExternalConnection externalConnectionToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<ExternalConnection>(externalConnectionToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified ExternalConnection using POST and returns a <see cref="GraphResponse{ExternalConnection}"/> object.
        /// </summary>
        /// <param name="externalConnectionToCreate">The ExternalConnection to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ExternalConnection}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ExternalConnection>> CreateResponseAsync(ExternalConnection externalConnectionToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<ExternalConnection>(externalConnectionToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified ExternalConnection.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<ExternalConnection>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified ExternalConnection and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified ExternalConnection.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ExternalConnection.</returns>
        public async System.Threading.Tasks.Task<ExternalConnection> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<ExternalConnection>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified ExternalConnection and returns a <see cref="GraphResponse{ExternalConnection}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ExternalConnection}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ExternalConnection>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<ExternalConnection>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified ExternalConnection using PATCH.
        /// </summary>
        /// <param name="externalConnectionToUpdate">The ExternalConnection to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ExternalConnection.</returns>
        public async System.Threading.Tasks.Task<ExternalConnection> UpdateAsync(ExternalConnection externalConnectionToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<ExternalConnection>(externalConnectionToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified ExternalConnection using PATCH and returns a <see cref="GraphResponse{ExternalConnection}"/> object.
        /// </summary>
        /// <param name="externalConnectionToUpdate">The ExternalConnection to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ExternalConnection}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ExternalConnection>> UpdateResponseAsync(ExternalConnection externalConnectionToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<ExternalConnection>(externalConnectionToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified ExternalConnection using PUT.
        /// </summary>
        /// <param name="externalConnectionToUpdate">The ExternalConnection object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<ExternalConnection> PutAsync(ExternalConnection externalConnectionToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<ExternalConnection>(externalConnectionToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified ExternalConnection using PUT and returns a <see cref="GraphResponse{ExternalConnection}"/> object.
        /// </summary>
        /// <param name="externalConnectionToUpdate">The ExternalConnection object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{ExternalConnection}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ExternalConnection>> PutResponseAsync(ExternalConnection externalConnectionToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<ExternalConnection>(externalConnectionToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IExternalConnectionRequest Expand(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IExternalConnectionRequest Expand(Expression<Func<ExternalConnection, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = Microsoft.Graph.ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IExternalConnectionRequest Select(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IExternalConnectionRequest Select(Expression<Func<ExternalConnection, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = Microsoft.Graph.ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="externalConnectionToInitialize">The <see cref="ExternalConnection"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(ExternalConnection externalConnectionToInitialize)
        {

            if (externalConnectionToInitialize != null)
            {
                if (externalConnectionToInitialize.Groups != null && externalConnectionToInitialize.Groups.CurrentPage != null)
                {
                    externalConnectionToInitialize.Groups.InitializeNextPageRequest(this.Client, externalConnectionToInitialize.GroupsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    externalConnectionToInitialize.Groups.AdditionalData = externalConnectionToInitialize.AdditionalData;
                }
                if (externalConnectionToInitialize.Items != null && externalConnectionToInitialize.Items.CurrentPage != null)
                {
                    externalConnectionToInitialize.Items.InitializeNextPageRequest(this.Client, externalConnectionToInitialize.ItemsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    externalConnectionToInitialize.Items.AdditionalData = externalConnectionToInitialize.AdditionalData;
                }
                if (externalConnectionToInitialize.Operations != null && externalConnectionToInitialize.Operations.CurrentPage != null)
                {
                    externalConnectionToInitialize.Operations.InitializeNextPageRequest(this.Client, externalConnectionToInitialize.OperationsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    externalConnectionToInitialize.Operations.AdditionalData = externalConnectionToInitialize.AdditionalData;
                }

            }


        }
    }
}
