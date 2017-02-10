// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using System.Linq;

    /// <summary>
    /// Single sign-on request information for domain management.
    /// </summary>
    public partial class DomainControlCenterSsoRequest
    {
        /// <summary>
        /// Initializes a new instance of the DomainControlCenterSsoRequest
        /// class.
        /// </summary>
        public DomainControlCenterSsoRequest() { }

        /// <summary>
        /// Initializes a new instance of the DomainControlCenterSsoRequest
        /// class.
        /// </summary>
        /// <param name="url">URL where the single sign-on request is to be
        /// made.</param>
        /// <param name="postParameterKey">Post parameter key.</param>
        /// <param name="postParameterValue">Post parameter value. Client
        /// should use 'application/x-www-form-urlencoded' encoding for this
        /// value.</param>
        public DomainControlCenterSsoRequest(string url = default(string), string postParameterKey = default(string), string postParameterValue = default(string))
        {
            Url = url;
            PostParameterKey = postParameterKey;
            PostParameterValue = postParameterValue;
        }

        /// <summary>
        /// Gets URL where the single sign-on request is to be made.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "url")]
        public string Url { get; private set; }

        /// <summary>
        /// Gets post parameter key.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "postParameterKey")]
        public string PostParameterKey { get; private set; }

        /// <summary>
        /// Gets post parameter value. Client should use
        /// 'application/x-www-form-urlencoded' encoding for this value.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "postParameterValue")]
        public string PostParameterValue { get; private set; }

    }
}