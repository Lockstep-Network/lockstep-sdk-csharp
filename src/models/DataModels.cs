/***
 * Lockstep Software Development Kit for C#
 *
 * (c) 2021-2022 Lockstep, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author     Ted Spence <tspence@lockstep.io>
 * @copyright  2021-2022 Lockstep, Inc.
 * @link       https://github.com/Lockstep-Network/lockstep-sdk-csharp
 */



#pragma warning disable CS8618

using System;

namespace LockstepSDK
{

    /// <summary>
    /// An Activity contains information about work being done on a specific accounting task.
    /// You can use Activities to track information about who has been assigned a specific task,
    /// the current status of the task, the name and description given for the particular task,
    /// the priority of the task, and any amounts collected, paid, or credited for the task.
    /// </summary>
    public class ActivityModel
    {

        /// <summary>
        /// The unique ID of this record, automatically assigned by Lockstep when this record is
        /// added to the Lockstep platform.
        /// </summary>
        public Guid ActivityId { get; set; }

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid GroupKey { get; set; }

        /// <summary>
        /// The ID of the company to which this activity belongs.
        /// </summary>
        public Guid CompanyId { get; set; }

        /// <summary>
        /// The type code of the activity
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string ActivityTypeCode { get; set; }
#else
        public string? ActivityTypeCode { get; set; }
#endif

        /// <summary>
        /// The name of the activity.  The name is a short name provided by the
        /// person who created the activity that can be displayed in a list.
        /// </summary>
        public string ActivityName { get; set; }

        /// <summary>
        /// A description of the activity.  This field contains more detailed text about the
        /// activity and can be lengthy.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string ActivityDescription { get; set; }
#else
        public string? ActivityDescription { get; set; }
#endif

        /// <summary>
        /// The status of the activity.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string ActivityStatus { get; set; }
#else
        public string? ActivityStatus { get; set; }
#endif

        /// <summary>
        /// True if this activity is currently &quot;open&quot;, which indicates that the activity is
        /// currently in progress.
        /// </summary>
        public bool IsOpen { get; set; }

        /// <summary>
        /// The priority of the activity.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Priority { get; set; }
#else
        public string? Priority { get; set; }
#endif

        /// <summary>
        /// The ID of the user the activity is assigned to.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public Guid UserAssignedTo { get; set; }
#else
        public Guid? UserAssignedTo { get; set; }
#endif

        /// <summary>
        /// The date the activity was assigned.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime DateAssigned { get; set; }
#else
        public DateTime? DateAssigned { get; set; }
#endif

        /// <summary>
        /// The date the activity was closed.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime DateClosed { get; set; }
#else
        public DateTime? DateClosed { get; set; }
#endif

        /// <summary>
        /// If this activity has been &quot;snoozed&quot;, this field will be non-null and will contain
        /// the date when the activity will be displayed.  Until that date arrives, the activity
        /// will remain hidden.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime SnoozeUntilDate { get; set; }
#else
        public DateTime? SnoozeUntilDate { get; set; }
#endif

        /// <summary>
        /// The date on which this activity was created.
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// The ID of the user who created this activity.
        /// </summary>
        public Guid CreatedUserId { get; set; }

        /// <summary>
        /// The date on which this activity was last modified.
        /// </summary>
        public DateTime Modified { get; set; }

        /// <summary>
        /// The ID of the user who last modified this activity.
        /// </summary>
        public Guid ModifiedUserId { get; set; }

        /// <summary>
        /// Amount collected (if any) for the activity.
        /// </summary>
        public double? AmountCollected { get; set; }

        /// <summary>
        /// Amount paid (if any) for the activity.
        /// </summary>
        public double? AmountPaid { get; set; }

        /// <summary>
        /// Credit given (if any) for the activity.
        /// </summary>
        public double? CreditGiven { get; set; }

        /// <summary>
        /// True if this activity is to be shown in an &quot;unread&quot; state.  When an activity
        /// is read by a person it is assigned to, this flag is set to false.
        /// </summary>
        public bool IsUnread { get; set; }

        /// <summary>
        /// Activities may be archived when they should be hidden from the user.  When
        /// this flag is true, this activity should be hidden.
        /// </summary>
        public bool IsArchived { get; set; }

        /// <summary>
        /// The company associated with the activity
        ///
        /// To retrieve this collection, specify `Company` in the &quot;Include&quot; parameter for your query.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public CompanyModel Company { get; set; }
#else
        public CompanyModel? Company { get; set; }
#endif

        /// <summary>
        /// The name of the user the activity is assigned to
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string UserAssignedToName { get; set; }
#else
        public string? UserAssignedToName { get; set; }
#endif

        /// <summary>
        /// A collection of attachments linked to this record.  To retrieve this collection, specify `Attachments` in
        /// the `include` parameter when retrieving data.
        ///
        /// To create an attachment, use the [Upload Attachment](https://developer.lockstep.io/reference/post_api-v1-attachments)
        /// endpoint with the `TableKey` to `Activity` and the `ObjectKey` set to the `ActivityId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
#if DOT_NET_FRAMEWORK
        public AttachmentModel[] Attachments { get; set; }
#else
        public AttachmentModel[]? Attachments { get; set; }
#endif

        /// <summary>
        /// A collection of notes linked to this record.  To retrieve this collection, specify `Notes` in the
        /// `include` parameter when retrieving data.
        ///
        /// To create a note, use the [Create Note](https://developer.lockstep.io/reference/post_api-v1-notes)
        /// endpoint with the `TableKey` to `Activity` and the `ObjectKey` set to the `ActivityId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
#if DOT_NET_FRAMEWORK
        public NoteModel[] Notes { get; set; }
#else
        public NoteModel[]? Notes { get; set; }
#endif

        /// <summary>
        /// A collection of custom fields linked to this record.  To retrieve this collection, specify
        /// `CustomFieldDefinitions` in the `include` parameter when retrieving data.
        ///
        /// To create a custom field, use the [Create Custom Field](https://developer.lockstep.io/reference/post_api-v1-customfieldvalues)
        /// endpoint with the `TableKey` to `Activity` and the `ObjectKey` set to the `ActivityId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
#if DOT_NET_FRAMEWORK
        public CustomFieldDefinitionModel[] CustomFieldDefinitions { get; set; }
#else
        public CustomFieldDefinitionModel[]? CustomFieldDefinitions { get; set; }
#endif

        /// <summary>
        /// A collection of custom fields linked to this record.  To retrieve this collection, specify
        /// `CustomFieldValues` in the `include` parameter when retrieving data.
        ///
        /// To create a custom field, use the [Create Custom Field](https://developer.lockstep.io/reference/post_api-v1-customfieldvalues)
        /// endpoint with the `TableKey` to `Activity` and the `ObjectKey` set to the `ActivityId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
#if DOT_NET_FRAMEWORK
        public CustomFieldValueModel[] CustomFieldValues { get; set; }
#else
        public CustomFieldValueModel[]? CustomFieldValues { get; set; }
#endif

        /// <summary>
        /// All references attached to this applied activity.
        ///
        /// To retrieve this collection, specify `References` in the &quot;Include&quot; parameter for your query.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public ActivityXRefModel[] References { get; set; }
#else
        public ActivityXRefModel[]? References { get; set; }
#endif
    }

    /// <summary>
    /// Represents an item belonging to the activity stream.
    /// </summary>
    public class ActivityStreamItemModel
    {

        /// <summary>
        /// The object key of the activity stream item.
        /// </summary>
        public Guid ObjectKey { get; set; }

        /// <summary>
        /// The type code of the activity stream item.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string ActivityStreamType { get; set; }
#else
        public string? ActivityStreamType { get; set; }
#endif

        /// <summary>
        /// The text body description for this Activity Stream Item.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string TextValue { get; set; }
#else
        public string? TextValue { get; set; }
#endif

        /// <summary>
        /// The date on which this activity stream item was created.
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// The ID of the user who created this activity.
        /// </summary>
        public Guid CreatedUserId { get; set; }

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid GroupKey { get; set; }

        /// <summary>
        /// The sender&#39;s email address if activity stream item is an Email.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string FromEmailAddress { get; set; }
#else
        public string? FromEmailAddress { get; set; }
#endif

        /// <summary>
        /// The recipient&#39;s email address if activity stream item is an Email.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string ToEmailAddress { get; set; }
#else
        public string? ToEmailAddress { get; set; }
#endif

        /// <summary>
        /// The name of the contact sending the activity otherwise null.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string FromContactName { get; set; }
#else
        public string? FromContactName { get; set; }
#endif

        /// <summary>
        /// The name of the contact sending the activity otherwise null.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string ToContactName { get; set; }
#else
        public string? ToContactName { get; set; }
#endif
    }

    /// <summary>
    /// Represents links between an Activity and another record.
    /// </summary>
    public class ActivityXRefModel
    {

        /// <summary>
        /// The unique ID of this record, automatically assigned by Lockstep when this is
        /// added to the Lockstep platform.
        /// </summary>
        public Guid ActivityXRefId { get; set; }

        /// <summary>
        /// The ID of the activity to which this reference belongs.
        /// </summary>
        public Guid ActivityId { get; set; }

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid GroupKey { get; set; }

        /// <summary>
        /// The name of the table the activity reference is associated with
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string TableKey { get; set; }
#else
        public string? TableKey { get; set; }
#endif

        /// <summary>
        /// The ID of the object the activity reference is associated with
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string ObjectKey { get; set; }
#else
        public string? ObjectKey { get; set; }
#endif
    }

    /// <summary>
    /// Represents an aging record
    /// </summary>
    public class AgingModel
    {

        /// <summary>
        /// Aging bucket of outstanding balance data (days past due date of invoice)
        /// </summary>
        public int Bucket { get; set; }

        /// <summary>
        /// Currency code of aging bucket
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string CurrencyCode { get; set; }
#else
        public string? CurrencyCode { get; set; }
#endif

        /// <summary>
        /// Outstanding balance for the given aging bucket
        /// </summary>
        public double OutstandingBalance { get; set; }
    }

    /// <summary>
    /// An API Key is an authentication token that you may use with the Lockstep API.  Because API Keys
    /// do not have an expiration date, they are well suited for unattended processes.  Each API Key
    /// is associated with a user, and may be revoked to prevent it from accessing the Lockstep API.
    /// When you create an API Key, make sure to save the value in a secure location.  Lockstep cannot
    /// retrieve an API Key once it is created.
    ///
    /// For more information, see [API Keys](https://developer.lockstep.io/docs/api-keys).
    /// </summary>
    public class ApiKeyModel
    {

        /// <summary>
        /// The unique identifier for the API key.
        /// </summary>
        public Guid ApiKeyId { get; set; }

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid GroupKey { get; set; }

        /// <summary>
        /// The name of the API key.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// For convenience, a call to createApiKey will contain the name of the environment for this API key,
        /// typically SBX or PRD. This can help you distinguish between keys created on the Sandbox environment
        /// from those created on Production.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Environment { get; set; }
#else
        public string? Environment { get; set; }
#endif

        /// <summary>
        /// The API key to use for authentication. This will only be returned upon creation of the API key.
        /// All other times, this value will be `null`.
        ///
        /// For more information, see [API Keys](https://developer.lockstep.io/docs/api-keys).
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string ApiKey { get; set; }
#else
        public string? ApiKey { get; set; }
#endif

        /// <summary>
        /// The first 10 characters of the API key.  This information can be used to ensure that you are
        /// looking at the correct API Key, but cannot be used for authentication.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string KeyPrefix { get; set; }
#else
        public string? KeyPrefix { get; set; }
#endif

        /// <summary>
        /// The date the API key was created.
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// The user that created the API key.
        /// </summary>
        public Guid CreatedUserId { get; set; }

        /// <summary>
        /// The date the API key was revoked.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime Revoked { get; set; }
#else
        public DateTime? Revoked { get; set; }
#endif

        /// <summary>
        /// The user who revoked the API key.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public Guid RevokedUserId { get; set; }
#else
        public Guid? RevokedUserId { get; set; }
#endif

        /// <summary>
        /// The UTC datetime when the API key expires.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime Expires { get; set; }
#else
        public DateTime? Expires { get; set; }
#endif
    }

    /// <summary>
    /// App enrollment and custom field merged into one
    /// </summary>
    public class AppEnrollmentCustomFieldModel
    {

        /// <summary>
        /// Unique id for the app enrollment
        /// </summary>
        public Guid AppEnrollmentId { get; set; }

        /// <summary>
        /// Id of enrolled app
        /// </summary>
        public Guid AppId { get; set; }

        /// <summary>
        /// The name of the application
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Name { get; set; }
#else
        public string? Name { get; set; }
#endif

        /// <summary>
        /// Tag for what type of app the application is
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string AppType { get; set; }
#else
        public string? AppType { get; set; }
#endif

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid GroupKey { get; set; }

        /// <summary>
        /// Unique Id for the custom field definition
        /// </summary>
        public Guid CustomFieldDefinitionId { get; set; }

        /// <summary>
        /// Text to display in-application for custom field
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string CustomFieldLabel { get; set; }
#else
        public string? CustomFieldLabel { get; set; }
#endif

        /// <summary>
        /// Data type of the custom field definition
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string DataType { get; set; }
#else
        public string? DataType { get; set; }
#endif

        /// <summary>
        /// Used for display logic when multiple app enrollment custom fields exist
        /// </summary>
        public int SortOrder { get; set; }

        /// <summary>
        /// Value for the field
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Value { get; set; }
#else
        public string? Value { get; set; }
#endif
    }

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
        public Guid AppEnrollmentId { get; set; }

        /// <summary>
        /// The ID number of the Application that this enrollment represents.  You can fetch information
        /// about this Application object by specifying `App` in the &quot;Include&quot; parameter for your request.
        /// </summary>
        public Guid AppId { get; set; }

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid GroupKey { get; set; }

        /// <summary>
        /// Determines whether the app enrollment is in use
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Created date
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Created user ID
        /// </summary>
        public Guid CreatedUserId { get; set; }

        /// <summary>
        /// Last modified date
        /// </summary>
        public DateTime Modified { get; set; }

        /// <summary>
        /// Last user ID to modify
        /// </summary>
        public Guid ModifiedUserId { get; set; }

        /// <summary>
        /// Stores schedule information for the application enrollment
        /// see https://en.wikipedia.org/wiki/Cron
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string CronSettings { get; set; }
#else
        public string? CronSettings { get; set; }
#endif

        /// <summary>
        /// Flag indicating if the Sync process should be ran on the specified schedule
        /// </summary>
        public bool SyncScheduleIsActive { get; set; }

        /// <summary>
        /// The Application to which this AppEnrollment belongs.  Contains general name, description,
        /// logo, and other metadata about this application.
        ///
        /// To retrieve this object, specify `App` in the &quot;Include&quot; parameter for your query.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public ApplicationModel App { get; set; }
#else
        public ApplicationModel? App { get; set; }
#endif

        /// <summary>
        /// A collection of custom fields linked to this record.  To retrieve this collection, specify
        /// `CustomFieldDefinitions` in the `include` parameter when retrieving data.
        ///
        /// To create a custom field, use the [Create Custom Field](https://developer.lockstep.io/reference/post_api-v1-customfieldvalues)
        /// endpoint with the `TableKey` to `AppEnrollment` and the `ObjectKey` set to the `AppEnrollmentId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
#if DOT_NET_FRAMEWORK
        public CustomFieldDefinitionModel[] CustomFieldDefinitions { get; set; }
#else
        public CustomFieldDefinitionModel[]? CustomFieldDefinitions { get; set; }
#endif

        /// <summary>
        /// A collection of custom fields linked to this record.  To retrieve this collection, specify
        /// `CustomFieldValues` in the `include` parameter when retrieving data.
        ///
        /// To create a custom field, use the [Create Custom Field](https://developer.lockstep.io/reference/post_api-v1-customfieldvalues)
        /// endpoint with the `TableKey` to `AppEnrollment` and the `ObjectKey` set to the `AppEnrollmentId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
#if DOT_NET_FRAMEWORK
        public CustomFieldValueModel[] CustomFieldValues { get; set; }
#else
        public CustomFieldValueModel[]? CustomFieldValues { get; set; }
#endif

        /// <summary>
        /// Data about the last sync attached to this app enrollment
        ///
        /// To retrieve this collection, specify `LastSync` in the &quot;Include&quot; parameter for your query.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public SyncRequestModel LastSync { get; set; }
#else
        public SyncRequestModel? LastSync { get; set; }
#endif

        /// <summary>
        /// Data about the last successful sync associated with this enrollment
        /// </summary>
#if DOT_NET_FRAMEWORK
        public SyncRequestModel LastSuccessfulSync { get; set; }
#else
        public SyncRequestModel? LastSuccessfulSync { get; set; }
#endif

        /// <summary>
        /// Optional data necessary to create an app enrollment for a supported connector.
        /// Only enter relevant fields for the given connector.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public ConnectorInfoModel ConnectorInfo { get; set; }
#else
        public ConnectorInfoModel? ConnectorInfo { get; set; }
#endif
    }

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
        public Guid AppId { get; set; }

        /// <summary>
        /// The name of this application
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Name { get; set; }
#else
        public string? Name { get; set; }
#endif

        /// <summary>
        /// Brief summary of this application shown as a subtitle
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Description { get; set; }
#else
        public string? Description { get; set; }
#endif

        /// <summary>
        /// Tag for what type of app this is
        /// </summary>
        public string AppType { get; set; }

        /// <summary>
        /// The ID of the owner
        /// </summary>
        public Guid OwnerId { get; set; }

        /// <summary>
        /// The URL to visit for more information about this application
        /// </summary>
#if DOT_NET_FRAMEWORK
        public Uri ProjectUrl { get; set; }
#else
        public Uri? ProjectUrl { get; set; }
#endif

        /// <summary>
        /// The URL for the icon for this application
        /// </summary>
#if DOT_NET_FRAMEWORK
        public Uri IconUrl { get; set; }
#else
        public Uri? IconUrl { get; set; }
#endif

        /// <summary>
        /// The description of the price for this application
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string PriceTerms { get; set; }
#else
        public string? PriceTerms { get; set; }
#endif

        /// <summary>
        /// The ID of the user who created this application
        /// </summary>
#if DOT_NET_FRAMEWORK
        public Guid CreatedUserId { get; set; }
#else
        public Guid? CreatedUserId { get; set; }
#endif

        /// <summary>
        /// The ID of the user who last modified this application
        /// </summary>
#if DOT_NET_FRAMEWORK
        public Guid ModifiedUserId { get; set; }
#else
        public Guid? ModifiedUserId { get; set; }
#endif

        /// <summary>
        /// The date this application was created
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime Created { get; set; }
#else
        public DateTime? Created { get; set; }
#endif

        /// <summary>
        /// The date this application was last modified
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime Modified { get; set; }
#else
        public DateTime? Modified { get; set; }
#endif

        /// <summary>
        /// Flag indicating if the application is active.
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// URL to the Wiki for the Application
        /// </summary>
#if DOT_NET_FRAMEWORK
        public Uri WikiURL { get; set; }
#else
        public Uri? WikiURL { get; set; }
#endif

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid GroupKey { get; set; }

        /// <summary>
        /// A collection of notes linked to this record.  To retrieve this collection, specify `Notes` in the
        /// `include` parameter when retrieving data.
        ///
        /// To create a note, use the [Create Note](https://developer.lockstep.io/reference/post_api-v1-notes)
        /// endpoint with the `TableKey` to `Application` and the `ObjectKey` set to the `ApplicationId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
#if DOT_NET_FRAMEWORK
        public NoteModel[] Notes { get; set; }
#else
        public NoteModel[]? Notes { get; set; }
#endif

        /// <summary>
        /// A collection of attachments linked to this record.  To retrieve this collection, specify `Attachments` in
        /// the `include` parameter when retrieving data.
        ///
        /// To create an attachment, use the [Upload Attachment](https://developer.lockstep.io/reference/post_api-v1-attachments)
        /// endpoint with the `TableKey` to `Application` and the `ObjectKey` set to the `ApplicationId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
#if DOT_NET_FRAMEWORK
        public AttachmentModel[] Attachments { get; set; }
#else
        public AttachmentModel[]? Attachments { get; set; }
#endif

        /// <summary>
        /// A collection of custom fields linked to this record.  To retrieve this collection, specify
        /// `CustomFieldDefinitions` in the `include` parameter when retrieving data.
        ///
        /// To create a custom field, use the [Create Custom Field](https://developer.lockstep.io/reference/post_api-v1-customfieldvalues)
        /// endpoint with the `TableKey` to `Application` and the `ObjectKey` set to the `ApplicationId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
#if DOT_NET_FRAMEWORK
        public CustomFieldDefinitionModel[] CustomFieldDefinitions { get; set; }
#else
        public CustomFieldDefinitionModel[]? CustomFieldDefinitions { get; set; }
#endif

        /// <summary>
        /// A collection of custom fields linked to this record.  To retrieve this collection, specify
        /// `CustomFieldValues` in the `include` parameter when retrieving data.
        ///
        /// To create a custom field, use the [Create Custom Field](https://developer.lockstep.io/reference/post_api-v1-customfieldvalues)
        /// endpoint with the `TableKey` to `Application` and the `ObjectKey` set to the `ApplicationId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
#if DOT_NET_FRAMEWORK
        public CustomFieldValueModel[] CustomFieldValues { get; set; }
#else
        public CustomFieldValueModel[]? CustomFieldValues { get; set; }
