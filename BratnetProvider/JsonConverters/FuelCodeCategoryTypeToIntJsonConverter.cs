using Atom.NewtonsoftJson;
using Newtonsoft.Json;

namespace BratnetProvider
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="FuelCodeCategoryType"/> to <see cref="int"/> 
    /// </summary>
    public class FuelCodeCategoryTypeToIntJsonConverter : BaseEnumToIntJsonConverter<FuelCodeCategory>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public FuelCodeCategoryTypeToIntJsonConverter()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<FuelCodeCategory, int> GetMapper() => Constants.FuelCodeCategoryTypeToIntMapper;

        #endregion
    }
}
