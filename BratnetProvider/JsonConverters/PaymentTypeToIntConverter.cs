using Atom.NewtonsoftJson;
using Newtonsoft.Json;

namespace BratnetProvider
{
    /// <summary>
    /// The <see cref="JsonConverter{T}"/> that converts a <see cref="PaymentType"/> to <see cref="int"/>
    /// </summary>
    public class PaymentTypeToIntConverter : BaseEnumToIntJsonConverter<PaymentType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PaymentTypeToIntConverter()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<PaymentType, int> GetMapper() => Constants.PaymentMethodToIntMapper;

        #endregion
    }
}
