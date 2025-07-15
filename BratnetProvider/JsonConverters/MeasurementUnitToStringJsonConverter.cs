using Atom.NewtonsoftJson;
using Newtonsoft.Json;

namespace BratnetProvider
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that converts a <see cref="MeasurementUnit"/> to <see cref="string"/>
    /// </summary>
    public class MeasurementUnitToStringJsonConverter : BaseEnumToStringJsonConverter<MeasurementUnit>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public MeasurementUnitToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<MeasurementUnit, string> GetMapper() => BratnetProviderClientConstants.MeasurementUnitToStringMapper;

        #endregion
    }
}
