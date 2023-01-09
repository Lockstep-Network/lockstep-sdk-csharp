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
    /// The CreditMemoAppliedSyncModel represents information coming into Lockstep from an external financial system or
    /// other enterprise resource planning system.  To import data from an external system, convert your original data
    /// into the CreditMemoAppliedSyncModel format and call the [Upload Sync File API](https://developer.lockstep.io/reference/post_api-v1-sync-zip).
    /// This API retrieves all of the data you uploaded in a compressed ZIP file and imports it into the Lockstep
    /// platform.
    ///
    /// Once imported, this record will be available in the Lockstep API as a [CreditMemoAppliedModel](https://developer.lockstep.io/docs/creditmemoappliedmodel).
    ///
    /// For more information on writing your own connector, see [Connector Data](https://developer.lockstep.io/docs/connector-data).
    /// </summary>
    public class CreditMemoAppliedSyncModel
    {

        /// <summary>
        /// This is the primary key of the Credit Memo Application record. For this field, you should use whatever this
        /// transaction&#39;s unique identifying number is in the originating system. Search for a unique, non-changing
        /// number within the originating financial system for this record.
        ///
        /// Since Credit Memo Applications are often considered transactions, a typical value to look for will be
        /// the transaction ID number, the payment confirmation number, or some other record of this payment.
        ///
        /// For more information, see [Identity Columns](https://developer.lockstep.io/docs/identity-columns).
        /// </summary>
        public string ErpKey { get; set; }

        /// <summary>
        /// This field indicates which Invoice had its balanced reduced by applying a credit memo.  In this field,
        /// identify the original primary key or unique ID of the Invoice which had its balanced reduced.
        ///
        /// Example: Company ABC received a credit memo, CM000123 for $500.  Company ABC then chooses to apply this
        /// credit memo to reduce the balance of the invoice PO1000578.  The `InvoiceErpKey` is `PO1000578`.
        /// </summary>
        public string InvoiceErpKey { get; set; }

        /// <summary>
        /// This field indicates which Invoice is the original credit memo that was used to make this payment
        /// application event.  In this field, identify the original primary key or unique ID of the Invoice which
        /// created the credit memo that was consumed in this event.
        ///
        /// Example: Company ABC received a credit memo, CM000123 for $500.  Company ABC then chooses to apply this
        /// credit memo to reduce the balance of the invoice PO1000578.  The `CreditMemoInvoiceErpKey` is `CM000123`.
        /// </summary>
        public string CreditMemoInvoiceErpKey { get; set; }

        /// <summary>
        /// Reference number for the applied credit memo.
        /// </summary>
        public int? EntryNumber { get; set; }

        /// <summary>
        /// The date on which this credit memo was applied to the Invoice.
        /// </summary>
        public DateTime? ApplyToInvoiceDate { get; set; }

        /// <summary>
        /// The amount of this credit memo that was applied to this Invoice.
        /// </summary>
        public decimal? CreditMemoAppliedAmount { get; set; }

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
