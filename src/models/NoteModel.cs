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
    /// A note is a customizable text string that can be attached to various account attributes
    /// within Lockstep. You can use notes for internal communication, correspondence with
    /// clients, or personal reminders. The Note Model represents a note and a number of
    /// different metadata attributes related to the creation, storage, and ownership of the note.
    ///
    /// See [Extensibility](https://developer.lockstep.io/docs/extensibility) for more information.
    /// </summary>
    public class NoteModel
    {

        /// <summary>
        /// The unique ID of this record, automatically assigned by Lockstep when this record is
        /// added to the Lockstep platform.
        /// </summary>
        public Guid? NoteId { get; set; }

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid? GroupKey { get; set; }

        /// <summary>
        /// A Note is connected to an existing item within the Lockstep Platform by the fields `TableKey` and
        /// `ObjectKey`.  For example, a Note connected to Invoice 12345 would have a `TableKey` value of
        /// `Invoice` and an `ObjectKey` value of `12345`.
        ///
        /// The `TableKey` value contains the name of the table within the Lockstep Platform to which this metadata
        /// is connected.
        ///
        /// For more information, see [linking metadata to an object](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
        public string TableKey { get; set; }

        /// <summary>
        /// A Note is connected to an existing item within the Lockstep Platform by the fields `TableKey` and
        /// `ObjectKey`.  For example, a Note connected to Invoice 12345 would have a `TableKey` value of
        /// `Invoice` and an `ObjectKey` value of `12345`.
        ///
        /// The `ObjectKey` value contains the primary key of the record within the Lockstep Platform to which this
        /// metadata is connected.
        ///
        /// For more information, see [linking metadata to an object](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
        public Guid? ObjectKey { get; set; }

        /// <summary>
        /// The full text of the note
        /// </summary>
        public string NoteText { get; set; }

        /// <summary>
        /// The type of the note
        /// </summary>
        public string NoteType { get; set; }

        /// <summary>
        /// A flag indicating whether this Note is archived (also known as hidden or deleted).  When you call
        /// [ArchiveNote](https://developer.lockstep.io/reference/delete_api-v1-notes-id) this field will
        /// be set to true.
        ///
        /// You should avoid displaying Notes with the IsArchived field set to true in your user interface.
        /// </summary>
        public bool? IsArchived { get; set; }

        /// <summary>
        /// The date the note was created
        /// </summary>
        public DateTime? Created { get; set; }

        /// <summary>
        /// The unique ID of the [UserAccount](https://developer.lockstep.io/docs/useraccountmodel) of the user
        /// who created this Note.
        /// </summary>
        public Guid? CreatedUserId { get; set; }

        /// <summary>
        /// The name of the user who created the note
        /// </summary>
        public string CreatedUserName { get; set; }

        /// <summary>
        /// The AppEnrollmentId of the application that imported this record.  For accounts
        /// with more than one financial system connected, this field identifies the originating
        /// financial system that produced this record.  This value is null if this record
        /// was not loaded from an external ERP or financial system.
        /// </summary>
        public Guid? AppEnrollmentId { get; set; }

        /// <summary>
        /// The person to whom this note is intended for.
        /// </summary>
        public string RecipientName { get; set; }
    }
}
