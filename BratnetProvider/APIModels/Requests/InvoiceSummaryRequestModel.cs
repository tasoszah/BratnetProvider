using Atom.Web;
using Newtonsoft.Json;

namespace BratnetProvider
{
    /// <summary>
    /// Represents a request model for an invoice summary
    /// </summary>
    public class InvoiceSummaryRequestModel : BaseRequestModel
    {
        #region Public Properties

        /// <summary>
        /// The total net value of the invoice before VAT and other additional charges or deductions
        /// </summary>
        [JsonProperty("totalNetValue")]
        public decimal? TotalNetValue { get; set; }

        /// <summary>
        /// The total vat amount
        /// </summary>
        [JsonProperty("totalVatAmount")]
        public decimal? TotalVATAmount { get; set; }

        /// <summary>
        /// The total amount of any withheld taxes or amounts that have been deducted from the invoice value
        /// </summary>
        [JsonProperty("totalWithheldAmount")]
        public decimal? TotalWithheldAmount { get; set; }

        /// <summary>
        /// The total fees amount
        /// </summary>
        [JsonProperty("totalFeesAmount")]
        public decimal? TotalFeesAmount { get; set; }

        /// <summary>
        /// The total stamp duty amount
        /// </summary>
        [JsonProperty("totalStampDutyAmount")]
        public decimal? TotalStampDutyAmount { get; set; }

        /// <summary>
        /// The total amount of any other taxes applied to the invoice that are not VAT or standard sales taxes.
        /// </summary>
        [JsonProperty("totalOtherTaxesAmount")]
        public decimal? TotalOtherTaxesAmount { get; set; }

        /// <summary>
        /// The total deductions amount
        /// </summary>
        [JsonProperty("totalDeductionsAmount")]
        public decimal? TotalDeductionsAmount { get; set; }

        /// <summary>
        /// The total gross value of the invoice, including net value, VAT, fees, and any other applicable charges or taxes
        /// </summary>
        [JsonProperty("totalGrossValue")]
        public decimal? TotalGrossValue { get; set; }

        /// <summary>
        /// The gross value to be printed on the invoice
        /// </summary>
        [JsonProperty("totalPrintGrossValue")]
        public decimal? TotalPrintGrossValue { get; set; }

        /// <summary>
        /// The classification of the expenses
        /// </summary>
        [JsonProperty("expensesClassification")]
        public IEnumerable<ExpenseClassificationRequestModel>? ExpensesClassification { get; set; }

        /// <summary>
        /// The classification of the income
        /// </summary>
        [JsonProperty("incomeClassification")]
        public IEnumerable<IncomeClassificationRequestModel>? IncomeClassification { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public InvoiceSummaryRequestModel() : base()
        {

        }

        #endregion
    }
}
