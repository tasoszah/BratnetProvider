using Atom.NewtonsoftJson;

namespace BratnetProvider
{
    /// <inheritdoc/>
    public class BudgetTypeToIntJsonConverter : BaseEnumToIntJsonConverter<BudgetType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public BudgetTypeToIntJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<BudgetType, int> GetMapper() => Constants.BudgetTypeToIntMapper;

        #endregion
    }
}