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
    /// Contains summary information for a Payment
    /// </summary>
    public class PaymentSummaryModel
    {

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
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
        /// Total amount of this payment.
        /// </summary>
        public decimal? PaymentAmount { get; set; }

        /// <summary>
        /// Unapplied balance of this payment.
        /// </summary>
        public decimal? UnappliedAmount { get; set; }

        /// <summary>
        /// True if this payment includes some unassigned amount that has not yet been applied to an invoice.  If this
        /// value is true, the field `UnappliedAmount` will be nonzero.
        /// </summary>
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
        /// The ids of the customer for the associated invoices.
        /// </summary>
        public Guid[] CustomerIds { get; set; }

        /// <summary>
        /// The names of the customer for the associated invoices.
        /// </summary>
        public string[] CustomerNames { get; set; }

        /// <summary>
        /// The ids of the company for the associated invoices.
        /// </summary>
        public Guid[] CompanyIds { get; set; }

        /// <summary>
        /// The names of the company for the associated invoices.
        /// </summary>
        public string[] CompanyNames { get; set; }
    }
}
