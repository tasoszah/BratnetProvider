namespace BratnetProvider
{
    /// <summary>
    /// Provides enumeration over the special invoice category type
    /// </summary>
    public enum SpecialInvoiceCategoryType
    {
        /// <summary>
        /// Subsidies - grants
        /// </summary>
        SubsidiesGrants,

        /// <summary>
        /// Hotel retail revenue - charging room
        /// </summary>
        HotelRetailRevenueChargesRoom,

        /// <summary>
        /// Acounting entry
        /// </summary>
        AccountingEntry,

        /// <summary>
        /// Price valid only for transmission via erp or version 
        /// through provider or invoice
        /// </summary>
        TaxFree,

        /// <summary>
        /// Complex domestic - foreign transactions
        /// </summary>
        ComplexDomesticTransactions,

        /// <summary>
        /// Beneficiaries referred to in Article 3 of the Decision 139818 EX2022/28.09.2022 
        /// (B'5083) Joint Ministerial Decision 
        /// </summary>
        BenefiitiariesReferredToArticle3,

        /// <summary>
        /// Purchase of agricultural goods and services Article 41 of the VAT Code
        /// </summary>
        PurchaseOfArgicalturalGoods,

        /// <summary>
        /// Retail Revenues TEM AADE_1
        /// (TEM: Tax Electronic Mechanism) Read Only - invalid price for shipment via ERP / Provider
        /// </summary>
        RetailRevenuesTemAade1,

        /// <summary>
        /// (TEM: Tax Electronic Mechanism) Read Only - invalid price for shipment via ERP / Provider
        /// </summary>
        RetailRevenuesTemAade2,

        /// <summary>
        /// Business Retail TEM (Tax Electronic Mechanism) Revenue Deviation
        /// </summary>
        BussinessRetailTem,

        /// <summary>
        /// Heating Voucher
        /// </summary>
        HeatingVoucher,

        /// <summary>
        /// Food service transactions
        /// </summary>
        FoodServiceTransactions

    }
}