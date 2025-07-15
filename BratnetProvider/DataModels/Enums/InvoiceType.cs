namespace BratnetProvider
{
    /// <summary>
    /// Provides enumeration over the invoice types
    /// </summary>
    public enum InvoiceType
    {
        // Sale invoices (1)

        /// <summary>
        /// Invoice type 1.1
        /// </summary>
        SalesInvoice,

        /// <summary>
        /// Invoice type 1.2
        /// </summary>
        SalesInvoiceForIntraCommunity,

        /// <summary>
        /// Invoice type 1.3
        /// </summary>
        SalesInvoiceForThirdPartyCountries,

        /// <summary>
        /// Invoice type 1.4
        /// </summary>
        SalesInvoiceForThirdParty,

        /// <summary>
        /// Invoice type 1.5
        /// </summary>
        SalesInvoiceForThirdPartySalesAndClearance,

        /// <summary>
        /// Invoice type 1.6
        /// </summary>
        SalesInvoiceForAdditionalCases,

        // Provision of service invoices (2)

        /// <summary>
        /// Invoice type 2.1
        /// </summary>
        ProvisionOfServicesInvoice,

        /// <summary>
        /// Invoice type 2.2
        /// </summary>
        ProvisionOfServicesInvoiceForIntraCommunity,

        /// <summary>
        /// Invoice type 2.3
        /// </summary>
        ProvisionOfServicesInvoiceForThirdCountries,

        /// <summary>
        /// Invoice type 2.4
        /// </summary>
        ProvisionOfServicesInvoiceForAdditionalCases,

        // Deeds of ownership (3)

        /// <summary>
        /// Invoice type 3.1
        /// </summary>
        DeedOfOwnershipForNonObligatoryIssuer,

        /// <summary>
        /// Invoice type 3.2
        /// </summary>
        DeedOfOwnershipWithDenialFromObligatoryIssuer,

        // Debit invoices (5)

        /// <summary>
        /// Invoice type 5.1
        /// </summary>
        CorrelatedDebitInvoice,

        /// <summary>
        /// Invoice type 5.2
        /// </summary>
        NonCorrelatedDebitInvoice,

        // Self delivery invoices (6)

        /// <summary>
        /// Invoice type 6.1
        /// </summary>
        SelfDeliveryReceipt,

        /// <summary>
        /// Invoice type 6.2
        /// </summary>
        SelfUseReceipt,

        // Contract - Income (7)

        /// <summary>
        /// Invoice type 7.1
        /// </summary>
        ContractIncome,

        // Special item (income) – Receive receipt (8)

        /// <summary>
        /// Invoice type 8.1
        /// </summary>
        RentIncome,

        /// <summary>
        /// Invoice type 8.2
        /// </summary>
        ReceiptOfAccommodationTaxCollection,

        /// <summary>
        /// Invoice type 8.4
        /// </summary>
        POSReceipt,

        /// <summary>
        /// Invoice type 8.5
        /// </summary>
        POSDebitReceipt,

        /// <summary>
        /// Invoice type 8.6
        /// </summary>
        CateringOrderForm,

        // Shipping Document (9)

        /// <summary>
        /// Invoice type 9.3
        /// </summary>
        DeliveryNote,

        // Retail receipts (11)

        /// <summary>
        /// Invoice type 11.1
        /// </summary>
        SalesReceipt,

        /// <summary>
        /// Invoice type 11.2
        /// </summary>
        ProvisionOfServicesReceipt,

        /// <summary>
        /// Invoice type 11.3
        /// </summary>
        SimplifiedInvoice,

        /// <summary>
        /// Invoice type 11.4
        /// </summary>
        SalesDebitReceipt,

        /// <summary>
        /// Invoice type 11.5
        /// </summary>
        SalesReceiptForThirdParty,

        // Obtaining retail receipts (13)

        /// <summary>
        /// Invoice type 13.1
        /// </summary>
        ExpensesPurchasesAndRetailTransactionsForDomesticAndNonDomestic,

        /// <summary>
        /// Invoice type 13.2
        /// </summary>
        RetailTransactionsSubmissionForDomesticAndNonDomestic,

        /// <summary>
        /// Invoice type 13.3
        /// </summary>
        SharedCommonExpenses,

        /// <summary>
        /// Invoice type 13.4
        /// </summary>
        Subscriptions,

        /// <summary>
        /// Invoice type 13.30
        /// </summary>
        EntityReceiptAsSpecifiedByTheOriginator,

        /// <summary>
        /// Invoice type 13.31
        /// </summary>
        SalesDebitReceiptForDomesticAndNonDomestic,

        // Exemption documents of domestic / foreign entities (14)

        /// <summary>
        /// Invoice type 14.1
        /// </summary>
        SalesInvoiceForIntraCommunityAcquisitions,

        /// <summary>
        /// Invoice type 14.2
        /// </summary>
        SalesInvoiceForThirdCountriesAcquisitions,

        /// <summary>
        /// Invoice type 14.3
        /// </summary>
        ProvisionOfServicesInvoiceForIntraCommunityAcquisitions,

        /// <summary>
        /// Invoice type 14.4
        /// </summary>
        ProvisionOfServicesInvoiceForThirdCountriesAcquisitions,

        /// <summary>
        /// Invoice type 14.5
        /// </summary>
        EFKAAndInsuranceOrganizations,

        /// <summary>
        /// Invoice type 14.30
        /// </summary>>
        EntityDocumentsAsStatedByTheEntity,

        /// <summary>
        /// Invoice type 14.31
        /// </summary>
        DebitInvoiceForDomesticAndNonDomestic,

        // Contract - Expense (15)

        /// <summary>
        /// Invoice type 15.1
        /// </summary>
        ContractExpense,

        // Special item (expense) – Payment receipt (16)

        /// <summary>
        /// Invoice type 16.1
        /// </summary>
        RentExpense,

        // Entity records (17)

        /// <summary>
        /// Invoice type 17.1
        /// </summary>
        Payroll,

        /// <summary>
        /// Invoice type 17.2
        /// </summary>
        Deprecations,

        /// <summary>
        /// Invoice type 17.3
        /// </summary>
        VariousIncomeArrangementsForAccountingBase,

        /// <summary>
        /// Invoice type 17.4
        /// </summary>
        VariousIncomeArrangementsForTaxBase,

        /// <summary>
        /// Invoice type 17.5
        /// </summary>
        VariousExpenseArrangementsForAccountingBase,

        /// <summary>
        /// Invoice type 17.6
        /// </summary>
        VariousExpenseArrangementsForTaxBase,
    }
}