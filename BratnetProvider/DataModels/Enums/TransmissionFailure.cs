namespace BratnetProvider
{
    /// <summary>
    /// Provides enumeration over the transmission failures
    /// </summary>
    public enum TransmissionFailure
    {
        /// <summary>
        /// Provider error
        /// </summary>
        ProviderError,

        /// <summary>
        /// MyData error
        /// </summary>
        MyDataError,

        /// <summary>
        /// Unable to connect to MyData
        /// </summary>
        UnableToConnect,

        /// <summary>
        /// Access denied
        /// </summary>
        AccessViolation
    }
}