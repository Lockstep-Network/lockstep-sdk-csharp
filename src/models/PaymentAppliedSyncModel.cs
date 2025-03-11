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
    /// The PaymentAppliedSyncModel represents information coming into ADS from an external financial system or
    /// other enterprise resource planning system.  To import data from an external system, convert your original data
    /// into the PaymentAppliedSyncModel format and call the [Upload Sync File API](https://developer.lockstep.io/reference/post_api-v1-sync-zip).
    /// This API retrieves all of the data you uploaded in a compressed ZIP file and imports it into the ADS
    /// Platform.
    ///
    /// Once imported, this record will be available in the ADS Platform API as a [PaymentAppliedModel](https://developer.lockstep.io/docs/paymentappliedmodel).
    ///
    /// For more information on writing your own connector, see [Connector Data](https://developer.lockstep.io/docs/connector-data).
    /// </summary>
    public class PaymentAppliedSyncModel
    {

        /// <summary>
        /// Indicates what action to take when an existing object has been found during the sync process.
        /// </summary>
        public int? OnMatchAction { get; set; }

        /// <summary>
        /// The unique identifier of this object in the Sage Network platform.
        /// </summary>
        public Guid? NetworkId { get; set; }

        /// <summary>
        /// This is the primary key of the Payment Application record. For this field, you should use whatever this
        /// transaction&#39;s unique identifying number is in the originating system. Search for a unique, non-changing
        /// number within the originating financial system for this record.
        ///
        /// Since Payment Applications are often considered transactions, a typical value to look for will be
        /// the transaction ID number, the payment confirmation number, or some other record of this payment.
        ///
        /// For more information, see [Identity Columns](https://developer.lockstep.io/docs/identity-columns).
        /// </summary>
        public string ErpKey { get; set; }

        /// <summary>
        /// This field indicates which Invoice had its balance reduced by applying this payment.  In this field,
        /// identify the original primary key or unique ID of the Invoice which had its balance reduced.
        ///
        /// This information lets you track how an invoice was paid. You can identify what proportion of an invoice&#39;s
        /// balance was paid by which methods by joining this field to Invoices.
        ///
        /// This value should match the [Invoice ErpKey](https://developer.lockstep.io/docs/importing-invoices#erpkey)
        /// field on the [InvoiceSyncModel](https://developer.lockstep.io/docs/importing-invoices).
        /// </summary>
        public string InvoiceErpKey { get; set; }

        /// <summary>
        /// The network id of the related Invoice.
        /// </summary>
        public Guid? InvoiceNetworkId { get; set; }

        /// <summary>
        /// This field indicates which Payment is being used to provide the funds for a the payment.  In this field,
        /// identify the original primary key or unique ID of the Payment which will be supplying the funds.
        ///
        /// This information lets you track how a payment was funded. You can identify what proportion of an payment&#39;s
        /// balance was paid by which methods by joining this field to the Payment.
        ///
        /// This value should match the [Payment ErpKey](https://developer.lockstep.io/docs/importing-payments#erpkey)
        /// field on the [PaymentSyncModel](https://developer.lockstep.io/docs/importing-payments).
        /// </summary>
        public string RefundErpKey { get; set; }

        /// <summary>
        /// The network id of the related refund Payment.
        /// </summary>
        public Guid? RefundNetworkId { get; set; }

        /// <summary>
        /// This field indicates which Payment was used to provide the funds for this payment application, or the payment that
        /// is being funded in the case of a refund. In this field, identify the original primary key or unique ID of the
        /// Payment that was used for this payment or the Payment that is being refunded.
        ///
        /// This information lets you track how an invoice was paid. You can identify what proportion of an payment&#39;s
        /// balance was paid by which methods by joining this field to the Payment.
        ///
        /// This value should match the [Payment ErpKey](https://developer.lockstep.io/docs/importing-payments#erpkey)
        /// field on the [PaymentSyncModel](https://developer.lockstep.io/docs/importing-payments).
        /// </summary>
        public string PaymentErpKey { get; set; }

        /// <summary>
        /// The network id of the related Payment.
        /// </summary>
        public Guid? PaymentNetworkId { get; set; }

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
        /// If known, the date when this record was created according to the originating financial system
        /// in which this record is maintained.  If the originating financial system does not maintain a
        /// created-date, leave this field null.
        /// </summary>
        public DateTime? Created { get; set; }

        /// <summary>
        /// If known, the date when this record was most recently modified according to the originating
        /// financial system in which this record is maintained.  If the originating financial system does
        /// not maintain a most-recently-modified-date, leave this field null.
        /// </summary>
        public DateTime? Modified { get; set; }
    }
}
