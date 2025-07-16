using Atom.NewtonsoftJson;

namespace BratnetProvider
{
    /// <inheritdoc/>
    public class PEPPOLInvoiceTypeCodeToStringJsonConverter : BaseEnumToStringJsonConverter<PEPPOLInvoiceTypeCode>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PEPPOLInvoiceTypeCodeToStringJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<PEPPOLInvoiceTypeCode, string> GetMapper() => BratnetProviderClientConstants.PEPPOLInvoiceTypeCodeToStringMapper;

        #endregion
    }
}
