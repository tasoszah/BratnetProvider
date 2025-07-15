using Atom.Web;
using Newtonsoft.Json;

namespace BratnetProvider
{
    /// <summary>
    /// Represents a request model for UBL fields.
    /// </summary>
    public class UblFieldsRequestModel: BaseRequestModel
    {
        #region Public Properties

        /// <summary>
        /// The UBL invoice type
        /// </summary>
        [JsonProperty("invoiceTypeCode")]
        ///Missing converter
        public PEPPOLInvoiceTypeCode? UblInvoiceTypeCode { get; set; }

        /// <summary>
        /// The issuer's information
        /// </summary>
        [JsonProperty("issuerInfo")]
        public UblUserInfoRequestModel? IssuerInfo { get; set; }

        /// <summary>
        /// The counterpart's information
        /// </summary>
        [JsonProperty("counterInfo")]
        public UblUserInfoRequestModel? CounterpartInfo { get; set; }

        /// <summary>
        /// The delivery request information
        /// </summary>
        [JsonProperty("delivery")]
        public UblDeliveryRequestModel? Delivery { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public UblFieldsRequestModel() : base()
        {

        }

        #endregion
    }
}
