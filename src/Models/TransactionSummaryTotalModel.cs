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
    /// Represents transaction summary information based on the query request within the group account.
    /// </summary>
    public class TransactionSummaryTotalModel
    {

        /// <summary>
        /// Total count of all transactions from the query request.
        /// </summary>
        public int? TotalCount { get; set; }

        /// <summary>
        /// Total value of all transactions from the query request.
        /// </summary>
        public decimal? TotalAmount { get; set; }

        /// <summary>
        /// Total outstanding amount value of all transactions from the query request.
        /// </summary>
        public decimal? OutstandingAmount { get; set; }

        /// <summary>
        /// Total open invoice count from the query request.
        /// </summary>
        public int? InvoiceOpenCount { get; set; }

        /// <summary>
        /// Total past due invoice count from the query request.
        /// </summary>
        public int? InvoicePastDueCount { get; set; }
    }
}
