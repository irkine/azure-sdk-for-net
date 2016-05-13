
namespace Microsoft.Azure.Management.PowerBIEmbedded.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    public partial class WorkspaceCollectionList
    {
        /// <summary>
        /// Initializes a new instance of the WorkspaceCollectionList class.
        /// </summary>
        public WorkspaceCollectionList() { }

        /// <summary>
        /// Initializes a new instance of the WorkspaceCollectionList class.
        /// </summary>
        public WorkspaceCollectionList(IList<WorkspaceCollection> value = default(IList<WorkspaceCollection>))
        {
            Value = value;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<WorkspaceCollection> Value { get; set; }

    }
}
