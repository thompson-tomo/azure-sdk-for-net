// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The logging properties of the connected registry. </summary>
    public partial class ConnectedRegistryLogging
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

        /// <summary> Initializes a new instance of <see cref="ConnectedRegistryLogging"/>. </summary>
        public ConnectedRegistryLogging()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ConnectedRegistryLogging"/>. </summary>
        /// <param name="logLevel"> The verbosity of logs persisted on the connected registry. </param>
        /// <param name="auditLogStatus"> Indicates whether audit logs are enabled on the connected registry. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ConnectedRegistryLogging(ConnectedRegistryLogLevel? logLevel, ConnectedRegistryAuditLogStatus? auditLogStatus, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            LogLevel = logLevel;
            AuditLogStatus = auditLogStatus;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The verbosity of logs persisted on the connected registry. </summary>
        [WirePath("logLevel")]
        public ConnectedRegistryLogLevel? LogLevel { get; set; }
        /// <summary> Indicates whether audit logs are enabled on the connected registry. </summary>
        [WirePath("auditLogStatus")]
        public ConnectedRegistryAuditLogStatus? AuditLogStatus { get; set; }
    }
}
