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
    /// The InvoiceLineSyncModel represents information coming into ADS from an external financial system or other
    /// enterprise resource planning system.  To import data from an external system, convert your original data into
    /// the InvoiceLineSyncModel format and call the [Upload Sync File API](https://developer.lockstep.io/reference/post_api-v1-sync-zip).
    /// This API retrieves all of the data you uploaded in a compressed ZIP file and imports it into the ADS
    /// Platform.
    ///
    /// Once imported, this record will be available in the ADS Platform API as an [InvoiceLineModel](https://developer.lockstep.io/docs/invoicelinemodel).
    ///
    /// For more information on writing your own connector, see [Connector Data](https://developer.lockstep.io/docs/connector-data).
    /// </summary>
    public class InvoiceLineSyncModel
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
        /// This is the primary key of the Invoice Line record. For this field, you should use whatever the contact&#39;s unique
        /// identifying number is in the originating system. Search for a unique, non-changing number within the
        /// originating financial system for this record.
        ///
        /// Example: If you store your invoice line records in a database, whatever the primary key for the invoice
        /// line table is in the database should be the &quot;ErpKey&quot;.
        ///
        /// For more information, see [Identity Columns](https://developer.lockstep.io/docs/identity-columns).
        /// </summary>
        public string ErpKey { get; set; }

        /// <summary>
        /// The original primary key or unique ID of the invoice to which this line belongs.  This value should
        /// match the [Invoice ErpKey](https://developer.lockstep.io/docs/importing-invoices#erpkey) field on the
        /// [InvoiceSyncModel](https://developer.lockstep.io/docs/importing-invoices).
        /// </summary>
        public string InvoiceErpKey { get; set; }

        /// <summary>
        /// The network id of the parent Invoice.
        /// </summary>
        public Guid? InvoiceNetworkId { get; set; }

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
        /// </summary>
        public DateTime? ReportingDate { get; set; }

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
