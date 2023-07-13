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
    /// A request to insert a new Payment
    /// </summary>
    public class InsertPaymentRequestModel
    {

        /// <summary>
        /// The AppEnrollmentId of the application to write this record to.
        /// </summary>
        public Guid? AppEnrollmentId { get; set; }

        /// <summary>
        /// The unique ID of this record, automatically assigned by Lockstep when this record is
        /// added to the Lockstep platform.
        ///
        /// For the ID of this record in its originating financial system, see `ErpKey`.
        /// </summary>
        public Guid? PaymentId { get; set; }

        /// <summary>
        /// The ID of the company to which this payment belongs.
        /// </summary>
        public Guid? CompanyId { get; set; }

        /// <summary>
        /// The ERP key for the company to which this payment belongs.
        /// </summary>
        public string CompanyErpKey { get; set; }

        /// <summary>
        /// A additional reference that may be used in the ERP
        /// </summary>
        public string CompanyExternalReference { get; set; }

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
        /// Memo or reference text (ex. memo field on a check).
        /// </summary>
        public string MemoText { get; set; }

        /// <summary>
        /// The date when this payment was received.
        /// </summary>
        public DateTime? PaymentDate { get; set; }

        /// <summary>
        /// The date when a payment was posted to a ledger.
        /// </summary>
        public DateTime? PostDate { get; set; }

        /// <summary>
        /// Total amount of this payment in it&#39;s received currency.
        /// </summary>
        public decimal? PaymentAmount { get; set; }

        /// <summary>
        /// Unapplied balance of this payment in it&#39;s received currency.  If this amount is nonzero, the field `IsOpen` will be true.
        /// </summary>
        public decimal? UnappliedAmount { get; set; }

        /// <summary>
        /// The ISO 4217 currency code for this payment.
        ///
        /// For a list of ISO 4217 currency codes, see [Query Currencies](https://developer.lockstep.io/reference/get_api-v1-definitions-currencies).
        /// </summary>
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Reference code for the payment for the given Erp system.
        /// </summary>
        public string ReferenceCode { get; set; }

        /// <summary>
        /// Is the payment voided?
        /// </summary>
        public bool? IsVoided { get; set; }

        /// <summary>
        /// Is the payment in dispute?
        /// </summary>
        public bool? InDispute { get; set; }

        /// <summary>
        /// The Currency Rate used to get from the account&#39;s base currency to the payment amount.
        /// </summary>
        public decimal? CurrencyRate { get; set; }

        /// <summary>
        /// Total amount of this payment in the group&#39;s base currency.
        /// </summary>
        public decimal? BaseCurrencyPaymentAmount { get; set; }

        /// <summary>
        /// Unapplied balance of this payment in the group&#39;s base currency.  If this amount is nonzero, the field `IsOpen` will be true.
        /// </summary>
        public decimal? BaseCurrencyUnappliedAmount { get; set; }

        /// <summary>
        /// The Bank account id for the company to which this payment belongs.
        /// </summary>
        public string BankAccountId { get; set; }

        /// <summary>
        /// The GroupKey this request belongs to.
        /// </summary>
        public Guid? GroupKey { get; set; }

        /// <summary>
        /// All applications this payment is associated with.
        /// To retrieve this collection, specify `Applications` in the &quot;Include&quot; parameter for your query.
        /// </summary>
        public InsertPaymentAppliedRequestModel[] Applications { get; set; }
    }
}
