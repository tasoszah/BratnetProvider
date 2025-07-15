using Atom.Web;
using Newtonsoft.Json;

namespace BratnetProvider
{
    /// <summary>
    /// Represents a request model for taxes
    /// </summary>
    public class TaxesRequestModel : BaseRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Represents a collection of tax request models 
        /// </summary>
        [JsonProperty("taxes")]
        public IEnumerable<TaxRequestModel>? Taxes { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public TaxesRequestModel() : base()
        {

        }

        #endregion
    }
}
