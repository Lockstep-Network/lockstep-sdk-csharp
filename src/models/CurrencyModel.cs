/***
 * Lockstep Platform SDK for C#
 *
 * (c) 2021-2022 Lockstep, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author     Lockstep Network <support@lockstep.io>
 * @copyright  2021-2022 Lockstep, Inc.
 * @link       https://github.com/Lockstep-Network/lockstep-sdk-csharp
 */



#pragma warning disable CS8618

using System;

namespace LockstepSDK
{

    /// <summary>
    /// Represents an ISO-4217 currency code definition
    /// </summary>
    public class CurrencyModel
    {

        /// <summary>
        /// Alphabetic code for the given currency
        /// </summary>
        public string AlphaCode { get; set; }

        /// <summary>
        /// Numeric code for the given currency
        /// </summary>
        public string NumericCode { get; set; }

        /// <summary>
        /// Name of currency
        /// </summary>
        public string CurrencyName { get; set; }

        /// <summary>
        /// Number of places after the decimal for this currency
        /// </summary>
        public int? MinorUnit { get; set; }

        /// <summary>
        /// Symbol for the given currency
        /// </summary>
        public string Symbol { get; set; }
    }
}
