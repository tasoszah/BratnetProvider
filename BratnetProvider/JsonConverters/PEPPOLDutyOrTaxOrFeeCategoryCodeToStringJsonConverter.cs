using Atom.NewtonsoftJson;

namespace BratnetProvider
{
    /// <inheritdoc/>
    public class PEPPOLDutyOrTaxOrFeeCategoryCodeToStringJsonConverter : BaseEnumToStringJsonConverter<PEPPOLDutyOrTaxOrFeeCategoryCode>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PEPPOLDutyOrTaxOrFeeCategoryCodeToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<PEPPOLDutyOrTaxOrFeeCategoryCode, string> GetMapper() => Constants.PEPPOLDutyOrTaxOrFeeCategoryCodeToStringMapper;

        #endregion
    }
}