#endif
    }

    /// <summary>
    /// Aggregated Accounts Receivable Aging information.
    /// </summary>
    public class ArAgingHeaderInfoModel
    {

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid GroupKey { get; set; }

        /// <summary>
        /// The aging bucket this data belongs to.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string ReportBucket { get; set; }
#else
        public string? ReportBucket { get; set; }
#endif

        /// <summary>
        /// The total number of customers.
        /// </summary>
        public int TotalCustomers { get; set; }

        /// <summary>
        /// The total number of invoices outstanding.
        /// </summary>
        public int TotalInvoicesOutstanding { get; set; }

        /// <summary>
        /// The total amount outstanding.
        /// </summary>
        public double TotalOutstandingAmount { get; set; }

        /// <summary>
        /// The total amount for AR.
        /// </summary>
        public double TotalArAmount { get; set; }

        /// <summary>
        /// Portion of Total AR this data represents.
        /// </summary>
        public double PercentageOfTotalAr { get; set; }
    }

    /// <summary>
    /// Aggregated Accounts Receivable information.
    /// </summary>
    public class ArHeaderInfoModel
    {

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid GroupKey { get; set; }

        /// <summary>
        /// The date of the report
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime ReportPeriod { get; set; }
#else
        public DateTime? ReportPeriod { get; set; }
#endif

        /// <summary>
        /// The total number of customers.
        /// </summary>
        public int TotalCustomers { get; set; }

        /// <summary>
        /// The total number of invoices.
        /// </summary>
        public int TotalInvoices { get; set; }

        /// <summary>
        /// The total amount invoiced.
        /// </summary>
        public double TotalInvoicedAmount { get; set; }

        /// <summary>
        /// The total number of unapplied payments.
        /// </summary>
        public double TotalUnappliedPayments { get; set; }

        /// <summary>
        /// The total amount of collected payments.
        /// </summary>
        public double TotalCollected { get; set; }

        /// <summary>
        /// The total accounts receivable amount.
        /// </summary>
        public double TotalArAmount { get; set; }

        /// <summary>
        /// The number of paid invoices.
        /// </summary>
        public int TotalInvoicesPaid { get; set; }

        /// <summary>
        /// The number of past due invoices.
        /// </summary>
        public int TotalInvoicesPastDue { get; set; }

        /// <summary>
        /// The number of past due invoices for the last 90 days.
        /// </summary>
        public int TotalInvoices90DaysPastDue { get; set; }

        /// <summary>
        /// The total amount past due.
        /// </summary>
        public double TotalPastDueAmount { get; set; }

        /// <summary>
        /// The total past due for the past 90 days.
        /// </summary>
        public double TotalPastDueAmount90Days { get; set; }

        /// <summary>
        /// Portion of Total AR that is Past due.
        /// </summary>
        public double PercentageOfTotalAr { get; set; }

        /// <summary>
        /// Daily sales outstanding.
        /// </summary>
        public double Dso { get; set; }

        /// <summary>
        /// The total amount invoiced, due this year.
        /// </summary>
        public double TotalInvoiceAmountCurrentYear { get; set; }

        /// <summary>
        /// The total amount invoiced, due last year.
        /// </summary>
        public double TotalInvoiceAmountPreviousYear { get; set; }

        /// <summary>
        /// The total of all payments received this year.
        /// </summary>
        public double TotalPaymentAmountCurrentYear { get; set; }

        /// <summary>
        /// The total amount of payments received in the last 30 days
        /// </summary>
        public int TotalCollectedPastThirtyDays { get; set; }

        /// <summary>
        /// The total amount of Invoices paid in the last 30 days
        /// </summary>
        public int TotalInvoicesPaidPastThirtyDays { get; set; }

        /// <summary>
        /// Portion of Total AR that is 90+ days Past due.
        /// </summary>
        public double PercentageOfTotalAr90DaysPastDue { get; set; }
    }

    /// <summary>
    /// Contains summarized data for an invoice
    /// </summary>
    public class AtRiskInvoiceSummaryModel
    {

        /// <summary>
        /// The date of the report
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime ReportDate { get; set; }
#else
        public DateTime? ReportDate { get; set; }
#endif

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid GroupKey { get; set; }

        /// <summary>
        /// The ID number of the counterparty for the invoice, for example, a customer or vendor.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public Guid CustomerId { get; set; }
#else
        public Guid? CustomerId { get; set; }
#endif

        /// <summary>
        /// The unique ID number of this invoice.
        /// </summary>
        public Guid InvoiceId { get; set; }

        /// <summary>
        /// A reference code that is used to identify this invoice.
        /// The meaning of this field is specific to the ERP or accounting system used by the user.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string InvoiceNumber { get; set; }
#else
        public string? InvoiceNumber { get; set; }
#endif

        /// <summary>
        /// The reporting date for this invoice.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime InvoiceDate { get; set; }
#else
        public DateTime? InvoiceDate { get; set; }
#endif

        /// <summary>
        /// The name of the counterparty for the invoice, for example, a customer or vendor.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string CustomerName { get; set; }
#else
        public string? CustomerName { get; set; }
#endif

        /// <summary>
        /// The status of the invoice.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Status { get; set; }
#else
        public string? Status { get; set; }
#endif

        /// <summary>
        /// The due date of the invoice.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime PaymentDueDate { get; set; }
#else
        public DateTime? PaymentDueDate { get; set; }
#endif

        /// <summary>
        /// The total amount of the Invoice.
        /// </summary>
        public double? InvoiceAmount { get; set; }

        /// <summary>
        /// The remaining balance value of this invoice.
        /// </summary>
        public double? OutstandingBalance { get; set; }

        /// <summary>
        /// A code identifying the type of this Invoice.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string InvoiceTypeCode { get; set; }
#else
        public string? InvoiceTypeCode { get; set; }
#endif

        /// <summary>
        /// The date stamp for the newest Activity on this Invoice.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime NewestActivity { get; set; }
#else
        public DateTime? NewestActivity { get; set; }
#endif

        /// <summary>
        /// The number of days this Invoice is past due.
        /// </summary>
        public int? DaysPastDue { get; set; }

        /// <summary>
        /// The memo text of the payments associated to this invoice.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string[] PaymentNumbers { get; set; }
#else
        public string[]? PaymentNumbers { get; set; }
#endif

        /// <summary>
        /// The ids of the payments associated to this invoice.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public Guid[] PaymentIds { get; set; }
#else
        public Guid[]? PaymentIds { get; set; }
#endif
    }

    /// <summary>
    /// Aggregated Attachment status information.
    /// </summary>
    public class AttachmentHeaderInfoModel
    {

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid GroupKey { get; set; }

        /// <summary>
        /// The CompanyId associated with the attachment status report. Providing a null value will
        /// return an attachment summary for all attachments associated to the provided GroupKey
        /// </summary>
#if DOT_NET_FRAMEWORK
        public Guid CompanyId { get; set; }
#else
        public Guid? CompanyId { get; set; }
#endif

        /// <summary>
        /// The total number of attachments associated with the provided GroupKey and CompanyId.
        /// </summary>
        public int TotalAttachments { get; set; }

        /// <summary>
        /// The total number of archived attachments associated with the provided GroupKey and CompanyId.
        /// </summary>
        public int TotalArchived { get; set; }

        /// <summary>
        /// The total number of active attachments associated with the provided GroupKey and CompanyId.
        /// </summary>
        public int TotalActive { get; set; }
    }

    /// <summary>
    /// Represents a user uploaded attachment
    /// </summary>
    public class AttachmentModel
    {

        /// <summary>
        /// The unique ID of this record, automatically assigned by Lockstep when this record is
        /// added to the Lockstep platform.
        /// </summary>
        public Guid AttachmentId { get; set; }

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid GroupKey { get; set; }

        /// <summary>
        /// The name of the table the attachment is associated with
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string TableKey { get; set; }
#else
        public string? TableKey { get; set; }
#endif

        /// <summary>
        /// The ID of the object the attachment is associated with
        /// </summary>
        public Guid ObjectKey { get; set; }

        /// <summary>
        /// Name of the file
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string FileName { get; set; }
#else
        public string? FileName { get; set; }
#endif

        /// <summary>
        /// Extension type of the file
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string FileExt { get; set; }
#else
        public string? FileExt { get; set; }
#endif

        /// <summary>
        /// Corresponding AttachmentType object to describe this attachment
        /// </summary>
        public Guid AttachmentTypeId { get; set; }

        /// <summary>
        /// Flag indicating the attachment was archived
        /// </summary>
        public bool IsArchived { get; set; }

        /// <summary>
        /// Tracks the original record for this attachment, not currently used.
        /// </summary>
        public Guid OriginAttachmentId { get; set; }

        /// <summary>
        /// Flag for if LS clients can see this file
        /// </summary>
        public bool ViewInternal { get; set; }

        /// <summary>
        /// Flag for if Vendors and customers can see this file
        /// </summary>
        public bool ViewExternal { get; set; }

        /// <summary>
        /// The unique ID of this record as it was known in its originating financial system.
        ///
        /// If this company record was imported from a financial system, it will have the value `ErpKey`
        /// set to the original primary key number of the record as it was known in the originating financial
        /// system.  If this record was not imported from a financial system, this value will be `null`.
        ///
        /// For more information, see [Identity Columns](https://developer.lockstep.io/docs/identity-columns).
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string ErpKey { get; set; }
#else
        public string? ErpKey { get; set; }
#endif

        /// <summary>
        /// The AppEnrollmentId of the application that imported this record.  For accounts
        /// with more than one financial system connected, this field identifies the originating
        /// financial system that produced this record.  This value is null if this record
        /// was not loaded from an external ERP or financial system.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public Guid AppEnrollmentId { get; set; }
#else
        public Guid? AppEnrollmentId { get; set; }
#endif

        /// <summary>
        /// The date the attachment was created
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Id of the user who made the file
        /// </summary>
        public Guid CreatedUserId { get; set; }

        /// <summary>
        /// The type of this attachment.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string AttachmentType { get; set; }
#else
        public string? AttachmentType { get; set; }
#endif
    }

    /// <summary>
    /// A BatchSyncModel contains a collection of records to load into the Lockstep Platform.  Data contained
    /// in this batch will be merged with your existing data.  Each record will be matched with existing data inside
    /// the Lockstep Platform using the [Identity Column](https://developer.lockstep.io/docs/identity-columns) rules.
    /// Any record that represents a new AppEnrollmentId+ErpKey will be inserted.  A record that matches an existing
    /// AppEnrollmentId+ErpKey will be updated, but only if the data has changed.
    ///
    /// A Sync process permits either a complete data file or a partial / delta data file.  Lockstep recommends
    /// using a sliding time window to avoid the risk of clock skew errors that might accidentally omit records.
    /// Best practice is to run a Sync process daily, and to export all data that has changed in the past 48 hours.
    /// </summary>
    public class BatchSyncModel
    {

        /// <summary>
        /// A list of Company records to merge with your Lockstep Platform data
        /// </summary>
#if DOT_NET_FRAMEWORK
        public CompanySyncModel[] Companies { get; set; }
#else
        public CompanySyncModel[]? Companies { get; set; }
#endif

        /// <summary>
        /// A list of Contact records to merge with your Lockstep Platform data
        /// </summary>
#if DOT_NET_FRAMEWORK
        public ContactSyncModel[] Contacts { get; set; }
#else
        public ContactSyncModel[]? Contacts { get; set; }
#endif

        /// <summary>
        /// A list of CreditMemoApplied records to merge with your Lockstep Platform data
        /// </summary>
#if DOT_NET_FRAMEWORK
        public CreditMemoAppliedSyncModel[] CreditMemoApplications { get; set; }
#else
        public CreditMemoAppliedSyncModel[]? CreditMemoApplications { get; set; }
#endif

        /// <summary>
        /// A list of Invoice records to merge with your Lockstep Platform data
        /// </summary>
#if DOT_NET_FRAMEWORK
        public InvoiceSyncModel[] Invoices { get; set; }
#else
        public InvoiceSyncModel[]? Invoices { get; set; }
#endif

        /// <summary>
        /// A list of InvoiceLine records to merge with your Lockstep Platform data
        /// </summary>
#if DOT_NET_FRAMEWORK
        public InvoiceLineSyncModel[] InvoiceLines { get; set; }
#else
        public InvoiceLineSyncModel[]? InvoiceLines { get; set; }
#endif

        /// <summary>
        /// A list of CustomField records to merge with your Lockstep Platform data
        /// </summary>
#if DOT_NET_FRAMEWORK
        public CustomFieldSyncModel[] CustomFields { get; set; }
#else
        public CustomFieldSyncModel[]? CustomFields { get; set; }
#endif

        /// <summary>
        /// A list of Payment records to merge with your Lockstep Platform data
        /// </summary>
#if DOT_NET_FRAMEWORK
        public PaymentSyncModel[] Payments { get; set; }
#else
        public PaymentSyncModel[]? Payments { get; set; }
#endif

        /// <summary>
        /// A list of PaymentApplied records to merge with your Lockstep Platform data
        /// </summary>
#if DOT_NET_FRAMEWORK
        public PaymentAppliedSyncModel[] PaymentApplications { get; set; }
#else
        public PaymentAppliedSyncModel[]? PaymentApplications { get; set; }
#endif
    }

    /// <summary>
    /// Input format used for bulk conversion route
    /// </summary>
    public class BulkCurrencyConversionModel
    {

        /// <summary>
        /// The date for the currency rate
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// The currency code This will be validated by the /api/v1/currencies data set
        /// </summary>
        public string SourceCurrency { get; set; }
    }

    /// <summary>
    /// Represents the cashflow report based on a timeframe
    /// </summary>
    public class CashflowReportModel
    {

        /// <summary>
        /// Timeframe in days the cashflow report is generated on
        /// </summary>
        public int Timeframe { get; set; }

        /// <summary>
        /// Amount of payments collected based in the timeframe
        /// </summary>
        public double PaymentsCollected { get; set; }

        /// <summary>
        /// Number of payments collected based in the timeframe
        /// </summary>
        public int PaymentsCollectedCount { get; set; }

        /// <summary>
        /// Amount of invoices billed based in the timeframe
        /// </summary>
        public double InvoicesBilled { get; set; }

        /// <summary>
        /// Number of invoices billed in the timeframe
        /// </summary>
        public int InvoicesBilledCount { get; set; }
    }

    /// <summary>
    /// Represents a Code Definition.  Codes can be used as shortened, human readable strings.
    /// Additionally, this table can be used to store lists of system values for Lockstep objects.
    /// </summary>
    public class CodeDefinitionModel
    {

        /// <summary>
        /// The unique ID of this record, automatically assigned by Lockstep when this record is
        /// added to the Lockstep platform.
        /// </summary>
        public Guid CodeDefinitionId { get; set; }

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid GroupKey { get; set; }

        /// <summary>
        /// The type of the Code Definition
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string CodeType { get; set; }
#else
        public string? CodeType { get; set; }
#endif

        /// <summary>
        /// The Code to be defined.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Code { get; set; }
#else
        public string? Code { get; set; }
#endif

        /// <summary>
        /// The definition of the Code
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string CodeDescription { get; set; }
#else
        public string? CodeDescription { get; set; }
#endif

        /// <summary>
        /// The date that the Code Definition was created
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// The ID of the user who created the Code Definition
        /// </summary>
        public Guid CreatedUserId { get; set; }

        /// <summary>
        /// The date the Code Definition was last modified
        /// </summary>
        public DateTime Modified { get; set; }

        /// <summary>
        /// The ID of the user who last modified the Code Definition
        /// </summary>
        public Guid ModifiedUserId { get; set; }
    }

    /// <summary>
    /// A Company represents a customer, a vendor, or a company within the organization of the account holder.
    /// Companies can have parents and children, representing an organizational hierarchy of corporate entities.
    /// You can use Companies to track projects and financial data under this Company label.
    ///
    /// See [Vendors, Customers, and Companies](https://developer.lockstep.io/docs/companies-customers-and-vendors) for more information.
    /// </summary>
    public class CompanyModel
    {

        /// <summary>
        /// The unique ID of this record, automatically assigned by Lockstep when this record is
        /// added to the Lockstep platform.
        ///
        /// For the ID of this record in its originating financial system, see `ErpKey`.
        /// </summary>
        public Guid CompanyId { get; set; }

        /// <summary>
        /// The short name of the company.
        /// </summary>
        public string CompanyName { get; set; }

        /// <summary>
        /// The unique ID of this record as it was known in its originating financial system.
        ///
        /// If this company record was imported from a financial system, it will have the value `ErpKey`
        /// set to the original primary key number of the record as it was known in the originating financial
        /// system.  If this record was not imported, this value will be `null`.
        ///
        /// For more information, see [Identity Columns](https://developer.lockstep.io/docs/identity-columns).
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string ErpKey { get; set; }
#else
        public string? ErpKey { get; set; }
#endif

        /// <summary>
        /// This field indicates the type of company.  It can be one of a limited number of values:
        /// Company, Customer, Group, Vendor, or Third Party.  A company that represents both a customer and a vendor
        /// is identified as a CustomerVendor.
        ///
        /// * `Company` - This record represents a company that is part of the organization of the account holder.
        /// * `Customer` - This record represents a business entity that purchases things from the account holder.
        /// * `Group` - Only one record of type `GROUP` exists in each account.  Contains your account profile.
        /// * `Vendor` - This record represents a business entity that sells things to the account holder.
        /// * `Third Party` - This record represents a business entity that is neither a customer nor vendor.
        /// * `CustomerVendor` - Both a customer and a vendor.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string CompanyType { get; set; }
#else
        public string? CompanyType { get; set; }
#endif

        /// <summary>
        /// The status of the company.  Companies can be either `Active` or `Inactive`.  When matched to a
        /// Lockstep corporate profile, this value will change to reflect that this record will be kept
        /// in sync with that company&#39;s identity.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string CompanyStatus { get; set; }
#else
        public string? CompanyStatus { get; set; }
#endif

        /// <summary>
        /// If this business entity is part of an organization, this value is non-null and it is set
        /// to the `CompanyId` value of the parent company of this business entity.
        ///
        /// If this value is null, this business entity is a standalone.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public Guid ParentCompanyId { get; set; }
#else
        public Guid? ParentCompanyId { get; set; }
#endif

        /// <summary>
        /// For convenience, this field indicates the top-level parent company.  This can be used
        /// to jump directly to the top parent in complex organizational hierarchies.
        /// </summary>
        public Guid EnterpriseId { get; set; }

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid GroupKey { get; set; }

        /// <summary>
        /// This flag indicates whether the company is currently active.  An inactive company
        /// should be hidden from the user interface but will still be available for querying.
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// The default currency code used by this business entity.  This value can be overridden
        /// for invoices in a different currency code.
        ///
        /// For a list of defined currency codes, see [Query Currencies](https://developer.lockstep.io/reference/get_api-v1-definitions-currencies)
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string DefaultCurrencyCode { get; set; }
#else
        public string? DefaultCurrencyCode { get; set; }
#endif

        /// <summary>
        /// The URL of this company&#39;s logo, if known.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string CompanyLogoUrl { get; set; }
#else
        public string? CompanyLogoUrl { get; set; }
#endif

        /// <summary>
        /// The Lockstep `ContactId` of the primary contact for this company.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public Guid PrimaryContactId { get; set; }
#else
        public Guid? PrimaryContactId { get; set; }
#endif

        /// <summary>
        /// Address info
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Address1 { get; set; }
#else
        public string? Address1 { get; set; }
#endif

        /// <summary>
        /// Address info
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Address2 { get; set; }
#else
        public string? Address2 { get; set; }
#endif

        /// <summary>
        /// Address info
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Address3 { get; set; }
#else
        public string? Address3 { get; set; }
#endif

        /// <summary>
        /// Address info
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string City { get; set; }
#else
        public string? City { get; set; }
#endif

        /// <summary>
        /// Address info
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string StateRegion { get; set; }
#else
        public string? StateRegion { get; set; }
#endif

        /// <summary>
        /// Address info
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string PostalCode { get; set; }
#else
        public string? PostalCode { get; set; }
#endif

        /// <summary>
        /// Address info
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Country { get; set; }
#else
        public string? Country { get; set; }
#endif

        /// <summary>
        /// Phone number
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string PhoneNumber { get; set; }
#else
        public string? PhoneNumber { get; set; }
#endif

        /// <summary>
        /// Fax number
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string FaxNumber { get; set; }
#else
        public string? FaxNumber { get; set; }
#endif

        /// <summary>
        /// The date this company was created
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime Created { get; set; }
#else
        public DateTime? Created { get; set; }
#endif

        /// <summary>
        /// The ID of the user who created this company
        /// </summary>
        public Guid CreatedUserId { get; set; }

        /// <summary>
        /// The date this company was last modified
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime Modified { get; set; }
#else
        public DateTime? Modified { get; set; }
#endif

        /// <summary>
        /// The ID of the user who last modified this company
        /// </summary>
        public Guid ModifiedUserId { get; set; }

        /// <summary>
        /// The name of the user who last modified this company
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string ModifiedUserName { get; set; }
#else
        public string? ModifiedUserName { get; set; }
#endif

        /// <summary>
        /// Federal Tax ID
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string TaxId { get; set; }
#else
        public string? TaxId { get; set; }
#endif

        /// <summary>
        /// Dun &amp; Bradstreet Number
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string DunsNumber { get; set; }
#else
        public string? DunsNumber { get; set; }
#endif

        /// <summary>
        /// AP (Accounts Payable) Email Address
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string ApEmailAddress { get; set; }
#else
        public string? ApEmailAddress { get; set; }
#endif

        /// <summary>
        /// AR (Accounts Receivable) Email Address
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string ArEmailAddress { get; set; }
#else
        public string? ArEmailAddress { get; set; }
#endif

        /// <summary>
        /// For companies that use a custom domain name for their email system, this is
        /// the domain name used by this company.  If this value is known, new emails that
        /// come in from this domain will be connected to this company.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string DomainName { get; set; }
#else
        public string? DomainName { get; set; }
#endif

        /// <summary>
        /// Identifier for classification of this company.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public Guid CompanyClassificationCodeDefId { get; set; }
#else
        public Guid? CompanyClassificationCodeDefId { get; set; }
#endif

        /// <summary>
        /// Description of the company.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Description { get; set; }
#else
        public string? Description { get; set; }
#endif

        /// <summary>
        /// Website URL for this company.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Website { get; set; }
#else
        public string? Website { get; set; }
#endif

        /// <summary>
        /// The AppEnrollmentId of the application that imported this record.  For accounts
        /// with more than one financial system connected, this field identifies the originating
        /// financial system that produced this record.  This value is null if this record
        /// was not loaded from an external ERP or financial system.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public Guid AppEnrollmentId { get; set; }
#else
        public Guid? AppEnrollmentId { get; set; }
#endif

        /// <summary>
        /// A collection of notes linked to this record.  To retrieve this collection, specify `Notes` in the
        /// `include` parameter when retrieving data.
        ///
        /// To create a note, use the [Create Note](https://developer.lockstep.io/reference/post_api-v1-notes)
        /// endpoint with the `TableKey` to `Company` and the `ObjectKey` set to the `CompanyId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
#if DOT_NET_FRAMEWORK
        public NoteModel[] Notes { get; set; }
#else
        public NoteModel[]? Notes { get; set; }
#endif

        /// <summary>
        /// A collection of attachments linked to this record.  To retrieve this collection, specify `Attachments` in
        /// the `include` parameter when retrieving data.
        ///
        /// To create an attachment, use the [Upload Attachment](https://developer.lockstep.io/reference/post_api-v1-attachments)
        /// endpoint with the `TableKey` to `Company` and the `ObjectKey` set to the `CompanyId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
#if DOT_NET_FRAMEWORK
        public AttachmentModel[] Attachments { get; set; }
#else
        public AttachmentModel[]? Attachments { get; set; }
#endif

        /// <summary>
        /// All contacts attached to this company.
        ///
        /// To retrieve this collection, specify `Contacts` in the &quot;Include&quot; parameter for your query.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public ContactModel[] Contacts { get; set; }
#else
        public ContactModel[]? Contacts { get; set; }
#endif

        /// <summary>
        /// All invoices attached to this company.
        ///
        /// To retrieve this collection, specify `Invoices` in the &quot;Include&quot; parameter for your query. For more information on Invoices, see [InvoiceModel](https://developer.lockstep.io/reference/get_api-v1-invoices-id).
        /// </summary>
#if DOT_NET_FRAMEWORK
        public object[] Invoices { get; set; }
#else
        public object[]? Invoices { get; set; }
#endif

        /// <summary>
        /// A collection of custom fields linked to this record.  To retrieve this collection, specify
        /// `CustomFieldDefinitions` in the `include` parameter when retrieving data.
        ///
        /// To create a custom field, use the [Create Custom Field](https://developer.lockstep.io/reference/post_api-v1-customfieldvalues)
        /// endpoint with the `TableKey` to `Company` and the `ObjectKey` set to the `CompanyId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
#if DOT_NET_FRAMEWORK
        public CustomFieldDefinitionModel[] CustomFieldDefinitions { get; set; }
#else
        public CustomFieldDefinitionModel[]? CustomFieldDefinitions { get; set; }
#endif

        /// <summary>
        /// A collection of custom fields linked to this record.  To retrieve this collection, specify
        /// `CustomFieldValues` in the `include` parameter when retrieving data.
        ///
        /// To create a custom field, use the [Create Custom Field](https://developer.lockstep.io/reference/post_api-v1-customfieldvalues)
        /// endpoint with the `TableKey` to `Company` and the `ObjectKey` set to the `CompanyId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
#if DOT_NET_FRAMEWORK
        public CustomFieldValueModel[] CustomFieldValues { get; set; }
#else
        public CustomFieldValueModel[]? CustomFieldValues { get; set; }
#endif

        /// <summary>
        /// Classification code definition for this company.
        ///
        /// To retrieve this collection, specify `Classification` in the &quot;Include&quot; parameter for your query.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public CodeDefinitionModel CompanyClassificationCodeDefinition { get; set; }
#else
        public CodeDefinitionModel? CompanyClassificationCodeDefinition { get; set; }
#endif
    }

    /// <summary>
    /// The CompanySyncModel represents information coming into Lockstep from an external financial system or other
    /// enterprise resource planning system.  To import data from an external system, convert your original data into
    /// the CompanySyncModel format and call the [Upload Sync File API](https://developer.lockstep.io/reference/post_api-v1-sync-zip).
    /// This API retrieves all of the data you uploaded in a compressed ZIP file and imports it into the Lockstep
    /// platform.
    ///
    /// Once imported, this record will be available in the Lockstep API as a [CompanyModel](https://developer.lockstep.io/docs/companymodel).
    ///
    /// For more information on writing your own connector, see [Connector Data](https://developer.lockstep.io/docs/connector-data).
    /// </summary>
    public class CompanySyncModel
    {

        /// <summary>
        /// This is the primary key of the Company record. For this field, you should use whatever the company&#39;s unique
        /// identifying number is in the originating system. Search for a unique, non-changing number within the
        /// originating financial system for this record.
        ///
        /// Example: If you store your company records in a database, whatever the primary key for the company table is
        /// in the database should be the `ErpKey`.
        ///
        /// Example: If you use a financial system such as Quickbooks or Xero, look for the primary ID number of the
        /// company record within that financial system.
        ///
        /// For more information, see [Identity Columns](https://developer.lockstep.io/docs/identity-columns).
        /// </summary>
        public string ErpKey { get; set; }

        /// <summary>
        /// A friendly, short name of the company.
        /// </summary>
        public string CompanyName { get; set; }

        /// <summary>
        /// This field indicates the type of company. It can be one of a limited number of values: `Company`,
        /// `Customer`, `Group`, `Vendor`, or `Third Party`. A company that represents both a customer and a vendor is
        /// identified as a `CustomerVendor`.
        ///
        /// When loading data into Lockstep, you should focus on the distinction between a company that is part of
        /// your own enterprise, or a company that is external to your enterprise.
        ///
        /// For a company that is within your enterprise, you should set this value to be `Company`.
        ///
        /// For a company that is external to your enterprise, you should set this value to either `Customer`,
        /// `Vendor`, `Third Party`, or `CustomerVendor`.  If you don&#39;t know what value to choose, select
        /// `CustomerVendor`.
        /// </summary>
        public string CompanyType { get; set; }

        /// <summary>
        /// An optional field including status codes.  Defined status codes are `Active` and `Inactive`.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string CompanyStatus { get; set; }
#else
        public string? CompanyStatus { get; set; }
#endif

        /// <summary>
        /// If this company has a parent company, identify the parent company&#39;s `ErpKey` value here. This value should
        /// be the original primary key or unique ID of the parent company to this company belongs. This value should
        /// match the original ErpKey field on the parent company.
        ///
        /// If this company is not a child company, leave this field null.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string ParentCompanyErpKey { get; set; }
#else
        public string? ParentCompanyErpKey { get; set; }
#endif

        /// <summary>
        /// This flag indicates whether the company is currently active. An inactive company will be hidden from the
        /// user interface but will still be available for querying.
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// The default currency code for transactions related to this company.  For a list of currency codes, see
        /// [Query Currencies](https://developer.lockstep.io/reference/get_api-v1-definitions-currencies). This will be validated by the /api/v1/currencies data set
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string DefaultCurrencyCode { get; set; }
#else
        public string? DefaultCurrencyCode { get; set; }
#endif

        /// <summary>
        /// The URL of this company&#39;s logo, if known.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string CompanyLogoUrl { get; set; }
#else
        public string? CompanyLogoUrl { get; set; }
#endif

        /// <summary>
        /// The `ErpKey` of the primary contact for this company.  This value should match the `ErpKey` value of the
        /// [Importing Contacts](https://developer.lockstep.io/docs/importing-contacts) record for the contact table.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string PrimaryContactErpKey { get; set; }
#else
        public string? PrimaryContactErpKey { get; set; }
#endif

        /// <summary>
        /// The company&#39;s primary mailing address information
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Address1 { get; set; }
#else
        public string? Address1 { get; set; }
#endif

        /// <summary>
        /// The company&#39;s primary mailing address information
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Address2 { get; set; }
#else
        public string? Address2 { get; set; }
#endif

        /// <summary>
        /// The company&#39;s primary mailing address information
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Address3 { get; set; }
#else
        public string? Address3 { get; set; }
#endif

        /// <summary>
        /// The company&#39;s primary mailing address information
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string City { get; set; }
#else
        public string? City { get; set; }
#endif

        /// <summary>
        /// The company&#39;s primary mailing address information
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string StateRegion { get; set; }
#else
        public string? StateRegion { get; set; }
#endif

        /// <summary>
        /// The company&#39;s primary mailing address information
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string PostalCode { get; set; }
#else
        public string? PostalCode { get; set; }
#endif

        /// <summary>
        /// The company&#39;s primary mailing address information This will be validated by the /api/v1/countries data set
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Country { get; set; }
#else
        public string? Country { get; set; }
#endif

        /// <summary>
        /// The main phone number of this company.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string PhoneNumber { get; set; }
#else
        public string? PhoneNumber { get; set; }
#endif

        /// <summary>
        /// The main fax number of this company.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string FaxNumber { get; set; }
#else
        public string? FaxNumber { get; set; }
#endif

        /// <summary>
        /// If known, the date when this record was created according to the originating financial system
        /// in which this record is maintained.  If the originating financial system does not maintain a
        /// created-date, leave this field null.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime Created { get; set; }
#else
        public DateTime? Created { get; set; }
#endif

        /// <summary>
        /// If known, the date when this record was most recently modified according to the originating
        /// financial system in which this record is maintained.  If the originating financial system does
        /// not maintain a most-recently-modified-date, leave this field null.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime Modified { get; set; }
#else
        public DateTime? Modified { get; set; }
#endif

        /// <summary>
        /// The company&#39;s Tax ID number for the appropriate government for this company.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string TaxId { get; set; }
#else
        public string? TaxId { get; set; }
#endif

        /// <summary>
        /// The Dun and Bradstreet number for this company, if known.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string DunsNumber { get; set; }
#else
        public string? DunsNumber { get; set; }
#endif

        /// <summary>
        /// If you know the AP (accounts payable) email address of this company, fill it in here. This is the email
        /// address where you would send questions to the company if the company owed you money.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string ApEmailAddress { get; set; }
#else
        public string? ApEmailAddress { get; set; }
#endif

        /// <summary>
        /// If you know the AR (accounts receivable) email address of this company, fill it in here. This is the email
        /// address where you would send questions to the company if you owed this company money.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string ArEmailAddress { get; set; }
#else
        public string? ArEmailAddress { get; set; }
#endif
    }

    /// <summary>
    /// Represents all possible data required to set up an app enrollment for a connector.
    /// Only send required fields for the given connector.
    /// </summary>
    public class ConnectorInfoModel
    {

        /// <summary>
        /// The authorization code returned from the first step of the OAuth2 flow
        /// https://oauth.net/2/grant-types/authorization-code/
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string AuthCode { get; set; }
#else
        public string? AuthCode { get; set; }
#endif

        /// <summary>
        /// The realm id of the account being granted permissions to access
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string RealmId { get; set; }
#else
        public string? RealmId { get; set; }
#endif

        /// <summary>
        /// The redirect uri used for step one of the OAuth2.0 flow.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string RedirectUri { get; set; }
#else
        public string? RedirectUri { get; set; }
#endif

        /// <summary>
        /// The email an email connection is being created for.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Email { get; set; }
#else
        public string? Email { get; set; }
#endif

        /// <summary>
        /// The username of the web services account with access permissions.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Username { get; set; }
#else
        public string? Username { get; set; }
#endif

        /// <summary>
        /// The password for the web services account with access permissions.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Password { get; set; }
#else
        public string? Password { get; set; }
#endif

        /// <summary>
        /// The username for sftp client
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string SftpUsername { get; set; }
#else
        public string? SftpUsername { get; set; }
#endif

        /// <summary>
        /// The password for sftp client
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string SftpPassword { get; set; }
#else
        public string? SftpPassword { get; set; }
#endif

        /// <summary>
        /// The Lockstep server URL for sftp client
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string SftpServerUrl { get; set; }
#else
        public string? SftpServerUrl { get; set; }
#endif

        /// <summary>
        /// The port number for sftp client
        /// </summary>
        public int? SftpPortNumber { get; set; }
    }

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
        public Guid ContactId { get; set; }

        /// <summary>
        /// The ID of the company to which this contact belongs.
        /// </summary>
        public Guid CompanyId { get; set; }

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid GroupKey { get; set; }

        /// <summary>
        /// The unique ID of this record as it was known in its originating financial system.
        ///
        /// If this contact record was imported from a financial system, it will have the value `ErpKey`
        /// set to the original primary key number of the record as it was known in the originating financial
        /// system.  If this record was not imported, this value will be `null`.
        ///
        /// For more information, see [Identity Columns](https://developer.lockstep.io/docs/identity-columns).
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string ErpKey { get; set; }
#else
        public string? ErpKey { get; set; }
