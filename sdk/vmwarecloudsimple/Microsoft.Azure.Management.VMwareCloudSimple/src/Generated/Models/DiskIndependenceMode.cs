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
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for DiskIndependenceMode.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DiskIndependenceMode
    {
        [EnumMember(Value = "persistent")]
        Persistent,
        [EnumMember(Value = "independent_persistent")]
        IndependentPersistent,
        [EnumMember(Value = "independent_nonpersistent")]
        IndependentNonpersistent
    }
    internal static class DiskIndependenceModeEnumExtension
    {
        internal static string ToSerializedValue(this DiskIndependenceMode? value)
        {
            return value == null ? null : ((DiskIndependenceMode)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this DiskIndependenceMode value)
        {
            switch( value )
            {
                case DiskIndependenceMode.Persistent:
                    return "persistent";
                case DiskIndependenceMode.IndependentPersistent:
                    return "independent_persistent";
                case DiskIndependenceMode.IndependentNonpersistent:
                    return "independent_nonpersistent";
            }
            return null;
        }

        internal static DiskIndependenceMode? ParseDiskIndependenceMode(this string value)
        {
            switch( value )
            {
                case "persistent":
                    return DiskIndependenceMode.Persistent;
                case "independent_persistent":
                    return DiskIndependenceMode.IndependentPersistent;
                case "independent_nonpersistent":
                    return DiskIndependenceMode.IndependentNonpersistent;
            }
            return null;
        }
    }
}
