/***
 * Lockstep Platform SDK for C#
 *
 * (c) 2021-2023 Lockstep, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author     Lockstep Network <support@lockstep.io>
 * @copyright  2021-2023 Lockstep, Inc.
 * @link       https://github.com/Lockstep-Network/lockstep-sdk-csharp
 */



#pragma warning disable CS8618

using System;

namespace LockstepSDK.Models
{

    /// <summary>
    /// Represents a currency rate for specific currencies and date
    /// </summary>
    public class CurrencyRateModel
    {

        /// <summary>
        /// The source currency
        /// </summary>
        public string SourceCurrency { get; set; }

        /// <summary>
        /// The destination currency
        /// </summary>
        public string DestinationCurrency { get; set; }

        /// <summary>
        /// The date for the currency rate
        ///
        /// This is a date-only field stored as a string in ISO 8601 (YYYY-MM-DD) format.
        /// </summary>
        public string Date { get; set; }

        /// <summary>
        /// The currency rate value
        /// </summary>
        public decimal? CurrencyRate { get; set; }
    }
}
