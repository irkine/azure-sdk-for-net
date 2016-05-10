
namespace Microsoft.Azure.Management.PowerBIEmbedded.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    public partial class AzureArrayWorkspaceCollection
    {
        /// <summary>
        /// Initializes a new instance of the AzureArrayWorkspaceCollection
        /// class.
        /// </summary>
        public AzureArrayWorkspaceCollection() { }

        /// <summary>
        /// Initializes a new instance of the AzureArrayWorkspaceCollection
        /// class.
        /// </summary>
        public AzureArrayWorkspaceCollection(IList<WorkspaceCollection> value = default(IList<WorkspaceCollection>))
        {
            Value = value;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<WorkspaceCollection> Value { get; set; }

    }
}
