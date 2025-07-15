using Newtonsoft.Json;

namespace BratnetProvider
{
    /// <summary>
    /// Represents a request model for UBL delivery information.
    /// </summary>
    public class UblDeliveryRequestModel
    {
        #region Public Properties

        /// <summary>
        /// The delivery address
        /// </summary>
        [JsonProperty("address")]
        public AddressRequestModel? Address { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public UblDeliveryRequestModel() : base()
        {

        }

        #endregion
    }
}
