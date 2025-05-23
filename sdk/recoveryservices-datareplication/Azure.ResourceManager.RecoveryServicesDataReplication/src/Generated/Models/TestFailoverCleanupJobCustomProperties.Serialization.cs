// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    public partial class TestFailoverCleanupJobCustomProperties : IUtf8JsonSerializable, IJsonModel<TestFailoverCleanupJobCustomProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TestFailoverCleanupJobCustomProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<TestFailoverCleanupJobCustomProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TestFailoverCleanupJobCustomProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TestFailoverCleanupJobCustomProperties)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (options.Format != "W" && Optional.IsDefined(Comments))
            {
                writer.WritePropertyName("comments"u8);
                writer.WriteStringValue(Comments);
            }
        }

        TestFailoverCleanupJobCustomProperties IJsonModel<TestFailoverCleanupJobCustomProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TestFailoverCleanupJobCustomProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TestFailoverCleanupJobCustomProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTestFailoverCleanupJobCustomProperties(document.RootElement, options);
        }

        internal static TestFailoverCleanupJobCustomProperties DeserializeTestFailoverCleanupJobCustomProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string comments = default;
            string instanceType = default;
            AffectedObjectDetails affectedObjectDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("comments"u8))
                {
                    comments = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("affectedObjectDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    affectedObjectDetails = AffectedObjectDetails.DeserializeAffectedObjectDetails(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new TestFailoverCleanupJobCustomProperties(instanceType, affectedObjectDetails, serializedAdditionalRawData, comments);
        }

        BinaryData IPersistableModel<TestFailoverCleanupJobCustomProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TestFailoverCleanupJobCustomProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerRecoveryServicesDataReplicationContext.Default);
                default:
                    throw new FormatException($"The model {nameof(TestFailoverCleanupJobCustomProperties)} does not support writing '{options.Format}' format.");
            }
        }

        TestFailoverCleanupJobCustomProperties IPersistableModel<TestFailoverCleanupJobCustomProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TestFailoverCleanupJobCustomProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeTestFailoverCleanupJobCustomProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TestFailoverCleanupJobCustomProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<TestFailoverCleanupJobCustomProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
