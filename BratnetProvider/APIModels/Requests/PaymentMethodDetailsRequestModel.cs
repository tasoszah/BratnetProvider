using Atom.Web;
using Newtonsoft.Json;

namespace BratnetProvider
{
    /// <summary>
    /// Represents a request model for payment methods
    /// </summary>
    public class PaymentMethodDetailsRequestModel : BaseRequestModel
    {
        #region Public Properties

        /// <summary>
        /// The list of payment methods details
        /// </summary>
        [JsonProperty("paymentMethodDetails")]
        public IEnumerable<PaymentMethodDetailRequestModel>? PaymentMethodDetails { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PaymentMethodDetailsRequestModel() : base()
        {

        }

        #endregion
    }
}
