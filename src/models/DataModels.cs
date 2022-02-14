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
        public string? ActivityTypeCode { get; set; }

        /// <summary>
        /// The name of the activity.  The name is a short name provided by the
        /// person who created the activity that can be displayed in a list.
        /// </summary>
        public string ActivityName { get; set; }

        /// <summary>
        /// A description of the activity.  This field contains more detailed text about the
        /// activity and can be lengthy.
        /// </summary>
        public string? ActivityDescription { get; set; }

        /// <summary>
        /// The status of the activity.
        /// </summary>
        public string? ActivityStatus { get; set; }

        /// <summary>
        /// True if this activity is currently "open", which indicates that the activitiy is
        /// currently in progress.
        /// </summary>
        public bool IsOpen { get; set; }

        /// <summary>
        /// The priority of the activity.
        /// </summary>
        public string? Priority { get; set; }

        /// <summary>
        /// The ID of the user the activity is assigned to.
        /// </summary>
        public Guid? UserAssignedTo { get; set; }

        /// <summary>
        /// The date the activity was assigned.
        /// </summary>
        public DateTime? DateAssigned { get; set; }

        /// <summary>
        /// The date the activity was closed.
        /// </summary>
        public DateTime? DateClosed { get; set; }

        /// <summary>
        /// If this activity has been "snoozed", this field will be non-null and will contain
        /// the date when the activity will be displayed.  Until that date arrives, the activity
        /// will remain hidden.
        /// </summary>
        public DateTime? SnoozeUntilDate { get; set; }

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
        /// True if this activity is to be shown in an "unread" state.  When an activity
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
        /// To retrieve this collection, specify `Company` in the "Include" parameter for your query.
        /// </summary>
        public CompanyModel? Company { get; set; }

        /// <summary>
        /// The name of the user the activity is assigned to
        /// </summary>
        public string? UserAssignedToName { get; set; }

        /// <summary>
        /// All attachments attached to applied activity.
        ///
        /// To retrieve this collection, specify `Attachments` in the "Include" parameter for your query.
        /// </summary>
        public AttachmentModel[]? Attachments { get; set; }

        /// <summary>
        /// All notes attached to this applied activity.
        ///
        /// To retrieve this collection, specify `Notes` in the "Include" parameter for your query.
        /// </summary>
        public NoteModel[]? Notes { get; set; }

        /// <summary>
        /// All definitions attached to this applied activity.
        ///
        /// To retrieve this collection, specify `CustomFieldValues` in the "Include" parameter for your query.
        /// </summary>
        public CustomFieldDefinitionModel[]? CustomFieldDefinitions { get; set; }

        /// <summary>
        /// All values attached to this activity.
        ///
        /// To retrieve this collection, specify `CustomFieldValues` in the "Include" parameter for your query.
        /// </summary>
        public CustomFieldValueModel[]? CustomFieldValues { get; set; }

        /// <summary>
        /// All references attached to this applied activity.
        ///
        /// To retrieve this collection, specify `References` in the "Include" parameter for your query.
        /// </summary>
        public ActivityXRefModel[]? References { get; set; }
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
        public string? ActivityStreamType { get; set; }

        /// <summary>
        /// The text body description for this Activity Stream Item.
        /// </summary>
        public string? TextValue { get; set; }

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
        /// The sender's email address if activity stream item is an Email.
        /// </summary>
        public string? FromEmailAddress { get; set; }

        /// <summary>
        /// The recipient's email address if activity stream item is an Email.
        /// </summary>
        public string? ToEmailAddress { get; set; }

        /// <summary>
        /// The name of the contact sending the activity otherwise null.
        /// </summary>
        public string? FromContactName { get; set; }

        /// <summary>
        /// The name of the contact sending the activity otherwise null.
        /// </summary>
        public string? ToContactName { get; set; }
    }

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
        public string? TableKey { get; set; }

        /// <summary>
        /// The ID of the object the activity reference is associated with
        /// </summary>
        public string? ObjectKey { get; set; }
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
        public string? CurrencyCode { get; set; }

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
        public string? Environment { get; set; }

        /// <summary>
        /// The API key to use for authentication. This will only be returned upon creation of the API key.
        /// All other times, this value will be `null`.
        ///
        /// For more information, see [API Keys](https://developer.lockstep.io/docs/api-keys).
        /// </summary>
        public string? ApiKey { get; set; }

        /// <summary>
        /// The first 10 characters of the API key.  This information can be used to ensure that you are
        /// looking at the correct API Key, but cannot be used for authentication.
        /// </summary>
        public string? KeyPrefix { get; set; }

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
        public DateTime? Revoked { get; set; }

        /// <summary>
        /// The user who revoked the API key.
        /// </summary>
        public Guid? RevokedUserId { get; set; }

        /// <summary>
        /// The UTC datetime when the API key expires.
        /// </summary>
        public DateTime? Expires { get; set; }
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
        public string? Name { get; set; }

        /// <summary>
        /// Tag for what type of app the application is
        /// </summary>
        public string? AppType { get; set; }

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
        public string? CustomFieldLabel { get; set; }

        /// <summary>
        /// Data type of the custom field definition
        /// </summary>
        public string? DataType { get; set; }

        /// <summary>
        /// Used for display logic when multiple app enrollment custom fields exist
        /// </summary>
        public int SortOrder { get; set; }

        /// <summary>
        /// String of data for field
        /// </summary>
        public string? StringValue { get; set; }

        /// <summary>
        /// Number data for field
        /// </summary>
        public double? NumericValue { get; set; }
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
        /// about this Application object by specifying `App` in the "Include" parameter for your request.
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
        public string? CronSettings { get; set; }

        /// <summary>
        /// Flag indicating if the Sync process should be ran on the specified schedule
        /// </summary>
        public bool SyncScheduleIsActive { get; set; }

        /// <summary>
        /// The Application to which this AppEnrollment belongs.  Contains general name, description,
        /// logo, and other metadata about this application.
        ///
        /// To retrieve this object, specify `App` in the "Include" parameter for your query.
        /// </summary>
        public ApplicationModel? App { get; set; }

        /// <summary>
        /// All definitions attached to this app.
        ///
        /// To retrieve this collection, specify `CustomFieldValues` in the "Include" parameter for your query.
        /// </summary>
        public CustomFieldDefinitionModel[]? CustomFieldDefinitions { get; set; }

        /// <summary>
        /// All values attached to this app.
        ///
        /// To retrieve this collection, specify `CustomFieldValues` in the "Include" parameter for your query.
        /// </summary>
        public CustomFieldValueModel[]? CustomFieldValues { get; set; }

        /// <summary>
        /// Data about the last sync attached to this app enrollment
        ///
        /// To retrieve this collection, specify `LastSync` in the "Include" parameter for your query.
        /// </summary>
        public SyncRequestModel? LastSync { get; set; }

        /// <summary>
        /// Data about the last successful sync associated with this enrollment
        /// </summary>
        public SyncRequestModel? LastSuccessfulSync { get; set; }

        /// <summary>
        /// Optional data necessary to create an app enrollment for a supported connector.
        /// Only enter relevant fields for the given connector.
        /// </summary>
        public ConnectorInfoModel? ConnectorInfo { get; set; }
    }

    /// <summary>
    /// An Application represents a feature available to customers within the Lockstep Platform.  You can create
    /// Applications by working with your Lockstep business development manager and publish them on the platform
    /// so that customers can browse and find your Application on the Lockstep Platform Marketplace.  When a
    /// customer adds an Application to their account, they obtain an AppEnrollment which represents that customer's
    /// instance of this Application.  The customer-specific AppEnrollment contains a customer's configuration data
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
        public string? Name { get; set; }

        /// <summary>
        /// Brief summary of this application shown as a subtitle
        /// </summary>
        public string? Description { get; set; }

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
        public Uri? ProjectUrl { get; set; }

        /// <summary>
        /// The URL for the icon for this application
        /// </summary>
        public Uri? IconUrl { get; set; }

        /// <summary>
        /// The description of the price for this application
        /// </summary>
        public string? PriceTerms { get; set; }

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
        public bool IsActive { get; set; }

        /// <summary>
        /// URL to the Wiki for the Application
        /// </summary>
        public Uri? WikiURL { get; set; }

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid GroupKey { get; set; }

        /// <summary>
        /// All notes attached to this app.
        /// To retrieve this collection, specify `Notes` in the "Include" parameter for your query.
        /// </summary>
        public NoteModel[]? Notes { get; set; }

        /// <summary>
        /// All attachments attached to this app.
        /// To retrieve this collection, specify `Attachments` in the "Include" parameter for your query.
        /// </summary>
        public AttachmentModel[]? Attachments { get; set; }

        /// <summary>
        /// All definitions attached to the application.
        /// To retrieve this collection, specify `CustomFieldValues` in the "Include" parameter for your query.
        /// </summary>
        public CustomFieldDefinitionModel[]? CustomFieldDefinitions { get; set; }

        /// <summary>
        /// All values attached to the application.
        /// To retrieve this collection, specify `CustomFieldValues` in the "Include" parameter for your query.
        /// </summary>
        public CustomFieldValueModel[]? CustomFieldValues { get; set; }
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
        public string? ReportBucket { get; set; }

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
        public DateTime? ReportPeriod { get; set; }

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
        public DateTime? ReportDate { get; set; }

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
        public Guid? CustomerId { get; set; }

        /// <summary>
        /// The unique ID number of this invoice.
        /// </summary>
        public Guid InvoiceId { get; set; }

        /// <summary>
        /// A reference code that is used to identify this invoice.
        /// The meaning of this field is specific to the ERP or accounting system used by the user.
        /// </summary>
        public string? InvoiceNumber { get; set; }

        /// <summary>
        /// The reporting date for this invoice.
        /// </summary>
        public DateTime? InvoiceDate { get; set; }

        /// <summary>
        /// The name of the counterparty for the invoice, for example, a customer or vendor.
        /// </summary>
        public string? CustomerName { get; set; }

        /// <summary>
        /// The status of the invoice.
        /// </summary>
        public string? Status { get; set; }

        /// <summary>
        /// The due date of the invoice.
        /// </summary>
        public DateTime? PaymentDueDate { get; set; }

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
        public string? InvoiceTypeCode { get; set; }

        /// <summary>
        /// The date stamp for the newest Activity on this Invoice.
        /// </summary>
        public DateTime? NewestActivity { get; set; }

        /// <summary>
        /// The number of days this Invoice is past due.
        /// </summary>
        public int? DaysPastDue { get; set; }

        /// <summary>
        /// The memo text of the payments associated to this invoice.
        /// </summary>
        public string[]? PaymentNumbers { get; set; }

        /// <summary>
        /// The ids of the payments associated to this invoice.
        /// </summary>
        public Guid[]? PaymentIds { get; set; }
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
        public Guid? CompanyId { get; set; }

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
        public string? TableKey { get; set; }

        /// <summary>
        /// The ID of the object the attachment is associated with
        /// </summary>
        public Guid ObjectKey { get; set; }

        /// <summary>
        /// Name of the file
        /// </summary>
        public string? FileName { get; set; }

        /// <summary>
        /// Extension type of the file
        /// </summary>
        public string? FileExt { get; set; }

        /// <summary>
        /// Corresponding AttachmentType object to describe this attachment
        /// </summary>
        public Guid AttachmentTypeId { get; set; }

        /// <summary>
        /// Flag indicating the attachment was archived
        /// </summary>
        public bool IsArchived { get; set; }

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
        public string? ErpKey { get; set; }

        /// <summary>
        /// The AppEnrollmentId of the application that imported this attachment record.  For accounts
        /// with more than one financial system connected, this field identifies the originating
        /// financial system that produced this record.
        /// </summary>
        public Guid? AppEnrollmentId { get; set; }

        /// <summary>
        /// The date the attachment was created
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Id of the user who made the file
        /// </summary>
        public Guid CreatedUserId { get; set; }
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
        public CompanySyncModel[]? Companies { get; set; }

        /// <summary>
        /// A list of Contact records to merge with your Lockstep Platform data
        /// </summary>
        public ContactSyncModel[]? Contacts { get; set; }

        /// <summary>
        /// A list of CreditMemoApplied records to merge with your Lockstep Platform data
        /// </summary>
        public CreditMemoAppliedSyncModel[]? CreditMemoApplications { get; set; }

        /// <summary>
        /// A list of Invoice records to merge with your Lockstep Platform data
        /// </summary>
        public InvoiceSyncModel[]? Invoices { get; set; }

        /// <summary>
        /// A list of InvoiceLine records to merge with your Lockstep Platform data
        /// </summary>
        public InvoiceLineSyncModel[]? InvoiceLines { get; set; }

        /// <summary>
        /// A list of CustomField records to merge with your Lockstep Platform data
        /// </summary>
        public CustomFieldSyncModel[]? CustomFields { get; set; }

        /// <summary>
        /// A list of Payment records to merge with your Lockstep Platform data
        /// </summary>
        public PaymentSyncModel[]? Payments { get; set; }

        /// <summary>
        /// A list of PaymentApplied records to merge with your Lockstep Platform data
        /// </summary>
        public PaymentAppliedSyncModel[]? PaymentApplications { get; set; }
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
        public string? CodeType { get; set; }

        /// <summary>
        /// The Code to be defined.
        /// </summary>
        public string? Code { get; set; }

        /// <summary>
        /// The definition of the Code
        /// </summary>
        public string? CodeDescription { get; set; }

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
        public string? ErpKey { get; set; }

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
        public string? CompanyType { get; set; }

        /// <summary>
        /// The status of the company.  Companies can be either `Active` or `Inactive`.  When matched to a
        /// Lockstep corporate profile, this value will change to reflect that this record will be kept
        /// in sync with that company's identity.
        /// </summary>
        public string? CompanyStatus { get; set; }

        /// <summary>
        /// If this business entity is part of an organization, this value is non-null and it is set
        /// to the `CompanyId` value of the parent company of this business entity.
        ///
        /// If this value is null, this business entity is a standalone.
        /// </summary>
        public Guid? ParentCompanyId { get; set; }

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
        public string? DefaultCurrencyCode { get; set; }

        /// <summary>
        /// The URL of this company's logo, if known.
        /// </summary>
        public string? CompanyLogoUrl { get; set; }

        /// <summary>
        /// The Lockstep `ContactId` of the primary contact for this company.
        /// </summary>
        public Guid? PrimaryContactId { get; set; }

        /// <summary>
        /// Address info
        /// </summary>
        public string? Address1 { get; set; }

        /// <summary>
        /// Address info
        /// </summary>
        public string? Address2 { get; set; }

        /// <summary>
        /// Address info
        /// </summary>
        public string? Address3 { get; set; }

        /// <summary>
        /// Address info
        /// </summary>
        public string? City { get; set; }

        /// <summary>
        /// Address info
        /// </summary>
        public string? StateRegion { get; set; }

        /// <summary>
        /// Address info
        /// </summary>
        public string? PostalCode { get; set; }

        /// <summary>
        /// Address info
        /// </summary>
        public string? Country { get; set; }

        /// <summary>
        /// Phone number
        /// </summary>
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// Fax number
        /// </summary>
        public string? FaxNumber { get; set; }

        /// <summary>
        /// The date this company was created
        /// </summary>
        public DateTime? Created { get; set; }

        /// <summary>
        /// The ID of the user who created this company
        /// </summary>
        public Guid CreatedUserId { get; set; }

        /// <summary>
        /// The date this company was last modified
        /// </summary>
        public DateTime? Modified { get; set; }

        /// <summary>
        /// The ID of the user who last modified this company
        /// </summary>
        public Guid ModifiedUserId { get; set; }

        /// <summary>
        /// The name of the user who last modified this company
        /// </summary>
        public string? ModifiedUserName { get; set; }

        /// <summary>
        /// Federal Tax ID
        /// </summary>
        public string? TaxId { get; set; }

        /// <summary>
        /// Dun & Bradstreet Number
        /// </summary>
        public string? DunsNumber { get; set; }

        /// <summary>
        /// AP (Accounts Payable) Email Address
        /// </summary>
        public string? ApEmailAddress { get; set; }

        /// <summary>
        /// AR (Accounts Receivable) Email Address
        /// </summary>
        public string? ArEmailAddress { get; set; }

        /// <summary>
        /// For companies that use a custom domain name for their email system, this is
        /// the domain name used by this company.  If this value is known, new emails that
        /// come in from this domain will be connected to this company.
        /// </summary>
        public string? DomainName { get; set; }

        /// <summary>
        /// Identifier for classification of this company.
        /// </summary>
        public Guid? CompanyClassificationCodeDefId { get; set; }

        /// <summary>
        /// Description of the company.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Website URL for this company.
        /// </summary>
        public string? Website { get; set; }

        /// <summary>
        /// The AppEnrollmentId of the application that imported this company record.  For accounts
        /// with more than one financial system connected, this field identifies the originating
        /// financial system that produced this record.
        /// </summary>
        public Guid? AppEnrollmentId { get; set; }

        /// <summary>
        /// All notes attached to this company.
        ///
        /// To retrieve this collection, specify `Notes` in the "Include" parameter for your query.
        /// </summary>
        public NoteModel[]? Notes { get; set; }

        /// <summary>
        /// All attachments attached to this company.
        ///
        /// To retrieve this collection, specify `Attachments` in the "Include" parameter for your query.
        /// </summary>
        public AttachmentModel[]? Attachments { get; set; }

        /// <summary>
        /// All contacts attached to this company.
        ///
        /// To retrieve this collection, specify `Contacts` in the "Include" parameter for your query.
        /// </summary>
        public ContactModel[]? Contacts { get; set; }

        /// <summary>
        /// All invoices attached to this company.
        ///
        /// To retrieve this collection, specify `Invoices` in the "Include" parameter for your query. For more information on Invoices, see [InvoiceModel](https://developer.lockstep.io/reference/get_api-v1-invoices-id).
        /// </summary>
        public object[]? Invoices { get; set; }

        /// <summary>
        /// All definitions attached to this company.
        ///
        /// To retrieve this collection, specify `CustomFieldValues` in the "Include" parameter for your query.
        /// </summary>
        public CustomFieldDefinitionModel[]? CustomFieldDefinitions { get; set; }

        /// <summary>
        /// All values attached to this company.
        ///
        /// To retrieve this collection, specify `CustomFieldValues` in the "Include" parameter for your query.
        /// </summary>
        public CustomFieldValueModel[]? CustomFieldValues { get; set; }

        /// <summary>
        /// Classification code definition for this company.
        ///
        /// To retrieve this collection, specify `Classification` in the "Include" parameter for your query.
        /// </summary>
        public CodeDefinitionModel? CompanyClassificationCodeDefinition { get; set; }
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
        /// This is the primary key of the Company record. For this field, you should use whatever the company's unique
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
        public string? ErpKey { get; set; }

        /// <summary>
        /// A friendly, short name of the company.
        /// </summary>
        public string? CompanyName { get; set; }

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
        /// `Vendor`, `Third Party`, or `CustomerVendor`.  If you don't know what value to choose, select
        /// `CustomerVendor`.
        /// </summary>
        public string? CompanyType { get; set; }

        /// <summary>
        /// Either `Active` or `Inactive`.
        /// </summary>
        public string? CompanyStatus { get; set; }

        /// <summary>
        /// If this company has a parent company, identify the parent company's `ErpKey` value here. This value should
        /// be the original primary key or unique ID of the parent company to this company belongs. This value should
        /// match the original ErpKey field on the parent company.
        ///
        /// If this company is not a child company, leave this field null.
        /// </summary>
        public string? ParentCompanyErpKey { get; set; }

        /// <summary>
        /// This flag indicates whether the company is currently active. An inactive company will be hidden from the
        /// user interface but will still be available for querying.
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// The default currency code for transactions related to this company.  For a list of currency codes, see
        /// [Query Currencies](https://developer.lockstep.io/reference/get_api-v1-definitions-currencies). This will be validated by the /api/v1/currencies data set
        /// </summary>
        public string? DefaultCurrencyCode { get; set; }

        /// <summary>
        /// The URL of this company's logo, if known.
        /// </summary>
        public Uri? CompanyLogoUrl { get; set; }

        /// <summary>
        /// The `ErpKey` of the primary contact for this company.  This value should match the `ErpKey` value of the
        /// [Importing Contacts](https://developer.lockstep.io/docs/importing-contacts) record for the contact table.
        /// </summary>
        public string? PrimaryContactErpKey { get; set; }

        /// <summary>
        /// The company's primary mailing address information
        /// </summary>
        public string? Address1 { get; set; }

        /// <summary>
        /// The company's primary mailing address information
        /// </summary>
        public string? Address2 { get; set; }

        /// <summary>
        /// The company's primary mailing address information
        /// </summary>
        public string? Address3 { get; set; }

        /// <summary>
        /// The company's primary mailing address information
        /// </summary>
        public string? City { get; set; }

        /// <summary>
        /// The company's primary mailing address information
        /// </summary>
        public string? StateRegion { get; set; }

        /// <summary>
        /// The company's primary mailing address information
        /// </summary>
        public string? PostalCode { get; set; }

        /// <summary>
        /// The company's primary mailing address information This will be validated by the /api/v1/countries data set
        /// </summary>
        public string? Country { get; set; }

        /// <summary>
        /// The main phone number of this company.
        /// </summary>
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// The main fax number of this company.
        /// </summary>
        public string? FaxNumber { get; set; }

        /// <summary>
        /// If known, the date when this record was created according to the originating financial system
        /// in which this record is maintained.  If the originating financial system does not maintain a
        /// created-date, leave this field null.
        /// </summary>
        public DateTime? Created { get; set; }

        /// <summary>
        /// If known, the date when this record was most recently modified according to the originating
        /// financial system in which this record is maintained.  If the originating financial system does
        /// not maintain a most-recently-modified-date, leave this field null.
        /// </summary>
        public DateTime? Modified { get; set; }

        /// <summary>
        /// The company's Tax ID number for the appropriate government for this company.
        /// </summary>
        public string? TaxId { get; set; }

        /// <summary>
        /// The Dun and Bradstreet number for this company, if known.
        /// </summary>
        public string? DunsNumber { get; set; }

        /// <summary>
        /// If you know the AP (accounts payable) email address of this company, fill it in here. This is the email
        /// address where you would send questions to the company if the company owed you money.
        /// </summary>
        public string? ApEmailAddress { get; set; }

        /// <summary>
        /// If you know the AR (accounts receivable) email address of this company, fill it in here. This is the email
        /// address where you would send questions to the company if you owed this company money.
        /// </summary>
        public string? ArEmailAddress { get; set; }
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
        public string? AuthCode { get; set; }

        /// <summary>
        /// The realm id of the account being granted permissions to access
        /// </summary>
        public string? RealmId { get; set; }

        /// <summary>
        /// The redirect uri used for step one of the OAuth2.0 flow.
        /// </summary>
        public string? RedirectUri { get; set; }

        /// <summary>
        /// The email an email connection is being created for.
        /// </summary>
        public string? Email { get; set; }
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
        /// If this company record was imported from a financial system, it will have the value `ErpKey`
        /// set to the original primary key number of the record as it was known in the originating financial
        /// system.  If this record was not imported, this value will be `null`.
        ///
        /// For more information, see [Identity Columns](https://developer.lockstep.io/docs/identity-columns).
        /// </summary>
        public string? ErpKey { get; set; }

        /// <summary>
        /// The name of the contact.
        /// </summary>
        public string? ContactName { get; set; }

        /// <summary>
        /// A friendly human-readable code that describes this Contact.
        /// </summary>
        public string? ContactCode { get; set; }

        /// <summary>
        /// The title of the contact.
        /// </summary>
        public string? Title { get; set; }

        /// <summary>
        /// The role code for the contact.
        /// </summary>
        public string? RoleCode { get; set; }

        /// <summary>
        /// The email address of the contact.
        /// </summary>
        public string? EmailAddress { get; set; }

        /// <summary>
        /// The phone number of the contact.
        /// </summary>
        public string? Phone { get; set; }

        /// <summary>
        /// The fax number of the contact.
        /// </summary>
        public string? Fax { get; set; }

        /// <summary>
        /// The first line of the address.
        /// </summary>
        public string? Address1 { get; set; }

        /// <summary>
        /// The second line of the address.
        /// </summary>
        public string? Address2 { get; set; }

        /// <summary>
        /// The third line of the address.
        /// </summary>
        public string? Address3 { get; set; }

        /// <summary>
        /// The city of the address.
        /// </summary>
        public string? City { get; set; }

        /// <summary>
        /// The state/region of the address.
        /// </summary>
        public string? StateRegion { get; set; }

        /// <summary>
        /// The postal/zip code of the address.
        /// </summary>
        public string? PostalCode { get; set; }

        /// <summary>
        /// The two character country code of the address. This will be validated by the /api/v1/countries data set
        /// </summary>
        public string? CountryCode { get; set; }

        /// <summary>
        /// Flag indicating if the contact is active.
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// The webpage url of the contact.
        /// </summary>
        public Uri? WebpageUrl { get; set; }

        /// <summary>
        /// The picture/avatar url of the contact.
        /// </summary>
        public Uri? PictureUrl { get; set; }

        /// <summary>
        /// The date on which this record was created.
        /// </summary>
        public DateTime? Created { get; set; }

        /// <summary>
        /// The ID of the user who created this contact.
        /// </summary>
        public Guid CreatedUserId { get; set; }

        /// <summary>
        /// The date on which this record was last modified.
        /// </summary>
        public DateTime? Modified { get; set; }

        /// <summary>
        /// The ID of the user who last modified this contact.
        /// </summary>
        public Guid ModifiedUserId { get; set; }

        /// <summary>
        /// AppEnrollmentId for this record; used for mapping purposes.
        /// </summary>
        public Guid? AppEnrollmentId { get; set; }

        /// <summary>
        /// All notes attached to this company.
        /// To retrieve this collection, specify `Notes` in the "Include" parameter for your query.
        /// </summary>
        public NoteModel[]? Notes { get; set; }

        /// <summary>
        /// All attachments attached to this company.
        /// To retrieve this collection, specify `Attachments` in the "Include" parameter for your query.
        /// </summary>
        public AttachmentModel[]? Attachments { get; set; }

        /// <summary>
        /// All definitions attached to this contact.
        /// To retrieve this collection, specify `CustomFieldValues` in the "Include" parameter for your query.
        /// </summary>
        public CustomFieldDefinitionModel[]? CustomFieldDefinitions { get; set; }

        /// <summary>
        /// All values attached to this contact.
        /// To retrieve this collection, specify `Attachments` in the "Include" parameter for your query.
        /// </summary>
        public CustomFieldValueModel[]? CustomFieldValues { get; set; }
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
        /// This is the primary key of the Contact record. For this field, you should use whatever the contact's unique
        /// identifying number is in the originating system. Search for a unique, non-changing number within the
        /// originating financial system for this record.
        ///
        /// Example: If you store your contact records in a database, whatever the primary key for the contact table is
        /// in the database should be the "ErpKey".
        ///
        /// For more information, see [Identity Columns](https://developer.lockstep.io/docs/identity-columns).
        /// </summary>
        public string? ErpKey { get; set; }

        /// <summary>
        /// The original primary key or unique ID of the company to which this contact belongs.  This value should
        /// match the [Company ErpKey](https://developer.lockstep.io/docs/importing-companies#erpkey) field on the
        /// [CompanySyncModel](https://developer.lockstep.io/docs/importing-companies).
        /// </summary>
        public string? CompanyErpKey { get; set; }

        /// <summary>
        /// The name of the contact.
        /// </summary>
        public string? ContactName { get; set; }

        /// <summary>
        /// A friendly human-readable code that describes this Contact.
        /// </summary>
        public string? ContactCode { get; set; }

        /// <summary>
        /// The title of the contact.
        /// </summary>
        public string? Title { get; set; }

        /// <summary>
        /// The role code for the contact.
        /// </summary>
        public string? RoleCode { get; set; }

        /// <summary>
        /// The email address of the contact.
        /// </summary>
        public string? EmailAddress { get; set; }

        /// <summary>
        /// The phone number of the contact.
        /// </summary>
        public string? Phone { get; set; }

        /// <summary>
        /// The fax number of the contact.
        /// </summary>
        public string? Fax { get; set; }

        /// <summary>
        /// The mailing address information for this contact.
        /// </summary>
        public string? Address1 { get; set; }

        /// <summary>
        /// The mailing address information for this contact.
        /// </summary>
        public string? Address2 { get; set; }

        /// <summary>
        /// The mailing address information for this contact.
        /// </summary>
        public string? Address3 { get; set; }

        /// <summary>
        /// The mailing address information for this contact.
        /// </summary>
        public string? City { get; set; }

        /// <summary>
        /// The mailing address information for this contact.
        /// </summary>
        public string? StateRegion { get; set; }

        /// <summary>
        /// The mailing address information for this contact.
        /// </summary>
        public string? PostalCode { get; set; }

        /// <summary>
        /// The mailing address information for this contact. This will be validated by the /api/v1/countries data set
        /// </summary>
        public string? CountryCode { get; set; }

        /// <summary>
        /// True if this contact is considered "active".
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// A webpage URL for more information about this contact.
        /// </summary>
        public Uri? WebpageUrl { get; set; }

        /// <summary>
        /// If available, the URL of a photograph that shows this contact.
        /// </summary>
        public Uri? PictureUrl { get; set; }

        /// <summary>
        /// If known, the date when this record was created according to the originating financial system
        /// in which this record is maintained.  If the originating financial system does not maintain a
        /// created-date, leave this field null.
        /// </summary>
        public DateTime? Created { get; set; }

        /// <summary>
        /// If known, the date when this record was most recently modified according to the originating
        /// financial system in which this record is maintained.  If the originating financial system does
        /// not maintain a most-recently-modified-date, leave this field null.
        /// </summary>
        public DateTime? Modified { get; set; }
    }

    /// <summary>
    /// Country model for ISO-3166
    /// </summary>
    public class CountryModel
    {

        /// <summary>
        /// Name of the country
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// 2 letter alphabetic code for the given country
        /// </summary>
        public string? Alpha2 { get; set; }

        /// <summary>
        /// 3 letter alphabetic code for the given country
        /// </summary>
        public string? Alpha3 { get; set; }

        /// <summary>
        /// Unique 3 digit number for the given country
        /// </summary>
        public int CountryCode { get; set; }

        /// <summary>
        /// Region of the country
        /// </summary>
        public string? Region { get; set; }

        /// <summary>
        /// Subregion of the country
        /// </summary>
        public string? SubRegion { get; set; }

        /// <summary>
        /// Intermediate region of the country
        /// </summary>
        public string? IntermediateRegion { get; set; }

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
        public string? FrenchName { get; set; }

        /// <summary>
        /// A different name for a country
        /// </summary>
        public string? Aliases { get; set; }
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
        /// The Lockstep ID of the Invoice to which this credit memo was applied.  This Invoice's outstanding balance
        /// was reduced by the value of the field `CreditMemoAppliedAmount` on the date `ApplyToInvoiceDate`.
        ///
        /// Example: Company ABC received a credit memo, CM000123 for $500.  Company ABC then chooses to apply this
        /// credit memo to reduce the balance of the invoice PO1000578.  The `InvoiceErpKey` is the Lockstep Platform
        /// ID number of Invoice `PO1000578`.
        /// </summary>
        public Guid InvoiceId { get; set; }

        /// <summary>
        /// The Lockstep ID of the Invoice of type "Credit Memo" that was consumed in this payment application event.
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
        public string? ErpKey { get; set; }

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
        /// AppEnrollmentId for this record; used for mapping purposes.
        /// </summary>
        public Guid? AppEnrollmentId { get; set; }

        /// <summary>
        /// All attachments attached to applied Credit Memo.
        /// To retrieve this collection, specify `Attachments` in the "Include" parameter for your query.
        /// </summary>
        public AttachmentModel[]? Attachments { get; set; }

        /// <summary>
        /// All notes attached to this applied Credit Memo.
        ///
        /// To retrieve this collection, specify `Notes` in the "Include" parameter for your query.
        /// </summary>
        public NoteModel[]? Notes { get; set; }

        /// <summary>
        /// All definitions attached to this applied Credit Memo.
        ///
        /// To retrieve this collection, specify `CustomFields` in the "Include" parameter for your query.
        /// </summary>
        public CustomFieldDefinitionModel[]? CustomFieldDefinitions { get; set; }

        /// <summary>
        /// All values attached to this Credit Memo.
        ///
        /// To retrieve this collection, specify `CustomFields` in the "Include" parameter for your query.
        /// </summary>
        public CustomFieldValueModel[]? CustomFieldValues { get; set; }
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
        /// transaction's unique identifying number is in the originating system. Search for a unique, non-changing
        /// number within the originating financial system for this record.
        ///
        /// Since Credit Memo Applications are often considered transactions, a typical value to look for will be
        /// the transaction ID number, the payment confirmation number, or some other record of this payment.
        ///
        /// For more information, see [Identity Columns](https://developer.lockstep.io/docs/identity-columns).
        /// </summary>
        public string? ErpKey { get; set; }

        /// <summary>
        /// This field indicates which Invoice had its balanced reduced by applying a credit memo.  In this field,
        /// identify the original primary key or unique ID of the Invoice which had its balanced reduced.
        ///
        /// Example: Company ABC received a credit memo, CM000123 for $500.  Company ABC then chooses to apply this
        /// credit memo to reduce the balance of the invoice PO1000578.  The `InvoiceErpKey` is `PO1000578`.
        /// </summary>
        public string? InvoiceErpKey { get; set; }

        /// <summary>
        /// This field indicates which Invoice is the original credit memo that was used to make this payment
        /// application event.  In this field, identify the original primary key or unique ID of the Invoice which
        /// created the credit memo that was consumed in this event.
        ///
        /// Example: Company ABC received a credit memo, CM000123 for $500.  Company ABC then chooses to apply this
        /// credit memo to reduce the balance of the invoice PO1000578.  The `CreditMemoInvoiceErpKey` is `CM000123`.
        /// </summary>
        public string? CreditMemoInvoiceErpKey { get; set; }

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
        public DateTime? Created { get; set; }

        /// <summary>
        /// If known, the date when this record was most recently modified according to the originating
        /// financial system in which this record is maintained.  If the originating financial system does
        /// not maintain a most-recently-modified-date, leave this field null.
        /// </summary>
        public DateTime? Modified { get; set; }
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
        public DateTime? ApplyToInvoiceDate { get; set; }

        /// <summary>
        /// Amount applied to credit memo.
        /// </summary>
        public double CreditMemoAppliedAmount { get; set; }

        /// <summary>
        /// An additional reference code that is sometimes used to identify this invoice.
        /// The meaning of this field is specific to the ERP or accounting system used by the user.
        /// </summary>
        public string? ReferenceCode { get; set; }

        /// <summary>
        /// The ID number of the company that created this invoice.
        /// </summary>
        public Guid? CompanyId { get; set; }

        /// <summary>
        /// The ID number of the counterparty for the invoice, for example, a customer or vendor.
        /// </summary>
        public Guid? CustomerId { get; set; }

        /// <summary>
        /// A code identifying the status of this invoice.
        /// </summary>
        public string? InvoiceStatusCode { get; set; }

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
        public string? AlphaCode { get; set; }

        /// <summary>
        /// Numeric code for the given currency
        /// </summary>
        public string? NumericCode { get; set; }

        /// <summary>
        /// Name of currency
        /// </summary>
        public string? CurrencyName { get; set; }

        /// <summary>
        /// Number of places after the decimal for this currency
        /// </summary>
        public int MinorUnit { get; set; }

        /// <summary>
        /// Symbol for the given currency
        /// </summary>
        public string? Symbol { get; set; }
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
        public string? Name { get; set; }

        /// <summary>
        /// Customer address info
        /// </summary>
        public string? Address1 { get; set; }

        /// <summary>
        /// Customer address info
        /// </summary>
        public string? Address2 { get; set; }

        /// <summary>
        /// Customer address info
        /// </summary>
        public string? Address3 { get; set; }

        /// <summary>
        /// Customer address info
        /// </summary>
        public string? City { get; set; }

        /// <summary>
        /// Customer address info
        /// </summary>
        public string? State { get; set; }

        /// <summary>
        /// Customer address info
        /// </summary>
        public string? PostalCode { get; set; }

        /// <summary>
        /// Customer address country
        /// </summary>
        public string? Country { get; set; }

        /// <summary>
        /// Customer phone number
        /// </summary>
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// Customer fax number
        /// </summary>
        public string? FaxNumber { get; set; }

        /// <summary>
        /// Customer AR email address
        /// </summary>
        public string? Email { get; set; }

        /// <summary>
        /// Customer primary contact id
        /// </summary>
        public Guid ContactId { get; set; }

        /// <summary>
        /// Customer primary contact name
        /// </summary>
        public string? ContactName { get; set; }

        /// <summary>
        /// Customer primary contact email address
        /// </summary>
        public string? ContactEmail { get; set; }

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
        public CustomerDetailsPaymentModel[]? Payments { get; set; }
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
        public Guid? PaymentAppliedId { get; set; }

        /// <summary>
        /// Payment type
        /// </summary>
        public string? PaymentType { get; set; }

        /// <summary>
        /// Unique identifier for invoice payment is associated with
        /// </summary>
        public Guid? InvoiceId { get; set; }

        /// <summary>
        /// Invoice type payment is associated with
        /// </summary>
        public string? InvoiceTypeCode { get; set; }

        /// <summary>
        /// Invoice reference code payment is associated with
        /// </summary>
        public string? InvoiceReferenceCode { get; set; }

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
        public string? CompanyName { get; set; }

        /// <summary>
        /// The name of the primary contact.
        /// </summary>
        public string? PrimaryContact { get; set; }

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
        public DateTime? NewestActivity { get; set; }
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
        public string? TableKey { get; set; }

        /// <summary>
        /// Id of app this definition belongs to
        /// </summary>
        public Guid? AppId { get; set; }

        /// <summary>
        /// Text to display in-application for custom field
        /// </summary>
        public string? CustomFieldLabel { get; set; }

        /// <summary>
        /// Data type of this definition
        /// </summary>
        public string? DataType { get; set; }

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
        /// AppEnrollmentId for this record; used for mapping purposes.
        /// </summary>
        public Guid? AppEnrollmentId { get; set; }
    }

    /// <summary>
    /// The CustomFieldSyncModel represents information coming into Lockstep from an external financial system or other
    /// enterprise resource planning system.  [Custom Fields](https://developer.lockstep.io/docs/custom-fields#custom-fields)
    /// represent custom data extensions that you can use with the Lockstep Platform.  If you need to store extra
    /// information about an object that does not match Lockstep's official schema, you can store it in the Custom
    /// Field system using CustomFieldSyncModel.
    ///
    /// To store a custom field for an object, create a CustomFieldSyncModel record containing the `EntityType` and
    /// `ErpKey` of the entity to which you will attach a custom field. Next specify the field's `CustomFieldLabel`
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
        /// invoice named "ApprovalStatusCode".  For the `ErpKey` field, specify the value `100047878`.
        ///
        /// For more information, see [Identity Columns](https://developer.lockstep.io/docs/identity-columns).
        /// </summary>
        public string? ErpKey { get; set; }

        /// <summary>
        /// Custom Fields are identified by the `EntityType` and `ErpKey` values together.
        ///
        /// Example: You have an invoice whose ID number is 100047878, and you wish to store a custom field on that
        /// invoice named "ApprovalStatusCode".  For the `EntityType` field, specify the value `Invoice`.
        ///
        /// Recognized types include:
        /// * `Company` - Link this custom field to a CompanySyncModel
        /// * `Contact` - Link this custom field to a ContactSyncModel
        /// * `Invoice` - Link this custom field to an InvoiceSyncModel
        /// * `InvoiceLine` - Link this custom field to an InvoiceLineSyncModel
        /// * `Payment` - Link this custom field to a PaymentSyncModel
        /// </summary>
        public string? EntityType { get; set; }

        /// <summary>
        /// A label that uniquely identifies this custom field within your software.
        ///
        /// Example: You have an invoice whose ID number is 100047878, and you wish to store a custom field on that
        /// invoice named "ApprovalStatusCode".  For the `CustomFieldLabel` field, specify the value `ApprovalStatusCode`.
        /// </summary>
        public string? CustomFieldLabel { get; set; }

        /// <summary>
        /// The value of this custom field, if it is stored in string format.
        /// </summary>
        public string? StringValue { get; set; }

        /// <summary>
        /// The value of this custom field, if it is stored in numeric format.
        /// </summary>
        public double? NumericValue { get; set; }

        /// <summary>
        /// If known, the date when this record was created according to the originating financial system
        /// in which this record is maintained.  If the originating financial system does not maintain a
        /// created-date, leave this field null.
        /// </summary>
        public DateTime? Created { get; set; }

        /// <summary>
        /// If known, the date when this record was most recently modified according to the originating
        /// financial system in which this record is maintained.  If the originating financial system does
        /// not maintain a most-recently-modified-date, leave this field null.
        /// </summary>
        public DateTime? Modified { get; set; }
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
        /// Additional key if source table doesn't have a unique id
        /// </summary>
        public Guid RecordKey { get; set; }

        /// <summary>
        /// String of data for field
        /// </summary>
        public string? StringValue { get; set; }

        /// <summary>
        /// Number data for field
        /// </summary>
        public double? NumericValue { get; set; }

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
        /// AppEnrollmentId for this record; used for mapping purposes.
        /// </summary>
        public Guid? AppEnrollmentId { get; set; }

        /// <summary>
        /// Definition of the value
        /// </summary>
        public CustomFieldDefinitionModel? CustomFieldDefinition { get; set; }
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
    /// by the `CompanyId` field, recipient(s) by the `EmailTo` field, and cc recipient(s) by the 'EmailCC' field.
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
        /// The unique ID number of this email's conversation thread.
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
        public Guid? CompanyId { get; set; }

        /// <summary>
        /// The email address for the sender of this email.
        /// </summary>
        public string? EmailFrom { get; set; }

        /// <summary>
        /// The email address for the recipient(s) of this email.
        /// </summary>
        public string? EmailTo { get; set; }

        /// <summary>
        /// The email address for the CC recipient(s) of this email
        /// </summary>
        public string? EmailCC { get; set; }

        /// <summary>
        /// The subject line of this email.
        /// </summary>
        public string? EmailSubject { get; set; }

        /// <summary>
        /// The body content of this email.
        /// </summary>
        public string? EmailBody { get; set; }

        /// <summary>
        /// The date on which this email was sent.
        /// </summary>
        public DateTime? SentDate { get; set; }

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
        public int ViewCount { get; set; }

        /// <summary>
        /// AppEnrollmentId for this record; used for mapping purposes.
        /// </summary>
        public Guid? AppEnrollmentId { get; set; }

        /// <summary>
        /// The id of the email in an external system if imported.
        /// </summary>
        public string? ExternalEmailId { get; set; }

        /// <summary>
        /// The id of the email thread in an external system if imported.
        /// </summary>
        public string? ExternalThreadId { get; set; }

        /// <summary>
        /// The email address(es) for the BCC recipient(s) of this email
        /// </summary>
        public string? EmailBcc { get; set; }

        /// <summary>
        /// The type message being sent (New, Reply, Forward) or null for messages not being sent.
        /// </summary>
        public string? SendType { get; set; }

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
        public Guid? ResponseOriginId { get; set; }

        /// <summary>
        /// The email object associated with the response origin id.
        /// </summary>
        public EmailModel? ResponseOrigin { get; set; }

        /// <summary>
        /// All notes attached to this email.
        /// To retrieve this collection, specify `Notes` in the "Include" parameter for your query.
        /// </summary>
        public NoteModel[]? Notes { get; set; }

        /// <summary>
        /// All attachments attached to this email.
        /// To retrieve this collection, specify `Attachments` in the "Include" parameter for your query.
        /// </summary>
        public AttachmentModel[]? Attachments { get; set; }

        /// <summary>
        /// All definitions attached to this email.
        /// To retrieve this collection, specify `CustomFieldValues` in the "Include" parameter for your query.
        /// </summary>
        public CustomFieldDefinitionModel[]? CustomFieldDefinitions { get; set; }

        /// <summary>
        /// All values attached to this email.
        /// To retrieve this collection, specify `Attachments` in the "Include" parameter for your query.
        /// </summary>
        public CustomFieldValueModel[]? CustomFieldValues { get; set; }
    }

    /// <summary>
    /// Represents all the possible data sent as a part of the provisioning post.
    /// Only send required fields for the given connector.
    /// </summary>
    public class ErpInfoDataModel
    {

        /// <summary>
        /// The authorization code returned from the first step of the OAuth2 flow
        /// https://oauth.net/2/grant-types/authorization-code/
        /// </summary>
        public string? AuthCode { get; set; }

        /// <summary>
        /// The realm id of the account being granted permissions to access
        /// </summary>
        public string? RealmId { get; set; }

        /// <summary>
        /// The redirect uri used for step one of the OAuth2.0 flow.
        /// </summary>
        public string? RedirectUri { get; set; }
    }

    /// <summary>
    /// Represents the ERP object sent in a provisioning request
    /// </summary>
    public class ErpInfoModel
    {

        /// <summary>
        /// The id of the ERP's App
        /// </summary>
        public Guid AppId { get; set; }

        /// <summary>
        /// The data required to store for connector access
        /// </summary>
        public ConnectorInfoModel? Data { get; set; }
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
        public string? Name { get; set; }

        /// <summary>
        /// Flag to indicate if ERP is supported
        /// </summary>
        public bool IsSupported { get; set; }
    }

    /// <summary>
    /// Model containing information about a user for the invite/onboarding process.
    /// </summary>
    public class InviteDataModel
    {

        /// <summary>
        /// The email address of the invited user.
        /// </summary>
        public string? Email { get; set; }

        /// <summary>
        /// The status of the user.
        /// </summary>
        public string? UserStatus { get; set; }
    }

    /// <summary>
    /// Model from the User invite process
    /// </summary>
    public class InviteModel
    {

        /// <summary>
        /// The invited email address
        /// </summary>
        public string? Email { get; set; }

        /// <summary>
        /// True if the invite was sent successfully
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// The invited user, may be null if the user could not be invited
        /// </summary>
        public UserAccountModel? InvitedUser { get; set; }

        /// <summary>
        /// The error message if the invite was not successful
        /// </summary>
        public string? ErrorMessage { get; set; }
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
        public string? Line1 { get; set; }

        /// <summary>
        /// The second line of the address.
        /// </summary>
        public string? Line2 { get; set; }

        /// <summary>
        /// The third line of the address.
        /// </summary>
        public string? Line3 { get; set; }

        /// <summary>
        /// The name of the city for this address.
        /// </summary>
        public string? City { get; set; }

        /// <summary>
        /// The state or region part of this address.
        /// </summary>
        public string? Region { get; set; }

        /// <summary>
        /// The postal code for this address.
        /// </summary>
        public string? PostalCode { get; set; }

        /// <summary>
        /// The country for this address.
        /// </summary>
        public string? Country { get; set; }

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
        public DateTime? Created { get; set; }

        /// <summary>
        /// The ID number of the user who created this address.
        /// </summary>
        public Guid? CreatedUserId { get; set; }

        /// <summary>
        /// The date on which this address record was last modified.
        /// </summary>
        public DateTime? Modified { get; set; }

        /// <summary>
        /// The ID number of the user who most recently modified this address.
        /// </summary>
        public Guid? ModifiedUserId { get; set; }
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
        public string? ErpKey { get; set; }

        /// <summary>
        /// The purchase order code as it exists in the user's ERP or accounting system.
        /// </summary>
        public string? PurchaseOrderCode { get; set; }

        /// <summary>
        /// An additional reference code that is sometimes used to identify this invoice.
        /// The meaning of this field is specific to the ERP or accounting system used by the user.
        /// </summary>
        public string? ReferenceCode { get; set; }

        /// <summary>
        /// A code identifying the salesperson responsible for writing this invoice.
        /// </summary>
        public string? SalespersonCode { get; set; }

        /// <summary>
        /// A string identifying the salesperson responsible for writing this invoice.
        /// </summary>
        public string? SalespersonName { get; set; }

        /// <summary>
        /// A code identifying the type of this invoice.
        /// </summary>
        public string? InvoiceTypeCode { get; set; }

        /// <summary>
        /// A code identifying the status of this invoice.
        /// </summary>
        public string? InvoiceStatusCode { get; set; }

        /// <summary>
        /// A code identifying the terms given to the purchaser.
        /// </summary>
        public string? TermsCode { get; set; }

        /// <summary>
        /// If the customer negotiated any special terms different from the standard terms above, describe them here.
        /// </summary>
        public string? SpecialTerms { get; set; }

        /// <summary>
        /// The three-character ISO 4217 currency code used for this invoice. This will be validated by the /api/v1/currencies data set
        /// </summary>
        public string? CurrencyCode { get; set; }

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
        public DateTime? InvoiceDate { get; set; }

        /// <summary>
        /// The date when discounts were adjusted for this invoice.
        /// </summary>
        public DateTime? DiscountDate { get; set; }

        /// <summary>
        /// The date when this invoice posted to the company's general ledger.
        /// </summary>
        public DateTime? PostedDate { get; set; }

        /// <summary>
        /// The date when the invoice was closed and finalized after completion of all payments and delivery of all products and
        /// services.
        /// </summary>
        public DateTime? InvoiceClosedDate { get; set; }

        /// <summary>
        /// The date when the remaining outstanding balance is due.
        /// </summary>
        public DateTime? PaymentDueDate { get; set; }

        /// <summary>
        /// The date and time when this record was imported from the user's ERP or accounting system.
        /// </summary>
        public DateTime? ImportedDate { get; set; }

        /// <summary>
        /// The ID number of the invoice's origination address
        /// </summary>
        public Guid? PrimaryOriginAddressId { get; set; }

        /// <summary>
        /// The ID number of the invoice's bill-to address
        /// </summary>
        public Guid? PrimaryBillToAddressId { get; set; }

        /// <summary>
        /// The ID number of the invoice's ship-to address
        /// </summary>
        public Guid? PrimaryShipToAddressId { get; set; }

        /// <summary>
        /// The date on which this invoice record was created.
        /// </summary>
        public DateTime? Created { get; set; }

        /// <summary>
        /// The ID number of the user who created this invoice.
        /// </summary>
        public Guid? CreatedUserId { get; set; }

        /// <summary>
        /// The date on which this invoice record was last modified.
        /// </summary>
        public DateTime? Modified { get; set; }

        /// <summary>
        /// The ID number of the user who most recently modified this invoice.
        /// </summary>
        public Guid? ModifiedUserId { get; set; }
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
        public string? ErpKey { get; set; }

        /// <summary>
        /// The line number of this line, as defined in the originating ERP or accounting system.  You can sort on this number to
        /// get the original view of lines within the invoice.
        /// </summary>
        public string? LineNumber { get; set; }

        /// <summary>
        /// A code number identifying the product or service that is specified on this line.
        /// </summary>
        public string? ProductCode { get; set; }

        /// <summary>
        /// Description of this invoice line.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// For lines measured in a unit other than "quantity", this code indicates the measurement system for the quantity field.
        /// If the line is measured in quantity, this field is null.
        /// </summary>
        public string? UnitMeasureCode { get; set; }

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
        public string? ExemptionCode { get; set; }

        /// <summary>
        /// If null, the products specified on this line were delivered on the same date as all other lines.
        /// If not null, this line was delivered or finalized on a different date than the overall invoice.
        /// </summary>
        public DateTime? ReportingDate { get; set; }

        /// <summary>
        /// An optional ID number for the line's origin address.
        /// </summary>
        public Guid? OverrideOriginAddressId { get; set; }

        /// <summary>
        /// An optional ID number for the line's bill to address.
        /// </summary>
        public Guid? OverrideBillToAddressId { get; set; }

        /// <summary>
        /// An optional ID number for the line's ship to address.
        /// </summary>
        public Guid? OverrideShipToAddressId { get; set; }

        /// <summary>
        /// The date on which this line was created.
        /// </summary>
        public DateTime? Created { get; set; }

        /// <summary>
        /// The ID number of the user who created this line.
        /// </summary>
        public Guid? CreatedUserId { get; set; }

        /// <summary>
        /// The date on which this line was last modified.
        /// </summary>
        public DateTime? Modified { get; set; }

        /// <summary>
        /// The ID number of the user who most recently modified this line.
        /// </summary>
        public Guid? ModifiedUserId { get; set; }

        /// <summary>
        /// AppEnrollmentId for this record; used for mapping purposes.
        /// </summary>
        public Guid? AppEnrollmentId { get; set; }

        /// <summary>
        /// All notes attached to this company.
        /// To retrieve this collection, specify `Notes` in the "Include" parameter for your query.
        /// </summary>
        public NoteModel[]? Notes { get; set; }

        /// <summary>
        /// All attachments attached to this company.
        /// To retrieve this collection, specify `Attachments` in the "Include" parameter for your query.
        /// </summary>
        public AttachmentModel[]? Attachments { get; set; }
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
        /// This is the primary key of the Invoice Line record. For this field, you should use whatever the contact's unique
        /// identifying number is in the originating system. Search for a unique, non-changing number within the
        /// originating financial system for this record.
        ///
        /// Example: If you store your invoice line records in a database, whatever the primary key for the invoice
        /// line table is in the database should be the "ErpKey".
        ///
        /// For more information, see [Identity Columns](https://developer.lockstep.io/docs/identity-columns).
        /// </summary>
        public string? ErpKey { get; set; }

        /// <summary>
        /// The original primary key or unique ID of the invoice to which this line belongs.  This value should
        /// match the [Invoice ErpKey](https://developer.lockstep.io/docs/importing-invoices#erpkey) field on the
        /// [InvoiceSyncModel](https://developer.lockstep.io/docs/importing-invoices).
        /// </summary>
        public string? InvoiceErpKey { get; set; }

        /// <summary>
        /// The line number of this line, as defined in the originating ERP or accounting system.  You can sort on this number to
        /// get the original view of lines within the invoice.
        /// </summary>
        public string? LineNumber { get; set; }

        /// <summary>
        /// A code number identifying the product or service that is specified on this line.
        /// </summary>
        public string? ProductCode { get; set; }

        /// <summary>
        /// Description of this invoice line.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// For lines measured in a unit other than "quantity", this code indicates the measurement system for the quantity field.
        /// If the line is measured in quantity, this field is null.
        /// </summary>
        public string? UnitMeasureCode { get; set; }

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
        public string? ExemptionCode { get; set; }

        /// <summary>
        /// If null, the products specified on this line were delivered on the same date as all other lines.
        /// If not null, this line was delivered or finalized on a different date than the overall invoice.
        /// </summary>
        public DateTime? ReportingDate { get; set; }

        /// <summary>
        /// Origination address for this invoice line, if this line item was originated from a different address
        /// </summary>
        public string? OriginAddressLine1 { get; set; }

        /// <summary>
        /// Origination address for this invoice line, if this line item was originated from a different address
        /// </summary>
        public string? OriginAddressLine2 { get; set; }

        /// <summary>
        /// Origination address for this invoice line, if this line item was originated from a different address
        /// </summary>
        public string? OriginAddressLine3 { get; set; }

        /// <summary>
        /// Origination address for this invoice line, if this line item was originated from a different address
        /// </summary>
        public string? OriginAddressCity { get; set; }

        /// <summary>
        /// Origination address for this invoice line, if this line item was originated from a different address
        /// </summary>
        public string? OriginAddressRegion { get; set; }

        /// <summary>
        /// Origination address for this invoice line, if this line item was originated from a different address
        /// </summary>
        public string? OriginAddressPostalCode { get; set; }

        /// <summary>
        /// Origination address for this invoice line, if this line item was originated from a different address This will be validated by the /api/v1/countries data set
        /// </summary>
        public string? OriginAddressCountry { get; set; }

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
        public string? BillToAddressLine1 { get; set; }

        /// <summary>
        /// Billing address for this invoice line, if this line item is to be billed to a different address
        /// </summary>
        public string? BillToAddressLine2 { get; set; }

        /// <summary>
        /// Billing address for this invoice line, if this line item is to be billed to a different address
        /// </summary>
        public string? BillToAddressLine3 { get; set; }

        /// <summary>
        /// Billing address for this invoice line, if this line item is to be billed to a different address
        /// </summary>
        public string? BillToAddressCity { get; set; }

        /// <summary>
        /// Billing address for this invoice line, if this line item is to be billed to a different address
        /// </summary>
        public string? BillToAddressRegion { get; set; }

        /// <summary>
        /// Billing address for this invoice line, if this line item is to be billed to a different address
        /// </summary>
        public string? BillToAddressPostalCode { get; set; }

        /// <summary>
        /// Billing address for this invoice line, if this line item is to be billed to a different address This will be validated by the /api/v1/countries data set
        /// </summary>
        public string? BillToAddressCountry { get; set; }

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
        public string? ShipToAddressLine1 { get; set; }

        /// <summary>
        /// Shipping address for this invoice line, if this line item is to be shipped to a different address
        /// </summary>
        public string? ShipToAddressLine2 { get; set; }

        /// <summary>
        /// Shipping address for this invoice line, if this line item is to be shipped to a different address
        /// </summary>
        public string? ShipToAddressLine3 { get; set; }

        /// <summary>
        /// Shipping address for this invoice line, if this line item is to be shipped to a different address
        /// </summary>
        public string? ShipToAddressCity { get; set; }

        /// <summary>
        /// Shipping address for this invoice line, if this line item is to be shipped to a different address
        /// </summary>
        public string? ShipToAddressRegion { get; set; }

        /// <summary>
        /// Shipping address for this invoice line, if this line item is to be shipped to a different address
        /// </summary>
        public string? ShipToAddressPostalCode { get; set; }

        /// <summary>
        /// Shipping address for this invoice line, if this line item is to be shipped to a different address This will be validated by the /api/v1/countries data set
        /// </summary>
        public string? ShipToAddressCountry { get; set; }

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
        public DateTime? Created { get; set; }

        /// <summary>
        /// If known, the date when this record was most recently modified according to the originating
        /// financial system in which this record is maintained.  If the originating financial system does
        /// not maintain a most-recently-modified-date, leave this field null.
        /// </summary>
        public DateTime? Modified { get; set; }
    }

    /// <summary>
    /// An Invoice represents a bill sent from one company to another.  The creator of the invoice is identified
    /// by the `CompanyId` field, and the recipient of the invoice is identified by the `CustomerId` field.  Most
    /// invoices are uniquely identified both by a Lockstep Platform ID number and a customer ERP "key" that was
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
        public string? ErpKey { get; set; }

        /// <summary>
        /// The "Purchase Order Code" is a code that is sometimes used by companies to refer to the original PO
        /// that was sent that caused this invoice to be written.  If a customer sends a purchase order to a vendor,
        /// the vendor can then create an invoice and refer back to the originating purchase order using this field.
        /// </summary>
        public string? PurchaseOrderCode { get; set; }

        /// <summary>
        /// An additional reference code that is sometimes used to identify this invoice.
        /// The meaning of this field is specific to the ERP or accounting system used by the user.
        /// </summary>
        public string? ReferenceCode { get; set; }

        /// <summary>
        /// A code identifying the salesperson responsible for writing this quote, invoice, or order.
        /// </summary>
        public string? SalespersonCode { get; set; }

        /// <summary>
        /// A name identifying the salesperson responsible for writing this quote, invoice, or order.
        /// </summary>
        public string? SalespersonName { get; set; }

        /// <summary>
        /// A code identifying the type of this invoice.
        ///
        /// Recognized Invoice types are:
        /// * `Invoice` - Represents an invoice sent by Company to the Customer
        /// * `AP Invoice` - Represents an invoice sent by Customer to the Company
        /// * `Credit Memo` - Represents a credit memo generated by Customer given to Company
        /// </summary>
        public string? InvoiceTypeCode { get; set; }

        /// <summary>
        /// A code identifying the status of this invoice.
        ///
        /// Recognized Invoice status codes are:
        /// * `Open` - Represents an invoice that is considered open and needs more work to complete
        /// * `Closed` - Represents an invoice that is considered closed and resolved
        /// </summary>
        public string? InvoiceStatusCode { get; set; }

        /// <summary>
        /// A code identifying the terms given to the purchaser.  This field is imported directly from the originating
        /// financial system and does not follow a specified format.
        /// </summary>
        public string? TermsCode { get; set; }

        /// <summary>
        /// If the customer negotiated any special terms different from the standard terms above, describe them here.
        /// </summary>
        public string? SpecialTerms { get; set; }

        /// <summary>
        /// The three-character ISO 4217 currency code used for this invoice.
        /// </summary>
        public string? CurrencyCode { get; set; }

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
        public DateTime? InvoiceDate { get; set; }

        /// <summary>
        /// The date when discounts were adjusted for this invoice.
        /// </summary>
        public DateTime? DiscountDate { get; set; }

        /// <summary>
        /// The date when this invoice posted to the company's general ledger.
        /// </summary>
        public DateTime? PostedDate { get; set; }

        /// <summary>
        /// The date when the invoice was closed and finalized after completion of all payments and delivery of all products and
        /// services.
        /// </summary>
        public DateTime? InvoiceClosedDate { get; set; }

        /// <summary>
        /// The date when the remaining outstanding balance is due.
        /// </summary>
        public DateTime? PaymentDueDate { get; set; }

        /// <summary>
        /// The date and time when this record was imported from the user's ERP or accounting system.
        /// </summary>
        public DateTime? ImportedDate { get; set; }

        /// <summary>
        /// The ID number of the invoice's origination address
        /// </summary>
        public Guid? PrimaryOriginAddressId { get; set; }

        /// <summary>
        /// The ID number of the invoice's bill-to address
        /// </summary>
        public Guid? PrimaryBillToAddressId { get; set; }

        /// <summary>
        /// The ID number of the invoice's ship-to address
        /// </summary>
        public Guid? PrimaryShipToAddressId { get; set; }

        /// <summary>
        /// The date on which this address record was created.
        /// </summary>
        public DateTime? Created { get; set; }

        /// <summary>
        /// The ID number of the user who created this address.
        /// </summary>
        public Guid? CreatedUserId { get; set; }

        /// <summary>
        /// The date on which this address record was last modified.
        /// </summary>
        public DateTime? Modified { get; set; }

        /// <summary>
        /// The ID number of the user who most recently modified this address.
        /// </summary>
        public Guid? ModifiedUserId { get; set; }

        /// <summary>
        /// AppEnrollmentId for this record; used for mapping purposes.
        /// </summary>
        public Guid? AppEnrollmentId { get; set; }

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
        /// To retrieve this collection, specify `Addresses` in the "Include" parameter for your query.
        /// </summary>
        public InvoiceAddressModel[]? Addresses { get; set; }

        /// <summary>
        /// All lines attached to this invoice.
        /// To retrieve this collection, specify `Lines` in the "Include" parameter for your query.
        /// </summary>
        public InvoiceLineModel[]? Lines { get; set; }

        /// <summary>
        /// All payments attached to this invoice, the amount of the payment applied to this Invoice, and the date the Payment was applied.
        /// To retrieve this collection, specify `Payments` in the "Include" parameter for your query.
        /// </summary>
        public InvoicePaymentDetailModel[]? Payments { get; set; }

        /// <summary>
        /// All notes attached to this invoice.
        /// To retrieve this collection, specify `Notes` in the "Include" parameter for your query.
        /// </summary>
        public NoteModel[]? Notes { get; set; }

        /// <summary>
        /// All attachments attached to this invoice.
        /// To retrieve this collection, specify `Attachments` in the "Include" parameter for your query.
        /// </summary>
        public AttachmentModel[]? Attachments { get; set; }

        /// <summary>
        /// The Company associated to this invoice.
        /// To retrieve this item, specify `Company` in the "Include" parameter for your query.
        /// </summary>
        public CompanyModel? Company { get; set; }

        /// <summary>
        /// The Customer associated to the invoice customer
        /// To retrieve this item, specify `Customer` in the "Include" parameter for your query.
        /// </summary>
        public CompanyModel? Customer { get; set; }

        /// <summary>
        /// The Contact associated to the invoice customer
        /// To retrieve this item, specify `Customer` in the "Include" parameter for your query.
        /// </summary>
        public ContactModel? CustomerPrimaryContact { get; set; }

        /// <summary>
        /// The credit memos associated to this invoice.
        /// To retrieve this item, specify `CreditMemos` in the "Include" parameter for your query.
        /// </summary>
        public CreditMemoInvoiceModel[]? CreditMemos { get; set; }

        /// <summary>
        /// All custom field values associated with this invoice
        /// To retrieve this item, specify `CustomFieldValues` in the "Include" parameter for your query.
        /// </summary>
        public CustomFieldValueModel[]? CustomFieldValues { get; set; }

        /// <summary>
        /// All custom field definitions
        /// </summary>
        public CustomFieldDefinitionModel[]? CustomFieldDefinitions { get; set; }
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
        public DateTime? ApplyToInvoiceDate { get; set; }

        /// <summary>
        /// Amount applied to Invoice.
        /// </summary>
        public double PaymentAppliedAmount { get; set; }

        /// <summary>
        /// An additional reference code that is sometimes used to identify this Payment.
        /// The meaning of this field is specific to the ERP or accounting system used by the user.
        /// </summary>
        public string? ReferenceCode { get; set; }

        /// <summary>
        /// The ID number of the Company (CompanyType = "Customer") that created this Payment.
        /// </summary>
        public Guid? CompanyId { get; set; }

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
        public Guid? CustomerId { get; set; }

        /// <summary>
        /// The unique ID number of this invoice.
        /// </summary>
        public Guid InvoiceId { get; set; }

        /// <summary>
        /// A reference code that is used to identify this invoice.
        /// The meaning of this field is specific to the ERP or accounting system used by the user.
        /// </summary>
        public string? InvoiceNumber { get; set; }

        /// <summary>
        /// The reporting date for this invoice.
        /// </summary>
        public DateTime? InvoiceDate { get; set; }

        /// <summary>
        /// The name of the counterparty for the invoice, for example, a customer or vendor.
        /// </summary>
        public string? CustomerName { get; set; }

        /// <summary>
        /// The status of the invoice.
        /// </summary>
        public string? Status { get; set; }

        /// <summary>
        /// The due date of the invoice.
        /// </summary>
        public DateTime? PaymentDueDate { get; set; }

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
        public string? InvoiceTypeCode { get; set; }

        /// <summary>
        /// The date stamp for the newest Activity on this Invoice.
        /// </summary>
        public DateTime? NewestActivity { get; set; }

        /// <summary>
        /// The number of days this Invoice is past due.
        /// </summary>
        public int? DaysPastDue { get; set; }

        /// <summary>
        /// The memo text of the payments associated to this invoice.
        /// </summary>
        public string[]? PaymentNumbers { get; set; }

        /// <summary>
        /// The ids of the payments associated to this invoice.
        /// </summary>
        public Guid[]? PaymentIds { get; set; }
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
        /// This is the primary key of the Invoice record. For this field, you should use whatever the invoice's unique
        /// identifying number is in the originating system. Search for a unique, non-changing number within the
        /// originating financial system for this record.
        ///
        /// Example: If you store your invoice records in a database, whatever the primary key for the invoice table is
        /// in the database should be the "ErpKey".
        ///
        /// For more information, see [Identity Columns](https://developer.lockstep.io/docs/identity-columns).
        /// </summary>
        public string? ErpKey { get; set; }

        /// <summary>
        /// The original primary key or unique ID of the company to which this invoice belongs.  This value should
        /// match the [Company ErpKey](https://developer.lockstep.io/docs/importing-companies#erpkey) field on the
        /// [CompanySyncModel](https://developer.lockstep.io/docs/importing-companies).
        ///
        /// An Invoice has two relationships: The Company and the Customer.  The field `CompanyErpKey` identifies the
        /// company that created the invoice, and the field `CustomerErpKey` is the customer to whom the invoice
        /// was sent.
        /// </summary>
        public string? CompanyErpKey { get; set; }

        /// <summary>
        /// The original primary key or unique ID of the company to which this invoice was sent.  This value should
        /// match the [Company ErpKey](https://developer.lockstep.io/docs/importing-companies#erpkey) field on the
        /// [CompanySyncModel](https://developer.lockstep.io/docs/importing-companies).
        ///
        /// An Invoice has two relationships: The Company and the Customer.  The field `CompanyErpKey` identifies the
        /// company that created the invoice, and the field `CustomerErpKey` is the customer to whom the invoice
        /// was sent.
        /// </summary>
        public string? CustomerErpKey { get; set; }

        /// <summary>
        /// The name of the salesperson that wrote this invoice.  This is just text, it is not a reference to the
        /// "Contacts" table.  You will not receive an error if this field does not match a known contact person.
        /// </summary>
        public string? SalespersonName { get; set; }

        /// <summary>
        /// The "Purchase Order Code" is a code that is sometimes used by companies to refer to the original PO
        /// that was sent that caused this invoice to be written.  If a customer sends a purchase order to a vendor,
        /// the vendor can then create an invoice and refer back to the originating purchase order using this field.
        /// </summary>
        public string? PurchaseOrderCode { get; set; }

        /// <summary>
        /// An additional reference code that is sometimes used to identify this invoice. The meaning of this field
        /// is specific to the ERP or accounting system used by the user.
        /// </summary>
        public string? ReferenceCode { get; set; }

        /// <summary>
        /// A code identifying the salesperson responsible for writing this quote, invoice, or order.  This is just
        /// text, it is not a reference to the "Contacts" table.  You will not receive an error if this field does
        /// not match a known contact person.
        /// </summary>
        public string? SalespersonCode { get; set; }

        /// <summary>
        /// A code identifying the type of this invoice.
        ///
        /// Recognized Invoice types are:
        /// * `Invoice` - Represents an invoice sent by Company to the Customer
        /// * `AP Invoice` - Represents an invoice sent by Customer to the Company
        /// * `Credit Memo` - Represents a credit memo generated by Customer given to Company
        /// </summary>
        public string? InvoiceTypeCode { get; set; }

        /// <summary>
        /// A code identifying the status of this invoice.
        ///
        /// Recognized Invoice status codes are:
        /// * `Open` - Represents an invoice that is considered open and needs more work to complete
        /// * `Closed` - Represents an invoice that is considered closed and resolved
        /// </summary>
        public string? InvoiceStatusCode { get; set; }

        /// <summary>
        /// A code identifying the terms given to the purchaser.  This field is imported directly from the originating
        /// financial system and does not follow a specified format.
        /// </summary>
        public string? TermsCode { get; set; }

        /// <summary>
        /// If the customer negotiated any special terms different from the standard terms above, describe them here.
        /// </summary>
        public string? SpecialTerms { get; set; }

        /// <summary>
        /// The three-character ISO 4217 currency code used for this invoice. This will be validated by the /api/v1/currencies data set
        /// </summary>
        public string? CurrencyCode { get; set; }

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
        public DateTime? InvoiceDate { get; set; }

        /// <summary>
        /// The date when discounts were adjusted for this invoice.
        /// </summary>
        public DateTime? DiscountDate { get; set; }

        /// <summary>
        /// The date when this invoice posted to the company's general ledger.
        /// </summary>
        public DateTime? PostedDate { get; set; }

        /// <summary>
        /// The date when the invoice was closed and finalized after completion of all payments and delivery of all products and
        /// services.
        /// </summary>
        public DateTime? InvoiceClosedDate { get; set; }

        /// <summary>
        /// The date when the remaining outstanding balance is due.
        /// </summary>
        public DateTime? PaymentDueDate { get; set; }

        /// <summary>
        /// The date and time when this record was imported from the user's ERP or accounting system.
        /// </summary>
        public DateTime? ImportedDate { get; set; }

        /// <summary>
        /// The origination address for this invoice
        /// </summary>
        public string? OriginAddressLine1 { get; set; }

        /// <summary>
        /// The origination address for this invoice
        /// </summary>
        public string? OriginAddressLine2 { get; set; }

        /// <summary>
        /// The origination address for this invoice
        /// </summary>
        public string? OriginAddressLine3 { get; set; }

        /// <summary>
        /// The origination address for this invoice
        /// </summary>
        public string? OriginAddressCity { get; set; }

        /// <summary>
        /// The origination address for this invoice
        /// </summary>
        public string? OriginAddressRegion { get; set; }

        /// <summary>
        /// The origination address for this invoice
        /// </summary>
        public string? OriginAddressPostalCode { get; set; }

        /// <summary>
        /// The origination address for this invoice This will be validated by the /api/v1/countries data set
        /// </summary>
        public string? OriginAddressCountry { get; set; }

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
        public string? BillToAddressLine1 { get; set; }

        /// <summary>
        /// The billing address for this invoice
        /// </summary>
        public string? BillToAddressLine2 { get; set; }

        /// <summary>
        /// The billing address for this invoice
        /// </summary>
        public string? BillToAddressLine3 { get; set; }

        /// <summary>
        /// The billing address for this invoice
        /// </summary>
        public string? BillToAddressCity { get; set; }

        /// <summary>
        /// The billing address for this invoice
        /// </summary>
        public string? BillToAddressRegion { get; set; }

        /// <summary>
        /// The billing address for this invoice
        /// </summary>
        public string? BillToAddressPostalCode { get; set; }

        /// <summary>
        /// The billing address for this invoice This will be validated by the /api/v1/countries data set
        /// </summary>
        public string? BillToAddressCountry { get; set; }

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
        public string? ShipToAddressLine1 { get; set; }

        /// <summary>
        /// The shipping address for this invoice
        /// </summary>
        public string? ShipToAddressLine2 { get; set; }

        /// <summary>
        /// The shipping address for this invoice
        /// </summary>
        public string? ShipToAddressLine3 { get; set; }

        /// <summary>
        /// The shipping address for this invoice
        /// </summary>
        public string? ShipToAddressCity { get; set; }

        /// <summary>
        /// The shipping address for this invoice
        /// </summary>
        public string? ShipToAddressRegion { get; set; }

        /// <summary>
        /// The shipping address for this invoice
        /// </summary>
        public string? ShipToAddressPostalCode { get; set; }

        /// <summary>
        /// The shipping address for this invoice This will be validated by the /api/v1/countries data set
        /// </summary>
        public string? ShipToAddressCountry { get; set; }

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
        public DateTime? Created { get; set; }

        /// <summary>
        /// If known, the date when this record was most recently modified according to the originating
        /// financial system in which this record is maintained.  If the originating financial system does
        /// not maintain a most-recently-modified-date, leave this field null.
        /// </summary>
        public DateTime? Modified { get; set; }

        /// <summary>
        /// Is the invoice voided?
        /// </summary>
        public bool IsVoided { get; set; }

        /// <summary>
        /// Is the invoice in dispute?
        /// </summary>
        public bool InDispute { get; set; }
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
        public string? Name { get; set; }

        /// <summary>
        /// Name of company of lead
        /// </summary>
        public string? Company { get; set; }

        /// <summary>
        /// Email of lead
        /// </summary>
        public string? Email { get; set; }

        /// <summary>
        /// Requested ERP of lead
        /// </summary>
        public string? ErpSystem { get; set; }
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
        public string? TableKey { get; set; }

        /// <summary>
        /// The ID of the object the note is associated with
        /// </summary>
        public Guid ObjectKey { get; set; }

        /// <summary>
        /// The text of the note
        /// </summary>
        public string? NoteText { get; set; }

        /// <summary>
        /// The type of the note
        /// </summary>
        public string? NoteType { get; set; }

        /// <summary>
        /// Flag indicating if the note has been archived
        /// </summary>
        public bool IsArchived { get; set; }

        /// <summary>
        /// The date the note was created
        /// </summary>
        public DateTime? Created { get; set; }

        /// <summary>
        /// The ID of the user who created the note
        /// </summary>
        public Guid CreatedUserId { get; set; }

        /// <summary>
        /// The name of the user who created the note
        /// </summary>
        public string? CreatedUserName { get; set; }

        /// <summary>
        /// AppEnrollmentId for this record; used for mapping purposes.
        /// </summary>
        public Guid? AppEnrollmentId { get; set; }

        /// <summary>
        /// The person to whom this note is intended for.
        /// </summary>
        public string? RecipientName { get; set; }
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
        public string? ErpKey { get; set; }

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
        /// AppEnrollmentId for this record; used for mapping purposes.
        /// </summary>
        public Guid? AppEnrollmentId { get; set; }

        /// <summary>
        /// The invoice associated with this applied payment.
        /// </summary>
        public InvoiceModel? Invoice { get; set; }
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
        /// transaction's unique identifying number is in the originating system. Search for a unique, non-changing
        /// number within the originating financial system for this record.
        ///
        /// Since Payment Applications are often considered transactions, a typical value to look for will be
        /// the transaction ID number, the payment confirmation number, or some other record of this payment.
        ///
        /// For more information, see [Identity Columns](https://developer.lockstep.io/docs/identity-columns).
        /// </summary>
        public string? ErpKey { get; set; }

        /// <summary>
        /// This field indicates which Invoice had its balance reduced by applying this payment.  In this field,
        /// identify the original primary key or unique ID of the Invoice which had its balance reduced.
        ///
        /// This information lets you track how an invoice was paid. You can identify what proportion of an invoice's
        /// balance was paid by which methods by joining this field to Invoices.
        ///
        /// This value should match the [Invoice ErpKey](https://developer.lockstep.io/docs/importing-invoices#erpkey)
        /// field on the [InvoiceSyncModel](https://developer.lockstep.io/docs/importing-invoices).
        /// </summary>
        public string? InvoiceErpKey { get; set; }

        /// <summary>
        /// This field indicates which Payment was used to provide the funds for this payment application. In this
        /// field, identify the original primary key or unique ID of the Payment that was used for this payment
        /// application.
        ///
        /// This information lets you track how an invoice was paid. You can identify what proportion of an payment's
        /// balance was paid by which methods by joining this field to the Payment.
        ///
        /// This value should match the [Payment ErpKey](https://developer.lockstep.io/docs/importing-payments#erpkey)
        /// field on the [PaymentSyncModel](https://developer.lockstep.io/docs/importing-payments).
        /// </summary>
        public string? PaymentErpKey { get; set; }

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
        public DateTime? Created { get; set; }

        /// <summary>
        /// If known, the date when this record was most recently modified according to the originating
        /// financial system in which this record is maintained.  If the originating financial system does
        /// not maintain a most-recently-modified-date, leave this field null.
        /// </summary>
        public DateTime? Modified { get; set; }
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
        public string? CustomerName { get; set; }

        /// <summary>
        /// Memo or reference text (ex. memo field on a check).
        /// </summary>
        public string? MemoText { get; set; }

        /// <summary>
        /// Reference code for the payment for the given Erp system.
        /// </summary>
        public string? ReferenceCode { get; set; }

        /// <summary>
        /// The name of the Primary Contact for the Customer.
        /// </summary>
        public string? PrimaryContact { get; set; }

        /// <summary>
        /// The Email address of the Customer.
        /// </summary>
        public string? Email { get; set; }

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
        public string? PaymentType { get; set; }

        /// <summary>
        /// The date of this Payment.
        /// </summary>
        public DateTime? PaymentDate { get; set; }

        /// <summary>
        /// Payment post date.
        /// </summary>
        public DateTime? PostDate { get; set; }

        /// <summary>
        /// The phone number of the Customer's Primary Contact.
        /// </summary>
        public string? Phone { get; set; }

        /// <summary>
        /// The fax number of the Customer's Primary Contact.
        /// </summary>
        public string? Fax { get; set; }

        /// <summary>
        /// The first line of the address for the Customer's Primary Contact.
        /// </summary>
        public string? Address1 { get; set; }

        /// <summary>
        /// The second line of the address for the Customer's Primary Contact.
        /// </summary>
        public string? Address2 { get; set; }

        /// <summary>
        /// The third line of the address for the Customer's Primary Contact.
        /// </summary>
        public string? Address3 { get; set; }

        /// <summary>
        /// The city of the address for the Customer's Primary Contact.
        /// </summary>
        public string? City { get; set; }

        /// <summary>
        /// The state/region of the address for the Customer's Primary Contact.
        /// </summary>
        public string? StateRegion { get; set; }

        /// <summary>
        /// The postal/zip code of the address for the Customer's Primary Contact.
        /// </summary>
        public string? PostalCode { get; set; }

        /// <summary>
        /// The 2 character country code of the address for the Customer's Primary Contact.
        /// </summary>
        public string? CountryCode { get; set; }
    }

    /// <summary>
    /// A Payment represents money sent from one company to another.  A single payment may contain payments for
    /// one or more invoices; it is also possible for payments to be made in advance of an invoice, for example,
    /// as a deposit.  The creator of the Payment is identified by the `CustomerId` field, and the recipient of
    /// the Payment is identified by the `CompanyId` field.  Most Payments are uniquely identified both by a
    /// Lockstep Platform ID number and a customer ERP "key" that was generated by the system that originated
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
        public string? ErpKey { get; set; }

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
        public string? MemoText { get; set; }

        /// <summary>
        /// The date when this payment was received.  This typically is the date when an accounting employee recorded
        /// that they received notification that the payment had occurred, whether they were notified by email, postal
        /// mail, or financial transaction notification.
        /// </summary>
        public DateTime PaymentDate { get; set; }

        /// <summary>
        /// The date when a payment was posted to a ledger.  This date is often determined by a company's accounting
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
        public string? CurrencyCode { get; set; }

        /// <summary>
        /// Reference code for the payment for the given Erp system.
        /// </summary>
        public string? ReferenceCode { get; set; }

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
        /// AppEnrollmentId for this record; used for mapping purposes.
        /// </summary>
        public Guid? AppEnrollmentId { get; set; }

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
        /// To retrieve this collection, specify `Applications` in the "Include" parameter for your query.
        /// </summary>
        public PaymentAppliedModel[]? Applications { get; set; }

        /// <summary>
        /// All notes attached to this payment.
        /// To retrieve this collection, specify `Notes` in the "Include" parameter for your query.
        /// </summary>
        public NoteModel[]? Notes { get; set; }

        /// <summary>
        /// All attachments attached to this payment.
        /// To retrieve this collection, specify `Attachments` in the "Include" parameter for your query.
        /// </summary>
        public AttachmentModel[]? Attachments { get; set; }

        /// <summary>
        /// All definitions attached to this payment.
        /// To retrieve this collection, specify `CustomFieldValues` in the "Include" parameter for your query.
        /// </summary>
        public CustomFieldDefinitionModel[]? CustomFieldDefinitions { get; set; }

        /// <summary>
        /// All values attached to this payment.
        /// To retrieve this collection, specify `CustomFieldValues` in the "Include" parameter for your query.
        /// </summary>
        public CustomFieldValueModel[]? CustomFieldValues { get; set; }
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
        public string? MemoText { get; set; }

        /// <summary>
        /// Reference code for the payment for the given Erp system.
        /// </summary>
        public string? ReferenceCode { get; set; }

        /// <summary>
        /// The type of payment, Payment or AP Payment.
        /// </summary>
        public string? PaymentType { get; set; }

        /// <summary>
        /// The date of this payment.
        /// </summary>
        public DateTime? PaymentDate { get; set; }

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
        public string[]? InvoiceList { get; set; }

        /// <summary>
        /// The ids of the invoices associated to this payment.
        /// </summary>
        public Guid[]? InvoiceIdList { get; set; }

        /// <summary>
        /// The name of the customer for this payment.
        /// </summary>
        public string? CustomerName { get; set; }

        /// <summary>
        /// The id of the customer for this payment.
        /// </summary>
        public Guid? CustomerId { get; set; }
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
        /// This is the primary key of the Payment record. For this field, you should use whatever the payment's unique
        /// identifying number is in the originating system. Search for a unique, non-changing number within the
        /// originating financial system for this record.
        ///
        /// Example: If you store your payment records in a database, whatever the primary key for the payment table is
        /// in the database should be the "ErpKey".
        ///
        /// For more information, see [Identity Columns](https://developer.lockstep.io/docs/identity-columns).
        /// </summary>
        public string? ErpKey { get; set; }

        /// <summary>
        /// The original primary key or unique ID of the company to which this payment belongs.  This value should
        /// match the [Company ErpKey](https://developer.lockstep.io/docs/importing-companies#erpkey) field on the
        /// [CompanySyncModel](https://developer.lockstep.io/docs/importing-companies).
        /// </summary>
        public string? CompanyErpKey { get; set; }

        /// <summary>
        /// The type of payment, cash or check.
        ///
        /// Recognized PaymentType values are:
        /// * `Cash` - A cash payment or other direct transfer.
        /// * `Check` - A check payment.
        /// </summary>
        public string? PaymentType { get; set; }

        /// <summary>
        /// Cash, check, credit card, wire transfer.
        ///
        /// Recognized TenderType values are:
        /// * `Cash` - A cash payment or other direct transfer.
        /// * `Check` - A check payment.
        /// * `Credit Card` - A payment made via a credit card.
        /// * `Wire Transfer` - A payment made via wire transfer from another financial institution.
        /// </summary>
        public string? TenderType { get; set; }

        /// <summary>
        /// True if this payment includes some unassigned amount that has not yet been applied to an invoice.  If this
        /// value is true, the field `UnappliedAmount` will be nonzero.
        /// </summary>
        public bool IsOpen { get; set; }

        /// <summary>
        /// Memo or reference text (ex. memo field on a check).
        /// </summary>
        public string? MemoText { get; set; }

        /// <summary>
        /// The date when this payment was received.  This typically is the date when an accounting employee recorded
        /// that they received notification that the payment had occurred, whether they were notified by email, postal
        /// mail, or financial transaction notification.
        /// </summary>
        public DateTime PaymentDate { get; set; }

        /// <summary>
        /// The date when a payment was posted to a ledger.  This date is often determined by a company's accounting
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
        public string? CurrencyCode { get; set; }

        /// <summary>
        /// If known, the date when this record was created according to the originating financial system
        /// in which this record is maintained.  If the originating financial system does not maintain a
        /// created-date, leave this field null.
        /// </summary>
        public DateTime? Created { get; set; }

        /// <summary>
        /// If known, the date when this record was most recently modified according to the originating
        /// financial system in which this record is maintained.  If the originating financial system does
        /// not maintain a most-recently-modified-date, leave this field null.
        /// </summary>
        public DateTime? Modified { get; set; }

        /// <summary>
        /// A reference code for the payment for the given financial or ERP system.  This can be any value that the
        /// originating system uses to designate the payment, such as a confirmation number or tracking number, that
        /// is different from the `ErpKey` value.
        /// </summary>
        public string? ReferenceCode { get; set; }

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
        public string? TimeZone { get; set; }

        /// <summary>
        /// The default currency of the user
        /// </summary>
        public string? DefaultCurrency { get; set; }

        /// <summary>
        /// The company information for the user and group
        /// </summary>
        public CompanyModel? Company { get; set; }

        /// <summary>
        /// Optional connector information needed to enroll user to their email connector
        /// </summary>
        public ErpInfoModel? EmailConnector { get; set; }
    }

    /// <summary>
    /// Represents the data sent during the onboarding flow
    /// </summary>
    public class ProvisioningModel
    {

        /// <summary>
        /// The full name of the new user
        /// </summary>
        public string? FullName { get; set; }

        /// <summary>
        /// The information necessary to enroll the user in their ERP
        /// </summary>
        public ErpInfoModel? Erp { get; set; }
    }

    /// <summary>
    /// Represents the response to either a successful or failed account provisioning
    /// </summary>
    public class ProvisioningResponseModel
    {

        /// <summary>
        /// If provisioning is successful, contains the username of the created user.
        /// </summary>
        public string? UserName { get; set; }

        /// <summary>
        /// If provisioning is successful, contains subscription account name of created user.
        /// </summary>
        public string? AccountName { get; set; }

        /// <summary>
        /// If provisioning is successful, contains the unique identifier of the created user.
        /// </summary>
        public Guid? UserId { get; set; }

        /// <summary>
        /// If provisioning is successful, contains the group key of the created user.
        /// </summary>
        public Guid? GroupKey { get; set; }

        /// <summary>
        /// If provisioning is successful, contains the app enrollment id of the created app enrollment.
        /// </summary>
        public Guid? AppEnrollmentId { get; set; }

        /// <summary>
        /// if provisioning is successful, contains the sync request id of the sync that was started for the app enrollment.
        /// </summary>
        public Guid? SyncRequestId { get; set; }

        /// <summary>
        /// The error message(s).
        /// </summary>
        public string? ErrorMessage { get; set; }
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
        public string? InvoiceMonthName { get; set; }

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
        public string? Name { get; set; }

        /// <summary>
        /// 2 letter alphabetic code for the given state
        /// </summary>
        public string? Alpha2 { get; set; }

        /// <summary>
        /// A different name for a state
        /// </summary>
        public string? Aliases { get; set; }
    }

    /// <summary>
    /// Represents the status of a user's credentials
    /// </summary>
    public class StatusModel
    {

        /// <summary>
        /// If authentication is successful, contains the username of the logged-in user.
        /// </summary>
        public string? UserName { get; set; }

        /// <summary>
        /// If authentication is successful, contains subscription account name of logged-in user.
        /// </summary>
        public string? AccountName { get; set; }

        /// <summary>
        /// If authentication is successful, contains subscription account company id of logged-in user.
        /// </summary>
        public Guid? AccountCompanyId { get; set; }

        /// <summary>
        /// If authentication is successful, contains the unique identifier of the logged-in user.
        /// </summary>
        public Guid? UserId { get; set; }

        /// <summary>
        /// If authentication is successful, contains the group key of the logged-in user.
        /// </summary>
        public Guid? GroupKey { get; set; }

        /// <summary>
        /// Returns true if authentication for this API was successful.
        /// </summary>
        public bool LoggedIn { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// The set of roles for this user.
        /// </summary>
        public string[]? Roles { get; set; }

        /// <summary>
        /// Date and time user has last logged into Azure B2C.
        /// </summary>
        public DateTime? LastLoggedIn { get; set; }

        /// <summary>
        /// The id of the API key used to authenticate.
        /// </summary>
        public Guid? ApiKeyId { get; set; }

        /// <summary>
        /// If authentication is successful, contains the user status of the logged-in user.
        /// </summary>
        public string? UserStatus { get; set; }

        /// <summary>
        /// The environment currently being used
        /// </summary>
        public string? Environment { get; set; }

        /// <summary>
        /// The version currently being used
        /// </summary>
        public string? Version { get; set; }

        /// <summary>
        /// Statuses for the dependencies of this api.
        /// OK if the dependency is working.
        /// </summary>
        public object? Dependencies { get; set; }
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
        public object? Errors { get; set; }
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
        public string? StatusCode { get; set; }

        /// <summary>
        /// Message containing information about the sync request results
        /// </summary>
        public string? ProcessResultMessage { get; set; }

        /// <summary>
        /// App enrollment sync request is for
        /// </summary>
        public Guid? AppEnrollmentId { get; set; }

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
        /// field if the SyncRequest's `StatusCode` field is set to `Cancelled`, `Success`, or `Failed`.
        ///
        /// To retrieve this collection, add the keyword `details` to the `include` parameter on your Retrieve or
        /// Query requests.
        /// </summary>
        public object? Details { get; set; }
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
        public UserAccountModel? PreviousOwner { get; set; }

        /// <summary>
        /// The new owner of the account.
        /// </summary>
        public UserAccountModel? NewOwner { get; set; }
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
    /// Represents a Uri for download link
    /// </summary>
    public class UriModel
    {

        /// <summary>
        /// Represents the download link
        /// </summary>
        public Uri? DownloadLink { get; set; }
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
        /// This record provides a link to the user's Azure AD B2C OID.
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
        /// The status of the user's account
        /// </summary>
        public string? Status { get; set; }

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
        public string? ModifiedUserName { get; set; }

        /// <summary>
        /// The ID of the user in Azure B2C
        /// </summary>
        public Guid? B2CUserId { get; set; }

        /// <summary>
        /// The id of the Permission Level for the user.
        /// </summary>
        public Guid UserRole { get; set; }

        /// <summary>
        /// The date timestamp when the invite was sent to the user.
        /// </summary>
        public DateTime? InviteSent { get; set; }

        /// <summary>
        /// The phone number of the user.
        /// </summary>
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// The fax number of the user.
        /// </summary>
        public string? FaxNumber { get; set; }

        /// <summary>
        /// The title of the user; free text field
        /// </summary>
        public string? Title { get; set; }

        /// <summary>
        /// FK to the CodeDefinition table; CodeType = 'AccountingRole'
        /// </summary>
        public Guid? AccountingRoleCodeDefId { get; set; }

        /// <summary>
        /// Address Line 1 for this User
        /// </summary>
        public string? Address1 { get; set; }

        /// <summary>
        /// Address Line 2 for this User
        /// </summary>
        public string? Address2 { get; set; }

        /// <summary>
        /// Address Line 3 for this User
        /// </summary>
        public string? Address3 { get; set; }

        /// <summary>
        /// City for this User
        /// </summary>
        public string? City { get; set; }

        /// <summary>
        /// Region ("state" in the US) for this User
        /// </summary>
        public string? StateRegion { get; set; }

        /// <summary>
        /// Postal Code this User
        /// </summary>
        public string? PostalCode { get; set; }

        /// <summary>
        /// Country for this User This will be validated by the /api/v1/countries data set
        /// </summary>
        public string? Country { get; set; }

        /// <summary>
        /// Image URL for this User
        /// </summary>
        public string? ImageURL { get; set; }

        /// <summary>
        /// Description for this User.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Last date time user logged into Azure B2C.
        /// </summary>
        public DateTime? B2CLastLoggedIn { get; set; }

        /// <summary>
        /// The default currency code used by this user entity.  This value can be overridden
        /// for invoices in a different currency code.
        ///
        /// For a list of defined currency codes, see [Query Currencies](https://developer.lockstep.io/reference/get_api-v1-definitions-currencies) This will be validated by the /api/v1/currencies data set
        /// </summary>
        public string? DefaultCurrencyCode { get; set; }

        /// <summary>
        /// All notes attached to this User.
        /// To retrieve this collection, specify `Notes` in the "Include" parameter for your query.
        /// </summary>
        public NoteModel[]? Notes { get; set; }

        /// <summary>
        /// All attachments attached to this User.
        /// To retrieve this collection, specify `Attachments` in the "Include" parameter for your query.
        /// </summary>
        public AttachmentModel[]? Attachments { get; set; }

        /// <summary>
        /// All values attached to this User.
        /// To retrieve this collection, specify `CustomFieldValues` in the "Include" parameter for your query.
        /// </summary>
        public CustomFieldValueModel[]? CustomFieldValues { get; set; }

        /// <summary>
        /// Accounting role definition for this User.
        /// To retrieve this collection, specify `AccountingRole` in the "Include" parameter for your query.
        /// </summary>
        public CodeDefinitionModel? AccountingRoleCodeDefinition { get; set; }
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
        public string? StatusCode { get; set; }

        /// <summary>
        /// When the StatusCode is set to Errored a message is supplied for why it was errored.
        /// </summary>
        public string? StatusMessage { get; set; }

        /// <summary>
        /// An secret set during webhook creation that can be used to verify that the notification
        /// is coming from the Lockstep API.
        /// </summary>
        public string? ClientSecret { get; set; }

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
        /// set in the CallbackHttpMethod property with a query parameter of "code" set to an encoded
        /// string. To successfully create the webhook, the call must return a successful status code
        /// with the query parameter's value as the plain text content.
        /// </summary>
        public Uri CallbackUrl { get; set; }

        /// <summary>
        /// The expiration date for the given webhook subscription. Once the expiration date passes,
        /// notifications will no longer be sent to the callback url.
        /// </summary>
        public DateTime? ExpirationDate { get; set; }

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
    }
}
