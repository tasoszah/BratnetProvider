using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;

namespace BratnetProvider
{
    /// <summary>
    /// Represents an API result that contains a specific type of response.
    /// </summary>
    /// <typeparam name="T">The type of the response</typeparam>
    public class APIResultResponseModel<T>
        where T : notnull, new()
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Response"/> property
        /// </summary>
        private T? mResponse;

        /// <summary>
        /// The member of the <see cref="UserRequestID"/> property
        /// </summary>
        private string? mUserRequestID;

        /// <summary>
        /// The member of the <see cref="Version"/> property
        /// </summary>
        private string? mVersion;

        #endregion

        #region Public Properties

        /// <summary>
        /// The user request ID
        /// </summary>
        [AllowNull]
        [JsonProperty("userRequestID")]
        public string UserRequestID
        {
            get => mUserRequestID ?? string.Empty;
            set => mUserRequestID = value;
        }

        /// <summary>
        /// The version
        /// </summary>
        [AllowNull]
        [JsonProperty("version")]
        public string Version
        {
            get => mVersion ??= string.Empty;
            set => mVersion = value;
        }

        /// <summary>   
        /// The response
        /// </summary>
        [JsonProperty("response")]
        public T Response
        {
            get => mResponse ??= new();

            set => mResponse = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public APIResultResponseModel() : base()
        {
        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString() => Response?.ToString() ?? "No response";

        #endregion
    }
}
