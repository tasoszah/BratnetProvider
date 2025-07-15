namespace BratnetProvider
{
    /// <summary>
    /// Provides enumeration over the payment types
    /// </summary>
    public enum PaymentType
    {
        /// <summary>
        /// Home Payments Professional Account
        /// </summary>
        BusinessHomePaymentAccount,

        /// <summary>
        /// Foreigner's Professional Payment Account
        /// </summary>
        BusinessForeignPaymentAccount,

        /// <summary>
        /// Cash payment
        /// </summary>
        Cash,

        /// <summary>
        /// Bank check payment
        /// </summary>
        Check,

        /// <summary>
        /// On credit payment
        /// </summary>
        OnCredit,

        /// <summary>
        /// Online deposit
        /// </summary>
        WebBanking,

        /// <summary>
        /// POS terminal
        /// </summary>
        POSOrEPOS,

        /// <summary>
        /// IRIS payments
        /// </summary>
        IRIS
    }
}