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
    /// Represents a magic link that can be used to log in to a ADS Platform application.
    /// </summary>
    public class MagicLinkModel
    {

        /// <summary>
        /// The unique ID of this record, automatically assigned by ADS when this record is
        /// added to the ADS Platform.
        /// </summary>
        public Guid? MagicLinkId { get; set; }

        /// <summary>
        /// The GroupKey uniquely identifies a single ADS Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        /// </summary>
        public Guid? GroupKey { get; set; }

        /// <summary>
        /// The unique ID of the user that this magic link is associated with.
        /// </summary>
        public Guid? UserId { get; set; }

        /// <summary>
        /// The ID of the user role for the magic link.
        /// </summary>
        public Guid? UserRole { get; set; }

        /// <summary>
        /// The ID of the application for this magic link.
        /// </summary>
        public Guid? ApplicationId { get; set; }

        /// <summary>
        /// The UTC date and time when this magic link expires.
        /// </summary>
        public DateTime? Expires { get; set; }

        /// <summary>
        /// The UTC date and time when this magic link was revoked.
        /// </summary>
        public DateTime? Revoked { get; set; }

        /// <summary>
        /// The date that the magic link was created
        /// </summary>
        public DateTime? Created { get; set; }

        /// <summary>
        /// The ID of the user who created the magic link
        /// </summary>
        public Guid? CreatedUserId { get; set; }

        /// <summary>
        /// The date that the magic link was last modified
        /// </summary>
        public DateTime? Modified { get; set; }

        /// <summary>
        /// The ID of the user who last modified the magic link
        /// </summary>
        public Guid? ModifiedUserId { get; set; }

        /// <summary>
        /// The ID of the company associated to this magic link
        /// </summary>
        public Guid? CompanyId { get; set; }

        /// <summary>
        /// The ID of the accounting profile associated to this magic link
        /// </summary>
        [Obsolete("This field is deprecated.")]
        public Guid? AccountingProfileId { get; set; }

        /// <summary>
        /// The created magic link URL. This will only be returned upon creation of the magic link.
        /// All other times, this value will be `null`.
        /// </summary>
        public string MagicLinkUrl { get; set; }

        /// <summary>
        /// The user associated with this magic link.
        /// To retrieve this item, specify `User` in the &quot;Include&quot; parameter for your query.
        /// </summary>
        public UserAccountModel User { get; set; }

        /// <summary>
        /// The number of visits to this Magic Link
        /// </summary>
        public int? Visits { get; set; }

        /// <summary>
        /// Possible statuses for a Magic Link.
        /// </summary>
        public int? Status { get; set; }

        /// <summary>
        /// A collection of notes linked to this record.  To retrieve this collection, specify `Notes` in the
        /// `include` parameter when retrieving data.
        ///
        /// To create a note, use the [Create Note](https://developer.lockstep.io/reference/post_api-v1-notes)
        /// endpoint with the `TableKey` to `MagicLink` and the `ObjectKey` set to the `MagicLinkId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
        public NoteModel[] Notes { get; set; }

        /// <summary>
        /// A collection of custom fields linked to this record.  To retrieve this collection, specify
        /// `CustomFieldValues` in the `include` parameter when retrieving data.
        ///
        /// To create a custom field, use the [Create Custom Field](https://developer.lockstep.io/reference/post_api-v1-customfieldvalues)
        /// endpoint with the `TableKey` to `MagicLink` and the `ObjectKey` set to the `MagicLinkId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
        public CustomFieldValueModel[] CustomFieldValues { get; set; }
    }
}
