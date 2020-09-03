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
    /// The type Ios Device Features Configuration.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class IosDeviceFeaturesConfiguration : AppleDeviceFeaturesConfigurationBase
    {
    
		///<summary>
		/// The IosDeviceFeaturesConfiguration constructor
		///</summary>
        public IosDeviceFeaturesConfiguration()
        {
            this.ODataType = "microsoft.graph.iosDeviceFeaturesConfiguration";
        }
	
        /// <summary>
        /// Gets or sets asset tag template.
        /// Asset tag information for the device, displayed on the login window and lock screen.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "assetTagTemplate", Required = Newtonsoft.Json.Required.Default)]
        public string AssetTagTemplate { get; set; }
    
        /// <summary>
        /// Gets or sets home screen dock icons.
        /// A list of app and folders to appear on the Home Screen Dock. This collection can contain a maximum of 500 elements.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "homeScreenDockIcons", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<IosHomeScreenItem> HomeScreenDockIcons { get; set; }
    
        /// <summary>
        /// Gets or sets home screen pages.
        /// A list of pages on the Home Screen. This collection can contain a maximum of 500 elements.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "homeScreenPages", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<IosHomeScreenPage> HomeScreenPages { get; set; }
    
        /// <summary>
        /// Gets or sets lock screen footnote.
        /// A footnote displayed on the login window and lock screen. Available in iOS 9.3.1 and later.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lockScreenFootnote", Required = Newtonsoft.Json.Required.Default)]
        public string LockScreenFootnote { get; set; }
    
        /// <summary>
        /// Gets or sets notification settings.
        /// Notification settings for each bundle id. Applicable to devices in supervised mode only (iOS 9.3 and later). This collection can contain a maximum of 500 elements.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "notificationSettings", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<IosNotificationSettings> NotificationSettings { get; set; }
    
    }
}

