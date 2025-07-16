using Atom.Web;
using Newtonsoft.Json;

namespace BratnetProvider
{
    /// <summary>
    /// Represents a request model for B2G project references. Project information under which the invoice is submitted
    /// </summary>
    public class B2GProjectReferenceRequestModel : BaseRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Type code of the project 
        /// </summary>
        [JsonProperty("type")]
        [JsonConverter(typeof(BudgetTypeToIntJsonConverter))]
        public BudgetType? Type { get; set; }

        /// <summary>
        /// ID of the project or funding reference
        /// </summary>
        /// <example>6ΗΓ5Ω6Μ-Λ14</example>
        [JsonProperty("id")]
        public string? Id { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public B2GProjectReferenceRequestModel() : base()
        {

        }

        #endregion
    }
}
