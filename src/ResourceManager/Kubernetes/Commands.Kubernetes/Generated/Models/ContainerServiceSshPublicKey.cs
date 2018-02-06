// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Commands.Kubernetes.Generated.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Contains information about SSH certificate public key data.
    /// </summary>
    public partial class ContainerServiceSshPublicKey
    {
        /// <summary>
        /// Initializes a new instance of the ContainerServiceSshPublicKey
        /// class.
        /// </summary>
        public ContainerServiceSshPublicKey()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ContainerServiceSshPublicKey
        /// class.
        /// </summary>
        /// <param name="keyData">Certificate public key used to authenticate
        /// with VMs through SSH. The certificate must be in PEM format with or
        /// without headers.</param>
        public ContainerServiceSshPublicKey(string keyData)
        {
            KeyData = keyData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets certificate public key used to authenticate with VMs
        /// through SSH. The certificate must be in PEM format with or without
        /// headers.
        /// </summary>
        [JsonProperty(PropertyName = "keyData")]
        public string KeyData { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (KeyData == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "KeyData");
            }
        }
    }
}
