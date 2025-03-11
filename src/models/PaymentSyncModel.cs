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
    /// The PaymentSyncModel represents information coming into ADS from an external financial system or other
    /// enterprise resource planning system.  To import data from an external system, convert your original data into
    /// the PaymentSyncModel format and call the [Upload Sync File API](https://developer.lockstep.io/reference/post_api-v1-sync-zip).
    /// This API retrieves all of the data you uploaded in a compressed ZIP file and imports it into the ADS
    /// Platform.
    ///
    /// Once imported, this record will be available in the ADS Platform API as a [PaymentModel](https://developer.lockstep.io/docs/paymentmodel).
    ///
    /// For more information on writing your own connector, see [Connector Data](https://developer.lockstep.io/docs/connector-data).
    /// </summary>
    public class PaymentSyncModel
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
        /// This is the primary key of the Payment record. For this field, you should use whatever the payment&#39;s unique
        /// identifying number is in the originating system. Search for a unique, non-changing number within the
        /// originating financial system for this record.
        ///
        /// Example: If you store your payment records in a database, whatever the primary key for the payment table is
        /// in the database should be the &quot;ErpKey&quot;.
        ///
        /// For more information, see [Identity Columns](https://developer.lockstep.io/docs/identity-columns).
        /// </summary>
        public string ErpKey { get; set; }

        /// <summary>
        /// The original primary key or unique ID of the company to which this payment belongs.  This value should
        /// match the [Company ErpKey](https://developer.lockstep.io/docs/importing-companies#erpkey) field on the
        /// [CompanySyncModel](https://developer.lockstep.io/docs/importing-companies).
        /// </summary>
        public string CompanyErpKey { get; set; }

        /// <summary>
        /// The network id of the related Company.
        /// </summary>
        public Guid? CompanyNetworkId { get; set; }

        /// <summary>
        /// The type of payment, AR Payment or AP Payment.
        ///
        /// Recognized PaymentType values are:
        /// * `AR Payment` - A payment made by a Customer to the Company
        /// * `AP Payment` - A payment made by the Company to a Vendor
        /// </summary>
        public string PaymentType { get; set; }

        /// <summary>
        /// Cash, check, credit card, wire transfer.
        ///
        /// Recognized TenderType values are:
        /// * `Cash` - A cash payment or other direct transfer.
        /// * `Check` - A check payment.
        /// * `Credit Card` - A payment made via a credit card.
        /// * `Wire Transfer` - A payment made via wire transfer from another financial institution.
        /// * `Other` - A payment made via another method not listed above.
        /// </summary>
        public string TenderType { get; set; }

        /// <summary>
        /// True if this payment includes some unassigned amount that has not yet been applied to an invoice.  If this
        /// value is true, the field `UnappliedAmount` will be nonzero.
        /// </summary>
        public bool? IsOpen { get; set; }

        /// <summary>
        /// Memo or reference text (ex. memo field on a check).
        /// </summary>
        public string MemoText { get; set; }

        /// <summary>
        /// The date when this payment was received.  This typically is the date when an accounting employee recorded
        /// that they received notification that the payment had occurred, whether they were notified by email, postal
        /// mail, or financial transaction notification.
        /// </summary>
        public DateTime? PaymentDate { get; set; }

        /// <summary>
        /// The date when a payment was posted to a ledger.  This date is often determined by a company&#39;s accounting
        /// practices and may be different than the date when the payment was received.  This date may be affected by
        /// issues such as temporary holds on funds transferred, bank holidays, or other actions.
        /// </summary>
        public DateTime? PostDate { get; set; }

        /// <summary>
        /// Total amount of this payment in the payment&#39;s currency.
        /// </summary>
        public decimal? PaymentAmount { get; set; }

        /// <summary>
        /// Unapplied balance of this payment in the payment&#39;s currency.  If this amount is nonzero, the field `IsOpen` will be true.
        /// </summary>
        public decimal? UnappliedAmount { get; set; }

        /// <summary>
        /// The ISO 4217 currency code for this payment.
        ///
        /// For a list of ISO 4217 currency codes, see [Query Currencies](https://developer.lockstep.io/reference/get_api-v1-definitions-currencies).
        /// </summary>
        public string CurrencyCode { get; set; }

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

        /// <summary>
        /// A reference code for the payment for the given financial or ERP system.  This can be any value that the
        /// originating system uses to designate the payment, such as a confirmation number or tracking number, that
        /// is different from the `ErpKey` value.
        /// </summary>
        public string ReferenceCode { get; set; }

        /// <summary>
        /// True if this payment was voided.
        /// </summary>
        public bool? IsVoided { get; set; }

        /// <summary>
        /// True if this payment is in dispute.
        /// </summary>
        public bool? InDispute { get; set; }

        /// <summary>
        /// The Currency Rate used to get from the account&#39;s base currency to the payment amount.
        /// </summary>
        public decimal? CurrencyRate { get; set; }

        /// <summary>
        /// Total amount of this payment in the erp&#39;s base currency.
        /// </summary>
        public decimal? BaseCurrencyPaymentAmount { get; set; }

        /// <summary>
        /// Unapplied balance of this payment in the erp&#39;s base currency.  If this amount is nonzero, the field `IsOpen` will be true.
        /// </summary>
        public decimal? BaseCurrencyUnappliedAmount { get; set; }

        /// <summary>
        /// Bank account id for the payment.
        /// </summary>
        public string BankAccountId { get; set; }

        /// <summary>
        /// The tax code of this payment.
        /// </summary>
        public string TaxCode { get; set; }

        /// <summary>
        /// The financial account code of this payment.
        /// </summary>
        public string FinancialAccountCode { get; set; }
    }
}
