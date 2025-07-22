using Atom.NewtonsoftJson;

namespace BratnetProvider
{
    /// <inheritdoc/>
    public class ExpenseClassificationTypeToStringJsonConverter : BaseEnumToStringJsonConverter<ExpenseClassificationType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ExpenseClassificationTypeToStringJsonConverter() : base()
        {
        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<ExpenseClassificationType, string> GetMapper() => Constants.ExpenseClassificationTypeToStringMapper;

        #endregion
    }
}
