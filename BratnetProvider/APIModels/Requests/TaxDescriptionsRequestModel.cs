using Atom.Web;
using Newtonsoft.Json;

namespace BratnetProvider
{
    /// <summary>
    /// Represents a request model for tax descriptions.
    /// </summary>
    public class TaxDescriptionsRequestModel : BaseRequestModel
    {
        #region Public Properties

        /// <summary>
        /// The id of the tax description.
        /// </summary>
        [JsonProperty("lineId")]
        public int? LineId { get; set; }

        /// <summary>
        /// The description of the tax
        /// </summary>
        [JsonProperty("taxDescription")]
        public string? TaxDescription { get; set; }

        /// <summary>
        /// The amount of the tax
        /// </summary>
        [JsonProperty("taxAmount")]
        public decimal? taxAmount { get; set; }

        /// <summary>
        /// The VAT amount of the tax
        /// </summary>
        [JsonProperty("taxVatAmount")]
        public decimal? TaxVATAmount { get; set; }

        /// <summary>
        /// The VAT category of the tax 
        /// </summary>
        [JsonProperty("vatCategory")]
        [JsonConverter(typeof(VATCategoryToIntJsonConverter))]
        public VATCategory? VATCategory { get; set; }

        /// <summary>
        /// The tax type
        /// </summary>
        [JsonProperty("taxType")]
        [JsonConverter(typeof(TaxTypeToIntJsonConverter))]
        public TaxType? TaxType { get; set; }

        /// <summary>
        /// The tax VAT percentage
        /// </summary>
        [JsonProperty("taxVatPercent")]
        public int? TaxVATPercentage { get; set; }

        /// <summary>
        /// The tax category id
        /// </summary>
        [JsonProperty("taxCategoryId")]
        public int? TaxCategoryId { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public TaxDescriptionsRequestModel() : base()
        {

        }

        #endregion
    }
}
