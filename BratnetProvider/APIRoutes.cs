namespace BratnetProvider
{
    /// <summary>
    /// The API routes
    /// </summary>
    public static class APIRoutes
    {
        //Probably
        public const string ProductionRoute = "https://einvoicing-api.etimologiera.gr/v4/";

        public const string TestingRoute = "https://einvoicing-dev-api.etimologiera.gr/v4/";

        public static string GetBaseRoute(bool shouldUseTestEnvironment)
        {
            if (shouldUseTestEnvironment)
                return TestingRoute;

            return ProductionRoute;
        }

        public static string SendInvoiceRoute(bool shouldUseTestEnvironment)
            => $"{GetBaseRoute(shouldUseTestEnvironment)}sendInvoice";

        public static string SendSimInvoiceRoute(bool shouldUseTestEnvironment)
            => $"{GetBaseRoute(shouldUseTestEnvironment)}sendSimInvoice";

        public static string CreateSimSignatureRoute(bool shouldUseTestEnvironment)
            => $"{GetBaseRoute(shouldUseTestEnvironment)}createSimSign";

        public static string CancelSimSignatureRoute(bool shouldUseTestEnvironment)
            => $"{GetBaseRoute(shouldUseTestEnvironment)}cancelSimSign";

        public static string CreateSignatureRoute(bool shouldUseTestEnvironment)
            => $"{GetBaseRoute(shouldUseTestEnvironment)}createSign";

        public static string CancelSignatureRoute(bool shouldUseTestEnvironment)
            => $"{GetBaseRoute(shouldUseTestEnvironment)}cancelSign";

        public static string UpdatePaymentsRoute(bool shouldUseTestEnvironment)
            => $"{GetBaseRoute(shouldUseTestEnvironment)}updatePayments";

        //public static string InvoiceRequestInfoRoute(bool shouldUseTestEnvironment)
        //    => $"{GetBaseRoute(shouldUseTestEnvironment)}invoiceRequestInfo";

        //public static string SendOfllineDataRoute(bool shouldUseTestEnvironment)
        //    => $"{GetBaseRoute(shouldUseTestEnvironment)}sendOfflineData";

        #region Restaurants

        //public static string TransferTableRoute(bool shouldUseTestEnvironment)
        //    => $"{GetBaseRoute(shouldUseTestEnvironment)}orders/transferTable";

        //public static string OpenTableRoute(bool shouldUseTestEnvironment)
        //    => $"{GetBaseRoute(shouldUseTestEnvironment)}orders/openTables";

        //public static string OpenTableDetailsRoute(bool shouldUseTestEnvironment)
        //    => $"{GetBaseRoute(shouldUseTestEnvironment)}orders/openTableDetails";

        #endregion

    }
}
