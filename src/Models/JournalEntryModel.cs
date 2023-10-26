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
    /// Contains information about a journal entry
    /// </summary>
    public class JournalEntryModel
    {

        /// <summary>
        /// The unique ID of this record, automatically assigned by Lockstep when this record is
        /// added to the Lockstep platform.
        ///
        /// For the ID of this record in its originating financial system, see `ErpKey`.
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
        /// The ERP’s identifier for this journal entry, usually has meaning to the user.
        /// May be the same value of the ERP Key.
        /// </summary>
        public string JournalId { get; set; }

        /// <summary>
        /// Possible sources for a Journal Entry.
        /// </summary>
        public int? Source { get; set; }

        /// <summary>
        /// The UTC date and time when this journal entry was posted.
        /// </summary>
        public DateTime? PostingDate { get; set; }

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
        /// The date that the journal entry was created.
        /// </summary>
        public DateTime? Created { get; set; }

        /// <summary>
        /// The ID of the user who created the journal entry.
        /// </summary>
        public Guid? CreatedUserId { get; set; }

        /// <summary>
        /// The date that the journal entry was last modified.
        /// </summary>
        public DateTime? Modified { get; set; }

        /// <summary>
        /// The ID of the user who last modified the journal entry.
        /// </summary>
        public Guid? ModifiedUserId { get; set; }

        /// <summary>
        /// The date on which this record was last modified in source ERP.
        /// </summary>
        public DateTime? SourceModifiedDate { get; set; }

        /// <summary>
        /// All lines attached to this journal entry.
        /// To retrieve this collection, specify `Lines` in the &quot;Include&quot; parameter for your query.
        /// </summary>
        public JournalEntryLineModel[] Lines { get; set; }

        /// <summary>
        /// A collection of attachments linked to this record.  To retrieve this collection, specify `Attachments` in
        /// the `include` parameter when retrieving data.
        ///
        /// To create an attachment, use the [Upload Attachment](https://developer.lockstep.io/reference/post_api-v1-attachments)
        /// endpoint with the `TableKey` to `Invoice` and the `ObjectKey` set to the `InvoiceId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
        public AttachmentModel[] Attachments { get; set; }
    }
}
