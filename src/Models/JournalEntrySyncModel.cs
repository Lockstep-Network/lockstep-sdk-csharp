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
    /// The JournalEntrySyncModel represents information coming into ADS from an external financial system or other
    /// enterprise resource planning system.  To import data from an external system, convert your original data into
    /// the JournalEntrySyncModel format and call the [Upload Sync File API](https://developer.lockstep.io/reference/post_api-v1-sync-zip).
    /// This API retrieves all of the data you uploaded in a compressed ZIP file and imports it into the ADS
    /// Platform.
    ///
    /// Once imported, this record will be available in the ADS Platform API as a JournalEntryModel
    ///
    /// For more information on writing your own connector, see [Connector Data](https://developer.lockstep.io/docs/connector-data).
    /// </summary>
    public class JournalEntrySyncModel
    {

        /// <summary>
        /// Indicates what action to take when an existing object has been found during the sync process.
        /// </summary>
        public int? OnMatchAction { get; set; }

        /// <summary>
        /// This is the primary key of the Journal Entry record. For this field, you should use whatever the Journal Entry&#39;s unique
        /// identifying number is in the originating system. Search for a unique, non-changing number within the
        /// originating financial system for this record.
        ///
        /// Example: If you store your Journal Entry records in a database, whatever the primary key for the Journal Entry table is
        /// in the database should be the &quot;ErpKey&quot;.
        ///
        /// For more information, see [Identity Columns](https://developer.lockstep.io/docs/identity-columns).
        /// </summary>
        public string ErpKey { get; set; }

        /// <summary>
        /// The ERP’s identifier for this journal entry, usually has meaning to the user.
        /// May be the same value of the ERP Key.
        /// </summary>
        public string JournalId { get; set; }

        /// <summary>
        /// Possible sources for a Journal Entry.
        /// </summary>
        public int? Source { get; set; }

        /// <summary>
        /// Possible statuses for a Journal Entry.
        /// </summary>
        public int? Status { get; set; }

        /// <summary>
        /// A brief description explaining the purpose of the journal entry.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// An additional comment related to the entry.
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// Any reference number or identifier associated with the entry, such as an invoice number or purchase order.
        /// </summary>
        public string ReferenceNumber { get; set; }

        /// <summary>
        /// The raw posting date from the source.
        /// </summary>
        public DateTime? SourcePostingDate { get; set; }

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
