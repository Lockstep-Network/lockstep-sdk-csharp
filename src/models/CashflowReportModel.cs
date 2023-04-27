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
    /// Represents the cashflow report based on a timeframe
    /// </summary>
    public class CashflowReportModel
    {

        /// <summary>
        /// Timeframe in days the cashflow report is generated on
        /// </summary>
        public int? Timeframe { get; set; }

        /// <summary>
        /// The base currency code of the group.
        /// </summary>
        public string BaseCurrencyCode { get; set; }

        /// <summary>
        /// Amount of payments collected based in the timeframe in the group&#39;s base currency
        /// </summary>
        public decimal? PaymentsCollected { get; set; }

        /// <summary>
        /// Number of payments collected based in the timeframe
        /// </summary>
        public int? PaymentsCollectedCount { get; set; }

        /// <summary>
        /// Amount of invoices billed based in the timeframe in the group&#39;s base currency
        /// </summary>
        public decimal? InvoicesBilled { get; set; }

        /// <summary>
        /// Number of invoices billed in the timeframe
        /// </summary>
        public int? InvoicesBilledCount { get; set; }
    }
}