#endif

        /// <summary>
        /// The name of the contact.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string ContactName { get; set; }
#else
        public string? ContactName { get; set; }
#endif

        /// <summary>
        /// A friendly human-readable code that describes this Contact.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string ContactCode { get; set; }
#else
        public string? ContactCode { get; set; }
#endif

        /// <summary>
        /// The title of the contact.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Title { get; set; }
#else
        public string? Title { get; set; }
#endif

        /// <summary>
        /// The role code for the contact.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string RoleCode { get; set; }
#else
        public string? RoleCode { get; set; }
#endif

        /// <summary>
        /// The email address of the contact.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string EmailAddress { get; set; }
#else
        public string? EmailAddress { get; set; }
#endif

        /// <summary>
        /// The phone number of the contact.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Phone { get; set; }
#else
        public string? Phone { get; set; }
#endif

        /// <summary>
        /// The fax number of the contact.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Fax { get; set; }
#else
        public string? Fax { get; set; }
#endif

        /// <summary>
        /// The first line of the address.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Address1 { get; set; }
#else
        public string? Address1 { get; set; }
#endif

        /// <summary>
        /// The second line of the address.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Address2 { get; set; }
#else
        public string? Address2 { get; set; }
#endif

        /// <summary>
        /// The third line of the address.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Address3 { get; set; }
#else
        public string? Address3 { get; set; }
#endif

        /// <summary>
        /// The city of the address.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string City { get; set; }
#else
        public string? City { get; set; }
#endif

        /// <summary>
        /// The state/region of the address.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string StateRegion { get; set; }
#else
        public string? StateRegion { get; set; }
#endif

        /// <summary>
        /// The postal/zip code of the address.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string PostalCode { get; set; }
#else
        public string? PostalCode { get; set; }
#endif

        /// <summary>
        /// The two character country code of the address. This will be validated by the /api/v1/countries data set
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string CountryCode { get; set; }
#else
        public string? CountryCode { get; set; }
#endif

        /// <summary>
        /// Flag indicating if the contact is active.
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// The webpage url of the contact.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public Uri WebpageUrl { get; set; }
#else
        public Uri? WebpageUrl { get; set; }
#endif

        /// <summary>
        /// The picture/avatar url of the contact.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public Uri PictureUrl { get; set; }
#else
        public Uri? PictureUrl { get; set; }
#endif

        /// <summary>
        /// The date on which this record was created.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime Created { get; set; }
#else
        public DateTime? Created { get; set; }
#endif

        /// <summary>
        /// The ID of the user who created this contact.
        /// </summary>
        public Guid CreatedUserId { get; set; }

        /// <summary>
        /// The date on which this record was last modified.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime Modified { get; set; }
#else
        public DateTime? Modified { get; set; }
#endif

        /// <summary>
        /// The ID of the user who last modified this contact.
        /// </summary>
        public Guid ModifiedUserId { get; set; }

        /// <summary>
        /// The AppEnrollmentId of the application that imported this record.  For accounts
        /// with more than one financial system connected, this field identifies the originating
        /// financial system that produced this record.  This value is null if this record
        /// was not loaded from an external ERP or financial system.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public Guid AppEnrollmentId { get; set; }
#else
        public Guid? AppEnrollmentId { get; set; }
#endif

        /// <summary>
        /// A collection of notes linked to this record.  To retrieve this collection, specify `Notes` in the
        /// `include` parameter when retrieving data.
        ///
        /// To create a note, use the [Create Note](https://developer.lockstep.io/reference/post_api-v1-notes)
        /// endpoint with the `TableKey` to `Contact` and the `ObjectKey` set to the `ContactId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
#if DOT_NET_FRAMEWORK
        public NoteModel[] Notes { get; set; }
#else
        public NoteModel[]? Notes { get; set; }
#endif

        /// <summary>
        /// A collection of attachments linked to this record.  To retrieve this collection, specify `Attachments` in
        /// the `include` parameter when retrieving data.
        ///
        /// To create an attachment, use the [Upload Attachment](https://developer.lockstep.io/reference/post_api-v1-attachments)
        /// endpoint with the `TableKey` to `Contact` and the `ObjectKey` set to the `ContactId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
#if DOT_NET_FRAMEWORK
        public AttachmentModel[] Attachments { get; set; }
#else
        public AttachmentModel[]? Attachments { get; set; }
#endif

        /// <summary>
        /// A collection of custom fields linked to this record.  To retrieve this collection, specify
        /// `CustomFieldDefinitions` in the `include` parameter when retrieving data.
        ///
        /// To create a custom field, use the [Create Custom Field](https://developer.lockstep.io/reference/post_api-v1-customfieldvalues)
        /// endpoint with the `TableKey` to `Contact` and the `ObjectKey` set to the `ContactId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
#if DOT_NET_FRAMEWORK
        public CustomFieldDefinitionModel[] CustomFieldDefinitions { get; set; }
#else
        public CustomFieldDefinitionModel[]? CustomFieldDefinitions { get; set; }
#endif

        /// <summary>
        /// A collection of custom fields linked to this record.  To retrieve this collection, specify
        /// `CustomFieldValues` in the `include` parameter when retrieving data.
        ///
        /// To create a custom field, use the [Create Custom Field](https://developer.lockstep.io/reference/post_api-v1-customfieldvalues)
        /// endpoint with the `TableKey` to `Contact` and the `ObjectKey` set to the `ContactId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
#if DOT_NET_FRAMEWORK
        public CustomFieldValueModel[] CustomFieldValues { get; set; }
#else
        public CustomFieldValueModel[]? CustomFieldValues { get; set; }
#endif
    }

    /// <summary>
    /// The ContactSyncModel represents information coming into Lockstep from an external financial system or other
    /// enterprise resource planning system.  To import data from an external system, convert your original data into
    /// the ContactSyncModel format and call the [Upload Sync File API](https://developer.lockstep.io/reference/post_api-v1-sync-zip).
    /// This API retrieves all of the data you uploaded in a compressed ZIP file and imports it into the Lockstep
    /// platform.
    ///
    /// Once imported, this record will be available in the Lockstep API as a [ContactModel](https://developer.lockstep.io/docs/contactmodel).
    ///
    /// For more information on writing your own connector, see [Connector Data](https://developer.lockstep.io/docs/connector-data).
    /// </summary>
    public class ContactSyncModel
    {

        /// <summary>
        /// This is the primary key of the Contact record. For this field, you should use whatever the contact&#39;s unique
        /// identifying number is in the originating system. Search for a unique, non-changing number within the
        /// originating financial system for this record.
        ///
        /// Example: If you store your contact records in a database, whatever the primary key for the contact table is
        /// in the database should be the &quot;ErpKey&quot;.
        ///
        /// For more information, see [Identity Columns](https://developer.lockstep.io/docs/identity-columns).
        /// </summary>
        public string ErpKey { get; set; }

        /// <summary>
        /// The original primary key or unique ID of the company to which this contact belongs.  This value should
        /// match the [Company ErpKey](https://developer.lockstep.io/docs/importing-companies#erpkey) field on the
        /// [CompanySyncModel](https://developer.lockstep.io/docs/importing-companies).
        /// </summary>
        public string CompanyErpKey { get; set; }

        /// <summary>
        /// The name of the contact.
        /// </summary>
        public string ContactName { get; set; }

        /// <summary>
        /// A friendly human-readable code that describes this Contact.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string ContactCode { get; set; }
#else
        public string? ContactCode { get; set; }
#endif

        /// <summary>
        /// The title of the contact.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Title { get; set; }
#else
        public string? Title { get; set; }
#endif

        /// <summary>
        /// The role code for the contact.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string RoleCode { get; set; }
#else
        public string? RoleCode { get; set; }
#endif

        /// <summary>
        /// The email address of the contact.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string EmailAddress { get; set; }
#else
        public string? EmailAddress { get; set; }
#endif

        /// <summary>
        /// The phone number of the contact.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Phone { get; set; }
#else
        public string? Phone { get; set; }
#endif

        /// <summary>
        /// The fax number of the contact.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Fax { get; set; }
#else
        public string? Fax { get; set; }
#endif

        /// <summary>
        /// The mailing address information for this contact.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Address1 { get; set; }
#else
        public string? Address1 { get; set; }
#endif

        /// <summary>
        /// The mailing address information for this contact.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Address2 { get; set; }
#else
        public string? Address2 { get; set; }
#endif

        /// <summary>
        /// The mailing address information for this contact.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Address3 { get; set; }
#else
        public string? Address3 { get; set; }
#endif

        /// <summary>
        /// The mailing address information for this contact.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string City { get; set; }
#else
        public string? City { get; set; }
#endif

        /// <summary>
        /// The mailing address information for this contact.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string StateRegion { get; set; }
#else
        public string? StateRegion { get; set; }
#endif

        /// <summary>
        /// The mailing address information for this contact.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string PostalCode { get; set; }
#else
        public string? PostalCode { get; set; }
#endif

        /// <summary>
        /// The mailing address information for this contact. This will be validated by the /api/v1/countries data set
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string CountryCode { get; set; }
#else
        public string? CountryCode { get; set; }
#endif

        /// <summary>
        /// True if this contact is considered &quot;active&quot;.
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// A webpage URL for more information about this contact.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string WebpageUrl { get; set; }
#else
        public string? WebpageUrl { get; set; }
#endif

        /// <summary>
        /// If available, the URL of a photograph that shows this contact.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string PictureUrl { get; set; }
#else
        public string? PictureUrl { get; set; }
#endif

        /// <summary>
        /// If known, the date when this record was created according to the originating financial system
        /// in which this record is maintained.  If the originating financial system does not maintain a
        /// created-date, leave this field null.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime Created { get; set; }
#else
        public DateTime? Created { get; set; }
#endif

        /// <summary>
        /// If known, the date when this record was most recently modified according to the originating
        /// financial system in which this record is maintained.  If the originating financial system does
        /// not maintain a most-recently-modified-date, leave this field null.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime Modified { get; set; }
#else
        public DateTime? Modified { get; set; }
#endif
    }

    /// <summary>
    /// Country model for ISO-3166
    /// </summary>
    public class CountryModel
    {

        /// <summary>
        /// Name of the country
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Name { get; set; }
#else
        public string? Name { get; set; }
#endif

        /// <summary>
        /// 2 letter alphabetic code for the given country
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Alpha2 { get; set; }
#else
        public string? Alpha2 { get; set; }
#endif

        /// <summary>
        /// 3 letter alphabetic code for the given country
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Alpha3 { get; set; }
#else
        public string? Alpha3 { get; set; }
#endif

        /// <summary>
        /// Unique 3 digit number for the given country
        /// </summary>
        public int CountryCode { get; set; }

        /// <summary>
        /// Region of the country
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Region { get; set; }
#else
        public string? Region { get; set; }
#endif

        /// <summary>
        /// Subregion of the country
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string SubRegion { get; set; }
#else
        public string? SubRegion { get; set; }
#endif

        /// <summary>
        /// Intermediate region of the country
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string IntermediateRegion { get; set; }
#else
        public string? IntermediateRegion { get; set; }
#endif

        /// <summary>
        /// Numeric code for a region
        /// </summary>
        public int RegionCode { get; set; }

        /// <summary>
        /// Numeric code for a subregion
        /// </summary>
        public int SubRegionCode { get; set; }

        /// <summary>
        /// Numeric code for an intermediate region
        /// </summary>
        public int IntermediateRegionCode { get; set; }

        /// <summary>
        /// French name of the country
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string FrenchName { get; set; }
#else
        public string? FrenchName { get; set; }
#endif

        /// <summary>
        /// A different name for a country
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Aliases { get; set; }
#else
        public string? Aliases { get; set; }
#endif
    }

    /// <summary>
    /// Credit Memos reflect credits granted to a customer for various reasons, such as discounts or refunds.
    /// Credit Memos may be applied to Invoices as Payments. When a Credit Memo is applied as payment to an Invoice,
    /// Lockstep creates a Credit Memo Application record to track the amount from the Credit Memo that was applied
    /// as payment to the Invoice. You can examine Credit Memo Application records to track which Invoices were paid
    /// using this Credit.
    /// </summary>
    public class CreditMemoAppliedModel
    {

        /// <summary>
        /// The unique ID of this record, automatically assigned by Lockstep when this record is
        /// added to the Lockstep platform.
        ///
        /// For the ID of this record in its originating financial system, see `ErpKey`.
        /// </summary>
        public Guid CreditMemoAppliedId { get; set; }

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid GroupKey { get; set; }

        /// <summary>
        /// The Lockstep ID of the Invoice to which this credit memo was applied.  This Invoice&#39;s outstanding balance
        /// was reduced by the value of the field `CreditMemoAppliedAmount` on the date `ApplyToInvoiceDate`.
        ///
        /// Example: Company ABC received a credit memo, CM000123 for $500.  Company ABC then chooses to apply this
        /// credit memo to reduce the balance of the invoice PO1000578.  The `InvoiceErpKey` is the Lockstep Platform
        /// ID number of Invoice `PO1000578`.
        /// </summary>
        public Guid InvoiceId { get; set; }

        /// <summary>
        /// The Lockstep ID of the Invoice of type &quot;Credit Memo&quot; that was consumed in this payment application event.
        ///
        /// Example: Company ABC received a credit memo, CM000123 for $500.  Company ABC then chooses to apply this
        /// credit memo to reduce the balance of the invoice PO1000578.  The `CreditMemoInvoiceId` is the Lockstep
        /// Platform ID number of Invoice `CM000123`.
        /// </summary>
        public Guid CreditMemoInvoiceId { get; set; }

        /// <summary>
        /// The unique ID of this record as it was known in its originating financial system.
        ///
        /// If this company record was imported from a financial system, it will have the value `ErpKey`
        /// set to the original primary key number of the record as it was known in the originating financial
        /// system.  If this record was not imported, this value will be `null`.
        ///
        /// For more information, see [Identity Columns](https://developer.lockstep.io/docs/identity-columns).
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string ErpKey { get; set; }
#else
        public string? ErpKey { get; set; }
#endif

        /// <summary>
        /// Reference number for the applied credit memo.
        /// </summary>
        public int EntryNumber { get; set; }

        /// <summary>
        /// The date on which this credit memo was applied to the Invoice represented by `InvoiceId`.
        /// </summary>
        public DateTime ApplyToInvoiceDate { get; set; }

        /// <summary>
        /// The amount of the credit memo that was applied to the Invoice represented by `InvoiceId`.
        /// </summary>
        public double CreditMemoAppliedAmount { get; set; }

        /// <summary>
        /// Date credit memo applied record was created.
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// The id of the user who created this applied credit memo.
        /// </summary>
        public Guid CreatedUserId { get; set; }

        /// <summary>
        /// Date credit memo applied record was modified.
        /// </summary>
        public DateTime Modified { get; set; }

        /// <summary>
        /// The id of the user who modified this applied credit memo.
        /// </summary>
        public Guid ModifiedUserId { get; set; }

        /// <summary>
        /// The AppEnrollmentId of the application that imported this record.  For accounts
        /// with more than one financial system connected, this field identifies the originating
        /// financial system that produced this record.  This value is null if this record
        /// was not loaded from an external ERP or financial system.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public Guid AppEnrollmentId { get; set; }
#else
        public Guid? AppEnrollmentId { get; set; }
#endif

        /// <summary>
        /// A collection of attachments linked to this record.  To retrieve this collection, specify `Attachments` in
        /// the `include` parameter when retrieving data.
        ///
        /// To create an attachment, use the [Upload Attachment](https://developer.lockstep.io/reference/post_api-v1-attachments)
        /// endpoint with the `TableKey` to `CreditMemoApplied` and the `ObjectKey` set to the `CreditMemoAppliedId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
#if DOT_NET_FRAMEWORK
        public AttachmentModel[] Attachments { get; set; }
#else
        public AttachmentModel[]? Attachments { get; set; }
#endif

        /// <summary>
        /// A collection of notes linked to this record.  To retrieve this collection, specify `Notes` in the
        /// `include` parameter when retrieving data.
        ///
        /// To create a note, use the [Create Note](https://developer.lockstep.io/reference/post_api-v1-notes)
        /// endpoint with the `TableKey` to `CreditMemoApplied` and the `ObjectKey` set to the `CreditMemoAppliedId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
#if DOT_NET_FRAMEWORK
        public NoteModel[] Notes { get; set; }
#else
        public NoteModel[]? Notes { get; set; }
#endif

        /// <summary>
        /// A collection of custom fields linked to this record.  To retrieve this collection, specify
        /// `CustomFieldDefinitions` in the `include` parameter when retrieving data.
        ///
        /// To create a custom field, use the [Create Custom Field](https://developer.lockstep.io/reference/post_api-v1-customfieldvalues)
        /// endpoint with the `TableKey` to `CreditMemoApplied` and the `ObjectKey` set to the `CreditMemoAppliedId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
#if DOT_NET_FRAMEWORK
        public CustomFieldDefinitionModel[] CustomFieldDefinitions { get; set; }
#else
        public CustomFieldDefinitionModel[]? CustomFieldDefinitions { get; set; }
#endif

        /// <summary>
        /// A collection of custom fields linked to this record.  To retrieve this collection, specify
        /// `CustomFieldValues` in the `include` parameter when retrieving data.
        ///
        /// To create a custom field, use the [Create Custom Field](https://developer.lockstep.io/reference/post_api-v1-customfieldvalues)
        /// endpoint with the `TableKey` to `CreditMemoApplied` and the `ObjectKey` set to the `CreditMemoAppliedId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
#if DOT_NET_FRAMEWORK
        public CustomFieldValueModel[] CustomFieldValues { get; set; }
#else
        public CustomFieldValueModel[]? CustomFieldValues { get; set; }
#endif
    }

    /// <summary>
    /// The CreditMemoAppliedSyncModel represents information coming into Lockstep from an external financial system or
    /// other enterprise resource planning system.  To import data from an external system, convert your original data
    /// into the CreditMemoAppliedSyncModel format and call the [Upload Sync File API](https://developer.lockstep.io/reference/post_api-v1-sync-zip).
    /// This API retrieves all of the data you uploaded in a compressed ZIP file and imports it into the Lockstep
    /// platform.
    ///
    /// Once imported, this record will be available in the Lockstep API as a [CreditMemoAppliedModel](https://developer.lockstep.io/docs/creditmemoappliedmodel).
    ///
    /// For more information on writing your own connector, see [Connector Data](https://developer.lockstep.io/docs/connector-data).
    /// </summary>
    public class CreditMemoAppliedSyncModel
    {

        /// <summary>
        /// This is the primary key of the Credit Memo Application record. For this field, you should use whatever this
        /// transaction&#39;s unique identifying number is in the originating system. Search for a unique, non-changing
        /// number within the originating financial system for this record.
        ///
        /// Since Credit Memo Applications are often considered transactions, a typical value to look for will be
        /// the transaction ID number, the payment confirmation number, or some other record of this payment.
        ///
        /// For more information, see [Identity Columns](https://developer.lockstep.io/docs/identity-columns).
        /// </summary>
        public string ErpKey { get; set; }

        /// <summary>
        /// This field indicates which Invoice had its balanced reduced by applying a credit memo.  In this field,
        /// identify the original primary key or unique ID of the Invoice which had its balanced reduced.
        ///
        /// Example: Company ABC received a credit memo, CM000123 for $500.  Company ABC then chooses to apply this
        /// credit memo to reduce the balance of the invoice PO1000578.  The `InvoiceErpKey` is `PO1000578`.
        /// </summary>
        public string InvoiceErpKey { get; set; }

        /// <summary>
        /// This field indicates which Invoice is the original credit memo that was used to make this payment
        /// application event.  In this field, identify the original primary key or unique ID of the Invoice which
        /// created the credit memo that was consumed in this event.
        ///
        /// Example: Company ABC received a credit memo, CM000123 for $500.  Company ABC then chooses to apply this
        /// credit memo to reduce the balance of the invoice PO1000578.  The `CreditMemoInvoiceErpKey` is `CM000123`.
        /// </summary>
        public string CreditMemoInvoiceErpKey { get; set; }

        /// <summary>
        /// Reference number for the applied credit memo.
        /// </summary>
        public int EntryNumber { get; set; }

        /// <summary>
        /// The date on which this credit memo was applied to the Invoice.
        /// </summary>
        public DateTime ApplyToInvoiceDate { get; set; }

        /// <summary>
        /// The amount of this credit memo that was applied to this Invoice.
        /// </summary>
        public double CreditMemoAppliedAmount { get; set; }

        /// <summary>
        /// If known, the date when this record was created according to the originating financial system
        /// in which this record is maintained.  If the originating financial system does not maintain a
        /// created-date, leave this field null.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime Created { get; set; }
#else
        public DateTime? Created { get; set; }
#endif

        /// <summary>
        /// If known, the date when this record was most recently modified according to the originating
        /// financial system in which this record is maintained.  If the originating financial system does
        /// not maintain a most-recently-modified-date, leave this field null.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime Modified { get; set; }
#else
        public DateTime? Modified { get; set; }
#endif
    }

    /// <summary>
    /// Contains information about a credit memo invoice
    /// </summary>
    public class CreditMemoInvoiceModel
    {

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid GroupKey { get; set; }

        /// <summary>
        /// The unique ID of this record, automatically assigned by Lockstep when this record is
        /// added to the Lockstep platform.
        /// </summary>
        public Guid CreditMemoAppliedId { get; set; }

        /// <summary>
        /// The id of the invoice
        /// </summary>
        public Guid InvoiceId { get; set; }

        /// <summary>
        /// The id of the credit memo invoice
        /// </summary>
        public Guid CreditMemoInvoiceId { get; set; }

        /// <summary>
        /// Date invoice applied to credit memo.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime ApplyToInvoiceDate { get; set; }
#else
        public DateTime? ApplyToInvoiceDate { get; set; }
#endif

        /// <summary>
        /// Amount applied to credit memo.
        /// </summary>
        public double CreditMemoAppliedAmount { get; set; }

        /// <summary>
        /// An additional reference code that is sometimes used to identify this invoice.
        /// The meaning of this field is specific to the ERP or accounting system used by the user.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string ReferenceCode { get; set; }
#else
        public string? ReferenceCode { get; set; }
#endif

        /// <summary>
        /// The ID number of the company that created this invoice.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public Guid CompanyId { get; set; }
#else
        public Guid? CompanyId { get; set; }
#endif

        /// <summary>
        /// The ID number of the counterparty for the invoice, for example, a customer or vendor.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public Guid CustomerId { get; set; }
#else
        public Guid? CustomerId { get; set; }
#endif

        /// <summary>
        /// A code identifying the status of this invoice.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string InvoiceStatusCode { get; set; }
#else
        public string? InvoiceStatusCode { get; set; }
#endif

        /// <summary>
        /// The total value of this invoice, inclusive of all taxes and line items.
        /// </summary>
        public double? TotalAmount { get; set; }

        /// <summary>
        /// The remaining balance value of this invoice.
        /// </summary>
        public double? OutstandingBalanceAmount { get; set; }
    }

    /// <summary>
    /// Represents an ISO-4217 currency code definition
    /// </summary>
    public class CurrencyModel
    {

        /// <summary>
        /// Alphabetic code for the given currency
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string AlphaCode { get; set; }
#else
        public string? AlphaCode { get; set; }
#endif

        /// <summary>
        /// Numeric code for the given currency
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string NumericCode { get; set; }
#else
        public string? NumericCode { get; set; }
#endif

        /// <summary>
        /// Name of currency
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string CurrencyName { get; set; }
#else
        public string? CurrencyName { get; set; }
#endif

        /// <summary>
        /// Number of places after the decimal for this currency
        /// </summary>
        public int MinorUnit { get; set; }

        /// <summary>
        /// Symbol for the given currency
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Symbol { get; set; }
#else
        public string? Symbol { get; set; }
#endif
    }

    /// <summary>
    /// Represents a currency rate for specific currencies and date
    /// </summary>
    public class CurrencyRateModel
    {

        /// <summary>
        /// The source currency
        /// </summary>
        public string SourceCurrency { get; set; }

        /// <summary>
        /// The destination currency
        /// </summary>
        public string DestinationCurrency { get; set; }

        /// <summary>
        /// The date for the currency rate
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// The currency rate value
        /// </summary>
        public double? CurrencyRate { get; set; }
    }

    /// <summary>
    /// Contains customer details data
    /// </summary>
    public class CustomerDetailsModel
    {

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid GroupKey { get; set; }

        /// <summary>
        /// The unique ID of this customer
        /// </summary>
        public Guid CustomerId { get; set; }

        /// <summary>
        /// The unique ID of this customer
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Name { get; set; }
#else
        public string? Name { get; set; }
#endif

        /// <summary>
        /// Customer address info
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Address1 { get; set; }
#else
        public string? Address1 { get; set; }
#endif

        /// <summary>
        /// Customer address info
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Address2 { get; set; }
#else
        public string? Address2 { get; set; }
#endif

        /// <summary>
        /// Customer address info
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Address3 { get; set; }
#else
        public string? Address3 { get; set; }
#endif

        /// <summary>
        /// Customer address info
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string City { get; set; }
#else
        public string? City { get; set; }
#endif

        /// <summary>
        /// Customer address info
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string State { get; set; }
#else
        public string? State { get; set; }
#endif

        /// <summary>
        /// Customer address info
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string PostalCode { get; set; }
#else
        public string? PostalCode { get; set; }
#endif

        /// <summary>
        /// Customer address country
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Country { get; set; }
#else
        public string? Country { get; set; }
#endif

        /// <summary>
        /// Customer phone number
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string PhoneNumber { get; set; }
#else
        public string? PhoneNumber { get; set; }
#endif

        /// <summary>
        /// Customer fax number
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string FaxNumber { get; set; }
#else
        public string? FaxNumber { get; set; }
#endif

        /// <summary>
        /// Customer AR email address
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Email { get; set; }
#else
        public string? Email { get; set; }
#endif

        /// <summary>
        /// Customer primary contact id
        /// </summary>
        public Guid ContactId { get; set; }

        /// <summary>
        /// Customer primary contact name
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string ContactName { get; set; }
#else
        public string? ContactName { get; set; }
#endif

        /// <summary>
        /// Customer primary contact email address
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string ContactEmail { get; set; }
#else
        public string? ContactEmail { get; set; }
#endif

        /// <summary>
        /// Customer number of outstanding invoices
        /// </summary>
        public int OutstandingInvoices { get; set; }

        /// <summary>
        /// Customer total outstanding invoice amount
        /// </summary>
        public double OutstandingAmount { get; set; }

        /// <summary>
        /// Customer total past due amount
        /// </summary>
        public double AmountPastDue { get; set; }

        /// <summary>
        /// Customer payments collected
        /// </summary>
#if DOT_NET_FRAMEWORK
        public CustomerDetailsPaymentModel[] Payments { get; set; }
#else
        public CustomerDetailsPaymentModel[]? Payments { get; set; }
#endif
    }

    /// <summary>
    /// Customer payment collected information
    /// </summary>
    public class CustomerDetailsPaymentModel
    {

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid GroupKey { get; set; }

        /// <summary>
        /// Unique identifier for payment
        /// </summary>
        public Guid PaymentId { get; set; }

        /// <summary>
        /// Unique identifier for payment applied
        /// </summary>
#if DOT_NET_FRAMEWORK
        public Guid PaymentAppliedId { get; set; }
#else
        public Guid? PaymentAppliedId { get; set; }
#endif

        /// <summary>
        /// Payment type
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string PaymentType { get; set; }
#else
        public string? PaymentType { get; set; }
#endif

        /// <summary>
        /// Unique identifier for invoice payment is associated with
        /// </summary>
#if DOT_NET_FRAMEWORK
        public Guid InvoiceId { get; set; }
#else
        public Guid? InvoiceId { get; set; }
#endif

        /// <summary>
        /// Invoice type payment is associated with
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string InvoiceTypeCode { get; set; }
#else
        public string? InvoiceTypeCode { get; set; }
#endif

        /// <summary>
        /// Invoice reference code payment is associated with
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string InvoiceReferenceCode { get; set; }
#else
        public string? InvoiceReferenceCode { get; set; }
#endif

        /// <summary>
        /// Invoice total amount payment is associated with
        /// </summary>
        public double InvoiceTotalAmount { get; set; }

        /// <summary>
        /// Date payment placed
        /// </summary>
        public DateTime PaymentDate { get; set; }

        /// <summary>
        /// Amount payment was made for
        /// </summary>
        public double PaymentAmount { get; set; }
    }

    /// <summary>
    /// Contains summarized data for a customer
    /// </summary>
    public class CustomerSummaryModel
    {

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid GroupKey { get; set; }

        /// <summary>
        /// The unique ID of this company.
        /// </summary>
        public Guid CompanyId { get; set; }

        /// <summary>
        /// The name of the company.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string CompanyName { get; set; }
#else
        public string? CompanyName { get; set; }
#endif

        /// <summary>
        /// The name of the primary contact.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string PrimaryContact { get; set; }
#else
        public string? PrimaryContact { get; set; }
#endif

        /// <summary>
        /// The number of outstanding invoices for this customer.
        /// </summary>
        public int? OutstandingInvoices { get; set; }

        /// <summary>
        /// The number of open invoices.
        /// </summary>
        public int? TotalInvoicesOpen { get; set; }

        /// <summary>
        /// The number of past due invoices.
        /// </summary>
        public int? TotalInvoicesPastDue { get; set; }

        /// <summary>
        /// The number of closed invoices for this customer.
        /// </summary>
        public int? ClosedInvoices { get; set; }

        /// <summary>
        /// The total from collected payments.
        /// </summary>
        public double? AmountCollected { get; set; }

        /// <summary>
        /// The total balance of outstanding invoices.
        /// </summary>
        public double? OutstandingAmount { get; set; }

        /// <summary>
        /// The total amount past due for this customer.
        /// </summary>
        public double? AmountPastDue { get; set; }

        /// <summary>
        /// The total value of unapplied Payments for this Customer.
        /// </summary>
        public double? UnappliedPayments { get; set; }

        /// <summary>
        /// Portion of Total AR for this Customer that is Past due. (TotalPastDue / Total AR).
        /// </summary>
        public double? PercentOfTotalAr { get; set; }

        /// <summary>
        /// Daily sales outstanding value for this Customer.
        /// </summary>
        public double? Dso { get; set; }

        /// <summary>
        /// The date stamp for the newest Activity on this Customer.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime NewestActivity { get; set; }
#else
        public DateTime? NewestActivity { get; set; }
#endif
    }

    /// <summary>
    /// A Custom Field represents metadata added to an object within the Lockstep Platform.  Lockstep provides a
    /// core definition for each object.  The core definition is intended to represent a level of compatibility
    /// that provides support across most accounting systems and products.  When a user or developer requires
    /// information beyond this core definition, you can use Custom Fields to represent this information.
    ///
    /// See [Extensibility](https://developer.lockstep.io/docs/extensibility) for more information.
    /// </summary>
    public class CustomFieldDefinitionModel
    {

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid GroupKey { get; set; }

        /// <summary>
        /// The unique ID of this record, automatically assigned by Lockstep when this record is
        /// added to the Lockstep platform.
        /// </summary>
        public Guid CustomFieldDefinitionId { get; set; }

        /// <summary>
        /// Table to which this definition belongs
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string TableKey { get; set; }
#else
        public string? TableKey { get; set; }
#endif

        /// <summary>
        /// Id of app this definition belongs to
        /// </summary>
#if DOT_NET_FRAMEWORK
        public Guid AppId { get; set; }
#else
        public Guid? AppId { get; set; }
#endif

        /// <summary>
        /// Text to display in-application for custom field
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string CustomFieldLabel { get; set; }
#else
        public string? CustomFieldLabel { get; set; }
#endif

        /// <summary>
        /// Data type of this definition
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string DataType { get; set; }
#else
        public string? DataType { get; set; }
#endif

        /// <summary>
        /// Used for display logic when multiple custom fields exist
        /// </summary>
        public int SortOrder { get; set; }

        /// <summary>
        /// Date created
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Id of user who created this definition
        /// </summary>
        public Guid CreatedUserId { get; set; }

        /// <summary>
        /// Date modified
        /// </summary>
        public DateTime Modified { get; set; }

        /// <summary>
        /// Id of user who modified this definition
        /// </summary>
        public Guid ModifiedUserId { get; set; }

        /// <summary>
        /// The AppEnrollmentId of the application that imported this record.  For accounts
        /// with more than one financial system connected, this field identifies the originating
        /// financial system that produced this record.  This value is null if this record
        /// was not loaded from an external ERP or financial system.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public Guid AppEnrollmentId { get; set; }
#else
        public Guid? AppEnrollmentId { get; set; }
#endif
    }

    /// <summary>
    /// The CustomFieldSyncModel represents information coming into Lockstep from an external financial system or other
    /// enterprise resource planning system.  [Custom Fields](https://developer.lockstep.io/docs/custom-fields#custom-fields)
    /// represent custom data extensions that you can use with the Lockstep Platform.  If you need to store extra
    /// information about an object that does not match Lockstep&#39;s official schema, you can store it in the Custom
    /// Field system using CustomFieldSyncModel.
    ///
    /// To store a custom field for an object, create a CustomFieldSyncModel record containing the `EntityType` and
    /// `ErpKey` of the entity to which you will attach a custom field. Next specify the field&#39;s `CustomFieldLabel`
    /// and either a `StringValue` or `NumericValue`.
    ///
    /// Once imported, this record will be available in the Lockstep API as a [CustomFieldValueModel](https://developer.lockstep.io/docs/customfieldvaluemodel).
    ///
    /// For more information on writing your own connector, see [Connector Data](https://developer.lockstep.io/docs/connector-data).
    /// </summary>
    public class CustomFieldSyncModel
    {

        /// <summary>
        /// This is the primary key of the record to which you will attach this custom field. You should provide the
        /// identifying number as it is stored in the originating financial system. Search for a unique, non-changing
        /// number within the originating financial system for this record.
        ///
        /// Custom Fields are identified by the `EntityType` and `ErpKey` values together.
        ///
        /// Example: You have an invoice whose ID number is 100047878, and you wish to store a custom field on that
        /// invoice named &quot;ApprovalStatusCode&quot;.  For the `ErpKey` field, specify the value `100047878`.
        ///
        /// For more information, see [Identity Columns](https://developer.lockstep.io/docs/identity-columns).
        /// </summary>
        public string ErpKey { get; set; }

        /// <summary>
        /// Custom Fields are identified by the `EntityType` and `ErpKey` values together.
        ///
        /// Example: You have an invoice whose ID number is 100047878, and you wish to store a custom field on that
        /// invoice named &quot;ApprovalStatusCode&quot;.  For the `EntityType` field, specify the value `Invoice`.
        ///
        /// Recognized types include:
        /// * `Company` - Link this custom field to a CompanySyncModel
        /// * `Contact` - Link this custom field to a ContactSyncModel
        /// * `Invoice` - Link this custom field to an InvoiceSyncModel
        /// * `InvoiceLine` - Link this custom field to an InvoiceLineSyncModel
        /// * `Payment` - Link this custom field to a PaymentSyncModel
        /// </summary>
        public string EntityType { get; set; }

        /// <summary>
        /// A label that uniquely identifies this custom field within your software.
        ///
        /// Example: You have an invoice whose ID number is 100047878, and you wish to store a custom field on that
        /// invoice named &quot;ApprovalStatusCode&quot;.  For the `CustomFieldLabel` field, specify the value `ApprovalStatusCode`.
        /// </summary>
        public string CustomFieldLabel { get; set; }

        /// <summary>
        /// The value of this custom field.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Value { get; set; }
#else
        public string? Value { get; set; }
#endif

        /// <summary>
        /// If known, the date when this record was created according to the originating financial system
        /// in which this record is maintained.  If the originating financial system does not maintain a
        /// created-date, leave this field null.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime Created { get; set; }
#else
        public DateTime? Created { get; set; }
#endif

        /// <summary>
        /// If known, the date when this record was most recently modified according to the originating
        /// financial system in which this record is maintained.  If the originating financial system does
        /// not maintain a most-recently-modified-date, leave this field null.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime Modified { get; set; }
#else
        public DateTime? Modified { get; set; }
#endif
    }

    /// <summary>
    /// A Custom Field represents metadata added to an object within the Lockstep Platform.  Lockstep provides a
    /// core definition for each object.  The core definition is intended to represent a level of compatibility
    /// that provides support across most accounting systems and products.  When a user or developer requires
    /// information beyond this core definition, you can use Custom Fields to represent this information.
    ///
    /// See [Extensibility](https://developer.lockstep.io/docs/extensibility) for more information.
    /// </summary>
    public class CustomFieldValueModel
    {

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid GroupKey { get; set; }

        /// <summary>
        /// The unique ID of this record, automatically assigned by Lockstep when this record is
        /// added to the Lockstep platform.
        /// </summary>
        public Guid CustomFieldDefinitionId { get; set; }

        /// <summary>
        /// Additional key if source table doesn&#39;t have a unique id
        /// </summary>
        public Guid RecordKey { get; set; }

        /// <summary>
        /// Date created
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Id of user who created this value
        /// </summary>
        public Guid CreatedUserId { get; set; }

        /// <summary>
        /// Date modified
        /// </summary>
        public DateTime Modified { get; set; }

        /// <summary>
        /// Id of user who modified this value
        /// </summary>
        public Guid ModifiedUserId { get; set; }

        /// <summary>
        /// The AppEnrollmentId of the application that imported this attachment record.  For accounts
        /// with more than one financial system connected, this field identifies the originating
        /// financial system that produced this record.  This value is null if this record
        /// was not loaded from an external ERP or financial system.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public Guid AppEnrollmentId { get; set; }
#else
        public Guid? AppEnrollmentId { get; set; }
#endif

        /// <summary>
        /// The value of this custom field.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Value { get; set; }
#else
        public string? Value { get; set; }
#endif

        /// <summary>
        /// Definition of the value
        /// </summary>
#if DOT_NET_FRAMEWORK
        public CustomFieldDefinitionModel CustomFieldDefinition { get; set; }
#else
        public CustomFieldDefinitionModel? CustomFieldDefinition { get; set; }
#endif
    }

    /// <summary>
    /// Represents the daily sales outstanding report
    /// </summary>
    public class DailySalesOutstandingReportModel
    {

        /// <summary>
        /// Timeframe (month) the daily sales outstanding values are associated with
        /// </summary>
        public DateTime Timeframe { get; set; }

        /// <summary>
        /// Number of invoices the average daily sales outstanding is calculated on
        /// </summary>
        public int InvoiceCount { get; set; }

        /// <summary>
        /// Time (in days) between an invoice was completed paid off and when the invoice was issued
        /// </summary>
        public double DailySalesOutstanding { get; set; }
    }

    /// <summary>
    /// Model containing information to create a new developer account.
    /// </summary>
    public class DeveloperAccountSubmitModel
    {

        /// <summary>
        /// The name of the developer.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The email address of the developer.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// The company name of the developer.
        /// </summary>
        public string CompanyName { get; set; }
    }

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
        public Guid EmailId { get; set; }

        /// <summary>
        /// The unique ID number of this email&#39;s conversation thread.
        /// </summary>
        public Guid ThreadId { get; set; }

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid GroupKey { get; set; }

        /// <summary>
        /// The ID number of the company that created this email.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public Guid CompanyId { get; set; }
