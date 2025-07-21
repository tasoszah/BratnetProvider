using Atom.NewtonsoftJson;

namespace BratnetProvider
{
    /// <inheritdoc/>
    public class PEPPOLAllowanceReasonCodeToStringJsonConverter : BaseEnumToStringJsonConverter<PEPPOLAllowanceReasonCode>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PEPPOLAllowanceReasonCodeToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<PEPPOLAllowanceReasonCode, string> GetMapper() => Constants.PEPPOLAllowanceReasonCodeToStringMapper;

        #endregion
    }
}
