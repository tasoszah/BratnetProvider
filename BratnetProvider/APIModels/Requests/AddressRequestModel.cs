using Atom.Web;
using Newtonsoft.Json;

namespace BratnetProvider
{
    /// <summary>
    /// Represent an address request model
    /// </summary>
    public class AddressRequestModel : BaseRequestModel
    {
        #region Public Properties

        /// <summary>
        /// The street name
        /// </summary>
        [JsonProperty("street")]
        public string? StreetName { get; set; }

        /// <summary>
        /// The street number
        /// </summary>
        [JsonProperty("number")]
        public string? StreetNumber { get; set; }

        /// <summary>
        /// The postal code
        /// </summary>
        [JsonProperty("postalCode")]
        public string? PostalCode { get; set; }

        /// <summary>
        /// The city
        /// </summary>
        [JsonProperty("city")]
        public string? City { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public AddressRequestModel() : base()
        {
            

        }

        #endregion

    }
}
