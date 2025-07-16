using Newtonsoft.Json;

namespace BratnetProvider
{
    /// <summary>
    /// Represents a request model for invoice VAT analysis.
    /// </summary>
    public class InvoiceVATAnalysisRequestModel
    {
        #region Public Properties

        /// <summary>
        /// The VAT category
        /// </summary>
        [JsonProperty("vatCategory")]
        [JsonConverter(typeof(VATCategoryToIntJsonConverter))]
        public VATCategory? VATCategory { get; set; }

        /// <summary>
        /// The VAT percentage
        /// </summary>
        [JsonProperty("vatPercent")]
        public int? VATPercentage { get; set; }

        /// <summary>
        /// The net value per VAT category
        /// </summary>
        [JsonProperty("netValuePerVat")]
        public decimal? NetValuePerVAT { get; set; }

        /// <summary>
        /// The VAT amount per VAT category
        /// </summary>
        [JsonProperty("vatAmount")]
        public decimal? VATAmount { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public InvoiceVATAnalysisRequestModel() : base()
        {

        }

        #endregion
    }
}
