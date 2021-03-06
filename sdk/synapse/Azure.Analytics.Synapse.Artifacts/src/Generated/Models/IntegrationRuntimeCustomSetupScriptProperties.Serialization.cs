// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class IntegrationRuntimeCustomSetupScriptProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(BlobContainerUri))
            {
                writer.WritePropertyName("blobContainerUri");
                writer.WriteStringValue(BlobContainerUri);
            }
            if (Optional.IsDefined(SasToken))
            {
                writer.WritePropertyName("sasToken");
                writer.WriteObjectValue(SasToken);
            }
            writer.WriteEndObject();
        }

        internal static IntegrationRuntimeCustomSetupScriptProperties DeserializeIntegrationRuntimeCustomSetupScriptProperties(JsonElement element)
        {
            Optional<string> blobContainerUri = default;
            Optional<SecureString> sasToken = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("blobContainerUri"))
                {
                    blobContainerUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sasToken"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sasToken = SecureString.DeserializeSecureString(property.Value);
                    continue;
                }
            }
            return new IntegrationRuntimeCustomSetupScriptProperties(blobContainerUri.Value, sasToken.Value);
        }
    }
}
