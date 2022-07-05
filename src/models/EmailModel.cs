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
    /// An Email represents a communication sent from one company to another.  The creator of the email is identified
    /// by the `CompanyId` field, recipient(s) by the `EmailTo` field, and cc recipient(s) by the &#39;EmailCC&#39; field.
    /// The Email Model represents an email and a number of different metadata attributes related to the creation,
    /// storage, and ownership of the email.
    /// </summary>
    public class EmailModel
    {

        /// <summary>
        /// The unique ID of this record, automatically assigned by Lockstep when this record is
        /// added to the Lockstep platform.
        /// </summary>
        public Guid? EmailId { get; set; }

        /// <summary>
        /// The unique ID number of this email&#39;s conversation thread.
        /// </summary>
        public Guid? ThreadId { get; set; }

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid? GroupKey { get; set; }

        /// <summary>
        /// The ID number of the company that created this email.
        /// </summary>
        public Guid? CompanyId { get; set; }

        /// <summary>
        /// The email address for the sender of this email.
        /// </summary>
        public string EmailFrom { get; set; }

        /// <summary>
        /// The email address for the recipient(s) of this email.
        /// </summary>
        public string EmailTo { get; set; }

        /// <summary>
        /// The email address for the CC recipient(s) of this email
        /// </summary>
        public string EmailCC { get; set; }

        /// <summary>
        /// The subject line of this email.
        /// </summary>
        public string EmailSubject { get; set; }

        /// <summary>
        /// The body content of this email.
        /// </summary>
        public string EmailBody { get; set; }

        /// <summary>
        /// The date on which this email was sent.
        /// </summary>
        public DateTime? SentDate { get; set; }

        /// <summary>
        /// A status flag indicating if this email is unread.
        /// </summary>
        public bool? IsUnread { get; set; }

        /// <summary>
        /// A status flag indicating if this email is priority status.
        /// </summary>
        public bool? IsPriority { get; set; }

        /// <summary>
        /// A status flag indicating if this email is marked as spam.
        /// </summary>
        public bool? IsSpam { get; set; }

        /// <summary>
        /// The date on which this email was created.
        /// </summary>
        public DateTime? Created { get; set; }

        /// <summary>
        /// The ID number of the user who created this email.
        /// </summary>
        public Guid? CreatedUserId { get; set; }

        /// <summary>
        /// A status flag indicating if this email is to be sent.
        /// </summary>
        public bool? ToBeSent { get; set; }

        /// <summary>
        /// The ID number of the customer that sent this email.
        /// </summary>
        public Guid? CustomerId { get; set; }

        /// <summary>
        /// The date on which this email was received.
        /// </summary>
        public DateTime? ReceivedTimeStamp { get; set; }

        /// <summary>
        /// The date on which this email was opened.
        /// </summary>
        public DateTime? OpenedTimestamp { get; set; }

        /// <summary>
        /// The number of times this email was viewed.
        /// </summary>
        public int? ViewCount { get; set; }

        /// <summary>
        /// The AppEnrollmentId of the application that imported this record.  For accounts
        /// with more than one financial system connected, this field identifies the originating
        /// financial system that produced this record.  This value is null if this record
        /// was not loaded from an external ERP or financial system.
        /// </summary>
        public Guid? AppEnrollmentId { get; set; }

        /// <summary>
        /// The id of the email in an external system if imported.
        /// </summary>
        public string ExternalEmailId { get; set; }

        /// <summary>
        /// The id of the email thread in an external system if imported.
        /// </summary>
        public string ExternalThreadId { get; set; }

        /// <summary>
        /// The email address(es) for the BCC recipient(s) of this email
        /// </summary>
        public string EmailBcc { get; set; }

        /// <summary>
        /// The type message being sent (New, Reply, Forward) or null for messages not being sent.
        /// </summary>
        public string SendType { get; set; }

        /// <summary>
        /// The date on which this email was modified.
        /// Email modification should only be done by internal services.
        /// </summary>
        public DateTime? Modified { get; set; }

        /// <summary>
        /// The ID of the user who modified this email.
        /// Email modification should only be done by internal services.
        /// </summary>
        public Guid? ModifiedUserId { get; set; }

        /// <summary>
        /// If the message being sent is a reply or a forward, the id of the the email being replied to or forwarded.
        /// Otherwise null.
        /// </summary>
        public Guid? ResponseOriginId { get; set; }

        /// <summary>
        /// The email object associated with the response origin id.
        /// </summary>
        public EmailModel ResponseOrigin { get; set; }

        /// <summary>
        /// A collection of notes linked to this record.  To retrieve this collection, specify `Notes` in the
        /// `include` parameter when retrieving data.
        ///
        /// To create a note, use the [Create Note](https://developer.lockstep.io/reference/post_api-v1-notes)
        /// endpoint with the `TableKey` to `Email` and the `ObjectKey` set to the `EmailId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
        public NoteModel[] Notes { get; set; }

        /// <summary>
        /// A collection of attachments linked to this record.  To retrieve this collection, specify `Attachments` in
        /// the `include` parameter when retrieving data.
        ///
        /// To create an attachment, use the [Upload Attachment](https://developer.lockstep.io/reference/post_api-v1-attachments)
        /// endpoint with the `TableKey` to `Email` and the `ObjectKey` set to the `EmailId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
        public AttachmentModel[] Attachments { get; set; }

        /// <summary>
        /// A collection of custom fields linked to this record.  To retrieve this collection, specify
        /// `CustomFieldDefinitions` in the `include` parameter when retrieving data.
        ///
        /// To create a custom field, use the [Create Custom Field](https://developer.lockstep.io/reference/post_api-v1-customfieldvalues)
        /// endpoint with the `TableKey` to `Email` and the `ObjectKey` set to the `EmailId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
        public CustomFieldDefinitionModel[] CustomFieldDefinitions { get; set; }

        /// <summary>
        /// A collection of custom fields linked to this record.  To retrieve this collection, specify
        /// `CustomFieldValues` in the `include` parameter when retrieving data.
        ///
        /// To create a custom field, use the [Create Custom Field](https://developer.lockstep.io/reference/post_api-v1-customfieldvalues)
        /// endpoint with the `TableKey` to `Email` and the `ObjectKey` set to the `EmailId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
        public CustomFieldValueModel[] CustomFieldValues { get; set; }
    }
}
