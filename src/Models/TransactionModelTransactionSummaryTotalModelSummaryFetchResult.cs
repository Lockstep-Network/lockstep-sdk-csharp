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

    public class TransactionModelTransactionSummaryTotalModelSummaryFetchResult
    {

        public int? TotalCount { get; set; }

        public int? PageSize { get; set; }

        public int? PageNumber { get; set; }

        public TransactionModel[] Records { get; set; }

        /// <summary>
        /// Represents transaction summary information based on the query request within the group account.
        /// </summary>
        public TransactionSummaryTotalModel Summary { get; set; }

        public SummaryAgingTotalsModel[] AgingSummary { get; set; }

        public TransactionCurrencySummaryModel[] CurrencySummaries { get; set; }
    }
}
