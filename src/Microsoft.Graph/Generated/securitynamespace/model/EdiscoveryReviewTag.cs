// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph.SecurityNamespace
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Ediscovery Review Tag.
    /// </summary>
    [JsonConverter(typeof(Microsoft.Graph.DerivedTypeConverter<EdiscoveryReviewTag>))]
    public partial class EdiscoveryReviewTag : Tag
    {
    
        ///<summary>
        /// The EdiscoveryReviewTag constructor
        ///</summary>
        public EdiscoveryReviewTag()
        {
            this.ODataType = "microsoft.graph.security.ediscoveryReviewTag";
        }

        /// <summary>
        /// Gets or sets child selectability.
        /// Indicates whether a single or multiple child tags can be associated with a document. Possible values are: One, Many.  This value controls whether the UX presents the tags as checkboxes or a radio button group.
        /// </summary>
        [JsonPropertyName("childSelectability")]
        public ChildSelectability? ChildSelectability { get; set; }
    
        /// <summary>
        /// Gets or sets child tags.
        /// Returns the tags that are a child of a tag.
        /// </summary>
        [JsonPropertyName("childTags")]
        public IEdiscoveryReviewTagChildTagsCollectionWithReferencesPage ChildTags { get; set; }

        /// <summary>
        /// Gets or sets childTagsNextLink.
        /// </summary>
        [JsonPropertyName("childTags@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string ChildTagsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets parent.
        /// Returns the parent tag of the specified tag.
        /// </summary>
        [JsonPropertyName("parent")]
        public EdiscoveryReviewTag Parent { get; set; }
    
    }
}

