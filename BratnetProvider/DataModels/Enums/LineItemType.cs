namespace BratnetProvider
{
    /// <summary>
    /// Provides enumeration over the line item types
    /// </summary>
    public enum LineItemType
    {
        /// <summary>
        /// End line with VAT
        /// </summary>
        EndLineWithVAT,

        /// <summary>
        /// Other tax line with VAT
        /// </summary>
        OtherTaxLineWithVAT,

        /// <summary>
        /// Giftcard
        /// </summary>
        Giftcard,

        /// <summary>
        /// Value with negative sign
        /// </summary>
        ValueWithNegativeSign
    }
}