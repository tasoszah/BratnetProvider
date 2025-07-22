using Atom.Web;

namespace BratnetProvider
{
    /// <summary>
    /// A normalized (kinda acceptable) version of the <see cref="InvoiceDetailRequestModel"/>
    /// </summary>
    public class NormalizedInvoiceDetailRequestModel : BaseRequestModel
    {
        #region Public Properties

        /// <inheritdoc cref="InvoiceDetailRequestModel.Name"/>
        public string? Name { get; set; }

        /// <inheritdoc cref="InvoiceDetailRequestModel.Code"/>
        public string? Code { get; set; }

        /// <inheritdoc cref="InvoiceDetailRequestModel.LineNumber"/>
        public int? LineNumber { get; set; }

        /// <inheritdoc cref="InvoiceDetailRequestModel.Quantity"/>
        public int? Quantity { get; set; }

        /// <inheritdoc cref="InvoiceDetailRequestModel.MeasurementUnit"/>
        public MeasurementUnit? MeasurementUnit { get; set; }

        /// <inheritdoc cref="InvoiceDetailRequestModel.NetValueBeforeDiscount"/>
        public decimal? NetValueBeforeDiscount { get; set; }

        /// <inheritdoc cref="InvoiceDetailRequestModel.NetValue"/>
        public decimal? NetValue { get; set; }

        /// <inheritdoc cref="InvoiceDetailRequestModel.VATAmount"/>
        public decimal? VATAmount { get; set; }

        /// <inheritdoc cref="InvoiceDetailRequestModel.VATCategory"/>
        public VATCategory? VATCategory { get; set; }

        /// <inheritdoc cref="InvoiceDetailRequestModel.ExpenseClassificationType"/>
        public ExpenseClassificationType? ExpenseClassificationType { get; set; }

        /// <inheritdoc cref="InvoiceDetailRequestModel.ExpenseClassificationCategory"/>
        public ExpenseClassificationCategory? ExpenseClassificationCategory { get; set; }

        /// <inheritdoc cref="InvoiceDetailRequestModel.Price"/>
        public decimal? Price { get; set; }

        /// <inheritdoc cref="InvoiceDetailRequestModel.VATPercent"/>
        public int? VATPercent { get; set; }

        /// <inheritdoc cref="InvoiceDetailRequestModel.PriceIncludeVAT"/>
        public decimal? PriceIncludeVAT { get; set; }

        /// <inheritdoc cref="InvoiceDetailRequestModel.ItemDescription"/>
        public string? ItemDescription { get; set; }

        /// <inheritdoc cref="InvoiceDetailRequestModel.TaricNumber"/>
        public string? TaricNumber { get; set; }

        /// <inheritdoc cref="InvoiceDetailRequestModel.ItemCode"/>
        public string? ItemCode { get; set; }

        /// <summary>
        /// The category
        /// </summary>
        public IncomeClassificationCategory? IncomeClassificationCategory { get; set; }

        /// <summary>
        /// The type
        /// </summary>
        public IncomeClassificationType? IncomeClassificationType { get; set; }

        /// <inheritdoc cref="InvoiceDetailRequestModel.HasDiscountOption"/>
        public bool? HasDiscountOption { get; set; }

        /// <inheritdoc cref="InvoiceDetailRequestModel.VATExemptionCategory"/>
        public VATExemptionCategory? VATExemptionCategory { get; set; }

        /// <summary>
        /// The UBL VAT category
        /// </summary>
        public PEPPOLDutyOrTaxOrFeeCategoryCode? PEPPOLVATCategory { get; set; }

        /// <summary>
        /// The UBL measurement unit
        /// </summary>
        public PEPPOLRecommendationCode? PEPPOLMeasurementUnit { get; set; }

        /// <inheritdoc cref="InvoiceDetailRequestModel.PEPPOLCpvCode"/>
        public string? PEPPOLCpvCode { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public NormalizedInvoiceDetailRequestModel() : base()
        {

        }

        #endregion

        #region Public Methods

        public InvoiceDetailRequestModel ToInvoiceDetailRequestModel()
        {
            var result = new InvoiceDetailRequestModel
            {
                Code = Code,
                HasDiscountOption = HasDiscountOption,
                ItemCode = ItemCode,
                ItemDescription = ItemDescription,
                LineNumber = LineNumber,
                MeasurementUnit = MeasurementUnit,
                MeasurementUnitName = MeasurementUnit is null ? null : Constants.MeasurementUnitToStringMapper[MeasurementUnit.Value],
                Name = Name,
                NetValue = NetValue,
                NetValueBeforeDiscount = NetValueBeforeDiscount,
                PEPPOLCpvCode = PEPPOLCpvCode,
                PEPPOLMeasurementUnit = PEPPOLMeasurementUnit,
                PEPPOLVATCategory = PEPPOLVATCategory,
                Price = Price,
                PriceIncludeVAT = PriceIncludeVAT,
                Quantity = Quantity,
                TaricNumber = TaricNumber,
                VATAmount = VATAmount,
                VATCategory = VATCategory,
                VATExemptionCategory = VATExemptionCategory,
                VATPercent = VATPercent,
                 
            };

            // TODO: Check if income classifications should be set if non type or category is specified!
            if (IncomeClassificationCategory is not null || IncomeClassificationType is not null) 
            {
                result.IncomeClassifications = new List<IncomeClassificationRequestModel>()
                {
                    new IncomeClassificationRequestModel()
                    {
                        Category = IncomeClassificationCategory,
                        Type = IncomeClassificationType,
                        Amount = NetValue + VATAmount
                    }
                };
            }

            if (ExpenseClassificationCategory is not null || ExpenseClassificationType is not null)
            {
                result.ExpenseClassifications = new List<ExpenseClassificationRequestModel>()
                {
                    new ExpenseClassificationRequestModel()
                    {
                        Category = ExpenseClassificationCategory,
                        Type = ExpenseClassificationType,
                        Amount = NetValue + VATAmount
                    }
                };
            }

             return result;
        }

        #endregion
    }
}
