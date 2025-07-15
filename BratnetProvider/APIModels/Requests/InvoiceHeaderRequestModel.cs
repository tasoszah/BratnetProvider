using Atom;
using Atom.Web;
using Newtonsoft.Json;

namespace BratnetProvider
{
    /// <summary>
    /// Represents a request model for invoice header information
    /// </summary>
    public class InvoiceHeaderRequestModel : BaseRequestModel
    {
        #region Public Properties

        /// <summary>
        /// The series
        /// </summary>
        [JsonProperty("series")]
        public string? Series { get; set; }

        /// <summary>
        /// The number
        /// </summary>
        [JsonProperty("aa")]
        public string? AA { get; set; }

        /// <summary>
        /// The issue date
        /// </summary>
        [JsonProperty("issueDate")]
        public DateOnly? IssueDate { get; set; }

        /// <summary>
        /// The issue time
        /// </summary>
        [JsonProperty("issueTime")]
        public TimeOnly? IssueTime { get; set; }

        /// <summary>
        /// The invoice type
        /// </summary>
        [JsonProperty("invoiceType")]
        [JsonConverter(typeof(InvoiceTypeToStringJsonConverter))]
        public InvoiceType? InvoiceType { get; set; }

        /// <summary>
        /// The currency code
        /// </summary>
        [JsonProperty("currency")]
        public CurrencyCode? Currency { get; set; }

        /// <summary>
        /// The move purpose
        /// </summary>
        [JsonProperty("movePurpose")]
        [JsonConverter(typeof(MovePurposeToIntJsonConverter))]
        public MovePurpose? MovePurpose { get; set; }

        /// <summary>
        /// A flag indicating if the invoice has vat payment suspension
        /// </summary>
        [JsonProperty("vatPaymentSuspension")]
        public bool? VatPaymentSuspension { get; set; }

        /// <summary>
        /// The dispatch date
        /// </summary>
        [JsonProperty("dispatchDate")]
        public DateOnly? DispatchDate { get; set; }

        /// <summary>
        /// The dispatch time
        /// </summary>
        [JsonProperty("dispatchTime")]
        public TimeOnly? Dispatchtime { get; set; }

        /// <summary>
        /// The vehicle number
        /// </summary>
        [JsonProperty("vehicleNumber")]
        public string? VehicleNumber { get; set; }

        /// <summary>
        /// The other delivery note header information
        /// </summary>
        [JsonProperty("otherDeliveryNoteHeader")]
        public OtherDeliveryNoteHeaderRequestModel? OtherDeliveryNoteHeader { get; set; }

        /// <summary>
        /// The table number
        /// </summary>
        [JsonProperty("tableAA")]
        public string? TableAA { get; set; }

        /// <summary>
        /// The Vat category
        /// </summary>
        [JsonProperty("specialInvoiceCategory")]
        [JsonConverter(typeof(VATCategoryToIntJsonConverter))]
        public VATCategory? VATCategory { get; set; }

        /// <summary>
        /// The correlated MARKs
        /// </summary>
        [JsonProperty("multipleConnectedMarks")]
        public IEnumerable<long>? MultipleConnectedMarks { get; set; }

        /// <summary>
        /// The correlated invoices (the MARKs of them AGAIN!)
        /// </summary>
        [JsonProperty("correlatedInvoices")]
        public IEnumerable<long>? CorrelatedInvoices { get; set; }

        /// <summary>
        /// System Id that is going to be used as aa
        /// ONLY for Send Sim Invoices
        /// </summary>
        [JsonProperty("externalSystemId")]
        public string? ExternalSystemId { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public InvoiceHeaderRequestModel() : base()
        {

        }

        #endregion
    }
}
