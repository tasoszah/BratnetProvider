using Atom.NewtonsoftJson;
using Newtonsoft.Json;

namespace BratnetProvider
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> that converts a <see cref="TransmissionFailure"/> to <see cref="int"/>
    /// </summary>
    public class TransmissionFailureToIntJsonConverter : BaseEnumToIntJsonConverter<TransmissionFailure>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public TransmissionFailureToIntJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<TransmissionFailure, int> GetMapper() => Constants.TransmissionFailureToIntMapper;

        #endregion
    }
}
