// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.EventHub.Models
{
    /// <summary> Properties of Messaging Region. </summary>
    public partial class MessagingRegionsProperties
    {
        /// <summary> Initializes a new instance of MessagingRegionsProperties. </summary>
        public MessagingRegionsProperties()
        {
        }

        /// <summary> Initializes a new instance of MessagingRegionsProperties. </summary>
        /// <param name="code"> Region code. </param>
        /// <param name="fullName"> Full name of the region. </param>
        internal MessagingRegionsProperties(string code, string fullName)
        {
            Code = code;
            FullName = fullName;
        }

        /// <summary> Region code. </summary>
        public string Code { get; }
        /// <summary> Full name of the region. </summary>
        public string FullName { get; }
    }
}