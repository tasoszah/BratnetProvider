using Atom;
using Newtonsoft.Json;

namespace BratnetProvider
{
    /// <summary>
    /// Represents a wrapper for a set of <see cref="Responses"/>
    /// </summary>
    /// <typeparam name="T">The type of the response models</typeparam>
    public class ResponsesWrapperResponseModel<T>
        where T : notnull
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Responses"/> property
        /// </summary>
        private IEnumerable<T>? mResponses;

        #endregion

        #region Public Properties

        /// <summary>
        /// The responses
        /// </summary>
        [JsonProperty("responses")]
        public IEnumerable<T> Responses
        {
            get => mResponses ?? Enumerable.Empty<T>();

            set => mResponses = value;
        }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("createdAt")]
        public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("updatedAt")]
        public DateTimeOffset UpdatedAt { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ResponsesWrapperResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString()
        {
            var items = new List<string>();

            foreach(var item in Responses)
            {
                var s = item.ToString();

                if (!s.IsNullOrEmpty())
                    items.Add(s);
            }

            if (items.IsNullOrEmpty())
                return "No responses";

            return string.Join(", ", items);
        }

        #endregion
    }
}
