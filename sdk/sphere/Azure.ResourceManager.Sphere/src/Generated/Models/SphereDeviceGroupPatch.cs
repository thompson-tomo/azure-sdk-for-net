// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Sphere.Models
{
    /// <summary> The type used for update operations of the DeviceGroup. </summary>
    public partial class SphereDeviceGroupPatch
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

        /// <summary> Initializes a new instance of <see cref="SphereDeviceGroupPatch"/>. </summary>
        public SphereDeviceGroupPatch()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SphereDeviceGroupPatch"/>. </summary>
        /// <param name="description"> Description of the device group. </param>
        /// <param name="osFeedType"> Operating system feed type of the device group. </param>
        /// <param name="updatePolicy"> Update policy of the device group. </param>
        /// <param name="allowCrashDumpsCollection"> Flag to define if the user allows for crash dump collection. </param>
        /// <param name="regionalDataBoundary"> Regional data boundary for the device group. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SphereDeviceGroupPatch(string description, SphereOSFeedType? osFeedType, SphereUpdatePolicy? updatePolicy, SphereAllowCrashDumpCollectionStatus? allowCrashDumpsCollection, RegionalDataBoundary? regionalDataBoundary, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Description = description;
            OSFeedType = osFeedType;
            UpdatePolicy = updatePolicy;
            AllowCrashDumpsCollection = allowCrashDumpsCollection;
            RegionalDataBoundary = regionalDataBoundary;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Description of the device group. </summary>
        public string Description { get; set; }
        /// <summary> Operating system feed type of the device group. </summary>
        public SphereOSFeedType? OSFeedType { get; set; }
        /// <summary> Update policy of the device group. </summary>
        public SphereUpdatePolicy? UpdatePolicy { get; set; }
        /// <summary> Flag to define if the user allows for crash dump collection. </summary>
        public SphereAllowCrashDumpCollectionStatus? AllowCrashDumpsCollection { get; set; }
        /// <summary> Regional data boundary for the device group. </summary>
        public RegionalDataBoundary? RegionalDataBoundary { get; set; }
    }
}
