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
    /// Contains information about a journal entry line
    /// </summary>
    public class JournalEntryLineModel
    {

        /// <summary>
        /// The unique ID of this record, automatically assigned by Lockstep when this record is
        /// added to the Lockstep platform.
        ///
        /// For the ID of this record in its originating financial system, see `ErpKey`.
        /// </summary>
        public Guid? JournalEntryLineId { get; set; }

        /// <summary>
        /// The Journal Entry with which this line is associated.
        /// </summary>
        public Guid? JournalEntryId { get; set; }

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid? GroupKey { get; set; }

        /// <summary>
        /// The AppEnrollmentId of the application that imported this record.  For accounts
        /// with more than one financial system connected, this field identifies the originating
        /// financial system that produced this record.  This value is null if this record
        /// was not loaded from an external ERP or financial system.
        /// </summary>
        public Guid? AppEnrollmentId { get; set; }

        /// <summary>
        /// The unique ID of this record as it was known in its originating financial system.
        ///
        /// If this journal entry record was imported from a financial system, it will have the value `ErpKey`
        /// set to the original primary key number of the record as it was known in the originating financial
        /// system.  If this record was not imported, this value will be `null`.
        ///
        /// For more information, see [Identity Columns](https://developer.lockstep.io/docs/identity-columns).
        /// </summary>
        public string ErpKey { get; set; }

        /// <summary>
        /// The Financial Account with which this line is associated.
        /// </summary>
        public Guid? FinancialAccountId { get; set; }

        /// <summary>
        /// The unique code/identifier assigned to each account in the chart of accounts.
        /// </summary>
        public string AccountNumber { get; set; }

        /// <summary>
        /// The name of the account.
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// Debit to account.
        /// </summary>
        public decimal? Debit { get; set; }

        /// <summary>
        /// Credit to account.
        /// </summary>
        public decimal? Credit { get; set; }

        /// <summary>
        /// The transaction currency in which the entry is recorded, especially useful for multi-currency environments.
        /// </summary>
        public string CurrencyCode { get; set; }

        /// <summary>
        /// The base currency debit amount for the account.
        /// </summary>
        public decimal? BaseDebit { get; set; }

        /// <summary>
        /// The base currency credit amount for the account.
        /// </summary>
        public decimal? BaseCredit { get; set; }

        /// <summary>
        /// The base currency in which the entry is recorded, especially useful for multi-currency environments.
        /// </summary>
        public string BaseCurrencyCode { get; set; }

        /// <summary>
        /// The ERP’s identifier for the user who recorded the journal entry line.
        /// </summary>
        public string SourceCreatedUser { get; set; }

        /// <summary>
        /// A memo related to this line.
        /// </summary>
        public string Memo { get; set; }

        /// <summary>
        /// Dimensions for this journal entry line.
        /// </summary>
        public object Dimensions { get; set; }

        /// <summary>
        /// The date that the journal entry line was created.
        /// </summary>
        public DateTime? Created { get; set; }

        /// <summary>
        /// The ID of the user who created the journal entry line.
        /// </summary>
        public Guid? CreatedUserId { get; set; }

        /// <summary>
        /// The date that the journal entry line was last modified.
        /// </summary>
        public DateTime? Modified { get; set; }

        /// <summary>
        /// The ID of the user who last modified the journal entry line.
        /// </summary>
        public Guid? ModifiedUserId { get; set; }

        /// <summary>
        /// The date on which this record was last modified in source ERP.
        /// </summary>
        public DateTime? SourceModifiedDate { get; set; }

        /// <summary>
        /// The journal entry for this journal entry line.
        /// To retrieve this item, specify `JournalEntry` in the &quot;Include&quot; parameter for your query.
        /// </summary>
        public JournalEntryModel JournalEntry { get; set; }
    }
}
