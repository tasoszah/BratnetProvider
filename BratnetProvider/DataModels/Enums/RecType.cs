using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BratnetProvider
{
    /// <summary>
    /// Provides enumeration over the rec types
    /// </summary>
    public enum RecType
    {
        /// <summary>
        /// Usual detail line
        /// </summary>
        Normal = 0,

        /// <summary>
        /// Line contains information about withheld taxes
        /// </summary>
        Withheld = 1,

        /// <summary>
        /// Line contains information about fees
        /// </summary>
        Fee = 2,

        /// <summary>
        /// Line contains information about other taxes
        /// </summary>
        OtherTax = 3,

        /// <summary>
        /// Line contains information about stamp duties
        /// </summary>
        Stampduty = 4,

        /// <summary>
        /// Line contains information about deductions
        /// </summary>
        Deduction = 5,

        /// <summary>
        /// Line contains information about giftcards
        /// </summary>
        Giftcard = 6
    }
}
