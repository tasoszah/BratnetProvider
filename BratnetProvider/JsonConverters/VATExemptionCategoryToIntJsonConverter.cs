using Atom.NewtonsoftJson;
using Newtonsoft.Json;

namespace BratnetProvider.JsonConverters
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="VATExemptionCategory"/> to <see cref="string"/>
    /// </summary>
    public class VATExemptionCategoryToIntJsonConverter : BaseEnumToIntJsonConverter<VATExemptionCategory>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public VATExemptionCategoryToIntJsonConverter()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<VATExemptionCategory, int> GetMapper() => Constants.VATExemptionCategoryToIntMapper;

        #endregion
    }
}