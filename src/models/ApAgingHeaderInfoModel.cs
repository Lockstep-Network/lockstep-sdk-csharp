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

namespace LockstepSDK.Models
{

    /// <summary>
    /// Aggregated Accounts Payable Aging information.
    /// </summary>
    public class ApAgingHeaderInfoModel
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
        /// The total number of vendors.
        /// </summary>
        public int? TotalVendors { get; set; }

        /// <summary>
        /// The total number of bills outstanding.
        /// </summary>
        public int? TotalBillsOutstanding { get; set; }

        /// <summary>
        /// The total amount outstanding on bills.
        /// </summary>
        public decimal? TotalBillsOutstandingAmount { get; set; }

        /// <summary>
        /// The total amount outstanding on credit memos.
        /// </summary>
        public decimal? TotalCreditMemoOutstandingAmount { get; set; }

        /// <summary>
        /// The total amount of advance payments.
        /// </summary>
        public decimal? TotalAdvancePaymentAmount { get; set; }

        /// <summary>
        /// The total amount outstanding.
        /// </summary>
        public decimal? TotalOutstandingAmount { get; set; }

        /// <summary>
        /// The total amount for AP.
        /// </summary>
        public decimal? TotalApAmount { get; set; }

        /// <summary>
        /// Portion of Total AP this data represents.
        /// </summary>
        public decimal? PercentageOfTotalAp { get; set; }
    }
}
