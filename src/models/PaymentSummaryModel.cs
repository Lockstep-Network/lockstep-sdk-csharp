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
    /// Contains summary information for a Payment
    /// </summary>
    public class PaymentSummaryModel
    {

        /// <summary>
        /// The GroupKey uniquely identifies a single ADS Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid? GroupKey { get; set; }

        /// <summary>
        /// The id of the payment
        /// </summary>
        public Guid? PaymentId { get; set; }

        /// <summary>
        /// Memo or reference text (ex. memo field on a check).
        /// </summary>
        public string MemoText { get; set; }

        /// <summary>
        /// Reference code for the payment for the given Erp system.
        /// </summary>
        public string ReferenceCode { get; set; }

        /// <summary>
        /// The tender type of payment (Cash, Check, etc.)
        /// </summary>
        public string TenderType { get; set; }

        /// <summary>
        /// The type of payment, AR Payment or AP Payment.
        /// </summary>
        public string PaymentType { get; set; }

        /// <summary>
        /// The date of this payment.
        ///
        /// This is a date-only field stored as a string in ISO 8601 (YYYY-MM-DD) format.
        /// </summary>
        public string PaymentDate { get; set; }

        /// <summary>
        /// The currency code of the payment.
        /// </summary>
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Total amount of this payment.
        /// </summary>
        public decimal? PaymentAmount { get; set; }

        /// <summary>
        /// Unapplied balance of this payment.
        /// </summary>
        public decimal? UnappliedAmount { get; set; }

        /// <summary>
        /// The base currency code of the group.
        /// </summary>
        public string BaseCurrencyCode { get; set; }

        /// <summary>
        /// The payment amount in the group&#39;s base currency.
        /// </summary>
        public decimal? BaseCurrencyPaymentAmount { get; set; }

        /// <summary>
        /// The unapplied amount in the group&#39;s base currency.
        /// </summary>
        public decimal? BaseCurrencyUnappliedAmount { get; set; }

        /// <summary>
        /// True if this payment includes some unassigned amount that has not yet been applied to an invoice.  If this
        /// value is true, the field `UnappliedAmount` will be nonzero.
        /// </summary>
        [Obsolete("This field is deprecated.")]
        public bool? IsOpen { get; set; }

        /// <summary>
        /// The number of invoices associated to this payment.
        /// </summary>
        public int? InvoiceCount { get; set; }

        /// <summary>
        /// The number of payments applied to this payment.
        /// </summary>
        public decimal? TotalPaymentsApplied { get; set; }

        /// <summary>
        /// The reference codes of the invoices associated to this payment.
        /// </summary>
        public string[] InvoiceList { get; set; }

        /// <summary>
        /// The ids of the invoices associated to this payment.
        /// </summary>
        public Guid[] InvoiceIdList { get; set; }

        /// <summary>
        /// The id of the company for this payment.
        /// </summary>
        public Guid? PaymentCompanyId { get; set; }

        /// <summary>
        /// The name of the company for this payment.
        /// </summary>
        public string PaymentCompanyName { get; set; }

        /// <summary>
        /// Specific payments have support for pdf retrieval from their respective erp. When this flag is true, an additional
        /// call to Payments/{id}/pdf can be made to retrieve a pdf directly from the erp.
        /// </summary>
        public bool? SupportsErpPdfRetrieval { get; set; }

        /// <summary>
        /// The ids of the customer for the associated invoices.
        /// </summary>
        [Obsolete("This field is deprecated.")]
        public Guid[] CustomerIds { get; set; }

        /// <summary>
        /// The names of the customer for the associated invoices.
        /// </summary>
        [Obsolete("This field is deprecated.")]
        public string[] CustomerNames { get; set; }

        /// <summary>
        /// The ids of the company for the associated invoices.
        /// </summary>
        [Obsolete("This field is deprecated.")]
        public Guid[] CompanyIds { get; set; }

        /// <summary>
        /// The names of the company for the associated invoices.
        /// </summary>
        [Obsolete("This field is deprecated.")]
        public string[] CompanyNames { get; set; }

        /// <summary>
        /// The modified date of the payment
        /// </summary>
        public DateTime? Modified { get; set; }
    }
}
