/***
 * Lockstep Platform SDK for C#
 *
 * (c) 2021-2025 Lockstep, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author     Lockstep Network <support@lockstep.io>
 * @copyright  2021-2025 Lockstep, Inc.
 * @link       https://github.com/Lockstep-Network/lockstep-sdk-csharp
 */



#pragma warning disable CS8618

using System;

namespace LockstepSDK.Models
{

    /// <summary>
    /// Represents transaction summary information based on the query request within the group account, grouped by currency.
    /// </summary>
    public class TransactionCurrencySummaryModel
    {

        /// <summary>
        /// The currency code for the summary.
        /// </summary>
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Total value of all transactions from the query request for the specified currency.
        /// </summary>
        public decimal? TotalAmount { get; set; }

        /// <summary>
        /// Total outstanding amount value of all transactions from the query request for the specified currency.
        /// </summary>
        public decimal? OutstandingAmount { get; set; }
    }
}
