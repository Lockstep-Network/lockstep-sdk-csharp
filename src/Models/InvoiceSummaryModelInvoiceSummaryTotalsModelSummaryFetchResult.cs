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

    public class InvoiceSummaryModelInvoiceSummaryTotalsModelSummaryFetchResult
    {

        public InvoiceSummaryModel[] Records { get; set; }

        public int? TotalCount { get; set; }

        public int? PageSize { get; set; }

        public int? PageNumber { get; set; }

        /// <summary>
        /// The totals for an Invoice Summary
        /// </summary>
        public InvoiceSummaryTotalsModel Summary { get; set; }

        public SummaryAgingTotalsModel[] AgingSummary { get; set; }
    }
}
