using Atom;
using System.Collections.Immutable;

namespace BratnetProvider
{
    /// <summary>
    /// Constants related to the bratnet provider client
    /// </summary>
    public static class BratnetProviderClientConstants
    {
        /// <summary>
        /// Maps the <see cref="DocumentDeviationType"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<DocumentDeviationType, int> DocumentDeviationTypeToIntMapper { get; } = new Dictionary<DocumentDeviationType, int>()
        {
            { DocumentDeviationType.RecipientOmissionTransmission, 1 },
            { DocumentDeviationType.IssuerOmissionTransmission, 2 },
            { DocumentDeviationType.TransmissionOfDeviationFromReceiver, 3 },
            { DocumentDeviationType.TransmissionOfDeviationFromPublisher, 4 }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="FeesPercentageCategory"/>s to their related <see cref="int"/>s
        /// </summary>
        public static IReadOnlyDictionary<FeePercentageCategory, int> FeesPercentageCategoryToIntMapper { get; } = new Dictionary<FeePercentageCategory, int>()
        {
            { FeePercentageCategory.MonthlyBill12Percent, 1 },
            { FeePercentageCategory.MonthlyBill15Percent, 2 },
            { FeePercentageCategory.MonthlyBill18Percent, 3 },
            { FeePercentageCategory.MonthlyBill20Percent, 4 },
            { FeePercentageCategory.MobileCalls12Percent, 5 },
            { FeePercentageCategory.CableTV10Percent, 6 },
            { FeePercentageCategory.Telephone5Percent, 7 },
            { FeePercentageCategory.EnvironmentalFeePercentForPlasticBag, 8 },
            { FeePercentageCategory.OliveFlyControl2Percent, 9 },
            { FeePercentageCategory.OtherFees, 10 },
            { FeePercentageCategory.OtherTaxFees, 11 },
            { FeePercentageCategory.OliveFlyControl, 12 },
            { FeePercentageCategory.MonthlyBillOfEachConnection10Percent, 13 },
            { FeePercentageCategory.MobileCalls10Percent, 14 },
            { FeePercentageCategory.MobileAndPrepaidFee0Percent, 15 },
            { FeePercentageCategory.EnvironmentalFeePercentForPlasticProducts, 16 },
            { FeePercentageCategory.RecyclingFee, 17 },
            { FeePercentageCategory.AccommodationFee, 18 },
            { FeePercentageCategory.GrossRevenueTaxOfRestaurants, 19 },
            { FeePercentageCategory.GrossReceiptFeeOfEntertainmentCenters, 20 },
            { FeePercentageCategory.CasinoGrossReceiptsTax, 21 },
            { FeePercentageCategory.OtherFeeOnGrossReceipts, 22 }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="FuelCodeCategoryType"/>s to their related <see cref="int"/>s
        /// </summary>
        public static IReadOnlyDictionary<FuelCodeCategory, int> FuelCodeCategoryTypeToIntMapper { get; } = new Dictionary<FuelCodeCategory, int>()
        {
            // Benzine
            { FuelCodeCategory.Benzine95RON, 10},
            { FuelCodeCategory.Benzine95RONPlus, 11},
            { FuelCodeCategory.Benzine100RON, 12},
            { FuelCodeCategory.BenzineLRP, 13},
            { FuelCodeCategory.AirplaneBenzine, 14},

            // Diesel
            { FuelCodeCategory.SpecialJetFuel, 15},
            { FuelCodeCategory.Diesel, 20},
            { FuelCodeCategory.DieselPremium, 21},
            { FuelCodeCategory.DieselHeatnn, 30},
            { FuelCodeCategory.DieaselHeatPremium, 31},
            { FuelCodeCategory.DieselLight, 32},
            { FuelCodeCategory.OtherUseDiesel, 33},
            { FuelCodeCategory.NavyDiesel, 34},

            // Kerosene
            { FuelCodeCategory.KerosenJP1, 35},
            { FuelCodeCategory.OtherUseKerosene, 36},
            { FuelCodeCategory.FuelOil, 37},

            // Oil
            { FuelCodeCategory.NavyFuelOil, 38},

            // LPG (liquid gas)
            { FuelCodeCategory.LPG, 40},
            { FuelCodeCategory.LPGAndMethaneIndustrial, 41},
            { FuelCodeCategory.LPGAndMethaneHeating, 42},
            { FuelCodeCategory.LPGAndMethaneCommercialEngines, 43},
            { FuelCodeCategory.LPGAndMethaneHeatingOtherUse, 44},

            // CNG (Compressed Natural Gas)
            { FuelCodeCategory.CNG, 50},

            // Hydrocarbons
            { FuelCodeCategory.AromaticHydrocarbons, 60},
            { FuelCodeCategory.CyclicHydrocarbons, 61},

            // Light oils
            { FuelCodeCategory.LightPetrol, 70},
            { FuelCodeCategory.LightOil, 71},

            // Bio diesel
            { FuelCodeCategory.Biodiesel, 72},

            // Other service charges
            { FuelCodeCategory.OtherServiceCharges, 999}

        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="InvoiceDetailType"/>s to their related <see cref="int"/>s
        /// </summary>
        public static IReadOnlyDictionary<InvoiceDetailType, int> InvoiceDetailTypeToIntMapper { get; } = new Dictionary<InvoiceDetailType, int>()
        {
            { InvoiceDetailType.ThirdPartySalesClearance, 1 },
            { InvoiceDetailType.FeeFromThirdPartySales, 2 }

        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="InvoiceType"/>s to their related <see cref="int"/>s
        /// </summary>
        public static IReadOnlyDictionary<InvoiceType, string> InvoiceTypeToStringMapper { get; } = new Dictionary<InvoiceType, string>()
        {
            // Sales invoices
            { InvoiceType.SalesInvoice, "1.1" },
            { InvoiceType.SalesInvoiceForIntraCommunity, "1.2" },
            { InvoiceType.SalesInvoiceForThirdPartyCountries, "1.3" },
            { InvoiceType.SalesInvoiceForThirdParty, "1.4"},
            { InvoiceType.SalesInvoiceForThirdPartySalesAndClearance, "1.5" },
            { InvoiceType.SalesInvoiceForAdditionalCases, "1.6" },

            // Provision of service invoices
            { InvoiceType.ProvisionOfServicesInvoice, "2.1" },
            { InvoiceType.ProvisionOfServicesInvoiceForIntraCommunity, "2.2" },
            { InvoiceType.ProvisionOfServicesInvoiceForThirdCountries, "2.3" },
            { InvoiceType.ProvisionOfServicesInvoiceForAdditionalCases, "2.4" },

            // Deeds of ownership
            { InvoiceType.DeedOfOwnershipForNonObligatoryIssuer, "3.1" },
            { InvoiceType.DeedOfOwnershipWithDenialFromObligatoryIssuer, "3.2" },

            // Correlated debit invoice
            { InvoiceType.CorrelatedDebitInvoice, "5.1" },
            { InvoiceType.NonCorrelatedDebitInvoice, "5.2" },

            // Self delivery invoices
            { InvoiceType.SelfDeliveryReceipt, "6.1" },
            {InvoiceType.SelfUseReceipt, "6.2" },

            // Contract income invoice
            { InvoiceType.ContractIncome, "7.1" },

            // Special item (income) invoice
            { InvoiceType.RentIncome, "8.1" },
            { InvoiceType.ReceiptOfAccommodationTaxCollection, "8.2" },

            // Retail receipts invoices
            { InvoiceType.SalesReceipt, "11.1" },
            { InvoiceType.ProvisionOfServicesReceipt, "11.2"},
            { InvoiceType.SimplifiedInvoice, "11.3" },
            { InvoiceType.SalesDebitReceipt, "11.4" },
            { InvoiceType.SalesReceiptForThirdParty, "11.5" },

            // Obtaining retail receipts invoice
            { InvoiceType.ExpensesPurchasesAndRetailTransactionsForDomesticAndNonDomestic, "13.1" },
            { InvoiceType.RetailTransactionsSubmissionForDomesticAndNonDomestic, "13.2" },
            { InvoiceType.SharedCommonExpenses, "13.3" },
            { InvoiceType.Subscriptions, "13.4" },
            { InvoiceType.EntityReceiptAsSpecifiedByTheOriginator, "13.30" },
            { InvoiceType. SalesDebitReceiptForDomesticAndNonDomestic, "13.31" },

            // Exemption invoices of domestic / foreign countries
            { InvoiceType.SalesInvoiceForIntraCommunityAcquisitions, "14.1"},
            { InvoiceType.SalesInvoiceForThirdCountriesAcquisitions, "14.2"},
            { InvoiceType.ProvisionOfServicesInvoiceForIntraCommunityAcquisitions, "14.3"},
            { InvoiceType.ProvisionOfServicesInvoiceForThirdCountriesAcquisitions, "14.4"},
            { InvoiceType.EFKAAndInsuranceOrganizations, "14.5"},
            { InvoiceType.EntityDocumentsAsStatedByTheEntity, "14.30"},
            { InvoiceType.DebitInvoiceForDomesticAndNonDomestic, "14.31"},

            // Contract expense invoice
            { InvoiceType.ContractExpense, "15.1" },

            // Rent expense invoice
            { InvoiceType.RentExpense, "16.1" },

            // Entity records invoices
            { InvoiceType.Payroll, "17.1" },
            { InvoiceType.Deprecations, "17.2" },
            { InvoiceType.VariousIncomeArrangementsForAccountingBase, "17.3" } ,
            { InvoiceType.VariousIncomeArrangementsForTaxBase, "17.4" },
            { InvoiceType.VariousExpenseArrangementsForAccountingBase, "17.5" },
            { InvoiceType.VariousExpenseArrangementsForTaxBase, "17.6" }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="LineItemType"/>s to their related <see cref="int"/>s
        /// </summary>
        public static IReadOnlyDictionary<LineItemType, int> LineItemTypeToIntMapper { get; } = new Dictionary<LineItemType, int>()
        {
            { LineItemType.EndLineWithVAT, 2 },
            { LineItemType.OtherTaxLineWithVAT, 3 },
            { LineItemType.Giftcard, 6 },
            { LineItemType.ValueWithNegativeSign, 7 }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="MeasurementUnit"/>s to their related <see cref="int"/>s
        /// </summary>
        public static IReadOnlyDictionary<MeasurementUnit, int> MeasurementUnitToIntMapper { get; } = new Dictionary<MeasurementUnit, int>()
        {
            { MeasurementUnit.Pieces, 1 },
            { MeasurementUnit.Kilos, 2 },
            { MeasurementUnit.Liters, 3 },
            { MeasurementUnit.Meters, 4 },
            { MeasurementUnit.SquareMeters, 5 },
            { MeasurementUnit.CubicMeters, 6 },
            { MeasurementUnit.PiecesOtherCases, 7 }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="MovePurpose"/>s to their related <see cref="int"/>s
        /// </summary>
        public static IReadOnlyDictionary<MovePurpose, int> MovePurposeToIntMapper { get; } = new Dictionary<MovePurpose, int>()
        {
            { MovePurpose.Sale, 1 },
            { MovePurpose.SaleForThirdPartyAccount, 2 },
            { MovePurpose.Sampling, 3 },
            { MovePurpose.Exhibition, 4 },
            { MovePurpose.Return, 5 },
            { MovePurpose.Storage, 6 },
            { MovePurpose.ProcessingAssembly, 7 },
            { MovePurpose.BetweenEntityFacilities, 8 },
            { MovePurpose.Purchase, 9 },
            { MovePurpose.SupplyOfShipsAndAircrafts, 10 },
            { MovePurpose.FreeExhibition, 11 },
            { MovePurpose.Warranty, 12 },
            { MovePurpose.Lending, 13 },
            { MovePurpose.StorageToThirdParties, 14 },
            { MovePurpose.ReturnFromStorage, 15 },
            { MovePurpose.Recycling, 16 },
            { MovePurpose.DestructionOfUselessMaterial, 17 },
            { MovePurpose.InternalMovement, 18},
            { MovePurpose.OtherMovements, 19 }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="OtherTaxesPercentageCategory"/>s to their related <see cref="int"/>s
        /// </summary>
        public static IReadOnlyDictionary<OtherTaxPercentageCategory, int> OtherTaxesPercentageCategoryToIntMapper { get; } = new Dictionary<OtherTaxPercentageCategory, int>()
        {
            // Fire insurance premiums
            { OtherTaxPercentageCategory.FireInsurancePremiums20To15Percent, 1 },
            { OtherTaxPercentageCategory.FireInsurancePremiums20To5Percent, 2 },

            // Life insurance premiums
            { OtherTaxPercentageCategory.LifeInsurancePremiums4Percent, 3 },
            { OtherTaxPercentageCategory.OtherInsurancePremiums15Percent, 4 },

            // Premium tax exemptions
            { OtherTaxPercentageCategory.PremiumTaxExemptions0Percent, 5 },

            // Hotels 1 to 4 stars tax
            { OtherTaxPercentageCategory.Hotel1To2Stars0Point50Euro, 6 },
            { OtherTaxPercentageCategory.Hotel3Stars1Point50Euro, 7 },
            { OtherTaxPercentageCategory.Hotel4Stars3Euro, 8 },
            { OtherTaxPercentageCategory.Hotel4Stars4Euro, 9 },
            { OtherTaxPercentageCategory.RoomsToLetFurnishedRoomsApartments0Point50Euro, 10 },

            // Excise tax on advertisements that are shown on television
            { OtherTaxPercentageCategory.EFTV5Percent, 11 },

            // Luxury tax on the taxable person
            { OtherTaxPercentageCategory.LuxuryOnTheTaxableValueForIntraCommunityAcquiredAndImportedFromThirdCountries10Percent, 12 },
            { OtherTaxPercentageCategory.LuxuryOnTheSalePriceBeforeVATForDomesticallyProducedItems10Percent, 13 },

            // State's right to casinos tickets
            { OtherTaxPercentageCategory.PublicRightToCasinoTickets80Percent, 14 },

            // Fire insurance premiums
            { OtherTaxPercentageCategory.FireInsurancePremiums20Percent, 15 },

            // Other taxes
            { OtherTaxPercentageCategory.OtherCustomsDutiesTaxes, 16 },
            { OtherTaxPercentageCategory.OtherTaxes, 17 },
            { OtherTaxPercentageCategory.ChargesOfOtherTaxes, 18 },

            // SCT (Special Consumption Tax)
            { OtherTaxPercentageCategory.EFC, 19 },

            // Added Hotels and Airbnbs
            { OtherTaxPercentageCategory.Hotel1To2Stars1Point50EuroPerRoom, 20 },
            { OtherTaxPercentageCategory.Hotel3Stars3EuroPerRoom, 21 },
            { OtherTaxPercentageCategory.Hotel3Stars7EuroPerRoom, 22 },
            { OtherTaxPercentageCategory.Hotel3Stars10EuroPerRoom, 23 },
            { OtherTaxPercentageCategory.EquipedRentalRoomsAndApartments1Point50EuroPerRoom, 24 },
            { OtherTaxPercentageCategory.ShortTermRentalProperies0Point50Euro, 28 },
            { OtherTaxPercentageCategory.ShortTermRentalProperies1Point50Euro, 25 },
            { OtherTaxPercentageCategory.ShortTermRentalProperies4Euro, 29 },
            { OtherTaxPercentageCategory.ShortTermRentalProperies10Euro, 26 },
            { OtherTaxPercentageCategory.SelfCateringAccommodation4Euro, 30 },
            { OtherTaxPercentageCategory.SelfCateringAccommodation10Euro, 27 }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="PaymentMethod"/>s to their related <see cref="int"/>s
        /// </summary>
        public static IReadOnlyDictionary<PaymentType, int> PaymentMethodToIntMapper { get; } = new Dictionary<PaymentType, int>()
        {
            { PaymentType.BusinessHomePaymentAccount, 1 },
            { PaymentType.BusinessForeignPaymentAccount, 2 },
            { PaymentType.Cash, 3 },
            { PaymentType.Check, 4 },
            { PaymentType.OnCredit, 5 },
            { PaymentType.WebBanking, 6 },
            { PaymentType.POSOrEPOS, 7 }, 
            { PaymentType.IRIS, 8 }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="RecType"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<RecType, string> RecTypeToStringMapper { get; } = new Dictionary<RecType, string>()
        {
            { RecType.Normal, "NORMAL" },
            { RecType.Withheld, "WITHHELD" },
            { RecType.Fee, "FEE" },
            { RecType.OtherTax, "OTHERTAX" },
            { RecType.Stampduty, "STAMPDUTY" },
            { RecType.Deduction, "DEDUCTION" },
            { RecType.Giftcard, "GIFTCARD" },
        }.ToImmutableDictionary();

        public static IReadOnlyDictionary<MeasurementUnit, string> MeasurementUnitToStringMapper { get; } = new Dictionary<MeasurementUnit, string>()
        {
            { MeasurementUnit.Pieces, "Τεμάχια" },
            { MeasurementUnit.Kilos, "Κιλά" },
            { MeasurementUnit.Liters, "Λίτρα" },
            { MeasurementUnit.Meters, "Μέτρα" },
            { MeasurementUnit.SquareMeters, "Τετραγωνικά Μέτρα " },
            { MeasurementUnit.CubicMeters, "Κυβικά Μέτρα" },
            { MeasurementUnit.PiecesOtherCases, "Τεμάχια-Λοιπές Περιπτώσεις " },
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="RecType"/>s to their related <see cref="int"/>s
        /// </summary>
        public static IReadOnlyDictionary<RecType, int> RecTypeToIntMapper { get; } = new Dictionary<RecType, int>()
        {
            { RecType.Normal, 0 },
            { RecType.Withheld, 1 },
            { RecType.Fee, 2 },
            { RecType.OtherTax, 3 },
            { RecType.Stampduty, 4 },
            { RecType.Deduction, 5 },
            { RecType.Giftcard, 6 },
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="SpecialInvoiceCategoryType"/>s to their related <see cref="int"/>s
        /// </summary>
        public static IReadOnlyDictionary<SpecialInvoiceCategoryType, int> SpecialInvoiceCategoryTypeToIntMapper { get; } = new Dictionary<SpecialInvoiceCategoryType, int>()
        {
            { SpecialInvoiceCategoryType.SubsidiesGrants, 1 },
            { SpecialInvoiceCategoryType.HotelRetailRevenueChargesRoom, 2 },
            { SpecialInvoiceCategoryType.AccountingEntry, 3 },
            { SpecialInvoiceCategoryType.TaxFree, 4 },
            { SpecialInvoiceCategoryType.ComplexDomesticTransactions, 5 },
            { SpecialInvoiceCategoryType.BenefiitiariesReferredToArticle3, 6 },
            { SpecialInvoiceCategoryType.PurchaseOfArgicalturalGoods, 7 },
            { SpecialInvoiceCategoryType.RetailRevenuesTemAade1, 8 },
            { SpecialInvoiceCategoryType.RetailRevenuesTemAade2, 9 },
            { SpecialInvoiceCategoryType.BussinessRetailTem, 10 },
            { SpecialInvoiceCategoryType.HeatingVoucher, 11 },
            { SpecialInvoiceCategoryType.FoodServiceTransactions, 12 }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="StampDutyPercentageCategory"/>s to their related <see cref="int"/>s
        /// </summary>
        public static IReadOnlyDictionary<StampDutyPercentageCategory, int> StampDutyPercentageCategoryToIntMapper { get; } = new Dictionary<StampDutyPercentageCategory, int>()
        {
            { StampDutyPercentageCategory.Rate1Point2, 1},
            { StampDutyPercentageCategory.Rate2Point4, 2},
            { StampDutyPercentageCategory.Rate3Point6, 3},
            { StampDutyPercentageCategory.OtherCasesOfStampDuty, 4}
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="TaxType"/>s to their related <see cref="int"/>s
        /// </summary>
        public static IReadOnlyDictionary<TaxType, int> TaxTypeToIntMapper { get; } = new Dictionary<TaxType, int>()
        {
            {TaxType.WithholdingTax, 1},
            {TaxType.Fees, 2},
            {TaxType.OtherTaxes, 3},
            {TaxType.Stamp, 4},
            {TaxType.Reservations, 5}
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="TransmissionFailure"/>s to their related <see cref="int"/>s
        /// </summary>
        public static IReadOnlyDictionary<TransmissionFailure, int> TransmissionFailureToIntMapper { get; } = new Dictionary<TransmissionFailure, int>()
        {
            { TransmissionFailure.ProviderError, 1},
            { TransmissionFailure.MyDataError, 2 },
            { TransmissionFailure.UnableToConnect, 3 },
            { TransmissionFailure.AccessViolation, 4 }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="VATCategory"/>s to their related <see cref="int"/>s
        /// </summary>
        public static IReadOnlyDictionary<VATCategory, int> VATCategoryToIntMapper { get; } = new Dictionary<VATCategory, int>()
        {
            { VATCategory.VATRate24, 1 },
            { VATCategory.VATRate13, 2 },
            { VATCategory.VATRate6, 3 },
            { VATCategory.VATRate17, 4 },
            { VATCategory.VATRate9, 5 },
            { VATCategory.VATRate4, 6 },
            { VATCategory.VATRate3, 7 },
            { VATCategory.ExcludingVAT, 8 },
            { VATCategory.EntriesWithoutVAT, 9 }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="VATExemptionCategory"/>s to their related <see cref="int"/>s
        /// </summary>
        public static IReadOnlyDictionary<VATExemptionCategory, int> VATExemptionCategoryToIntMapper { get; } = new Dictionary<VATExemptionCategory, int>()
        {
            // Articles excluding VAT
            { VATExemptionCategory.Articles2And3, 1 },
            { VATExemptionCategory.Article5, 2 },
            { VATExemptionCategory.Article13, 3 },
            { VATExemptionCategory.Article14, 4 },
            { VATExemptionCategory.Article16, 5 },
            { VATExemptionCategory.Article19, 6 },
            { VATExemptionCategory.Article22, 7 },
            { VATExemptionCategory.Article24, 8 },
            { VATExemptionCategory.Article25, 9 },
            { VATExemptionCategory.Article26, 10 },
            { VATExemptionCategory.Article27, 11 },
            { VATExemptionCategory.Article27ForOpenSeaShips, 12 },
            { VATExemptionCategory.Article27Point1Gamma, 13 },
            { VATExemptionCategory.Article28, 14 },
            { VATExemptionCategory.Article39, 15 },
            { VATExemptionCategory.Article39A, 16 },
            { VATExemptionCategory.Article40, 17 },
            { VATExemptionCategory.Article41, 18 },
            { VATExemptionCategory.Article47, 19 },

            // Article including VAT
            { VATExemptionCategory.Article43IncludingVAT, 20 },
            { VATExemptionCategory.Article44IncludingVAT, 21 },
            { VATExemptionCategory.Article45IncludingVAT, 22 },
            { VATExemptionCategory.Article46IncludingVAT, 23 },

            // Article including VAT
            { VATExemptionCategory.Article6, 24 },

            // Policies excluding VAT
            { VATExemptionCategory.Policy1029_1995, 25 },
            { VATExemptionCategory.Policy1167_2015, 26 },

            // Other VAT exemptions
            { VATExemptionCategory.OtherVATExemptions, 27 },

            // Articles excluding VAT (OSS EU status)
            { VATExemptionCategory.Article24b1, 28 },
            { VATExemptionCategory.Article47b, 29 },
            { VATExemptionCategory.Article47c, 30 },
            { VATExemptionCategory.Article47d, 31 }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="WithholdingTaxCategory"/>s to their related <see cref="int"/>s
        /// </summary>
        public static IReadOnlyDictionary<WithholdingTaxCategory, int> WithholdingTaxCategoryToIntMapper { get; } = new Dictionary<WithholdingTaxCategory, int>()
        {
            // Withholding tax cases
            { WithholdingTaxCategory.CaseBTax15Percent, 1 },
            { WithholdingTaxCategory.CaseCRights20Percent, 2 },
            { WithholdingTaxCategory.CaseDManagementAdviceFees20Percent, 3 },
            { WithholdingTaxCategory.CaseDTechnicalWorks3Percent, 4 },

            // Liquid fuels and tobacco products
            { WithholdingTaxCategory.LiquidFuelsAndTobaccoProducts1Percent, 5 },

            // Other goods
            { WithholdingTaxCategory.OtherGoods4Percent, 6 },

            // Delivery service
            { WithholdingTaxCategory.Services8Percent, 7 },

            // Advanced payments
            { WithholdingTaxCategory.AdvancePayment4Percent, 8 },
            { WithholdingTaxCategory.AdvancePayment10Percent, 9 },
            { WithholdingTaxCategory.AdvancePayment15Percent, 10 },

            // Withholding tax percent
            { WithholdingTaxCategory.WithholdingTaxPercent, 11 },
            { WithholdingTaxCategory.WithholdingTax15Percent, 12 },
            { WithholdingTaxCategory.WithholdingTax10Percent, 13 },

            // Withholding special solidarity contribution
            { WithholdingTaxCategory.WithholdingSpecialSolidarityContribution, 14 },

            // Withholding termination of employment
            { WithholdingTaxCategory.WithholdingTerminationOfEmployment, 15 },

            // Withholding foreign transactions
            { WithholdingTaxCategory.WithholdingForeignTransaction, 16 },

            // Other withholding taxes
            { WithholdingTaxCategory.OtherWithholdingTaxes, 17 },

            // Withholding tax dividends
            { WithholdingTaxCategory.WithholdingTaxDividend, 18 }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="CurrencyCode"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<CurrencyCode, string> CurrencyCodeToStringMapper { get; } = Enum.GetValues<CurrencyCode>().ToImmutableDictionary(x => x, x => x.ToString());
    }
}