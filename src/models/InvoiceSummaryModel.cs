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
    /// Contains summarized data for an invoice
    /// </summary>
    public class InvoiceSummaryModel
    {

        /// <summary>
        /// The GroupKey uniquely identifies a single ADS Platform account.  All records for this
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
        /// The date when the invoice was closed and finalized after completion of all payments and delivery of all products and
        /// services.
        ///
        /// This is a date-only field stored as a string in ISO 8601 (YYYY-MM-DD) format.
        /// </summary>
        public string InvoiceClosedDate { get; set; }

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
        /// The currency code for the invoice.
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
        /// The group&#39;s base currency code.
        /// </summary>
        public string BaseCurrencyCode { get; set; }

        /// <summary>
        /// The invoice amount in the group&#39;s base currency
        /// </summary>
        public decimal? BaseCurrencyInvoiceAmount { get; set; }

        /// <summary>
        /// The outstanding balance amount in the group&#39;s base currency
        /// </summary>
        public decimal? BaseCurrencyOutstandingBalance { get; set; }

        /// <summary>
        /// A code identifying the type of this Invoice.
        /// </summary>
        public string InvoiceTypeCode { get; set; }

        /// <summary>
        /// The date stamp for the newest Activity on this Invoice.
        ///
        /// This is a date-only field stored as a string in ISO 8601 (YYYY-MM-DD) format.
        /// </summary>
        [Obsolete("This field is deprecated.")]
        public string NewestActivity { get; set; }

        /// <summary>
        /// The number of days this Invoice is past due.
        /// </summary>
        [Obsolete("This field is deprecated.")]
        public int? DaysPastDue { get; set; }

        /// <summary>
        /// The number of payments associated to this invoice.
        /// </summary>
        [Obsolete("This field is deprecated.")]
        public int? PaymentCount { get; set; }

        /// <summary>
        /// Specific invoices have support for pdf retrieval from their respective erp. When this flag is true, an additional
        /// call to Invoices/{id}/pdf can be made to retrieve a pdf directly from the erp.
        /// </summary>
        public bool? SupportsErpPdfRetrieval { get; set; }

        /// <summary>
        /// The memo text of the payments associated to this invoice.
        /// </summary>
        public string[] PaymentNumbers { get; set; }

        /// <summary>
        /// The ids of the payments associated to this invoice.
        /// </summary>
        public Guid[] PaymentIds { get; set; }

        /// <summary>
        /// The modified date of the invoice.
        /// </summary>
        public DateTime? Modified { get; set; }
    }
}
