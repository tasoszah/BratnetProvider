namespace BratnetProvider
{
    /// <summary>
    /// Credentials used for accessing the Bratnet provider API.
    /// </summary>
    public record BratnetProviderCredentials
    {
        #region Public Properties

        /// <summary>
        /// The username
        /// </summary>
        public string Username { get; }

        /// <summary>
        /// The pasword
        /// </summary>
        public string Password { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public BratnetProviderCredentials(string username, string password) : base()
        {
            Username = username ?? string.Empty;
            Password = password ?? string.Empty;
        }

        #endregion
    }
}
