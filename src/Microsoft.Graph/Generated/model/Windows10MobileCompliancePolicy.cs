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
    /// The type Windows10Mobile Compliance Policy.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<Windows10MobileCompliancePolicy>))]
    public partial class Windows10MobileCompliancePolicy : DeviceCompliancePolicy
    {
    
		///<summary>
		/// The Windows10MobileCompliancePolicy constructor
		///</summary>
        public Windows10MobileCompliancePolicy()
        {
            this.ODataType = "microsoft.graph.windows10MobileCompliancePolicy";
        }
	
        /// <summary>
        /// Gets or sets bit locker enabled.
        /// Require devices to be reported healthy by Windows Device Health Attestation - bit locker is enabled
        /// </summary>
        [JsonPropertyName("bitLockerEnabled")]
        public bool? BitLockerEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets code integrity enabled.
        /// Require devices to be reported as healthy by Windows Device Health Attestation.
        /// </summary>
        [JsonPropertyName("codeIntegrityEnabled")]
        public bool? CodeIntegrityEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets early launch anti malware driver enabled.
        /// Require devices to be reported as healthy by Windows Device Health Attestation - early launch antimalware driver is enabled.
        /// </summary>
        [JsonPropertyName("earlyLaunchAntiMalwareDriverEnabled")]
        public bool? EarlyLaunchAntiMalwareDriverEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets os maximum version.
        /// Maximum Windows Phone version.
        /// </summary>
        [JsonPropertyName("osMaximumVersion")]
        public string OsMaximumVersion { get; set; }
    
        /// <summary>
        /// Gets or sets os minimum version.
        /// Minimum Windows Phone version.
        /// </summary>
        [JsonPropertyName("osMinimumVersion")]
        public string OsMinimumVersion { get; set; }
    
        /// <summary>
        /// Gets or sets password block simple.
        /// Whether or not to block syncing the calendar.
        /// </summary>
        [JsonPropertyName("passwordBlockSimple")]
        public bool? PasswordBlockSimple { get; set; }
    
        /// <summary>
        /// Gets or sets password expiration days.
        /// Number of days before password expiration. Valid values 1 to 255
        /// </summary>
        [JsonPropertyName("passwordExpirationDays")]
        public Int32? PasswordExpirationDays { get; set; }
    
        /// <summary>
        /// Gets or sets password minimum character set count.
        /// The number of character sets required in the password.
        /// </summary>
        [JsonPropertyName("passwordMinimumCharacterSetCount")]
        public Int32? PasswordMinimumCharacterSetCount { get; set; }
    
        /// <summary>
        /// Gets or sets password minimum length.
        /// Minimum password length. Valid values 4 to 16
        /// </summary>
        [JsonPropertyName("passwordMinimumLength")]
        public Int32? PasswordMinimumLength { get; set; }
    
        /// <summary>
        /// Gets or sets password minutes of inactivity before lock.
        /// Minutes of inactivity before a password is required.
        /// </summary>
        [JsonPropertyName("passwordMinutesOfInactivityBeforeLock")]
        public Int32? PasswordMinutesOfInactivityBeforeLock { get; set; }
    
        /// <summary>
        /// Gets or sets password previous password block count.
        /// The number of previous passwords to prevent re-use of.
        /// </summary>
        [JsonPropertyName("passwordPreviousPasswordBlockCount")]
        public Int32? PasswordPreviousPasswordBlockCount { get; set; }
    
        /// <summary>
        /// Gets or sets password required.
        /// Require a password to unlock Windows Phone device.
        /// </summary>
        [JsonPropertyName("passwordRequired")]
        public bool? PasswordRequired { get; set; }
    
        /// <summary>
        /// Gets or sets password required type.
        /// The required password type. Possible values are: deviceDefault, alphanumeric, numeric.
        /// </summary>
        [JsonPropertyName("passwordRequiredType")]
        public RequiredPasswordType? PasswordRequiredType { get; set; }
    
        /// <summary>
        /// Gets or sets password require to unlock from idle.
        /// Require a password to unlock an idle device.
        /// </summary>
        [JsonPropertyName("passwordRequireToUnlockFromIdle")]
        public bool? PasswordRequireToUnlockFromIdle { get; set; }
    
        /// <summary>
        /// Gets or sets secure boot enabled.
        /// Require devices to be reported as healthy by Windows Device Health Attestation - secure boot is enabled.
        /// </summary>
        [JsonPropertyName("secureBootEnabled")]
        public bool? SecureBootEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets storage require encryption.
        /// Require encryption on windows devices.
        /// </summary>
        [JsonPropertyName("storageRequireEncryption")]
        public bool? StorageRequireEncryption { get; set; }
    
    }
}

