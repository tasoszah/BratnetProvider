using Atom.Web;
using Newtonsoft.Json;

namespace BratnetProvider
{
    /// <summary>
    /// Represents a request model for creating signature for secure invoice submission.
    /// </summary>
    public class CreateSimSignatureRequestModel : BaseRequestModel
    {
        #region Public Properties

        /// <summary>
        /// System Id that is going to be used as AA
        /// </summary>
        [JsonProperty("externalSystemId")]
        public string? ExternalSystemId { get; set; }

        /// <summary>
        /// The issuer's VAT Number
        /// </summary>
        [JsonProperty("issuerVatNumber")]
        public string? IssuerVATNumber { get; set; }

        /// <summary>
        /// The date when the invoice was issued
        /// </summary>
        [JsonProperty("invoiceIssueDate")]
        [JsonConverter(typeof(DateOnlyToStringJsonConverter))]
        public DateOnly? InvoiceIssueDate { get; set; }

        /// <summary>
        /// The time when the invoice was issued
        /// </summary>
        [JsonProperty("invoiceIssueTime")]
        public TimeOnly? InvoiceIssueTime { get; set; }

        /// <summary>
        /// The type of the invoice
        /// </summary>
        [JsonProperty("invoiceType")]
        [JsonConverter(typeof(InvoiceTypeToStringJsonConverter))]
        public InvoiceType? InvoiceType { get; set; }

        /// <summary>
        /// The company's branch
        /// </summary>
        [JsonProperty("companyBranch")]
        public string? CompanyBranch { get; set; }

        /// <summary>
        /// The series of the invoice
        /// </summary>
        [JsonProperty("invoiceSeries")]
        public string? InvoiceSeries { get; set; }

        /// <summary>
        /// The net value of the item after any discounts have been applied
        /// </summary>
        [JsonProperty("netValue")]
        public decimal? NetValue { get; set; }

        /// <summary>
        /// The monetary value of the VAT calculated for a particular item, service, or transaction
        /// </summary>
        [JsonProperty("vatAmount")]
        public decimal? VATAmount { get; set; }

        /// <summary>
        /// The total monetary amount of the invoice, including the net value and any applicable taxes, fees, or other charges
        /// </summary>
        [JsonProperty("totalValue")]
        public decimal? TotalValue { get; set; }

        /// <summary>
        /// The total sum that has been or will be paid for the invoice
        /// </summary>
        [JsonProperty("paymentAmount")]
        public decimal? PaymentAmount { get; set; }

        /// <summary>
        /// The POS terminal Id
        /// </summary>
        [JsonProperty("terminalId")]
        public string? TerminalId { get; set; }

        /// <summary>
        /// The NSP code
        /// </summary>
        ///<example>1 - Mellon</example>
        ///<example>2 - Viva</example>
        [JsonProperty("nspCode")]
        public string? NSPCode { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public CreateSimSignatureRequestModel() : base()
        {

        }

        #endregion
    }
}
