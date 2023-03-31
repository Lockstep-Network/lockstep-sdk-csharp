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
    /// Contains summarized data for an invoice
    /// </summary>
    public class AtRiskInvoiceSummaryModel
    {

        /// <summary>
        /// The date of the report
        ///
        /// This is a date-only field stored as a string in ISO 8601 (YYYY-MM-DD) format.
        /// </summary>
        public string ReportDate { get; set; }

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid? GroupKey { get; set; }

        /// <summary>
        /// The ID number of the counterparty for the invoice, for example, a customer or vendor.
        /// </summary>
        public Guid? CustomerId { get; set; }

        /// <summary>
        /// The unique ID number of this invoice.
        /// </summary>
        public Guid? InvoiceId { get; set; }

        /// <summary>
        /// A reference code that is used to identify this invoice.
        /// The meaning of this field is specific to the ERP or accounting system used by the user.
        /// </summary>
        public string InvoiceNumber { get; set; }

        /// <summary>
        /// The reporting date for this invoice.
        ///
        /// This is a date-only field stored as a string in ISO 8601 (YYYY-MM-DD) format.
        /// </summary>
        public string InvoiceDate { get; set; }

        /// <summary>
        /// The name of the counterparty for the invoice, for example, a customer or vendor.
        /// </summary>
        public string CustomerName { get; set; }

        /// <summary>
        /// The status of the invoice.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// The due date of the invoice.
        ///
        /// This is a date-only field stored as a string in ISO 8601 (YYYY-MM-DD) format.
        /// </summary>
        public string PaymentDueDate { get; set; }

        /// <summary>
        /// The currency code of the invoice
        /// </summary>
        public string CurrencyCode { get; set; }

        /// <summary>
        /// The total amount of the Invoice.
        /// </summary>
        public decimal? InvoiceAmount { get; set; }

        /// <summary>
        /// The remaining balance value of this invoice.
        /// </summary>
        public decimal? OutstandingBalance { get; set; }

        /// <summary>
        /// The currency code of the group.
        /// </summary>
        public string BaseCurrencyCode { get; set; }

        /// <summary>
        /// The total amount of the Invoice in the group&#39;s currency.
        /// </summary>
        public decimal? BaseCurrencyInvoiceAmount { get; set; }

        /// <summary>
        /// The remaining balance value of this invoice in the group&#39;s currency.
        /// </summary>
        public decimal? BaseCurrencyOutstandingBalance { get; set; }

        /// <summary>
        /// A code identifying the type of this Invoice.
        /// </summary>
        public string InvoiceTypeCode { get; set; }

        /// <summary>
        /// The number of days this Invoice is past due.
        /// </summary>
        public int? DaysPastDue { get; set; }

        /// <summary>
        /// The memo text of the payments associated to this invoice.
        /// </summary>
        public string[] PaymentNumbers { get; set; }

        /// <summary>
        /// The ids of the payments associated to this invoice.
        /// </summary>
        public Guid[] PaymentIds { get; set; }
    }
}
