using Atom.NewtonsoftJson;

namespace BratnetProvider
{
    /// <inheritdoc/>
    public class PEPPOLVATExemptionCodeToStringJsonConverter : BaseEnumToStringJsonConverter<PEPPOLVATExemptionCode>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PEPPOLVATExemptionCodeToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<PEPPOLVATExemptionCode, string> GetMapper() => BratnetProviderClientConstants.PEPPOLVATExemptionCodeToStringMapper;

        #endregion
    }
}
