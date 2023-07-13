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
    /// A request to insert a payment application
    /// </summary>
    public class InsertPaymentAppliedRequestModel
    {

        /// <summary>
        /// The unique ID of this record, automatically assigned by Lockstep when this record is
        /// added to the Lockstep platform.
        ///
        /// For the ID of this record in its originating financial system, see `ErpKey`.
        /// </summary>
        public Guid? PaymentAppliedId { get; set; }

        /// <summary>
        /// The Invoice this payment is applied to.
        /// </summary>
        public Guid? InvoiceId { get; set; }

        /// <summary>
        /// The Payment this application applies from.
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
        /// The ERP key of the Invoice this payment is applied to.
        /// </summary>
        public string InvoiceErpKey { get; set; }

        /// <summary>
        /// The date this payment was applied to this invoice.
        /// </summary>
        public DateTime? ApplyToInvoiceDate { get; set; }

        /// <summary>
        /// The total amount that was applied to this Invoice from the Payment.
        /// </summary>
        public decimal? PaymentAppliedAmount { get; set; }
    }
}
