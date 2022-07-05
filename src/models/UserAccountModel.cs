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
    /// A User represents a person who has the ability to authenticate against the Lockstep Platform and use
    /// services such as Lockstep Inbox.  A User is uniquely identified by an Azure identity, and each user must
    /// have an email address defined within their account.  All Users must validate their email to make use of
    /// Lockstep platform services.  Users may have different privileges and access control rights within the
    /// Lockstep Platform.
    /// </summary>
    public class UserAccountModel
    {

        /// <summary>
        /// The unique ID of this record, automatically assigned by Lockstep when this record is
        /// added to the Lockstep platform.
        ///
        /// This record provides a link to the user&#39;s Azure AD B2C OID.
        /// </summary>
        public Guid? UserId { get; set; }

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid? GroupKey { get; set; }

        /// <summary>
        /// The full name of the user
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// The email of the user
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// The status of the user&#39;s account
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// The date that the user account was created
        /// </summary>
        public DateTime? Created { get; set; }

        /// <summary>
        /// The ID of the user who created the user account
        /// </summary>
        public Guid? CreatedUserId { get; set; }

        /// <summary>
        /// The date the user account was last modified
        /// </summary>
        public DateTime? Modified { get; set; }

        /// <summary>
        /// The ID of the user who last modified the user account
        /// </summary>
        public Guid? ModifiedUserId { get; set; }

        /// <summary>
        /// The name of the user who last modified the user account
        /// </summary>
        public string ModifiedUserName { get; set; }

        /// <summary>
        /// The ID of the user in Azure B2C
        /// </summary>
        public Guid? B2CUserId { get; set; }

        /// <summary>
        /// The id of the Permission Level for the user.
        /// </summary>
        public Guid? UserRole { get; set; }

        /// <summary>
        /// The date timestamp when the invite was sent to the user.
        /// </summary>
        public DateTime? InviteSent { get; set; }

        /// <summary>
        /// The phone number of the user.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// The fax number of the user.
        /// </summary>
        public string FaxNumber { get; set; }

        /// <summary>
        /// The title of the user; free text field
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// FK to the CodeDefinition table; CodeType = &#39;AccountingRole&#39;
        /// </summary>
        public Guid? AccountingRoleCodeDefId { get; set; }

        /// <summary>
        /// Address Line 1 for this User
        /// </summary>
        public string Address1 { get; set; }

        /// <summary>
        /// Address Line 2 for this User
        /// </summary>
        public string Address2 { get; set; }

        /// <summary>
        /// Address Line 3 for this User
        /// </summary>
        public string Address3 { get; set; }

        /// <summary>
        /// City for this User
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Region (&quot;state&quot; in the US) for this User
        /// </summary>
        public string StateRegion { get; set; }

        /// <summary>
        /// Postal Code this User
        /// </summary>
        public string PostalCode { get; set; }

        /// <summary>
        /// Country for this User This will be validated by the /api/v1/definitions/countries data set
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Time zone for this user
        /// </summary>
        public string TimeZone { get; set; }

        /// <summary>
        /// Image URL for this User
        /// </summary>
        public string ImageURL { get; set; }

        /// <summary>
        /// Description for this User.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Last date time user logged into Azure B2C.
        /// </summary>
        public DateTime? B2CLastLoggedIn { get; set; }

        /// <summary>
        /// The default currency code used by this user entity.  This value can be overridden
        /// for invoices in a different currency code.
        ///
        /// For a list of defined currency codes, see [Query Currencies](https://developer.lockstep.io/reference/get_api-v1-definitions-currencies) This will be validated by the /api/v1/definitions/currencies data set
        /// </summary>
        public string DefaultCurrencyCode { get; set; }

        /// <summary>
        /// A collection of notes linked to this record.  To retrieve this collection, specify `Notes` in the
        /// `include` parameter when retrieving data.
        ///
        /// To create a note, use the [Create Note](https://developer.lockstep.io/reference/post_api-v1-notes)
        /// endpoint with the `TableKey` to `UserAccount` and the `ObjectKey` set to the `UserId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
        public NoteModel[] Notes { get; set; }

        /// <summary>
        /// A collection of attachments linked to this record.  To retrieve this collection, specify `Attachments` in
        /// the `include` parameter when retrieving data.
        ///
        /// To create an attachment, use the [Upload Attachment](https://developer.lockstep.io/reference/post_api-v1-attachments)
        /// endpoint with the `TableKey` to `UserAccount` and the `ObjectKey` set to the `UserId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
        public AttachmentModel[] Attachments { get; set; }

        /// <summary>
        /// A collection of custom fields linked to this record.  To retrieve this collection, specify
        /// `CustomFieldValues` in the `include` parameter when retrieving data.
        ///
        /// To create a custom field, use the [Create Custom Field](https://developer.lockstep.io/reference/post_api-v1-customfieldvalues)
        /// endpoint with the `TableKey` to `UserAccount` and the `ObjectKey` set to the `UserId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
        public CustomFieldValueModel[] CustomFieldValues { get; set; }

        /// <summary>
        /// Accounting role definition for this User.
        /// To retrieve this collection, specify `AccountingRole` in the &quot;Include&quot; parameter for your query.
        /// </summary>
        public CodeDefinitionModel AccountingRoleCodeDefinition { get; set; }
    }
}
