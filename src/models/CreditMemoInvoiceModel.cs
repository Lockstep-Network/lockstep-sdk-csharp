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
    /// Contains information about a credit memo invoice
    /// </summary>
    public class CreditMemoInvoiceModel
    {

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid? GroupKey { get; set; }

        /// <summary>
        /// The base currency code of the group.
        /// </summary>
        public string BaseCurrencyCode { get; set; }

        /// <summary>
        /// The currency code of the credit memo invoice.
        /// </summary>
        public string CurrencyCode { get; set; }

        /// <summary>
        /// The unique ID of this record, automatically assigned by Lockstep when this record is
        /// added to the Lockstep platform.
        /// </summary>
        public Guid? CreditMemoAppliedId { get; set; }

        /// <summary>
        /// The id of the invoice
        /// </summary>
        public Guid? InvoiceId { get; set; }

        /// <summary>
        /// The id of the credit memo invoice
        /// </summary>
        public Guid? CreditMemoInvoiceId { get; set; }

        /// <summary>
        /// Date invoice applied to credit memo.
        ///
        /// This is a date-only field stored as a string in ISO 8601 (YYYY-MM-DD) format.
        /// </summary>
        public string ApplyToInvoiceDate { get; set; }

        /// <summary>
        /// Amount applied to credit memo.
        /// </summary>
        public decimal? CreditMemoAppliedAmount { get; set; }

        /// <summary>
        /// The amount applied to credit memo in the group&#39;s base currency.
        /// </summary>
        public decimal? BaseCurrencyCreditMemoAppliedAmount { get; set; }

        /// <summary>
        /// An additional reference code that is sometimes used to identify this invoice.
        /// The meaning of this field is specific to the ERP or accounting system used by the user.
        /// </summary>
        public string ReferenceCode { get; set; }

        /// <summary>
        /// The ID number of the company that created this invoice.
        /// </summary>
        public Guid? CompanyId { get; set; }

        /// <summary>
        /// The ID number of the counterparty for the invoice, for example, a customer or vendor.
        /// </summary>
        public Guid? CustomerId { get; set; }

        /// <summary>
        /// A code identifying the status of this invoice.
        /// </summary>
        public string InvoiceStatusCode { get; set; }

        /// <summary>
        /// The total value of this invoice, inclusive of all taxes and line items.
        /// </summary>
        public decimal? TotalAmount { get; set; }

        /// <summary>
        /// The remaining balance value of this invoice.
        /// </summary>
        public decimal? OutstandingBalanceAmount { get; set; }

        /// <summary>
        /// The total value of this invoice, inclusive of all taxes and line items in the group&#39;s base currency.
        /// </summary>
        public decimal? BaseCurrencyTotalAmount { get; set; }

        /// <summary>
        /// The remaining balance value of this invoice in the group&#39;s base currency.
        /// </summary>
        public decimal? BaseCurrencyOutstandingBalanceAmount { get; set; }
    }
}
