// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ResourceConnector.Models
{
    internal partial class ApplianceSupportedVersionMetadata : IUtf8JsonSerializable, IJsonModel<ApplianceSupportedVersionMetadata>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApplianceSupportedVersionMetadata>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ApplianceSupportedVersionMetadata>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplianceSupportedVersionMetadata>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApplianceSupportedVersionMetadata)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(CatalogVersion))
            {
                writer.WritePropertyName("catalogVersion"u8);
                writer.WriteObjectValue(CatalogVersion, options);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value, ModelSerializationExtensions.JsonDocumentOptions))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        ApplianceSupportedVersionMetadata IJsonModel<ApplianceSupportedVersionMetadata>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplianceSupportedVersionMetadata>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApplianceSupportedVersionMetadata)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApplianceSupportedVersionMetadata(document.RootElement, options);
        }

        internal static ApplianceSupportedVersionMetadata DeserializeApplianceSupportedVersionMetadata(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ApplianceSupportedVersionCatalogVersion catalogVersion = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("catalogVersion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    catalogVersion = ApplianceSupportedVersionCatalogVersion.DeserializeApplianceSupportedVersionCatalogVersion(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ApplianceSupportedVersionMetadata(catalogVersion, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ApplianceSupportedVersionMetadata>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplianceSupportedVersionMetadata>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerResourceConnectorContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ApplianceSupportedVersionMetadata)} does not support writing '{options.Format}' format.");
            }
        }

        ApplianceSupportedVersionMetadata IPersistableModel<ApplianceSupportedVersionMetadata>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplianceSupportedVersionMetadata>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeApplianceSupportedVersionMetadata(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ApplianceSupportedVersionMetadata)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ApplianceSupportedVersionMetadata>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
