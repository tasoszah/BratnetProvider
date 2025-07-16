using Atom.Web;
using Newtonsoft.Json;

namespace BratnetProvider
{
    /// <summary>
    /// Represents a single tax 
    /// </summary>
    public class TaxRequestModel : BaseRequestModel
    {
        #region Public Properties 

        /// <summary>
        /// The tax type
        /// </summary>
        [JsonProperty("taxType")]
        [JsonConverter(typeof(TaxTypeToIntJsonConverter))]
        public TaxType? Type { get; set; }

        /// <summary>
        /// The tax category
        /// </summary>
        [JsonProperty("taxCategory")]
        public int? TaxCategory { get; set; }

        /// <summary>
        /// The underlying value
        /// </summary>
        [JsonProperty("underlyingValue")]
        public decimal? UnderlyingValue { get; set; }

        /// <summary>
        /// The tax amount
        /// </summary>
        [JsonProperty("taxAmount")]
        public decimal? TaxAmount { get; set; }

        /// <summary>
        /// The id
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Withholding percentage
        /// ONLY for B2G
        /// </summary>
        /// <example> 20 for 20%</example>
        [JsonProperty("ublMultiplierFactor")]
        public decimal? PEPPOLMultiplierFactor { get; set; }

        /// <summary>
        /// Tax category code
        /// ONLY for B2G
        /// </summary>
        [JsonProperty("ublTaxCategory")]
        [JsonConverter(typeof(PEPPOLAllowanceReasonCodeToStringJsonConverter))]
        public PEPPOLAllowanceReasonCode? PEPPOLTaxCategory { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public TaxRequestModel() : base()
        {

        }

        #endregion
    }
}
