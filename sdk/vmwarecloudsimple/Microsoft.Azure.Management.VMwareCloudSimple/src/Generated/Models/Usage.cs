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
    /// Usage model
    /// </summary>
    public partial class Usage
    {
        /// <summary>
        /// Initializes a new instance of the Usage class.
        /// </summary>
        public Usage()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Usage class.
        /// </summary>
        /// <param name="currentValue">The current usage value</param>
        /// <param name="limit">limit of a given sku in a region for a
        /// subscription. The maximum permitted value for the usage quota. If
        /// there is no limit, this value will be -1</param>
        /// <param name="name">Usage name value and localized name</param>
        /// <param name="unit">The usages' unit. Possible values include:
        /// 'Count', 'Bytes', 'Seconds', 'Percent', 'CountPerSecond',
        /// 'BytesPerSecond'</param>
        public Usage(int currentValue, int limit, UsageName name = default(UsageName), UsageCount? unit = default(UsageCount?))
        {
            CurrentValue = currentValue;
            Limit = limit;
            Name = name;
            Unit = unit;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the current usage value
        /// </summary>
        [JsonProperty(PropertyName = "currentValue")]
        public int CurrentValue { get; set; }

        /// <summary>
        /// Gets or sets limit of a given sku in a region for a subscription.
        /// The maximum permitted value for the usage quota. If there is no
        /// limit, this value will be -1
        /// </summary>
        [JsonProperty(PropertyName = "limit")]
        public int Limit { get; set; }

        /// <summary>
        /// Gets or sets usage name value and localized name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public UsageName Name { get; set; }

        /// <summary>
        /// Gets or sets the usages' unit. Possible values include: 'Count',
        /// 'Bytes', 'Seconds', 'Percent', 'CountPerSecond', 'BytesPerSecond'
        /// </summary>
        [JsonProperty(PropertyName = "unit")]
        public UsageCount? Unit { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
