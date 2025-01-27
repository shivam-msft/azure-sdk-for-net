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
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Resource pool model
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ResourcePool
    {
        /// <summary>
        /// Initializes a new instance of the ResourcePool class.
        /// </summary>
        public ResourcePool()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResourcePool class.
        /// </summary>
        /// <param name="id">resource pool id
        /// (privateCloudId:vsphereId)</param>
        /// <param name="location">Azure region</param>
        /// <param name="name">{ResourcePoolName}</param>
        /// <param name="privateCloudId">The Private Cloud Id</param>
        /// <param name="fullName">Hierarchical resource pool name</param>
        /// <param
        /// name="type">{resourceProviderNamespace}/{resourceType}</param>
        public ResourcePool(string id, string location = default(string), string name = default(string), string privateCloudId = default(string), string fullName = default(string), string type = default(string))
        {
            Id = id;
            Location = location;
            Name = name;
            PrivateCloudId = privateCloudId;
            FullName = fullName;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets resource pool id (privateCloudId:vsphereId)
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets azure region
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; private set; }

        /// <summary>
        /// Gets {ResourcePoolName}
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the Private Cloud Id
        /// </summary>
        [JsonProperty(PropertyName = "privateCloudId")]
        public string PrivateCloudId { get; private set; }

        /// <summary>
        /// Gets hierarchical resource pool name
        /// </summary>
        [JsonProperty(PropertyName = "properties.fullName")]
        public string FullName { get; private set; }

        /// <summary>
        /// Gets {resourceProviderNamespace}/{resourceType}
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Id == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Id");
            }
        }
    }
}
