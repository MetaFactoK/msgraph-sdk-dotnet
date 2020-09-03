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
    /// The type Managed EBook.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class ManagedEBook : Entity
    {
    
		///<summary>
		/// The internal ManagedEBook constructor
		///</summary>
        protected internal ManagedEBook()
        {
            // Don't allow initialization of abstract entity types
        }
    
        /// <summary>
        /// Gets or sets created date time.
        /// The date and time when the eBook file was created.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "createdDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// Description.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description", Required = Newtonsoft.Json.Required.Default)]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// Name of the eBook.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets information url.
        /// The more information Url.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "informationUrl", Required = Newtonsoft.Json.Required.Default)]
        public string InformationUrl { get; set; }
    
        /// <summary>
        /// Gets or sets large cover.
        /// Book cover.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "largeCover", Required = Newtonsoft.Json.Required.Default)]
        public MimeContent LargeCover { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// The date and time when the eBook was last modified.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastModifiedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets privacy information url.
        /// The privacy statement Url.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "privacyInformationUrl", Required = Newtonsoft.Json.Required.Default)]
        public string PrivacyInformationUrl { get; set; }
    
        /// <summary>
        /// Gets or sets published date time.
        /// The date and time when the eBook was published.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "publishedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? PublishedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets publisher.
        /// Publisher.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "publisher", Required = Newtonsoft.Json.Required.Default)]
        public string Publisher { get; set; }
    
        /// <summary>
        /// Gets or sets assignments.
        /// The list of assignments for this eBook.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "assignments", Required = Newtonsoft.Json.Required.Default)]
        public IManagedEBookAssignmentsCollectionPage Assignments { get; set; }
    
        /// <summary>
        /// Gets or sets device states.
        /// The list of installation states for this eBook.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceStates", Required = Newtonsoft.Json.Required.Default)]
        public IManagedEBookDeviceStatesCollectionPage DeviceStates { get; set; }
    
        /// <summary>
        /// Gets or sets install summary.
        /// Mobile App Install Summary.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "installSummary", Required = Newtonsoft.Json.Required.Default)]
        public EBookInstallSummary InstallSummary { get; set; }
    
        /// <summary>
        /// Gets or sets user state summary.
        /// The list of installation states for this eBook.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userStateSummary", Required = Newtonsoft.Json.Required.Default)]
        public IManagedEBookUserStateSummaryCollectionPage UserStateSummary { get; set; }
    
    }
}

