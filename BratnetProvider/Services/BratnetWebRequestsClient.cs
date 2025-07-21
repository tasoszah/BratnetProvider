using Atom.Web;
using System.Net.Http.Headers;
using System.Text;

namespace BratnetProvider
{
    /// <summary>
    /// A <see cref="WebRequestsClient{TAuthenticationArgs}"/> capable of making requests to the Bratnet provider API
    /// </summary>
    public class BratnetWebRequestsClient : WebRequestsClient<BratnetProviderCredentials>
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Instance"/> property
        /// </summary>
        private static readonly Lazy<BratnetWebRequestsClient> mInstance = new(() => new());

        #endregion

        #region Public Properties

        /// <summary>
        /// The single instance of the <see cref="BratnetWebRequestsClient"/>
        /// </summary>
        public static BratnetWebRequestsClient Instance => mInstance.Value;

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        protected BratnetWebRequestsClient() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override AuthenticationHeaderValue CreateAuthenticationHeader(BratnetProviderCredentials authenticationArgs)
        {
            var credentials = Encoding.ASCII.GetBytes($"{authenticationArgs.Username}:{authenticationArgs.Password}");
            var base64Credentials = Convert.ToBase64String(credentials);

            return new AuthenticationHeaderValue("Basic", base64Credentials);
        }

        #endregion
    }
}