#else
        public Guid? CompanyId { get; set; }
#endif

        /// <summary>
        /// The email address for the sender of this email.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string EmailFrom { get; set; }
#else
        public string? EmailFrom { get; set; }
#endif

        /// <summary>
        /// The email address for the recipient(s) of this email.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string EmailTo { get; set; }
#else
        public string? EmailTo { get; set; }
#endif

        /// <summary>
        /// The email address for the CC recipient(s) of this email
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string EmailCC { get; set; }
#else
        public string? EmailCC { get; set; }
#endif

        /// <summary>
        /// The subject line of this email.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string EmailSubject { get; set; }
#else
        public string? EmailSubject { get; set; }
#endif

        /// <summary>
        /// The body content of this email.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string EmailBody { get; set; }
#else
        public string? EmailBody { get; set; }
#endif

        /// <summary>
        /// The date on which this email was sent.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime SentDate { get; set; }
#else
        public DateTime? SentDate { get; set; }
#endif

        /// <summary>
        /// A status flag indicating if this email is unread.
        /// </summary>
        public bool IsUnread { get; set; }

        /// <summary>
        /// A status flag indicating if this email is priority status.
        /// </summary>
        public bool IsPriority { get; set; }

        /// <summary>
        /// A status flag indicating if this email is marked as spam.
        /// </summary>
        public bool IsSpam { get; set; }

        /// <summary>
        /// The date on which this email was created.
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// The ID number of the user who created this email.
        /// </summary>
        public Guid CreatedUserId { get; set; }

        /// <summary>
        /// A status flag indicating if this email is to be sent.
        /// </summary>
        public bool ToBeSent { get; set; }

        /// <summary>
        /// The ID number of the customer that sent this email.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public Guid CustomerId { get; set; }
#else
        public Guid? CustomerId { get; set; }
#endif

        /// <summary>
        /// The date on which this email was received.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime ReceivedTimeStamp { get; set; }
#else
        public DateTime? ReceivedTimeStamp { get; set; }
#endif

        /// <summary>
        /// The date on which this email was opened.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime OpenedTimestamp { get; set; }
#else
        public DateTime? OpenedTimestamp { get; set; }
#endif

        /// <summary>
        /// The number of times this email was viewed.
        /// </summary>
        public int ViewCount { get; set; }

        /// <summary>
        /// The AppEnrollmentId of the application that imported this record.  For accounts
        /// with more than one financial system connected, this field identifies the originating
        /// financial system that produced this record.  This value is null if this record
        /// was not loaded from an external ERP or financial system.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public Guid AppEnrollmentId { get; set; }
#else
        public Guid? AppEnrollmentId { get; set; }
#endif

        /// <summary>
        /// The id of the email in an external system if imported.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string ExternalEmailId { get; set; }
#else
        public string? ExternalEmailId { get; set; }
#endif

        /// <summary>
        /// The id of the email thread in an external system if imported.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string ExternalThreadId { get; set; }
#else
        public string? ExternalThreadId { get; set; }
#endif

        /// <summary>
        /// The email address(es) for the BCC recipient(s) of this email
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string EmailBcc { get; set; }
#else
        public string? EmailBcc { get; set; }
#endif

        /// <summary>
        /// The type message being sent (New, Reply, Forward) or null for messages not being sent.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string SendType { get; set; }
#else
        public string? SendType { get; set; }
#endif

        /// <summary>
        /// The date on which this email was modified.
        /// Email modification should only be done by internal services.
        /// </summary>
        public DateTime Modified { get; set; }

        /// <summary>
        /// The ID of the user who modified this email.
        /// Email modification should only be done by internal services.
        /// </summary>
        public Guid ModifiedUserId { get; set; }

        /// <summary>
        /// If the message being sent is a reply or a forward, the id of the the email being replied to or forwarded.
        /// Otherwise null.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public Guid ResponseOriginId { get; set; }
#else
        public Guid? ResponseOriginId { get; set; }
#endif

        /// <summary>
        /// The email object associated with the response origin id.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public EmailModel ResponseOrigin { get; set; }
#else
        public EmailModel? ResponseOrigin { get; set; }
#endif

        /// <summary>
        /// A collection of notes linked to this record.  To retrieve this collection, specify `Notes` in the
        /// `include` parameter when retrieving data.
        ///
        /// To create a note, use the [Create Note](https://developer.lockstep.io/reference/post_api-v1-notes)
        /// endpoint with the `TableKey` to `Email` and the `ObjectKey` set to the `EmailId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
#if DOT_NET_FRAMEWORK
        public NoteModel[] Notes { get; set; }
#else
        public NoteModel[]? Notes { get; set; }
#endif

        /// <summary>
        /// A collection of attachments linked to this record.  To retrieve this collection, specify `Attachments` in
        /// the `include` parameter when retrieving data.
        ///
        /// To create an attachment, use the [Upload Attachment](https://developer.lockstep.io/reference/post_api-v1-attachments)
        /// endpoint with the `TableKey` to `Email` and the `ObjectKey` set to the `EmailId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
#if DOT_NET_FRAMEWORK
        public AttachmentModel[] Attachments { get; set; }
#else
        public AttachmentModel[]? Attachments { get; set; }
#endif

        /// <summary>
        /// A collection of custom fields linked to this record.  To retrieve this collection, specify
        /// `CustomFieldDefinitions` in the `include` parameter when retrieving data.
        ///
        /// To create a custom field, use the [Create Custom Field](https://developer.lockstep.io/reference/post_api-v1-customfieldvalues)
        /// endpoint with the `TableKey` to `Email` and the `ObjectKey` set to the `EmailId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
#if DOT_NET_FRAMEWORK
        public CustomFieldDefinitionModel[] CustomFieldDefinitions { get; set; }
#else
        public CustomFieldDefinitionModel[]? CustomFieldDefinitions { get; set; }
#endif

        /// <summary>
        /// A collection of custom fields linked to this record.  To retrieve this collection, specify
        /// `CustomFieldValues` in the `include` parameter when retrieving data.
        ///
        /// To create a custom field, use the [Create Custom Field](https://developer.lockstep.io/reference/post_api-v1-customfieldvalues)
        /// endpoint with the `TableKey` to `Email` and the `ObjectKey` set to the `EmailId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
#if DOT_NET_FRAMEWORK
        public CustomFieldValueModel[] CustomFieldValues { get; set; }
#else
        public CustomFieldValueModel[]? CustomFieldValues { get; set; }
