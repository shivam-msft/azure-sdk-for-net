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
    /// Host name model
    /// </summary>
    public partial class CustomizationHostName
    {
        /// <summary>
        /// Initializes a new instance of the CustomizationHostName class.
        /// </summary>
        public CustomizationHostName()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CustomizationHostName class.
        /// </summary>
        /// <param name="name">Hostname</param>
        /// <param name="type">Type of host name. Possible values include:
        /// 'USER_DEFINED', 'PREFIX_BASED', 'FIXED', 'VIRTUAL_MACHINE_NAME',
        /// 'CUSTOM_NAME'</param>
        public CustomizationHostName(string name = default(string), string type = default(string))
        {
            Name = name;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets hostname
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets type of host name. Possible values include:
        /// 'USER_DEFINED', 'PREFIX_BASED', 'FIXED', 'VIRTUAL_MACHINE_NAME',
        /// 'CUSTOM_NAME'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

    }
}
