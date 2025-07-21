using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;

namespace BratnetProvider
{
    /// <summary>
    /// Represents the response model for an invoice.
    /// </summary>
    public class InvoiceResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="InvoiceUID"/> property 
        /// </summary>
        private string? mInvoiceUID;

        /// <summary>
        /// The member of the <see cref="AuthenticationCode"/> property 
        /// </summary>
        private string? mAuthenticationCode;

        /// <summary>
        /// The member of the <see cref="InvoiceURL"/> property 
        /// </summary>
        private string? mInvoiceURL;

        /// <summary>
        /// The member of the <see cref="BSignature"/> property 
        /// </summary>
        private string? mBSignature;

        /// <summary>
        /// The member of the <see cref="HSignature"/> property 
        /// </summary>
        private string? mHSignature;

        /// <summary>
        /// The member of the <see cref="SignatureMessage"/> property 
        /// </summary>
        private string? mSignatureMessage;

        #endregion

        #region Public Properties

        /// <summary>
        /// The Id
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// The index
        /// </summary>
        [JsonProperty("index")]
        public int Index { get; set; }

        /// <summary>
        /// The UID of the invoice.
        /// </summary>
        [AllowNull]
        [JsonProperty("invoiceUid")]
        public string InvoiceUID
        {
            get => mInvoiceUID ??= string.Empty;
            set => mInvoiceUID = value;
        }

        /// <summary>
        /// The MARK of the invoice.
        /// </summary>
        [JsonProperty("invoiceMark")]
        public long InvoiceMARK { get; set; }

        /// <summary>
        /// The classification MARK
        /// </summary>
        [JsonProperty("classificationMark")]
        public long ClassificationMARK { get; set; }

        /// <summary>
        /// The authentication code of the invoice.
        /// </summary>
        [AllowNull]
        [JsonProperty("authenticationCode")]
        public string AuthenticationCode
        {
            get => mAuthenticationCode ??= string.Empty;
            set => mAuthenticationCode = value;
        }

        /// <summary>
        /// The invoice URL.
        /// </summary>
        [AllowNull]
        [JsonProperty("invoiceUrl")]
        public string InvoiceURL
        {
            get => mInvoiceURL ??= string.Empty;
            set => mInvoiceURL = value;
        }

        /// <summary>
        /// The B. signature
        /// </summary>
        [AllowNull]
        [JsonProperty("bSignature")]
        public string BSignature
        {
            get => mBSignature ??= string.Empty;
            set => mBSignature = value;
        }

        /// <summary>
        /// The H. signature
        /// </summary>
        [AllowNull]
        [JsonProperty("hSignature")]
        public string HSignature
        {
            get => mHSignature ??= string.Empty;
            set => mHSignature = value;
        }

        /// <summary>
        /// The signature message.
        /// </summary>
        [AllowNull]
        [JsonProperty("signatureMessage")]
        public string SignatureMessage
        {
            get => mSignatureMessage ??= string.Empty;
            set => mSignatureMessage = value;
        }

        /// <summary>
        /// The MARK of the cancelation invoice
        /// </summary>
        [JsonProperty("cancellationMark")]
        public long CancellationMARK { get; set; }

        /// <summary>
        /// The creation date
        /// </summary>
        [JsonProperty("createdAt")]
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// The date the invoice was last updated
        /// </summary>
        [JsonProperty("updatedAt")]
        public DateTime DateUpdated { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public InvoiceResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString() => "MARK: " + InvoiceMARK;

        #endregion
    }
}
