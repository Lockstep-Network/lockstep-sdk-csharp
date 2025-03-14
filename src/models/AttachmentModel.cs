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
    /// An Attachment is a file that can be attached to various account attributes within ADS.
    /// This data model contains metadata about the attachment.  You can upload and download attachments
    /// into the ADS Platform along with this metadata.  Attachments can be used for invoices, payments,
    /// legal documents, or any other external files that you wish to track.
    ///
    /// See [Extensibility](https://developer.lockstep.io/docs/extensibility) for more information.
    /// </summary>
    public class AttachmentModel
    {

        /// <summary>
        /// The unique ID of this record, automatically assigned by ADS when this record is
        /// added to the ADS Platform.
        /// </summary>
        public Guid? AttachmentId { get; set; }

        /// <summary>
        /// The GroupKey uniquely identifies a single ADS Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid? GroupKey { get; set; }

        /// <summary>
        /// An Attachment is connected to an existing item within the ADS Platform by the fields `TableKey` and
        /// `ObjectKey`.  For example, an Attachment connected to Invoice 12345 would have a `TableKey` value of
        /// `Invoice` and an `ObjectKey` value of `12345`.
        ///
        /// The `TableKey` value contains the name of the table within the ADS Platform to which this Attachment
        /// is connected.
        ///
        /// For more information, see [linking metadata to an object](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
        public string TableKey { get; set; }

        /// <summary>
        /// An Attachment is connected to an existing item within the ADS Platform by the fields `TableKey` and
        /// `ObjectKey`.  For example, an Attachment connected to Invoice 12345 would have a `TableKey` value of
        /// `Invoice` and an `ObjectKey` value of `12345`.
        ///
        /// The `ObjectKey` value contains the primary key of the record within the ADS Platform to which this
        /// Attachment is connected.
        ///
        /// For more information, see [linking metadata to an object](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
        public Guid? ObjectKey { get; set; }

        /// <summary>
        /// An Attachment represents a file that was uploaded to the ADS Platform.  This field contains the original
        /// name of the file on disk, without its extension.
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// An Attachment represents a file that was uploaded to the ADS Platform.  This field contains the original
        /// extension name of the file on disk.
        /// </summary>
        public string FileExt { get; set; }

        /// <summary>
        /// A flag indicating whether this Attachment is archived (also known as hidden or deleted).  When you call
        /// [ArchiveAttachment](https://developer.lockstep.io/reference/delete_api-v1-attachments-id) this field will
        /// be set to true.
        ///
        /// You should avoid displaying Attachments with the IsArchived field set to true in your user interface.
        /// </summary>
        public bool? IsArchived { get; set; }

        /// <summary>
        /// The unique ID of this record as it was known in its originating financial system.
        ///
        /// If this company record was imported from a financial system, it will have the value `ErpKey`
        /// set to the original primary key number of the record as it was known in the originating financial
        /// system.  If this record was not imported from a financial system, this value will be `null`.
        ///
        /// For more information, see [Identity Columns](https://developer.lockstep.io/docs/identity-columns).
        /// </summary>
        public string ErpKey { get; set; }

        /// <summary>
        /// The AppEnrollmentId of the application that imported this record.  For accounts
        /// with more than one financial system connected, this field identifies the originating
        /// financial system that produced this record.  This value is null if this record
        /// was not loaded from an external ERP or financial system.
        /// </summary>
        public Guid? AppEnrollmentId { get; set; }

        /// <summary>
        /// The date the attachment was created.
        /// </summary>
        public DateTime? Created { get; set; }

        /// <summary>
        /// The unique ID of the [UserAccount](https://developer.lockstep.io/docs/useraccountmodel) of the user
        /// who created this Attachment.
        /// </summary>
        public Guid? CreatedUserId { get; set; }

        /// <summary>
        /// The date the attachment was modified.
        /// </summary>
        public DateTime? Modified { get; set; }

        /// <summary>
        /// The unique ID of the [UserAccount](https://developer.lockstep.io/docs/useraccountmodel) of the user
        /// who modified this Attachment.
        /// </summary>
        public Guid? ModifiedUserId { get; set; }

        /// <summary>
        /// A text string describing the type of this Attachment.
        /// </summary>
        public string AttachmentType { get; set; }

        /// <summary>
        /// The different statuses of an attachment being scanned for viruses.
        /// </summary>
        public string UploadStatus { get; set; }
    }
}
