using Atom.NewtonsoftJson;
using Newtonsoft.Json;

namespace BratnetProvider
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that converts a <see cref="RecType"/> to <see cref="int"/>
    /// </summary>
    public class RecTypeToIntJsonConverter : BaseEnumToIntJsonConverter<RecType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public RecTypeToIntJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<RecType, int> GetMapper() => BratnetProviderClientConstants.RecTypeToIntMapper;

        #endregion
    }
}
