
namespace Microsoft.Azure.Management.PowerBIEmbedded.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    public partial class UpdateWorkspaceCollectionRequest
    {
        /// <summary>
        /// Initializes a new instance of the UpdateWorkspaceCollectionRequest
        /// class.
        /// </summary>
        public UpdateWorkspaceCollectionRequest() { }

        /// <summary>
        /// Initializes a new instance of the UpdateWorkspaceCollectionRequest
        /// class.
        /// </summary>
        public UpdateWorkspaceCollectionRequest(IList<object> tags = default(IList<object>), AzureSku sku = default(AzureSku))
        {
            Tags = tags;
            Sku = sku;
        }

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
