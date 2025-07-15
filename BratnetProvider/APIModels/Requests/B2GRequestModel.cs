using Atom.Web;
using Newtonsoft.Json;

namespace BratnetProvider
{
    /// <summary>
    /// Represents a request model for B2G transactions.
    /// </summary>
    public class B2GRequestModel : BaseRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Unique government entity identifier
        /// </summary>
        /// <example>1053.2020000000.0001</example>
        [JsonProperty("accountingCustomerPartyId")]
        public string? AccountingCustomerPartyId { get; set; }

        /// <summary>
        /// The reference to the contract or agreement related to this invoice
        /// </summary>
        /// <example>20SYMV006467658</example>
        [JsonProperty("contractDocumentId")]
        public string? ContractDocumentId { get; set; }

        /// <summary>
        /// Project information under which the invoice is submitted
        /// </summary>
        [JsonProperty("projectReference")]
        public B2GProjectReferenceRequestModel? ProjectReference { get; set; }

        /// <summary>
        /// Identifies the buyer’s internal organizational unit
        /// </summary>
        [JsonProperty("buyerReference")]
        public B2GBuyerReferenceRequestModel? BuyerReference { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public B2GRequestModel() : base()
        {

        }

        #endregion
    }
}
