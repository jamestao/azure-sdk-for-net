// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.PostgreSQL.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for ServerSecurityAlertPolicyState.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ServerSecurityAlertPolicyState
    {
        [EnumMember(Value = "Enabled")]
        Enabled,
        [EnumMember(Value = "Disabled")]
        Disabled
    }
    internal static class ServerSecurityAlertPolicyStateEnumExtension
    {
        internal static string ToSerializedValue(this ServerSecurityAlertPolicyState? value)
        {
            return value == null ? null : ((ServerSecurityAlertPolicyState)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this ServerSecurityAlertPolicyState value)
        {
            switch( value )
            {
                case ServerSecurityAlertPolicyState.Enabled:
                    return "Enabled";
                case ServerSecurityAlertPolicyState.Disabled:
                    return "Disabled";
            }
            return null;
        }

        internal static ServerSecurityAlertPolicyState? ParseServerSecurityAlertPolicyState(this string value)
        {
            switch( value )
            {
                case "Enabled":
                    return ServerSecurityAlertPolicyState.Enabled;
                case "Disabled":
                    return ServerSecurityAlertPolicyState.Disabled;
            }
            return null;
        }
    }
}
