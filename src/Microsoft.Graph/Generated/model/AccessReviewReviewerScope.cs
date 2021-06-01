// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type AccessReviewReviewerScope.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class AccessReviewReviewerScope
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessReviewReviewerScope"/> class.
        /// </summary>
        public AccessReviewReviewerScope()
        {
            this.ODataType = "microsoft.graph.accessReviewReviewerScope";
        }

        /// <summary>
        /// Gets or sets query.
        /// The query specifying who will be the reviewer. See table for examples.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "query", Required = Newtonsoft.Json.Required.Default)]
        public string Query { get; set; }
    
        /// <summary>
        /// Gets or sets queryRoot.
        /// In the scenario where reviewers need to be specified dynamically, this property is used to indicate the relative source of the query. This property is only required if a relative query, for example, ./manager, is specified. Possible value: decisions.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "queryRoot", Required = Newtonsoft.Json.Required.Default)]
        public string QueryRoot { get; set; }
    
        /// <summary>
        /// Gets or sets queryType.
        /// The type of query. Examples include MicrosoftGraph and ARM.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "queryType", Required = Newtonsoft.Json.Required.Default)]
        public string QueryType { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.type", Required = Newtonsoft.Json.Required.Default)]
        public string ODataType { get; set; }
    
    }
}
