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
    /// Company payment collected information
    /// </summary>
    public class CompanyDetailsPaymentModel
    {

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid? GroupKey { get; set; }

        /// <summary>
        /// Unique identifier for payment
        /// </summary>
        public Guid? PaymentId { get; set; }

        /// <summary>
        /// Unique identifier for payment applied
        /// </summary>
        public Guid? PaymentAppliedId { get; set; }

        /// <summary>
        /// Payment type
        /// </summary>
        public string PaymentType { get; set; }

        /// <summary>
        /// Unique identifier for invoice payment is associated with
        /// </summary>
        public Guid? InvoiceId { get; set; }

        /// <summary>
        /// Invoice type payment is associated with
        /// </summary>
        public string InvoiceTypeCode { get; set; }

        /// <summary>
        /// Invoice reference code payment is associated with
        /// </summary>
        public string InvoiceReferenceCode { get; set; }

        /// <summary>
        /// The currency code of the invoice the payment is associated with.
        /// </summary>
        public string InvoiceCurrencyCode { get; set; }

        /// <summary>
        /// Invoice total amount payment is associated with
        /// </summary>
        public decimal? InvoiceTotalAmount { get; set; }

        /// <summary>
        /// Date payment placed
        /// </summary>
        public DateTime? PaymentDate { get; set; }

        /// <summary>
        /// The currency code of the payment.
        /// </summary>
        public string PaymentCurrencyCode { get; set; }

        /// <summary>
        /// Amount payment was made for
        /// </summary>
        public decimal? PaymentAmount { get; set; }
    }
}
