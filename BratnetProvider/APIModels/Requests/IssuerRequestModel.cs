using Atom;
using Newtonsoft.Json;

namespace BratnetProvider
{
    /// <summary>
    /// Represent an issuer request model
    /// </summary>
    public class IssuerRequestModel
    {
        #region Public Properties

        /// <summary>
        /// The VAT Number
        /// </summary>
        [JsonProperty("vatNumber")]
        public string? VATNumber { get; set; }

        /// <summary>
        /// The country code
        /// </summary>
        [JsonProperty("country")]
        [JsonConverter(typeof(CountryCodeToStringJsonConverter))]
        public CountryCode? Country { get; set; }

        /// <summary>
        /// The branch
        /// </summary>
        [JsonProperty("branch")]
        public int Branch { get; set; }

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
        public IssuerRequestModel() : base()
        {

        }

        #endregion
    }
}
