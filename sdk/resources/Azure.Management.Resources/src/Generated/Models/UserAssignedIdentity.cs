// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.Resources.Models
{
    /// <summary> User-assigned managed identity. </summary>
    public partial class UserAssignedIdentity
    {
        /// <summary> Initializes a new instance of UserAssignedIdentity. </summary>
        public UserAssignedIdentity()
        {
        }

        /// <summary> Initializes a new instance of UserAssignedIdentity. </summary>
        /// <param name="principalId"> Azure Active Directory principal ID associated with this identity. </param>
        /// <param name="clientId"> Client App Id associated with this identity. </param>
        internal UserAssignedIdentity(string principalId, string clientId)
        {
            PrincipalId = principalId;
            ClientId = clientId;
        }

        /// <summary> Azure Active Directory principal ID associated with this identity. </summary>
        public string PrincipalId { get; set; }
        /// <summary> Client App Id associated with this identity. </summary>
        public string ClientId { get; set; }
    }
}