using Atom.Web;
using Newtonsoft.Json;

namespace BratnetProvider
{
    /// <summary>
    /// Represents a response model for a payment method
    /// </summary>
    public class PaymentMethodDetailRequestModel : BaseRequestModel
    {
        #region Public Properties

        /// <summary>
        /// The payment method type
        /// </summary>
        [JsonProperty("type")]
        [JsonConverter(typeof(PaymentTypeToIntConverter))]
        public PaymentType? PaymentType { get; set; }

        /// <summary>
        /// The amount
        /// </summary>
        [JsonProperty("amount")]
        public decimal? Amount { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PaymentMethodDetailRequestModel() : base()
        {

        }

        #endregion
    }
}
