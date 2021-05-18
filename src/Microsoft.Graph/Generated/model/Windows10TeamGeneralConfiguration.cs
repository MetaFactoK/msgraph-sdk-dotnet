// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Windows10Team General Configuration.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<Windows10TeamGeneralConfiguration>))]
    public partial class Windows10TeamGeneralConfiguration : DeviceConfiguration
    {
    
		///<summary>
		/// The Windows10TeamGeneralConfiguration constructor
		///</summary>
        public Windows10TeamGeneralConfiguration()
        {
            this.ODataType = "microsoft.graph.windows10TeamGeneralConfiguration";
        }
	
        /// <summary>
        /// Gets or sets azure operational insights block telemetry.
        /// Indicates whether or not to Block Azure Operational Insights.
        /// </summary>
        [JsonPropertyName("azureOperationalInsightsBlockTelemetry")]
        public bool? AzureOperationalInsightsBlockTelemetry { get; set; }
    
        /// <summary>
        /// Gets or sets azure operational insights workspace id.
        /// The Azure Operational Insights workspace id.
        /// </summary>
        [JsonPropertyName("azureOperationalInsightsWorkspaceId")]
        public string AzureOperationalInsightsWorkspaceId { get; set; }
    
        /// <summary>
        /// Gets or sets azure operational insights workspace key.
        /// The Azure Operational Insights Workspace key.
        /// </summary>
        [JsonPropertyName("azureOperationalInsightsWorkspaceKey")]
        public string AzureOperationalInsightsWorkspaceKey { get; set; }
    
        /// <summary>
        /// Gets or sets connect app block auto launch.
        /// Specifies whether to automatically launch the Connect app whenever a projection is initiated.
        /// </summary>
        [JsonPropertyName("connectAppBlockAutoLaunch")]
        public bool? ConnectAppBlockAutoLaunch { get; set; }
    
        /// <summary>
        /// Gets or sets maintenance window blocked.
        /// Indicates whether or not to Block setting a maintenance window for device updates.
        /// </summary>
        [JsonPropertyName("maintenanceWindowBlocked")]
        public bool? MaintenanceWindowBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets maintenance window duration in hours.
        /// Maintenance window duration for device updates. Valid values 0 to 5
        /// </summary>
        [JsonPropertyName("maintenanceWindowDurationInHours")]
        public Int32? MaintenanceWindowDurationInHours { get; set; }
    
        /// <summary>
        /// Gets or sets maintenance window start time.
        /// Maintenance window start time for device updates.
        /// </summary>
        [JsonPropertyName("maintenanceWindowStartTime")]
        public TimeOfDay MaintenanceWindowStartTime { get; set; }
    
        /// <summary>
        /// Gets or sets miracast blocked.
        /// Indicates whether or not to Block wireless projection.
        /// </summary>
        [JsonPropertyName("miracastBlocked")]
        public bool? MiracastBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets miracast channel.
        /// The channel. Possible values are: userDefined, one, two, three, four, five, six, seven, eight, nine, ten, eleven, thirtySix, forty, fortyFour, fortyEight, oneHundredFortyNine, oneHundredFiftyThree, oneHundredFiftySeven, oneHundredSixtyOne, oneHundredSixtyFive.
        /// </summary>
        [JsonPropertyName("miracastChannel")]
        public MiracastChannel? MiracastChannel { get; set; }
    
        /// <summary>
        /// Gets or sets miracast require pin.
        /// Indicates whether or not to require a pin for wireless projection.
        /// </summary>
        [JsonPropertyName("miracastRequirePin")]
        public bool? MiracastRequirePin { get; set; }
    
        /// <summary>
        /// Gets or sets settings block my meetings and files.
        /// Specifies whether to disable the 'My meetings and files' feature in the Start menu, which shows the signed-in user's meetings and files from Office 365.
        /// </summary>
        [JsonPropertyName("settingsBlockMyMeetingsAndFiles")]
        public bool? SettingsBlockMyMeetingsAndFiles { get; set; }
    
        /// <summary>
        /// Gets or sets settings block session resume.
        /// Specifies whether to allow the ability to resume a session when the session times out.
        /// </summary>
        [JsonPropertyName("settingsBlockSessionResume")]
        public bool? SettingsBlockSessionResume { get; set; }
    
        /// <summary>
        /// Gets or sets settings block signin suggestions.
        /// Specifies whether to disable auto-populating of the sign-in dialog with invitees from scheduled meetings.
        /// </summary>
        [JsonPropertyName("settingsBlockSigninSuggestions")]
        public bool? SettingsBlockSigninSuggestions { get; set; }
    
        /// <summary>
        /// Gets or sets settings default volume.
        /// Specifies the default volume value for a new session. Permitted values are 0-100. The default is 45. Valid values 0 to 100
        /// </summary>
        [JsonPropertyName("settingsDefaultVolume")]
        public Int32? SettingsDefaultVolume { get; set; }
    
        /// <summary>
        /// Gets or sets settings screen timeout in minutes.
        /// Specifies the number of minutes until the Hub screen turns off.
        /// </summary>
        [JsonPropertyName("settingsScreenTimeoutInMinutes")]
        public Int32? SettingsScreenTimeoutInMinutes { get; set; }
    
        /// <summary>
        /// Gets or sets settings session timeout in minutes.
        /// Specifies the number of minutes until the session times out.
        /// </summary>
        [JsonPropertyName("settingsSessionTimeoutInMinutes")]
        public Int32? SettingsSessionTimeoutInMinutes { get; set; }
    
        /// <summary>
        /// Gets or sets settings sleep timeout in minutes.
        /// Specifies the number of minutes until the Hub enters sleep mode.
        /// </summary>
        [JsonPropertyName("settingsSleepTimeoutInMinutes")]
        public Int32? SettingsSleepTimeoutInMinutes { get; set; }
    
        /// <summary>
        /// Gets or sets welcome screen background image url.
        /// The welcome screen background image URL. The URL must use the HTTPS protocol and return a PNG image.
        /// </summary>
        [JsonPropertyName("welcomeScreenBackgroundImageUrl")]
        public string WelcomeScreenBackgroundImageUrl { get; set; }
    
        /// <summary>
        /// Gets or sets welcome screen block automatic wake up.
        /// Indicates whether or not to Block the welcome screen from waking up automatically when someone enters the room.
        /// </summary>
        [JsonPropertyName("welcomeScreenBlockAutomaticWakeUp")]
        public bool? WelcomeScreenBlockAutomaticWakeUp { get; set; }
    
        /// <summary>
        /// Gets or sets welcome screen meeting information.
        /// The welcome screen meeting information shown. Possible values are: userDefined, showOrganizerAndTimeOnly, showOrganizerAndTimeAndSubject.
        /// </summary>
        [JsonPropertyName("welcomeScreenMeetingInformation")]
        public WelcomeScreenMeetingInformation? WelcomeScreenMeetingInformation { get; set; }
    
    }
}