#endif
    }

    /// <summary>
    /// Represents the ERP object sent in a provisioning request
    /// </summary>
    public class ErpInfoModel
    {

        /// <summary>
        /// The id of the ERP&#39;s App
        /// </summary>
        public Guid AppId { get; set; }

        /// <summary>
        /// The data required to store for connector access
        /// </summary>
#if DOT_NET_FRAMEWORK
        public ConnectorInfoModel Data { get; set; }
#else
        public ConnectorInfoModel? Data { get; set; }
#endif
    }

    /// <summary>
    /// Represents unsupported ERP systems
    /// </summary>
    public class ErpModel
    {

        /// <summary>
        /// Unique ID for this ERP
        /// </summary>
        public Guid ErpSystemId { get; set; }

        /// <summary>
        /// Name of ERP
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Name { get; set; }
#else
        public string? Name { get; set; }
#endif

        /// <summary>
        /// Flag to indicate if ERP is supported
        /// </summary>
        public bool IsSupported { get; set; }
    }

    /// <summary>
    /// Represents a balance for a financial account for a given period of time.
    /// </summary>
    public class FinancialAccountBalanceHistoryModel
    {

        /// <summary>
        /// The unique ID of this record, automatically assigned by Lockstep when this record is
        /// added to the Lockstep platform.
        /// </summary>
        public Guid FinancialAccountBalanceHistoryId { get; set; }

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid GroupKey { get; set; }

        /// <summary>
        /// The id of the Financial Account that this balance history is for.
        /// </summary>
        public Guid FinancialAccountId { get; set; }

        /// <summary>
        /// The AppEnrollmentId of the application that imported this record.  For accounts
        /// with more than one financial system connected, this field identifies the originating
        /// financial system that produced this record.  This value is null if this record
        /// was not loaded from an external ERP or financial system.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public Guid AppEnrollmentId { get; set; }
#else
        public Guid? AppEnrollmentId { get; set; }
#endif

        /// <summary>
        /// The financial year that this period falls under
        /// </summary>
        public int FinancialYear { get; set; }

        /// <summary>
        /// The period number (1-12 or 1-13) that this balance history is for
        /// </summary>
        public int PeriodNumber { get; set; }

        /// <summary>
        /// The start date of this period.
        /// </summary>
        public DateTime PeriodStartDate { get; set; }

        /// <summary>
        /// The end date of this period.
        /// </summary>
        public DateTime PeriodEndDate { get; set; }

        /// <summary>
        /// The status of this period. The status should be Closed if the books for this period have been closed,
        /// if not the status should be Open. The status can also be Deleted if there was a recalculation that needed
        /// to occur, for example due to a change in financial year settings.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Status { get; set; }
#else
        public string? Status { get; set; }
#endif

        /// <summary>
        /// The current or end balance of this period.
        /// </summary>
        public double Balance { get; set; }

        /// <summary>
        /// The date on which this financial account balance history record was created.
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// The ID number of the user who created this financial account balance history.
        /// </summary>
        public Guid CreatedUserId { get; set; }

        /// <summary>
        /// The date on which this financial account balance history record was modified.
        /// </summary>
        public DateTime Modified { get; set; }

        /// <summary>
        /// The ID number of the user who most recently modified this financial account balance history.
        /// </summary>
        public Guid ModifiedUserId { get; set; }
    }

    /// <summary>
    /// An Financial account refers to records of assets, liabilities, income, expenses, and equity.
    /// </summary>
    public class FinancialAccountModel
    {

        /// <summary>
        /// The unique identifier for the Financial Account.
        /// </summary>
        public Guid FinancialAccountId { get; set; }

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid GroupKey { get; set; }

        /// <summary>
        /// The code for the Financial Account. Can either be a general ledger or
        /// an account code.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Code { get; set; }
#else
        public string? Code { get; set; }
#endif

        /// <summary>
        /// The External Id for the Financial Account.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string ErpKey { get; set; }
#else
        public string? ErpKey { get; set; }
#endif

        /// <summary>
        /// The App Enrollment Id for the Financial Account.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public Guid AppEnrollmentId { get; set; }
#else
        public Guid? AppEnrollmentId { get; set; }
#endif

        /// <summary>
        /// The name of the Financial Account.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Name { get; set; }
#else
        public string? Name { get; set; }
#endif

        /// <summary>
        /// The status of the Financial Account. Possible values are active,
        /// inactive, deleted or archived.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Status { get; set; }
#else
        public string? Status { get; set; }
#endif

        /// <summary>
        /// The cashflow type for the Financial Account. Examples include cash, financing, investment
        /// or operation.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string CashflowType { get; set; }
#else
        public string? CashflowType { get; set; }
#endif

        /// <summary>
        /// The description for the Financial Account.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Description { get; set; }
#else
        public string? Description { get; set; }
#endif

        /// <summary>
        /// The classification for the Financial Account. Possible values are Asset, Equity,
        /// Expense, Liability or Revenue.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Classification { get; set; }
#else
        public string? Classification { get; set; }
#endif

        /// <summary>
        /// The category for the Financial Account. Examples include Current Asset, Current Liability, Common Stock
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Category { get; set; }
#else
        public string? Category { get; set; }
#endif

        /// <summary>
        /// The subcategory for the Financial Account. Examples include Cash, Property, Bank Loan, etc.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Subcategory { get; set; }
#else
        public string? Subcategory { get; set; }
#endif

        /// <summary>
        /// The date the FinancialAccount was created.
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// The user that has created the Financial Account.
        /// </summary>
        public Guid CreatedUserId { get; set; }

        /// <summary>
        /// The date the Financial Account was modified.
        /// </summary>
        public DateTime Modified { get; set; }

        /// <summary>
        /// The user that has modified the Financial Account.
        /// </summary>
        public Guid ModifiedUserId { get; set; }
    }

    /// <summary>
    /// A Financial Year Setting is used to to set the type, beginning, end, and number of periods of a year used to
    /// calculate accounting reports. The financial setting can either be for a specific app enrollment id via a sync
    /// or, when the financial year setting is manually created, will cover all account data without an app enrollment id.
    /// </summary>
    public class FinancialYearSettingModel
    {

        /// <summary>
        /// The unique ID of this record, automatically assigned by Lockstep when this record is
        /// added to the Lockstep platform.
        /// </summary>
        public Guid FinancialYearSettingId { get; set; }

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid GroupKey { get; set; }

        /// <summary>
        /// The AppEnrollmentId of the application that imported this record.  For accounts
        /// with more than one financial system connected, this field identifies the originating
        /// financial system that produced this record.  This value is null if this record
        /// was not loaded from an external ERP or financial system.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public Guid AppEnrollmentId { get; set; }
#else
        public Guid? AppEnrollmentId { get; set; }
#endif

        /// <summary>
        /// The type of financial year, either Calendar or Fiscal.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string YearType { get; set; }
#else
        public string? YearType { get; set; }
#endif

        /// <summary>
        /// Total number of periods in the year. For Calendar year types this should always be 12. For Fiscal year types
        /// this can either be 12 or 13 for a 4 week 13 period year.
        /// </summary>
        public int TotalPeriods { get; set; }

        /// <summary>
        /// The start date of the financial year. Should be entered in MM-DD format.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime StartDate { get; set; }
#else
        public DateTime? StartDate { get; set; }
#endif

        /// <summary>
        /// The end date of the financial year. Should be entered in MM-DD format.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime EndDate { get; set; }
#else
        public DateTime? EndDate { get; set; }
#endif

        /// <summary>
        /// The date on which this financial year setting record was created.
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// The ID number of the user who created this financial year setting.
        /// </summary>
        public Guid CreatedUserId { get; set; }

        /// <summary>
        /// The date on which this financial year setting record was last modified.
        /// </summary>
        public DateTime Modified { get; set; }

        /// <summary>
        /// The ID number of the user who most recently modified this financial year setting.
        /// </summary>
        public Guid ModifiedUserId { get; set; }
    }

    /// <summary>
    /// Model containing information about a user for the invite/onboarding process.
    /// </summary>
    public class InviteDataModel
    {

        /// <summary>
        /// The email address of the invited user.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Email { get; set; }
#else
        public string? Email { get; set; }
#endif

        /// <summary>
        /// The status of the user.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string UserStatus { get; set; }
#else
        public string? UserStatus { get; set; }
#endif
    }

    /// <summary>
    /// Model from the User invite process
    /// </summary>
    public class InviteModel
    {

        /// <summary>
        /// The invited email address
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Email { get; set; }
#else
        public string? Email { get; set; }
#endif

        /// <summary>
        /// True if the invite was sent successfully
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// The invited user, may be null if the user could not be invited
        /// </summary>
#if DOT_NET_FRAMEWORK
        public UserAccountModel InvitedUser { get; set; }
#else
        public UserAccountModel? InvitedUser { get; set; }
#endif

        /// <summary>
        /// The error message if the invite was not successful
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string ErrorMessage { get; set; }
#else
        public string? ErrorMessage { get; set; }
#endif
    }

    /// <summary>
    /// Model to invite a new user to your accounting group
    /// </summary>
    public class InviteSubmitModel
    {

        /// <summary>
        /// The email address of the user to invite
        /// </summary>
        public string Email { get; set; }
    }

    /// <summary>
    /// Represents a single address for an invoice
    /// </summary>
    public class InvoiceAddressModel
    {

        /// <summary>
        /// The unique ID of this record, automatically assigned by Lockstep when this record is
        /// added to the Lockstep platform.
        /// </summary>
        public Guid InvoiceAddressId { get; set; }

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid GroupKey { get; set; }

        /// <summary>
        /// The ID number of the invoice this address belongs to
        /// </summary>
        public Guid InvoiceId { get; set; }

        /// <summary>
        /// The first line of the address.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Line1 { get; set; }
#else
        public string? Line1 { get; set; }
#endif

        /// <summary>
        /// The second line of the address.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Line2 { get; set; }
#else
        public string? Line2 { get; set; }
#endif

        /// <summary>
        /// The third line of the address.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Line3 { get; set; }
#else
        public string? Line3 { get; set; }
#endif

        /// <summary>
        /// The name of the city for this address.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string City { get; set; }
#else
        public string? City { get; set; }
#endif

        /// <summary>
        /// The state or region part of this address.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Region { get; set; }
#else
        public string? Region { get; set; }
#endif

        /// <summary>
        /// The postal code for this address.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string PostalCode { get; set; }
#else
        public string? PostalCode { get; set; }
#endif

        /// <summary>
        /// The country for this address.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Country { get; set; }
#else
        public string? Country { get; set; }
#endif

        /// <summary>
        /// The latitude of this address, if available.
        /// </summary>
        public float? Latitude { get; set; }

        /// <summary>
        /// The longitude of this address, if available.
        /// </summary>
        public float? Longitude { get; set; }

        /// <summary>
        /// The date on which this address record was created.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime Created { get; set; }
#else
        public DateTime? Created { get; set; }
#endif

        /// <summary>
        /// The ID number of the user who created this address.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public Guid CreatedUserId { get; set; }
#else
        public Guid? CreatedUserId { get; set; }
#endif

        /// <summary>
        /// The date on which this address record was last modified.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime Modified { get; set; }
#else
        public DateTime? Modified { get; set; }
#endif

        /// <summary>
        /// The ID number of the user who most recently modified this address.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public Guid ModifiedUserId { get; set; }
#else
        public Guid? ModifiedUserId { get; set; }
#endif

        /// <summary>
        /// The AppEnrollmentId of the application that imported this record.  For accounts
        /// with more than one financial system connected, this field identifies the originating
        /// financial system that produced this record.  This value is null if this record
        /// was not loaded from an external ERP or financial system.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public Guid AppEnrollmentId { get; set; }
#else
        public Guid? AppEnrollmentId { get; set; }
#endif
    }

    /// <summary>
    /// An Invoice represents a bill sent from one company to another.  The Lockstep Platform tracks changes to
    /// each Invoice so that you can observe the changes over time.  You can view the InvoiceHistory list to
    /// monitor and observe the changes of this Invoice and track the dates when changes occurred.
    /// </summary>
    public class InvoiceHistoryModel
    {

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid GroupKey { get; set; }

        /// <summary>
        /// The unique ID number of this invoice history entry.
        /// </summary>
        public Guid InvoiceHistoryId { get; set; }

        /// <summary>
        /// The unique ID of the Invoice represented by this history entry.  This ID was automatically assigned
        /// by Lockstep to the Invoice record when it was added to the Lockstep platform.
        ///
        /// For the ID of this record in its originating financial system, see `ErpKey`.
        /// </summary>
        public Guid InvoiceId { get; set; }

        /// <summary>
        /// The ID number of the company that created this invoice.
        /// </summary>
        public Guid CompanyId { get; set; }

        /// <summary>
        /// The ID number of the counterparty for the invoice, for example, a customer or vendor.
        /// </summary>
        public Guid CustomerId { get; set; }

        /// <summary>
        /// The unique ID of this record as it was known in its originating financial system.
        ///
        /// If this company record was imported from a financial system, it will have the value `ErpKey`
        /// set to the original primary key number of the record as it was known in the originating financial
        /// system.  If this record was not imported, this value will be `null`.
        ///
        /// For more information, see [Identity Columns](https://developer.lockstep.io/docs/identity-columns).
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string ErpKey { get; set; }
#else
        public string? ErpKey { get; set; }
#endif

        /// <summary>
        /// The purchase order code as it exists in the user&#39;s ERP or accounting system.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string PurchaseOrderCode { get; set; }
#else
        public string? PurchaseOrderCode { get; set; }
#endif

        /// <summary>
        /// An additional reference code that is sometimes used to identify this invoice.
        /// The meaning of this field is specific to the ERP or accounting system used by the user.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string ReferenceCode { get; set; }
#else
        public string? ReferenceCode { get; set; }
#endif

        /// <summary>
        /// A code identifying the salesperson responsible for writing this invoice.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string SalespersonCode { get; set; }
#else
        public string? SalespersonCode { get; set; }
#endif

        /// <summary>
        /// A string identifying the salesperson responsible for writing this invoice.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string SalespersonName { get; set; }
#else
        public string? SalespersonName { get; set; }
#endif

        /// <summary>
        /// A code identifying the type of this invoice.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string InvoiceTypeCode { get; set; }
#else
        public string? InvoiceTypeCode { get; set; }
#endif

        /// <summary>
        /// A code identifying the status of this invoice.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string InvoiceStatusCode { get; set; }
#else
        public string? InvoiceStatusCode { get; set; }
#endif

        /// <summary>
        /// A code identifying the terms given to the purchaser.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string TermsCode { get; set; }
#else
        public string? TermsCode { get; set; }
#endif

        /// <summary>
        /// If the customer negotiated any special terms different from the standard terms above, describe them here.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string SpecialTerms { get; set; }
#else
        public string? SpecialTerms { get; set; }
#endif

        /// <summary>
        /// The three-character ISO 4217 currency code used for this invoice. This will be validated by the /api/v1/currencies data set
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string CurrencyCode { get; set; }
#else
        public string? CurrencyCode { get; set; }
#endif

        /// <summary>
        /// The total value of this invoice, inclusive of all taxes and line items.
        /// </summary>
        public double? TotalAmount { get; set; }

        /// <summary>
        /// The total sales (or transactional) tax calculated for this invoice.
        /// </summary>
        public double? SalesTaxAmount { get; set; }

        /// <summary>
        /// The total discounts given by the seller to the buyer on this invoice.
        /// </summary>
        public double? DiscountAmount { get; set; }

        /// <summary>
        /// The remaining balance value of this invoice.
        /// </summary>
        public double? OutstandingBalanceAmount { get; set; }

        /// <summary>
        /// The reporting date for this invoice.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime InvoiceDate { get; set; }
#else
        public DateTime? InvoiceDate { get; set; }
#endif

        /// <summary>
        /// The date when discounts were adjusted for this invoice.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime DiscountDate { get; set; }
#else
        public DateTime? DiscountDate { get; set; }
#endif

        /// <summary>
        /// The date when this invoice posted to the company&#39;s general ledger.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime PostedDate { get; set; }
#else
        public DateTime? PostedDate { get; set; }
#endif

        /// <summary>
        /// The date when the invoice was closed and finalized after completion of all payments and delivery of all products and
        /// services.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime InvoiceClosedDate { get; set; }
#else
        public DateTime? InvoiceClosedDate { get; set; }
#endif

        /// <summary>
        /// The date when the remaining outstanding balance is due.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime PaymentDueDate { get; set; }
#else
        public DateTime? PaymentDueDate { get; set; }
#endif

        /// <summary>
        /// The date and time when this record was imported from the user&#39;s ERP or accounting system.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime ImportedDate { get; set; }
#else
        public DateTime? ImportedDate { get; set; }
#endif

        /// <summary>
        /// The ID number of the invoice&#39;s origination address
        /// </summary>
#if DOT_NET_FRAMEWORK
        public Guid PrimaryOriginAddressId { get; set; }
#else
        public Guid? PrimaryOriginAddressId { get; set; }
#endif

        /// <summary>
        /// The ID number of the invoice&#39;s bill-to address
        /// </summary>
#if DOT_NET_FRAMEWORK
        public Guid PrimaryBillToAddressId { get; set; }
#else
        public Guid? PrimaryBillToAddressId { get; set; }
#endif

        /// <summary>
        /// The ID number of the invoice&#39;s ship-to address
        /// </summary>
#if DOT_NET_FRAMEWORK
        public Guid PrimaryShipToAddressId { get; set; }
#else
        public Guid? PrimaryShipToAddressId { get; set; }
#endif

        /// <summary>
        /// The date on which this invoice record was created.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime Created { get; set; }
#else
        public DateTime? Created { get; set; }
#endif

        /// <summary>
        /// The ID number of the user who created this invoice.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public Guid CreatedUserId { get; set; }
#else
        public Guid? CreatedUserId { get; set; }
#endif

        /// <summary>
        /// The date on which this invoice record was last modified.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime Modified { get; set; }
#else
        public DateTime? Modified { get; set; }
#endif

        /// <summary>
        /// The ID number of the user who most recently modified this invoice.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public Guid ModifiedUserId { get; set; }
#else
        public Guid? ModifiedUserId { get; set; }
#endif

        /// <summary>
        /// The AppEnrollmentId of the application that imported this record.  For accounts
        /// with more than one financial system connected, this field identifies the originating
        /// financial system that produced this record.  This value is null if this record
        /// was not loaded from an external ERP or financial system.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public Guid AppEnrollmentId { get; set; }
#else
        public Guid? AppEnrollmentId { get; set; }
#endif
    }

    /// <summary>
    /// Represents a line in an invoice
    /// </summary>
    public class InvoiceLineModel
    {

        /// <summary>
        /// The unique ID of this record, automatically assigned by Lockstep when this record is
        /// added to the Lockstep platform.
        ///
        /// For the ID of this record in its originating financial system, see `ErpKey`.
        /// </summary>
        public Guid InvoiceLineId { get; set; }

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid GroupKey { get; set; }

        /// <summary>
        /// The ID number of the invoice this line belongs to.
        /// </summary>
        public Guid InvoiceId { get; set; }

        /// <summary>
        /// The unique ID of this record as it was known in its originating financial system, if it was
        /// different from the original `LineNumber`.
        ///
        /// If this company record was imported from a financial system, it will have the value `ErpKey`
        /// set to the original primary key number of the record as it was known in the originating financial
        /// system.  If this record was not imported, this value will be `null`.
        ///
        /// For more information, see [Identity Columns](https://developer.lockstep.io/docs/identity-columns).
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string ErpKey { get; set; }
#else
        public string? ErpKey { get; set; }
#endif

        /// <summary>
        /// The line number of this line, as defined in the originating ERP or accounting system.  You can sort on this number to
        /// get the original view of lines within the invoice.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string LineNumber { get; set; }
#else
        public string? LineNumber { get; set; }
#endif

        /// <summary>
        /// A code number identifying the product or service that is specified on this line.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string ProductCode { get; set; }
#else
        public string? ProductCode { get; set; }
#endif

        /// <summary>
        /// Description of this invoice line.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Description { get; set; }
#else
        public string? Description { get; set; }
#endif

        /// <summary>
        /// For lines measured in a unit other than &quot;quantity&quot;, this code indicates the measurement system for the quantity field.
        /// If the line is measured in quantity, this field is null.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string UnitMeasureCode { get; set; }
#else
        public string? UnitMeasureCode { get; set; }
#endif

        /// <summary>
        /// The price of a single unit for this line.
        /// </summary>
        public double UnitPrice { get; set; }

        /// <summary>
        /// The quantity of items for ths line.
        /// </summary>
        public double? Quantity { get; set; }

        /// <summary>
        /// The number of items that have been shipped.
        /// </summary>
        public double? QuantityShipped { get; set; }

        /// <summary>
        /// The number of items that has been received.
        /// </summary>
        public double? QuantityReceived { get; set; }

        /// <summary>
        /// The total amount for this line.
        /// </summary>
        public double? TotalAmount { get; set; }

        /// <summary>
        /// If this line is tax exempt, this code indicates the reason for the exemption.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string ExemptionCode { get; set; }
#else
        public string? ExemptionCode { get; set; }
#endif

        /// <summary>
        /// If null, the products specified on this line were delivered on the same date as all other lines.
        /// If not null, this line was delivered or finalized on a different date than the overall invoice.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime ReportingDate { get; set; }
#else
        public DateTime? ReportingDate { get; set; }
#endif

        /// <summary>
        /// An optional ID number for the line&#39;s origin address.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public Guid OverrideOriginAddressId { get; set; }
#else
        public Guid? OverrideOriginAddressId { get; set; }
#endif

        /// <summary>
        /// An optional ID number for the line&#39;s bill to address.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public Guid OverrideBillToAddressId { get; set; }
#else
        public Guid? OverrideBillToAddressId { get; set; }
#endif

        /// <summary>
        /// An optional ID number for the line&#39;s ship to address.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public Guid OverrideShipToAddressId { get; set; }
#else
        public Guid? OverrideShipToAddressId { get; set; }
#endif

        /// <summary>
        /// The date on which this line was created.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime Created { get; set; }
#else
        public DateTime? Created { get; set; }
#endif

        /// <summary>
        /// The ID number of the user who created this line.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public Guid CreatedUserId { get; set; }
#else
        public Guid? CreatedUserId { get; set; }
#endif

        /// <summary>
        /// The date on which this line was last modified.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime Modified { get; set; }
#else
        public DateTime? Modified { get; set; }
#endif

        /// <summary>
        /// The ID number of the user who most recently modified this line.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public Guid ModifiedUserId { get; set; }
#else
        public Guid? ModifiedUserId { get; set; }
#endif

        /// <summary>
        /// The AppEnrollmentId of the application that imported this record.  For accounts
        /// with more than one financial system connected, this field identifies the originating
        /// financial system that produced this record.  This value is null if this record
        /// was not loaded from an external ERP or financial system.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public Guid AppEnrollmentId { get; set; }
#else
        public Guid? AppEnrollmentId { get; set; }
#endif

        /// <summary>
        /// A collection of notes linked to this record.  To retrieve this collection, specify `Notes` in the
        /// `include` parameter when retrieving data.
        ///
        /// To create a note, use the [Create Note](https://developer.lockstep.io/reference/post_api-v1-notes)
        /// endpoint with the `TableKey` to `InvoiceLine` and the `ObjectKey` set to the `InvoiceLineId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
#if DOT_NET_FRAMEWORK
        public NoteModel[] Notes { get; set; }
#else
        public NoteModel[]? Notes { get; set; }
#endif

        /// <summary>
        /// A collection of attachments linked to this record.  To retrieve this collection, specify `Attachments` in
        /// the `include` parameter when retrieving data.
        ///
        /// To create an attachment, use the [Upload Attachment](https://developer.lockstep.io/reference/post_api-v1-attachments)
        /// endpoint with the `TableKey` to `InvoiceLine` and the `ObjectKey` set to the `InvoiceLineId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
#if DOT_NET_FRAMEWORK
        public AttachmentModel[] Attachments { get; set; }
#else
        public AttachmentModel[]? Attachments { get; set; }
#endif
    }

    /// <summary>
    /// The InvoiceLineSyncModel represents information coming into Lockstep from an external financial system or other
    /// enterprise resource planning system.  To import data from an external system, convert your original data into
    /// the InvoiceLineSyncModel format and call the [Upload Sync File API](https://developer.lockstep.io/reference/post_api-v1-sync-zip).
    /// This API retrieves all of the data you uploaded in a compressed ZIP file and imports it into the Lockstep
    /// platform.
    ///
    /// Once imported, this record will be available in the Lockstep API as an [InvoiceLineModel](https://developer.lockstep.io/docs/invoicelinemodel).
    ///
    /// For more information on writing your own connector, see [Connector Data](https://developer.lockstep.io/docs/connector-data).
    /// </summary>
    public class InvoiceLineSyncModel
    {

        /// <summary>
        /// This is the primary key of the Invoice Line record. For this field, you should use whatever the contact&#39;s unique
        /// identifying number is in the originating system. Search for a unique, non-changing number within the
        /// originating financial system for this record.
        ///
        /// Example: If you store your invoice line records in a database, whatever the primary key for the invoice
        /// line table is in the database should be the &quot;ErpKey&quot;.
        ///
        /// For more information, see [Identity Columns](https://developer.lockstep.io/docs/identity-columns).
        /// </summary>
        public string ErpKey { get; set; }

        /// <summary>
        /// The original primary key or unique ID of the invoice to which this line belongs.  This value should
        /// match the [Invoice ErpKey](https://developer.lockstep.io/docs/importing-invoices#erpkey) field on the
        /// [InvoiceSyncModel](https://developer.lockstep.io/docs/importing-invoices).
        /// </summary>
        public string InvoiceErpKey { get; set; }

        /// <summary>
        /// The line number of this line, as defined in the originating ERP or accounting system.  You can sort on this number to
        /// get the original view of lines within the invoice.
        /// </summary>
        public string LineNumber { get; set; }

        /// <summary>
        /// A code number identifying the product or service that is specified on this line.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string ProductCode { get; set; }
#else
        public string? ProductCode { get; set; }
#endif

        /// <summary>
        /// Description of this invoice line.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Description { get; set; }
#else
        public string? Description { get; set; }
#endif

        /// <summary>
        /// For lines measured in a unit other than &quot;quantity&quot;, this code indicates the measurement system for the quantity field.
        /// If the line is measured in quantity, this field is null.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string UnitMeasureCode { get; set; }
#else
        public string? UnitMeasureCode { get; set; }
#endif

        /// <summary>
        /// The price of a single unit for this line.
        /// </summary>
        public double? UnitPrice { get; set; }

        /// <summary>
        /// The quantity of items for ths line.
        /// </summary>
        public double? Quantity { get; set; }

        /// <summary>
        /// The number of items that have been shipped.
        /// </summary>
        public double? QuantityShipped { get; set; }

        /// <summary>
        /// The number of items that has been received.
        /// </summary>
        public double? QuantityReceived { get; set; }

        /// <summary>
        /// The total amount for this line.
        /// </summary>
        public double? TotalAmount { get; set; }

        /// <summary>
        /// If this line is tax exempt, this code indicates the reason for the exemption.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string ExemptionCode { get; set; }
#else
        public string? ExemptionCode { get; set; }
#endif

        /// <summary>
        /// If null, the products specified on this line were delivered on the same date as all other lines.
        /// If not null, this line was delivered or finalized on a different date than the overall invoice.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime ReportingDate { get; set; }
#else
        public DateTime? ReportingDate { get; set; }
#endif

        /// <summary>
        /// Origination address for this invoice line, if this line item was originated from a different address
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string OriginAddressLine1 { get; set; }
#else
        public string? OriginAddressLine1 { get; set; }
#endif

        /// <summary>
        /// Origination address for this invoice line, if this line item was originated from a different address
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string OriginAddressLine2 { get; set; }
#else
        public string? OriginAddressLine2 { get; set; }
#endif

        /// <summary>
        /// Origination address for this invoice line, if this line item was originated from a different address
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string OriginAddressLine3 { get; set; }
#else
        public string? OriginAddressLine3 { get; set; }
#endif

        /// <summary>
        /// Origination address for this invoice line, if this line item was originated from a different address
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string OriginAddressCity { get; set; }
#else
        public string? OriginAddressCity { get; set; }
#endif

        /// <summary>
        /// Origination address for this invoice line, if this line item was originated from a different address
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string OriginAddressRegion { get; set; }
#else
        public string? OriginAddressRegion { get; set; }
#endif

        /// <summary>
        /// Origination address for this invoice line, if this line item was originated from a different address
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string OriginAddressPostalCode { get; set; }
#else
        public string? OriginAddressPostalCode { get; set; }
#endif

        /// <summary>
        /// Origination address for this invoice line, if this line item was originated from a different address This will be validated by the /api/v1/countries data set
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string OriginAddressCountry { get; set; }
#else
        public string? OriginAddressCountry { get; set; }
#endif

        /// <summary>
        /// Origination address for this invoice line, if this line item was originated from a different address
        /// </summary>
        public float? OriginAddressLatitude { get; set; }

        /// <summary>
        /// Origination address for this invoice line, if this line item was originated from a different address
        /// </summary>
        public float? OriginAddressLongitude { get; set; }

        /// <summary>
        /// Billing address for this invoice line, if this line item is to be billed to a different address
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string BillToAddressLine1 { get; set; }
#else
        public string? BillToAddressLine1 { get; set; }
#endif

        /// <summary>
        /// Billing address for this invoice line, if this line item is to be billed to a different address
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string BillToAddressLine2 { get; set; }
#else
        public string? BillToAddressLine2 { get; set; }
#endif

        /// <summary>
        /// Billing address for this invoice line, if this line item is to be billed to a different address
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string BillToAddressLine3 { get; set; }
#else
        public string? BillToAddressLine3 { get; set; }
#endif

        /// <summary>
        /// Billing address for this invoice line, if this line item is to be billed to a different address
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string BillToAddressCity { get; set; }
#else
        public string? BillToAddressCity { get; set; }
#endif

        /// <summary>
        /// Billing address for this invoice line, if this line item is to be billed to a different address
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string BillToAddressRegion { get; set; }
#else
        public string? BillToAddressRegion { get; set; }
#endif

        /// <summary>
        /// Billing address for this invoice line, if this line item is to be billed to a different address
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string BillToAddressPostalCode { get; set; }
#else
        public string? BillToAddressPostalCode { get; set; }
#endif

        /// <summary>
        /// Billing address for this invoice line, if this line item is to be billed to a different address This will be validated by the /api/v1/countries data set
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string BillToAddressCountry { get; set; }
#else
        public string? BillToAddressCountry { get; set; }
#endif

        /// <summary>
        /// Billing address for this invoice line, if this line item is to be billed to a different address
        /// </summary>
        public float? BillToAddressLatitude { get; set; }

        /// <summary>
        /// Billing address for this invoice line, if this line item is to be billed to a different address
        /// </summary>
        public float? BillToAddressLongitude { get; set; }

        /// <summary>
        /// Shipping address for this invoice line, if this line item is to be shipped to a different address
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string ShipToAddressLine1 { get; set; }
#else
        public string? ShipToAddressLine1 { get; set; }
#endif

        /// <summary>
        /// Shipping address for this invoice line, if this line item is to be shipped to a different address
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string ShipToAddressLine2 { get; set; }
#else
        public string? ShipToAddressLine2 { get; set; }
#endif

        /// <summary>
        /// Shipping address for this invoice line, if this line item is to be shipped to a different address
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string ShipToAddressLine3 { get; set; }
#else
        public string? ShipToAddressLine3 { get; set; }
#endif

        /// <summary>
        /// Shipping address for this invoice line, if this line item is to be shipped to a different address
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string ShipToAddressCity { get; set; }
#else
        public string? ShipToAddressCity { get; set; }
#endif

        /// <summary>
        /// Shipping address for this invoice line, if this line item is to be shipped to a different address
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string ShipToAddressRegion { get; set; }
#else
        public string? ShipToAddressRegion { get; set; }
#endif

        /// <summary>
        /// Shipping address for this invoice line, if this line item is to be shipped to a different address
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string ShipToAddressPostalCode { get; set; }
#else
        public string? ShipToAddressPostalCode { get; set; }
#endif

        /// <summary>
        /// Shipping address for this invoice line, if this line item is to be shipped to a different address This will be validated by the /api/v1/countries data set
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string ShipToAddressCountry { get; set; }
#else
        public string? ShipToAddressCountry { get; set; }
#endif

        /// <summary>
        /// Shipping address for this invoice line, if this line item is to be shipped to a different address
        /// </summary>
        public float? ShipToAddressLatitude { get; set; }

        /// <summary>
        /// Shipping address for this invoice line, if this line item is to be shipped to a different address
        /// </summary>
        public float? ShipToAddressLongitude { get; set; }

        /// <summary>
        /// If known, the date when this record was created according to the originating financial system
        /// in which this record is maintained.  If the originating financial system does not maintain a
        /// created-date, leave this field null.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime Created { get; set; }
#else
        public DateTime? Created { get; set; }
#endif

        /// <summary>
        /// If known, the date when this record was most recently modified according to the originating
        /// financial system in which this record is maintained.  If the originating financial system does
        /// not maintain a most-recently-modified-date, leave this field null.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime Modified { get; set; }
#else
        public DateTime? Modified { get; set; }
#endif
    }

    /// <summary>
    /// An Invoice represents a bill sent from one company to another.  The creator of the invoice is identified
    /// by the `CompanyId` field, and the recipient of the invoice is identified by the `CustomerId` field.  Most
    /// invoices are uniquely identified both by a Lockstep Platform ID number and a customer ERP &quot;key&quot; that was
    /// generated by the system that originated the invoice.  Invoices have a total amount and a due date, and when
    /// some payments have been made on the Invoice the `TotalAmount` and the `OutstandingBalanceAmount` may be
    /// different.
    /// </summary>
    public class InvoiceModel
    {

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid GroupKey { get; set; }

        /// <summary>
        /// The unique ID of this record, automatically assigned by Lockstep when this record is
        /// added to the Lockstep platform.
        ///
        /// For the ID of this record in its originating financial system, see `ErpKey`.
        /// </summary>
        public Guid InvoiceId { get; set; }

        /// <summary>
        /// The ID number of the company that created this invoice.
        /// </summary>
        public Guid CompanyId { get; set; }

        /// <summary>
        /// The ID number of the counterparty for the invoice, for example, a customer or vendor.
        /// </summary>
        public Guid CustomerId { get; set; }

        /// <summary>
        /// The unique ID of this record as it was known in its originating financial system.
        ///
        /// If this company record was imported from a financial system, it will have the value `ErpKey`
        /// set to the original primary key number of the record as it was known in the originating financial
        /// system.  If this record was not imported, this value will be `null`.
        ///
        /// For more information, see [Identity Columns](https://developer.lockstep.io/docs/identity-columns).
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string ErpKey { get; set; }
#else
        public string? ErpKey { get; set; }
#endif

        /// <summary>
        /// The &quot;Purchase Order Code&quot; is a code that is sometimes used by companies to refer to the original PO
        /// that was sent that caused this invoice to be written.  If a customer sends a purchase order to a vendor,
        /// the vendor can then create an invoice and refer back to the originating purchase order using this field.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string PurchaseOrderCode { get; set; }
#else
        public string? PurchaseOrderCode { get; set; }
#endif

        /// <summary>
        /// An additional reference code that is sometimes used to identify this invoice.
        /// The meaning of this field is specific to the ERP or accounting system used by the user.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string ReferenceCode { get; set; }
#else
        public string? ReferenceCode { get; set; }
#endif

        /// <summary>
        /// A code identifying the salesperson responsible for writing this quote, invoice, or order.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string SalespersonCode { get; set; }
#else
        public string? SalespersonCode { get; set; }
#endif

        /// <summary>
        /// A name identifying the salesperson responsible for writing this quote, invoice, or order.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string SalespersonName { get; set; }
#else
        public string? SalespersonName { get; set; }
#endif

        /// <summary>
        /// A code identifying the type of this invoice.
        ///
        /// Recognized Invoice types are:
        /// * `Invoice` - Represents an invoice sent by Company to the Customer
        /// * `AP Invoice` - Represents an invoice sent by Customer to the Company
        /// * `Credit Memo` - Represents a credit memo generated by Customer given to Company
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string InvoiceTypeCode { get; set; }
#else
        public string? InvoiceTypeCode { get; set; }
#endif

        /// <summary>
        /// A code identifying the status of this invoice.
        ///
        /// Recognized Invoice status codes are:
        /// * `Open` - Represents an invoice that is considered open and needs more work to complete
        /// * `Closed` - Represents an invoice that is considered closed and resolved
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string InvoiceStatusCode { get; set; }
#else
        public string? InvoiceStatusCode { get; set; }
#endif

        /// <summary>
        /// A code identifying the terms given to the purchaser.  This field is imported directly from the originating
        /// financial system and does not follow a specified format.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string TermsCode { get; set; }
#else
        public string? TermsCode { get; set; }
#endif

        /// <summary>
        /// If the customer negotiated any special terms different from the standard terms above, describe them here.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string SpecialTerms { get; set; }
#else
        public string? SpecialTerms { get; set; }
#endif

        /// <summary>
        /// The three-character ISO 4217 currency code used for this invoice.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string CurrencyCode { get; set; }
#else
        public string? CurrencyCode { get; set; }
#endif

        /// <summary>
        /// The total value of this invoice, inclusive of all taxes and line items.
        /// </summary>
        public double? TotalAmount { get; set; }

        /// <summary>
        /// The total sales (or transactional) tax calculated for this invoice.
        /// </summary>
        public double? SalesTaxAmount { get; set; }

        /// <summary>
        /// The total discounts given by the seller to the buyer on this invoice.
        /// </summary>
        public double? DiscountAmount { get; set; }

        /// <summary>
        /// The remaining balance value of this invoice.
        /// </summary>
        public double? OutstandingBalanceAmount { get; set; }

        /// <summary>
        /// The reporting date for this invoice.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime InvoiceDate { get; set; }
#else
        public DateTime? InvoiceDate { get; set; }
#endif

        /// <summary>
        /// The date when discounts were adjusted for this invoice.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime DiscountDate { get; set; }
#else
        public DateTime? DiscountDate { get; set; }
#endif

        /// <summary>
        /// The date when this invoice posted to the company&#39;s general ledger.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime PostedDate { get; set; }
#else
        public DateTime? PostedDate { get; set; }
#endif

        /// <summary>
        /// The date when the invoice was closed and finalized after completion of all payments and delivery of all products and
        /// services.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime InvoiceClosedDate { get; set; }
#else
        public DateTime? InvoiceClosedDate { get; set; }
#endif

        /// <summary>
        /// The date when the remaining outstanding balance is due.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime PaymentDueDate { get; set; }
#else
        public DateTime? PaymentDueDate { get; set; }
#endif

        /// <summary>
        /// The date and time when this record was imported from the user&#39;s ERP or accounting system.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime ImportedDate { get; set; }
#else
        public DateTime? ImportedDate { get; set; }
#endif

        /// <summary>
        /// The ID number of the invoice&#39;s origination address
        /// </summary>
#if DOT_NET_FRAMEWORK
        public Guid PrimaryOriginAddressId { get; set; }
#else
        public Guid? PrimaryOriginAddressId { get; set; }
#endif

        /// <summary>
        /// The ID number of the invoice&#39;s bill-to address
        /// </summary>
#if DOT_NET_FRAMEWORK
        public Guid PrimaryBillToAddressId { get; set; }
#else
        public Guid? PrimaryBillToAddressId { get; set; }
#endif

        /// <summary>
        /// The ID number of the invoice&#39;s ship-to address
        /// </summary>
#if DOT_NET_FRAMEWORK
        public Guid PrimaryShipToAddressId { get; set; }
#else
        public Guid? PrimaryShipToAddressId { get; set; }
#endif

        /// <summary>
        /// The date on which this invoice record was created.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime Created { get; set; }
#else
        public DateTime? Created { get; set; }
#endif

        /// <summary>
        /// The ID number of the user who created this invoice.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public Guid CreatedUserId { get; set; }
#else
        public Guid? CreatedUserId { get; set; }
#endif

        /// <summary>
        /// The date on which this invoice record was last modified.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime Modified { get; set; }
#else
        public DateTime? Modified { get; set; }
#endif

        /// <summary>
        /// The ID number of the user who most recently modified this invoice.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public Guid ModifiedUserId { get; set; }
#else
        public Guid? ModifiedUserId { get; set; }
#endif

        /// <summary>
        /// The AppEnrollmentId of the application that imported this record.  For accounts
        /// with more than one financial system connected, this field identifies the originating
        /// financial system that produced this record.  This value is null if this record
        /// was not loaded from an external ERP or financial system.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public Guid AppEnrollmentId { get; set; }
#else
        public Guid? AppEnrollmentId { get; set; }
#endif

        /// <summary>
        /// Is the invoice voided?
        /// </summary>
        public bool IsVoided { get; set; }

        /// <summary>
        /// Is the invoice in dispute?
        /// </summary>
        public bool InDispute { get; set; }

        /// <summary>
        /// Should the invoice be excluded from aging calculations?
        /// </summary>
        public bool ExcludeFromAging { get; set; }

        /// <summary>
        /// All addresses connected to this invoice.
        /// To retrieve this collection, specify `Addresses` in the &quot;Include&quot; parameter for your query.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public InvoiceAddressModel[] Addresses { get; set; }
#else
        public InvoiceAddressModel[]? Addresses { get; set; }
#endif

        /// <summary>
        /// All lines attached to this invoice.
        /// To retrieve this collection, specify `Lines` in the &quot;Include&quot; parameter for your query.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public InvoiceLineModel[] Lines { get; set; }
#else
        public InvoiceLineModel[]? Lines { get; set; }
#endif

        /// <summary>
        /// All payments attached to this invoice, the amount of the payment applied to this Invoice, and the date the Payment was applied.
        /// To retrieve this collection, specify `Payments` in the &quot;Include&quot; parameter for your query.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public InvoicePaymentDetailModel[] Payments { get; set; }
#else
        public InvoicePaymentDetailModel[]? Payments { get; set; }
#endif

        /// <summary>
        /// A collection of notes linked to this record.  To retrieve this collection, specify `Notes` in the
        /// `include` parameter when retrieving data.
        ///
        /// To create a note, use the [Create Note](https://developer.lockstep.io/reference/post_api-v1-notes)
        /// endpoint with the `TableKey` to `Invoice` and the `ObjectKey` set to the `InvoiceId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
#if DOT_NET_FRAMEWORK
        public NoteModel[] Notes { get; set; }
#else
        public NoteModel[]? Notes { get; set; }
#endif

        /// <summary>
        /// A collection of attachments linked to this record.  To retrieve this collection, specify `Attachments` in
        /// the `include` parameter when retrieving data.
        ///
        /// To create an attachment, use the [Upload Attachment](https://developer.lockstep.io/reference/post_api-v1-attachments)
        /// endpoint with the `TableKey` to `Invoice` and the `ObjectKey` set to the `InvoiceId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
#if DOT_NET_FRAMEWORK
        public AttachmentModel[] Attachments { get; set; }
#else
        public AttachmentModel[]? Attachments { get; set; }
#endif

        /// <summary>
        /// The Company associated to this invoice.
        /// To retrieve this item, specify `Company` in the &quot;Include&quot; parameter for your query.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public CompanyModel Company { get; set; }
#else
        public CompanyModel? Company { get; set; }
#endif

        /// <summary>
        /// The Customer associated to the invoice customer
        /// To retrieve this item, specify `Customer` in the &quot;Include&quot; parameter for your query.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public CompanyModel Customer { get; set; }
#else
        public CompanyModel? Customer { get; set; }
#endif

        /// <summary>
        /// The Contact associated to the invoice customer
        /// To retrieve this item, specify `Customer` in the &quot;Include&quot; parameter for your query.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public ContactModel CustomerPrimaryContact { get; set; }
#else
        public ContactModel? CustomerPrimaryContact { get; set; }
#endif

        /// <summary>
        /// The credit memos associated to this invoice.
        /// To retrieve this item, specify `CreditMemos` in the &quot;Include&quot; parameter for your query.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public CreditMemoInvoiceModel[] CreditMemos { get; set; }
#else
        public CreditMemoInvoiceModel[]? CreditMemos { get; set; }
#endif

        /// <summary>
        /// A collection of custom fields linked to this record.  To retrieve this collection, specify
        /// `CustomFieldValues` in the `include` parameter when retrieving data.
        ///
        /// To create a custom field, use the [Create Custom Field](https://developer.lockstep.io/reference/post_api-v1-customfieldvalues)
        /// endpoint with the `TableKey` to `Invoice` and the `ObjectKey` set to the `InvoiceId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
#if DOT_NET_FRAMEWORK
        public CustomFieldValueModel[] CustomFieldValues { get; set; }
#else
        public CustomFieldValueModel[]? CustomFieldValues { get; set; }
#endif

        /// <summary>
        /// A collection of custom fields linked to this record.  To retrieve this collection, specify
        /// `CustomFieldDefinitions` in the `include` parameter when retrieving data.
        ///
        /// To create a custom field, use the [Create Custom Field](https://developer.lockstep.io/reference/post_api-v1-customfieldvalues)
        /// endpoint with the `TableKey` to `Invoice` and the `ObjectKey` set to the `InvoiceId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
#if DOT_NET_FRAMEWORK
        public CustomFieldDefinitionModel[] CustomFieldDefinitions { get; set; }
#else
        public CustomFieldDefinitionModel[]? CustomFieldDefinitions { get; set; }
#endif
    }

    /// <summary>
    /// View to return Payment Detail information for a given Invoice record.
    /// </summary>
    public class InvoicePaymentDetailModel
    {

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid GroupKey { get; set; }

        /// <summary>
        /// The unique identifier of this PaymentApplied record.
        /// </summary>
        public Guid PaymentAppliedId { get; set; }

        /// <summary>
        /// The database id of the invoice
        /// </summary>
        public Guid InvoiceId { get; set; }

        /// <summary>
        /// The database id of the Payment.
        /// </summary>
        public Guid PaymentId { get; set; }

        /// <summary>
        /// Date Payment applied to Invoice.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime ApplyToInvoiceDate { get; set; }
#else
        public DateTime? ApplyToInvoiceDate { get; set; }
#endif

        /// <summary>
        /// Amount applied to Invoice.
        /// </summary>
        public double PaymentAppliedAmount { get; set; }

        /// <summary>
        /// An additional reference code that is sometimes used to identify this Payment.
        /// The meaning of this field is specific to the ERP or accounting system used by the user.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string ReferenceCode { get; set; }
#else
        public string? ReferenceCode { get; set; }
#endif

        /// <summary>
        /// The ID number of the Company (CompanyType = &quot;Customer&quot;) that created this Payment.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public Guid CompanyId { get; set; }
#else
        public Guid? CompanyId { get; set; }
#endif

        /// <summary>
        /// The total value of this Payment.
        /// </summary>
        public double? PaymentAmount { get; set; }

        /// <summary>
        /// The remaining balance value of this Payment.
        /// </summary>
        public double? UnappliedAmount { get; set; }
    }

    /// <summary>
    /// Contains summarized data for an invoice
    /// </summary>
    public class InvoiceSummaryModel
    {

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid GroupKey { get; set; }

        /// <summary>
        /// The ID number of the counterparty for the invoice, for example, a customer or vendor.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public Guid CustomerId { get; set; }
#else
        public Guid? CustomerId { get; set; }
#endif

        /// <summary>
        /// The unique ID number of this invoice.
        /// </summary>
        public Guid InvoiceId { get; set; }

        /// <summary>
        /// A reference code that is used to identify this invoice.
        /// The meaning of this field is specific to the ERP or accounting system used by the user.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string InvoiceNumber { get; set; }
#else
        public string? InvoiceNumber { get; set; }
#endif

        /// <summary>
        /// The reporting date for this invoice.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime InvoiceDate { get; set; }
#else
        public DateTime? InvoiceDate { get; set; }
#endif

        /// <summary>
        /// The name of the counterparty for the invoice, for example, a customer or vendor.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string CustomerName { get; set; }
#else
        public string? CustomerName { get; set; }
#endif

        /// <summary>
        /// The status of the invoice.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Status { get; set; }
#else
        public string? Status { get; set; }
#endif

        /// <summary>
        /// The due date of the invoice.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime PaymentDueDate { get; set; }
#else
        public DateTime? PaymentDueDate { get; set; }
#endif

        /// <summary>
        /// The total amount of the Invoice.
        /// </summary>
        public double? InvoiceAmount { get; set; }

        /// <summary>
        /// The remaining balance value of this invoice.
        /// </summary>
        public double? OutstandingBalance { get; set; }

        /// <summary>
        /// A code identifying the type of this Invoice.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string InvoiceTypeCode { get; set; }
#else
        public string? InvoiceTypeCode { get; set; }
#endif

        /// <summary>
        /// The date stamp for the newest Activity on this Invoice.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime NewestActivity { get; set; }
#else
        public DateTime? NewestActivity { get; set; }
#endif

        /// <summary>
        /// The number of days this Invoice is past due.
        /// </summary>
        public int? DaysPastDue { get; set; }

        /// <summary>
        /// The memo text of the payments associated to this invoice.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string[] PaymentNumbers { get; set; }
#else
        public string[]? PaymentNumbers { get; set; }
#endif

        /// <summary>
        /// The ids of the payments associated to this invoice.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public Guid[] PaymentIds { get; set; }
#else
        public Guid[]? PaymentIds { get; set; }
#endif
    }

    /// <summary>
    /// The InvoiceSyncModel represents information coming into Lockstep from an external financial system or other
    /// enterprise resource planning system.  To import data from an external system, convert your original data into
    /// the InvoiceSyncModel format and call the [Upload Sync File API](https://developer.lockstep.io/reference/post_api-v1-sync-zip).
    /// This API retrieves all of the data you uploaded in a compressed ZIP file and imports it into the Lockstep
    /// platform.
    ///
    /// Once imported, this record will be available in the Lockstep API as an [InvoiceModel](https://developer.lockstep.io/docs/invoicemodel).
    ///
    /// For more information on writing your own connector, see [Connector Data](https://developer.lockstep.io/docs/connector-data).
    /// </summary>
    public class InvoiceSyncModel
    {

        /// <summary>
        /// This is the primary key of the Invoice record. For this field, you should use whatever the invoice&#39;s unique
        /// identifying number is in the originating system. Search for a unique, non-changing number within the
        /// originating financial system for this record.
        ///
        /// Example: If you store your invoice records in a database, whatever the primary key for the invoice table is
        /// in the database should be the &quot;ErpKey&quot;.
        ///
        /// For more information, see [Identity Columns](https://developer.lockstep.io/docs/identity-columns).
        /// </summary>
        public string ErpKey { get; set; }

        /// <summary>
        /// The original primary key or unique ID of the company to which this invoice belongs.  This value should
        /// match the [Company ErpKey](https://developer.lockstep.io/docs/importing-companies#erpkey) field on the
        /// [CompanySyncModel](https://developer.lockstep.io/docs/importing-companies).
        ///
        /// An Invoice has two relationships: The Company and the Customer.  The field `CompanyErpKey` identifies the
        /// company that created the invoice, and the field `CustomerErpKey` is the customer to whom the invoice
        /// was sent.
        /// </summary>
        public string CompanyErpKey { get; set; }

        /// <summary>
        /// The original primary key or unique ID of the company to which this invoice was sent.  This value should
        /// match the [Company ErpKey](https://developer.lockstep.io/docs/importing-companies#erpkey) field on the
        /// [CompanySyncModel](https://developer.lockstep.io/docs/importing-companies).
        ///
        /// An Invoice has two relationships: The Company and the Customer.  The field `CompanyErpKey` identifies the
        /// company that created the invoice, and the field `CustomerErpKey` is the customer to whom the invoice
        /// was sent.
        /// </summary>
        public string CustomerErpKey { get; set; }

        /// <summary>
        /// The name of the salesperson that wrote this invoice.  This is just text, it is not a reference to the
        /// &quot;Contacts&quot; table.  You will not receive an error if this field does not match a known contact person.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string SalespersonName { get; set; }
#else
        public string? SalespersonName { get; set; }
#endif

        /// <summary>
        /// The &quot;Purchase Order Code&quot; is a code that is sometimes used by companies to refer to the original PO
        /// that was sent that caused this invoice to be written.  If a customer sends a purchase order to a vendor,
        /// the vendor can then create an invoice and refer back to the originating purchase order using this field.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string PurchaseOrderCode { get; set; }
#else
        public string? PurchaseOrderCode { get; set; }
#endif

        /// <summary>
        /// An additional reference code that is sometimes used to identify this invoice. The meaning of this field
        /// is specific to the ERP or accounting system used by the user.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string ReferenceCode { get; set; }
#else
        public string? ReferenceCode { get; set; }
#endif

        /// <summary>
        /// A code identifying the salesperson responsible for writing this quote, invoice, or order.  This is just
        /// text, it is not a reference to the &quot;Contacts&quot; table.  You will not receive an error if this field does
        /// not match a known contact person.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string SalespersonCode { get; set; }
#else
        public string? SalespersonCode { get; set; }
#endif

        /// <summary>
        /// A code identifying the type of this invoice.
        ///
        /// Recognized Invoice types are:
        /// * `Invoice` - Represents an invoice sent by Company to the Customer
        /// * `AP Invoice` - Represents an invoice sent by Customer to the Company
        /// * `Credit Memo` - Represents a credit memo generated by Customer given to Company
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string InvoiceTypeCode { get; set; }
#else
        public string? InvoiceTypeCode { get; set; }
#endif

        /// <summary>
        /// A code identifying the status of this invoice.
        ///
        /// Recognized Invoice status codes are:
        /// * `Open` - Represents an invoice that is considered open and needs more work to complete
        /// * `Closed` - Represents an invoice that is considered closed and resolved
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string InvoiceStatusCode { get; set; }
#else
        public string? InvoiceStatusCode { get; set; }
#endif

        /// <summary>
        /// A code identifying the terms given to the purchaser.  This field is imported directly from the originating
        /// financial system and does not follow a specified format.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string TermsCode { get; set; }
#else
        public string? TermsCode { get; set; }
#endif

        /// <summary>
        /// If the customer negotiated any special terms different from the standard terms above, describe them here.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string SpecialTerms { get; set; }
#else
        public string? SpecialTerms { get; set; }
#endif

        /// <summary>
        /// The three-character ISO 4217 currency code used for this invoice. This will be validated by the /api/v1/currencies data set
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string CurrencyCode { get; set; }
#else
        public string? CurrencyCode { get; set; }
#endif

        /// <summary>
        /// The total value of this invoice, inclusive of all taxes and line items.
        /// </summary>
        public double? TotalAmount { get; set; }

        /// <summary>
        /// The total sales (or transactional) tax calculated for this invoice.
        /// </summary>
        public double? SalesTaxAmount { get; set; }

        /// <summary>
        /// The total discounts given by the seller to the buyer on this invoice.
        /// </summary>
        public double? DiscountAmount { get; set; }

        /// <summary>
        /// The remaining balance value of this invoice.
        /// </summary>
        public double? OutstandingBalanceAmount { get; set; }

        /// <summary>
        /// The reporting date for this invoice.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime InvoiceDate { get; set; }
#else
        public DateTime? InvoiceDate { get; set; }
#endif

        /// <summary>
        /// The date when discounts were adjusted for this invoice.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime DiscountDate { get; set; }
#else
        public DateTime? DiscountDate { get; set; }
#endif

        /// <summary>
        /// The date when this invoice posted to the company&#39;s general ledger.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime PostedDate { get; set; }
#else
        public DateTime? PostedDate { get; set; }
#endif

        /// <summary>
        /// The date when the invoice was closed and finalized after completion of all payments and delivery of all products and
        /// services.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime InvoiceClosedDate { get; set; }
#else
        public DateTime? InvoiceClosedDate { get; set; }
#endif

        /// <summary>
        /// The date when the remaining outstanding balance is due.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime PaymentDueDate { get; set; }
#else
        public DateTime? PaymentDueDate { get; set; }
#endif

        /// <summary>
        /// The date and time when this record was imported from the user&#39;s ERP or accounting system.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime ImportedDate { get; set; }
#else
        public DateTime? ImportedDate { get; set; }
#endif

        /// <summary>
        /// The origination address for this invoice
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string OriginAddressLine1 { get; set; }
#else
        public string? OriginAddressLine1 { get; set; }
#endif

        /// <summary>
        /// The origination address for this invoice
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string OriginAddressLine2 { get; set; }
#else
        public string? OriginAddressLine2 { get; set; }
#endif

        /// <summary>
        /// The origination address for this invoice
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string OriginAddressLine3 { get; set; }
#else
        public string? OriginAddressLine3 { get; set; }
#endif

        /// <summary>
        /// The origination address for this invoice
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string OriginAddressCity { get; set; }
#else
        public string? OriginAddressCity { get; set; }
#endif

        /// <summary>
        /// The origination address for this invoice
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string OriginAddressRegion { get; set; }
#else
        public string? OriginAddressRegion { get; set; }
#endif

        /// <summary>
        /// The origination address for this invoice
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string OriginAddressPostalCode { get; set; }
#else
        public string? OriginAddressPostalCode { get; set; }
#endif

        /// <summary>
        /// The origination address for this invoice This will be validated by the /api/v1/countries data set
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string OriginAddressCountry { get; set; }
#else
        public string? OriginAddressCountry { get; set; }
#endif

        /// <summary>
        /// The origination address for this invoice
        /// </summary>
        public float? OriginAddressLatitude { get; set; }

        /// <summary>
        /// The origination address for this invoice
        /// </summary>
        public float? OriginAddressLongitude { get; set; }

        /// <summary>
        /// The billing address for this invoice
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string BillToAddressLine1 { get; set; }
#else
        public string? BillToAddressLine1 { get; set; }
#endif

        /// <summary>
        /// The billing address for this invoice
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string BillToAddressLine2 { get; set; }
#else
        public string? BillToAddressLine2 { get; set; }
#endif

        /// <summary>
        /// The billing address for this invoice
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string BillToAddressLine3 { get; set; }
#else
        public string? BillToAddressLine3 { get; set; }
#endif

        /// <summary>
        /// The billing address for this invoice
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string BillToAddressCity { get; set; }
#else
        public string? BillToAddressCity { get; set; }
#endif

        /// <summary>
        /// The billing address for this invoice
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string BillToAddressRegion { get; set; }
#else
        public string? BillToAddressRegion { get; set; }
#endif

        /// <summary>
        /// The billing address for this invoice
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string BillToAddressPostalCode { get; set; }
#else
        public string? BillToAddressPostalCode { get; set; }
#endif

        /// <summary>
        /// The billing address for this invoice This will be validated by the /api/v1/countries data set
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string BillToAddressCountry { get; set; }
#else
        public string? BillToAddressCountry { get; set; }
#endif

        /// <summary>
        /// The billing address for this invoice
        /// </summary>
        public float? BillToAddressLatitude { get; set; }

        /// <summary>
        /// The billing address for this invoice
        /// </summary>
        public float? BillToAddressLongitude { get; set; }

        /// <summary>
        /// The shipping address for this invoice
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string ShipToAddressLine1 { get; set; }
#else
        public string? ShipToAddressLine1 { get; set; }
#endif

        /// <summary>
        /// The shipping address for this invoice
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string ShipToAddressLine2 { get; set; }
#else
        public string? ShipToAddressLine2 { get; set; }
#endif

        /// <summary>
        /// The shipping address for this invoice
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string ShipToAddressLine3 { get; set; }
#else
        public string? ShipToAddressLine3 { get; set; }
#endif

        /// <summary>
        /// The shipping address for this invoice
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string ShipToAddressCity { get; set; }
#else
        public string? ShipToAddressCity { get; set; }
#endif

        /// <summary>
        /// The shipping address for this invoice
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string ShipToAddressRegion { get; set; }
#else
        public string? ShipToAddressRegion { get; set; }
#endif

        /// <summary>
        /// The shipping address for this invoice
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string ShipToAddressPostalCode { get; set; }
#else
        public string? ShipToAddressPostalCode { get; set; }
#endif

        /// <summary>
        /// The shipping address for this invoice This will be validated by the /api/v1/countries data set
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string ShipToAddressCountry { get; set; }
#else
        public string? ShipToAddressCountry { get; set; }
#endif

        /// <summary>
        /// The shipping address for this invoice
        /// </summary>
        public float? ShipToAddressLatitude { get; set; }

        /// <summary>
        /// The shipping address for this invoice
        /// </summary>
        public float? ShipToAddressLongitude { get; set; }

        /// <summary>
        /// If known, the date when this record was created according to the originating financial system
        /// in which this record is maintained.  If the originating financial system does not maintain a
        /// created-date, leave this field null.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime Created { get; set; }
#else
        public DateTime? Created { get; set; }
#endif

        /// <summary>
        /// If known, the date when this record was most recently modified according to the originating
        /// financial system in which this record is maintained.  If the originating financial system does
        /// not maintain a most-recently-modified-date, leave this field null.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime Modified { get; set; }
#else
        public DateTime? Modified { get; set; }
#endif

        /// <summary>
        /// Is the invoice voided? If not specified, we assume the invoice is not voided.
        /// </summary>
        public bool? IsVoided { get; set; }

        /// <summary>
        /// Is the invoice in dispute? If not specified, we assume the invoice is not in dispute.
        /// </summary>
        public bool? InDispute { get; set; }
    }

    /// <summary>
    /// Represents leads for creating new ERP connectors
    /// </summary>
    public class LeadModel
    {

        /// <summary>
        /// The unique ID of this record, automatically assigned by Lockstep when this record is
        /// added to the Lockstep platform.
        /// </summary>
        public Guid LeadId { get; set; }

        /// <summary>
        /// Name of lead
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Name { get; set; }
#else
        public string? Name { get; set; }
#endif

        /// <summary>
        /// Name of company of lead
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Company { get; set; }
#else
        public string? Company { get; set; }
#endif

        /// <summary>
        /// Email of lead
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Email { get; set; }
#else
        public string? Email { get; set; }
#endif

        /// <summary>
        /// Requested ERP of lead
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string ErpSystem { get; set; }
#else
        public string? ErpSystem { get; set; }
#endif
    }

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
        public Guid NoteId { get; set; }

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid GroupKey { get; set; }

        /// <summary>
        /// The name of the table the note is associated with
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string TableKey { get; set; }
#else
        public string? TableKey { get; set; }
