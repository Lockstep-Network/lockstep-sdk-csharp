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
    /// The JournalEntryLineSyncModel represents information coming into Lockstep from an external financial system or other
    /// enterprise resource planning system.  To import data from an external system, convert your original data into
    /// the JournalEntryLineSyncModel format and call the [Upload Sync File API](https://developer.lockstep.io/reference/post_api-v1-sync-zip).
    /// This API retrieves all of the data you uploaded in a compressed ZIP file and imports it into the Lockstep
    /// platform.
    ///
    /// Once imported, this record will be available in the Lockstep API as a JournalEntryLineModel
    ///
    /// For more information on writing your own connector, see [Connector Data](https://developer.lockstep.io/docs/connector-data).
    /// </summary>
    public class JournalEntryLineSyncModel
    {

        /// <summary>
        /// Indicates what action to take when an existing object has been found during the sync process.
        /// </summary>
        public int? OnMatchAction { get; set; }

        /// <summary>
        /// This is the primary key of the Journal Entry Line record. For this field, you should use whatever the Journal Entry Line&#39;s unique
        /// identifying number is in the originating system. Search for a unique, non-changing number within the
        /// originating financial system for this record.
        ///
        /// Example: If you store your Journal Entry Line records in a database, whatever the primary key for the Journal Entry Line table is
        /// in the database should be the &quot;ErpKey&quot;.
        ///
        /// For more information, see [Identity Columns](https://developer.lockstep.io/docs/identity-columns).
        /// </summary>
        public string ErpKey { get; set; }

        /// <summary>
        /// The original primary key or unique ID of the journal entry to which this line belongs.  This value should
        /// match the Journal Entry ErpKey field on the JournalEntrySyncModel.
        /// </summary>
        public string JournalEntryErpKey { get; set; }

        /// <summary>
        /// An optional Financial Account with which this line is associated. This value should
        /// match the Financial Account ErpKey field on the FinancialAccountSyncModel.
        /// </summary>
        public string FinancialAccountErpKey { get; set; }

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
        /// A JSON string representing the dimensions for this journal entry line.
        /// </summary>
        public object Dimensions { get; set; }

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
