// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.VMwareCloudSimple.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines headers for Delete operation.
    /// </summary>
    public partial class DedicatedCloudServicesDeleteHeaders
    {
        /// <summary>
        /// Initializes a new instance of the
        /// DedicatedCloudServicesDeleteHeaders class.
        /// </summary>
        public DedicatedCloudServicesDeleteHeaders()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// DedicatedCloudServicesDeleteHeaders class.
        /// </summary>
        public DedicatedCloudServicesDeleteHeaders(string contentType = default(string))
        {
            ContentType = contentType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Content-Type")]
        public string ContentType { get; set; }

    }
}
