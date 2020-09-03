// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Mail Folder.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class MailFolder : Entity
    {
    
		///<summary>
		/// The MailFolder constructor
		///</summary>
        public MailFolder()
        {
            this.ODataType = "microsoft.graph.mailFolder";
        }
	
        /// <summary>
        /// Gets or sets child folder count.
        /// The number of immediate child mailFolders in the current mailFolder.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "childFolderCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? ChildFolderCount { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The mailFolder's display name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets parent folder id.
        /// The unique identifier for the mailFolder's parent mailFolder.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "parentFolderId", Required = Newtonsoft.Json.Required.Default)]
        public string ParentFolderId { get; set; }
    
        /// <summary>
        /// Gets or sets total item count.
        /// The number of items in the mailFolder.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "totalItemCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? TotalItemCount { get; set; }
    
        /// <summary>
        /// Gets or sets unread item count.
        /// The number of items in the mailFolder marked as unread.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "unreadItemCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? UnreadItemCount { get; set; }
    
        /// <summary>
        /// Gets or sets child folders.
        /// The collection of child folders in the mailFolder.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "childFolders", Required = Newtonsoft.Json.Required.Default)]
        public IMailFolderChildFoldersCollectionPage ChildFolders { get; set; }
    
        /// <summary>
        /// Gets or sets message rules.
        /// The collection of rules that apply to the user's Inbox folder.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "messageRules", Required = Newtonsoft.Json.Required.Default)]
        public IMailFolderMessageRulesCollectionPage MessageRules { get; set; }
    
        /// <summary>
        /// Gets or sets messages.
        /// The collection of messages in the mailFolder.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "messages", Required = Newtonsoft.Json.Required.Default)]
        public IMailFolderMessagesCollectionPage Messages { get; set; }
    
        /// <summary>
        /// Gets or sets multi value extended properties.
        /// The collection of multi-value extended properties defined for the mailFolder. Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "multiValueExtendedProperties", Required = Newtonsoft.Json.Required.Default)]
        public IMailFolderMultiValueExtendedPropertiesCollectionPage MultiValueExtendedProperties { get; set; }
    
        /// <summary>
        /// Gets or sets single value extended properties.
        /// The collection of single-value extended properties defined for the mailFolder. Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "singleValueExtendedProperties", Required = Newtonsoft.Json.Required.Default)]
        public IMailFolderSingleValueExtendedPropertiesCollectionPage SingleValueExtendedProperties { get; set; }
    
    }
}

