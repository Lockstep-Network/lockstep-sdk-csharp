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
    /// A Payment Application is created by a business who receives a Payment from a customer.  A customer may make
    /// a single Payment to match an Invoice exactly, a partial Payment for an Invoice, or a single Payment may be
    /// made for multiple smaller Invoices.  The Payment Application contains information about which Invoices are connected
    /// to which Payments and for which amounts.
    /// </summary>
    public class PaymentAppliedModel
    {

        /// <summary>
        /// The GroupKey uniquely identifies a single ADS Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid? GroupKey { get; set; }

        /// <summary>
        /// The unique ID of this record, automatically assigned by ADS Platform when this record is
        /// added to the ADS Platform.
        ///
        /// For the ID of this record in its originating financial system, see `ErpKey`.
        /// </summary>
        public Guid? PaymentAppliedId { get; set; }

        /// <summary>
        /// The Invoice this payment is applied to.
        /// </summary>
        public Guid? InvoiceId { get; set; }

        /// <summary>
        /// The refund Payment that funded the payment.
        /// </summary>
        public Guid? RefundId { get; set; }

        /// <summary>
        /// The Payment applied to the invoice or receiving funding from a refund.
        /// </summary>
        public Guid? PaymentId { get; set; }

        /// <summary>
        /// The unique ID of this record as it was known in its originating financial system.
        ///
        /// If this company record was imported from a financial system, it will have the value `ErpKey`
        /// set to the original primary key number of the record as it was known in the originating financial
        /// system.  If this record was not imported, this value will be `null`.
        ///
        /// For more information, see [Identity Columns](https://developer.lockstep.io/docs/identity-columns).
        /// </summary>
        public string ErpKey { get; set; }

        /// <summary>
        /// Possible statuses for a record that supports ERP Update.
        /// </summary>
        public int? ErpUpdateStatus { get; set; }

        /// <summary>
        /// Possible actions for a record that supports ERP Update.
        /// </summary>
        public int? ErpUpdateAction { get; set; }

        /// <summary>
        /// The entry number of this payment application.  This is often a journal entry number, confirmation code,
        /// or other identifying field for this payment application.
        /// </summary>
        public int? EntryNumber { get; set; }

        /// <summary>
        /// The date this payment was applied to this invoice.
        /// </summary>
        public DateTime? ApplyToInvoiceDate { get; set; }

        /// <summary>
        /// The total amount that was applied to this Invoice from the Payment.
        /// </summary>
        public decimal? PaymentAppliedAmount { get; set; }

        /// <summary>
        /// Date payment applied record was created.
        /// </summary>
        public DateTime? Created { get; set; }

        /// <summary>
        /// The id of the user who created this applied payment.
        /// </summary>
        public Guid? CreatedUserId { get; set; }

        /// <summary>
        /// Date payment applied record was modified.
        /// </summary>
        public DateTime? Modified { get; set; }

        /// <summary>
        /// The id of the user who modified this applied payment.
        /// </summary>
        public Guid? ModifiedUserId { get; set; }

        /// <summary>
        /// The AppEnrollmentId of the application that imported this record.  For accounts
        /// with more than one financial system connected, this field identifies the originating
        /// financial system that produced this record.  This value is null if this record
        /// was not loaded from an external ERP or financial system.
        /// </summary>
        public Guid? AppEnrollmentId { get; set; }

        /// <summary>
        /// The date on which this record was last modified in source ERP.
        /// </summary>
        public DateTime? SourceModifiedDate { get; set; }

        /// <summary>
        /// The payment associated with this applied payment
        /// </summary>
        public PaymentModel Payment { get; set; }

        /// <summary>
        /// The invoice associated with this applied payment.
        /// </summary>
        public InvoiceModel Invoice { get; set; }

        /// <summary>
        /// The refund payment associated with this applied payment
        /// </summary>
        public PaymentModel Refund { get; set; }

        /// <summary>
        /// Additional attributes that may be required by the source system.
        /// </summary>
        [Obsolete("This field is deprecated.")]
        public object ErpSystemAttributes { get; set; }
    }
}
