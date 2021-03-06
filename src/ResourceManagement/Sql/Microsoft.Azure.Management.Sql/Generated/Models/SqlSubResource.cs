// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Sql.Models
{
    using System.Linq;

    /// <summary>
    /// Subresource properties
    /// </summary>
    public partial class SqlSubResource
    {
        /// <summary>
        /// Initializes a new instance of the SqlSubResource class.
        /// </summary>
        public SqlSubResource() { }

        /// <summary>
        /// Initializes a new instance of the SqlSubResource class.
        /// </summary>
        /// <param name="name">Resource name</param>
        /// <param name="id">The resource ID.</param>
        public SqlSubResource(string name = default(string), string id = default(string))
        {
            Name = name;
            Id = id;
        }

        /// <summary>
        /// Gets resource name
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the resource ID.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

    }
}
