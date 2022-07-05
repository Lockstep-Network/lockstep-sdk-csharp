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
    /// An AppEnrollment represents an app that has been enrolled to the current account.  When you sign up for an
    /// app using the Lockstep Platform, you obtain an enrollment record for that app.  Example types of apps include
    /// connectors and feature enhancement apps. The App Enrollment object contains information about this app, its
    /// configuration, and settings.
    ///
    /// See [Applications and Enrollments](https://developer.lockstep.io/docs/applications-and-enrollments) for more information.
    /// </summary>
    public class AppEnrollmentModel
    {

        /// <summary>
        /// The unique ID of this record, automatically assigned by Lockstep when this record is
        /// added to the Lockstep platform.
        /// </summary>
        public Guid? AppEnrollmentId { get; set; }

        /// <summary>
        /// The ID number of the Application that this enrollment represents.  You can fetch information
        /// about this Application object by specifying `App` in the &quot;Include&quot; parameter for your request.
        /// </summary>
        public Guid? AppId { get; set; }

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid? GroupKey { get; set; }

        /// <summary>
        /// Determines whether the app enrollment is in use
        /// </summary>
        public bool? IsActive { get; set; }

        /// <summary>
        /// Created date
        /// </summary>
        public DateTime? Created { get; set; }

        /// <summary>
        /// Created user ID
        /// </summary>
        public Guid? CreatedUserId { get; set; }

        /// <summary>
        /// Last modified date
        /// </summary>
        public DateTime? Modified { get; set; }

        /// <summary>
        /// Last user ID to modify
        /// </summary>
        public Guid? ModifiedUserId { get; set; }

        /// <summary>
        /// Stores schedule information for the application enrollment
        /// see https://en.wikipedia.org/wiki/Cron
        /// </summary>
        public string CronSettings { get; set; }

        /// <summary>
        /// Flag indicating if the Sync process should be ran on the specified schedule
        /// </summary>
        public bool? SyncScheduleIsActive { get; set; }

        /// <summary>
        /// The Application to which this AppEnrollment belongs.  Contains general name, description,
        /// logo, and other metadata about this application.
        ///
        /// To retrieve this object, specify `App` in the &quot;Include&quot; parameter for your query.
        /// </summary>
        public ApplicationModel App { get; set; }

        /// <summary>
        /// A collection of custom fields linked to this record.  To retrieve this collection, specify
        /// `CustomFieldDefinitions` in the `include` parameter when retrieving data.
        ///
        /// To create a custom field, use the [Create Custom Field](https://developer.lockstep.io/reference/post_api-v1-customfieldvalues)
        /// endpoint with the `TableKey` to `AppEnrollment` and the `ObjectKey` set to the `AppEnrollmentId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
        public CustomFieldDefinitionModel[] CustomFieldDefinitions { get; set; }

        /// <summary>
        /// A collection of custom fields linked to this record.  To retrieve this collection, specify
        /// `CustomFieldValues` in the `include` parameter when retrieving data.
        ///
        /// To create a custom field, use the [Create Custom Field](https://developer.lockstep.io/reference/post_api-v1-customfieldvalues)
        /// endpoint with the `TableKey` to `AppEnrollment` and the `ObjectKey` set to the `AppEnrollmentId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
        public CustomFieldValueModel[] CustomFieldValues { get; set; }

        /// <summary>
        /// Data about the last sync attached to this app enrollment
        ///
        /// To retrieve this collection, specify `LastSync` in the &quot;Include&quot; parameter for your query.
        /// </summary>
        public SyncRequestModel LastSync { get; set; }

        /// <summary>
        /// Data about the last successful sync associated with this enrollment
        /// </summary>
        public SyncRequestModel LastSuccessfulSync { get; set; }

        /// <summary>
        /// Optional data necessary to create an app enrollment for a supported connector.
        /// Only enter relevant fields for the given connector.
        /// </summary>
        public ConnectorInfoModel ConnectorInfo { get; set; }
    }
}
