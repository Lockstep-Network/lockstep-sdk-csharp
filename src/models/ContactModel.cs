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

namespace LockstepSDK
{

    /// <summary>
    /// A Contact contains information about a person or role within a Company.
    /// You can use Contacts to track information about who is responsible for a specific project,
    /// who handles invoices, or information about which role at a particular customer or
    /// vendor you should speak with about invoices.
    /// </summary>
    public class ContactModel
    {

        /// <summary>
        /// The unique ID of this record, automatically assigned by Lockstep when this record is
        /// added to the Lockstep platform.
        ///
        /// For the ID of this record in its originating financial system, see `ErpKey`.
        /// </summary>
        public Guid? ContactId { get; set; }

        /// <summary>
        /// The ID of the company to which this contact belongs.
        /// </summary>
        public Guid? CompanyId { get; set; }

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid? GroupKey { get; set; }

        /// <summary>
        /// The unique ID of this record as it was known in its originating financial system.
        ///
        /// If this contact record was imported from a financial system, it will have the value `ErpKey`
        /// set to the original primary key number of the record as it was known in the originating financial
        /// system.  If this record was not imported, this value will be `null`.
        ///
        /// For more information, see [Identity Columns](https://developer.lockstep.io/docs/identity-columns).
        /// </summary>
        public string ErpKey { get; set; }

        /// <summary>
        /// The name of the contact.
        /// </summary>
        public string ContactName { get; set; }

        /// <summary>
        /// A friendly human-readable code that describes this Contact.
        /// </summary>
        public string ContactCode { get; set; }

        /// <summary>
        /// The title of the contact.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The role code for the contact.
        /// </summary>
        public string RoleCode { get; set; }

        /// <summary>
        /// The email address of the contact.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// The phone number of the contact.
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// The fax number of the contact.
        /// </summary>
        public string Fax { get; set; }

        /// <summary>
        /// The first line of the address.
        /// </summary>
        public string Address1 { get; set; }

        /// <summary>
        /// The second line of the address.
        /// </summary>
        public string Address2 { get; set; }

        /// <summary>
        /// The third line of the address.
        /// </summary>
        public string Address3 { get; set; }

        /// <summary>
        /// The city of the address.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// The state/region of the address.
        /// </summary>
        public string StateRegion { get; set; }

        /// <summary>
        /// The postal/zip code of the address.
        /// </summary>
        public string PostalCode { get; set; }

        /// <summary>
        /// The two character country code of the address. This will be validated by the /api/v1/definitions/countries data set
        /// </summary>
        public string CountryCode { get; set; }

        /// <summary>
        /// Flag indicating if the contact is active.
        /// </summary>
        public bool? IsActive { get; set; }

        /// <summary>
        /// The webpage url of the contact.
        /// </summary>
        public string WebpageUrl { get; set; }

        /// <summary>
        /// The picture/avatar url of the contact.
        /// </summary>
        public string PictureUrl { get; set; }

        /// <summary>
        /// The date on which this record was created.
        /// </summary>
        public DateTime? Created { get; set; }

        /// <summary>
        /// The ID of the user who created this contact.
        /// </summary>
        public Guid? CreatedUserId { get; set; }

        /// <summary>
        /// The date on which this record was last modified.
        /// </summary>
        public DateTime? Modified { get; set; }

        /// <summary>
        /// The ID of the user who last modified this contact.
        /// </summary>
        public Guid? ModifiedUserId { get; set; }

        /// <summary>
        /// The AppEnrollmentId of the application that imported this record.  For accounts
        /// with more than one financial system connected, this field identifies the originating
        /// financial system that produced this record.  This value is null if this record
        /// was not loaded from an external ERP or financial system.
        /// </summary>
        public Guid? AppEnrollmentId { get; set; }

        /// <summary>
        /// A collection of notes linked to this record.  To retrieve this collection, specify `Notes` in the
        /// `include` parameter when retrieving data.
        ///
        /// To create a note, use the [Create Note](https://developer.lockstep.io/reference/post_api-v1-notes)
        /// endpoint with the `TableKey` to `Contact` and the `ObjectKey` set to the `ContactId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
        public NoteModel[] Notes { get; set; }

        /// <summary>
        /// A collection of attachments linked to this record.  To retrieve this collection, specify `Attachments` in
        /// the `include` parameter when retrieving data.
        ///
        /// To create an attachment, use the [Upload Attachment](https://developer.lockstep.io/reference/post_api-v1-attachments)
        /// endpoint with the `TableKey` to `Contact` and the `ObjectKey` set to the `ContactId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
        public AttachmentModel[] Attachments { get; set; }

        /// <summary>
        /// A collection of custom fields linked to this record.  To retrieve this collection, specify
        /// `CustomFieldDefinitions` in the `include` parameter when retrieving data.
        ///
        /// To create a custom field, use the [Create Custom Field](https://developer.lockstep.io/reference/post_api-v1-customfieldvalues)
        /// endpoint with the `TableKey` to `Contact` and the `ObjectKey` set to the `ContactId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
        public CustomFieldDefinitionModel[] CustomFieldDefinitions { get; set; }

        /// <summary>
        /// A collection of custom fields linked to this record.  To retrieve this collection, specify
        /// `CustomFieldValues` in the `include` parameter when retrieving data.
        ///
        /// To create a custom field, use the [Create Custom Field](https://developer.lockstep.io/reference/post_api-v1-customfieldvalues)
        /// endpoint with the `TableKey` to `Contact` and the `ObjectKey` set to the `ContactId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
        public CustomFieldValueModel[] CustomFieldValues { get; set; }
    }
}
