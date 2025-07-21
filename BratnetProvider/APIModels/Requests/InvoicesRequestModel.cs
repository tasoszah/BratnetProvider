using Atom.Web;
using Newtonsoft.Json;

namespace BratnetProvider
{
    /// <summary>
    /// Request model used for transmitting multiple invoices
    /// </summary>
    public class InvoicesRequestModel : BaseRequestModel
    {
        #region Public Properties

        /// <summary>
        /// The invoices
        /// </summary>
        [JsonProperty("invoice")]
        public IEnumerable<InvoiceRequestModel>? Invoices { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public InvoicesRequestModel() : base()
        {

        }

        #endregion
    }
}
