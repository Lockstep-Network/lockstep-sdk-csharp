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
    /// Aggregated Accounts Payable information.
    /// </summary>
    public class ApHeaderInfoModel
    {

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid? GroupKey { get; set; }

        /// <summary>
        /// The date of the report
        /// </summary>
        public DateTime? ReportDate { get; set; }

        /// <summary>
        /// The total number of vendors.
        /// </summary>
        public int? TotalVendors { get; set; }

        /// <summary>
        /// The total number of bills.
        /// </summary>
        public int? TotalBills { get; set; }

        /// <summary>
        /// The total amount billed.
        /// </summary>
        public decimal? TotalBilledAmount { get; set; }

        /// <summary>
        /// The total number of advance payments.
        /// </summary>
        public decimal? TotalAdvancePayments { get; set; }

        /// <summary>
        /// The total amount paid.
        /// </summary>
        public decimal? TotalPaid { get; set; }

        /// <summary>
        /// The total accounts payable amount.
        /// </summary>
        public decimal? TotalApAmount { get; set; }

        /// <summary>
        /// The number of paid bills.
        /// </summary>
        public int? TotalBillsPaid { get; set; }

        /// <summary>
        /// The number of past due bills.
        /// </summary>
        public int? TotalBillsPastDue { get; set; }

        /// <summary>
        /// The number of bills 90+ days past due.
        /// </summary>
        public int? TotalBills90DaysPastDue { get; set; }

        /// <summary>
        /// The total amount past due.
        /// </summary>
        public decimal? TotalPastDueAmount { get; set; }

        /// <summary>
        /// The total amount for bills 90+ days past due.
        /// </summary>
        public decimal? TotalPastDueAmount90Days { get; set; }

        /// <summary>
        /// Portion of Total AP that is Past due.
        /// </summary>
        public decimal? PercentageOfTotalAp { get; set; }

        /// <summary>
        /// The total amount billed, due this year.
        /// </summary>
        public decimal? TotalBilledAmountCurrentYear { get; set; }

        /// <summary>
        /// The total amount billed, due last year.
        /// </summary>
        public decimal? TotalBilledAmountPreviousYear { get; set; }

        /// <summary>
        /// The total of all payments made this year.
        /// </summary>
        public decimal? TotalPaidAmountCurrentYear { get; set; }

        /// <summary>
        /// Portion of Total AP that is 90+ days Past due.
        /// </summary>
        public decimal? PercentageOfTotalAp90DaysPastDue { get; set; }

        /// <summary>
        /// The number of vendors who were paid within the past thirty days.
        /// </summary>
        public int? VendorsPaidPastThirtyDays { get; set; }

        /// <summary>
        /// The total amount paid over the past thirty days.
        /// </summary>
        public decimal? AmountPaidPastThirtyDays { get; set; }

        /// <summary>
        /// The amount in advance from the payments made over the past thirty days.
        /// </summary>
        public decimal? AdvancePaymentAmountPastThirtyDays { get; set; }

        /// <summary>
        /// The number of bills paid over the past thirty days.
        /// </summary>
        public int? BillsPaidPastThirtyDays { get; set; }

        /// <summary>
        /// The number of vendors that sent bills over the the past thirty days.
        /// </summary>
        public int? BillingVendorsPastThirtyDays { get; set; }

        /// <summary>
        /// The total amount billed over the past thirty days.
        /// </summary>
        public decimal? AmountBilledPastThirtyDays { get; set; }

        /// <summary>
        /// The amount outstanding on the bills received over the past thirty days.
        /// </summary>
        public decimal? AmountDuePastThirtyDays { get; set; }

        /// <summary>
        /// The number of bills received over the past thirty days.
        /// </summary>
        public int? BillsPastThirtyDays { get; set; }
    }
}
