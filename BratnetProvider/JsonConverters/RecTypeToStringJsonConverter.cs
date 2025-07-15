using Atom.NewtonsoftJson;
using Newtonsoft.Json;

namespace BratnetProvider
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that converts a <see cref="RecType"/> to <see cref="string"/>
    /// </summary>
    public class RecTypeToStringJsonConverter : BaseEnumToStringJsonConverter<RecType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public RecTypeToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<RecType, string> GetMapper() => BratnetProviderClientConstants.RecTypeToStringMapper;

        #endregion
    }
}
