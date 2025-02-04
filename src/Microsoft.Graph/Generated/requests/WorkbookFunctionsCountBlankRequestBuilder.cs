// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type WorkbookFunctionsCountBlankRequestBuilder.
    /// </summary>
    public partial class WorkbookFunctionsCountBlankRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookFunctionsCountBlankRequest>, IWorkbookFunctionsCountBlankRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFunctionsCountBlankRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="range">A range parameter for the OData method call.</param>
        public WorkbookFunctionsCountBlankRequestBuilder(
            string requestUrl,
            IBaseClient client,
            System.Text.Json.JsonDocument range)
            : base(requestUrl, client)
        {
            this.SetParameter("range", range, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFunctionsCountBlankRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFunctionsCountBlankRequest(functionUrl, this.Client, options);

            if (this.HasParameter("range"))
            {
                request.RequestBody.Range = this.GetParameter<System.Text.Json.JsonDocument>("range");
            }

            return request;
        }
    }
}
