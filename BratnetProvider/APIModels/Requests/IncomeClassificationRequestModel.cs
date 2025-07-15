using Atom.Web;
using Newtonsoft.Json;

namespace BratnetProvider
{
    /// <summary>
    /// Represents a request model for an income classification
    /// </summary>
    public class IncomeClassificationRequestModel : BaseRequestModel
    {
        #region Public Properties

        /// <summary>
        /// The category
        /// </summary>
        [JsonProperty("classificationCategory")]
        public IncomeClassificationCategory? Category { get; set; }

        /// <summary>
        /// The type
        /// </summary>
        [JsonProperty("classificationType")]
        public IncomeClassificationType? Type { get; set; }

        /// <summary>
        /// The amount
        /// </summary>
        [JsonProperty("amount")]
        public decimal? Amount { get; set; }

        /// <summary>
        /// The Id
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public IncomeClassificationRequestModel() : base()
        {

        }

        #endregion
    }
}
