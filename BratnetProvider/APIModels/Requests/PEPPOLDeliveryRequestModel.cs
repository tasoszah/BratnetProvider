using Newtonsoft.Json;

namespace BratnetProvider
{
    /// <summary>
    /// Represents a request model for UBL delivery information.
    /// </summary>
    public class PEPPOLDeliveryRequestModel
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
        public PEPPOLDeliveryRequestModel() : base()
        {

        }

        #endregion
    }
}
