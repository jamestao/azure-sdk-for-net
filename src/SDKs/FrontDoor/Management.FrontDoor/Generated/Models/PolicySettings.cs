// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.FrontDoor.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines top-level WebApplicationFirewallPolicy configuration settings.
    /// </summary>
    public partial class PolicySettings
    {
        /// <summary>
        /// Initializes a new instance of the PolicySettings class.
        /// </summary>
        public PolicySettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PolicySettings class.
        /// </summary>
        /// <param name="enabledState">Describes if the policy is in enabled or
        /// disabled state. Defaults to Enabled if not specified. Possible
        /// values include: 'Disabled', 'Enabled'</param>
        /// <param name="mode">Describes if it is in detection mode or
        /// prevention mode at policy level. Possible values include:
        /// 'Prevention', 'Detection'</param>
        /// <param name="redirectUrl">If action type is redirect, this field
        /// represents redirect URL for the client.</param>
        /// <param name="customBlockResponseStatusCode">If the action type is
        /// block, customer can override the response status code.</param>
        /// <param name="customBlockResponseBody">If the action type is block,
        /// customer can override the response body. The body must be specified
        /// in base64 encoding.</param>
        public PolicySettings(string enabledState = default(string), string mode = default(string), string redirectUrl = default(string), int? customBlockResponseStatusCode = default(int?), string customBlockResponseBody = default(string))
        {
            EnabledState = enabledState;
            Mode = mode;
            RedirectUrl = redirectUrl;
            CustomBlockResponseStatusCode = customBlockResponseStatusCode;
            CustomBlockResponseBody = customBlockResponseBody;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets describes if the policy is in enabled or disabled
        /// state. Defaults to Enabled if not specified. Possible values
        /// include: 'Disabled', 'Enabled'
        /// </summary>
        [JsonProperty(PropertyName = "enabledState")]
        public string EnabledState { get; set; }

        /// <summary>
        /// Gets or sets describes if it is in detection mode or prevention
        /// mode at policy level. Possible values include: 'Prevention',
        /// 'Detection'
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        public string Mode { get; set; }

        /// <summary>
        /// Gets or sets if action type is redirect, this field represents
        /// redirect URL for the client.
        /// </summary>
        [JsonProperty(PropertyName = "redirectUrl")]
        public string RedirectUrl { get; set; }

        /// <summary>
        /// Gets or sets if the action type is block, customer can override the
        /// response status code.
        /// </summary>
        [JsonProperty(PropertyName = "customBlockResponseStatusCode")]
        public int? CustomBlockResponseStatusCode { get; set; }

        /// <summary>
        /// Gets or sets if the action type is block, customer can override the
        /// response body. The body must be specified in base64 encoding.
        /// </summary>
        [JsonProperty(PropertyName = "customBlockResponseBody")]
        public string CustomBlockResponseBody { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (CustomBlockResponseBody != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(CustomBlockResponseBody, "^(?:[A-Za-z0-9+/]{4})*(?:[A-Za-z0-9+/]{2}==|[A-Za-z0-9+/]{3}=|[A-Za-z0-9+/]{4})$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "CustomBlockResponseBody", "^(?:[A-Za-z0-9+/]{4})*(?:[A-Za-z0-9+/]{2}==|[A-Za-z0-9+/]{3}=|[A-Za-z0-9+/]{4})$");
                }
            }
        }
    }
}
