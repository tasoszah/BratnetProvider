using Newtonsoft.Json;

namespace BratnetProvider
{
    /// <summary>
    /// Represents a request model for invoice VAT analysis.
    /// </summary>
    public class InvoiceVatAnalysisRequestModel
    {
        #region Public Properties

        /// <summary>
        /// The Vat category
        /// </summary>
        [JsonProperty("vatCategory")]
        [JsonConverter(typeof(VATCategoryToIntJsonConverter))]
        public VATCategory? VatCategory { get; set; }

        /// <summary>
        /// The VAT percentage
        /// </summary>
        [JsonProperty("vatPercent")]
        public int? VatPercentage { get; set; }

        /// <summary>
        /// The net value per VAT category
        /// </summary>
        [JsonProperty("netValuePerVat")]
        public decimal? NetValuePerVat { get; set; }

        /// <summary>
        /// The VAT amount per VAT category
        /// </summary>
        [JsonProperty("vatAmount")]
        public decimal? VatAmount { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public InvoiceVatAnalysisRequestModel() : base()
        {

        }

        #endregion
    }
}
