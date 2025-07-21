using Atom.Web;
using Newtonsoft.Json;

namespace BratnetProvider
{
    /// <summary>
    /// Represents a request model for an expense classification
    /// </summary>
    public class ExpenseClassificationRequestModel : BaseRequestModel
    {
        #region Public Properties

        /// <summary>
        /// The type of expense classification
        /// </summary>
        [JsonProperty("classificationType")]
        public ExpenseClassificationType? Type { get; set; }

        /// <summary>
        /// The category of expense classification
        /// </summary>
        [JsonProperty("classificationCategory")]
        public ExpenseClassificationCategory? Category { get; set; }

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
        public ExpenseClassificationRequestModel() : base()
        {

        }

        #endregion

    }
}