#endif

        /// <summary>
        /// The ID of the object the note is associated with
        /// </summary>
        public Guid ObjectKey { get; set; }

        /// <summary>
        /// The text of the note
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string NoteText { get; set; }
#else
        public string? NoteText { get; set; }
#endif

        /// <summary>
        /// The type of the note
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string NoteType { get; set; }
#else
        public string? NoteType { get; set; }
#endif

        /// <summary>
        /// Flag indicating if the note has been archived
        /// </summary>
        public bool IsArchived { get; set; }

        /// <summary>
        /// The date the note was created
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime Created { get; set; }
#else
        public DateTime? Created { get; set; }
#endif

        /// <summary>
        /// The ID of the user who created the note
        /// </summary>
        public Guid CreatedUserId { get; set; }

        /// <summary>
        /// The name of the user who created the note
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string CreatedUserName { get; set; }
#else
        public string? CreatedUserName { get; set; }
#endif

        /// <summary>
        /// The AppEnrollmentId of the application that imported this record.  For accounts
        /// with more than one financial system connected, this field identifies the originating
        /// financial system that produced this record.  This value is null if this record
        /// was not loaded from an external ERP or financial system.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public Guid AppEnrollmentId { get; set; }
#else
        public Guid? AppEnrollmentId { get; set; }
