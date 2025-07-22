using Atom.NewtonsoftJson;

namespace BratnetProvider
{
    /// <inheritdoc/>
    public class IncomeClassificationTypeToStringJsonConverter : BaseEnumToStringJsonConverter<IncomeClassificationType>
    {
        #region Constructors
        
        /// <summary>
        /// Default constructor
        /// </summary>
        public IncomeClassificationTypeToStringJsonConverter() : base()
        {
        }
        
        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<IncomeClassificationType, string> GetMapper() => Constants.IncomeClassificationTypeToStringMapper;

        #endregion
    }
}
