using Atom.NewtonsoftJson;

namespace BratnetProvider
{
    /// <inheritdoc/>
    public class ExpenseClassificationCategoryToStringJsonConverter : BaseEnumToStringJsonConverter<ExpenseClassificationCategory>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ExpenseClassificationCategoryToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<ExpenseClassificationCategory, string> GetMapper() => Constants.ExpenseClassificationCategoryToStringMapper;

        #endregion
    }
}

