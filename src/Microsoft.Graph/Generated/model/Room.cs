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
    /// The type Room.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<Room>))]
    public partial class Room : Place
    {
    
		///<summary>
		/// The Room constructor
		///</summary>
        public Room()
        {
            this.ODataType = "microsoft.graph.room";
        }
	
        /// <summary>
        /// Gets or sets audio device name.
        /// Specifies the name of the audio device in the room.
        /// </summary>
        [JsonPropertyName("audioDeviceName")]
        public string AudioDeviceName { get; set; }
    
        /// <summary>
        /// Gets or sets booking type.
        /// Type of room. Possible values are standard, and reserved.
        /// </summary>
        [JsonPropertyName("bookingType")]
        public BookingType? BookingType { get; set; }
    
        /// <summary>
        /// Gets or sets building.
        /// Specifies the building name or building number that the room is in.
        /// </summary>
        [JsonPropertyName("building")]
        public string Building { get; set; }
    
        /// <summary>
        /// Gets or sets capacity.
        /// Specifies the capacity of the room.
        /// </summary>
        [JsonPropertyName("capacity")]
        public Int32? Capacity { get; set; }
    
        /// <summary>
        /// Gets or sets display device name.
        /// Specifies the name of the display device in the room.
        /// </summary>
        [JsonPropertyName("displayDeviceName")]
        public string DisplayDeviceName { get; set; }
    
        /// <summary>
        /// Gets or sets email address.
        /// Email address of the room.
        /// </summary>
        [JsonPropertyName("emailAddress")]
        public string EmailAddress { get; set; }
    
        /// <summary>
        /// Gets or sets floor label.
        /// Specifies a descriptive label for the floor, for example, P.
        /// </summary>
        [JsonPropertyName("floorLabel")]
        public string FloorLabel { get; set; }
    
        /// <summary>
        /// Gets or sets floor number.
        /// Specifies the floor number that the room is on.
        /// </summary>
        [JsonPropertyName("floorNumber")]
        public Int32? FloorNumber { get; set; }
    
        /// <summary>
        /// Gets or sets is wheel chair accessible.
        /// Specifies whether the room is wheelchair accessible.
        /// </summary>
        [JsonPropertyName("isWheelChairAccessible")]
        public bool? IsWheelChairAccessible { get; set; }
    
        /// <summary>
        /// Gets or sets label.
        /// Specifies a descriptive label for the room, for example, a number or name.
        /// </summary>
        [JsonPropertyName("label")]
        public string Label { get; set; }
    
        /// <summary>
        /// Gets or sets nickname.
        /// Specifies a nickname for the room, for example, 'conf room'.
        /// </summary>
        [JsonPropertyName("nickname")]
        public string Nickname { get; set; }
    
        /// <summary>
        /// Gets or sets tags.
        /// Specifies additional features of the room, for example, details like the type of view or furniture type.
        /// </summary>
        [JsonPropertyName("tags")]
        public IEnumerable<string> Tags { get; set; }
    
        /// <summary>
        /// Gets or sets video device name.
        /// Specifies the name of the video device in the room.
        /// </summary>
        [JsonPropertyName("videoDeviceName")]
        public string VideoDeviceName { get; set; }
    
    }
}

