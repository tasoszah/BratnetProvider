using Atom.Web;

namespace BratnetProvider
{
    /// <summary>
    /// An agent capable of making calls to the Bratnet provider API.
    /// </summary>
    public class BratnetProviderClient
    {
        #region Public Properties

        /// <summary>
        /// The credentials
        /// </summary>
        public BratnetProviderCredentials Credentials { get; }

        /// <summary>
        /// A flag indicating whether the test environment should be used
        /// </summary>
        public bool ShouldUseTestEnvironment { get; }

        /// <summary>
        /// The client
        /// </summary>
        public BratnetWebRequestsClient Client { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public BratnetProviderClient(BratnetProviderCredentials credentials, bool shouldUseTestEnvironment = false) : base()
        {
            Credentials = credentials ?? throw new ArgumentNullException(nameof(credentials));
            ShouldUseTestEnvironment = shouldUseTestEnvironment;
            Client = BratnetWebRequestsClient.Instance;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Creates a new SimInvoice
        /// </summary>
        /// <param name="model">The model</param>
        public async Task<WebRequestResult<APIResultResponseModel<ResponsesWrapperResponseModel<InvoiceResponseModel>>>> SendSimInvoiceAsync(InvoiceRequestModel model)
            => await SendSimInvoicesAsync([model]);

        /// <summary>
        /// Creates a new SimInvoice
        /// </summary>
        /// <param name="models">The models</param>
        public async Task<WebRequestResult<APIResultResponseModel<ResponsesWrapperResponseModel<InvoiceResponseModel>>>> SendSimInvoicesAsync(IEnumerable<InvoiceRequestModel> models)
            => await BratnetWebRequestsClient.Instance.PostAsync<APIResultResponseModel<ResponsesWrapperResponseModel<InvoiceResponseModel>>>(APIRoutes.SendInvoiceRoute(ShouldUseTestEnvironment), new InvoicesRequestModel() { Invoices = models }, Credentials);

        /// <summary>
        /// Creates a new Invoice
        /// </summary>
        /// <param name="model">The model</param>
        public async Task<WebRequestResult<APIResultResponseModel<ResponsesWrapperResponseModel<InvoiceResponseModel>>>> SendInvoiceAsync(InvoiceRequestModel model)
            => await SendInvoicesAsync([model]);

        /// <summary>
        /// Creates a new Invoice
        /// </summary>
        /// <param name="models">The models</param>
        public async Task<WebRequestResult<APIResultResponseModel<ResponsesWrapperResponseModel<InvoiceResponseModel>>>> SendInvoicesAsync(IEnumerable<InvoiceRequestModel> models)
           => await BratnetWebRequestsClient.Instance.PostAsync<APIResultResponseModel<ResponsesWrapperResponseModel<InvoiceResponseModel>>>(APIRoutes.SendInvoiceRoute(ShouldUseTestEnvironment), new InvoicesRequestModel() { Invoices = models }, Credentials);

        /// <summary>
        /// Creates a new SimSignature
        /// </summary>
        /// <param name="model">The model</param>
        public async Task<WebRequestResult<CreateSimSignatureResponseModel>> CreateSimSignatureRoute(CreateSimSignatureRequestModel model)
           => await BratnetWebRequestsClient.Instance.PostAsync<CreateSimSignatureResponseModel>(APIRoutes.SendInvoiceRoute(ShouldUseTestEnvironment), model, Credentials);

        /// <summary>
        /// Cancels a SimSignature
        /// </summary>
        /// <param name="model">The model</param>
        public async Task<WebRequestResult<CancelSignatureResponseModel>> CancelSimSignatureRoute(CancelSignatureRequestModel model)
           => await BratnetWebRequestsClient.Instance.PostAsync<CancelSignatureResponseModel>(APIRoutes.SendInvoiceRoute(ShouldUseTestEnvironment), model, Credentials);

        /// <summary>
        /// Creates a new Signature
        /// </summary>
        /// <param name="model">The model</param>
        public async Task<WebRequestResult<CreateSignatureResponseModel>> CreateSignatureRoute(CreateSignatureRequestModel model)
            => await BratnetWebRequestsClient.Instance.PostAsync<CreateSignatureResponseModel>(APIRoutes.SendInvoiceRoute(ShouldUseTestEnvironment), model, Credentials);

        /// <summary>
        /// Cancels a Signature
        /// </summary>
        /// <param name="model">The model</param>
        public async Task<WebRequestResult<CancelSignatureResponseModel>> CancelSignatureRoute(CancelSignatureRequestModel model)
            => await BratnetWebRequestsClient.Instance.PostAsync<CancelSignatureResponseModel>(APIRoutes.SendInvoiceRoute(ShouldUseTestEnvironment), model, Credentials);

        /// <summary>
        /// Updates a Payment
        /// </summary>
        /// <param name="model">The model</param>
        public async Task<WebRequestResult<UpdatePaymentResponseModel>> UpdatePaymentsRoute(UpdatePaymentsRequestModel model)
            => await BratnetWebRequestsClient.Instance.PostAsync<UpdatePaymentResponseModel>(APIRoutes.SendInvoiceRoute(ShouldUseTestEnvironment), model, Credentials);

        #endregion
    }
}
