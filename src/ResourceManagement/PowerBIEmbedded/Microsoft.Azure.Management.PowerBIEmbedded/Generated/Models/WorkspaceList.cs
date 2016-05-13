
namespace Microsoft.Azure.Management.PowerBIEmbedded.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    public partial class WorkspaceList
    {
        /// <summary>
        /// Initializes a new instance of the WorkspaceList class.
        /// </summary>
        public WorkspaceList() { }

        /// <summary>
        /// Initializes a new instance of the WorkspaceList class.
        /// </summary>
        public WorkspaceList(IList<Workspace> value = default(IList<Workspace>))
        {
            Value = value;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<Workspace> Value { get; set; }

    }
}
