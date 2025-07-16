using Atom.Web;
using Newtonsoft.Json;

namespace BratnetProvider
{
    /// <summary>
    /// Represents a request model for UBL fields.
    /// </summary>
    public class PEPPOLFieldsRequestModel: BaseRequestModel
    {
        #region Public Properties

        /// <summary>
        /// The UBL invoice type
        /// </summary>
        [JsonProperty("invoiceTypeCode")]
        [JsonConverter(typeof(PEPPOLInvoiceTypeCodeToStringJsonConverter))]
        public PEPPOLInvoiceTypeCode? PEPPOLInvoiceTypeCode { get; set; }

        /// <summary>
        /// The issuer's information
        /// </summary>
        [JsonProperty("issuerInfo")]
        public PEPPOLUserInfoRequestModel? IssuerInfo { get; set; }

        /// <summary>
        /// The counterpart's information
        /// </summary>
        [JsonProperty("counterInfo")]
        public PEPPOLUserInfoRequestModel? CounterpartInfo { get; set; }

        /// <summary>
        /// The delivery request information
        /// </summary>
        [JsonProperty("delivery")]
        public PEPPOLDeliveryRequestModel? Delivery { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PEPPOLFieldsRequestModel() : base()
        {

        }

        #endregion
    }
}
