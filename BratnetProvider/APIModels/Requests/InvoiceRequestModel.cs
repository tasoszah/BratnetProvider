using Atom.Web;
using Newtonsoft.Json;

namespace BratnetProvider
{
    /// <summary>
    /// Represents a request model for an invoice 
    /// </summary>
    public class InvoiceRequestModel : BaseRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Indicates whether the invoice has been digitally or physically signed
        /// </summary>
        [JsonProperty("isUnsigned")]
        public bool? IsUnsigned { get; set; }

        /// <summary>
        /// Transmission failure code, if applicable
        /// </summary>
        [JsonProperty("transmissionFailure")]
        public int? TransmissionFailure { get; set; }

        /// <summary>
        /// The Terminal Id (tidNsp) ensures that each transaction is distinct and traceable, allowing for proper tracking,
        /// auditing, and reconciliation in systems that handle invoicing or financial processes
        /// </summary>
        [JsonProperty("tidNsp")]
        public string? TidNsp { get; set; }

        /// <summary>
        /// Details about the entity issuing the invoice, such as VAT number, branch, address, and supply account number
        /// </summary>
        [JsonProperty("issuer")]
        public IssuerRequestModel? Issuer { get; set; }

        /// <summary>
        /// Information about the recipient of the invoice, including name, VAT number, address, and associated details
        /// </summary>
        [JsonProperty("counterpart")]
        public IssuerRequestModel? CounterPart { get; set; }

        /// <summary>
        /// The invoice header serves as the introductory information that describes the invoice's characteristics,
        /// including identification, issuance details, payment terms, and any relevant shipping or delivery data.
        /// </summary>
        [JsonProperty("invoiceHeader")]
        public InvoiceHeaderRequestModel? InvoiceHeader { get; set; }

        /// <summary>
        /// Specifies how the invoice amount will be paid, with details like payment type, amount, and additional information
        /// </summary>
        [JsonProperty("paymentMethods")]
        public PaymentMethodDetailsRequestModel? PaymentMethods { get; set; }

        /// <summary>
        /// Contains detailed information about the items or services being invoiced
        /// </summary>
        [JsonProperty("invoiceDetails")]
        public IEnumerable<InvoiceDetailRequestModel>? InvoiceDetails { get; set; }

        /// <summary>
        /// Provides a high-level overview of the total values for the invoice, summarizing the key financial
        /// figures such as the total net value, taxes, deductions, and other charges
        /// </summary>
        [JsonProperty("invoiceSummary")]
        public InvoiceSummaryRequestModel? InvoiceSummary { get; set; }

        /// <summary>
        /// The invoice VAT analysis
        /// </summary>
        [JsonProperty("invoiceVatAnalysis")]
        public InvoiceVATAnalysisRequestModel? InvoiceVatAnalysis { get; set; }

        /// <summary>
        /// Contains additional optional fields that provide supplementary information not directly related 
        /// to the core invoice details but may be necessary for specific business requirements or regulatory compliance
        /// </summary>
        [JsonProperty("extra")]
        public ExtrasRequestModel? Extras { get; set; }

        /// <summary>
        /// The UBL fields section provides UBL-compliant addressing and entity identification for public sector invoices
        /// </summary>
        [JsonProperty("ublFields")]
        public PEPPOLFieldsRequestModel? PEPPOLFields { get; set; }

        /// <summary>
        /// Includes essential metadata for government invoicing such as project references and contract details
        /// </summary>
        [JsonProperty("b2g")]
        public B2GRequestModel? B2G { get; set; }

        /// <summary>
        /// The taxes total
        /// </summary>
        [JsonProperty("taxesTotals")]
        public TaxesRequestModel? Taxes { get; set; }

        /// <summary>
        /// The taxes descriptions
        /// </summary>
        [JsonProperty("taxesDescriptions")]
        public IEnumerable<TaxesDescriptionsRequestModel>? TaxesDescriptions { get; set; }


        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public InvoiceRequestModel() : base()
        {

        }

        #endregion
    }
}
