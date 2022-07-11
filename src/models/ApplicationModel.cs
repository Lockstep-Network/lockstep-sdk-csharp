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
    /// An Application represents a feature available to customers within the Lockstep Platform.  You can create
    /// Applications by working with your Lockstep business development manager and publish them on the platform
    /// so that customers can browse and find your Application on the Lockstep Platform Marketplace.  When a
    /// customer adds an Application to their account, they obtain an AppEnrollment which represents that customer&#39;s
    /// instance of this Application.  The customer-specific AppEnrollment contains a customer&#39;s configuration data
    /// for the Application, which is not customer-specific.
    ///
    /// See [Applications and Enrollments](https://developer.lockstep.io/docs/applications-and-enrollments) for more information.
    /// --swaggerCategory:Platform
    /// </summary>
    public class ApplicationModel
    {

        /// <summary>
        /// A unique code identifying this application
        /// </summary>
        public Guid? AppId { get; set; }

        /// <summary>
        /// The name of this application
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Brief summary of this application shown as a subtitle
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Tag for what type of app this is
        /// </summary>
        public string AppType { get; set; }

        /// <summary>
        /// The ID of the owner
        /// </summary>
        public Guid? OwnerId { get; set; }

        /// <summary>
        /// The URL to visit for more information about this application
        /// </summary>
        public string ProjectUrl { get; set; }

        /// <summary>
        /// The URL for the icon for this application
        /// </summary>
        public string IconUrl { get; set; }

        /// <summary>
        /// The description of the price for this application
        /// </summary>
        public string PriceTerms { get; set; }

        /// <summary>
        /// The ID of the user who created this application
        /// </summary>
        public Guid? CreatedUserId { get; set; }

        /// <summary>
        /// The ID of the user who last modified this application
        /// </summary>
        public Guid? ModifiedUserId { get; set; }

        /// <summary>
        /// The date this application was created
        /// </summary>
        public DateTime? Created { get; set; }

        /// <summary>
        /// The date this application was last modified
        /// </summary>
        public DateTime? Modified { get; set; }

        /// <summary>
        /// Flag indicating if the application is active.
        /// </summary>
        public bool? IsActive { get; set; }

        /// <summary>
        /// URL to the Wiki for the Application
        /// </summary>
        public string WikiURL { get; set; }

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid? GroupKey { get; set; }

        /// <summary>
        /// A collection of notes linked to this record.  To retrieve this collection, specify `Notes` in the
        /// `include` parameter when retrieving data.
        ///
        /// To create a note, use the [Create Note](https://developer.lockstep.io/reference/post_api-v1-notes)
        /// endpoint with the `TableKey` to `Application` and the `ObjectKey` set to the `ApplicationId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
        public NoteModel[] Notes { get; set; }

        /// <summary>
        /// A collection of attachments linked to this record.  To retrieve this collection, specify `Attachments` in
        /// the `include` parameter when retrieving data.
        ///
        /// To create an attachment, use the [Upload Attachment](https://developer.lockstep.io/reference/post_api-v1-attachments)
        /// endpoint with the `TableKey` to `Application` and the `ObjectKey` set to the `ApplicationId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
        public AttachmentModel[] Attachments { get; set; }

        /// <summary>
        /// A collection of custom fields linked to this record.  To retrieve this collection, specify
        /// `CustomFieldDefinitions` in the `include` parameter when retrieving data.
        ///
        /// To create a custom field, use the [Create Custom Field](https://developer.lockstep.io/reference/post_api-v1-customfieldvalues)
        /// endpoint with the `TableKey` to `Application` and the `ObjectKey` set to the `ApplicationId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
        public CustomFieldDefinitionModel[] CustomFieldDefinitions { get; set; }

        /// <summary>
        /// A collection of custom fields linked to this record.  To retrieve this collection, specify
        /// `CustomFieldValues` in the `include` parameter when retrieving data.
        ///
        /// To create a custom field, use the [Create Custom Field](https://developer.lockstep.io/reference/post_api-v1-customfieldvalues)
        /// endpoint with the `TableKey` to `Application` and the `ObjectKey` set to the `ApplicationId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
        public CustomFieldValueModel[] CustomFieldValues { get; set; }
    }
}
