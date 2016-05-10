
namespace Microsoft.Azure.Management.PowerBIEmbedded.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    public partial class AzureArrayOperation
    {
        /// <summary>
        /// Initializes a new instance of the AzureArrayOperation class.
        /// </summary>
        public AzureArrayOperation() { }

        /// <summary>
        /// Initializes a new instance of the AzureArrayOperation class.
        /// </summary>
        public AzureArrayOperation(IList<Operation> value = default(IList<Operation>))
        {
            Value = value;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<Operation> Value { get; set; }

    }
}
