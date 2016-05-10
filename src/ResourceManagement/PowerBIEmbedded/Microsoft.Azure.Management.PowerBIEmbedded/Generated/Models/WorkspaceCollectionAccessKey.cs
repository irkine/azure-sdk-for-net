
namespace Microsoft.Azure.Management.PowerBIEmbedded.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    public partial class WorkspaceCollectionAccessKey
    {
        /// <summary>
        /// Initializes a new instance of the WorkspaceCollectionAccessKey
        /// class.
        /// </summary>
        public WorkspaceCollectionAccessKey() { }

        /// <summary>
        /// Initializes a new instance of the WorkspaceCollectionAccessKey
        /// class.
        /// </summary>
        public WorkspaceCollectionAccessKey(string keyName = default(string))
        {
            KeyName = keyName;
        }

        /// <summary>
        /// The key name
        /// </summary>
        [JsonProperty(PropertyName = "keyName")]
        public string KeyName { get; set; }

    }
}
