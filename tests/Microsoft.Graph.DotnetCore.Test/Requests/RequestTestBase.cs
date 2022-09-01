// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph.DotnetCore.Test.Requests
{
    using Microsoft.Graph.DotnetCore.Test.Mocks;
    using System;
    using System.Net.Http;
    public class RequestTestBase : IDisposable
    {
        protected string graphBaseUrl = string.Format(Constants.Url.GraphBaseUrlFormatString, "v1.0");

        protected MockAuthenticationProvider authenticationProvider;
        protected HttpResponseMessage httpResponseMessage;
        protected GraphServiceClient graphServiceClient;

        public RequestTestBase()
        {
            this.authenticationProvider = new MockAuthenticationProvider();
            this.httpResponseMessage = new HttpResponseMessage();

            this.graphServiceClient = new GraphServiceClient(
                this.authenticationProvider.Object);
        }

        public void Dispose()
        {
            this.httpResponseMessage.Dispose();
        }
    }
}
