// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class WebActivityAuthentication : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type);
            if (Pfx != null)
            {
                writer.WritePropertyName("pfx");
                writer.WriteObjectValue(Pfx);
            }
            if (Username != null)
            {
                writer.WritePropertyName("username");
                writer.WriteStringValue(Username);
            }
            if (Password != null)
            {
                writer.WritePropertyName("password");
                writer.WriteObjectValue(Password);
            }
            if (Resource != null)
            {
                writer.WritePropertyName("resource");
                writer.WriteStringValue(Resource);
            }
            writer.WriteEndObject();
        }

        internal static WebActivityAuthentication DeserializeWebActivityAuthentication(JsonElement element)
        {
            string type = default;
            SecretBase pfx = default;
            string username = default;
            SecretBase password = default;
            string resource = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("pfx"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    pfx = SecretBase.DeserializeSecretBase(property.Value);
                    continue;
                }
                if (property.NameEquals("username"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    username = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("password"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    password = SecretBase.DeserializeSecretBase(property.Value);
                    continue;
                }
                if (property.NameEquals("resource"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resource = property.Value.GetString();
                    continue;
                }
            }
            return new WebActivityAuthentication(type, pfx, username, password, resource);
        }
    }
}