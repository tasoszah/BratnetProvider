using Atom.NewtonsoftJson;

namespace BratnetProvider
{
    /// <inheritdoc/>
    public class IncomeClassificationCategoryToStringJsonConverter : BaseEnumToStringJsonConverter<IncomeClassificationCategory>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public IncomeClassificationCategoryToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<IncomeClassificationCategory, string> GetMapper() => Constants.IncomeClassificationCategoryToStringMapper;

        #endregion
    }
}
