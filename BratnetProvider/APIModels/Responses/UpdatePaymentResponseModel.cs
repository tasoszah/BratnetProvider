using Newtonsoft.Json;

namespace BratnetProvider
{
    /// <summary>
    /// Represents the response model for updating a payment.
    /// </summary>
    public class UpdatePaymentResponseModel
    {
        #region Public Properties

        /// <summary>
        /// The invoice MARK 
        /// </summary>
        [JsonProperty("invoiceMark")]
        public long InvoiceMARK { get; set; }

        /// <summary>
        /// The payment MARK
        /// </summary>
        [JsonProperty("paymentMethodMark")]
        public long PaymentMethodMARK { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public UpdatePaymentResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString() => "MARK: " + InvoiceMARK;

        #endregion
    }
}
