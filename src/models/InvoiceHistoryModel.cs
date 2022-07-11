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
    /// An Invoice represents a bill sent from one company to another.  The Lockstep Platform tracks changes to
    /// each Invoice so that you can observe the changes over time.  You can view the InvoiceHistory list to
    /// monitor and observe the changes of this Invoice and track the dates when changes occurred.
    /// </summary>
    public class InvoiceHistoryModel
    {

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid? GroupKey { get; set; }

        /// <summary>
        /// The unique ID number of this invoice history entry.
        /// </summary>
        public Guid? InvoiceHistoryId { get; set; }

        /// <summary>
        /// The unique ID of the Invoice represented by this history entry.  This ID was automatically assigned
        /// by Lockstep to the Invoice record when it was added to the Lockstep platform.
        ///
        /// For the ID of this record in its originating financial system, see `ErpKey`.
        /// </summary>
        public Guid? InvoiceId { get; set; }

        /// <summary>
        /// The ID number of the company that created this invoice.
        /// </summary>
        public Guid? CompanyId { get; set; }

        /// <summary>
        /// The ID number of the counterparty for the invoice, for example, a customer or vendor.
        /// </summary>
        public Guid? CustomerId { get; set; }

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
        /// The purchase order code as it exists in the user&#39;s ERP or accounting system.
        /// </summary>
        public string PurchaseOrderCode { get; set; }

        /// <summary>
        /// An additional reference code that is sometimes used to identify this invoice.
        /// The meaning of this field is specific to the ERP or accounting system used by the user.
        /// </summary>
        public string ReferenceCode { get; set; }

        /// <summary>
        /// A code identifying the salesperson responsible for writing this invoice.
        /// </summary>
        public string SalespersonCode { get; set; }

        /// <summary>
        /// A string identifying the salesperson responsible for writing this invoice.
        /// </summary>
        public string SalespersonName { get; set; }

        /// <summary>
        /// A code identifying the type of this invoice.
        /// </summary>
        public string InvoiceTypeCode { get; set; }

        /// <summary>
        /// A code identifying the status of this invoice.
        /// </summary>
        public string InvoiceStatusCode { get; set; }

        /// <summary>
        /// A code identifying the terms given to the purchaser.
        /// </summary>
        public string TermsCode { get; set; }

        /// <summary>
        /// If the customer negotiated any special terms different from the standard terms above, describe them here.
        /// </summary>
        public string SpecialTerms { get; set; }

        /// <summary>
        /// The three-character ISO 4217 currency code used for this invoice. This will be validated by the /api/v1/definitions/currencies data set
        /// </summary>
        public string CurrencyCode { get; set; }

        /// <summary>
        /// The total value of this invoice, inclusive of all taxes and line items.
        /// </summary>
        public decimal? TotalAmount { get; set; }

        /// <summary>
        /// The total sales (or transactional) tax calculated for this invoice.
        /// </summary>
        public decimal? SalesTaxAmount { get; set; }

        /// <summary>
        /// The total discounts given by the seller to the buyer on this invoice.
        /// </summary>
        public decimal? DiscountAmount { get; set; }

        /// <summary>
        /// The remaining balance value of this invoice.
        /// </summary>
        public decimal? OutstandingBalanceAmount { get; set; }

        /// <summary>
        /// The reporting date for this invoice.
        ///
        /// This is a date-only field stored as a string in ISO 8601 (YYYY-MM-DD) format.
        /// </summary>
        public string InvoiceDate { get; set; }

        /// <summary>
        /// The date when discounts were adjusted for this invoice.
        ///
        /// This is a date-only field stored as a string in ISO 8601 (YYYY-MM-DD) format.
        /// </summary>
        public string DiscountDate { get; set; }

        /// <summary>
        /// The date when this invoice posted to the company&#39;s general ledger.
        ///
        /// This is a date-only field stored as a string in ISO 8601 (YYYY-MM-DD) format.
        /// </summary>
        public string PostedDate { get; set; }

        /// <summary>
        /// The date when the invoice was closed and finalized after completion of all payments and delivery of all products and
        /// services.
        ///
        /// This is a date-only field stored as a string in ISO 8601 (YYYY-MM-DD) format.
        /// </summary>
        public string InvoiceClosedDate { get; set; }

        /// <summary>
        /// The date when the remaining outstanding balance is due.
        ///
        /// This is a date-only field stored as a string in ISO 8601 (YYYY-MM-DD) format.
        /// </summary>
        public string PaymentDueDate { get; set; }

        /// <summary>
        /// The date and time when this record was imported from the user&#39;s ERP or accounting system.
        /// </summary>
        public DateTime? ImportedDate { get; set; }

        /// <summary>
        /// The ID number of the invoice&#39;s origination address
        /// </summary>
        public Guid? PrimaryOriginAddressId { get; set; }

        /// <summary>
        /// The ID number of the invoice&#39;s bill-to address
        /// </summary>
        public Guid? PrimaryBillToAddressId { get; set; }

        /// <summary>
        /// The ID number of the invoice&#39;s ship-to address
        /// </summary>
        public Guid? PrimaryShipToAddressId { get; set; }

        /// <summary>
        /// The date on which this invoice record was created.
        /// </summary>
        public DateTime? Created { get; set; }

        /// <summary>
        /// The ID number of the user who created this invoice.
        /// </summary>
        public Guid? CreatedUserId { get; set; }

        /// <summary>
        /// The date on which this invoice record was last modified.
        /// </summary>
        public DateTime? Modified { get; set; }

        /// <summary>
        /// The ID number of the user who most recently modified this invoice.
        /// </summary>
        public Guid? ModifiedUserId { get; set; }

        /// <summary>
        /// The AppEnrollmentId of the application that imported this record.  For accounts
        /// with more than one financial system connected, this field identifies the originating
        /// financial system that produced this record.  This value is null if this record
        /// was not loaded from an external ERP or financial system.
        /// </summary>
        public Guid? AppEnrollmentId { get; set; }
    }
}
