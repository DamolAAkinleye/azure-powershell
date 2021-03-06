// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Commands.Synapse.Models
{
    using global::Azure.Analytics.Synapse.Artifacts.Models;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Square Service dataset.
    /// </summary>
    [Newtonsoft.Json.JsonObject("SquareObject")]
    [Rest.Serialization.JsonTransformation]
    public partial class PSSquareObjectDataset : PSDataset
    {
        /// <summary>
        /// Initializes a new instance of the PSSquareObjectDataset class.
        /// </summary>
        public PSSquareObjectDataset()
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the table name. Type: string (or Expression with
        /// resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.tableName")]
        public object TableName { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }

        public override Dataset ToSdkObject()
        {
            var dataset = new SquareObjectDataset(this.LinkedServiceName);
            dataset.TableName = this.TableName;
            SetProperties(dataset);
            return dataset;
        }
    }
}

