// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DeploymentManager.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines the properties of a Wait step.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Wait")]
    public partial class WaitStepProperties : StepProperties
    {
        /// <summary>
        /// Initializes a new instance of the WaitStepProperties class.
        /// </summary>
        public WaitStepProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WaitStepProperties class.
        /// </summary>
        /// <param name="attributes">The Wait attributes</param>
        public WaitStepProperties(WaitStepAttributes attributes = default(WaitStepAttributes))
        {
            Attributes = attributes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Wait attributes
        /// </summary>
        [JsonProperty(PropertyName = "attributes")]
        public WaitStepAttributes Attributes { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Attributes != null)
            {
                Attributes.Validate();
            }
        }
    }
}
