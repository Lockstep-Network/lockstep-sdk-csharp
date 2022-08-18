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
    /// The InvoiceSyncModel represents information coming into Lockstep from an external financial system or other
    /// enterprise resource planning system.  To import data from an external system, convert your original data into
    /// the InvoiceSyncModel format and call the [Upload Sync File API](https://developer.lockstep.io/reference/post_api-v1-sync-zip).
    /// This API retrieves all of the data you uploaded in a compressed ZIP file and imports it into the Lockstep
    /// platform.
    ///
    /// Once imported, this record will be available in the Lockstep API as an [InvoiceModel](https://developer.lockstep.io/docs/invoicemodel).
    ///
    /// For more information on writing your own connector, see [Connector Data](https://developer.lockstep.io/docs/connector-data).
    /// </summary>
    public class InvoiceSyncModel
    {

        /// <summary>
        /// This is the primary key of the Invoice record. For this field, you should use whatever the invoice&#39;s unique
        /// identifying number is in the originating system. Search for a unique, non-changing number within the
        /// originating financial system for this record.
        ///
        /// Example: If you store your invoice records in a database, whatever the primary key for the invoice table is
        /// in the database should be the &quot;ErpKey&quot;.
        ///
        /// For more information, see [Identity Columns](https://developer.lockstep.io/docs/identity-columns).
        /// </summary>
        public string ErpKey { get; set; }

        /// <summary>
        /// The original primary key or unique ID of the company to which this invoice belongs.  This value should
        /// match the [Company ErpKey](https://developer.lockstep.io/docs/importing-companies#erpkey) field on the
        /// [CompanySyncModel](https://developer.lockstep.io/docs/importing-companies).
        ///
        /// An Invoice has two relationships: The Company and the Customer.  The field `CompanyErpKey` identifies the
        /// company that created the invoice, and the field `CustomerErpKey` is the customer to whom the invoice
        /// was sent.
        /// </summary>
        public string CompanyErpKey { get; set; }

        /// <summary>
        /// The original primary key or unique ID of the company to which this invoice was sent.  This value should
        /// match the [Company ErpKey](https://developer.lockstep.io/docs/importing-companies#erpkey) field on the
        /// [CompanySyncModel](https://developer.lockstep.io/docs/importing-companies).
        ///
        /// An Invoice has two relationships: The Company and the Customer.  The field `CompanyErpKey` identifies the
        /// company that created the invoice, and the field `CustomerErpKey` is the customer to whom the invoice
        /// was sent.
        /// </summary>
        public string CustomerErpKey { get; set; }

        /// <summary>
        /// The name of the salesperson that wrote this invoice.  This is just text, it is not a reference to the
        /// &quot;Contacts&quot; table.  You will not receive an error if this field does not match a known contact person.
        /// </summary>
        public string SalespersonName { get; set; }

        /// <summary>
        /// The &quot;Purchase Order Code&quot; is a code that is sometimes used by companies to refer to the original PO
        /// that was sent that caused this invoice to be written.  If a customer sends a purchase order to a vendor,
        /// the vendor can then create an invoice and refer back to the originating purchase order using this field.
        /// </summary>
        public string PurchaseOrderCode { get; set; }

        /// <summary>
        /// An additional reference code that is sometimes used to identify this invoice. The meaning of this field
        /// is specific to the ERP or accounting system used by the user.
        /// </summary>
        public string ReferenceCode { get; set; }

        /// <summary>
        /// A code identifying the salesperson responsible for writing this quote, invoice, or order.  This is just
        /// text, it is not a reference to the &quot;Contacts&quot; table.  You will not receive an error if this field does
        /// not match a known contact person.
        /// </summary>
        public string SalespersonCode { get; set; }

        /// <summary>
        /// A code identifying the type of this invoice.
        ///
        /// Recognized Invoice types are:
        /// * `AR Invoice` - Represents an invoice sent by Company to the Customer
        /// * `AP Invoice` - Represents an invoice sent by Vendor to the Company
        /// * `AR Credit Memo` - Represents a credit memo generated by Company given to Customer
        /// * `AP Credit Memo` - Represents a credit memo generated by Vendor given to Company
        /// </summary>
        public string InvoiceTypeCode { get; set; }

        /// <summary>
        /// A code identifying the status of this invoice.
        ///
        /// Recognized Invoice status codes are:
        /// * `Open` - Represents an invoice that is considered open and needs more work to complete
        /// * `Closed` - Represents an invoice that is considered closed and resolved
        /// </summary>
        public string InvoiceStatusCode { get; set; }

        /// <summary>
        /// A code identifying the terms given to the purchaser.  This field is imported directly from the originating
        /// financial system and does not follow a specified format.
        /// </summary>
        public string TermsCode { get; set; }

        /// <summary>
        /// If the customer negotiated any special terms different from the standard terms above, describe them here.
        /// </summary>
        public string SpecialTerms { get; set; }

        /// <summary>
        /// The three-character ISO 4217 currency code used for this invoice.
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
        /// </summary>
        public DateTime? InvoiceDate { get; set; }

        /// <summary>
        /// The date when discounts were adjusted for this invoice.
        /// </summary>
        public DateTime? DiscountDate { get; set; }

        /// <summary>
        /// The date when this invoice posted to the company&#39;s general ledger.
        /// </summary>
        public DateTime? PostedDate { get; set; }

        /// <summary>
        /// The date when the invoice was closed and finalized after completion of all payments and delivery of all products and
        /// services.
        /// </summary>
        public DateTime? InvoiceClosedDate { get; set; }

        /// <summary>
        /// The date when the remaining outstanding balance is due.
        /// </summary>
        public DateTime? PaymentDueDate { get; set; }

        /// <summary>
        /// The date and time when this record was imported from the user&#39;s ERP or accounting system.
        /// </summary>
        public DateTime? ImportedDate { get; set; }

        /// <summary>
        /// The origination address for this invoice
        /// </summary>
        public string OriginAddressLine1 { get; set; }

        /// <summary>
        /// The origination address for this invoice
        /// </summary>
        public string OriginAddressLine2 { get; set; }

        /// <summary>
        /// The origination address for this invoice
        /// </summary>
        public string OriginAddressLine3 { get; set; }

        /// <summary>
        /// The origination address for this invoice
        /// </summary>
        public string OriginAddressCity { get; set; }

        /// <summary>
        /// The origination address for this invoice
        /// </summary>
        public string OriginAddressRegion { get; set; }

        /// <summary>
        /// The origination address for this invoice
        /// </summary>
        public string OriginAddressPostalCode { get; set; }

        /// <summary>
        /// The origination address for this invoice
        /// </summary>
        public string OriginAddressCountry { get; set; }

        /// <summary>
        /// The origination address for this invoice
        /// </summary>
        public decimal? OriginAddressLatitude { get; set; }

        /// <summary>
        /// The origination address for this invoice
        /// </summary>
        public decimal? OriginAddressLongitude { get; set; }

        /// <summary>
        /// The billing address for this invoice
        /// </summary>
        public string BillToAddressLine1 { get; set; }

        /// <summary>
        /// The billing address for this invoice
        /// </summary>
        public string BillToAddressLine2 { get; set; }

        /// <summary>
        /// The billing address for this invoice
        /// </summary>
        public string BillToAddressLine3 { get; set; }

        /// <summary>
        /// The billing address for this invoice
        /// </summary>
        public string BillToAddressCity { get; set; }

        /// <summary>
        /// The billing address for this invoice
        /// </summary>
        public string BillToAddressRegion { get; set; }

        /// <summary>
        /// The billing address for this invoice
        /// </summary>
        public string BillToAddressPostalCode { get; set; }

        /// <summary>
        /// The billing address for this invoice
        /// </summary>
        public string BillToAddressCountry { get; set; }

        /// <summary>
        /// The billing address for this invoice
        /// </summary>
        public decimal? BillToAddressLatitude { get; set; }

        /// <summary>
        /// The billing address for this invoice
        /// </summary>
        public decimal? BillToAddressLongitude { get; set; }

        /// <summary>
        /// The shipping address for this invoice
        /// </summary>
        public string ShipToAddressLine1 { get; set; }

        /// <summary>
        /// The shipping address for this invoice
        /// </summary>
        public string ShipToAddressLine2 { get; set; }

        /// <summary>
        /// The shipping address for this invoice
        /// </summary>
        public string ShipToAddressLine3 { get; set; }

        /// <summary>
        /// The shipping address for this invoice
        /// </summary>
        public string ShipToAddressCity { get; set; }

        /// <summary>
        /// The shipping address for this invoice
        /// </summary>
        public string ShipToAddressRegion { get; set; }

        /// <summary>
        /// The shipping address for this invoice
        /// </summary>
        public string ShipToAddressPostalCode { get; set; }

        /// <summary>
        /// The shipping address for this invoice
        /// </summary>
        public string ShipToAddressCountry { get; set; }

        /// <summary>
        /// The shipping address for this invoice
        /// </summary>
        public decimal? ShipToAddressLatitude { get; set; }

        /// <summary>
        /// The shipping address for this invoice
        /// </summary>
        public decimal? ShipToAddressLongitude { get; set; }

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
        /// Is the invoice voided? If not specified, we assume the invoice is not voided.
        /// </summary>
        public bool? IsVoided { get; set; }

        /// <summary>
        /// Is the invoice in dispute? If not specified, we assume the invoice is not in dispute.
        /// </summary>
        public bool? InDispute { get; set; }

        /// <summary>
        /// Indicates the preferred delivery method for this invoice. Examples include Print, Email, Fax
        /// </summary>
        public string PreferredDeliveryMethod { get; set; }
    }
}
