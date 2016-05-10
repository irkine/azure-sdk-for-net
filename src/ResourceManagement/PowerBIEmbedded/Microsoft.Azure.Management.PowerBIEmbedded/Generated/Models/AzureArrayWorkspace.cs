
namespace Microsoft.Azure.Management.PowerBIEmbedded.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    public partial class AzureArrayWorkspace
    {
        /// <summary>
        /// Initializes a new instance of the AzureArrayWorkspace class.
        /// </summary>
        public AzureArrayWorkspace() { }

        /// <summary>
        /// Initializes a new instance of the AzureArrayWorkspace class.
        /// </summary>
        public AzureArrayWorkspace(IList<Workspace> value = default(IList<Workspace>))
        {
            Value = value;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<Workspace> Value { get; set; }

    }
}
