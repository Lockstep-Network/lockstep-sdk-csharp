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
    /// Contains summarized data for a customer
    /// </summary>
    public class CustomerSummaryModel
    {

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid? GroupKey { get; set; }

        /// <summary>
        /// The unique ID of this company.
        /// </summary>
        public Guid? CompanyId { get; set; }

        /// <summary>
        /// The name of the company.
        /// </summary>
        public string CompanyName { get; set; }

        /// <summary>
        /// The name of the primary contact.
        /// </summary>
        public string PrimaryContact { get; set; }

        /// <summary>
        /// The number of outstanding invoices for this customer.
        /// </summary>
        public int? OutstandingInvoices { get; set; }

        /// <summary>
        /// The number of open invoices.
        /// </summary>
        public int? TotalInvoicesOpen { get; set; }

        /// <summary>
        /// The number of past due invoices.
        /// </summary>
        public int? TotalInvoicesPastDue { get; set; }

        /// <summary>
        /// The number of closed invoices for this customer.
        /// </summary>
        public int? ClosedInvoices { get; set; }

        /// <summary>
        /// The number of closed invoices for this customer in the past thirty days.
        /// </summary>
        public int? ClosedInvoicesPastThirtyDays { get; set; }

        /// <summary>
        /// The total from collected payments.
        /// </summary>
        public decimal? AmountCollected { get; set; }

        /// <summary>
        /// The total from collected payments in the past thirty days.
        /// </summary>
        public decimal? AmountCollectedPastThirtyDays { get; set; }

        /// <summary>
        /// The total balance of outstanding invoices.
        /// </summary>
        public decimal? OutstandingAmount { get; set; }

        /// <summary>
        /// The total amount invoiced in the past thirty days.
        /// </summary>
        public decimal? InvoicedAmountPastThirtyDays { get; set; }

        /// <summary>
        /// The total amount outstanding from the invoices invoiced in the past thirty days.
        /// </summary>
        public decimal? OutstandingAmountPastThirtyDays { get; set; }

        /// <summary>
        /// The number of invoices invoiced in the past thirty days.
        /// </summary>
        public int? InvoicesPastThirtyDays { get; set; }

        /// <summary>
        /// The total amount past due for this customer.
        /// </summary>
        public decimal? AmountPastDue { get; set; }

        /// <summary>
        /// The total value of unapplied Payments for this Customer.
        /// </summary>
        public decimal? UnappliedPayments { get; set; }

        /// <summary>
        /// The total value of unapplied Payments for this Customer in the past thirty days.
        /// </summary>
        public decimal? UnappliedAmountPastThirtyDays { get; set; }

        /// <summary>
        /// Portion of Total AR for this Customer that is Past due. (TotalPastDue / Total AR).
        /// </summary>
        public decimal? PercentOfTotalAr { get; set; }

        /// <summary>
        /// Daily sales outstanding value for this Customer.
        /// </summary>
        public decimal? Dso { get; set; }

        /// <summary>
        /// The date stamp for the newest Activity on this Customer.
        ///
        /// This is a date-only field stored as a string in ISO 8601 (YYYY-MM-DD) format.
        /// </summary>
        public string NewestActivity { get; set; }
    }
}
