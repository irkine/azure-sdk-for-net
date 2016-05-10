
namespace Microsoft.Azure.Management.PowerBIEmbedded.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    public partial class CreateWorkspaceCollectionRequest
    {
        /// <summary>
        /// Initializes a new instance of the CreateWorkspaceCollectionRequest
        /// class.
        /// </summary>
        public CreateWorkspaceCollectionRequest() { }

        /// <summary>
        /// Initializes a new instance of the CreateWorkspaceCollectionRequest
        /// class.
        /// </summary>
        public CreateWorkspaceCollectionRequest(string location = default(string), IList<object> tags = default(IList<object>), AzureSku sku = default(AzureSku))
        {
            Location = location;
            Tags = tags;
            Sku = sku;
        }

        /// <summary>
        /// The Azure location
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IList<object> Tags { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public AzureSku Sku { get; set; }

    }
}
