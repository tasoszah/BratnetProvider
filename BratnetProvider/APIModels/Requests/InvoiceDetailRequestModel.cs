using Atom.Web;
using BratnetProvider.JsonConverters;
using Newtonsoft.Json;
using System.Reflection;

namespace BratnetProvider
{
    /// <summary>
    /// The response model for invoice details
    /// </summary>
    public class InvoiceDetailRequestModel : BaseRequestModel
    {
        #region Public Properties

        /// <summary>
        /// The name
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The code
        /// </summary>
        [JsonProperty("code")]
        public string? Code { get; set; }

        /// <summary>
        /// The line number
        /// </summary>
        [JsonProperty("lineNumber")]
        public int? LineNumber { get; set; }

        /// <summary>
        /// The quantity
        /// </summary>
        [JsonProperty("quantity")]
        public int? Quantity { get; set; }

        /// <summary>
        /// The measurement unit
        /// </summary>
        [JsonProperty("measurementUnit")]
        [JsonConverter(typeof(MeasurementUnitToIntJsonConverter))]
        public MeasurementUnit? MeasurementUnit { get; set; }

        /// <summary>
        /// The net value before discount
        /// </summary>
        [JsonProperty("netValueBeforeDiscount")]
        public decimal? NetValueBeforeDiscount { get; set; }

        /// <summary>
        /// The net value
        /// </summary>
        [JsonProperty("netValue")]
        public decimal? NetValue { get; set; }

        /// <summary>
        /// The vat amount
        /// </summary>
        [JsonProperty("vatAmount")]
        public decimal? VATAmount { get; set; }

        /// <summary>
        /// The vat category
        /// </summary>
        [JsonProperty("vatCategory")]
        [JsonConverter(typeof(VATCategoryToIntJsonConverter))]
        public VATCategory? VATCategory { get; set; }

        /// <summary>
        /// The expenses classification
        /// </summary>
        [JsonProperty("expensesClassification")]
        public IEnumerable<ExpenseClassificationRequestModel>? ExpensesClassification { get; set; }

        /// <summary>
        /// The price
        /// </summary>
        [JsonProperty("price")]
        public decimal? Price { get; set; }

        /// <summary>
        /// The measurement unit name
        /// </summary>
        [JsonProperty("measurementUnitName")]
        [JsonConverter(typeof(MeasurementUnitToStringJsonConverter))]
        public MeasurementUnit? MeasurementUnitName { get; set; }

        /// <summary>
        /// The VAT percentage
        /// </summary>
        [JsonProperty("vatPercent")]
        public int? VATPercent { get; set; }

        /// <summary>
        /// Needs to be CHECKED
        /// At the examples it is always 0
        /// </summary>
        [JsonProperty("priceIncludeVAT")]
        public decimal? PriceIncludeVAT { get; set; }

        /// <summary>
        /// The item description 
        /// </summary>
        /// <remarks>Only used at tax free invoices</remarks>
        [JsonProperty("itemDescr")]
        public string? ItemDescription { get; set; }

        /// <summary>
        /// The taric number
        /// </summary>
        /// <remarks>Only used at invoices that are movement invoices. 10digit only!</remarks>
        [JsonProperty("TaricNo")]
        public string? TaricNumber { get; set; }

        /// <summary>
        /// The item code
        /// </summary>
        [JsonProperty("itemCode")]
        public string? ItemCode { get; set; }

        /// <summary>
        /// The income classifications
        /// </summary>
        [JsonProperty("incomeClassification")]
        public IEnumerable<IncomeClassificationRequestModel>? IncomeClassifications { get; set; }

        /// <summary>
        /// A flag indicating if the item has a discount 
        /// </summary>
        [JsonProperty("discountOption")]
        public bool? DiscountOption { get; set; }

        /// <summary>
        /// The VAT exemption category
        /// </summary>
        [JsonProperty("vatExemptionCategory")]
        [JsonConverter(typeof(VATExemptionCategoryToIntJsonConverter))]
        public VATExemptionCategory? VATExemptionCategory { get; set; }

        /// <summary>
        /// The UBL VAT category
        /// </summary>
        [JsonProperty("ublVatCategory")]
        [JsonConverter(typeof(PEPPOLDutyOrTaxOrFeeCategoryCodeToStringJsonConverter))]
        public PEPPOLDutyOrTaxOrFeeCategoryCode? PEPPOLVATCategory { get; set; }

        /// <summary>
        /// The UBL measurement unit
        /// </summary>
        [JsonProperty("ublMeasurementUnit")]
        [JsonConverter(typeof(PEPPOLRecommendationCodeToStringJsonConverter))]
        public PEPPOLRecommendationCode? PEPPOLMeasurementUnit { get; set; }

        /// <summary>
        /// The UBL CPV code
        /// </summary>
        [JsonProperty("ublCpvCode")]
        public string? PEPPOLCpvCode { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public InvoiceDetailRequestModel() : base()
        {

        }

        #endregion
    }
}
