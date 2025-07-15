using Atom.Web;
using Newtonsoft.Json;

namespace BratnetProvider
{
    /// <summary>
    /// Represent an extra data model
    /// </summary>
    public class ExtrasRequestModel : BaseRequestModel
    {
        #region Public Properties

        /// <summary>
        /// A flag that indicates if the document will be sended to counterpart via email
        /// </summary>
        [JsonProperty("customerSendEmail")]
        public bool? CustomerSendEmail { get; set; }

        /// <summary>
        /// The issuer's company name
        /// </summary>
        [JsonProperty("salerName")]
        public string? SellerName { get; set; }

        /// <summary>
        /// The issuer's main activity
        /// </summary>
        [JsonProperty("salerActivity")]
        public string? SellerActivity { get; set; }

        /// <summary>
        /// The issuer's address
        /// </summary>
        [JsonProperty("salerStreetName")]
        public string? SellerStreetName { get; set; }

        /// <summary>
        /// The issuer's region
        /// </summary>
        [JsonProperty("salerAdditionalStreetName")]
        public string? SellerAdditionalStreetName { get; set; }

        /// <summary>
        /// The issuer's district
        /// </summary>
        [JsonProperty("salerAdditionalStreetName")]
        public string? SellerRegion { get; set; }

        /// <summary>
        /// The issuer's postal code
        /// </summary>
        [JsonProperty("salerTk")]
        public string? SellerPostalCode { get; set; }

        /// <summary>
        /// The issuer's city
        /// </summary>
        [JsonProperty("salerCity")]
        public string? SellerCity { get; set; }

        /// <summary>
        /// The issuer's phone number
        /// </summary>
        [JsonProperty("salerPhone")]
        public string? SellerPhone { get; set; }

        /// <summary>
        /// The issuer's email
        /// </summary>
        [JsonProperty("salerEmail")]
        public string? SellerEmail { get; set; }

        /// <summary>
        /// The issuer's website
        /// </summary>
        [JsonProperty("salerWebsite")]
        public Uri? SellerWebsite { get; set; }

        /// <summary>
        /// The issuer's GCR (General Commercial Registry Number)
        /// </summary>
        [JsonProperty("salerGemh")]
        public string? SellerGCR { get; set; }

        /// <summary>
        /// The issuer's VAT (Tax Identification Number)
        /// </summary>
        [JsonProperty("salerVat")]
        public string? SellerVAT { get; set; }

        /// <summary>
        /// The issuer's tax office code (Public Financial Service) code
        /// </summary>
        [JsonProperty("salerDoyCode")]
        public uint? SellerPFSCode { get; set; }

        /// <summary>
        /// The issuer's tax office code (Public Financial Service) name
        /// </summary>
        [JsonProperty("salerDoyName")]
        public string? SellerPFSName { get; set; }

        /// <summary>
        /// The title of the seller
        /// </summary>
        [JsonProperty("salerTitle")]
        public string? SellerTitle { get; set; }

        /// <summary>
        /// The name of the representative or contact person for the seller
        /// </summary>
        [JsonProperty("salerRepresentative")]
        public string? SalerRepresentative { get; set; }

        /// <summary>
        /// The VAT (identification number) of the seller's representative
        /// </summary>
        [JsonProperty("salerRepresentativeVat")]
        public string? SalerRepresentativeVat { get; set; }

        /// <summary>
        /// The counterpart's company name
        /// </summary>
        [JsonProperty("customerName")]
        public string? CustomerName { get; set; }

        /// <summary>
        /// The counterpart's main activity
        /// </summary>
        [JsonProperty("customerActivity")]
        public string? CustomerActivity { get; set; }

        /// <summary>
        /// The counterpart's vat number
        /// </summary>
        [JsonProperty("customerVAT")]
        public string? CustomerVAT { get; set; }

        /// <summary>
        /// The counterpart's tax office code
        /// </summary>
        [JsonProperty("customerDoyCode")]
        public int CustomerDOYCode { get; set; }

        /// <summary>
        /// The counterpart's PFS name
        /// </summary>
        [JsonProperty("customerDoyName")]
        public string? CustomerPFSName { get; set; }

        /// <summary>
        /// The counterpart's address
        /// </summary>
        [JsonProperty("customerStreetName")]
        public string? CustomerAddress { get; set; }

        /// <summary>
        /// The customer's postal code
        /// </summary>
        [JsonProperty("customerTk")]
        public string? CustomerPostalCode { get; set; }

        /// <summary>
        /// The customer's city
        /// </summary>
        [JsonProperty("customerCity")]
        public string? CustomerCity { get; set; }

        /// <summary>
        /// The counterpart's phone number
        /// </summary>
        [JsonProperty("customerPhone")]
        public string? CustomerPhone { get; set; }

        /// <summary>
        /// The customer's email
        /// </summary>
        [JsonProperty("customerEmail")]
        public string? CustomerEmail { get; set; }

        /// <summary>
        /// The shipment's type
        /// </summary>
        ///<example>By car</example>
        [JsonProperty("shipmentName")]
        public string? ShipmentName { get; set; }

        /// <summary>
        /// The loading address
        /// </summary>
        [JsonProperty("loadingAddress")]
        public string? LoadingAddress { get; set; }

        /// <summary>
        /// The destination address
        /// </summary>
        [JsonProperty("destinationAddress")]
        public string? DestinationAddress { get; set; }

        /// <summary>
        /// The payment method
        /// </summary>
        [JsonProperty("paymentMethodName")]
        public PaymentType? PaymentMethodName { get; set; }

        /// <summary>
        /// The invoice type name
        /// </summary>
        [JsonProperty("invoiceTypeName")]
        public InvoiceType? InvoiceTypeName { get; set; }

        /// <summary>
        /// The move purpose
        /// </summary>
        [JsonProperty("movePurpose")]
        public MovePurpose? MovePurpose { get; set; }

        /// <summary>
        /// The vehicle number
        /// </summary>
        [JsonProperty("vehicleNumber")]
        public string? VehicleNumber { get; set; }

        /// <summary>
        /// The VAT exemption category name
        /// </summary>
        [JsonProperty("vatExemptionCategoryName")]
        public VATExemptionCategory? VATExemptionCategoryName { get; set; }

        /// <summary>
        /// The digital or physical signature of the relevant parties, confirming the details of the transaction
        /// ONLY for Send Sim Invoices
        /// </summary>
        [JsonProperty("signature")]
        public string? Signature { get; set; }

        /// <summary>
        /// The amount for any tip given as part of the invoice
        /// ONLY for Send Sim Invoices
        /// </summary>
        [JsonProperty("tipAmount")]
        public decimal? TipAmount { get; set; }

        /// <summary>
        /// A unique identifier for the transaction associated with the invoice
        /// ONLY for Send Sim Invoices
        /// </summary>
        [JsonProperty("transactionId")]
        public string? TransactionId { get; set; }

        /// <summary>
        /// The code used for tax or compliance
        /// ONLY for Send Sim Invoices
        /// </summary>
        [JsonProperty("nspCode")]
        public string? NspCode { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ExtrasRequestModel()
        {

        }

        #endregion

    }
}
