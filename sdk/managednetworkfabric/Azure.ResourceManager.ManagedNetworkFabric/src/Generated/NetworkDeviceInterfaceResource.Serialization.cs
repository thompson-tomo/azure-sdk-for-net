// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    public partial class NetworkDeviceInterfaceResource : IJsonModel<NetworkDeviceInterfaceData>
    {
        void IJsonModel<NetworkDeviceInterfaceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<NetworkDeviceInterfaceData>)Data).Write(writer, options);

        NetworkDeviceInterfaceData IJsonModel<NetworkDeviceInterfaceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<NetworkDeviceInterfaceData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<NetworkDeviceInterfaceData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<NetworkDeviceInterfaceData>(Data, options, AzureResourceManagerManagedNetworkFabricContext.Default);

        NetworkDeviceInterfaceData IPersistableModel<NetworkDeviceInterfaceData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<NetworkDeviceInterfaceData>(data, options, AzureResourceManagerManagedNetworkFabricContext.Default);

        string IPersistableModel<NetworkDeviceInterfaceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<NetworkDeviceInterfaceData>)Data).GetFormatFromOptions(options);
    }
}
