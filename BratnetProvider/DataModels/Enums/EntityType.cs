namespace BratnetProvider
{
    public enum EntityType
    {
        /// <summary>
        /// Tax Representative
        /// </summary>
        TaxRepresentative,

        /// <summary>
        /// Mediator
        /// </summary>
        Mediator,

        /// <summary>
        /// Transporter
        /// </summary>
        Transporter,

        /// <summary>
        /// Receiver of the Sender (Seller)
        /// </summary>
        ReceiverOfTheSender,

        /// <summary>
        /// Sender (Seller)
        /// </summary>
        Sender,

        /// <summary>
        /// Other Correlated Entities 
        /// </summary>
        OtherCorrelatedEntities
    }
}