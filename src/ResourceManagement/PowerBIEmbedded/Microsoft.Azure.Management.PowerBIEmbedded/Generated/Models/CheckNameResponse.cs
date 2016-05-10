
namespace Microsoft.Azure.Management.PowerBIEmbedded.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    public partial class CheckNameResponse
    {
        /// <summary>
        /// Initializes a new instance of the CheckNameResponse class.
        /// </summary>
        public CheckNameResponse() { }

        /// <summary>
        /// Initializes a new instance of the CheckNameResponse class.
        /// </summary>
        public CheckNameResponse(bool? nameAvailable = default(bool?), string reason = default(string), string message = default(string))
        {
            NameAvailable = nameAvailable;
            Reason = reason;
            Message = message;
        }

        /// <summary>
        /// Specifies a Boolean value that indicates whether the specified
        /// Power BI Workspace Collection name is available to use.
        /// </summary>
        [JsonProperty(PropertyName = "nameAvailable")]
        public bool? NameAvailable { get; set; }

        /// <summary>
        /// Specifies the reason that a Power BI Workspace Collection name
        /// cannot be used. Property is not set if the specified name is
        /// available.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string Reason { get; set; }

        /// <summary>
        /// Indicates why the specified name is unavailable.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

    }
}
