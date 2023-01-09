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
    /// Aggregated Accounts Receivable Aging information.
    /// </summary>
    public class ArAgingHeaderInfoModel
    {

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid? GroupKey { get; set; }

        /// <summary>
        /// The aging bucket this data belongs to.
        /// </summary>
        public string ReportBucket { get; set; }

        /// <summary>
        /// The total number of customers.
        /// </summary>
        public int? TotalCustomers { get; set; }

        /// <summary>
        /// The total number of invoices outstanding.
        /// </summary>
        public int? TotalInvoicesOutstanding { get; set; }

        /// <summary>
        /// The total amount outstanding on invoices.
        /// </summary>
        public decimal? TotalInvoiceOutstandingAmount { get; set; }

        /// <summary>
        /// The total amount outstanding on credit memos.
        /// </summary>
        public decimal? TotalCreditMemoOutstandingAmount { get; set; }

        /// <summary>
        /// The total amount of unapplied payments.
        /// </summary>
        public decimal? TotalUnappliedPaymentAmount { get; set; }

        /// <summary>
        /// The total amount outstanding.
        /// </summary>
        public decimal? TotalOutstandingAmount { get; set; }

        /// <summary>
        /// The total amount for AR.
        /// </summary>
        public decimal? TotalArAmount { get; set; }

        /// <summary>
        /// Portion of Total AR this data represents.
        /// </summary>
        public decimal? PercentageOfTotalAr { get; set; }
    }
}
