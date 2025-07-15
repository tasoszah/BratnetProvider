using Atom.Web;
using Newtonsoft.Json;

namespace BratnetProvider
{
    /// <summary>
    /// Represents a request model for B2G buyer reference information.
    /// </summary>
    public class B2GBuyerReferenceRequestModel : BaseRequestModel
    {
        #region Public Properties

        /// <summary>
        /// Name or code of the receiving department
        /// </summary>
        /// <example>EDAPY-580999-2024000001</example>
        [JsonProperty("orgUnitName")]
        public string? OrganizationUnitName { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public B2GBuyerReferenceRequestModel() : base()
        {

        }

        #endregion
    }
}
