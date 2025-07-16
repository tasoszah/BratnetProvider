using Atom.Web;
using Newtonsoft.Json;

namespace BratnetProvider
{
    /// <summary>
    /// Represents a request model for creating a signature for not simultaneous transactions.
    /// </summary>
    public class CreateSignatureRequestModel : BaseRequestModel
    {
        #region Public Properties

        /// <summary>
        /// A hash or unique string used to identify an object, user, or data item in a system
        /// </summary>
        [JsonProperty("uid")]
        public string? UId { get; set; }

        /// <summary>
        /// Ensures that each transaction is distinct and traceable, allowing for proper tracking, 
        /// auditing, and reconciliation in systems that handle invoicing or financial processes
        /// </summary>
        [JsonProperty("tidNsp")]
        public string? TIdNSP { get; set; }

        /// <summary>
        /// Represents a monetary value in a transaction or payment system
        /// </summary>
        [JsonProperty("payAmount")]
        public decimal? PayAmount { get; set; }

        /// <summary>
        /// The NSP code
        /// </summary>
        ///<example>1 - Mellon</example>
        ///<example>2 - Viva</example>
        [JsonProperty("nspCode")]
        public string? NSPCode { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public CreateSignatureRequestModel() : base()
        {

        }

        #endregion
    }
}
