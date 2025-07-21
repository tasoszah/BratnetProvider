using Atom.Web;

namespace BratnetProvider
{
    /// <summary>
    /// A normalized (kinda acceptable) version of the <see cref="InvoiceRequestModel"/>
    /// </summary>
    public class NormalizedInvoiceRequestModel : BaseRequestModel
    {
        #region Public Properties

        /// <inheritdoc cref="InvoiceRequestModel.IsUnsigned"/>
        public bool? IsUnsigned { get; set; }

        /// <inheritdoc cref="InvoiceRequestModel.TransmissionFailure"/>
        public int? TransmissionFailure { get; set; }

        /// <inheritdoc cref="InvoiceRequestModel.TIdNSP"/>
        public string? TIdNSP { get; set; }

        /// <inheritdoc cref="InvoiceRequestModel.Issuer"/>
        public IssuerRequestModel? Issuer { get; set; }

        /// <inheritdoc cref="InvoiceRequestModel.CounterPart"/>
        public IssuerRequestModel? CounterPart { get; set; }

        /// <inheritdoc cref="InvoiceRequestModel.InvoiceHeader"/>
        public InvoiceHeaderRequestModel? InvoiceHeader { get; set; }

        /// <inheritdoc cref="InvoiceRequestModel.PaymentMethods"/>
        public IEnumerable<PaymentMethodDetailRequestModel>? PaymentMethods { get; set; }

        /// <inheritdoc cref="InvoiceRequestModel.InvoiceDetails"/>
        public IEnumerable<NormalizedInvoiceDetailRequestModel>? InvoiceDetails { get; set; }

        /// <inheritdoc cref="InvoiceRequestModel.InvoiceVatAnalysis"/>
        public IEnumerable<InvoiceVATAnalysisRequestModel>? InvoiceVatAnalysis { get; set; }

        /// <inheritdoc cref="InvoiceRequestModel.PEPPOLFields"/>
        public PEPPOLFieldsRequestModel? PEPPOLFields { get; set; }

        /// <inheritdoc cref="InvoiceRequestModel.B2G"/>
        public B2GRequestModel? B2G { get; set; }

        /// <inheritdoc cref="InvoiceRequestModel.Taxes"/>
        public IEnumerable<TaxRequestModel>? Taxes { get; set; }

        /// <inheritdoc cref="InvoiceRequestModel.TaxDescriptions"/>
        public IEnumerable<TaxDescriptionsRequestModel>? TaxDescriptions { get; set; }

        /// <inheritdoc cref="InvoiceRequestModel.Extras"/>
        public ExtrasRequestModel? Extras { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public NormalizedInvoiceRequestModel() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Creates and returns a <see cref="InvoiceRequestModel"/> from the current <see cref="NormalizedInvoiceRequestModel"/>
        /// </summary>
        /// <returns></returns>
        public InvoiceRequestModel ToInvoiceRequestModel()
        {
            var result = new InvoiceRequestModel
            {
                IsUnsigned = IsUnsigned,
                TransmissionFailure = TransmissionFailure,
                TIdNSP = TIdNSP,
                Issuer = Issuer,
                CounterPart = CounterPart,
                InvoiceHeader = InvoiceHeader,
                PaymentMethods = PaymentMethods is null ? null : new PaymentMethodDetailsRequestModel() { PaymentMethodDetails = PaymentMethods },
                InvoiceVatAnalysis = InvoiceVatAnalysis,
                PEPPOLFields = PEPPOLFields,
                B2G = B2G,
                Taxes = Taxes is null ? null : new TaxesRequestModel() { Taxes = Taxes },
                TaxDescriptions = TaxDescriptions,
                Extras = Extras,
            };

            if (InvoiceDetails is not null)
            {
                var invoiceDetails = new List<InvoiceDetailRequestModel>();

                foreach(var invoiceDetail in InvoiceDetails)
                    invoiceDetails.Add(invoiceDetail.ToInvoiceDetailRequestModel());

                result.InvoiceDetails = invoiceDetails;
            }

            return result;
        }

        #endregion
    }
}
