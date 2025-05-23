// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Projects
{
    public partial class ConnectionPropertiesApiKeyAuth : IUtf8JsonSerializable, IJsonModel<ConnectionPropertiesApiKeyAuth>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConnectionPropertiesApiKeyAuth>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ConnectionPropertiesApiKeyAuth>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectionPropertiesApiKeyAuth>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConnectionPropertiesApiKeyAuth)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("credentials"u8);
            writer.WriteObjectValue(Credentials, options);
        }

        ConnectionPropertiesApiKeyAuth IJsonModel<ConnectionPropertiesApiKeyAuth>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectionPropertiesApiKeyAuth>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConnectionPropertiesApiKeyAuth)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConnectionPropertiesApiKeyAuth(document.RootElement, options);
        }

        internal static ConnectionPropertiesApiKeyAuth DeserializeConnectionPropertiesApiKeyAuth(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            CredentialsApiKeyAuth credentials = default;
            AuthenticationType authType = default;
            ConnectionType category = default;
            string target = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("credentials"u8))
                {
                    credentials = CredentialsApiKeyAuth.DeserializeCredentialsApiKeyAuth(property.Value, options);
                    continue;
                }
                if (property.NameEquals("authType"u8))
                {
                    authType = property.Value.GetString().ToAuthenticationType();
                    continue;
                }
                if (property.NameEquals("category"u8))
                {
                    category = new ConnectionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("target"u8))
                {
                    target = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ConnectionPropertiesApiKeyAuth(authType, category, target, serializedAdditionalRawData, credentials);
        }

        BinaryData IPersistableModel<ConnectionPropertiesApiKeyAuth>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectionPropertiesApiKeyAuth>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureAIProjectsContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ConnectionPropertiesApiKeyAuth)} does not support writing '{options.Format}' format.");
            }
        }

        ConnectionPropertiesApiKeyAuth IPersistableModel<ConnectionPropertiesApiKeyAuth>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectionPropertiesApiKeyAuth>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeConnectionPropertiesApiKeyAuth(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConnectionPropertiesApiKeyAuth)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConnectionPropertiesApiKeyAuth>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new ConnectionPropertiesApiKeyAuth FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeConnectionPropertiesApiKeyAuth(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
