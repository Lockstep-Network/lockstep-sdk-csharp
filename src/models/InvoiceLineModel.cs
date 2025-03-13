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
    /// Represents a line in an invoice
    /// </summary>
    public class InvoiceLineModel
    {

        /// <summary>
        /// The unique ID of this record, automatically assigned by ADS when this record is
        /// added to the ADS Platform.
        ///
        /// For the ID of this record in its originating financial system, see `ErpKey`.
        /// </summary>
        public Guid? InvoiceLineId { get; set; }

        /// <summary>
        /// The GroupKey uniquely identifies a single ADS Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid? GroupKey { get; set; }

        /// <summary>
        /// The ID number of the invoice this line belongs to.
        /// </summary>
        public Guid? InvoiceId { get; set; }

        /// <summary>
        /// The unique ID of this record as it was known in its originating financial system, if it was
        /// different from the original `LineNumber`.
        ///
        /// If this company record was imported from a financial system, it will have the value `ErpKey`
        /// set to the original primary key number of the record as it was known in the originating financial
        /// system.  If this record was not imported, this value will be `null`.
        ///
        /// For more information, see [Identity Columns](https://developer.lockstep.io/docs/identity-columns).
        /// </summary>
        public string ErpKey { get; set; }

        /// <summary>
        /// The line number of this line, as defined in the originating ERP or accounting system.  You can sort on this number to
        /// get the original view of lines within the invoice.
        /// </summary>
        public string LineNumber { get; set; }

        /// <summary>
        /// The account number this line is associated with in the originating ERP or accounting system.
        /// </summary>
        public string AccountNumber { get; set; }

        /// <summary>
        /// A code number identifying the product or service that is specified on this line.
        /// </summary>
        public string ProductCode { get; set; }

        /// <summary>
        /// Description of this invoice line.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The location to where specific items from an invoice will go.
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// For lines measured in a unit other than &quot;quantity&quot;, this code indicates the measurement system for the quantity field.
        /// If the line is measured in quantity, this field is null.
        /// </summary>
        public string UnitMeasureCode { get; set; }

        /// <summary>
        /// The price of a single unit for this line.
        /// </summary>
        public decimal? UnitPrice { get; set; }

        /// <summary>
        /// The quantity of items for ths line.
        /// </summary>
        public decimal? Quantity { get; set; }

        /// <summary>
        /// The number of items that have been shipped.
        /// </summary>
        public decimal? QuantityShipped { get; set; }

        /// <summary>
        /// The number of items that has been received.
        /// </summary>
        public decimal? QuantityReceived { get; set; }

        /// <summary>
        /// The total amount for this line.
        /// </summary>
        public decimal? TotalAmount { get; set; }

        /// <summary>
        /// The tax code used for taxation on this line.
        /// </summary>
        public string TaxCode { get; set; }

        /// <summary>
        /// The taxation rate for this line.
        /// </summary>
        public decimal? TaxRate { get; set; }

        /// <summary>
        /// The amount of sales tax for this line in the transaction&#39;s currency.
        /// </summary>
        public decimal? SalesTaxAmount { get; set; }

        /// <summary>
        /// The amount of sales tax for this line in the base currency.
        /// </summary>
        public decimal? BaseCurrencySalesTaxAmount { get; set; }

        /// <summary>
        /// The total value of this invoice line with deductions, excluding taxes.
        /// </summary>
        public decimal? NetAmount { get; set; }

        /// <summary>
        /// The total value of this invoice line with deductions, excluding taxes and in the invoice&#39;s base currency.
        /// </summary>
        public decimal? BaseCurrencyNetAmount { get; set; }

        /// <summary>
        /// If this line is tax exempt, this code indicates the reason for the exemption.
        /// </summary>
        public string ExemptionCode { get; set; }

        /// <summary>
        /// Unique identifier for tax purposes, used for reference, validation, or compliance.
        /// </summary>
        public string TaxUid { get; set; }

        /// <summary>
        /// If null, the products specified on this line were delivered on the same date as all other lines.
        /// If not null, this line was delivered or finalized on a different date than the overall invoice.
        ///
        /// This is a date-only field stored as a string in ISO 8601 (YYYY-MM-DD) format.
        /// </summary>
        public string ReportingDate { get; set; }

        /// <summary>
        /// The date on which this line was created.
        /// </summary>
        public DateTime? Created { get; set; }

        /// <summary>
        /// The ID number of the user who created this line.
        /// </summary>
        public Guid? CreatedUserId { get; set; }

        /// <summary>
        /// The date on which this line was last modified.
        /// </summary>
        public DateTime? Modified { get; set; }

        /// <summary>
        /// The ID number of the user who most recently modified this line.
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
        /// Possible statuses for a record that supports ERP Update.
        /// </summary>
        public int? ErpUpdateStatus { get; set; }

        /// <summary>
        /// Possible actions for a record that supports ERP Update.
        /// </summary>
        public int? ErpUpdateAction { get; set; }

        /// <summary>
        /// The date on which this record was last modified in source ERP.
        /// </summary>
        public DateTime? SourceModifiedDate { get; set; }

        /// <summary>
        /// Additional attributes that may be required by the source system.
        /// </summary>
        [Obsolete("This field is deprecated.")]
        public object ErpSystemAttributes { get; set; }

        /// <summary>
        /// A collection of notes linked to this record.  To retrieve this collection, specify `Notes` in the
        /// `include` parameter when retrieving data.
        ///
        /// To create a note, use the [Create Note](https://developer.lockstep.io/reference/post_api-v1-notes)
        /// endpoint with the `TableKey` to `InvoiceLine` and the `ObjectKey` set to the `InvoiceLineId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
        public NoteModel[] Notes { get; set; }

        /// <summary>
        /// A collection of attachments linked to this record.  To retrieve this collection, specify `Attachments` in
        /// the `include` parameter when retrieving data.
        ///
        /// To create an attachment, use the [Upload Attachment](https://developer.lockstep.io/reference/post_api-v1-attachments)
        /// endpoint with the `TableKey` to `InvoiceLine` and the `ObjectKey` set to the `InvoiceLineId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
        public AttachmentModel[] Attachments { get; set; }
    }
}
