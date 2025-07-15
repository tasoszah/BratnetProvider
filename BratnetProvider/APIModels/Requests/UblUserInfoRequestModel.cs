using Atom.Web;
using Newtonsoft.Json;

namespace BratnetProvider
{
    /// <summary>
    /// Represents a request model for UBL issuer/counterpart information.
    /// </summary>
    public class UblUserInfoRequestModel : BaseRequestModel
    {
        #region Public Properties

        /// <summary>
        /// The name
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The address 
        /// </summary>
        [JsonProperty("address")]
        public AddressRequestModel? Address { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public UblUserInfoRequestModel() : base()
        {

        }

        #endregion
    }
}
