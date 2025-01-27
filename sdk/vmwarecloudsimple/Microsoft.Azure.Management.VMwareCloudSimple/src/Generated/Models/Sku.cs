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
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The purchase SKU for CloudSimple paid resources
    /// </summary>
    public partial class Sku
    {
        /// <summary>
        /// Initializes a new instance of the Sku class.
        /// </summary>
        public Sku()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Sku class.
        /// </summary>
        /// <param name="name">The name of the SKU for VMWare CloudSimple
        /// Node</param>
        /// <param name="capacity">The capacity of the SKU</param>
        /// <param name="description">dedicatedCloudNode example: 8 x Ten-Core
        /// Intel® Xeon® Processor E5-2640 v4 2.40GHz 25MB Cache (90W); 12 x
        /// 64GB PC4-19200 2400MHz DDR4 ECC Registered DIMM, ...</param>
        /// <param name="family">If the service has different generations of
        /// hardware, for the same SKU, then that can be captured here</param>
        /// <param name="tier">The tier of the SKU</param>
        public Sku(string name, string capacity = default(string), string description = default(string), string family = default(string), string tier = default(string))
        {
            Capacity = capacity;
            Description = description;
            Family = family;
            Name = name;
            Tier = tier;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the capacity of the SKU
        /// </summary>
        [JsonProperty(PropertyName = "capacity")]
        public string Capacity { get; set; }

        /// <summary>
        /// Gets or sets dedicatedCloudNode example: 8 x Ten-Core Intel® Xeon®
        /// Processor E5-2640 v4 2.40GHz 25MB Cache (90W); 12 x 64GB PC4-19200
        /// 2400MHz DDR4 ECC Registered DIMM, ...
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets if the service has different generations of hardware,
        /// for the same SKU, then that can be captured here
        /// </summary>
        [JsonProperty(PropertyName = "family")]
        public string Family { get; set; }

        /// <summary>
        /// Gets or sets the name of the SKU for VMWare CloudSimple Node
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the tier of the SKU
        /// </summary>
        [JsonProperty(PropertyName = "tier")]
        public string Tier { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
        }
    }
}
