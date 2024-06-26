// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Orbital.Models
{
    /// <summary> Customer retrieves list of Available Contacts for a spacecraft resource. Later, one of the available contact can be selected to create a contact. </summary>
    public partial class OrbitalAvailableContact
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="OrbitalAvailableContact"/>. </summary>
        internal OrbitalAvailableContact()
        {
        }

        /// <summary> Initializes a new instance of <see cref="OrbitalAvailableContact"/>. </summary>
        /// <param name="spacecraft"> The reference to the spacecraft resource. </param>
        /// <param name="groundStationName"> Name of Azure Ground Station. </param>
        /// <param name="maximumElevationDegrees"> Maximum elevation of the antenna during the contact in decimal degrees. </param>
        /// <param name="txStartOn"> Time at which antenna transmit will be enabled (ISO 8601 UTC standard). </param>
        /// <param name="txEndOn"> Time at which antenna transmit will be disabled (ISO 8601 UTC standard). </param>
        /// <param name="rxStartOn"> Earliest time to receive a signal (ISO 8601 UTC standard). </param>
        /// <param name="rxEndOn"> Time to lost receiving a signal (ISO 8601 UTC standard). </param>
        /// <param name="startAzimuthDegrees"> Azimuth of the antenna at the start of the contact in decimal degrees. </param>
        /// <param name="endAzimuthDegrees"> Azimuth of the antenna at the end of the contact in decimal degrees. </param>
        /// <param name="startElevationDegrees"> Spacecraft elevation above the horizon at contact start. </param>
        /// <param name="endElevationDegrees"> Spacecraft elevation above the horizon at contact end. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal OrbitalAvailableContact(WritableSubResource spacecraft, string groundStationName, float? maximumElevationDegrees, DateTimeOffset? txStartOn, DateTimeOffset? txEndOn, DateTimeOffset? rxStartOn, DateTimeOffset? rxEndOn, float? startAzimuthDegrees, float? endAzimuthDegrees, float? startElevationDegrees, float? endElevationDegrees, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Spacecraft = spacecraft;
            GroundStationName = groundStationName;
            MaximumElevationDegrees = maximumElevationDegrees;
            TxStartOn = txStartOn;
            TxEndOn = txEndOn;
            RxStartOn = rxStartOn;
            RxEndOn = rxEndOn;
            StartAzimuthDegrees = startAzimuthDegrees;
            EndAzimuthDegrees = endAzimuthDegrees;
            StartElevationDegrees = startElevationDegrees;
            EndElevationDegrees = endElevationDegrees;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The reference to the spacecraft resource. </summary>
        internal WritableSubResource Spacecraft { get; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier SpacecraftId
        {
            get => Spacecraft?.Id;
        }

        /// <summary> Name of Azure Ground Station. </summary>
        public string GroundStationName { get; }
        /// <summary> Maximum elevation of the antenna during the contact in decimal degrees. </summary>
        public float? MaximumElevationDegrees { get; }
        /// <summary> Time at which antenna transmit will be enabled (ISO 8601 UTC standard). </summary>
        public DateTimeOffset? TxStartOn { get; }
        /// <summary> Time at which antenna transmit will be disabled (ISO 8601 UTC standard). </summary>
        public DateTimeOffset? TxEndOn { get; }
        /// <summary> Earliest time to receive a signal (ISO 8601 UTC standard). </summary>
        public DateTimeOffset? RxStartOn { get; }
        /// <summary> Time to lost receiving a signal (ISO 8601 UTC standard). </summary>
        public DateTimeOffset? RxEndOn { get; }
        /// <summary> Azimuth of the antenna at the start of the contact in decimal degrees. </summary>
        public float? StartAzimuthDegrees { get; }
        /// <summary> Azimuth of the antenna at the end of the contact in decimal degrees. </summary>
        public float? EndAzimuthDegrees { get; }
        /// <summary> Spacecraft elevation above the horizon at contact start. </summary>
        public float? StartElevationDegrees { get; }
        /// <summary> Spacecraft elevation above the horizon at contact end. </summary>
        public float? EndElevationDegrees { get; }
    }
}
