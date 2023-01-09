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
    /// An Accounting Profile is a child of a Company Profile, and collectively,
    /// they comprise the identity and necessary information for an accounting  team
    /// to work with trading partners, financial institutions, auditors, and others.
    /// You can use Accounting Profiles to define an accounting function by what
    /// the function does and how to interface with the function.
    /// </summary>
    public class AccountingProfileModel
    {

        /// <summary>
        /// The unique ID of this record, automatically assigned by Lockstep when this record is
        /// added to the Lockstep platform.
        /// </summary>
        public Guid? AccountingProfileId { get; set; }

        /// <summary>
        /// The ID of the company profile to which this accounting profile belongs.
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
        /// The name of the accounting profile.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The type of the accounting profile.
        /// Some examples include &#39;AR&#39;, &#39;AP&#39;, &#39;AR+AP&#39;, &#39;General Accounting&#39;, &#39;Treasury&#39;, &#39;Payroll&#39;, &#39;Finance&#39;
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// The email address associated with the accounting profile.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// The phone number associated with the accounting profile.
        /// </summary>
        public string Phone { get; set; }

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
        public string Region { get; set; }

        /// <summary>
        /// The postal/zip code of the address.
        /// </summary>
        public string PostalCode { get; set; }

        /// <summary>
        /// The two character country code of the address.
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// The ID of the primary contact with which this accounting profile is associated.
        /// </summary>
        public Guid? PrimaryContactId { get; set; }

        /// <summary>
        /// The date on which this record was created.
        /// </summary>
        public DateTime? Created { get; set; }

        /// <summary>
        /// The ID of the user who created this accounting profile.
        /// </summary>
        public Guid? CreatedUserId { get; set; }

        /// <summary>
        /// The date on which this record was last modified.
        /// </summary>
        public DateTime? Modified { get; set; }

        /// <summary>
        /// The ID of the user who last modified this accounting profile.
        /// </summary>
        public Guid? ModifiedUserId { get; set; }

        /// <summary>
        /// A collection of notes linked to this record.  To retrieve this collection, specify `Notes` in the
        /// `include` parameter when retrieving data.
        ///
        /// To create a note, use the [Create Note](https://developer.lockstep.io/reference/post_api-v1-notes)
        /// endpoint with the `TableKey` to `AccountingProfile` and the `ObjectKey` set to the `AccountingProfileId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
        public NoteModel[] Notes { get; set; }

        /// <summary>
        /// A collection of attachments linked to this record.  To retrieve this collection, specify `Attachments` in
        /// the `include` parameter when retrieving data.
        ///
        /// To create an attachment, use the [Upload Attachment](https://developer.lockstep.io/reference/post_api-v1-attachments)
        /// endpoint with the `TableKey` to `AccountingProfile` and the `ObjectKey` set to the `AccountingProfileId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
        public AttachmentModel[] Attachments { get; set; }

        /// <summary>
        /// A collection of custom fields linked to this record.  To retrieve this collection, specify
        /// `CustomFieldDefinitions` in the `include` parameter when retrieving data.
        ///
        /// To create a custom field, use the [Create Custom Field](https://developer.lockstep.io/reference/post_api-v1-customfieldvalues)
        /// endpoint with the `TableKey` to `AccountingProfile` and the `ObjectKey` set to the `AccountingProfileId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
        public CustomFieldDefinitionModel[] CustomFieldDefinitions { get; set; }

        /// <summary>
        /// A collection of custom fields linked to this record.  To retrieve this collection, specify
        /// `CustomFieldValues` in the `include` parameter when retrieving data.
        ///
        /// To create a custom field, use the [Create Custom Field](https://developer.lockstep.io/reference/post_api-v1-customfieldvalues)
        /// endpoint with the `TableKey` to `AccountingProfile` and the `ObjectKey` set to the `AccountingProfileId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
        public CustomFieldValueModel[] CustomFieldValues { get; set; }
    }
}