#endif

        /// <summary>
        /// The person to whom this note is intended for.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string RecipientName { get; set; }
#else
        public string? RecipientName { get; set; }
#endif
    }

    /// <summary>
    /// A Payment Application is created by a business who receives a Payment from a customer.  A customer may make
    /// a single Payment to match an Invoice exactly, a partial Payment for an Invoice, or a single Payment may be
    /// made for multiple smaller Invoices.  The Payment Application contains information about which Invoices are connected
    /// to which Payments and for which amounts.
    /// </summary>
    public class PaymentAppliedModel
    {

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid GroupKey { get; set; }

        /// <summary>
        /// The unique ID of this record, automatically assigned by Lockstep when this record is
        /// added to the Lockstep platform.
        ///
        /// For the ID of this record in its originating financial system, see `ErpKey`.
        /// </summary>
        public Guid PaymentAppliedId { get; set; }

        /// <summary>
        /// The Invoice this payment is applied to.
        /// </summary>
        public Guid InvoiceId { get; set; }

        /// <summary>
        /// The Payment applied to the invoice.
        /// </summary>
        public Guid PaymentId { get; set; }

        /// <summary>
        /// The unique ID of this record as it was known in its originating financial system.
        ///
        /// If this company record was imported from a financial system, it will have the value `ErpKey`
        /// set to the original primary key number of the record as it was known in the originating financial
        /// system.  If this record was not imported, this value will be `null`.
        ///
        /// For more information, see [Identity Columns](https://developer.lockstep.io/docs/identity-columns).
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string ErpKey { get; set; }
#else
        public string? ErpKey { get; set; }
#endif

        /// <summary>
        /// The entry number of this payment application.  This is often a journal entry number, confirmation code,
        /// or other identifying field for this payment application.
        /// </summary>
        public int EntryNumber { get; set; }

        /// <summary>
        /// The date this payment was applied to this invoice.
        /// </summary>
        public DateTime ApplyToInvoiceDate { get; set; }

        /// <summary>
        /// The total amount that was applied to this Invoice from the Payment.
        /// </summary>
        public double PaymentAppliedAmount { get; set; }

        /// <summary>
        /// Date payment applied record was created.
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// The id of the user who created this applied payment.
        /// </summary>
        public Guid CreatedUserId { get; set; }

        /// <summary>
        /// Date payment applied record was modified.
        /// </summary>
        public DateTime Modified { get; set; }

        /// <summary>
        /// The id of the user who modified this applied payment.
        /// </summary>
        public Guid ModifiedUserId { get; set; }

        /// <summary>
        /// The AppEnrollmentId of the application that imported this record.  For accounts
        /// with more than one financial system connected, this field identifies the originating
        /// financial system that produced this record.  This value is null if this record
        /// was not loaded from an external ERP or financial system.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public Guid AppEnrollmentId { get; set; }
#else
        public Guid? AppEnrollmentId { get; set; }
#endif

        /// <summary>
        /// The invoice associated with this applied payment.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public InvoiceModel Invoice { get; set; }
#else
        public InvoiceModel? Invoice { get; set; }
#endif
    }

    /// <summary>
    /// The PaymentAppliedSyncModel represents information coming into Lockstep from an external financial system or
    /// other enterprise resource planning system.  To import data from an external system, convert your original data
    /// into the PaymentAppliedSyncModel format and call the [Upload Sync File API](https://developer.lockstep.io/reference/post_api-v1-sync-zip).
    /// This API retrieves all of the data you uploaded in a compressed ZIP file and imports it into the Lockstep
    /// platform.
    ///
    /// Once imported, this record will be available in the Lockstep API as a [PaymentAppliedModel](https://developer.lockstep.io/docs/paymentappliedmodel).
    ///
    /// For more information on writing your own connector, see [Connector Data](https://developer.lockstep.io/docs/connector-data).
    /// </summary>
    public class PaymentAppliedSyncModel
    {

        /// <summary>
        /// This is the primary key of the Payment Application record. For this field, you should use whatever this
        /// transaction&#39;s unique identifying number is in the originating system. Search for a unique, non-changing
        /// number within the originating financial system for this record.
        ///
        /// Since Payment Applications are often considered transactions, a typical value to look for will be
        /// the transaction ID number, the payment confirmation number, or some other record of this payment.
        ///
        /// For more information, see [Identity Columns](https://developer.lockstep.io/docs/identity-columns).
        /// </summary>
        public string ErpKey { get; set; }

        /// <summary>
        /// This field indicates which Invoice had its balance reduced by applying this payment.  In this field,
        /// identify the original primary key or unique ID of the Invoice which had its balance reduced.
        ///
        /// This information lets you track how an invoice was paid. You can identify what proportion of an invoice&#39;s
        /// balance was paid by which methods by joining this field to Invoices.
        ///
        /// This value should match the [Invoice ErpKey](https://developer.lockstep.io/docs/importing-invoices#erpkey)
        /// field on the [InvoiceSyncModel](https://developer.lockstep.io/docs/importing-invoices).
        /// </summary>
        public string InvoiceErpKey { get; set; }

        /// <summary>
        /// This field indicates which Payment was used to provide the funds for this payment application. In this
        /// field, identify the original primary key or unique ID of the Payment that was used for this payment
        /// application.
        ///
        /// This information lets you track how an invoice was paid. You can identify what proportion of an payment&#39;s
        /// balance was paid by which methods by joining this field to the Payment.
        ///
        /// This value should match the [Payment ErpKey](https://developer.lockstep.io/docs/importing-payments#erpkey)
        /// field on the [PaymentSyncModel](https://developer.lockstep.io/docs/importing-payments).
        /// </summary>
        public string PaymentErpKey { get; set; }

        /// <summary>
        /// The entry number of this payment application.  This is often a journal entry number, confirmation code,
        /// or other identifying field for this payment application.
        /// </summary>
        public int EntryNumber { get; set; }

        /// <summary>
        /// The date this payment was applied to this invoice.
        /// </summary>
        public DateTime ApplyToInvoiceDate { get; set; }

        /// <summary>
        /// The total amount that was applied to this Invoice from the Payment.
        /// </summary>
        public double PaymentAppliedAmount { get; set; }

        /// <summary>
        /// If known, the date when this record was created according to the originating financial system
        /// in which this record is maintained.  If the originating financial system does not maintain a
        /// created-date, leave this field null.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime Created { get; set; }
#else
        public DateTime? Created { get; set; }
#endif

        /// <summary>
        /// If known, the date when this record was most recently modified according to the originating
        /// financial system in which this record is maintained.  If the originating financial system does
        /// not maintain a most-recently-modified-date, leave this field null.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime Modified { get; set; }
#else
        public DateTime? Modified { get; set; }
#endif
    }

    /// <summary>
    /// Contains group level payment data.
    /// </summary>
    public class PaymentDetailHeaderModel
    {

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid GroupKey { get; set; }

        /// <summary>
        /// The total number of Customers.
        /// </summary>
        public int? CustomerCount { get; set; }

        /// <summary>
        /// The total amount collected.
        /// </summary>
        public double? AmountCollected { get; set; }

        /// <summary>
        /// The total unapplied amount.
        /// </summary>
        public double? UnappliedAmount { get; set; }

        /// <summary>
        /// The number of paid invoices.
        /// </summary>
        public int? PaidInvoiceCount { get; set; }

        /// <summary>
        /// The number of open invoices.
        /// </summary>
        public int? OpenInvoiceCount { get; set; }
    }

    /// <summary>
    /// Contains detailed information about a Payment.
    /// </summary>
    public class PaymentDetailModel
    {

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid GroupKey { get; set; }

        /// <summary>
        /// The unique ID of this Payment.
        /// </summary>
        public Guid PaymentId { get; set; }

        /// <summary>
        /// The ID of the customer to which this Payment belongs.
        /// </summary>
        public Guid CustomerId { get; set; }

        /// <summary>
        /// The name of the customer to which this Payment belongs.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string CustomerName { get; set; }
#else
        public string? CustomerName { get; set; }
#endif

        /// <summary>
        /// Memo or reference text (ex. memo field on a check).
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string MemoText { get; set; }
#else
        public string? MemoText { get; set; }
#endif

        /// <summary>
        /// Reference code for the payment for the given Erp system.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string ReferenceCode { get; set; }
#else
        public string? ReferenceCode { get; set; }
#endif

        /// <summary>
        /// The name of the Primary Contact for the Customer.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string PrimaryContact { get; set; }
#else
        public string? PrimaryContact { get; set; }
#endif

        /// <summary>
        /// The Email address of the Customer.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Email { get; set; }
#else
        public string? Email { get; set; }
#endif

        /// <summary>
        /// Total amount of this Payment.
        /// </summary>
        public double PaymentAmount { get; set; }

        /// <summary>
        /// Unapplied balance of this Payment.
        /// </summary>
        public double UnappliedAmount { get; set; }

        /// <summary>
        /// The type of payment, Payment or AP Payment.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string PaymentType { get; set; }
#else
        public string? PaymentType { get; set; }
#endif

        /// <summary>
        /// The date of this Payment.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime PaymentDate { get; set; }
#else
        public DateTime? PaymentDate { get; set; }
#endif

        /// <summary>
        /// Payment post date.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime PostDate { get; set; }
#else
        public DateTime? PostDate { get; set; }
#endif

        /// <summary>
        /// The phone number of the Customer&#39;s Primary Contact.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Phone { get; set; }
#else
        public string? Phone { get; set; }
#endif

        /// <summary>
        /// The fax number of the Customer&#39;s Primary Contact.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Fax { get; set; }
#else
        public string? Fax { get; set; }
#endif

        /// <summary>
        /// The first line of the address for the Customer&#39;s Primary Contact.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Address1 { get; set; }
#else
        public string? Address1 { get; set; }
#endif

        /// <summary>
        /// The second line of the address for the Customer&#39;s Primary Contact.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Address2 { get; set; }
#else
        public string? Address2 { get; set; }
#endif

        /// <summary>
        /// The third line of the address for the Customer&#39;s Primary Contact.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Address3 { get; set; }
#else
        public string? Address3 { get; set; }
#endif

        /// <summary>
        /// The city of the address for the Customer&#39;s Primary Contact.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string City { get; set; }
#else
        public string? City { get; set; }
#endif

        /// <summary>
        /// The state/region of the address for the Customer&#39;s Primary Contact.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string StateRegion { get; set; }
#else
        public string? StateRegion { get; set; }
#endif

        /// <summary>
        /// The postal/zip code of the address for the Customer&#39;s Primary Contact.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string PostalCode { get; set; }
#else
        public string? PostalCode { get; set; }
#endif

        /// <summary>
        /// The 2 character country code of the address for the Customer&#39;s Primary Contact.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string CountryCode { get; set; }
#else
        public string? CountryCode { get; set; }
#endif
    }

    /// <summary>
    /// A Payment represents money sent from one company to another.  A single payment may contain payments for
    /// one or more invoices; it is also possible for payments to be made in advance of an invoice, for example,
    /// as a deposit.  The creator of the Payment is identified by the `CustomerId` field, and the recipient of
    /// the Payment is identified by the `CompanyId` field.  Most Payments are uniquely identified both by a
    /// Lockstep Platform ID number and a customer ERP &quot;key&quot; that was generated by the system that originated
    /// the Payment.  Payments that have not been fully applied have a nonzero `UnappliedAmount` value, which
    /// represents a deposit that has been paid and not yet applied to an Invoice.
    /// </summary>
    public class PaymentModel
    {

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid GroupKey { get; set; }

        /// <summary>
        /// The unique ID of this record, automatically assigned by Lockstep when this record is
        /// added to the Lockstep platform.
        ///
        /// For the ID of this record in its originating financial system, see `ErpKey`.
        /// </summary>
        public Guid PaymentId { get; set; }

        /// <summary>
        /// The ID of the company to which this payment belongs.
        /// </summary>
        public Guid CompanyId { get; set; }

        /// <summary>
        /// The unique ID of this record as it was known in its originating financial system.
        ///
        /// If this company record was imported from a financial system, it will have the value `ErpKey`
        /// set to the original primary key number of the record as it was known in the originating financial
        /// system.  If this record was not imported, this value will be `null`.
        ///
        /// For more information, see [Identity Columns](https://developer.lockstep.io/docs/identity-columns).
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string ErpKey { get; set; }
#else
        public string? ErpKey { get; set; }
#endif

        /// <summary>
        /// The type of payment, cash or check.
        ///
        /// Recognized PaymentType values are:
        /// * `Cash` - A cash payment or other direct transfer.
        /// * `Check` - A check payment.
        /// </summary>
        public string PaymentType { get; set; }

        /// <summary>
        /// Cash, check, credit card, wire transfer.
        ///
        /// Recognized TenderType values are:
        /// * `Cash` - A cash payment or other direct transfer.
        /// * `Check` - A check payment.
        /// * `Credit Card` - A payment made via a credit card.
        /// * `Wire Transfer` - A payment made via wire transfer from another financial institution.
        /// </summary>
        public string TenderType { get; set; }

        /// <summary>
        /// True if this payment includes some unassigned amount that has not yet been applied to an invoice.  If this
        /// value is true, the field `UnappliedAmount` will be nonzero.
        /// </summary>
        public bool IsOpen { get; set; }

        /// <summary>
        /// Memo or reference text (ex. memo field on a check).
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string MemoText { get; set; }
#else
        public string? MemoText { get; set; }
#endif

        /// <summary>
        /// The date when this payment was received.  This typically is the date when an accounting employee recorded
        /// that they received notification that the payment had occurred, whether they were notified by email, postal
        /// mail, or financial transaction notification.
        /// </summary>
        public DateTime PaymentDate { get; set; }

        /// <summary>
        /// The date when a payment was posted to a ledger.  This date is often determined by a company&#39;s accounting
        /// practices and may be different than the date when the payment was received.  This date may be affected by
        /// issues such as temporary holds on funds transferred, bank holidays, or other actions.
        /// </summary>
        public DateTime PostDate { get; set; }

        /// <summary>
        /// Total amount of this payment.
        /// </summary>
        public double PaymentAmount { get; set; }

        /// <summary>
        /// Unapplied balance of this payment.  If this amount is nonzero, the field `IsOpen` will be true.
        /// </summary>
        public double UnappliedAmount { get; set; }

        /// <summary>
        /// The ISO 4217 currency code for this payment.
        ///
        /// For a list of ISO 4217 currency codes, see [Query Currencies](https://developer.lockstep.io/reference/get_api-v1-definitions-currencies). This will be validated by the /api/v1/currencies data set
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string CurrencyCode { get; set; }
#else
        public string? CurrencyCode { get; set; }
#endif

        /// <summary>
        /// Reference code for the payment for the given Erp system.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string ReferenceCode { get; set; }
#else
        public string? ReferenceCode { get; set; }
#endif

        /// <summary>
        /// The date on which this record was created.
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// The ID of the user who created this payment.
        /// </summary>
        public Guid CreatedUserId { get; set; }

        /// <summary>
        /// The date on which this record was last modified.
        /// </summary>
        public DateTime Modified { get; set; }

        /// <summary>
        /// The ID of the user who last modified this payment.
        /// </summary>
        public Guid ModifiedUserId { get; set; }

        /// <summary>
        /// The AppEnrollmentId of the application that imported this record.  For accounts
        /// with more than one financial system connected, this field identifies the originating
        /// financial system that produced this record.  This value is null if this record
        /// was not loaded from an external ERP or financial system.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public Guid AppEnrollmentId { get; set; }
#else
        public Guid? AppEnrollmentId { get; set; }
#endif

        /// <summary>
        /// Is the payment voided?
        /// </summary>
        public bool IsVoided { get; set; }

        /// <summary>
        /// Is the payment in dispute?
        /// </summary>
        public bool InDispute { get; set; }

        /// <summary>
        /// All applications this payment is associated with.
        /// To retrieve this collection, specify `Applications` in the &quot;Include&quot; parameter for your query.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public PaymentAppliedModel[] Applications { get; set; }
#else
        public PaymentAppliedModel[]? Applications { get; set; }
#endif

        /// <summary>
        /// A collection of notes linked to this record.  To retrieve this collection, specify `Notes` in the
        /// `include` parameter when retrieving data.
        ///
        /// To create a note, use the [Create Note](https://developer.lockstep.io/reference/post_api-v1-notes)
        /// endpoint with the `TableKey` to `Payment` and the `ObjectKey` set to the `PaymentId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
#if DOT_NET_FRAMEWORK
        public NoteModel[] Notes { get; set; }
#else
        public NoteModel[]? Notes { get; set; }
#endif

        /// <summary>
        /// A collection of attachments linked to this record.  To retrieve this collection, specify `Attachments` in
        /// the `include` parameter when retrieving data.
        ///
        /// To create an attachment, use the [Upload Attachment](https://developer.lockstep.io/reference/post_api-v1-attachments)
        /// endpoint with the `TableKey` to `Payment` and the `ObjectKey` set to the `PaymentId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
#if DOT_NET_FRAMEWORK
        public AttachmentModel[] Attachments { get; set; }
#else
        public AttachmentModel[]? Attachments { get; set; }
#endif

        /// <summary>
        /// A collection of custom fields linked to this record.  To retrieve this collection, specify
        /// `CustomFieldDefinitions` in the `include` parameter when retrieving data.
        ///
        /// To create a custom field, use the [Create Custom Field](https://developer.lockstep.io/reference/post_api-v1-customfieldvalues)
        /// endpoint with the `TableKey` to `Payment` and the `ObjectKey` set to the `PaymentId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
#if DOT_NET_FRAMEWORK
        public CustomFieldDefinitionModel[] CustomFieldDefinitions { get; set; }
#else
        public CustomFieldDefinitionModel[]? CustomFieldDefinitions { get; set; }
#endif

        /// <summary>
        /// A collection of custom fields linked to this record.  To retrieve this collection, specify
        /// `CustomFieldValues` in the `include` parameter when retrieving data.
        ///
        /// To create a custom field, use the [Create Custom Field](https://developer.lockstep.io/reference/post_api-v1-customfieldvalues)
        /// endpoint with the `TableKey` to `Payment` and the `ObjectKey` set to the `PaymentId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
#if DOT_NET_FRAMEWORK
        public CustomFieldValueModel[] CustomFieldValues { get; set; }
#else
        public CustomFieldValueModel[]? CustomFieldValues { get; set; }
#endif
    }

    /// <summary>
    /// Contains summary information for a Payment
    /// </summary>
    public class PaymentSummaryModel
    {

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid GroupKey { get; set; }

        /// <summary>
        /// The id of the payment
        /// </summary>
        public Guid PaymentId { get; set; }

        /// <summary>
        /// Memo or reference text (ex. memo field on a check).
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string MemoText { get; set; }
#else
        public string? MemoText { get; set; }
#endif

        /// <summary>
        /// Reference code for the payment for the given Erp system.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string ReferenceCode { get; set; }
#else
        public string? ReferenceCode { get; set; }
#endif

        /// <summary>
        /// The type of payment, Payment or AP Payment.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string PaymentType { get; set; }
#else
        public string? PaymentType { get; set; }
#endif

        /// <summary>
        /// The date of this payment.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime PaymentDate { get; set; }
#else
        public DateTime? PaymentDate { get; set; }
#endif

        /// <summary>
        /// Total amount of this payment.
        /// </summary>
        public double PaymentAmount { get; set; }

        /// <summary>
        /// Unapplied balance of this payment.
        /// </summary>
        public double UnappliedAmount { get; set; }

        /// <summary>
        /// The number of invoices associated to this payment.
        /// </summary>
        public int? InvoiceCount { get; set; }

        /// <summary>
        /// The number of payments applied to this payment.
        /// </summary>
        public double? TotalPaymentsApplied { get; set; }

        /// <summary>
        /// The reference codes of the invoices associated to this payment.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string[] InvoiceList { get; set; }
#else
        public string[]? InvoiceList { get; set; }
#endif

        /// <summary>
        /// The ids of the invoices associated to this payment.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public Guid[] InvoiceIdList { get; set; }
#else
        public Guid[]? InvoiceIdList { get; set; }
#endif

        /// <summary>
        /// The name of the customer for this payment.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string CustomerName { get; set; }
#else
        public string? CustomerName { get; set; }
#endif

        /// <summary>
        /// The id of the customer for this payment.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public Guid CustomerId { get; set; }
#else
        public Guid? CustomerId { get; set; }
#endif
    }

    /// <summary>
    /// The PaymentSyncModel represents information coming into Lockstep from an external financial system or other
    /// enterprise resource planning system.  To import data from an external system, convert your original data into
    /// the PaymentSyncModel format and call the [Upload Sync File API](https://developer.lockstep.io/reference/post_api-v1-sync-zip).
    /// This API retrieves all of the data you uploaded in a compressed ZIP file and imports it into the Lockstep
    /// platform.
    ///
    /// Once imported, this record will be available in the Lockstep API as a [PaymentModel](https://developer.lockstep.io/docs/paymentmodel).
    ///
    /// For more information on writing your own connector, see [Connector Data](https://developer.lockstep.io/docs/connector-data).
    /// </summary>
    public class PaymentSyncModel
    {

        /// <summary>
        /// This is the primary key of the Payment record. For this field, you should use whatever the payment&#39;s unique
        /// identifying number is in the originating system. Search for a unique, non-changing number within the
        /// originating financial system for this record.
        ///
        /// Example: If you store your payment records in a database, whatever the primary key for the payment table is
        /// in the database should be the &quot;ErpKey&quot;.
        ///
        /// For more information, see [Identity Columns](https://developer.lockstep.io/docs/identity-columns).
        /// </summary>
        public string ErpKey { get; set; }

        /// <summary>
        /// The original primary key or unique ID of the company to which this payment belongs.  This value should
        /// match the [Company ErpKey](https://developer.lockstep.io/docs/importing-companies#erpkey) field on the
        /// [CompanySyncModel](https://developer.lockstep.io/docs/importing-companies).
        /// </summary>
        public string CompanyErpKey { get; set; }

        /// <summary>
        /// The type of payment, cash or check.
        ///
        /// Recognized PaymentType values are:
        /// * `Cash` - A cash payment or other direct transfer.
        /// * `Check` - A check payment.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string PaymentType { get; set; }
#else
        public string? PaymentType { get; set; }
#endif

        /// <summary>
        /// Cash, check, credit card, wire transfer.
        ///
        /// Recognized TenderType values are:
        /// * `Cash` - A cash payment or other direct transfer.
        /// * `Check` - A check payment.
        /// * `Credit Card` - A payment made via a credit card.
        /// * `Wire Transfer` - A payment made via wire transfer from another financial institution.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string TenderType { get; set; }
#else
        public string? TenderType { get; set; }
#endif

        /// <summary>
        /// True if this payment includes some unassigned amount that has not yet been applied to an invoice.  If this
        /// value is true, the field `UnappliedAmount` will be nonzero.
        /// </summary>
        public bool IsOpen { get; set; }

        /// <summary>
        /// Memo or reference text (ex. memo field on a check).
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string MemoText { get; set; }
#else
        public string? MemoText { get; set; }
#endif

        /// <summary>
        /// The date when this payment was received.  This typically is the date when an accounting employee recorded
        /// that they received notification that the payment had occurred, whether they were notified by email, postal
        /// mail, or financial transaction notification.
        /// </summary>
        public DateTime PaymentDate { get; set; }

        /// <summary>
        /// The date when a payment was posted to a ledger.  This date is often determined by a company&#39;s accounting
        /// practices and may be different than the date when the payment was received.  This date may be affected by
        /// issues such as temporary holds on funds transferred, bank holidays, or other actions.
        /// </summary>
        public DateTime PostDate { get; set; }

        /// <summary>
        /// Total amount of this payment.
        /// </summary>
        public double PaymentAmount { get; set; }

        /// <summary>
        /// Unapplied balance of this payment.  If this amount is nonzero, the field `IsOpen` will be true.
        /// </summary>
        public double UnappliedAmount { get; set; }

        /// <summary>
        /// The ISO 4217 currency code for this payment.
        ///
        /// For a list of ISO 4217 currency codes, see [Query Currencies](https://developer.lockstep.io/reference/get_api-v1-definitions-currencies). This will be validated by the /api/v1/currencies data set
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string CurrencyCode { get; set; }
#else
        public string? CurrencyCode { get; set; }
#endif

        /// <summary>
        /// If known, the date when this record was created according to the originating financial system
        /// in which this record is maintained.  If the originating financial system does not maintain a
        /// created-date, leave this field null.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime Created { get; set; }
#else
        public DateTime? Created { get; set; }
#endif

        /// <summary>
        /// If known, the date when this record was most recently modified according to the originating
        /// financial system in which this record is maintained.  If the originating financial system does
        /// not maintain a most-recently-modified-date, leave this field null.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime Modified { get; set; }
#else
        public DateTime? Modified { get; set; }
#endif

        /// <summary>
        /// A reference code for the payment for the given financial or ERP system.  This can be any value that the
        /// originating system uses to designate the payment, such as a confirmation number or tracking number, that
        /// is different from the `ErpKey` value.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string ReferenceCode { get; set; }
#else
        public string? ReferenceCode { get; set; }
#endif

        /// <summary>
        /// True if this payment was voided.
        /// </summary>
        public bool IsVoided { get; set; }

        /// <summary>
        /// True if this payment is in dispute.
        /// </summary>
        public bool InDispute { get; set; }
    }

    /// <summary>
    /// Represents the data to finalize onboarding for a user
    /// </summary>
    public class ProvisioningFinalizeRequestModel
    {

        /// <summary>
        /// The full name of the user
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// The time zone of the user
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string TimeZone { get; set; }
#else
        public string? TimeZone { get; set; }
#endif

        /// <summary>
        /// The default currency of the user
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string DefaultCurrency { get; set; }
#else
        public string? DefaultCurrency { get; set; }
#endif

        /// <summary>
        /// The company information for the user and group
        /// </summary>
#if DOT_NET_FRAMEWORK
        public CompanyModel Company { get; set; }
#else
        public CompanyModel? Company { get; set; }
#endif

        /// <summary>
        /// Optional connector information needed to enroll user to their email connector
        /// </summary>
#if DOT_NET_FRAMEWORK
        public ErpInfoModel EmailConnector { get; set; }
#else
        public ErpInfoModel? EmailConnector { get; set; }
#endif
    }

    /// <summary>
    /// Represents the data sent during the onboarding flow
    /// </summary>
    public class ProvisioningModel
    {

        /// <summary>
        /// The full name of the new user
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string FullName { get; set; }
#else
        public string? FullName { get; set; }
#endif

        /// <summary>
        /// The information necessary to enroll the user in their ERP
        /// </summary>
#if DOT_NET_FRAMEWORK
        public ErpInfoModel Erp { get; set; }
#else
        public ErpInfoModel? Erp { get; set; }
#endif
    }

    /// <summary>
    /// Represents the response to either a successful or failed account provisioning
    /// </summary>
    public class ProvisioningResponseModel
    {

        /// <summary>
        /// If provisioning is successful, contains the username of the created user.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string UserName { get; set; }
#else
        public string? UserName { get; set; }
#endif

        /// <summary>
        /// If provisioning is successful, contains subscription account name of created user.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string AccountName { get; set; }
#else
        public string? AccountName { get; set; }
#endif

        /// <summary>
        /// If provisioning is successful, contains the unique identifier of the created user.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public Guid UserId { get; set; }
#else
        public Guid? UserId { get; set; }
#endif

        /// <summary>
        /// If provisioning is successful, contains the group key of the created user.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public Guid GroupKey { get; set; }
#else
        public Guid? GroupKey { get; set; }
#endif

        /// <summary>
        /// If provisioning is successful, contains the app enrollment id of the created app enrollment.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public Guid AppEnrollmentId { get; set; }
#else
        public Guid? AppEnrollmentId { get; set; }
#endif

        /// <summary>
        /// if provisioning is successful, contains the sync request id of the sync that was started for the app enrollment.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public Guid SyncRequestId { get; set; }
#else
        public Guid? SyncRequestId { get; set; }
#endif

        /// <summary>
        /// The error message(s).
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string ErrorMessage { get; set; }
#else
        public string? ErrorMessage { get; set; }
#endif
    }

    /// <summary>
    /// Represents a risk rate calculation for a single month
    /// </summary>
    public class RiskRateModel
    {

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid GroupKey { get; set; }

        /// <summary>
        /// The month the risk rate was calculated for
        /// </summary>
        public DateTime ReportPeriod { get; set; }

        /// <summary>
        /// The string name of the month the risk rate was calculated for
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string InvoiceMonthName { get; set; }
#else
        public string? InvoiceMonthName { get; set; }
#endif

        /// <summary>
        /// The count of all invoices in the calculation month
        /// </summary>
        public int TotalInvoiceCount { get; set; }

        /// <summary>
        /// The sum of the total amount for invoices in the calculation month
        /// </summary>
        public double TotalInvoiceAmount { get; set; }

        /// <summary>
        /// The count of open invoices over 90 days from the calculation month
        /// </summary>
        public int AtRiskCount { get; set; }

        /// <summary>
        /// The sum of the outstanding balance of open invoices over 90 days from the calculation month
        /// </summary>
        public double AtRiskAmount { get; set; }

        /// <summary>
        /// The percentage of all open invoices for the calculation month that are over 90 days based on count
        /// </summary>
        public double AtRiskCountPercentage { get; set; }

        /// <summary>
        /// The percentage of all open invoices for the calculation month that are over 90 days based on outstanding balance
        /// </summary>
        public double AtRiskPercentage { get; set; }
    }

    /// <summary>
    /// State model for ISO-3166-2
    /// </summary>
    public class StateModel
    {

        /// <summary>
        /// Name of the state
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Name { get; set; }
#else
        public string? Name { get; set; }
#endif

        /// <summary>
        /// 2 letter alphabetic code for the given state
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Alpha2 { get; set; }
#else
        public string? Alpha2 { get; set; }
#endif

        /// <summary>
        /// A different name for a state
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Aliases { get; set; }
#else
        public string? Aliases { get; set; }
#endif
    }

    /// <summary>
    /// Represents the status of a user&#39;s credentials
    /// </summary>
    public class StatusModel
    {

        /// <summary>
        /// If authentication is successful, contains the username of the logged-in user.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string UserName { get; set; }
#else
        public string? UserName { get; set; }
#endif

        /// <summary>
        /// If authentication is successful, contains subscription account name of logged-in user.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string AccountName { get; set; }
#else
        public string? AccountName { get; set; }
#endif

        /// <summary>
        /// If authentication is successful, contains subscription account company id of logged-in user.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public Guid AccountCompanyId { get; set; }
#else
        public Guid? AccountCompanyId { get; set; }
#endif

        /// <summary>
        /// If authentication is successful, contains the unique identifier of the logged-in user.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public Guid UserId { get; set; }
#else
        public Guid? UserId { get; set; }
#endif

        /// <summary>
        /// If authentication is successful, contains the group key of the logged-in user.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public Guid GroupKey { get; set; }
#else
        public Guid? GroupKey { get; set; }
#endif

        /// <summary>
        /// Returns true if authentication for this API was successful.
        /// </summary>
        public bool LoggedIn { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string ErrorMessage { get; set; }
#else
        public string? ErrorMessage { get; set; }
#endif

        /// <summary>
        /// The set of roles for this user.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string[] Roles { get; set; }
#else
        public string[]? Roles { get; set; }
#endif

        /// <summary>
        /// Date and time user has last logged into Azure B2C.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime LastLoggedIn { get; set; }
#else
        public DateTime? LastLoggedIn { get; set; }
#endif

        /// <summary>
        /// The id of the API key used to authenticate.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public Guid ApiKeyId { get; set; }
#else
        public Guid? ApiKeyId { get; set; }
#endif

        /// <summary>
        /// If authentication is successful, contains the user status of the logged-in user.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string UserStatus { get; set; }
#else
        public string? UserStatus { get; set; }
#endif

        /// <summary>
        /// The environment currently being used
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Environment { get; set; }
#else
        public string? Environment { get; set; }
#endif

        /// <summary>
        /// The version currently being used
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Version { get; set; }
#else
        public string? Version { get; set; }
#endif

        /// <summary>
        /// Statuses for the dependencies of this api.
        /// OK if the dependency is working.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public object Dependencies { get; set; }
#else
        public object? Dependencies { get; set; }
#endif
    }

    /// <summary>
    /// Contains information about a sync process for an entity.
    /// </summary>
    public class SyncEntityResultModel
    {

        /// <summary>
        /// The number of entities inserted
        /// </summary>
        public int InsertCount { get; set; }

        /// <summary>
        /// The number of entities updated
        /// </summary>
        public int UpdateCount { get; set; }

        /// <summary>
        /// The number of entities skipped
        /// </summary>
        public int SkipCount { get; set; }

        /// <summary>
        /// The number of errors encountered during sync
        /// </summary>
        public int ErrorCount { get; set; }

        /// <summary>
        /// The errors encountered during sync keyed by ERP key
        /// </summary>
#if DOT_NET_FRAMEWORK
        public object Errors { get; set; }
#else
        public object? Errors { get; set; }
#endif
    }

    /// <summary>
    /// Represents a Sync action that loads data from a connector into the Lockstep Platform.  Users can
    /// request Sync actions manually using Lockstep Inbox, or via the [Create Sync API](https://developer.lockstep.io/reference/post_api-v1-sync).
    /// Each Sync action is tied to an [AppEnrollment](https://developer.lockstep.io/docs/applications-and-enrollments).
    /// When the Sync action is complete, the field `StatusCode` will be set to either `Success` or `Failed`.
    ///
    /// You can fetch a list of detailed results for the Sync API by calling Retrieve or Query with an `include`
    /// parameter of `details`.  These detailed results contain line-by-line errors that were detected during
    /// processing of this sync.
    /// </summary>
    public class SyncRequestModel
    {

        /// <summary>
        /// The unique ID of this record, automatically assigned by Lockstep when this record is
        /// added to the Lockstep platform.
        /// </summary>
        public Guid SyncRequestId { get; set; }

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid GroupKey { get; set; }

        /// <summary>
        /// The status of processing for this SyncRequest.  When a SyncRequest is created, it is flagged as `Ready`.
        /// When it is picked up for execution, its status moves to `In Progress`.  When it is complete, its status
        /// will move to `Success` or `Failed`.  If another API call cancels the SyncRequest, its status will move
        /// to `Cancelled`.
        ///
        /// * Ready
        /// * In Progress
        /// * Cancelled
        /// * Failed
        /// * Success
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string StatusCode { get; set; }
#else
        public string? StatusCode { get; set; }
#endif

        /// <summary>
        /// Message containing information about the sync request results
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string ProcessResultMessage { get; set; }
#else
        public string? ProcessResultMessage { get; set; }
#endif

        /// <summary>
        /// The AppEnrollmentId of the AppEnrollment object that executed this sync request
        /// </summary>
#if DOT_NET_FRAMEWORK
        public Guid AppEnrollmentId { get; set; }
#else
        public Guid? AppEnrollmentId { get; set; }
#endif

        /// <summary>
        /// The date this sync request was created
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// The date this sync request was last modified
        /// </summary>
        public DateTime Modified { get; set; }

        /// <summary>
        /// The ID number of the user who most recently modified this sync request.
        /// </summary>
        public Guid ModifiedUserId { get; set; }

        /// <summary>
        /// The detailed list of results and errors that occurred during the processing of this SyncRequest.  This
        /// information is available only after the SyncRequest has completed.  You will only be able to fetch this
        /// field if the SyncRequest&#39;s `StatusCode` field is set to `Cancelled`, `Success`, or `Failed`.
        ///
        /// To retrieve this collection, add the keyword `details` to the `include` parameter on your Retrieve or
        /// Query requests.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public object Details { get; set; }
#else
        public object? Details { get; set; }
#endif
    }

    /// <summary>
    /// A SyncSubmitModel represents a task that loads data from a connector to load into the Lockstep Platform.  Data
    /// contained in a sync will be merged with your existing data.  Each record will be matched with existing data
    /// inside the Lockstep Platform using the [Identity Column](https://developer.lockstep.io/docs/identity-columns)
    /// rules.  Any record that represents a new AppEnrollmentId+ErpKey will be inserted.  A record that matches an
    /// existing AppEnrollmentId+ErpKey will be updated, but only if the data has changed.
    ///
    /// A Sync process permits either a complete data file or a partial / delta data file.  Lockstep recommends
    /// using a sliding time window to avoid the risk of clock skew errors that might accidentally omit records.
    /// Best practice is to run a Sync process daily, and to export all data that has changed in the past 48 hours.
    /// </summary>
    public class SyncSubmitModel
    {

        /// <summary>
        /// The unique identifier of the app enrollment that is creating this sync request.
        /// </summary>
        public Guid AppEnrollmentId { get; set; }
    }

    /// <summary>
    /// Model from the transfer ownership process.
    /// </summary>
    public class TransferOwnerModel
    {

        /// <summary>
        /// The previous owner of the account.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public UserAccountModel PreviousOwner { get; set; }
#else
        public UserAccountModel? PreviousOwner { get; set; }
#endif

        /// <summary>
        /// The new owner of the account.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public UserAccountModel NewOwner { get; set; }
#else
        public UserAccountModel? NewOwner { get; set; }
#endif
    }

    /// <summary>
    /// Model used to submit a transfer ownership request
    /// </summary>
    public class TransferOwnerSubmitModel
    {

        /// <summary>
        /// The ID of the user to transfer ownership to.
        /// </summary>
        public Guid TargetUserId { get; set; }
    }

    /// <summary>
    /// Represents a cell of a trial balance report
    /// </summary>
    public class TrialBalanceReportCellModel
    {

        /// <summary>
        /// The value of the trial balance report cell
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Value { get; set; }
#else
        public string? Value { get; set; }
#endif
    }

    /// <summary>
    /// Represents a Trial Balance Report
    /// </summary>
    public class TrialBalanceReportModel
    {

        /// <summary>
        /// The name of the report (&quot;Trial Balance for *Company*&quot;)
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string ReportName { get; set; }
#else
        public string? ReportName { get; set; }
#endif

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid GroupKey { get; set; }

        /// <summary>
        /// The start date of the trial balance report
        /// </summary>
        public DateTime ReportStartDate { get; set; }

        /// <summary>
        /// The end date of the trial balance report
        /// </summary>
        public DateTime ReportEndDate { get; set; }

        /// <summary>
        /// The created date of the trial balance report
        /// </summary>
        public DateTime ReportCreatedDate { get; set; }

        /// <summary>
        /// The rows of the trial balance report
        /// </summary>
#if DOT_NET_FRAMEWORK
        public TrialBalanceReportRowModel[] Rows { get; set; }
#else
        public TrialBalanceReportRowModel[]? Rows { get; set; }
#endif
    }

    /// <summary>
    /// Represents a row of a trial balance report
    /// </summary>
    public class TrialBalanceReportRowModel
    {

        /// <summary>
        /// Describes what type of row this row is (Header, Summary, Classification, Category, Subcategory, Data)
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string RowType { get; set; }
#else
        public string? RowType { get; set; }
#endif

        /// <summary>
        /// The label for the row if it is a Classification, Category, or Subcategory.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Label { get; set; }
#else
        public string? Label { get; set; }
#endif

        /// <summary>
        /// The sub rows of this row if it is a Classification, Category, or Subcategory.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public TrialBalanceReportRowModel[] Rows { get; set; }
#else
        public TrialBalanceReportRowModel[]? Rows { get; set; }
#endif

        /// <summary>
        /// The cells of the row
        /// </summary>
#if DOT_NET_FRAMEWORK
        public TrialBalanceReportCellModel[] Cells { get; set; }
#else
        public TrialBalanceReportCellModel[]? Cells { get; set; }
#endif
    }

    /// <summary>
    /// Represents a Uri for download link
    /// </summary>
    public class UriModel
    {

        /// <summary>
        /// Represents the download link
        /// </summary>
#if DOT_NET_FRAMEWORK
        public Uri DownloadLink { get; set; }
#else
        public Uri? DownloadLink { get; set; }
#endif
    }

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
        public Guid UserId { get; set; }

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid GroupKey { get; set; }

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
#if DOT_NET_FRAMEWORK
        public string Status { get; set; }
#else
        public string? Status { get; set; }
#endif

        /// <summary>
        /// The date that the user account was created
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// The ID of the user who created the user account
        /// </summary>
        public Guid CreatedUserId { get; set; }

        /// <summary>
        /// The date the user account was last modified
        /// </summary>
        public DateTime Modified { get; set; }

        /// <summary>
        /// The ID of the user who last modified the user account
        /// </summary>
        public Guid ModifiedUserId { get; set; }

        /// <summary>
        /// The name of the user who last modified the user account
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string ModifiedUserName { get; set; }
#else
        public string? ModifiedUserName { get; set; }
#endif

        /// <summary>
        /// The ID of the user in Azure B2C
        /// </summary>
#if DOT_NET_FRAMEWORK
        public Guid B2CUserId { get; set; }
#else
        public Guid? B2CUserId { get; set; }
#endif

        /// <summary>
        /// The id of the Permission Level for the user.
        /// </summary>
        public Guid UserRole { get; set; }

        /// <summary>
        /// The date timestamp when the invite was sent to the user.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime InviteSent { get; set; }
#else
        public DateTime? InviteSent { get; set; }
#endif

        /// <summary>
        /// The phone number of the user.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string PhoneNumber { get; set; }
#else
        public string? PhoneNumber { get; set; }
#endif

        /// <summary>
        /// The fax number of the user.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string FaxNumber { get; set; }
#else
        public string? FaxNumber { get; set; }
#endif

        /// <summary>
        /// The title of the user; free text field
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Title { get; set; }
#else
        public string? Title { get; set; }
#endif

        /// <summary>
        /// FK to the CodeDefinition table; CodeType = &#39;AccountingRole&#39;
        /// </summary>
#if DOT_NET_FRAMEWORK
        public Guid AccountingRoleCodeDefId { get; set; }
#else
        public Guid? AccountingRoleCodeDefId { get; set; }
#endif

        /// <summary>
        /// Address Line 1 for this User
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Address1 { get; set; }
#else
        public string? Address1 { get; set; }
#endif

        /// <summary>
        /// Address Line 2 for this User
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Address2 { get; set; }
#else
        public string? Address2 { get; set; }
#endif

        /// <summary>
        /// Address Line 3 for this User
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Address3 { get; set; }
#else
        public string? Address3 { get; set; }
#endif

        /// <summary>
        /// City for this User
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string City { get; set; }
#else
        public string? City { get; set; }
#endif

        /// <summary>
        /// Region (&quot;state&quot; in the US) for this User
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string StateRegion { get; set; }
#else
        public string? StateRegion { get; set; }
#endif

        /// <summary>
        /// Postal Code this User
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string PostalCode { get; set; }
#else
        public string? PostalCode { get; set; }
#endif

        /// <summary>
        /// Country for this User This will be validated by the /api/v1/countries data set
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Country { get; set; }
#else
        public string? Country { get; set; }
#endif

        /// <summary>
        /// Image URL for this User
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string ImageURL { get; set; }
#else
        public string? ImageURL { get; set; }
#endif

        /// <summary>
        /// Description for this User.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Description { get; set; }
#else
        public string? Description { get; set; }
#endif

        /// <summary>
        /// Last date time user logged into Azure B2C.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime B2CLastLoggedIn { get; set; }
#else
        public DateTime? B2CLastLoggedIn { get; set; }
#endif

        /// <summary>
        /// The default currency code used by this user entity.  This value can be overridden
        /// for invoices in a different currency code.
        ///
        /// For a list of defined currency codes, see [Query Currencies](https://developer.lockstep.io/reference/get_api-v1-definitions-currencies) This will be validated by the /api/v1/currencies data set
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string DefaultCurrencyCode { get; set; }
#else
        public string? DefaultCurrencyCode { get; set; }
#endif

        /// <summary>
        /// A collection of notes linked to this record.  To retrieve this collection, specify `Notes` in the
        /// `include` parameter when retrieving data.
        ///
        /// To create a note, use the [Create Note](https://developer.lockstep.io/reference/post_api-v1-notes)
        /// endpoint with the `TableKey` to `UserAccount` and the `ObjectKey` set to the `UserId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
#if DOT_NET_FRAMEWORK
        public NoteModel[] Notes { get; set; }
#else
        public NoteModel[]? Notes { get; set; }
#endif

        /// <summary>
        /// A collection of attachments linked to this record.  To retrieve this collection, specify `Attachments` in
        /// the `include` parameter when retrieving data.
        ///
        /// To create an attachment, use the [Upload Attachment](https://developer.lockstep.io/reference/post_api-v1-attachments)
        /// endpoint with the `TableKey` to `UserAccount` and the `ObjectKey` set to the `UserId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
#if DOT_NET_FRAMEWORK
        public AttachmentModel[] Attachments { get; set; }
#else
        public AttachmentModel[]? Attachments { get; set; }
#endif

        /// <summary>
        /// A collection of custom fields linked to this record.  To retrieve this collection, specify
        /// `CustomFieldValues` in the `include` parameter when retrieving data.
        ///
        /// To create a custom field, use the [Create Custom Field](https://developer.lockstep.io/reference/post_api-v1-customfieldvalues)
        /// endpoint with the `TableKey` to `UserAccount` and the `ObjectKey` set to the `UserId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
#if DOT_NET_FRAMEWORK
        public CustomFieldValueModel[] CustomFieldValues { get; set; }
#else
        public CustomFieldValueModel[]? CustomFieldValues { get; set; }
#endif

        /// <summary>
        /// Accounting role definition for this User.
        /// To retrieve this collection, specify `AccountingRole` in the &quot;Include&quot; parameter for your query.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public CodeDefinitionModel AccountingRoleCodeDefinition { get; set; }
#else
        public CodeDefinitionModel? AccountingRoleCodeDefinition { get; set; }
#endif
    }

    /// <summary>
    /// Represents a role for a user
    /// </summary>
    public class UserRoleModel
    {

        /// <summary>
        /// The unique ID of this record, automatically assigned by Lockstep when this record is
        /// added to the Lockstep platform.
        /// </summary>
        public Guid UserRoleId { get; set; }

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid GroupKey { get; set; }

        /// <summary>
        /// The name of the user role
        /// </summary>
        public string UserRoleName { get; set; }

        /// <summary>
        /// The date that the user role was created
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// The ID of the user who created the user role
        /// </summary>
        public Guid CreatedUserId { get; set; }

        /// <summary>
        /// The date the user role was last modified
        /// </summary>
        public DateTime Modified { get; set; }

        /// <summary>
        /// The ID of the user who last modified the user role
        /// </summary>
        public Guid ModifiedUserId { get; set; }
    }

    /// <summary>
    /// Represents the Webhook Trigger History
    /// </summary>
    public class WebhookHistoryTableStorageModel
    {

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid GroupKey { get; set; }

        /// <summary>
        /// The WebhookId uniquely identifies the webhook used to send notification that an event action has taken place.
        /// </summary>
        public Guid WebhookId { get; set; }

        /// <summary>
        /// The unique ID of this record, automatically assigned by Lockstep when this record is
        /// added to the Lockstep platform.
        /// </summary>
        public Guid WebhookHistoryId { get; set; }

        /// <summary>
        /// Event type which fired webhook
        ///
        /// [entity].[action]
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string EventType { get; set; }
#else
        public string? EventType { get; set; }
#endif

        /// <summary>
        /// Flag whether request was sent to callback url successfully or blocked by failing or because it was disabled.
        /// </summary>
        public bool RequestSent { get; set; }

        /// <summary>
        /// Flag whether webhook notification was successful overall (if webhook disabled should always return true otherwise
        /// depends on the response from the callback url)
        /// </summary>
        public bool IsSuccessful { get; set; }

        /// <summary>
        /// Response status code that is returned when calling a callback url.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string ResponseStatusCode { get; set; }
#else
        public string? ResponseStatusCode { get; set; }
#endif

        /// <summary>
        /// Message containing information about the webhook callback results
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string ProcessResultMessage { get; set; }
#else
        public string? ProcessResultMessage { get; set; }
#endif

        /// <summary>
        /// Number of times message failed to be sent over to callback url before succeeding or failing out.
        /// The maximum value should is based on webhook.
        /// </summary>
        public int FailureCount { get; set; }

        /// <summary>
        /// Timestamp of when a request is sent to a webhook callback.
        /// Contains the last time message is sent if failures occur.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime Timestamp { get; set; }
#else
        public DateTime? Timestamp { get; set; }
#endif
    }

    /// <summary>
    /// A Webhook is a subscription to receive notifications automatically to the supplied
    /// callback url when changes are made to a supported object.
    ///
    /// Currently supported objects:
    ///  * `SyncRequest` - Receive a notification when a new sync request has completed for the group key.
    /// </summary>
    public class WebhookModel
    {

        /// <summary>
        /// The unique ID of this record, automatically assigned by Lockstep when this record is
        /// added to the Lockstep platform.
        /// </summary>
        public Guid WebhookId { get; set; }

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid GroupKey { get; set; }

        /// <summary>
        /// A name for the webhook subscription.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The status of the webhook (Active, Inactive, Errored).
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string StatusCode { get; set; }
#else
        public string? StatusCode { get; set; }
#endif

        /// <summary>
        /// When the StatusCode is set to Errored a message is supplied for why it was errored.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string StatusMessage { get; set; }
#else
        public string? StatusMessage { get; set; }
#endif

        /// <summary>
        /// An secret set during webhook creation that can be used to verify that the notification
        /// is coming from the Lockstep API.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string ClientSecret { get; set; }
#else
        public string? ClientSecret { get; set; }
#endif

        /// <summary>
        /// The format of the content to be returned in the webhook notifications. Options TBD.
        /// </summary>
        public string RequestContentType { get; set; }

        /// <summary>
        /// The HTTP Method to be used on the callback URL for use in notifications (GET, POST, PATCH, PUT).
        /// </summary>
        public string CallbackHttpMethod { get; set; }

        /// <summary>
        /// The URL where the notification will be sent via the method set in CallbackHttpMethod.
        ///
        /// When creating a webhook, the Lockstep API will make a call to this url via the method
        /// set in the CallbackHttpMethod property with a query parameter of &quot;code&quot; set to an encoded
        /// string. To successfully create the webhook, the call must return a successful status code
        /// with the query parameter&#39;s value as the plain text content.
        /// </summary>
        public Uri CallbackUrl { get; set; }

        /// <summary>
        /// The expiration date for the given webhook subscription. Once the expiration date passes,
        /// notifications will no longer be sent to the callback url.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public DateTime ExpirationDate { get; set; }
#else
        public DateTime? ExpirationDate { get; set; }
#endif

        /// <summary>
        /// The amount of times a notification should be retried before marking the webhook as errored.
        /// </summary>
        public int RetryCount { get; set; }

        /// <summary>
        /// The date this webhook was created
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// The ID of the user who created this webhook
        /// </summary>
        public Guid CreatedUserId { get; set; }

        /// <summary>
        /// The date this webhook was last modified
        /// </summary>
        public DateTime Modified { get; set; }

        /// <summary>
        /// The ID of the user who last modified this webhook
        /// </summary>
        public Guid ModifiedUserId { get; set; }

        /// <summary>
        /// The partition key used for the webhook callback history
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string PartitionKey { get; set; }
#else
        public string? PartitionKey { get; set; }
#endif
    }
}
