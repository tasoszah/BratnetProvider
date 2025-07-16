using Atom.Web;
using Newtonsoft.Json;

namespace BratnetProvider
{
    /// <summary>
    /// Represents a request model for canceling a signature 
    /// </summary>
    public class CancelSignatureRequestModel : BaseRequestModel
    {
        #region Public Properties

        /// <summary>
        /// A digital signature in hexadecimal format. This particular signature could be associated with a 
        /// transaction, document, or data payload in a blockchain or secure communication context
        /// </summary>
        [JsonProperty("hSignature")]
        public string? HSignature { get; set; }

        /// <summary>
        /// The description of the action, instructing that the message or operation can be canceled
        /// </summary>
        [JsonProperty("msgCancel")]
        public string? CancelMessage { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public CancelSignatureRequestModel() : base()
        {

        }

        #endregion
    }
}
