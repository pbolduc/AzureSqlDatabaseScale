// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Sql.Models
{
    using System.Linq;

    /// <summary>
    /// Represents an Azure SQL server firewall rule.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class ServerFirewallRule : SqlSubResource
    {
        /// <summary>
        /// Initializes a new instance of the ServerFirewallRule class.
        /// </summary>
        public ServerFirewallRule() { }

        /// <summary>
        /// Initializes a new instance of the ServerFirewallRule class.
        /// </summary>
        /// <param name="name">Resource name</param>
        /// <param name="id">The resource ID.</param>
        /// <param name="kind">Kind of server that contains this firewall
        /// rule.</param>
        /// <param name="location">Location of the server that contains this
        /// firewall rule.</param>
        /// <param name="startIpAddress">The start IP address of the Azure SQL
        /// server firewall rule. Must be IPv4 format.</param>
        /// <param name="endIpAddress">The end IP address of the Azure SQL
        /// server firewall rule. Must be IPv4 format.</param>
        public ServerFirewallRule(string name = default(string), string id = default(string), string kind = default(string), string location = default(string), string startIpAddress = default(string), string endIpAddress = default(string))
            : base(name, id)
        {
            Kind = kind;
            Location = location;
            StartIpAddress = startIpAddress;
            EndIpAddress = endIpAddress;
        }

        /// <summary>
        /// Gets kind of server that contains this firewall rule.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "kind")]
        public string Kind { get; private set; }

        /// <summary>
        /// Gets location of the server that contains this firewall rule.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "location")]
        public string Location { get; private set; }

        /// <summary>
        /// Gets or sets the start IP address of the Azure SQL server firewall
        /// rule. Must be IPv4 format.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.startIpAddress")]
        public string StartIpAddress { get; set; }

        /// <summary>
        /// Gets or sets the end IP address of the Azure SQL server firewall
        /// rule. Must be IPv4 format.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.endIpAddress")]
        public string EndIpAddress { get; set; }

    }
}
