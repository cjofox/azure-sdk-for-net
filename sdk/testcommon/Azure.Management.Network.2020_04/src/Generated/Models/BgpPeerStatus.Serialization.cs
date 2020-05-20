// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class BgpPeerStatus
    {
        internal static BgpPeerStatus DeserializeBgpPeerStatus(JsonElement element)
        {
            string localAddress = default;
            string neighbor = default;
            long? asn = default;
            BgpPeerState? state = default;
            string connectedDuration = default;
            long? routesReceived = default;
            long? messagesSent = default;
            long? messagesReceived = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("localAddress"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    localAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("neighbor"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    neighbor = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("asn"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    asn = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("state"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new BgpPeerState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("connectedDuration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    connectedDuration = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("routesReceived"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    routesReceived = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("messagesSent"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    messagesSent = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("messagesReceived"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    messagesReceived = property.Value.GetInt64();
                    continue;
                }
            }
            return new BgpPeerStatus(localAddress, neighbor, asn, state, connectedDuration, routesReceived, messagesSent, messagesReceived);
        }
    }
}