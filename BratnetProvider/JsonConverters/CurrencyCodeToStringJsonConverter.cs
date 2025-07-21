using Atom;
using Atom.NewtonsoftJson;

namespace BratnetProvider
{
    /// <inheritdoc/>
    public class CurrencyCodeToStringJsonConverter : BaseEnumToStringJsonConverter<CurrencyCode>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public CurrencyCodeToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<CurrencyCode, string> GetMapper() => Constants.CurrencyCodeToStringMapper;

        #endregion
    }
}
