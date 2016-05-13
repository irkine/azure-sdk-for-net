
namespace Microsoft.Azure.Management.PowerBIEmbedded.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    public partial class AzureSku
    {
        /// <summary>
        /// Initializes a new instance of the AzureSku class.
        /// </summary>
        public AzureSku() { }

        /// <summary>
        /// Initializes a new instance of the AzureSku class.
        /// </summary>
        public AzureSku(string name = default(string), string tier = default(string))
        {
            Name = name;
            Tier = tier;
        }

        /// <summary>
        /// SKU name. Possible values include: 'S1'
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// SKU tier. Possible values include: 'Standard'
        /// </summary>
        [JsonProperty(PropertyName = "tier")]
        public string Tier { get; set; }

    }
}
