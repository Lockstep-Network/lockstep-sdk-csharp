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
    /// Aggregated Accounts Receivable information.
    /// </summary>
    public class ArHeaderInfoModel
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
        ///
        /// This is a date-only field stored as a string in ISO 8601 (YYYY-MM-DD) format.
        /// </summary>
        public string ReportPeriod { get; set; }

        /// <summary>
        /// The total number of customers.
        /// </summary>
        public int? TotalCustomers { get; set; }

        /// <summary>
        /// The total number of invoices.
        /// </summary>
        public int? TotalInvoices { get; set; }

        /// <summary>
        /// The total amount invoiced.
        /// </summary>
        public decimal? TotalInvoicedAmount { get; set; }

        /// <summary>
        /// The total number of unapplied payments.
        /// </summary>
        public decimal? TotalUnappliedPayments { get; set; }

        /// <summary>
        /// The total amount of collected payments.
        /// </summary>
        public decimal? TotalCollected { get; set; }

        /// <summary>
        /// The total accounts receivable amount.
        /// </summary>
        public decimal? TotalArAmount { get; set; }

        /// <summary>
        /// The number of paid invoices.
        /// </summary>
        public int? TotalInvoicesPaid { get; set; }

        /// <summary>
        /// The number of past due invoices.
        /// </summary>
        public int? TotalInvoicesPastDue { get; set; }

        /// <summary>
        /// The number of past due invoices for the last 90 days.
        /// </summary>
        public int? TotalInvoices90DaysPastDue { get; set; }

        /// <summary>
        /// The total amount past due.
        /// </summary>
        public decimal? TotalPastDueAmount { get; set; }

        /// <summary>
        /// The total past due for the past 90 days.
        /// </summary>
        public decimal? TotalPastDueAmount90Days { get; set; }

        /// <summary>
        /// Portion of Total AR that is Past due.
        /// </summary>
        public decimal? PercentageOfTotalAr { get; set; }

        /// <summary>
        /// Daily sales outstanding.
        /// </summary>
        public decimal? Dso { get; set; }

        /// <summary>
        /// The total amount invoiced, due this year.
        /// </summary>
        public decimal? TotalInvoiceAmountCurrentYear { get; set; }

        /// <summary>
        /// The total amount invoiced, due last year.
        /// </summary>
        public decimal? TotalInvoiceAmountPreviousYear { get; set; }

        /// <summary>
        /// The total of all payments received this year.
        /// </summary>
        public decimal? TotalPaymentAmountCurrentYear { get; set; }

        /// <summary>
        /// The total amount of payments received in the last 30 days
        /// </summary>
        public int? TotalCollectedPastThirtyDays { get; set; }

        /// <summary>
        /// The total amount of Invoices paid in the last 30 days
        /// </summary>
        public int? TotalInvoicesPaidPastThirtyDays { get; set; }

        /// <summary>
        /// Portion of Total AR that is 90+ days Past due.
        /// </summary>
        public decimal? PercentageOfTotalAr90DaysPastDue { get; set; }
    }
}
