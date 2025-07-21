using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;

namespace BratnetProvider
{
    /// <summary>
    /// Represents the response model for creating signature for secure invoice submission.
    /// </summary>
    public class CreateSimSignatureResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="TempUID"/> property 
        /// </summary>
        private string? mTempUID;

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
        /// The temporary UID of the invoice.
        /// </summary>
        [AllowNull]
        [JsonProperty("tempUid")]
        public string TempUID
        {
            get => mTempUID ??= string.Empty;
            set => mTempUID = value;
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

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public CreateSimSignatureResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString() => "TempUID: " + TempUID;

        #endregion
    }
}
