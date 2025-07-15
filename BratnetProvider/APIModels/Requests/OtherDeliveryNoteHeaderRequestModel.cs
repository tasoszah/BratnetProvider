using Atom.Web;
using Newtonsoft.Json;

namespace BratnetProvider
{
    /// <summary>
    /// Represents a request model for other delivery note header information
    /// </summary>
    public class OtherDeliveryNoteHeaderRequestModel : BaseRequestModel
    {
        #region Public Properties

        /// <summary>
        /// The loading address
        /// </summary>
        [JsonProperty("loadingAddress")]
        public AddressRequestModel? LoadingAddress { get; set; }

        /// <summary>
        /// The delivery address
        /// </summary>
        [JsonProperty("deliveryAddress")]
        public AddressRequestModel? DeliveryAddress { get; set; }

        /// <summary>
        /// The start shipping branch
        /// </summary>
        [JsonProperty("startShippingBranch")]
        public int? StartShippingBranch { get; set; }

        /// <summary>
        /// The complete shipping branch
        /// </summary>
        [JsonProperty("completeShippingBranch")]
        public int? CompleteShippingBranch { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public OtherDeliveryNoteHeaderRequestModel() : base()
        {

        }

        #endregion
    }
}
