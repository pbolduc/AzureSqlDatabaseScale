// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Sql.Models
{
    using System.Linq;

    /// <summary>
    /// Represents an Azure SQL Database Transparent Data Encryption .
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class TransparentDataEncryption : SqlSubResource
    {
        /// <summary>
        /// Initializes a new instance of the TransparentDataEncryption class.
        /// </summary>
        public TransparentDataEncryption() { }

        /// <summary>
        /// Initializes a new instance of the TransparentDataEncryption class.
        /// </summary>
        /// <param name="name">Resource name</param>
        /// <param name="id">The resource ID.</param>
        /// <param name="status">The status of the Azure SQL Database
        /// Transparent Data Encryption. Possible values include: 'Enabled',
        /// 'Disabled'</param>
        public TransparentDataEncryption(string name = default(string), string id = default(string), TransparentDataEncryptionStates? status = default(TransparentDataEncryptionStates?))
            : base(name, id)
        {
            Status = status;
        }

        /// <summary>
        /// Gets or sets the status of the Azure SQL Database Transparent Data
        /// Encryption. Possible values include: 'Enabled', 'Disabled'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.status")]
        public TransparentDataEncryptionStates? Status { get; set; }

    }
}
