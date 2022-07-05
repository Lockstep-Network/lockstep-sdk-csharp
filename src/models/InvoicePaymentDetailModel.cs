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
    /// View to return Payment Detail information for a given Invoice record.
    /// </summary>
    public class InvoicePaymentDetailModel
    {

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid? GroupKey { get; set; }

        /// <summary>
        /// The unique identifier of this PaymentApplied record.
        /// </summary>
        public Guid? PaymentAppliedId { get; set; }

        /// <summary>
        /// The database id of the invoice
        /// </summary>
        public Guid? InvoiceId { get; set; }

        /// <summary>
        /// The database id of the Payment.
        /// </summary>
        public Guid? PaymentId { get; set; }

        /// <summary>
        /// Date Payment applied to Invoice.
        ///
        /// This is a date-only field stored as a string in ISO 8601 (YYYY-MM-DD) format.
        /// </summary>
        public string ApplyToInvoiceDate { get; set; }

        /// <summary>
        /// Amount applied to Invoice.
        /// </summary>
        public decimal? PaymentAppliedAmount { get; set; }

        /// <summary>
        /// An additional reference code that is sometimes used to identify this Payment.
        /// The meaning of this field is specific to the ERP or accounting system used by the user.
        /// </summary>
        public string ReferenceCode { get; set; }

        /// <summary>
        /// The ID number of the Company (CompanyType = &quot;Customer&quot;) that created this Payment.
        /// </summary>
        public Guid? CompanyId { get; set; }

        /// <summary>
        /// The total value of this Payment.
        /// </summary>
        public decimal? PaymentAmount { get; set; }

        /// <summary>
        /// The remaining balance value of this Payment.
        /// </summary>
        public decimal? UnappliedAmount { get; set; }
    }
}
