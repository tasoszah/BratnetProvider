using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;

namespace BratnetProvider
{
    /// <summary>
    /// Represents the response model for canceling a signature 
    /// </summary>
    public class CancelSignatureResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="HexSignature"/> property 
        /// </summary>
        private string? mHexSignature;

        /// <summary>
        /// The member of the <see cref="TempInvoiceUID"/> property 
        /// </summary>
        private string? mTempInvoiceUID;

        #endregion

        #region Public Properties

        /// <summary>
        /// The hex signature
        /// </summary>
        [AllowNull]
        [JsonProperty("hexSignature")]
        public string HexSignature
        {
            get => mHexSignature ??= string.Empty;
            set => mHexSignature = value;
        }

        /// <summary>
        /// The B. signature
        /// </summary>
        [AllowNull]
        [JsonProperty("tempInvoiceUid")]
        public string TempInvoiceUID
        {
            get => mTempInvoiceUID ??= string.Empty;
            set => mTempInvoiceUID = value;
        }

        /// <summary> 
        /// Indicates whether the signature cancellation was successful.
        /// </summary>
        [JsonProperty("canceled")]
        public bool IsCanceled { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public CancelSignatureResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString() => TempInvoiceUID;

        #endregion
    }
}