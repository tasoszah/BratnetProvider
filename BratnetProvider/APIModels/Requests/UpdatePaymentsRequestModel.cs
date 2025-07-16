using Atom.Web;
using Newtonsoft.Json;

namespace BratnetProvider
{
    /// <summary>
    /// Represents a request model for updating a POS payment
    /// </summary>
    public class UpdatePaymentsRequestModel : BaseRequestModel
    {
        #region Public Properties

        /// <summary>
        /// A hash or unique string used to identify an object, user, or data item in a system
        /// </summary>
        [JsonProperty("uid")]
        public string? UId { get; set; }

        /// <summary>
        /// A unique identifier for the transaction associated with the invoice
        /// </summary>
        [JsonProperty("transactionId")]
        public string? TransactionId { get; set; }

        /// <summary>
        /// A digital signature in hexadecimal format. This particular signature could be associated with a 
        /// transaction, document, or data payload in a blockchain or secure communication context
        /// </summary>
        [JsonProperty("hSignature")]
        public string? HSignature { get; set; }

        /// <summary>
        /// Represents a monetary value designated as a tip
        /// </summary>
        [JsonProperty("tipAmount")]
        public decimal? TipAmount { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public UpdatePaymentsRequestModel() : base()
        {

        }

        #endregion
    }
}
