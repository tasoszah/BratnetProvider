using Atom.NewtonsoftJson;

namespace BratnetProvider
{
    /// <inheritdoc/>
    public class PEPPOLRecommendationCodeToStringJsonConverter : BaseEnumToStringJsonConverter<PEPPOLRecommendationCode>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PEPPOLRecommendationCodeToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<PEPPOLRecommendationCode, string> GetMapper() => Constants.PEPPOLRecommendationCodeToStringMapper;

        #endregion
    }
}
