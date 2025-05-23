// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace _Type.Property.ValueTypes
{
    public partial class UnknownStringProperty : IJsonModel<UnknownStringProperty>
    {
        internal UnknownStringProperty() => throw null;

        void IJsonModel<UnknownStringProperty>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => throw null;

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options) => throw null;

        UnknownStringProperty IJsonModel<UnknownStringProperty>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => throw null;

        protected virtual UnknownStringProperty JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => throw null;

        BinaryData IPersistableModel<UnknownStringProperty>.Write(ModelReaderWriterOptions options) => throw null;

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options) => throw null;

        UnknownStringProperty IPersistableModel<UnknownStringProperty>.Create(BinaryData data, ModelReaderWriterOptions options) => throw null;

        protected virtual UnknownStringProperty PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options) => throw null;

        string IPersistableModel<UnknownStringProperty>.GetFormatFromOptions(ModelReaderWriterOptions options) => throw null;

        /// <param name="unknownStringProperty"> The <see cref="UnknownStringProperty"/> to serialize into <see cref="RequestContent"/>. </param>
        public static implicit operator RequestContent(UnknownStringProperty unknownStringProperty) => throw null;

        public static explicit operator UnknownStringProperty(Response result) => throw null;
    }
}
